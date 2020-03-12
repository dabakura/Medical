namespace UI
{
    partial class CUPulsoLatido
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUPulsoLatido));
            this.lbfrecuencia = new System.Windows.Forms.Label();
            this.bunifuDataViz1 = new Bunifu.DataViz.BunifuDataViz();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbcorazon = new System.Windows.Forms.PictureBox();
            this.switchbutton = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbText = new System.Windows.Forms.Label();
            this.pbTemperatura = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.txtTemperatura = new UCErrorTextBox.ErrorTxtBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcorazon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbfrecuencia
            // 
            this.lbfrecuencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbfrecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfrecuencia.ForeColor = System.Drawing.Color.White;
            this.lbfrecuencia.Location = new System.Drawing.Point(329, 0);
            this.lbfrecuencia.Name = "lbfrecuencia";
            this.lbfrecuencia.Size = new System.Drawing.Size(481, 22);
            this.lbfrecuencia.TabIndex = 11;
            this.lbfrecuencia.Text = "Historial de Frecuencia Cardiaca";
            this.lbfrecuencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDataViz1
            // 
            this.bunifuDataViz1.animationEnabled = false;
            this.bunifuDataViz1.AxisLineColor = System.Drawing.Color.Gold;
            this.bunifuDataViz1.AxisXFontColor = System.Drawing.Color.White;
            this.bunifuDataViz1.AxisXGridColor = System.Drawing.Color.Gainsboro;
            this.bunifuDataViz1.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz1.AxisYFontColor = System.Drawing.Color.White;
            this.bunifuDataViz1.AxisYGridColor = System.Drawing.Color.Gainsboro;
            this.bunifuDataViz1.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDataViz1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuDataViz1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuDataViz1.Location = new System.Drawing.Point(329, 0);
            this.bunifuDataViz1.Name = "bunifuDataViz1";
            this.bunifuDataViz1.Size = new System.Drawing.Size(481, 196);
            this.bunifuDataViz1.TabIndex = 10;
            this.bunifuDataViz1.Theme = Bunifu.DataViz.BunifuDataViz._theme.theme1;
            this.bunifuDataViz1.Title = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbcorazon);
            this.panel2.Controls.Add(this.switchbutton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 196);
            this.panel2.TabIndex = 9;
            // 
            // pbcorazon
            // 
            this.pbcorazon.Image = global::UI.Properties.Resources.corablue;
            this.pbcorazon.Location = new System.Drawing.Point(3, 75);
            this.pbcorazon.Name = "pbcorazon";
            this.pbcorazon.Size = new System.Drawing.Size(98, 98);
            this.pbcorazon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbcorazon.TabIndex = 7;
            this.pbcorazon.TabStop = false;
            // 
            // switchbutton
            // 
            this.switchbutton.BackColor = System.Drawing.Color.Transparent;
            this.switchbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchbutton.BackgroundImage")));
            this.switchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchbutton.Location = new System.Drawing.Point(33, 34);
            this.switchbutton.Name = "switchbutton";
            this.switchbutton.OffColor = System.Drawing.Color.Gray;
            this.switchbutton.OnColor = System.Drawing.Color.DeepSkyBlue;
            this.switchbutton.Size = new System.Drawing.Size(35, 20);
            this.switchbutton.TabIndex = 6;
            this.switchbutton.Value = true;
            this.switchbutton.OnValueChange += new System.EventHandler(this.switchbutton_OnValueChange);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Presion-Pulso";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbText);
            this.panel1.Controls.Add(this.pbTemperatura);
            this.panel1.Controls.Add(this.txtTemperatura);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Location = new System.Drawing.Point(107, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 190);
            this.panel1.TabIndex = 2;
            // 
            // lbText
            // 
            this.lbText.BackColor = System.Drawing.Color.Transparent;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbText.Location = new System.Drawing.Point(22, 67);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(128, 42);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "0.Bm";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbText.Click += new System.EventHandler(this.bunifuCircleProgressbar1_Click);
            // 
            // pbTemperatura
            // 
            this.pbTemperatura.animated = true;
            this.pbTemperatura.animationIterval = 12;
            this.pbTemperatura.animationSpeed = 100;
            this.pbTemperatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.pbTemperatura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTemperatura.BackgroundImage")));
            this.pbTemperatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbTemperatura.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pbTemperatura.LabelVisible = false;
            this.pbTemperatura.LineProgressThickness = 10;
            this.pbTemperatura.LineThickness = 2;
            this.pbTemperatura.Location = new System.Drawing.Point(0, 0);
            this.pbTemperatura.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pbTemperatura.MaxValue = 150;
            this.pbTemperatura.Name = "pbTemperatura";
            this.pbTemperatura.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.pbTemperatura.ProgressColor = System.Drawing.Color.SpringGreen;
            this.pbTemperatura.Size = new System.Drawing.Size(170, 170);
            this.pbTemperatura.TabIndex = 0;
            this.pbTemperatura.Value = 0;
            this.pbTemperatura.Click += new System.EventHandler(this.bunifuCircleProgressbar1_Click);
            this.pbTemperatura.Resize += new System.EventHandler(this.bunifuCircleProgressbar1_Resize);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.AutoClear = false;
            this.txtTemperatura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTemperatura.Location = new System.Drawing.Point(0, 170);
            this.txtTemperatura.MaxLength = 3;
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(171, 20);
            this.txtTemperatura.TabIndex = 3;
            this.txtTemperatura.Validar = false;
            this.txtTemperatura.ValidarContraseñas = false;
            this.txtTemperatura.ValidarDouble = false;
            this.txtTemperatura.ValidarInt32 = true;
            this.txtTemperatura.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.trackBar1.Location = new System.Drawing.Point(171, 0);
            this.trackBar1.Maximum = 150;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 190);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 700;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CUPulsoLatido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.lbfrecuencia);
            this.Controls.Add(this.bunifuDataViz1);
            this.Controls.Add(this.panel2);
            this.Name = "CUPulsoLatido";
            this.Size = new System.Drawing.Size(810, 196);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbcorazon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbfrecuencia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbText;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pbTemperatura;
        private UCErrorTextBox.ErrorTxtBox txtTemperatura;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbcorazon;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchbutton;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.DataViz.BunifuDataViz bunifuDataViz1;
    }
}
