namespace UI
{
    partial class CUTemperatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUTemperatura));
            this.lbText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbTemperatura = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.txtTemperatura = new UCErrorTextBox.ErrorTxtBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelbarra = new System.Windows.Forms.Label();
            this.pictureBoxTer = new System.Windows.Forms.PictureBox();
            this.bunifuDataViz1 = new Bunifu.DataViz.BunifuDataViz();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTer)).BeginInit();
            this.SuspendLayout();
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
            this.lbText.Text = "0°C";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbText.Click += new System.EventHandler(this.bunifuCircleProgressbar1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbText);
            this.panel1.Controls.Add(this.pbTemperatura);
            this.panel1.Controls.Add(this.txtTemperatura);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Location = new System.Drawing.Point(70, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 190);
            this.panel1.TabIndex = 2;
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
            this.pbTemperatura.MaxValue = 50;
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
            this.txtTemperatura.MaxLength = 6;
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(171, 20);
            this.txtTemperatura.TabIndex = 3;
            this.txtTemperatura.Validar = false;
            this.txtTemperatura.ValidarContraseñas = false;
            this.txtTemperatura.ValidarDouble = true;
            this.txtTemperatura.ValidarInt32 = false;
            this.txtTemperatura.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.trackBar1.Location = new System.Drawing.Point(171, 0);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 190);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelbarra);
            this.panel2.Controls.Add(this.pictureBoxTer);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 196);
            this.panel2.TabIndex = 3;
            // 
            // labelbarra
            // 
            this.labelbarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(184)))), ((int)(((byte)(227)))));
            this.labelbarra.Location = new System.Drawing.Point(28, 44);
            this.labelbarra.Name = "labelbarra";
            this.labelbarra.Size = new System.Drawing.Size(8, 0);
            this.labelbarra.TabIndex = 6;
            // 
            // pictureBoxTer
            // 
            this.pictureBoxTer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTer.Image")));
            this.pictureBoxTer.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxTer.Name = "pictureBoxTer";
            this.pictureBoxTer.Size = new System.Drawing.Size(61, 190);
            this.pictureBoxTer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTer.TabIndex = 5;
            this.pictureBoxTer.TabStop = false;
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
            this.bunifuDataViz1.Location = new System.Drawing.Point(286, 0);
            this.bunifuDataViz1.Name = "bunifuDataViz1";
            this.bunifuDataViz1.Size = new System.Drawing.Size(524, 196);
            this.bunifuDataViz1.TabIndex = 4;
            this.bunifuDataViz1.Theme = Bunifu.DataViz.BunifuDataViz._theme.theme1;
            this.bunifuDataViz1.Title = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Historial de Temperaturas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CUTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuDataViz1);
            this.Controls.Add(this.panel2);
            this.Name = "CUTemperatura";
            this.Size = new System.Drawing.Size(810, 196);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar pbTemperatura;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Panel panel1;
        private UCErrorTextBox.ErrorTxtBox txtTemperatura;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.DataViz.BunifuDataViz bunifuDataViz1;
        private System.Windows.Forms.PictureBox pictureBoxTer;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelbarra;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}
