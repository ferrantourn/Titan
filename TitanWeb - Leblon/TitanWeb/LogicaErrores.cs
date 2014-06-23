using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml;

namespace TitanWeb
{
    public static class LogicaErrores
    {
        public static bool GuardarError(string errormessage, DateTime date)
        {
            bool correcto = false;
            try
            {
                XmlDocument document = new XmlDocument();

                string physicalPath =
                      HttpContext.Current.Request.MapPath(ConfigurationManager.AppSettings["ErrorLogPath"]);
                document.Load(physicalPath);

                XmlNode root = document.DocumentElement;
                //creo elemento del xml
                XmlElement error = document.CreateElement("Error");
                //creo atributos para ese elemento.

                XmlAttribute xmlmensaje = document.CreateAttribute("Mensaje");
                XmlAttribute xmlfecha = document.CreateAttribute("Fecha");

                //le doy valor a los atributos creados.
                xmlmensaje.Value = errormessage;
                xmlfecha.Value = Convert.ToString(date);

                //agrego los atributos al elemento XML comentario
                error.Attributes.Append(xmlmensaje);
                error.Attributes.Append(xmlfecha);


                //agrego el elemento XML al archivo.
                root.AppendChild(error);
                //salvo el documento con los cambios realizados.

                document.Save(physicalPath);
                //no hubo problemas
                correcto = true;
            }
            catch (Exception ex)
            {
            }
            return correcto;
        }
    }
}