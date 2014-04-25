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
    public partial class PlantillaFondo : Form
    {
        public PlantillaFondo()
        {
            InitializeComponent();
        }

        private void PlantillaFondo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm m = MainForm.Instance;
            if (m.AbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                m.lblFondo.Text = m.AbrirArchivo.FileName;
                m.GenerateHTMLJPG();
            }
            this.Dispose();
        }

        private void Plantilla1_Click(object sender, EventArgs e)
        {
            MainForm m = MainForm.Instance;
            m.lblFondo.Text = Plantilla1.ImageLocation;
            m.GenerateHTMLJPG();
            this.Dispose();
        }

        private void Plantilla2_Click(object sender, EventArgs e)
        {
            MainForm m = MainForm.Instance;
            m.lblFondo.Text = Plantilla2.ImageLocation;
            m.GenerateHTMLJPG();
            this.Dispose();
        }

        private void Plantilla3_Click(object sender, EventArgs e)
        {
            MainForm m = MainForm.Instance;
            m.lblFondo.Text = Plantilla3.ImageLocation;
            m.GenerateHTMLJPG();
            this.Dispose();
        }

        private void Plantilla4_Click(object sender, EventArgs e)
        {
            MainForm m = MainForm.Instance;
            m.lblFondo.Text = Plantilla4.ImageLocation;
            m.GenerateHTMLJPG();
            this.Dispose();
        }

        private void Plantilla5_Click(object sender, EventArgs e)
        {
            MainForm m = MainForm.Instance;
            m.lblFondo.Text = Plantilla5.ImageLocation;
            m.GenerateHTMLJPG();
            this.Dispose();
        }

        private void Plantilla6_Click(object sender, EventArgs e)
        {
            MainForm m = MainForm.Instance;
            m.lblFondo.Text = Plantilla6.ImageLocation;
            m.GenerateHTMLJPG();
            this.Dispose();
        }

        private void Plantilla1_MouseEnter(object sender, EventArgs e)
        {
            Plantilla1.BorderStyle = BorderStyle.FixedSingle;
        }
        private void Plantilla1_MouseLeave(object sender, EventArgs e)
        {
            Plantilla1.BorderStyle = BorderStyle.None;
        }
        //---------------------------------
        private void Plantilla2_MouseEnter(object sender, EventArgs e)
        {
            Plantilla2.BorderStyle = BorderStyle.FixedSingle;
        }
        private void Plantilla2_MouseLeave(object sender, EventArgs e)
        {
            Plantilla2.BorderStyle = BorderStyle.None;
        }
        //---------------------------------
        private void Plantilla3_MouseEnter(object sender, EventArgs e)
        {
            Plantilla3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Plantilla3_MouseLeave(object sender, EventArgs e)
        {
            Plantilla3.BorderStyle = BorderStyle.None;
        }
        //---------------------------------
        private void Plantilla4_MouseEnter(object sender, EventArgs e)
        {
            Plantilla4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Plantilla4_MouseLeave(object sender, EventArgs e)
        {
            Plantilla4.BorderStyle = BorderStyle.None;
        }
        //---------------------------------
        private void Plantilla5_MouseEnter(object sender, EventArgs e)
        {
            Plantilla5.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Plantilla5_MouseLeave(object sender, EventArgs e)
        {
            Plantilla5.BorderStyle = BorderStyle.None;
        }
        //---------------------------------
        private void Plantilla6_MouseEnter(object sender, EventArgs e)
        {
            Plantilla6.BorderStyle = BorderStyle.FixedSingle;
        }
        private void Plantilla6_MouseLeave(object sender, EventArgs e)
        {
            Plantilla6.BorderStyle = BorderStyle.None;
        }
        //---------------------------------
    }
}
