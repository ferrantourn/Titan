using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace TitanWeb
{
    public class Persistencia
    {
        public void GuardarHTML(string HTMLText, string rutaArchivo)
        {
                File.WriteAllText(rutaArchivo, HTMLText);
        }

        public void GuardarJPG(string rutaArchivoHTML, string rutaArchivoJPG)
        {
            WebJPG websiteToImage = new WebJPG(rutaArchivoHTML, rutaArchivoJPG);
            websiteToImage.Generate();
        }

        public void GuardarProyectoAutolider(string nombre, AutoliderContainer c)
        {
            try
            {
                string origen = HttpContext.Current.Server.MapPath("~/UploadedImages");
                string destino = HttpContext.Current.Server.MapPath("~/") + nombre;
                Directory.CreateDirectory(destino);
                foreach (var file in new DirectoryInfo(origen).GetFiles())
                {
                    file.CopyTo(Path.Combine(destino, file.Name));
                }

                string sMarca = c.SMarca;
                string sModelo = c.SModelo;
                string sCilindrada = c.SCilindrada;
                string sMotor = c.SMotor;
                string sPrecio = c.SPrecio;
                string sDescripcionMultiLine = c.SDescripcionMultiLine;
                Uri Foto1 = new Uri(destino + "/" + Path.GetFileName(c.SFoto1.ToString()));
                Uri Foto2 = new Uri(destino + "/" + Path.GetFileName(c.SFoto2.ToString()));
                Uri Foto3 = new Uri(destino + "/" + Path.GetFileName(c.SFoto3.ToString()));
                Uri Foto4 = new Uri(destino + "/" + Path.GetFileName(c.SFoto4.ToString()));
                Uri FondoPrecio = new Uri(destino + "/" + Path.GetFileName(c.SFondoPrecio.ToString()));
                Uri FondoPlantilla = new Uri(destino + "/" + Path.GetFileName(c.SFondoPlantilla.ToString()));
                Uri Logo = new Uri(destino + "/" + Path.GetFileName(c.SLogo.ToString()));
                
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                XmlWriter writer = XmlWriter.Create(HttpContext.Current.Server.MapPath("~/") + nombre + ".titan", settings);

                writer.WriteStartDocument();
                writer.WriteComment("Generado por Titan.");
                writer.WriteStartElement("Producto");
                writer.WriteAttributeString("Foto1", Foto1.ToString());
                writer.WriteAttributeString("Foto2", Foto2.ToString());
                writer.WriteAttributeString("Foto3", Foto3.ToString());
                writer.WriteAttributeString("Foto4", Foto4.ToString());
                writer.WriteAttributeString("Logo", Logo.ToString());
                writer.WriteAttributeString("FondoPrecio", FondoPrecio.ToString());
                writer.WriteAttributeString("Fondo", FondoPlantilla.ToString());
                writer.WriteAttributeString("Cilindrada", sCilindrada);
                writer.WriteAttributeString("Modelo", sModelo);
                writer.WriteAttributeString("Motor", sMotor);
                writer.WriteAttributeString("Descripcion", sDescripcionMultiLine);
                writer.WriteAttributeString("Precio", sPrecio);
                writer.WriteAttributeString("Marca", sMarca);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
            catch
            {
                
            }
        }

        public void AbrirProyectoAutolider(string nombre, AutoliderContainer c)
        {
            
            string origen = HttpContext.Current.Server.MapPath("~/") + nombre;
            string destino = HttpContext.Current.Server.MapPath("~/UploadedImages");
            string archivo = HttpContext.Current.Server.MapPath("~/") + nombre + ".titan";

            //copio todo a la carpeta de trabajo "UploadedImages"
            foreach (var file in new DirectoryInfo(origen).GetFiles())
            {
                file.CopyTo(Path.Combine(destino, file.Name), true);
            }

            XmlReader reader = XmlReader.Create(archivo);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element
                && reader.Name == "Producto")
                {
                    c.SFoto1 = new Uri(destino + "/" + Path.GetFileName(reader.GetAttribute(0)));
                    c.SFoto2 = new Uri(destino + "/" + Path.GetFileName(reader.GetAttribute(1)));
                    c.SFoto3 = new Uri(destino + "/" + Path.GetFileName(reader.GetAttribute(2)));
                    c.SFoto4 = new Uri(destino + "/" + Path.GetFileName(reader.GetAttribute(3)));
                    c.SLogo = new Uri(destino + "/" + Path.GetFileName(reader.GetAttribute(4)));
                    c.SFondoPrecio = new Uri(destino + "/" + Path.GetFileName(reader.GetAttribute(5)));
                    c.SFondoPlantilla = new Uri(destino + "/" + Path.GetFileName(reader.GetAttribute(6)));
                    c.SCilindrada = reader.GetAttribute(7);
                    c.SModelo = reader.GetAttribute(8);
                    c.SMotor = reader.GetAttribute(9);
                    c.SDescripcionMultiLine = reader.GetAttribute(10);
                    c.SPrecio = reader.GetAttribute(11);
                    c.SMarca = reader.GetAttribute(12);
                } //end if
            } //end while
        }
    }
}