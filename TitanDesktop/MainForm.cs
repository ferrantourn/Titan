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
        }

        private void FotoBox2_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox2.ImageLocation = AbrirArchivo.FileName;
            FotoBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void FotoBox3_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox3.ImageLocation = AbrirArchivo.FileName;
            FotoBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void FotoBox4_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            FotoBox4.ImageLocation = AbrirArchivo.FileName;
            FotoBox4.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnFondo_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            lblFondo.Text = AbrirArchivo.FileName;

        }

        
    }
}
