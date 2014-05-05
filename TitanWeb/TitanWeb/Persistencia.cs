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
                Directory.CreateDirectory(HttpContext.Current.Server.MapPath("~/") + nombre);
                foreach (var file in HttpContext.Current.Server.MapPath("~/UploadedImages"))
                {
                    File.Copy(file, Path.Combine(HttpContext.Current.Server.MapPath("~/").ToString() + nombre.ToString(), Path.GetFileName(file)));
                }

                string sMarca = c.SMarca;
                string sModelo = c.SModelo;
                string sCilindrada = c.SCilindrada;
                string sMotor = c.SMarca;
                string sPrecio = c.SPrecio;
                string sDescripcionMultiLine = c.SDescripcionMultiLine;
                Uri Foto1 = new Uri("~/" + nombre + c.SFoto1.ToString());
                Uri Foto2 = new Uri("~/" + nombre + c.SFoto2.ToString());
                Uri Foto3 = new Uri("~/" + nombre + c.SFoto3.ToString());
                Uri Foto4 = new Uri("~/" + nombre + c.SFoto4.ToString());
                Uri FondoPrecio = new Uri("~/" + nombre + c.SFondoPrecio.ToString());
                Uri FondoPlantilla = new Uri("~/" + nombre + c.SFondoPlantilla.ToString());
                Uri Logo = new Uri("~/" + nombre + c.SLogo.ToString());
                
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                XmlWriter writer = XmlWriter.Create(nombre + ".titan", settings);

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
            c = new AutoliderContainer();
            
            XmlReader reader = XmlReader.Create("~/" + nombre + ".titan");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element
                && reader.Name == "Producto")
                {
                    c.SFoto1 = new Uri(reader.GetAttribute(0));
                    c.SFoto2 = new Uri(reader.GetAttribute(1));
                    c.SFoto3 = new Uri(reader.GetAttribute(2));
                    c.SFoto4 = new Uri(reader.GetAttribute(3));
                    c.SLogo = new Uri(reader.GetAttribute(4));
                    c.SFondoPrecio = new Uri(reader.GetAttribute(5));
                    c.SFondoPlantilla = new Uri(reader.GetAttribute(6));
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