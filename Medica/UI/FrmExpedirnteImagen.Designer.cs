namespace UI
{
    partial class FrmExpedirnteImagen
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
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.pnBody.Controls.Add(this.pbImagen);
            this.pnBody.Controls.Add(this.pbRight);
            this.pnBody.Controls.Add(this.pbLeft);
            // 
            // pbImagen
            // 
            this.pbImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImagen.Location = new System.Drawing.Point(100, 0);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Padding = new System.Windows.Forms.Padding(15);
            this.pbImagen.Size = new System.Drawing.Size(610, 590);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 2;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbImagen_Click);
            // 
            // pbRight
            // 
            this.pbRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbRight.Location = new System.Drawing.Point(710, 0);
            this.pbRight.Name = "pbRight";
            this.pbRight.Padding = new System.Windows.Forms.Padding(15);
            this.pbRight.Size = new System.Drawing.Size(100, 590);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRight.TabIndex = 1;
            this.pbRight.TabStop = false;
            this.pbRight.Click += new System.EventHandler(this.pbRight_Click);
            this.pbRight.MouseEnter += new System.EventHandler(this.pbRight_MouseEnter);
            this.pbRight.MouseLeave += new System.EventHandler(this.pbRight_MouseLeave);
            // 
            // pbLeft
            // 
            this.pbLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLeft.Location = new System.Drawing.Point(0, 0);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Padding = new System.Windows.Forms.Padding(15);
            this.pbLeft.Size = new System.Drawing.Size(100, 590);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeft.TabIndex = 0;
            this.pbLeft.TabStop = false;
            this.pbLeft.Click += new System.EventHandler(this.pbLeft_Click);
            this.pbLeft.MouseEnter += new System.EventHandler(this.pbLeft_MouseEnter);
            this.pbLeft.MouseLeave += new System.EventHandler(this.pbLeft_MouseLeave);
            // 
            // FrmExpedirnteImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 590);
            this.Name = "FrmExpedirnteImagen";
            this.Text = "FrmInicio";
            this.pnBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.PictureBox pbLeft;
    }
}