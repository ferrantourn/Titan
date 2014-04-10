﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Titan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FotoBox1_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox1.ImageLocation = AbrirArchivo.FileName;
            FotoBox1.SizeMode = PictureBoxSizeMode.Zoom;
            GenerateHTML();
        }

        private void FotoBox2_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox2.ImageLocation = AbrirArchivo.FileName;
            FotoBox2.SizeMode = PictureBoxSizeMode.Zoom;
            GenerateHTML();
        }

        private void FotoBox3_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox3.ImageLocation = AbrirArchivo.FileName;
            FotoBox3.SizeMode = PictureBoxSizeMode.Zoom;
            GenerateHTML();
        }

        private void FotoBox4_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox4.ImageLocation = AbrirArchivo.FileName;
            FotoBox4.SizeMode = PictureBoxSizeMode.Zoom;
            GenerateHTML();
        }

        private void btnFondo_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            lblFondo.Text = AbrirArchivo.FileName;
            GenerateHTML();

        }
        private void GenerateHTML()
        {
            
            string text = @"<html>

<head>
<meta http-equiv=""Content-Language"" content=""es-uy"">
<meta http-equiv=""Content-Type"" content=""text/html; charset=windows-1252"">
<title>Test</title>
</head>

<body>

<div style=""position: absolute; width: 900px; height: 800px; z-index: 2; left: 10px; top: 15px"" id=""capa1"">

<div style=""position: absolute; width: 281px; height: 17px; z-index: 4; left: 429px; top: 400px"" id=""Modelo"">
<font color=""#FFFFFF"" size=""2"">"
            
            + txtModelo.Text + @"</font></div>
<div style=""position: absolute; width: 281px; height: 17px; z-index: 4; left: 429px; top: 420px"" id=""Cilindrada"">
<font color=""#FFFFFF"" size=""2"">" 
            
            + txtCilindrada.Text + @"</font></div>
<div style=""position: absolute; width: 280px; height: 37px; z-index: 4; left: 429px; top: 439px"" id=""Motor"">
<font color=""#FFFFFF"" size=""2"">" 
            
            + txtMotor.Text + @"</font></div>
<div style=""position: absolute; width: 417px; height: 284px; z-index: 4; left: 293px; top: 489px"" id=""Descripcion"">
<font color=""#FFFFFF"" size=""2"">"
            
            + txtDescripcion.Text + @"</font></div>
<div style=""position: absolute; width: 240px; height: 240px; z-index: 3; left: 10px; top: 46px"" id=""foto1"">
<img border=""0"" src="""

            + FotoBox1.ImageLocation +@""" width=""240"" height=""240""></div>
<div style=""position: absolute; width: 420px; height: 240px; z-index: 2; left: 292px; top: 46px"" id=""foto2"">
<img border=""0"" src=""" 
            
            + FotoBox2.ImageLocation + @""" width=""420"" height=""240""></div>
<div style=""position: absolute; width: 240px; height: 240px; z-index: 1; left: 10px; top: 305px"" id=""foto3"">
<img border=""0"" src="""
            + FotoBox3.ImageLocation + @""" width=""240"" height=""240""></div>
<div style=""position: absolute; width: 240px; height: 240px; z-index: 1; left: 10px; top: 565px"" id=""foto4"">
<img border=""0"" src="""

            + FotoBox4.ImageLocation + @"""img/Modelos/Vespa4.jpg"" width=""240"" height=""240""></div>
<p><img border=""0"" src="""
            + lblFondo.Text + @""" width=""900"" height=""800""></p>
</div>

</body>

</html>";

            System.IO.File.WriteAllText(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "index.html"), text);


        }

        /// <summary>
        /// Levanta el contenido del archivo que pasamos por parametros, el cual
        /// deberia estar en la carpeta HTMLTemplates.
        /// </summary>
        /// <param name="FileNameTemplate">Nombre del archivo a levantar. Recordar se levantan desde la carpeta TemplatesMails en el raiz.</param>
        /// <returns>HTML devuelto.</returns>
        public static String GetTemplate(String FileNameTemplate)
        {
            //-----------------------------------------------
            //- Aquí levanto el archivo de template.         
            //-----------------------------------------------
            string fileName = string.Format("{0}\\{1}");
            //HttpContext.Current.Server.MapPath("~/Admin/HTMLTemplates"), FileNameTemplate);

            string contenido = "";

            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    contenido = reader.ReadToEnd();
                }
            }
            return contenido;
        }

        
    }
}
