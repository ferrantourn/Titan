namespace Titan
{
    partial class Resizer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SrcPicBox = new System.Windows.Forms.PictureBox();
            this.TargetPicBox = new System.Windows.Forms.PictureBox();
            this.lbCordinates = new System.Windows.Forms.Label();
            this.btnCortar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SrcPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.TargetPicBox);
            this.panel1.Controls.Add(this.SrcPicBox);
            this.panel1.Controls.Add(this.lbCordinates);
            this.panel1.Controls.Add(this.btnCortar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 662);
            this.panel1.TabIndex = 1;
            // 
            // SrcPicBox
            // 
            this.SrcPicBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.SrcPicBox.Location = new System.Drawing.Point(15, 218);
            this.SrcPicBox.Name = "SrcPicBox";
            this.SrcPicBox.Size = new System.Drawing.Size(125, 125);
            this.SrcPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SrcPicBox.TabIndex = 5;
            this.SrcPicBox.TabStop = false;
            this.SrcPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SrcPicBox_Paint);
            this.SrcPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SrcPicBox_MouseDown);
            this.SrcPicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SrcPicBox_MouseMove);
            this.SrcPicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SrcPicBox_MouseUp);
            // 
            // TargetPicBox
            // 
            this.TargetPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TargetPicBox.Location = new System.Drawing.Point(422, 12);
            this.TargetPicBox.Name = "TargetPicBox";
            this.TargetPicBox.Size = new System.Drawing.Size(250, 250);
            this.TargetPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TargetPicBox.TabIndex = 4;
            this.TargetPicBox.TabStop = false;
            // 
            // lbCordinates
            // 
            this.lbCordinates.AutoSize = true;
            this.lbCordinates.Location = new System.Drawing.Point(12, 44);
            this.lbCordinates.Name = "lbCordinates";
            this.lbCordinates.Size = new System.Drawing.Size(25, 13);
            this.lbCordinates.TabIndex = 2;
            this.lbCordinates.Text = "___";
            // 
            // btnCortar
            // 
            this.btnCortar.Location = new System.Drawing.Point(13, 189);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(75, 23);
            this.btnCortar.TabIndex = 3;
            this.btnCortar.Text = "Cortar";
            this.btnCortar.UseVisualStyleBackColor = true;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 12);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAceptar.Size = new System.Drawing.Size(137, 29);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar y Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 61);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Resizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 662);
            this.Controls.Add(this.panel1);
            this.Name = "Resizer";
            this.Text = "Resizer";
            this.Load += new System.EventHandler(this.Resizer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SrcPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Label lbCordinates;
        private System.Windows.Forms.PictureBox TargetPicBox;
        public System.Windows.Forms.PictureBox SrcPicBox;
        private System.Windows.Forms.Button btnCancelar;
    }
}