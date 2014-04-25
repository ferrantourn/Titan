using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titan
{
    public partial class PlantillaPrecio : Form
    {
        public PlantillaPrecio()
        {
            InitializeComponent();
        }

        private void PlantillaPrecio_Load(object sender, EventArgs e)
        {
            
        }

        private void PlantillaFondo1_Click(object sender, EventArgs e)
        {
            MainForm m = MainForm.Instance;
            m.lblPrecio.Text = PlantillaFondo1.ImageLocation;
            m.GenerateHTMLJPG();
            this.Dispose();
        }

        private void btnElegirFondoPrecio_Click(object sender, EventArgs e)
        {
            MainForm m = MainForm.Instance;
            if (m.AbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                m.lblPrecio.Text = m.AbrirArchivo.FileName;
                m.GenerateHTMLJPG();
            }
            this.Dispose();
        }

        private void PlantillaFondo3_Click(object sender, EventArgs e)
        {
            MainForm m = MainForm.Instance;
            m.lblPrecio.Text = PlantillaFondo3.ImageLocation;
            m.GenerateHTMLJPG();
            this.Dispose();
        }

        private void PlantillaFondo2_Click(object sender, EventArgs e)
        {
            MainForm m = MainForm.Instance;
            m.lblPrecio.Text = PlantillaFondo2.ImageLocation;
            m.GenerateHTMLJPG();
            this.Dispose();
        }

        private void PlantillaFondo4_Click(object sender, EventArgs e)
        {
            MainForm m = MainForm.Instance;
            m.lblPrecio.Text = PlantillaFondo4.ImageLocation;
            m.GenerateHTMLJPG();
            this.Dispose();
        }

        private void PlantillaFondo1_MouseEnter(object sender, EventArgs e)
        {
            PlantillaFondo1.BorderStyle = BorderStyle.Fixed3D;
        }
        private void PlantillaFondo1_MouseLeave(object sender, EventArgs e)
        {
            PlantillaFondo1.BorderStyle = BorderStyle.None;
        }

        private void PlantillaFondo2_MouseEnter(object sender, EventArgs e)
        {
            PlantillaFondo2.BorderStyle = BorderStyle.Fixed3D;
        }
        private void PlantillaFondo2_MouseLeave(object sender, EventArgs e)
        {
            PlantillaFondo2.BorderStyle = BorderStyle.None;
        }

        private void PlantillaFondo3_MouseEnter(object sender, EventArgs e)
        {
            PlantillaFondo3.BorderStyle = BorderStyle.Fixed3D;
        }
        private void PlantillaFondo3_MouseLeave(object sender, EventArgs e)
        {
            PlantillaFondo3.BorderStyle = BorderStyle.None;
        }

        private void PlantillaFondo4_MouseEnter(object sender, EventArgs e)
        {
            PlantillaFondo4.BorderStyle = BorderStyle.Fixed3D;
        }
        private void PlantillaFondo4_MouseLeave(object sender, EventArgs e)
        {
            PlantillaFondo4.BorderStyle = BorderStyle.None;
        }
    }
}
