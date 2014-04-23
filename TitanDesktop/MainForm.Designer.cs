namespace Titan
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = new System.Windows.Forms.TabControl();
            this.Diseño = new System.Windows.Forms.TabPage();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnLogo = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnPlantillaPrecio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblFondo = new System.Windows.Forms.Label();
            this.btnFondo = new System.Windows.Forms.Button();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.FotoBox4 = new System.Windows.Forms.PictureBox();
            this.FotoBox3 = new System.Windows.Forms.PictureBox();
            this.FotoBox2 = new System.Windows.Forms.PictureBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.FotoBox1 = new System.Windows.Forms.PictureBox();
            this.Previsualizar = new System.Windows.Forms.TabPage();
            this.HtmlPreview = new System.Windows.Forms.WebBrowser();
            this.Publicar = new System.Windows.Forms.TabPage();
            this.Config = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarpetaTrabajo = new System.Windows.Forms.TextBox();
            this.lblCarpeta = new System.Windows.Forms.Label();
            this.btnSeleccionarWorkingFolder = new System.Windows.Forms.Button();
            this.AbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.AbrirCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGuardarJPG = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GuardarJPG = new System.Windows.Forms.SaveFileDialog();
            this.tab1.SuspendLayout();
            this.Diseño.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox1)).BeginInit();
            this.Previsualizar.SuspendLayout();
            this.Publicar.SuspendLayout();
            this.Config.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.Diseño);
            this.tab1.Controls.Add(this.Previsualizar);
            this.tab1.Controls.Add(this.Publicar);
            this.tab1.Controls.Add(this.Config);
            this.tab1.Location = new System.Drawing.Point(13, 13);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(579, 570);
            this.tab1.TabIndex = 0;
            // 
            // Diseño
            // 
            this.Diseño.Controls.Add(this.lblLogo);
            this.Diseño.Controls.Add(this.btnLogo);
            this.Diseño.Controls.Add(this.lblPrecio);
            this.Diseño.Controls.Add(this.btnPlantillaPrecio);
            this.Diseño.Controls.Add(this.label2);
            this.Diseño.Controls.Add(this.txtPrecio);
            this.Diseño.Controls.Add(this.lblFondo);
            this.Diseño.Controls.Add(this.btnFondo);
            this.Diseño.Controls.Add(this.txtMotor);
            this.Diseño.Controls.Add(this.FotoBox4);
            this.Diseño.Controls.Add(this.FotoBox3);
            this.Diseño.Controls.Add(this.FotoBox2);
            this.Diseño.Controls.Add(this.txtModelo);
            this.Diseño.Controls.Add(this.txtCilindrada);
            this.Diseño.Controls.Add(this.txtDescripcion);
            this.Diseño.Controls.Add(this.FotoBox1);
            this.Diseño.Location = new System.Drawing.Point(4, 22);
            this.Diseño.Name = "Diseño";
            this.Diseño.Padding = new System.Windows.Forms.Padding(3);
            this.Diseño.Size = new System.Drawing.Size(571, 544);
            this.Diseño.TabIndex = 0;
            this.Diseño.Text = "Diseño";
            this.Diseño.UseVisualStyleBackColor = true;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(283, 231);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(25, 13);
            this.lblLogo.TabIndex = 16;
            this.lblLogo.Text = "___";
            // 
            // btnLogo
            // 
            this.btnLogo.Location = new System.Drawing.Point(283, 201);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(107, 23);
            this.btnLogo.TabIndex = 15;
            this.btnLogo.Text = "Escoger Logotipo";
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(283, 519);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(25, 13);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "___";
            // 
            // btnPlantillaPrecio
            // 
            this.btnPlantillaPrecio.Location = new System.Drawing.Point(283, 493);
            this.btnPlantillaPrecio.Name = "btnPlantillaPrecio";
            this.btnPlantillaPrecio.Size = new System.Drawing.Size(124, 23);
            this.btnPlantillaPrecio.TabIndex = 13;
            this.btnPlantillaPrecio.Text = "Escoger plantilla precio";
            this.btnPlantillaPrecio.UseVisualStyleBackColor = true;
            this.btnPlantillaPrecio.Click += new System.EventHandler(this.btnPlantillaPrecio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(329, 465);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 11;
            this.txtPrecio.Text = "0";
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFondo
            // 
            this.lblFondo.AutoSize = true;
            this.lblFondo.Location = new System.Drawing.Point(6, 519);
            this.lblFondo.Name = "lblFondo";
            this.lblFondo.Size = new System.Drawing.Size(25, 13);
            this.lblFondo.TabIndex = 10;
            this.lblFondo.Text = "___";
            // 
            // btnFondo
            // 
            this.btnFondo.Location = new System.Drawing.Point(7, 493);
            this.btnFondo.Name = "btnFondo";
            this.btnFondo.Size = new System.Drawing.Size(124, 23);
            this.btnFondo.TabIndex = 9;
            this.btnFondo.Text = "Escoger fondo";
            this.btnFondo.UseVisualStyleBackColor = true;
            this.btnFondo.Click += new System.EventHandler(this.btnFondo_Click);
            // 
            // txtMotor
            // 
            this.txtMotor.Location = new System.Drawing.Point(283, 307);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(282, 20);
            this.txtMotor.TabIndex = 8;
            this.txtMotor.Text = "Motor";
            // 
            // FotoBox4
            // 
            this.FotoBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoBox4.Location = new System.Drawing.Point(7, 334);
            this.FotoBox4.Name = "FotoBox4";
            this.FotoBox4.Size = new System.Drawing.Size(241, 152);
            this.FotoBox4.TabIndex = 7;
            this.FotoBox4.TabStop = false;
            this.FotoBox4.Click += new System.EventHandler(this.FotoBox4_Click);
            // 
            // FotoBox3
            // 
            this.FotoBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoBox3.Location = new System.Drawing.Point(7, 201);
            this.FotoBox3.Name = "FotoBox3";
            this.FotoBox3.Size = new System.Drawing.Size(241, 126);
            this.FotoBox3.TabIndex = 6;
            this.FotoBox3.TabStop = false;
            this.FotoBox3.Click += new System.EventHandler(this.FotoBox3_Click);
            // 
            // FotoBox2
            // 
            this.FotoBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoBox2.Location = new System.Drawing.Point(254, 6);
            this.FotoBox2.Name = "FotoBox2";
            this.FotoBox2.Size = new System.Drawing.Size(311, 182);
            this.FotoBox2.TabIndex = 5;
            this.FotoBox2.TabStop = false;
            this.FotoBox2.Click += new System.EventHandler(this.FotoBox2_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(283, 254);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(282, 20);
            this.txtModelo.TabIndex = 4;
            this.txtModelo.Text = "Modelo";
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(283, 280);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(282, 20);
            this.txtCilindrada.TabIndex = 3;
            this.txtCilindrada.Text = "Cilindrada";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(283, 334);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(282, 125);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Text = "Descripcion";
            // 
            // FotoBox1
            // 
            this.FotoBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoBox1.Location = new System.Drawing.Point(7, 7);
            this.FotoBox1.Name = "FotoBox1";
            this.FotoBox1.Size = new System.Drawing.Size(241, 181);
            this.FotoBox1.TabIndex = 1;
            this.FotoBox1.TabStop = false;
            this.FotoBox1.Click += new System.EventHandler(this.FotoBox1_Click);
            // 
            // Previsualizar
            // 
            this.Previsualizar.Controls.Add(this.HtmlPreview);
            this.Previsualizar.Location = new System.Drawing.Point(4, 22);
            this.Previsualizar.Name = "Previsualizar";
            this.Previsualizar.Padding = new System.Windows.Forms.Padding(3);
            this.Previsualizar.Size = new System.Drawing.Size(571, 544);
            this.Previsualizar.TabIndex = 1;
            this.Previsualizar.Text = "Previsualizar";
            this.Previsualizar.UseVisualStyleBackColor = true;
            // 
            // HtmlPreview
            // 
            this.HtmlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HtmlPreview.Location = new System.Drawing.Point(3, 3);
            this.HtmlPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.HtmlPreview.Name = "HtmlPreview";
            this.HtmlPreview.Size = new System.Drawing.Size(565, 538);
            this.HtmlPreview.TabIndex = 0;
            this.HtmlPreview.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Publicar
            // 
            this.Publicar.Controls.Add(this.label4);
            this.Publicar.Controls.Add(this.label3);
            this.Publicar.Controls.Add(this.button1);
            this.Publicar.Controls.Add(this.btnGuardarJPG);
            this.Publicar.Location = new System.Drawing.Point(4, 22);
            this.Publicar.Name = "Publicar";
            this.Publicar.Padding = new System.Windows.Forms.Padding(3);
            this.Publicar.Size = new System.Drawing.Size(571, 544);
            this.Publicar.TabIndex = 2;
            this.Publicar.Text = "Publicar/Guardar";
            this.Publicar.UseVisualStyleBackColor = true;
            // 
            // Config
            // 
            this.Config.Controls.Add(this.label1);
            this.Config.Controls.Add(this.txtCarpetaTrabajo);
            this.Config.Controls.Add(this.lblCarpeta);
            this.Config.Controls.Add(this.btnSeleccionarWorkingFolder);
            this.Config.Location = new System.Drawing.Point(4, 22);
            this.Config.Name = "Config";
            this.Config.Size = new System.Drawing.Size(571, 544);
            this.Config.TabIndex = 3;
            this.Config.Text = "Configuración";
            this.Config.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Carpeta de trabajo";
            // 
            // txtCarpetaTrabajo
            // 
            this.txtCarpetaTrabajo.Location = new System.Drawing.Point(174, 100);
            this.txtCarpetaTrabajo.Name = "txtCarpetaTrabajo";
            this.txtCarpetaTrabajo.ReadOnly = true;
            this.txtCarpetaTrabajo.Size = new System.Drawing.Size(225, 20);
            this.txtCarpetaTrabajo.TabIndex = 4;
            // 
            // lblCarpeta
            // 
            this.lblCarpeta.AutoSize = true;
            this.lblCarpeta.Location = new System.Drawing.Point(193, 81);
            this.lblCarpeta.Name = "lblCarpeta";
            this.lblCarpeta.Size = new System.Drawing.Size(0, 13);
            this.lblCarpeta.TabIndex = 3;
            // 
            // btnSeleccionarWorkingFolder
            // 
            this.btnSeleccionarWorkingFolder.Location = new System.Drawing.Point(93, 98);
            this.btnSeleccionarWorkingFolder.Name = "btnSeleccionarWorkingFolder";
            this.btnSeleccionarWorkingFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarWorkingFolder.TabIndex = 2;
            this.btnSeleccionarWorkingFolder.Text = "Seleccionar";
            this.btnSeleccionarWorkingFolder.UseVisualStyleBackColor = true;
            this.btnSeleccionarWorkingFolder.Click += new System.EventHandler(this.btnSeleccionarWorkingFolder_Click);
            // 
            // AbrirArchivo
            // 
            this.AbrirArchivo.FileName = "Abrir Imágen";
            this.AbrirArchivo.Filter = "Archivos JPG (*.JPG)|*.jpg|Todos los archivos (*.*)|*.*";
            // 
            // btnGuardarJPG
            // 
            this.btnGuardarJPG.Location = new System.Drawing.Point(27, 59);
            this.btnGuardarJPG.Name = "btnGuardarJPG";
            this.btnGuardarJPG.Size = new System.Drawing.Size(108, 23);
            this.btnGuardarJPG.TabIndex = 0;
            this.btnGuardarJPG.Text = "Guardar JPG";
            this.btnGuardarJPG.UseVisualStyleBackColor = true;
            this.btnGuardarJPG.Click += new System.EventHandler(this.btnGuardarJPG_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Guardar Proyecto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guardar la imágen en formato JPG para su publicación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Guarda proyecto en formato TITAN para su posterior edición";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 594);
            this.Controls.Add(this.tab1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Designer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tab1.ResumeLayout(false);
            this.Diseño.ResumeLayout(false);
            this.Diseño.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox1)).EndInit();
            this.Previsualizar.ResumeLayout(false);
            this.Publicar.ResumeLayout(false);
            this.Publicar.PerformLayout();
            this.Config.ResumeLayout(false);
            this.Config.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage Diseño;
        private System.Windows.Forms.TabPage Previsualizar;
        public System.Windows.Forms.PictureBox FotoBox1;
        private System.Windows.Forms.WebBrowser HtmlPreview;
        public System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtCilindrada;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TabPage Publicar;
        public System.Windows.Forms.PictureBox FotoBox4;
        public System.Windows.Forms.PictureBox FotoBox3;
        public System.Windows.Forms.PictureBox FotoBox2;
        private System.Windows.Forms.OpenFileDialog AbrirArchivo;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.Button btnFondo;
        private System.Windows.Forms.Label lblFondo;
        private System.Windows.Forms.TabPage Config;
        private System.Windows.Forms.FolderBrowserDialog AbrirCarpeta;
        private System.Windows.Forms.Label lblCarpeta;
        private System.Windows.Forms.Button btnSeleccionarWorkingFolder;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCarpetaTrabajo;
        private System.Windows.Forms.Button btnPlantillaPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnGuardarJPG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog GuardarJPG;

    }
}

