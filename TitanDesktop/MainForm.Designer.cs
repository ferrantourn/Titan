﻿namespace Titan
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
            this.AbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.btnFondo = new System.Windows.Forms.Button();
            this.lblFondo = new System.Windows.Forms.Label();
            this.tab1.SuspendLayout();
            this.Diseño.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox1)).BeginInit();
            this.Previsualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.Diseño);
            this.tab1.Controls.Add(this.Previsualizar);
            this.tab1.Controls.Add(this.Publicar);
            this.tab1.Location = new System.Drawing.Point(13, 13);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(579, 559);
            this.tab1.TabIndex = 0;
            // 
            // Diseño
            // 
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
            this.Diseño.Size = new System.Drawing.Size(571, 533);
            this.Diseño.TabIndex = 0;
            this.Diseño.Text = "Diseño";
            this.Diseño.UseVisualStyleBackColor = true;
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
            this.txtModelo.Location = new System.Drawing.Point(283, 194);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(282, 20);
            this.txtModelo.TabIndex = 4;
            this.txtModelo.Text = "Modelo";
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(283, 220);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(282, 20);
            this.txtCilindrada.TabIndex = 3;
            this.txtCilindrada.Text = "Cilindrada";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(283, 273);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(282, 213);
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
            this.Previsualizar.Size = new System.Drawing.Size(571, 533);
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
            this.HtmlPreview.Size = new System.Drawing.Size(565, 527);
            this.HtmlPreview.TabIndex = 0;
            this.HtmlPreview.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Publicar
            // 
            this.Publicar.Location = new System.Drawing.Point(4, 22);
            this.Publicar.Name = "Publicar";
            this.Publicar.Padding = new System.Windows.Forms.Padding(3);
            this.Publicar.Size = new System.Drawing.Size(571, 533);
            this.Publicar.TabIndex = 2;
            this.Publicar.Text = "Publicar";
            this.Publicar.UseVisualStyleBackColor = true;
            // 
            // AbrirArchivo
            // 
            this.AbrirArchivo.FileName = "Abrir Imágen";
            this.AbrirArchivo.Filter = "Archivos JPG (*.JPG)|*.jpg|Todos los archivos (*.*)|*.*";
            // 
            // txtMotor
            // 
            this.txtMotor.Location = new System.Drawing.Point(283, 247);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(282, 20);
            this.txtMotor.TabIndex = 8;
            this.txtMotor.Text = "Motor";
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
            // lblFondo
            // 
            this.lblFondo.AutoSize = true;
            this.lblFondo.Location = new System.Drawing.Point(137, 498);
            this.lblFondo.Name = "lblFondo";
            this.lblFondo.Size = new System.Drawing.Size(0, 13);
            this.lblFondo.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 584);
            this.Controls.Add(this.tab1);
            this.Name = "MainForm";
            this.Text = "Designer";
            this.tab1.ResumeLayout(false);
            this.Diseño.ResumeLayout(false);
            this.Diseño.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoBox1)).EndInit();
            this.Previsualizar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage Diseño;
        private System.Windows.Forms.TabPage Previsualizar;
        private System.Windows.Forms.PictureBox FotoBox1;
        private System.Windows.Forms.WebBrowser HtmlPreview;
        public System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtCilindrada;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TabPage Publicar;
        private System.Windows.Forms.PictureBox FotoBox4;
        private System.Windows.Forms.PictureBox FotoBox3;
        private System.Windows.Forms.PictureBox FotoBox2;
        private System.Windows.Forms.OpenFileDialog AbrirArchivo;
        private System.Windows.Forms.TextBox txtMotor;
        private System.Windows.Forms.Button btnFondo;
        private System.Windows.Forms.Label lblFondo;
    }
}

