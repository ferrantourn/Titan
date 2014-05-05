using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml;

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

        public void GuardarProyectoAutolider(string ArchivoDestino, AutoliderContainer c)
        {
            try
            {
                string directorio = Path.GetFileNameWithoutExtension(ArchivoDestino);
                Directory.CreateDirectory
                string sMarca = c.SMarca;
                string sModelo = c.SModelo;
                string sCilindrada = c.SCilindrada;
                string sMotor = c.SMarca;
                string sPrecio = c.SPrecio;
                string sDescripcionMultiLine = c.SDescripcionMultiLine;
                Uri Foto1 = c.SFoto1;
                Uri Foto2 = c.SFoto2;
                Uri Foto3 = c.SFoto3;
                Uri Foto4 = c.SFoto4;
                Uri FondoPrecio = c.SFondoPrecio;
                Uri FondoPlantilla = c.SFondoPlantilla;
                Uri Logo = c.SLogo;
                
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                XmlWriter writer = XmlWriter.Create(ArchivoDestino, settings);

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

        public void AbrirProyectoAutolider(string ArchivoOrigen, AutoliderContainer c)
        {
            c = new AutoliderContainer();
            
            XmlReader reader = XmlReader.Create(ArchivoOrigen);

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