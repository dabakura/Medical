namespace UI
{
    partial class FrmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacientes));
            this.cuCarpeta2 = new UI.CUCarpeta();
            this.cuCarpeta5 = new UI.CUCarpeta();
            this.cuCarpeta4 = new UI.CUCarpeta();
            this.cuCarpeta1 = new UI.CUCarpeta();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.GhostWhite;
            this.pnBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnBody.BackgroundImage")));
            this.pnBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBody.Controls.Add(this.label1);
            this.pnBody.Controls.Add(this.cuCarpeta2);
            this.pnBody.Controls.Add(this.cuCarpeta5);
            this.pnBody.Controls.Add(this.cuCarpeta4);
            this.pnBody.Controls.Add(this.cuCarpeta1);
            this.pnBody.Resize += new System.EventHandler(this.pnBody_Resize);
            // 
            // cuCarpeta2
            // 
            this.cuCarpeta2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuCarpeta2.BackColor = System.Drawing.Color.Transparent;
            this.cuCarpeta2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.cuCarpeta2.ButtonColorActive = System.Drawing.Color.RoyalBlue;
            this.cuCarpeta2.ButtonForeColor = System.Drawing.Color.White;
            this.cuCarpeta2.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.cuCarpeta2.CardColorBack = System.Drawing.Color.Transparent;
            this.cuCarpeta2.ImageIco = global::UI.Properties.Resources.userSave;
            this.cuCarpeta2.LabelText = "Modificar";
            this.cuCarpeta2.Location = new System.Drawing.Point(421, 448);
            this.cuCarpeta2.Name = "cuCarpeta2";
            this.cuCarpeta2.Size = new System.Drawing.Size(168, 142);
            this.cuCarpeta2.TabIndex = 5;
            this.cuCarpeta2.Click += new System.EventHandler(this.cuCarpeta2_Load);
            // 
            // cuCarpeta5
            // 
            this.cuCarpeta5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuCarpeta5.BackColor = System.Drawing.Color.Transparent;
            this.cuCarpeta5.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.cuCarpeta5.ButtonColorActive = System.Drawing.Color.RoyalBlue;
            this.cuCarpeta5.ButtonForeColor = System.Drawing.Color.White;
            this.cuCarpeta5.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.cuCarpeta5.CardColorBack = System.Drawing.Color.Transparent;
            this.cuCarpeta5.ImageIco = global::UI.Properties.Resources.userBuscar;
            this.cuCarpeta5.LabelText = "Buscar";
            this.cuCarpeta5.Location = new System.Drawing.Point(217, 448);
            this.cuCarpeta5.Name = "cuCarpeta5";
            this.cuCarpeta5.Size = new System.Drawing.Size(168, 142);
            this.cuCarpeta5.TabIndex = 4;
            this.cuCarpeta5.Click += new System.EventHandler(this.cuCarpeta5_Load);
            // 
            // cuCarpeta4
            // 
            this.cuCarpeta4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuCarpeta4.BackColor = System.Drawing.Color.Transparent;
            this.cuCarpeta4.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cuCarpeta4.ButtonColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(13)))), ((int)(((byte)(41)))));
            this.cuCarpeta4.ButtonForeColor = System.Drawing.Color.White;
            this.cuCarpeta4.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cuCarpeta4.CardColorBack = System.Drawing.Color.Transparent;
            this.cuCarpeta4.ImageIco = global::UI.Properties.Resources.userDelete;
            this.cuCarpeta4.LabelText = "Eliminar";
            this.cuCarpeta4.Location = new System.Drawing.Point(630, 448);
            this.cuCarpeta4.Name = "cuCarpeta4";
            this.cuCarpeta4.Size = new System.Drawing.Size(168, 142);
            this.cuCarpeta4.TabIndex = 3;
            this.cuCarpeta4.Click += new System.EventHandler(this.cuCarpeta4_Load);
            // 
            // cuCarpeta1
            // 
            this.cuCarpeta1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuCarpeta1.BackColor = System.Drawing.Color.Transparent;
            this.cuCarpeta1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.cuCarpeta1.ButtonColorActive = System.Drawing.Color.RoyalBlue;
            this.cuCarpeta1.ButtonForeColor = System.Drawing.Color.White;
            this.cuCarpeta1.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.cuCarpeta1.CardColorBack = System.Drawing.Color.Transparent;
            this.cuCarpeta1.ImageIco = global::UI.Properties.Resources.userAdd;
            this.cuCarpeta1.LabelText = "Ingresar";
            this.cuCarpeta1.Location = new System.Drawing.Point(12, 448);
            this.cuCarpeta1.Name = "cuCarpeta1";
            this.cuCarpeta1.Size = new System.Drawing.Size(168, 142);
            this.cuCarpeta1.TabIndex = 0;
            this.cuCarpeta1.Click += new System.EventHandler(this.cuCarpeta1_Load);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione su Opciòn en la parte inferior";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 590);
            this.Name = "FrmPacientes";
            this.Text = "FrmPacientes";
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CUCarpeta cuCarpeta4;
        private CUCarpeta cuCarpeta1;
        private CUCarpeta cuCarpeta2;
        private CUCarpeta cuCarpeta5;
        private System.Windows.Forms.Label label1;
    }
}