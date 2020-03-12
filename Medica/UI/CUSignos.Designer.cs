namespace UI
{
    partial class CUSignos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUSignos));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbpul = new System.Windows.Forms.Label();
            this.lbpulso = new System.Windows.Forms.Label();
            this.cpbPulso = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbpre = new System.Windows.Forms.Label();
            this.lbpresion = new System.Windows.Forms.Label();
            this.cpbPresion = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbsatu = new System.Windows.Forms.Label();
            this.lbsaturacion = new System.Windows.Forms.Label();
            this.cpbStauracion = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTemp = new System.Windows.Forms.Label();
            this.lbTemperatura = new System.Windows.Forms.Label();
            this.cpbTemperatura = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.pbPulso = new UI.CUVProgressBar();
            this.pbPresion = new UI.CUVProgressBar();
            this.pbStauracion = new UI.CUVProgressBar();
            this.pbTemperatura = new UI.CUVProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(810, 130);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbpul);
            this.panel4.Controls.Add(this.pbPulso);
            this.panel4.Controls.Add(this.lbpulso);
            this.panel4.Controls.Add(this.cpbPulso);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(609, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 124);
            this.panel4.TabIndex = 3;
            // 
            // lbpul
            // 
            this.lbpul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpul.BackColor = System.Drawing.Color.Transparent;
            this.lbpul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpul.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbpul.Location = new System.Drawing.Point(99, 43);
            this.lbpul.Name = "lbpul";
            this.lbpul.Size = new System.Drawing.Size(71, 36);
            this.lbpul.TabIndex = 6;
            this.lbpul.Text = "0.Bm";
            this.lbpul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbpulso
            // 
            this.lbpulso.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbpulso.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbpulso.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpulso.ForeColor = System.Drawing.Color.White;
            this.lbpulso.Location = new System.Drawing.Point(0, 0);
            this.lbpulso.Name = "lbpulso";
            this.lbpulso.Padding = new System.Windows.Forms.Padding(7);
            this.lbpulso.Size = new System.Drawing.Size(25, 122);
            this.lbpulso.TabIndex = 2;
            this.lbpulso.Text = "Temperatura";
            this.lbpulso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpbPulso
            // 
            this.cpbPulso.animated = false;
            this.cpbPulso.animationIterval = 5;
            this.cpbPulso.animationSpeed = 300;
            this.cpbPulso.BackColor = System.Drawing.Color.White;
            this.cpbPulso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpbPulso.BackgroundImage")));
            this.cpbPulso.Dock = System.Windows.Forms.DockStyle.Right;
            this.cpbPulso.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpbPulso.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cpbPulso.LabelVisible = false;
            this.cpbPulso.LineProgressThickness = 8;
            this.cpbPulso.LineThickness = 2;
            this.cpbPulso.Location = new System.Drawing.Point(74, 0);
            this.cpbPulso.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpbPulso.MaxValue = 130;
            this.cpbPulso.Name = "cpbPulso";
            this.cpbPulso.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cpbPulso.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.cpbPulso.Size = new System.Drawing.Size(122, 122);
            this.cpbPulso.TabIndex = 1;
            this.cpbPulso.Value = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbpre);
            this.panel3.Controls.Add(this.pbPresion);
            this.panel3.Controls.Add(this.lbpresion);
            this.panel3.Controls.Add(this.cpbPresion);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(407, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 124);
            this.panel3.TabIndex = 2;
            // 
            // lbpre
            // 
            this.lbpre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpre.BackColor = System.Drawing.Color.Transparent;
            this.lbpre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpre.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbpre.Location = new System.Drawing.Point(98, 43);
            this.lbpre.Name = "lbpre";
            this.lbpre.Size = new System.Drawing.Size(71, 36);
            this.lbpre.TabIndex = 5;
            this.lbpre.Text = "0.Mg";
            this.lbpre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbpresion
            // 
            this.lbpresion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbpresion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbpresion.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpresion.ForeColor = System.Drawing.Color.White;
            this.lbpresion.Location = new System.Drawing.Point(0, 0);
            this.lbpresion.Name = "lbpresion";
            this.lbpresion.Padding = new System.Windows.Forms.Padding(7);
            this.lbpresion.Size = new System.Drawing.Size(25, 122);
            this.lbpresion.TabIndex = 2;
            this.lbpresion.Text = "Temperatura";
            this.lbpresion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpbPresion
            // 
            this.cpbPresion.animated = false;
            this.cpbPresion.animationIterval = 5;
            this.cpbPresion.animationSpeed = 300;
            this.cpbPresion.BackColor = System.Drawing.Color.White;
            this.cpbPresion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpbPresion.BackgroundImage")));
            this.cpbPresion.Dock = System.Windows.Forms.DockStyle.Right;
            this.cpbPresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpbPresion.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cpbPresion.LabelVisible = false;
            this.cpbPresion.LineProgressThickness = 8;
            this.cpbPresion.LineThickness = 2;
            this.cpbPresion.Location = new System.Drawing.Point(72, 0);
            this.cpbPresion.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpbPresion.MaxValue = 180;
            this.cpbPresion.Name = "cpbPresion";
            this.cpbPresion.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cpbPresion.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.cpbPresion.Size = new System.Drawing.Size(122, 122);
            this.cpbPresion.TabIndex = 1;
            this.cpbPresion.Value = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbsatu);
            this.panel2.Controls.Add(this.pbStauracion);
            this.panel2.Controls.Add(this.lbsaturacion);
            this.panel2.Controls.Add(this.cpbStauracion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(205, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 124);
            this.panel2.TabIndex = 1;
            // 
            // lbsatu
            // 
            this.lbsatu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbsatu.BackColor = System.Drawing.Color.Transparent;
            this.lbsatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsatu.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbsatu.Location = new System.Drawing.Point(98, 43);
            this.lbsatu.Name = "lbsatu";
            this.lbsatu.Size = new System.Drawing.Size(71, 36);
            this.lbsatu.TabIndex = 4;
            this.lbsatu.Text = "0.Sp";
            this.lbsatu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbsaturacion
            // 
            this.lbsaturacion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbsaturacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbsaturacion.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsaturacion.ForeColor = System.Drawing.Color.White;
            this.lbsaturacion.Location = new System.Drawing.Point(0, 0);
            this.lbsaturacion.Name = "lbsaturacion";
            this.lbsaturacion.Padding = new System.Windows.Forms.Padding(7);
            this.lbsaturacion.Size = new System.Drawing.Size(25, 122);
            this.lbsaturacion.TabIndex = 2;
            this.lbsaturacion.Text = "Temperatura";
            this.lbsaturacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpbStauracion
            // 
            this.cpbStauracion.animated = false;
            this.cpbStauracion.animationIterval = 5;
            this.cpbStauracion.animationSpeed = 300;
            this.cpbStauracion.BackColor = System.Drawing.Color.White;
            this.cpbStauracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpbStauracion.BackgroundImage")));
            this.cpbStauracion.Dock = System.Windows.Forms.DockStyle.Right;
            this.cpbStauracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpbStauracion.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cpbStauracion.LabelVisible = false;
            this.cpbStauracion.LineProgressThickness = 8;
            this.cpbStauracion.LineThickness = 2;
            this.cpbStauracion.Location = new System.Drawing.Point(72, 0);
            this.cpbStauracion.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpbStauracion.MaxValue = 150;
            this.cpbStauracion.Name = "cpbStauracion";
            this.cpbStauracion.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cpbStauracion.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.cpbStauracion.Size = new System.Drawing.Size(122, 122);
            this.cpbStauracion.TabIndex = 1;
            this.cpbStauracion.Value = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbTemp);
            this.panel1.Controls.Add(this.pbTemperatura);
            this.panel1.Controls.Add(this.lbTemperatura);
            this.panel1.Controls.Add(this.cpbTemperatura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 124);
            this.panel1.TabIndex = 0;
            // 
            // lbTemp
            // 
            this.lbTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTemp.BackColor = System.Drawing.Color.Transparent;
            this.lbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTemp.Location = new System.Drawing.Point(97, 43);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(71, 36);
            this.lbTemp.TabIndex = 3;
            this.lbTemp.Text = "0°C";
            this.lbTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTemperatura
            // 
            this.lbTemperatura.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTemperatura.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTemperatura.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemperatura.ForeColor = System.Drawing.Color.White;
            this.lbTemperatura.Location = new System.Drawing.Point(0, 0);
            this.lbTemperatura.Name = "lbTemperatura";
            this.lbTemperatura.Padding = new System.Windows.Forms.Padding(7);
            this.lbTemperatura.Size = new System.Drawing.Size(25, 122);
            this.lbTemperatura.TabIndex = 1;
            this.lbTemperatura.Text = "Temperatura";
            this.lbTemperatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpbTemperatura
            // 
            this.cpbTemperatura.animated = false;
            this.cpbTemperatura.animationIterval = 5;
            this.cpbTemperatura.animationSpeed = 300;
            this.cpbTemperatura.BackColor = System.Drawing.Color.White;
            this.cpbTemperatura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpbTemperatura.BackgroundImage")));
            this.cpbTemperatura.Dock = System.Windows.Forms.DockStyle.Right;
            this.cpbTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpbTemperatura.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cpbTemperatura.LabelVisible = false;
            this.cpbTemperatura.LineProgressThickness = 8;
            this.cpbTemperatura.LineThickness = 2;
            this.cpbTemperatura.Location = new System.Drawing.Point(72, 0);
            this.cpbTemperatura.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpbTemperatura.MaxValue = 50;
            this.cpbTemperatura.Name = "cpbTemperatura";
            this.cpbTemperatura.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cpbTemperatura.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.cpbTemperatura.Size = new System.Drawing.Size(122, 122);
            this.cpbTemperatura.TabIndex = 0;
            this.cpbTemperatura.Value = 0;
            // 
            // reloj
            // 
            this.reloj.Enabled = true;
            this.reloj.Interval = 350;
            this.reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // pbPulso
            // 
            this.pbPulso.BarraColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbPulso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPulso.Location = new System.Drawing.Point(25, 0);
            this.pbPulso.Maximum = 130;
            this.pbPulso.Name = "pbPulso";
            this.pbPulso.Size = new System.Drawing.Size(49, 122);
            this.pbPulso.TabIndex = 3;
            // 
            // pbPresion
            // 
            this.pbPresion.BarraColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbPresion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPresion.Location = new System.Drawing.Point(25, 0);
            this.pbPresion.Maximum = 180;
            this.pbPresion.Name = "pbPresion";
            this.pbPresion.Size = new System.Drawing.Size(47, 122);
            this.pbPresion.TabIndex = 3;
            // 
            // pbStauracion
            // 
            this.pbStauracion.BarraColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbStauracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbStauracion.Location = new System.Drawing.Point(25, 0);
            this.pbStauracion.Maximum = 150;
            this.pbStauracion.Name = "pbStauracion";
            this.pbStauracion.Size = new System.Drawing.Size(47, 122);
            this.pbStauracion.TabIndex = 3;
            // 
            // pbTemperatura
            // 
            this.pbTemperatura.BarraColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbTemperatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTemperatura.Location = new System.Drawing.Point(25, 0);
            this.pbTemperatura.Maximum = 50;
            this.pbTemperatura.Name = "pbTemperatura";
            this.pbTemperatura.Size = new System.Drawing.Size(47, 122);
            this.pbTemperatura.TabIndex = 2;
            // 
            // CUSignos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CUSignos";
            this.Size = new System.Drawing.Size(810, 130);
            this.Load += new System.EventHandler(this.CUSignos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpbPulso;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpbPresion;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpbStauracion;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpbTemperatura;
        private System.Windows.Forms.Label lbTemperatura;
        private System.Windows.Forms.Label lbpulso;
        private System.Windows.Forms.Label lbpresion;
        private System.Windows.Forms.Label lbsaturacion;
        private System.Windows.Forms.Timer reloj;
        private CUVProgressBar pbPulso;
        private CUVProgressBar pbPresion;
        private CUVProgressBar pbStauracion;
        private CUVProgressBar pbTemperatura;
        private System.Windows.Forms.Label lbpul;
        private System.Windows.Forms.Label lbpre;
        private System.Windows.Forms.Label lbsatu;
        private System.Windows.Forms.Label lbTemp;
    }
}
