using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace TitanWeb
{
    public class LeblonHTML
    {
        public string GenerateHTML(LeblonContainer c)
        {
            string text = "";

            //convierto el texto multiline de una caja de texto .net a un código multiline HTML
            string TextoDescripcion;
            TextoDescripcion = c.SDescripcionMultiLine.Replace(Environment.NewLine, "<br />");
            TextoDescripcion = c.SDescripcionMultiLine.Replace("\n", "<br />");

            string TextoCuadro1;
            TextoCuadro1 = c.SCuadroMultiLine1.Replace(Environment.NewLine, "<br />");
            TextoCuadro1 = c.SCuadroMultiLine1.Replace("\n", "<br />");

            string TextoCuadro2;
            TextoCuadro2 = c.SCuadroMultiLine2.Replace(Environment.NewLine, "<br />");
            TextoCuadro2 = c.SCuadroMultiLine2.Replace("\n", "<br />");

            try
            {

                //string Fuente = "~/NeutraDispMedium.eot";
                //string Fuente = HttpContext.Current.Server.MapPath("~/NeutraDispMedium.eot");
                text = @"<html>

<head>
<meta http-equiv=""Content-Language"" content=""es-uy"">
<meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
<title>Autolider</title>
<style> 
@font-face
{
    font-family: mifuente;
    src: url(NeutraDispMedium.ttf);
}

</style>
</head>


<body>

<div  style=""font-family: myFirstFont; position: absolute; width: 900px; height: 800px; z-index: 2; left: 0px; top: 0px"" id=""capa1"">
<div style=""position: absolute; width: 421px; height: 74px; z-index: 4; left: 307px; top: 297px"" id=""Titulo"">
<font color=""#FFFFFF"" size=""10"">" + c.STitulo + @"</font></div>

<div style=""position: absolute; width: 203px; height: 74px; z-index: 4; left: 307px; top: 388px"" id=""Cuadro1"">
<font color=""#FFFFFF"">"
                + TextoCuadro1 + @"</font></div>

<div style=""position: absolute; width: 193px; height: 74px; z-index: 4; left: 530px; top: 388px"" id=""Cuadro2"">
<font color=""#FFFFFF"">" 
                + TextoCuadro2 + @"</font></div>

<div style=""position: absolute; width: 417px; height: 284px; z-index: 4; left: 306px; top: 478px"" id=""Descripcion"">
<font color=""#FFFFFF"">"
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

<div style=""position: absolute; width: 80px; height: 50px; z-index: 4; left: 633px; top: 717px"" align=""center"" id=""precio"">
<font color=""#FFFFFF"" size=""5"">" + c.SPrecio
+ @"</font></div>

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