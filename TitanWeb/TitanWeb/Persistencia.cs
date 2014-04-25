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

        public void GuardarProyecto(string ArchivoDestino, string sMarca, string sModelo, string sCilindrada, string sMotor,
                                      string sPrecio, string sDescripcionMultiLine,
                                      Uri Foto1, Uri Foto2, Uri Foto3, Uri Foto4, Uri FondoPrecio,
                                      Uri FondoPlantilla,
                                      Uri Logo)
        {
            try
            {
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

        public void AbrirProyecto(string ArchivoOrigen, ref string sMarca, ref string sModelo, ref string sCilindrada, ref string sMotor,
                                      ref string sPrecio, ref string sDescripcionMultiLine,
                                      ref Uri Foto1, ref Uri Foto2, ref Uri Foto3, ref Uri Foto4, ref Uri FondoPrecio,
                                      ref Uri FondoPlantilla,
                                      ref Uri Logo)
        {
           XmlReader reader = XmlReader.Create(ArchivoOrigen);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element
                && reader.Name == "Producto")
                {

                    Foto1 = new Uri(reader.GetAttribute(0));
                    Foto2 = new Uri(reader.GetAttribute(1));
                    Foto3 = new Uri(reader.GetAttribute(2));
                    Foto4 = new Uri(reader.GetAttribute(3));
                    Logo = new Uri(reader.GetAttribute(4));
                    FondoPrecio = new Uri(reader.GetAttribute(5));
                    FondoPlantilla = new Uri(reader.GetAttribute(6));
                    sCilindrada = reader.GetAttribute(7);
                    sModelo = reader.GetAttribute(8);
                    sMotor = reader.GetAttribute(9);
                    sDescripcionMultiLine = reader.GetAttribute(10);
                    sPrecio = reader.GetAttribute(11);
                    sMarca = reader.GetAttribute(12);

                } //end if

            } //end while
        }
    }
}