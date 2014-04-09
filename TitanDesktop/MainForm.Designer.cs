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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Previsualizar = new System.Windows.Forms.TabPage();
            this.HtmlPreview = new System.Windows.Forms.WebBrowser();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTitulo2 = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.Publicar = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tab1.SuspendLayout();
            this.Diseño.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Previsualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.tab1.Size = new System.Drawing.Size(579, 531);
            this.tab1.TabIndex = 0;
            // 
            // Diseño
            // 
            this.Diseño.Controls.Add(this.pictureBox4);
            this.Diseño.Controls.Add(this.pictureBox3);
            this.Diseño.Controls.Add(this.pictureBox2);
            this.Diseño.Controls.Add(this.txtTitulo);
            this.Diseño.Controls.Add(this.txtTitulo2);
            this.Diseño.Controls.Add(this.txtDescripcion);
            this.Diseño.Controls.Add(this.pictureBox1);
            this.Diseño.Location = new System.Drawing.Point(4, 22);
            this.Diseño.Name = "Diseño";
            this.Diseño.Padding = new System.Windows.Forms.Padding(3);
            this.Diseño.Size = new System.Drawing.Size(571, 505);
            this.Diseño.TabIndex = 0;
            this.Diseño.Text = "Diseño";
            this.Diseño.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 187);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Previsualizar
            // 
            this.Previsualizar.Controls.Add(this.HtmlPreview);
            this.Previsualizar.Location = new System.Drawing.Point(4, 22);
            this.Previsualizar.Name = "Previsualizar";
            this.Previsualizar.Padding = new System.Windows.Forms.Padding(3);
            this.Previsualizar.Size = new System.Drawing.Size(571, 505);
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
            this.HtmlPreview.Size = new System.Drawing.Size(565, 499);
            this.HtmlPreview.TabIndex = 0;
            this.HtmlPreview.Url = new System.Uri("/preview.html", System.UriKind.Relative);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(283, 246);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(282, 253);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtTitulo2
            // 
            this.txtTitulo2.Location = new System.Drawing.Point(283, 220);
            this.txtTitulo2.Name = "txtTitulo2";
            this.txtTitulo2.Size = new System.Drawing.Size(282, 20);
            this.txtTitulo2.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(283, 194);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(282, 20);
            this.txtTitulo.TabIndex = 4;
            // 
            // Publicar
            // 
            this.Publicar.Location = new System.Drawing.Point(4, 22);
            this.Publicar.Name = "Publicar";
            this.Publicar.Padding = new System.Windows.Forms.Padding(3);
            this.Publicar.Size = new System.Drawing.Size(571, 505);
            this.Publicar.TabIndex = 2;
            this.Publicar.Text = "Publicar";
            this.Publicar.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(254, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(311, 182);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(7, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(241, 126);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(7, 334);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(241, 165);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 577);
            this.Controls.Add(this.tab1);
            this.Name = "MainForm";
            this.Text = "Designer";
            this.tab1.ResumeLayout(false);
            this.Diseño.ResumeLayout(false);
            this.Diseño.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Previsualizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage Diseño;
        private System.Windows.Forms.TabPage Previsualizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser HtmlPreview;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtTitulo2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TabPage Publicar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

