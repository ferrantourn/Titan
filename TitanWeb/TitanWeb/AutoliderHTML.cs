using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace TitanWeb
{
    public class AutoliderHTML
    {
        public string GenerateHTML(string sMarca, string sModelo, string sCilindrada, string sMotor,
                                      string sPrecio, string sDescripcionMultiLine,
                                      Uri Foto1, Uri Foto2, Uri Foto3, Uri Foto4, Uri FondoPrecio, 
                                      Uri FondoPlantilla,
                                      Uri Logo)
        {
            string text = "";
            String TextoDescripcion = sDescripcionMultiLine.Replace(Environment.NewLine, "<br>");
            try
            {
                if (Foto1 == null || Foto1.ToString().Length == 0 || !File.Exists(Foto1.ToString()))
                {
                    Foto1 = new Uri("trans.png");
                }

                if (Foto2 == null || Foto2.ToString().Length == 0 || !File.Exists(Foto2.ToString()))
                {
                    Foto2 = new Uri("trans.png");
                }

                if (Foto3 == null || Foto3.ToString().Length == 0 || !File.Exists(Foto3.ToString()))
                {
                    Foto3 = new Uri("trans.png");
                }
                if (Foto4 == null || Foto4.ToString().Length == 0 || !File.Exists(Foto4.ToString()))
                {
                    Foto4 = new Uri("trans.png");
                }
                

                if (FondoPlantilla.ToString() == "")
                {
                    FondoPlantilla = new Uri("trans.png");
                }

                if (FondoPrecio.ToString() == "")
                {
                    FondoPrecio = new Uri("trans.png");
                }

                if (Logo.ToString() == "")
                {
                    Logo = new Uri("trans.png");
                }
                //copiar las imágenes a la working folder como idea opcional para el preview
                text = @"<html>

<head>
<meta http-equiv=""Content-Language"" content=""es-uy"">
<meta http-equiv=""Content-Type"" content=""text/html; charset=windows-1252"">
<title>Test</title>
</head>

<body>

<div style=""position: absolute; width: 900px; height: 800px; z-index: 2; left: 0px; top: 0px"" id=""capa1"">

<div style=""position: absolute; width: 281px; height: 17px; z-index: 4; left: 429px; top: 382px"" id=""Modelo"">
<font color=""#FFFFFF"">"

                + sModelo + @"</font></div>
<div style=""position: absolute; width: 281px; height: 17px; z-index: 4; left: 429px; top: 399px"" id=""Cilindrada"">
<font color=""#FFFFFF"">"

                + sCilindrada + @"</font></div>

<div style=""position: absolute; width: 280px; height: 37px; z-index: 4; left: 429px; top: 417px"" id=""Motor"">
<font color=""#FFFFFF"">"

                + sMotor + @"</font></div>
<div style=""position: absolute; width: 417px; height: 284px; z-index: 4; left: 293px; top: 468px"" id=""Descripcion"">
<font color=""#FFFFFF"">"

                + TextoDescripcion + @"</font></div>

<div style=""position: absolute; width: 240px; height: 240px; z-index: 3; left: 26px; top: 26px"" id=""foto1"">
<img border=""0"" src="""
                + Foto1 + @""" width=""240"" height=""240""></div>

<div style=""position: absolute; width: 420px; height: 240px; z-index: 2; left: 292px; top: 26px"" id=""foto2"">
<img border=""0"" src="""
                + Foto2 + @""" width=""420"" height=""240""></div>

<div style=""position: absolute; width: 240px; height: 240px; z-index: 1; left: 26px; top: 285px"" id=""foto3"">
<img border=""0"" src="""
                + Foto3 + @""" width=""240"" height=""240""></div>

<div style=""position: absolute; width: 240px; height: 240px; z-index: 1; left: 26px; top: 545px"" id=""foto4"">
<img border=""0"" src="""
                + Foto4 + @""" width=""240"" height=""240""></div>

<div style=""position: absolute; width: 584px; height: 95px; z-index: 1; left: 291px; top: 686px"" id=""precioFondo"">
<img border=""0"" src=""" + FondoPrecio + @""" width=""584"" height=""95""></div>

<div style=""position: absolute; width: 80px; height: 50px; z-index: 4; left: 298px; top: 724px"" align=""center"" id=""precio"">
<font color=""#FFFFFF"" size=""4"">" + sPrecio
+ @"</font></div>

<div style=""position: absolute; width: 584px; height: 95px; z-index: 1; left: 300px; top: 290px"" id=""Logo"">
<img border=""0"" src=""" + Logo + @""" width=""185"" height=""76""></div>

<p><img border=""0"" src="""
                + FondoPlantilla + @""" width=""900"" height=""800""></p>
</div>

</body>

</html>";
                
            }
            catch
            {

            }
            return text;

        }
    }
}