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
using System.Drawing.Imaging;


namespace Titan
{
    public partial class MainForm : Form
    {

        public int numeroFoto;
        private static MainForm instance;

        public static MainForm Instance
        {
            get 
            {
                return instance;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            
        }


        private void FotoBox1_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox1.ImageLocation = AbrirArchivo.FileName;
            Uri direccion = new Uri(AbrirArchivo.FileName);
            numeroFoto = 1; //indica que se va a cargar una foto en el Fotobox 1
            if (File.Exists(@"" + txtCarpetaTrabajo.Text + @"\\temp1.jpg"))
            {
                File.Delete(@"" + txtCarpetaTrabajo.Text + @"\\temp1.jpg");
            }

            GenerateCrop(direccion);
            
            FotoBox1.SizeMode = PictureBoxSizeMode.Zoom;
            GenerateHTMLJPG();
        }

        private void FotoBox2_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox2.ImageLocation = AbrirArchivo.FileName;
            FotoBox2.SizeMode = PictureBoxSizeMode.Zoom;
            GenerateHTMLJPG();
        }

        private void FotoBox3_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox3.ImageLocation = AbrirArchivo.FileName;
            FotoBox3.SizeMode = PictureBoxSizeMode.Zoom;
            GenerateHTMLJPG();
        }

        private void FotoBox4_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox4.ImageLocation = AbrirArchivo.FileName;
            FotoBox4.SizeMode = PictureBoxSizeMode.Zoom;
            GenerateHTMLJPG();
        }

        private void btnFondo_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            lblFondo.Text = AbrirArchivo.FileName;
            GenerateHTMLJPG();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            lblLogo.Text = AbrirArchivo.FileName;
            GenerateHTMLJPG();
        }

        private void btnPlantillaPrecio_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            lblPrecio.Text = AbrirArchivo.FileName;
            GenerateHTMLJPG();
        }

        private void GenerateCrop(Uri direccion)
        {
            Resizer r = new Resizer();
            r.Show();
            r.SrcPicBox.ImageLocation = direccion.ToString();
        }

        public void GenerateHTMLJPG()
        {
            Uri Foto1 = new Uri("file:///C:/");//nueva dirección vacía
            Uri Foto2 = new Uri("file:///C:/");
            Uri Foto3 = new Uri("file:///C:/");
            Uri Foto4 = new Uri("file:///C:/");
            Uri Fondo = new Uri("file:///C:/");
            Uri PrecioFondo = new Uri("file:///C:/");
            Uri Logo = new Uri("file:///C:/");

            String TextoDescripcion = txtDescripcion.Text.Replace(Environment.NewLine, "<br>");
            try
            {
                if (FotoBox1.ImageLocation != null)
                {
                    Foto1 = new Uri(FotoBox1.ImageLocation);
                }
                else
                {
                    Foto1 = new Uri(@"" + txtCarpetaTrabajo.Text + "\\trans.png");
                }

                if(FotoBox2.ImageLocation!=null)
                {
                    Foto2 = new Uri(FotoBox2.ImageLocation);
                }
                else
                {
                    Foto2 = new Uri(@"" + txtCarpetaTrabajo.Text + "\\trans.png");
                }

                if (FotoBox3.ImageLocation != null)
                {
                    Foto3 = new Uri(FotoBox3.ImageLocation);
                }
                else
                {
                    Foto3 = new Uri(@"" + txtCarpetaTrabajo.Text + "\\trans.png");
                }

                if (FotoBox4.ImageLocation != null)
                {
                    Foto4 = new Uri(FotoBox4.ImageLocation);
                }
                else
                {
                    Foto4 = new Uri(@"" + txtCarpetaTrabajo.Text + "\\trans.png");
                }


                if (lblFondo.Text != "")
                {
                    Fondo = new Uri(lblFondo.Text);
                }
                else
                {
                    Fondo = new Uri(@"" + txtCarpetaTrabajo.Text + "\\trans.png");
                }

                if (lblPrecio.Text != "")
                {
                    PrecioFondo = new Uri(lblPrecio.Text);
                }
                else
                {
                    PrecioFondo = new Uri(@"" + txtCarpetaTrabajo.Text + "\\trans.png");
                }

                if (lblLogo.Text != "")
                {
                    Logo = new Uri(lblLogo.Text);
                }
                else
                {
                    Logo = new Uri(@"" + txtCarpetaTrabajo.Text + "\\trans.png");
                }

            }
            catch
            {

            }

            try
            {
                //copiar las imágenes a la working folder como idea opcional para el preview

                string text = @"<html>

<head>
<meta http-equiv=""Content-Language"" content=""es-uy"">
<meta http-equiv=""Content-Type"" content=""text/html; charset=windows-1252"">
<title>Test</title>
</head>

<body>

<div style=""position: absolute; width: 900px; height: 800px; z-index: 2; left: 0px; top: 0px"" id=""capa1"">

<div style=""position: absolute; width: 281px; height: 17px; z-index: 4; left: 429px; top: 380px"" id=""Modelo"">
<font color=""#FFFFFF"" size=""2"">"

                + txtModelo.Text + @"</font></div>
<div style=""position: absolute; width: 281px; height: 17px; z-index: 4; left: 429px; top: 400px"" id=""Cilindrada"">
<font color=""#FFFFFF"" size=""2"">"

                + txtCilindrada.Text + @"</font></div>
<div style=""position: absolute; width: 280px; height: 37px; z-index: 4; left: 429px; top: 419px"" id=""Motor"">
<font color=""#FFFFFF"" size=""2"">"

                + txtMotor.Text + @"</font></div>
<div style=""position: absolute; width: 417px; height: 284px; z-index: 4; left: 293px; top: 469px"" id=""Descripcion"">
<font color=""#FFFFFF"" size=""2"">"

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
<img border=""0"" src=""" + PrecioFondo + @""" width=""584"" height=""95""></div>

<div style=""position: absolute; width: 80px; height: 50px; z-index: 4; left: 298px; top: 724px"" align=""center"" id=""precio"">
<font color=""#FFFFFF"" size=""4"">" + txtPrecio.Text
+ @"</font></div>

<div style=""position: absolute; width: 584px; height: 95px; z-index: 1; left: 300px; top: 290px"" id=""Logo"">
<img border=""0"" src=""" + Logo + @""" width=""185"" height=""76""></div>

<p><img border=""0"" src="""
                + Fondo + @""" width=""900"" height=""800""></p>
</div>

</body>

</html>";

                //creación del HTML
                File.WriteAllText(@"" + txtCarpetaTrabajo.Text + "\\index.html", text);
                Uri WebPath = new Uri(txtCarpetaTrabajo.Text + "index.html");
                HtmlPreview.Url = WebPath;

                //creación de JPG:
                WebJPG websiteToImage = new WebJPG(txtCarpetaTrabajo.Text + "index.html", @"" + txtCarpetaTrabajo.Text + "\\index.jpg");
                websiteToImage.Generate();
                PreviewJPG.ImageLocation = txtCarpetaTrabajo.Text + "\\index.jpg";
                

            }
            catch
            {
                //MessageBox.Show("Error");
                File.WriteAllText(@"" + txtCarpetaTrabajo.Text + "\\index.html", "");
            }
            finally
            {
                
            }
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

        private void btnSeleccionarWorkingFolder_Click(object sender, EventArgs e)
        {
            AbrirCarpeta.ShowDialog();
            txtCarpetaTrabajo.Text = AbrirCarpeta.SelectedPath;

            Uri WebPath = new Uri(txtCarpetaTrabajo.Text + "\\index.html");
            HtmlPreview.Url = WebPath;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtCarpetaTrabajo.Text = System.IO.Path.GetTempPath();
            if (File.Exists(@"" + txtCarpetaTrabajo.Text + @"\\index.html"))
            {
                File.Delete(@"" + txtCarpetaTrabajo.Text + @"\\index.html");
            }
            Uri WebPath = new Uri(txtCarpetaTrabajo.Text + "index.html");
            HtmlPreview.Url = WebPath;
            instance = this;
            lblFondo.Text = "";
            lblLogo.Text = "";
            lblPrecio.Text = "";
        }

        private void btnGuardarJPG_Click(object sender, EventArgs e)
        {

        }


    }
}
