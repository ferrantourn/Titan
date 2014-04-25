namespace Titan
{
    partial class PlantillaPrecio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlantillaFondo1 = new System.Windows.Forms.PictureBox();
            this.PlantillaFondo3 = new System.Windows.Forms.PictureBox();
            this.PlantillaFondo2 = new System.Windows.Forms.PictureBox();
            this.PlantillaFondo4 = new System.Windows.Forms.PictureBox();
            this.btnElegirFondoPrecio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlantillaFondo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantillaFondo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantillaFondo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantillaFondo4)).BeginInit();
            this.SuspendLayout();
            // 
            // PlantillaFondo1
            // 
            this.PlantillaFondo1.Location = new System.Drawing.Point(13, 49);
            this.PlantillaFondo1.Name = "PlantillaFondo1";
            this.PlantillaFondo1.Size = new System.Drawing.Size(292, 47);
            this.PlantillaFondo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlantillaFondo1.TabIndex = 0;
            this.PlantillaFondo1.TabStop = false;
            this.PlantillaFondo1.Click += new System.EventHandler(this.PlantillaFondo1_Click);
            this.PlantillaFondo1.MouseEnter += new System.EventHandler(this.PlantillaFondo1_MouseEnter);
            this.PlantillaFondo1.MouseLeave += new System.EventHandler(this.PlantillaFondo1_MouseLeave);
            // 
            // PlantillaFondo3
            // 
            this.PlantillaFondo3.Location = new System.Drawing.Point(325, 49);
            this.PlantillaFondo3.Name = "PlantillaFondo3";
            this.PlantillaFondo3.Size = new System.Drawing.Size(292, 47);
            this.PlantillaFondo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlantillaFondo3.TabIndex = 1;
            this.PlantillaFondo3.TabStop = false;
            this.PlantillaFondo3.Click += new System.EventHandler(this.PlantillaFondo3_Click);
            this.PlantillaFondo3.MouseEnter += new System.EventHandler(this.PlantillaFondo3_MouseEnter);
            this.PlantillaFondo3.MouseLeave += new System.EventHandler(this.PlantillaFondo3_MouseLeave);
            // 
            // PlantillaFondo2
            // 
            this.PlantillaFondo2.Location = new System.Drawing.Point(13, 113);
            this.PlantillaFondo2.Name = "PlantillaFondo2";
            this.PlantillaFondo2.Size = new System.Drawing.Size(292, 47);
            this.PlantillaFondo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlantillaFondo2.TabIndex = 2;
            this.PlantillaFondo2.TabStop = false;
            this.PlantillaFondo2.Click += new System.EventHandler(this.PlantillaFondo2_Click);
            this.PlantillaFondo2.MouseEnter += new System.EventHandler(this.PlantillaFondo2_MouseEnter);
            this.PlantillaFondo2.MouseLeave += new System.EventHandler(this.PlantillaFondo2_MouseLeave);
            // 
            // PlantillaFondo4
            // 
            this.PlantillaFondo4.Location = new System.Drawing.Point(325, 113);
            this.PlantillaFondo4.Name = "PlantillaFondo4";
            this.PlantillaFondo4.Size = new System.Drawing.Size(292, 47);
            this.PlantillaFondo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlantillaFondo4.TabIndex = 3;
            this.PlantillaFondo4.TabStop = false;
            this.PlantillaFondo4.Click += new System.EventHandler(this.PlantillaFondo4_Click);
            this.PlantillaFondo4.MouseEnter += new System.EventHandler(this.PlantillaFondo4_MouseEnter);
            this.PlantillaFondo4.MouseLeave += new System.EventHandler(this.PlantillaFondo4_MouseLeave);
            // 
            // btnElegirFondoPrecio
            // 
            this.btnElegirFondoPrecio.Location = new System.Drawing.Point(13, 190);
            this.btnElegirFondoPrecio.Name = "btnElegirFondoPrecio";
            this.btnElegirFondoPrecio.Size = new System.Drawing.Size(145, 23);
            this.btnElegirFondoPrecio.TabIndex = 4;
            this.btnElegirFondoPrecio.Text = "Elegir desde archivo...";
            this.btnElegirFondoPrecio.UseVisualStyleBackColor = true;
            this.btnElegirFondoPrecio.Click += new System.EventHandler(this.btnElegirFondoPrecio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Elija un fondo para el precio:";
            // 
            // PlantillaPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(655, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnElegirFondoPrecio);
            this.Controls.Add(this.PlantillaFondo4);
            this.Controls.Add(this.PlantillaFondo2);
            this.Controls.Add(this.PlantillaFondo3);
            this.Controls.Add(this.PlantillaFondo1);
            this.MaximizeBox = false;
            this.Name = "PlantillaPrecio";
            this.Load += new System.EventHandler(this.PlantillaPrecio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlantillaFondo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantillaFondo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantillaFondo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlantillaFondo4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox PlantillaFondo1;
        public System.Windows.Forms.PictureBox PlantillaFondo3;
        public System.Windows.Forms.PictureBox PlantillaFondo2;
        public System.Windows.Forms.PictureBox PlantillaFondo4;
        private System.Windows.Forms.Button btnElegirFondoPrecio;
        private System.Windows.Forms.Label label1;
    }
}