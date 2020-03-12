namespace UI
{
    partial class FrmVias_Administracion
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbAceptar = new System.Windows.Forms.RadioButton();
            this.txtVia = new UCErrorTextBox.ErrorTxtBox();
            this.txtDescripcion = new UCErrorTextBox.ErrorTxtBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
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
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(28, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(404, 26);
            this.label14.TabIndex = 34;
            this.label14.Text = "Via de Administraciòn:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbModificar);
            this.groupBox1.Controls.Add(this.rbAceptar);
            this.groupBox1.Location = new System.Drawing.Point(28, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 45);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones:";
            // 
            // rbModificar
            // 
            this.rbModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(329, 22);
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
            this.rbAceptar.Location = new System.Drawing.Point(7, 22);
            this.rbAceptar.Name = "rbAceptar";
            this.rbAceptar.Size = new System.Drawing.Size(62, 17);
            this.rbAceptar.TabIndex = 0;
            this.rbAceptar.TabStop = true;
            this.rbAceptar.Text = "Agregar";
            this.rbAceptar.UseVisualStyleBackColor = true;
            this.rbAceptar.CheckedChanged += new System.EventHandler(this.rbAceptar_CheckedChanged);
            // 
            // txtVia
            // 
            this.txtVia.AutoClear = true;
            this.txtVia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtVia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtVia.Location = new System.Drawing.Point(28, 90);
            this.txtVia.Name = "txtVia";
            this.txtVia.Size = new System.Drawing.Size(404, 20);
            this.txtVia.TabIndex = 37;
            this.txtVia.Validar = true;
            this.txtVia.ValidarContraseñas = false;
            this.txtVia.ValidarDouble = false;
            this.txtVia.ValidarInt32 = false;
            this.txtVia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiagnostico_KeyDown);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoClear = true;
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
            // FrmVias_Administracion
            // 
            this.AcceptButton = this.btnAccion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(461, 299);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtVia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVias_Administracion";
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
        private UCErrorTextBox.ErrorTxtBox txtVia;
        private UCErrorTextBox.ErrorTxtBox txtDescripcion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}