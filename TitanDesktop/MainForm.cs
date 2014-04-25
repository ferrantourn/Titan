using System;
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
using System.Xml;


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
            try
            {
                AbrirArchivo.ShowDialog();
                FotoBox1.ImageLocation = AbrirArchivo.FileName;
                Uri direccion = new Uri(AbrirArchivo.FileName);
                numeroFoto = 1; //indica que se va a cargar una foto en el Fotobox 1
                if (File.Exists(@"" + txtCarpetaTrabajo.Text + "temp1.jpg"))
                {
                    File.Delete(@"" + txtCarpetaTrabajo.Text + "temp1.jpg");
                }

                GenerateCrop(direccion);

                GenerateHTMLJPG();
            }
            catch
            {
                
            }
        }

        private void FotoBox2_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox2.ImageLocation = AbrirArchivo.FileName;
            GenerateHTMLJPG();
        }

        private void FotoBox3_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox3.ImageLocation = AbrirArchivo.FileName;
            GenerateHTMLJPG();
        }

        private void FotoBox4_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox4.ImageLocation = AbrirArchivo.FileName;
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
            if (AbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                lblLogo.Text = AbrirArchivo.FileName;
                GenerateHTMLJPG();
            }
        }

        private void btnPlantillaPrecio_Click(object sender, EventArgs e)
        {
            PlantillaPrecio p = new PlantillaPrecio();
            p.Show();
            p.PlantillaFondo1.ImageLocation = txtCarpetaTrabajo.Text + @"PlantillasPrecio\precio_azul.png";
            p.PlantillaFondo2.ImageLocation = txtCarpetaTrabajo.Text + @"PlantillasPrecio\precio_cyan.png";
            p.PlantillaFondo3.ImageLocation = txtCarpetaTrabajo.Text + @"PlantillasPrecio\precio_dorado.png";
            p.PlantillaFondo4.ImageLocation = txtCarpetaTrabajo.Text + @"PlantillasPrecio\precio_rojo.png";

            //AbrirArchivo.ShowDialog();
            //lblPrecio.Text = AbrirArchivo.FileName;
            GenerateHTMLJPG();


        }

        private void GenerateCrop(Uri direccion)
        {
            Resizer r = new Resizer();
            r.Show();
            r.SrcPicBox.ImageLocation = direccion.ToString();
        }


        //el núcleo del programa
        //genera un HTML con las fotos seleccionadas 
        //y genera un JPG a partir de ese HTML generado
        //el archivo trans.png es un archivo imágen transparente, que sirve para poner
        //en aquellos lugares donde el usuario no escogió foto.
        //dicho archivo debe estar presente en la working folder (carpetaTrabajo)
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
                if (FotoBox1.ImageLocation != null && FotoBox1.ImageLocation.ToString().Length != 0 && File.Exists(FotoBox1.ImageLocation))
                {
                    Foto1 = new Uri(FotoBox1.ImageLocation);
                }
                else
                {
                    Foto1 = new Uri(@"" + txtCarpetaTrabajo.Text + "trans.png");
                }

                if (FotoBox2.ImageLocation != null && FotoBox2.ImageLocation.ToString().Length != 0 && File.Exists(FotoBox1.ImageLocation))
                {
                    Foto2 = new Uri(FotoBox2.ImageLocation);
                }
                else
                {
                    Foto2 = new Uri(@"" + txtCarpetaTrabajo.Text + "trans.png");
                }

                if (FotoBox3.ImageLocation != null && FotoBox3.ImageLocation.ToString().Length != 0 && File.Exists(FotoBox1.ImageLocation))
                {
                    Foto3 = new Uri(FotoBox3.ImageLocation);
                }
                else
                {
                    Foto3 = new Uri(@"" + txtCarpetaTrabajo.Text + "trans.png");
                }

                if (FotoBox4.ImageLocation != null && FotoBox4.ImageLocation.ToString().Length != 0 && File.Exists(FotoBox1.ImageLocation))
                {
                    Foto4 = new Uri(FotoBox4.ImageLocation);
                }
                else
                {
                    Foto4 = new Uri(@"" + txtCarpetaTrabajo.Text + "trans.png");
                }

                if (lblFondo.Text != "")
                {
                    Fondo = new Uri(lblFondo.Text);
                }
                else
                {
                    Fondo = new Uri(@"" + txtCarpetaTrabajo.Text + "trans.png");
                }

                if (lblPrecio.Text != "")
                {
                    PrecioFondo = new Uri(lblPrecio.Text);
                }
                else
                {
                    PrecioFondo = new Uri(@"" + txtCarpetaTrabajo.Text + "trans.png");
                }

                if (lblLogo.Text != "")
                {
                    Logo = new Uri(lblLogo.Text);
                }
                else
                {
                    Logo = new Uri(@"" + txtCarpetaTrabajo.Text + "trans.png");
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

<div style=""position: absolute; width: 281px; height: 17px; z-index: 4; left: 429px; top: 382px"" id=""Modelo"">
<font color=""#FFFFFF"">"

                + txtModelo.Text + @"</font></div>
<div style=""position: absolute; width: 281px; height: 17px; z-index: 4; left: 429px; top: 399px"" id=""Cilindrada"">
<font color=""#FFFFFF"">"

                + txtCilindrada.Text + @"</font></div>

<div style=""position: absolute; width: 280px; height: 37px; z-index: 4; left: 429px; top: 417px"" id=""Motor"">
<font color=""#FFFFFF"">"

                + txtMotor.Text + @"</font></div>
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
                
                File.WriteAllText(@"" + txtCarpetaTrabajo.Text + "index.html", text);
                Uri WebPath = new Uri(txtCarpetaTrabajo.Text + "index.html");
                HtmlPreview.Url = WebPath;

                //creación de JPG:
                WebJPG websiteToImage = new WebJPG(txtCarpetaTrabajo.Text + "index.html", @"" + txtCarpetaTrabajo.Text + "index.jpg");
                websiteToImage.Generate();
                

            }
            catch
            {
                //MessageBox.Show("Error");
                File.WriteAllText(@"" + txtCarpetaTrabajo.Text + "index.html", "");
            }
            finally
            {
                
            }
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
            if (File.Exists(@"" + txtCarpetaTrabajo.Text + "index.html"))
            {
                File.Delete(@"" + txtCarpetaTrabajo.Text + "index.html");
            }
            if (File.Exists(@"" + txtCarpetaTrabajo.Text + "index.jpg"))
            {
                File.Delete(@"" + txtCarpetaTrabajo.Text + "index.jpg");
            }
            Uri WebPath = new Uri(txtCarpetaTrabajo.Text + "index.html");
            HtmlPreview.Url = WebPath;
            instance = this;
            lblFondo.Text = "";
            lblLogo.Text = "";
            lblPrecio.Text = "";
            FotoBox1.SizeMode = PictureBoxSizeMode.Zoom;
            FotoBox2.SizeMode = PictureBoxSizeMode.Zoom;
            FotoBox3.SizeMode = PictureBoxSizeMode.Zoom;
            FotoBox4.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void btnGuardarJPG_Click(object sender, EventArgs e)
        {

            GuardarJPG = new SaveFileDialog();

            GuardarJPG.Filter = "arhivos JPG (*.jpg)|*.jpg|Todos los archivos (*.*)|*.*";
            GuardarJPG.FilterIndex = 1;
            GuardarJPG.RestoreDirectory = true;
            try
            {

                if (GuardarJPG.ShowDialog() == DialogResult.OK)
                {
                    string origen = txtCarpetaTrabajo.Text + "index.jpg";
                    string destino = GuardarJPG.FileName.ToString();
                    File.Copy(origen, destino ,true);
                }

            }
            
            catch
            {
                MessageBox.Show("Error");            
            }
        }

        private void btnAbrirProyecto_Click(object sender, EventArgs e)
        {
            AbrirProyecto.ShowDialog();
            

            //XmlReader reader = XmlReader.Create(@"" + txtCarpetaTrabajo.Text + "proyecto.xml");
            XmlReader reader = XmlReader.Create(AbrirProyecto.FileName);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element
                && reader.Name == "Producto")
                {

                    FotoBox1.ImageLocation = reader.GetAttribute(0);
                    FotoBox2.ImageLocation = reader.GetAttribute(1);
                    FotoBox3.ImageLocation = reader.GetAttribute(2);
                    FotoBox4.ImageLocation = reader.GetAttribute(3);
                    lblLogo.Text = reader.GetAttribute(4);
                    lblPrecio.Text = reader.GetAttribute(5);
                    lblFondo.Text = reader.GetAttribute(6);
                    txtCilindrada.Text = reader.GetAttribute(7);
                    txtModelo.Text = reader.GetAttribute(8);
                    txtMotor.Text = reader.GetAttribute(9);
                    txtDescripcion.Text = reader.GetAttribute(10);
                    txtPrecio.Text = reader.GetAttribute(11);

                } //end if

            } //end while
            GenerateHTMLJPG();
        }

        private void btnGuardarProyecto_Click(object sender, EventArgs e)
        //guarda un XML con todo lo necesario para que luego se pueda levantar el proyecto
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                XmlWriter writer = XmlWriter.Create(@"" + txtCarpetaTrabajo.Text + "proyecto.xml", settings);
                        
                writer.WriteStartDocument();
                writer.WriteComment("Generado por Titan.");
                writer.WriteStartElement("Producto");
                writer.WriteAttributeString("Foto1", FotoBox1.ImageLocation);
                writer.WriteAttributeString("Foto2", FotoBox2.ImageLocation);
                writer.WriteAttributeString("Foto3", FotoBox3.ImageLocation);
                writer.WriteAttributeString("Foto4", FotoBox4.ImageLocation);
                writer.WriteAttributeString("Logo", lblLogo.Text);
                writer.WriteAttributeString("FondoPrecio", lblPrecio.Text);
                writer.WriteAttributeString("Fondo", lblFondo.Text);
                writer.WriteAttributeString("Cilindrada", txtCilindrada.Text);
                writer.WriteAttributeString("Modelo", txtModelo.Text);
                writer.WriteAttributeString("Motor", txtMotor.Text);
                writer.WriteAttributeString("Descripcion", txtDescripcion.Text);
                writer.WriteAttributeString("Precio", txtPrecio.Text);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al generar XML"); 
            }

            try
            {
                GuardarProyecto = new SaveFileDialog();
                GuardarProyecto.Filter = "arhivos XML (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
                GuardarProyecto.FilterIndex = 1;
                GuardarProyecto.RestoreDirectory = true;

                if (GuardarProyecto.ShowDialog() == DialogResult.OK)
                {
                    string origen = txtCarpetaTrabajo.Text + "proyecto.xml";
                    string destino = GuardarProyecto.FileName.ToString();
                    File.Copy(origen, destino, true);
                }
            }
            catch
            {
                MessageBox.Show("Error al guardar el archivo al destino"); 
            }

        }
    }
}
