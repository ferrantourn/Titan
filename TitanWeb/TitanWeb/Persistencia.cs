using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Titan;

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



    }
}