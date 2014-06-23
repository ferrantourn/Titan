using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Collections;
using System.Web.Security;
using System.Text;
using System.Xml.Linq;

namespace TitanWeb
{
    public class Persistencia
    {
        string Llave = "Titan"; //esta es la llave para unprotect y protect, cambiar de tanto en tanto

        public void GuardarHTML(string HTMLText, string rutaArchivo)
        {
                File.WriteAllText(rutaArchivo, HTMLText);
        }

        public void GuardarJPG(string rutaArchivoHTML, string rutaArchivoJPG)
        {
            WebJPG websiteToImage = new WebJPG(rutaArchivoHTML, rutaArchivoJPG);
            websiteToImage.Generate();
        }

        public void GuardarUsuario(string NombreUsuario, string Password)
        {
            var NombrePlano = Encoding.UTF8.GetBytes(NombreUsuario);
            var NombreEncryptado = Convert.ToBase64String(MachineKey.Protect(NombrePlano, Llave));
            var PasswordPlano = Encoding.UTF8.GetBytes(Password);
            var PasswordEncryptado = Convert.ToBase64String(MachineKey.Protect(PasswordPlano, Llave));

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            XmlWriter writer = XmlWriter.Create(HttpContext.Current.Server.MapPath("~/data.data"), settings);

            writer.WriteStartDocument();
            writer.WriteComment("Generado por Titan.");
            writer.WriteStartElement("Usuario");
            writer.WriteAttributeString("Nombre", NombreEncryptado);
            writer.WriteAttributeString("Pass", PasswordEncryptado);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
 
        }

        public bool GuardarUsuarioNew(string NombreUsuario, string Password)
        {
            var NombrePlano = Encoding.UTF8.GetBytes(NombreUsuario);
            var NombreEncriptado = Convert.ToBase64String(MachineKey.Protect(NombrePlano, Llave));
            var PasswordPlano = Encoding.UTF8.GetBytes(Password);
            var PasswordEncriptado = Convert.ToBase64String(MachineKey.Protect(PasswordPlano, Llave));

            if (!File.Exists(HttpContext.Current.Server.MapPath("~/data.data")))
            {
            XDocument xDoc = new XDocument(
            new XElement("Usuarios",
                new XElement("Usuario",
                    new XElement("Nombre", NombreEncriptado),
                    new XElement("Password", PasswordEncriptado))));

            StringWriter sw = new StringWriter();
            XmlWriter xWrite = XmlWriter.Create(sw);
            xDoc.Save(xWrite);
            xWrite.Close();
            xDoc.Save(HttpContext.Current.Server.MapPath("~/data.data"));
            return true;

            }
            else //si existe el archivo, busco en él si ya existe el usuario, y si no existe lo agrego
            {
                XElement xelement = XElement.Load(HttpContext.Current.Server.MapPath("~/data.data"));
                IEnumerable<XElement> usuarios = xelement.Elements();
                foreach (var usuario in usuarios)
                {
                    string NombreActualEncriptado = usuario.Element("Nombre").Value;
                    var NombreActualBytes = Convert.FromBase64String(NombreActualEncriptado);
                    var NombreActualPlano = MachineKey.Unprotect(NombreActualBytes, Llave);
                    string NombreActualStr = Encoding.UTF8.GetString(NombreActualPlano);

                    if (NombreActualStr == NombreUsuario)
                    {
                        return false;
                    }

                }
                
                XElement xEle = XElement.Load(HttpContext.Current.Server.MapPath("~/data.data"));
                xEle.Add(new XElement("Usuario",
                    new XElement("Nombre", NombreEncriptado),
                    new XElement("Password", PasswordEncriptado)));
                    xEle.Save(HttpContext.Current.Server.MapPath("~/data.data"));
                return true;
            }
        }
        public bool GuardarUsuarioNewNoEnc(string NombreUsuario, string Password)
        {
            if (!File.Exists(HttpContext.Current.Server.MapPath("~/data.data")))
            {
                XDocument xDoc = new XDocument(
                new XElement("Usuarios",
                    new XElement("Usuario",
                        new XElement("Nombre", NombreUsuario),
                        new XElement("Password", Password))));

                StringWriter sw = new StringWriter();
                XmlWriter xWrite = XmlWriter.Create(sw);
                xDoc.Save(xWrite);
                xWrite.Close();
                xDoc.Save(HttpContext.Current.Server.MapPath("~/data.data"));
                return true;

            }
            else //si existe el archivo, busco en él si ya existe el usuario, y si no existe lo agrego
            {
                XElement xelement = XElement.Load(HttpContext.Current.Server.MapPath("~/data.data"));
                IEnumerable<XElement> usuarios = xelement.Elements();
                foreach (var usuario in usuarios)
                {
                    string NombreActual = usuario.Element("Nombre").Value;

                    if (NombreActual == NombreUsuario)
                    {
                        return false;
                    }

                }

                XElement xEle = XElement.Load(HttpContext.Current.Server.MapPath("~/data.data"));
                xEle.Add(new XElement("Usuario",
                    new XElement("Nombre", NombreUsuario),
                    new XElement("Password", Password)));
                xEle.Save(HttpContext.Current.Server.MapPath("~/data.data"));
                return true;
            }
        }

        public bool LoginUsuario(string NombreUsuario, string Password)
        {
            try
            {
                XmlReader reader = XmlReader.Create(HttpContext.Current.Server.MapPath("~/data.data"));
                while (reader.Read())
                {

                    if (reader.NodeType == XmlNodeType.Element
                    && reader.Name == "Usuario")
                    {
                        string NombreEncriptado = reader.GetAttribute(0);
                        var NombreBytes = Convert.FromBase64String(NombreEncriptado);
                        var NombrePlano = MachineKey.Unprotect(NombreBytes, Llave);
                        string NombreStr = Encoding.UTF8.GetString(NombrePlano);

                        if (NombreStr == NombreUsuario) //Nos combiene desencriptar el password solo si encontramos nombre de usuario
                        {
                            string PasswordEncriptado = reader.GetAttribute(1);
                            var PasswordBytes = Convert.FromBase64String(PasswordEncriptado);
                            var PasswordPlano = MachineKey.Unprotect(PasswordBytes, Llave);
                            string PasswordStr = Encoding.UTF8.GetString(PasswordPlano);

                            if (PasswordStr == Password)
                            {
                                return true; //login true, nombre y pass correctos
                            }

                            return false; //aqui el usuario coincide pero el password que ingresó no es correcto
                        }
                    } //end if
                } //end while

                return false;//si no se encontró ningun usuario que coincida con Nombre
            }
            catch
            {
                
            }

            return false;
        }

        public bool LoginUsuarioNew(string NombreUsuario, string Password)
        {
            try
            {
                XElement xelement = XElement.Load(HttpContext.Current.Server.MapPath("~/data.data"));
                IEnumerable<XElement> usuarios = xelement.Elements();
                foreach (var usuario in usuarios)
                {
                    string NombreEncriptado = usuario.Element("Nombre").Value;
                    var NombreBytes = Convert.FromBase64String(NombreEncriptado);
                    var NombrePlano = MachineKey.Unprotect(NombreBytes, Llave);
                    string NombreStr = Encoding.UTF8.GetString(NombrePlano);

                    if (NombreStr == NombreUsuario)
                    {
                        string PasswordEncriptado = usuario.Element("Password").Value;
                        var PasswordBytes = Convert.FromBase64String(PasswordEncriptado);
                        var PasswordPlano = MachineKey.Unprotect(PasswordBytes, Llave);
                        string PasswordStr = Encoding.UTF8.GetString(PasswordPlano);

                        if (Password == PasswordStr)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                LogicaErrores.GuardarError("Error, no se encontró usuario", DateTime.Now);
                return false;
            }
            catch (Exception ex)
            {
                LogicaErrores.GuardarError(ex.Message, DateTime.Now);
            }
            LogicaErrores.GuardarError("Error, no se encontró usuario", DateTime.Now);
            return false;
        }

        public bool LoginUsuarioNewNoEnc(string NombreUsuario, string Password)
        {
            try
            {
                XElement xelement = XElement.Load(HttpContext.Current.Server.MapPath("~/data.data"));
                IEnumerable<XElement> usuarios = xelement.Elements();
                foreach (var usuario in usuarios)
                {
                    string NombreActual = usuario.Element("Nombre").Value;

                    if (NombreActual == NombreUsuario)
                    {
                        string PasswordActual = usuario.Element("Password").Value;

                        if (Password == PasswordActual)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                LogicaErrores.GuardarError("Error, no se encontró usuario", DateTime.Now);
                return false;
            }
            catch (Exception ex)
            {
                LogicaErrores.GuardarError(ex.Message, DateTime.Now);
            }
            LogicaErrores.GuardarError("Error, no se encontró usuario", DateTime.Now);
            return false;
        }

        public void GuardarProyectoLeblon(string nombre, LeblonContainer c)
        {
            try
            {
                string origen = HttpContext.Current.Server.MapPath("~/UploadedImages");
                string destino = HttpContext.Current.Server.MapPath("~/") + nombre;
                Directory.CreateDirectory(destino);
                foreach (var file in new DirectoryInfo(origen).GetFiles())
                {
                    file.CopyTo(Path.Combine(destino, file.Name),true);
                }

                string sTitulo = c.STitulo;
                string sCuadro1 = c.SCuadroMultiLine1;
                string sCuadro2 = c.SCuadroMultiLine2;
                string sDescripcionMultiLine = c.SDescripcionMultiLine;
                string sPrecio = c.SPrecio;

                
                Uri Foto1 = new Uri(destino + "/" + Path.GetFileName(c.SFoto1.ToString()));
                Uri Foto2 = new Uri(destino + "/" + Path.GetFileName(c.SFoto2.ToString()));
                Uri Foto3 = new Uri(destino + "/" + Path.GetFileName(c.SFoto3.ToString()));
                Uri Foto4 = new Uri(destino + "/" + Path.GetFileName(c.SFoto4.ToString()));
                Uri FondoPlantilla = new Uri(destino + "/" + Path.GetFileName(c.SFondoPlantilla.ToString()));
                
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                if (File.Exists(HttpContext.Current.Server.MapPath("~/") + nombre + ".titan"))
                {
                    File.Delete(HttpContext.Current.Server.MapPath("~/") + nombre + ".titan");
                }

                XmlWriter writer = XmlWriter.Create(HttpContext.Current.Server.MapPath("~/") + nombre + ".titan", settings);

                writer.WriteStartDocument();
                writer.WriteComment("Generado por Titan.");
                writer.WriteStartElement("Producto");
                writer.WriteAttributeString("Foto1", Foto1.ToString());
                writer.WriteAttributeString("Foto2", Foto2.ToString());
                writer.WriteAttributeString("Foto3", Foto3.ToString());
                writer.WriteAttributeString("Foto4", Foto4.ToString());
                writer.WriteAttributeString("Fondo", FondoPlantilla.ToString());
                writer.WriteAttributeString("Titulo", sTitulo);
                writer.WriteAttributeString("Cuadro1", sCuadro1);
                writer.WriteAttributeString("Cuadro2", sCuadro2);
                writer.WriteAttributeString("Descripcion", sDescripcionMultiLine);
                writer.WriteAttributeString("Precio", sPrecio);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
            catch
            {
                
            }
        }

        public ArrayList ListadoArchivosTitan() 
        //devuelve un arraylist con todos los archivos titan en la raiz de la página
        {
            ArrayList a = new ArrayList();
            DirectoryInfo d = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/"));
            FileInfo[] fileArray = d.GetFiles("*.titan",SearchOption.TopDirectoryOnly);
            foreach(FileInfo f in fileArray)
            {
                a.Add(f.Name.ToString());
            }
            return a;
        }

        public void AbrirProyectoVacio(LeblonContainer c)
        {
            c.SFondoPlantilla = new Uri(HttpContext.Current.Server.MapPath("~/UploadedImages/Fondo.png"));
            c.SFoto1 = new Uri(HttpContext.Current.Server.MapPath("~/UploadedImages/Foto1.png"));
            c.SFoto2 = new Uri(HttpContext.Current.Server.MapPath("~/UploadedImages/Foto2.png"));
            c.SFoto3 = new Uri(HttpContext.Current.Server.MapPath("~/UploadedImages/Foto3.png"));
            c.SFoto4 = new Uri(HttpContext.Current.Server.MapPath("~/UploadedImages/Foto4.png"));
        }

        public void AbrirProyectoLeblon(string nombre, LeblonContainer c)
        {
            
            string origen = HttpContext.Current.Server.MapPath("~/") + Path.GetFileNameWithoutExtension(nombre);
            string destino = HttpContext.Current.Server.MapPath("~/UploadedImages");
            string archivo = HttpContext.Current.Server.MapPath("~/") + nombre;

            foreach (FileInfo f in new DirectoryInfo(HttpContext.Current.Server.MapPath("UploadedImages/")).GetFiles("*.*"))
            {
                f.Delete();
            }

            foreach (FileInfo f in new DirectoryInfo(HttpContext.Current.Server.MapPath("~/" + Path.GetFileNameWithoutExtension(nombre))).GetFiles("*.*"))
            {
                f.CopyTo(Path.Combine(destino, f.Name), true);//true para overwrite
            }

            XmlReader reader = XmlReader.Create(archivo);
            try
            {
                while (reader.Read())
                {

                    if (reader.NodeType == XmlNodeType.Element
                    && reader.Name == "Producto")
                    {
                        c.SFoto1 = new Uri(destino + "/" + Path.GetFileName(reader.GetAttribute(0)));
                        c.SFoto2 = new Uri(destino + "/" + Path.GetFileName(reader.GetAttribute(1)));
                        c.SFoto3 = new Uri(destino + "/" + Path.GetFileName(reader.GetAttribute(2)));
                        c.SFoto4 = new Uri(destino + "/" + Path.GetFileName(reader.GetAttribute(3)));
                        c.SFondoPlantilla = new Uri(destino + "/" + Path.GetFileName(reader.GetAttribute(4)));
                        
                        c.STitulo = reader.GetAttribute(5);
                        c.SCuadroMultiLine1 = reader.GetAttribute(6);
                        c.SCuadroMultiLine2 = reader.GetAttribute(7);
                        c.SDescripcionMultiLine = reader.GetAttribute(8);
                        c.SPrecio = reader.GetAttribute(9);

                    } //end if
                } //end while
            }
            catch
            {
 
            }
            
        }
    }
}