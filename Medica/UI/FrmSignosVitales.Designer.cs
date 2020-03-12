namespace UI
{
    partial class FrmSignosVitales
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
            this.cuTemperatura1 = new UI.CUTemperatura();
            this.cuSaturacion1 = new UI.CUSaturacion();
            this.cuPulsoLatido1 = new UI.CUPulsoLatido();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.pnBody.Controls.Add(this.cuTemperatura1);
            this.pnBody.Controls.Add(this.cuPulsoLatido1);
            this.pnBody.Controls.Add(this.cuSaturacion1);
            // 
            // cuTemperatura1
            // 
            this.cuTemperatura1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.cuTemperatura1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuTemperatura1.Location = new System.Drawing.Point(0, 196);
            this.cuTemperatura1.Name = "cuTemperatura1";
            this.cuTemperatura1.Size = new System.Drawing.Size(810, 198);
            this.cuTemperatura1.TabIndex = 2;
            this.cuTemperatura1.TextIngreso = false;
            // 
            // cuSaturacion1
            // 
            this.cuSaturacion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.cuSaturacion1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cuSaturacion1.Location = new System.Drawing.Point(0, 394);
            this.cuSaturacion1.Name = "cuSaturacion1";
            this.cuSaturacion1.Size = new System.Drawing.Size(810, 196);
            this.cuSaturacion1.TabIndex = 3;
            this.cuSaturacion1.TextIngreso = false;
            // 
            // cuPulsoLatido1
            // 
            this.cuPulsoLatido1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.cuPulsoLatido1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuPulsoLatido1.Location = new System.Drawing.Point(0, 0);
            this.cuPulsoLatido1.Name = "cuPulsoLatido1";
            this.cuPulsoLatido1.Size = new System.Drawing.Size(810, 196);
            this.cuPulsoLatido1.TabIndex = 4;
            this.cuPulsoLatido1.TextIngreso = false;
            // 
            // FrmSignosVitales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 590);
            this.Name = "FrmSignosVitales";
            this.Text = "FrmSignosVitales";
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CUTemperatura cuTemperatura1;
        private CUSaturacion cuSaturacion1;
        private CUPulsoLatido cuPulsoLatido1;
    }
}