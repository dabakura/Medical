namespace UI
{
    partial class FrmDiagnostico
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiagnostico));
            this.button1 = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbAceptar = new System.Windows.Forms.RadioButton();
            this.txtDiagnostico = new UCErrorTextBox.ErrorTxtBox();
            this.txtDescripcion = new UCErrorTextBox.ErrorTxtBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.udlistefecto = new CUAdd.UCADD();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TransitionPanel = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ccbefecto = new UI.CUComboBoxAdd();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.TransitionPanel.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(357, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAccion
            // 
            this.TransitionPanel.SetDecoration(this.btnAccion, BunifuAnimatorNS.DecorationType.None);
            this.btnAccion.Location = new System.Drawing.Point(28, 264);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(75, 23);
            this.btnAccion.TabIndex = 1;
            this.btnAccion.Text = "Aceptar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.TransitionPanel.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(28, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(404, 26);
            this.label14.TabIndex = 34;
            this.label14.Text = "Diagnostico:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.TransitionPanel.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "Descripción:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbModificar);
            this.groupBox1.Controls.Add(this.rbAceptar);
            this.TransitionPanel.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(28, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 45);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones:";
            // 
            // rbModificar
            // 
            this.rbModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbModificar.AutoSize = true;
            this.TransitionPanel.SetDecoration(this.rbModificar, BunifuAnimatorNS.DecorationType.None);
            this.rbModificar.Location = new System.Drawing.Point(241, 22);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(68, 17);
            this.rbModificar.TabIndex = 2;
            this.rbModificar.Text = "Modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            this.rbModificar.CheckedChanged += new System.EventHandler(this.rbAceptar_CheckedChanged);
            // 
            // rbAceptar
            // 
            this.rbAceptar.AutoSize = true;
            this.rbAceptar.Checked = true;
            this.TransitionPanel.SetDecoration(this.rbAceptar, BunifuAnimatorNS.DecorationType.None);
            this.rbAceptar.Location = new System.Drawing.Point(7, 22);
            this.rbAceptar.Name = "rbAceptar";
            this.rbAceptar.Size = new System.Drawing.Size(62, 17);
            this.rbAceptar.TabIndex = 0;
            this.rbAceptar.TabStop = true;
            this.rbAceptar.Text = "Agregar";
            this.rbAceptar.UseVisualStyleBackColor = true;
            this.rbAceptar.CheckedChanged += new System.EventHandler(this.rbAceptar_CheckedChanged);
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.AutoClear = true;
            this.txtDiagnostico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDiagnostico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TransitionPanel.SetDecoration(this.txtDiagnostico, BunifuAnimatorNS.DecorationType.None);
            this.txtDiagnostico.Location = new System.Drawing.Point(28, 90);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(404, 20);
            this.txtDiagnostico.TabIndex = 37;
            this.txtDiagnostico.Validar = true;
            this.txtDiagnostico.ValidarContraseñas = false;
            this.txtDiagnostico.ValidarDouble = false;
            this.txtDiagnostico.ValidarInt32 = false;
            this.txtDiagnostico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiagnostico_KeyDown);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoClear = true;
            this.TransitionPanel.SetDecoration(this.txtDescripcion, BunifuAnimatorNS.DecorationType.None);
            this.txtDescripcion.Location = new System.Drawing.Point(28, 148);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(404, 110);
            this.txtDescripcion.TabIndex = 38;
            this.txtDescripcion.Validar = true;
            this.txtDescripcion.ValidarContraseñas = false;
            this.txtDescripcion.ValidarDouble = false;
            this.txtDescripcion.ValidarInt32 = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.TransitionPanel.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.Location = new System.Drawing.Point(357, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Efectos >>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // udlistefecto
            // 
            this.TransitionPanel.SetDecoration(this.udlistefecto, BunifuAnimatorNS.DecorationType.None);
            this.udlistefecto.GetDelete = null;
            this.udlistefecto.Location = new System.Drawing.Point(481, 101);
            this.udlistefecto.Name = "udlistefecto";
            this.udlistefecto.Size = new System.Drawing.Size(243, 186);
            this.udlistefecto.TabIndex = 41;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.TransitionPanel.SetDecoration(this.btnIngresar, BunifuAnimatorNS.DecorationType.None);
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(649, 72);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 42;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btningresarsintoma_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.TransitionPanel.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(481, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 26);
            this.label2.TabIndex = 43;
            this.label2.Text = "Efectos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransitionPanel
            // 
            this.TransitionPanel.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.TransitionPanel.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.TransitionPanel.DefaultAnimation = animation1;
            // 
            // ccbefecto
            // 
            this.ccbefecto.AutoSize = true;
            this.TransitionPanel.SetDecoration(this.ccbefecto, BunifuAnimatorNS.DecorationType.None);
            this.ccbefecto.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("ccbefecto.Items")));
            this.ccbefecto.Location = new System.Drawing.Point(481, 42);
            this.ccbefecto.Name = "ccbefecto";
            this.ccbefecto.Size = new System.Drawing.Size(243, 24);
            this.ccbefecto.TabIndex = 40;
            this.ccbefecto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbefecto.TextSelect = "";
            this.ccbefecto.Click += new System.EventHandler(this.cuComboBoxAdd1_Click);
            // 
            // FrmDiagnostico
            // 
            this.AcceptButton = this.btnAccion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(461, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.udlistefecto);
            this.Controls.Add(this.ccbefecto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.button1);
            this.TransitionPanel.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDiagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnostico";
            this.Load += new System.EventHandler(this.FrmDiagnostico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbAceptar;
        private UCErrorTextBox.ErrorTxtBox txtDiagnostico;
        private UCErrorTextBox.ErrorTxtBox txtDescripcion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngresar;
        private CUAdd.UCADD udlistefecto;
        private CUComboBoxAdd ccbefecto;
        private System.Windows.Forms.Button button2;
        private BunifuAnimatorNS.BunifuTransition TransitionPanel;
    }
}