namespace UI
{
    partial class FrmMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedicamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new UI.CUCarpeta();
            this.btnBuscar = new UI.CUCarpeta();
            this.btnEliminar = new UI.CUCarpeta();
            this.btnIngresar = new UI.CUCarpeta();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.GhostWhite;
            this.pnBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnBody.BackgroundImage")));
            this.pnBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBody.Controls.Add(this.label1);
            this.pnBody.Controls.Add(this.btnModificar);
            this.pnBody.Controls.Add(this.btnBuscar);
            this.pnBody.Controls.Add(this.btnEliminar);
            this.pnBody.Controls.Add(this.btnIngresar);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleccione su Opciòn en la parte inferior";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.btnModificar.ButtonColorActive = System.Drawing.Color.RoyalBlue;
            this.btnModificar.ButtonForeColor = System.Drawing.Color.White;
            this.btnModificar.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnModificar.CardColorBack = System.Drawing.Color.Transparent;
            this.btnModificar.ImageIco = global::UI.Properties.Resources.userSave;
            this.btnModificar.LabelText = "Modificar";
            this.btnModificar.Location = new System.Drawing.Point(421, 448);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(168, 142);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.btnBuscar.ButtonColorActive = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.ButtonForeColor = System.Drawing.Color.White;
            this.btnBuscar.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnBuscar.CardColorBack = System.Drawing.Color.Transparent;
            this.btnBuscar.ImageIco = global::UI.Properties.Resources.userBuscar;
            this.btnBuscar.LabelText = "Buscar";
            this.btnBuscar.Location = new System.Drawing.Point(217, 448);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(168, 142);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnEliminar.ButtonColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(13)))), ((int)(((byte)(41)))));
            this.btnEliminar.ButtonForeColor = System.Drawing.Color.White;
            this.btnEliminar.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.btnEliminar.CardColorBack = System.Drawing.Color.Transparent;
            this.btnEliminar.ImageIco = global::UI.Properties.Resources.mediMenos;
            this.btnEliminar.LabelText = "Eliminar";
            this.btnEliminar.Location = new System.Drawing.Point(630, 448);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(168, 142);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.btnIngresar.ButtonColorActive = System.Drawing.Color.RoyalBlue;
            this.btnIngresar.ButtonForeColor = System.Drawing.Color.White;
            this.btnIngresar.CardColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnIngresar.CardColorBack = System.Drawing.Color.Transparent;
            this.btnIngresar.ImageIco = global::UI.Properties.Resources.mediMas;
            this.btnIngresar.LabelText = "Ingresar";
            this.btnIngresar.Location = new System.Drawing.Point(12, 448);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(168, 142);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 590);
            this.Name = "FrmMedicamentos";
            this.Text = "FrmMedicamentos";
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CUCarpeta btnModificar;
        private CUCarpeta btnBuscar;
        private CUCarpeta btnEliminar;
        private CUCarpeta btnIngresar;
    }
}