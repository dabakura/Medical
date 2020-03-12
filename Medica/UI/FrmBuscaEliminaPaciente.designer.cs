namespace UI
{
    partial class FrmBuscaEliminaPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscaEliminaPaciente));
            this.panelder = new System.Windows.Forms.Panel();
            this.bunifuCardspersonales = new Bunifu.Framework.UI.BunifuCards();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paneliniz = new System.Windows.Forms.Panel();
            this.txtapellido1 = new UCErrorTextBox.ErrorTxtBox();
            this.txtnombre = new UCErrorTextBox.ErrorTxtBox();
            this.txtcedula = new UCErrorTextBox.ErrorTxtBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelinde = new System.Windows.Forms.Panel();
            this.txtfechana = new UCErrorTextBox.ErrorTxtBox();
            this.txtapellido2 = new UCErrorTextBox.ErrorTxtBox();
            this.cuGenero = new UI.CUGenero();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbDiagnostico = new System.Windows.Forms.RadioButton();
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.rbCedula = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new UCErrorTextBox.ErrorTxtBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.txtEdad = new UCErrorTextBox.ErrorTxtBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdiagnostico = new UCErrorTextBox.ErrorTxtBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpeso = new UCErrorTextBox.ErrorTxtBox();
            this.txtestatura = new UCErrorTextBox.ErrorTxtBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.paneliz = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAccion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lbPadecimientos = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnBody.SuspendLayout();
            this.panelder.SuspendLayout();
            this.bunifuCardspersonales.SuspendLayout();
            this.panel2.SuspendLayout();
            this.paneliniz.SuspendLayout();
            this.panelinde.SuspendLayout();
            this.bunifuCards4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.paneliz.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.White;
            this.pnBody.Controls.Add(this.panelder);
            this.pnBody.Controls.Add(this.paneliz);
            this.pnBody.Controls.Add(this.panel1);
            this.pnBody.SizeChanged += new System.EventHandler(this.pnBody_SizeChanged);
            // 
            // panelder
            // 
            this.panelder.BackColor = System.Drawing.Color.White;
            this.panelder.Controls.Add(this.bunifuCardspersonales);
            this.panelder.Controls.Add(this.bunifuCards4);
            this.panelder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelder.Location = new System.Drawing.Point(0, 55);
            this.panelder.Name = "panelder";
            this.panelder.Size = new System.Drawing.Size(405, 535);
            this.panelder.TabIndex = 10;
            // 
            // bunifuCardspersonales
            // 
            this.bunifuCardspersonales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCardspersonales.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCardspersonales.BorderRadius = 5;
            this.bunifuCardspersonales.BottomSahddow = true;
            this.bunifuCardspersonales.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.bunifuCardspersonales.Controls.Add(this.panel2);
            this.bunifuCardspersonales.Controls.Add(this.label7);
            this.bunifuCardspersonales.LeftSahddow = false;
            this.bunifuCardspersonales.Location = new System.Drawing.Point(11, 288);
            this.bunifuCardspersonales.Name = "bunifuCardspersonales";
            this.bunifuCardspersonales.RightSahddow = true;
            this.bunifuCardspersonales.ShadowDepth = 40;
            this.bunifuCardspersonales.Size = new System.Drawing.Size(388, 242);
            this.bunifuCardspersonales.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.paneliniz);
            this.panel2.Controls.Add(this.panelinde);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 189);
            this.panel2.TabIndex = 25;
            // 
            // paneliniz
            // 
            this.paneliniz.Controls.Add(this.txtapellido1);
            this.paneliniz.Controls.Add(this.txtnombre);
            this.paneliniz.Controls.Add(this.txtcedula);
            this.paneliniz.Controls.Add(this.label1);
            this.paneliniz.Controls.Add(this.label2);
            this.paneliniz.Controls.Add(this.label4);
            this.paneliniz.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneliniz.Location = new System.Drawing.Point(0, 0);
            this.paneliniz.Name = "paneliniz";
            this.paneliniz.Size = new System.Drawing.Size(192, 189);
            this.paneliniz.TabIndex = 27;
            // 
            // txtapellido1
            // 
            this.txtapellido1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtapellido1.AutoClear = false;
            this.txtapellido1.Enabled = false;
            this.txtapellido1.Location = new System.Drawing.Point(22, 137);
            this.txtapellido1.MaxLength = 50;
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(150, 20);
            this.txtapellido1.TabIndex = 21;
            this.txtapellido1.Validar = false;
            this.txtapellido1.ValidarContraseñas = false;
            this.txtapellido1.ValidarDouble = false;
            this.txtapellido1.ValidarInt32 = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombre.AutoClear = false;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(22, 85);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(150, 20);
            this.txtnombre.TabIndex = 20;
            this.txtnombre.Validar = false;
            this.txtnombre.ValidarContraseñas = false;
            this.txtnombre.ValidarDouble = false;
            this.txtnombre.ValidarInt32 = false;
            // 
            // txtcedula
            // 
            this.txtcedula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcedula.AutoClear = false;
            this.txtcedula.Enabled = false;
            this.txtcedula.Location = new System.Drawing.Point(22, 33);
            this.txtcedula.MaxLength = 11;
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(150, 20);
            this.txtcedula.TabIndex = 19;
            this.txtcedula.Validar = false;
            this.txtcedula.ValidarContraseñas = false;
            this.txtcedula.ValidarDouble = false;
            this.txtcedula.ValidarInt32 = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cedula:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Primer Apellido:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelinde
            // 
            this.panelinde.Controls.Add(this.txtfechana);
            this.panelinde.Controls.Add(this.txtapellido2);
            this.panelinde.Controls.Add(this.cuGenero);
            this.panelinde.Controls.Add(this.label3);
            this.panelinde.Controls.Add(this.label5);
            this.panelinde.Controls.Add(this.label6);
            this.panelinde.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelinde.Location = new System.Drawing.Point(193, 0);
            this.panelinde.Name = "panelinde";
            this.panelinde.Size = new System.Drawing.Size(192, 189);
            this.panelinde.TabIndex = 28;
            // 
            // txtfechana
            // 
            this.txtfechana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfechana.AutoClear = false;
            this.txtfechana.Enabled = false;
            this.txtfechana.Location = new System.Drawing.Point(22, 85);
            this.txtfechana.MaxLength = 50;
            this.txtfechana.Name = "txtfechana";
            this.txtfechana.Size = new System.Drawing.Size(150, 20);
            this.txtfechana.TabIndex = 22;
            this.txtfechana.Validar = false;
            this.txtfechana.ValidarContraseñas = false;
            this.txtfechana.ValidarDouble = false;
            this.txtfechana.ValidarInt32 = false;
            // 
            // txtapellido2
            // 
            this.txtapellido2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtapellido2.AutoClear = false;
            this.txtapellido2.Enabled = false;
            this.txtapellido2.Location = new System.Drawing.Point(22, 33);
            this.txtapellido2.MaxLength = 50;
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.Size = new System.Drawing.Size(150, 20);
            this.txtapellido2.TabIndex = 25;
            this.txtapellido2.Validar = false;
            this.txtapellido2.ValidarContraseñas = false;
            this.txtapellido2.ValidarDouble = false;
            this.txtapellido2.ValidarInt32 = false;
            // 
            // cuGenero
            // 
            this.cuGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cuGenero.Enabled = false;
            this.cuGenero.Genero = true;
            this.cuGenero.Location = new System.Drawing.Point(22, 138);
            this.cuGenero.Name = "cuGenero";
            this.cuGenero.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cuGenero.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.cuGenero.Size = new System.Drawing.Size(150, 18);
            this.cuGenero.TabIndex = 1;
            this.cuGenero.TextColor = System.Drawing.Color.White;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Segundo Apellido:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha de Nacimiento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Genero:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label7.Location = new System.Drawing.Point(0, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(387, 28);
            this.label7.TabIndex = 25;
            this.label7.Text = "Datos Personales";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards4.BorderRadius = 6;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.bunifuCards4.Controls.Add(this.btnBuscar);
            this.bunifuCards4.Controls.Add(this.dgvPacientes);
            this.bunifuCards4.Controls.Add(this.groupBox1);
            this.bunifuCards4.Controls.Add(this.txtBuscar);
            this.bunifuCards4.Controls.Add(this.label12);
            this.bunifuCards4.LeftSahddow = true;
            this.bunifuCards4.Location = new System.Drawing.Point(11, 13);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = false;
            this.bunifuCards4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(385, 269);
            this.bunifuCards4.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(274, 83);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 23);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToOrderColumns = true;
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.GridColor = System.Drawing.Color.DimGray;
            this.dgvPacientes.Location = new System.Drawing.Point(6, 109);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.Size = new System.Drawing.Size(375, 150);
            this.dgvPacientes.TabIndex = 30;
            this.dgvPacientes.SelectionChanged += new System.EventHandler(this.dgvPacientes_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbDiagnostico);
            this.groupBox1.Controls.Add(this.rbApellido);
            this.groupBox1.Controls.Add(this.rbCedula);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.groupBox1.Location = new System.Drawing.Point(5, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 41);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elija una Opción";
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(99, 19);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(68, 17);
            this.rbNombre.TabIndex = 3;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // rbDiagnostico
            // 
            this.rbDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDiagnostico.AutoSize = true;
            this.rbDiagnostico.Location = new System.Drawing.Point(278, 18);
            this.rbDiagnostico.Name = "rbDiagnostico";
            this.rbDiagnostico.Size = new System.Drawing.Size(92, 17);
            this.rbDiagnostico.TabIndex = 2;
            this.rbDiagnostico.Text = "Diagnostico";
            this.rbDiagnostico.UseVisualStyleBackColor = true;
            this.rbDiagnostico.CheckedChanged += new System.EventHandler(this.rbDiagnostico_CheckedChanged);
            // 
            // rbApellido
            // 
            this.rbApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbApellido.AutoSize = true;
            this.rbApellido.Location = new System.Drawing.Point(187, 19);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(70, 17);
            this.rbApellido.TabIndex = 1;
            this.rbApellido.Text = "Apellido";
            this.rbApellido.UseVisualStyleBackColor = true;
            this.rbApellido.CheckedChanged += new System.EventHandler(this.rbApellido_CheckedChanged);
            // 
            // rbCedula
            // 
            this.rbCedula.AutoSize = true;
            this.rbCedula.Checked = true;
            this.rbCedula.Location = new System.Drawing.Point(7, 18);
            this.rbCedula.Name = "rbCedula";
            this.rbCedula.Size = new System.Drawing.Size(64, 17);
            this.rbCedula.TabIndex = 0;
            this.rbCedula.TabStop = true;
            this.rbCedula.Text = "Cedula";
            this.rbCedula.UseVisualStyleBackColor = true;
            this.rbCedula.CheckedChanged += new System.EventHandler(this.rbCedula_CheckedChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoClear = false;
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscar.Location = new System.Drawing.Point(5, 83);
            this.txtBuscar.MaxLength = 11;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(247, 20);
            this.txtBuscar.TabIndex = 22;
            this.txtBuscar.Validar = true;
            this.txtBuscar.ValidarContraseñas = false;
            this.txtBuscar.ValidarDouble = false;
            this.txtBuscar.ValidarInt32 = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label12.Location = new System.Drawing.Point(1, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(384, 28);
            this.label12.TabIndex = 27;
            this.label12.Text = "Ingrese un Paciente a Buscar";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.bunifuCards3.Controls.Add(this.txtEdad);
            this.bunifuCards3.Controls.Add(this.label14);
            this.bunifuCards3.Controls.Add(this.txtdiagnostico);
            this.bunifuCards3.Controls.Add(this.label13);
            this.bunifuCards3.Controls.Add(this.txtpeso);
            this.bunifuCards3.Controls.Add(this.txtestatura);
            this.bunifuCards3.Controls.Add(this.label8);
            this.bunifuCards3.Controls.Add(this.label10);
            this.bunifuCards3.Controls.Add(this.label11);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(24, 13);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 40;
            this.bunifuCards3.Size = new System.Drawing.Size(369, 228);
            this.bunifuCards3.TabIndex = 4;
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdad.AutoClear = false;
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(85, 58);
            this.txtEdad.MaxLength = 6;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(203, 20);
            this.txtEdad.TabIndex = 34;
            this.txtEdad.Validar = false;
            this.txtEdad.ValidarContraseñas = false;
            this.txtEdad.ValidarDouble = true;
            this.txtEdad.ValidarInt32 = false;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(85, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 19);
            this.label14.TabIndex = 33;
            this.label14.Text = "Edad";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdiagnostico
            // 
            this.txtdiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdiagnostico.AutoClear = false;
            this.txtdiagnostico.Enabled = false;
            this.txtdiagnostico.Location = new System.Drawing.Point(85, 198);
            this.txtdiagnostico.MaxLength = 6;
            this.txtdiagnostico.Name = "txtdiagnostico";
            this.txtdiagnostico.Size = new System.Drawing.Size(203, 20);
            this.txtdiagnostico.TabIndex = 32;
            this.txtdiagnostico.Validar = false;
            this.txtdiagnostico.ValidarContraseñas = false;
            this.txtdiagnostico.ValidarDouble = true;
            this.txtdiagnostico.ValidarInt32 = false;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(85, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Diagnostico:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpeso
            // 
            this.txtpeso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpeso.AutoClear = false;
            this.txtpeso.Enabled = false;
            this.txtpeso.Location = new System.Drawing.Point(85, 153);
            this.txtpeso.MaxLength = 6;
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(203, 20);
            this.txtpeso.TabIndex = 29;
            this.txtpeso.Validar = false;
            this.txtpeso.ValidarContraseñas = false;
            this.txtpeso.ValidarDouble = true;
            this.txtpeso.ValidarInt32 = false;
            // 
            // txtestatura
            // 
            this.txtestatura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtestatura.AutoClear = false;
            this.txtestatura.Enabled = false;
            this.txtestatura.Location = new System.Drawing.Point(85, 106);
            this.txtestatura.MaxLength = 4;
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(203, 20);
            this.txtestatura.TabIndex = 28;
            this.txtestatura.Validar = false;
            this.txtestatura.ValidarContraseñas = false;
            this.txtestatura.ValidarDouble = true;
            this.txtestatura.ValidarInt32 = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label8.Location = new System.Drawing.Point(0, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(369, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Información Especifica";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(85, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Peso (KG):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(85, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Estatura (MTS):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paneliz
            // 
            this.paneliz.BackColor = System.Drawing.Color.White;
            this.paneliz.Controls.Add(this.bunifuCards3);
            this.paneliz.Controls.Add(this.bunifuThinButton22);
            this.paneliz.Controls.Add(this.btnAccion);
            this.paneliz.Controls.Add(this.bunifuCards1);
            this.paneliz.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneliz.ForeColor = System.Drawing.Color.White;
            this.paneliz.Location = new System.Drawing.Point(405, 55);
            this.paneliz.Name = "paneliz";
            this.paneliz.Size = new System.Drawing.Size(405, 535);
            this.paneliz.TabIndex = 9;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Cancelar";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Crimson;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuThinButton22.Location = new System.Drawing.Point(33, 489);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(158, 41);
            this.bunifuThinButton22.TabIndex = 7;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnAccion
            // 
            this.btnAccion.ActiveBorderThickness = 1;
            this.btnAccion.ActiveCornerRadius = 20;
            this.btnAccion.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAccion.ActiveForecolor = System.Drawing.Color.White;
            this.btnAccion.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccion.BackColor = System.Drawing.Color.White;
            this.btnAccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccion.BackgroundImage")));
            this.btnAccion.ButtonText = "Salvar";
            this.btnAccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAccion.IdleBorderThickness = 1;
            this.btnAccion.IdleCornerRadius = 20;
            this.btnAccion.IdleFillColor = System.Drawing.Color.White;
            this.btnAccion.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAccion.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAccion.Location = new System.Drawing.Point(238, 489);
            this.btnAccion.Margin = new System.Windows.Forms.Padding(5);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(155, 41);
            this.btnAccion.TabIndex = 6;
            this.btnAccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccion.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 6;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.bunifuCards1.Controls.Add(this.lbPadecimientos);
            this.bunifuCards1.Controls.Add(this.label9);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(24, 247);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(369, 234);
            this.bunifuCards1.TabIndex = 2;
            // 
            // lbPadecimientos
            // 
            this.lbPadecimientos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPadecimientos.FormattingEnabled = true;
            this.lbPadecimientos.Location = new System.Drawing.Point(0, 41);
            this.lbPadecimientos.Name = "lbPadecimientos";
            this.lbPadecimientos.Size = new System.Drawing.Size(366, 186);
            this.lbPadecimientos.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label9.Location = new System.Drawing.Point(1, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(368, 28);
            this.label9.TabIndex = 26;
            this.label9.Text = "Lista de Padecimientos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 55);
            this.panel1.TabIndex = 8;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.bunifuCustomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(786, 31);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Seleccione el Paciente";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBuscaEliminaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 590);
            this.Name = "FrmBuscaEliminaPaciente";
            this.Text = "Form1";
            this.pnBody.ResumeLayout(false);
            this.panelder.ResumeLayout(false);
            this.bunifuCardspersonales.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.paneliniz.ResumeLayout(false);
            this.paneliniz.PerformLayout();
            this.panelinde.ResumeLayout(false);
            this.panelinde.PerformLayout();
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.paneliz.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelder;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private UCErrorTextBox.ErrorTxtBox txtpeso;
        private UCErrorTextBox.ErrorTxtBox txtestatura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuCards bunifuCardspersonales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel paneliniz;
        private UCErrorTextBox.ErrorTxtBox txtapellido1;
        private UCErrorTextBox.ErrorTxtBox txtnombre;
        private UCErrorTextBox.ErrorTxtBox txtcedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelinde;
        private UCErrorTextBox.ErrorTxtBox txtapellido2;
        private CUGenero cuGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel paneliz;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAccion;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbDiagnostico;
        private System.Windows.Forms.RadioButton rbApellido;
        private System.Windows.Forms.RadioButton rbCedula;
        private UCErrorTextBox.ErrorTxtBox txtBuscar;
        private UCErrorTextBox.ErrorTxtBox txtdiagnostico;
        private System.Windows.Forms.ListBox lbPadecimientos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UCErrorTextBox.ErrorTxtBox txtEdad;
        private System.Windows.Forms.Label label14;
        private UCErrorTextBox.ErrorTxtBox txtfechana;
        private System.Windows.Forms.Button btnBuscar;
    }
}