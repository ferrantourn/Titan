using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace TitanWeb
{
    public class AutoliderHTML
    {
        public string GenerateHTML(AutoliderContainer c)
        {
            string text = "";

            //convierto el texto multiline de una caja de texto .net a un código multiline HTML
            string TextoDescripcion;
            TextoDescripcion = c.SDescripcionMultiLine.Replace(Environment.NewLine, "<br />");
            TextoDescripcion = c.SDescripcionMultiLine.Replace("\n", "<br />");

            try
            {

                string Fuente = "~/NeutraDispMedium.eot";
                //string Fuente = HttpContext.Current.Server.MapPath("~/NeutraDispMedium.eot");
                text = @"<html>

<head>
<meta http-equiv=""Content-Language"" content=""es-uy"">
<meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
<title>Autolider</title>
<style> 
@font-face
{
font-family: verdana;
}

</style>
</head>


<body>

<div style=""position: absolute; width: 900px; height: 800px; z-index: 2; left: 0px; top: 0px"" id=""capa1"">
<div style=""position: absolute; width: 281px; height: 17px; z-index: 4; left: 429px; top: 382px"" id=""Modelo"">
<font color=""#FFFFFF"" face = ""NeutraDisp"">"

                + c.SModelo + @"</font></div>
<div style=""position: absolute; width: 281px; height: 17px; z-index: 4; left: 429px; top: 399px"" id=""Cilindrada"">
<font color=""#FFFFFF"" face = ""NeutraDisp"">"

                + c.SCilindrada + @"</font></div>

<div style=""position: absolute; width: 280px; height: 37px; z-index: 4; left: 429px; top: 417px"" id=""Motor"">
<font color=""#FFFFFF"" face = ""NeutraDisp"">"

                + c.SMotor + @"</font></div>
<div style=""position: absolute; width: 417px; height: 284px; z-index: 4; left: 306px; top: 468px"" id=""Descripcion"">
<font color=""#FFFFFF"" face = ""NeutraDisp"">"

                + TextoDescripcion + @"</font></div>

<div style=""position: absolute; width: 240px; height: 240px; z-index: 3; left: 26px; top: 26px"" id=""foto1"">
<img border=""0"" src="""
                + c.SFoto1 + @""" width=""240"" height=""240""></div>

<div style=""position: absolute; width: 420px; height: 240px; z-index: 2; left: 292px; top: 26px"" id=""foto2"">
<img border=""0"" src="""
                + c.SFoto2 + @""" width=""420"" height=""240""></div>

<div style=""position: absolute; width: 240px; height: 240px; z-index: 1; left: 26px; top: 285px"" id=""foto3"">
<img border=""0"" src="""
                + c.SFoto3 + @""" width=""240"" height=""240""></div>

<div style=""position: absolute; width: 240px; height: 240px; z-index: 1; left: 26px; top: 545px"" id=""foto4"">
<img border=""0"" src="""
                + c.SFoto4 + @""" width=""240"" height=""240""></div>

<div style=""position: absolute; width: 584px; height: 95px; z-index: 1; left: 291px; top: 686px"" id=""precioFondo"">
<img border=""0"" src=""" + c.SFondoPrecio + @""" width=""584"" height=""95""></div>

<div style=""position: absolute; width: 80px; height: 50px; z-index: 4; left: 298px; top: 724px"" align=""center"" id=""precio"">
<font color=""#FFFFFF"" size=""4"">" + c.SPrecio
+ @"</font></div>

<div style=""position: absolute; width: 468px; height: 23px; z-index: 2; left: 410px; top: 753px"" id=""financiacion""><font color=""#FFFFFF"" size=""4"">"
+ c.SFinanciacion + @"</font></div>

<div style=""position: absolute; width: 584px; height: 95px; z-index: 1; left: 300px; top: 290px"" id=""Logo"">
<img border=""0"" src=""" + c.SLogo + @""" width=""185"" height=""76""></div>

<p><img border=""0"" src="""
                + c.SFondoPlantilla + @""" width=""900"" height=""800""></p>
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