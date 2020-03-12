using DAL;

namespace UI
{
    partial class FrmAddPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddPaciente));
            this.panelder = new System.Windows.Forms.Panel();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.txtpeso = new UCErrorTextBox.ErrorTxtBox();
            this.txtestatura = new UCErrorTextBox.ErrorTxtBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.dtnacimiento = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtapellido2 = new UCErrorTextBox.ErrorTxtBox();
            this.cuGenero = new UI.CUGenero();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.paneliz = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAccion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panelfin = new System.Windows.Forms.Panel();
            this.dtpadefin = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btningresarpadecimiento = new System.Windows.Forms.Button();
            this.dtpadeinicio = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chbpadeestado = new Bunifu.Framework.UI.BunifuCheckbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uclistapade = new CUAdd.UCADD();
            this.label14 = new System.Windows.Forms.Label();
            this.cdpadecimiento = new UI.CUComboBoxAdd();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cddiagnostico = new UI.CUComboBoxAdd();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnBody.SuspendLayout();
            this.panelder.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCardspersonales.SuspendLayout();
            this.panel2.SuspendLayout();
            this.paneliniz.SuspendLayout();
            this.panelinde.SuspendLayout();
            this.paneliz.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.panelfin.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.bunifuCards4.SuspendLayout();
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
            this.panelder.Controls.Add(this.bunifuCards3);
            this.panelder.Controls.Add(this.bunifuCardspersonales);
            this.panelder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelder.Location = new System.Drawing.Point(0, 55);
            this.panelder.Name = "panelder";
            this.panelder.Size = new System.Drawing.Size(405, 535);
            this.panelder.TabIndex = 10;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.bunifuCards3.Controls.Add(this.txtpeso);
            this.bunifuCards3.Controls.Add(this.txtestatura);
            this.bunifuCards3.Controls.Add(this.label8);
            this.bunifuCards3.Controls.Add(this.label10);
            this.bunifuCards3.Controls.Add(this.label11);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(14, 339);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 40;
            this.bunifuCards3.Size = new System.Drawing.Size(388, 184);
            this.bunifuCards3.TabIndex = 4;
            // 
            // txtpeso
            // 
            this.txtpeso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpeso.AutoClear = false;
            this.txtpeso.Location = new System.Drawing.Point(85, 141);
            this.txtpeso.MaxLength = 6;
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(222, 20);
            this.txtpeso.TabIndex = 29;
            this.txtpeso.Validar = true;
            this.txtpeso.ValidarContraseñas = false;
            this.txtpeso.ValidarDouble = true;
            this.txtpeso.ValidarInt32 = false;
            // 
            // txtestatura
            // 
            this.txtestatura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtestatura.AutoClear = false;
            this.txtestatura.Location = new System.Drawing.Point(85, 81);
            this.txtestatura.MaxLength = 4;
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(222, 20);
            this.txtestatura.TabIndex = 28;
            this.txtestatura.Validar = true;
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
            this.label8.Size = new System.Drawing.Size(388, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Información Fisica";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(85, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 19);
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
            this.label11.Location = new System.Drawing.Point(85, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Estatura (MTS):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bunifuCardspersonales.Location = new System.Drawing.Point(14, 13);
            this.bunifuCardspersonales.Name = "bunifuCardspersonales";
            this.bunifuCardspersonales.RightSahddow = true;
            this.bunifuCardspersonales.ShadowDepth = 40;
            this.bunifuCardspersonales.Size = new System.Drawing.Size(388, 320);
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
            this.panel2.Size = new System.Drawing.Size(385, 264);
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
            this.paneliniz.Size = new System.Drawing.Size(192, 264);
            this.paneliniz.TabIndex = 27;
            // 
            // txtapellido1
            // 
            this.txtapellido1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtapellido1.AutoClear = false;
            this.txtapellido1.Location = new System.Drawing.Point(12, 191);
            this.txtapellido1.MaxLength = 50;
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(150, 20);
            this.txtapellido1.TabIndex = 21;
            this.txtapellido1.Validar = true;
            this.txtapellido1.ValidarContraseñas = false;
            this.txtapellido1.ValidarDouble = false;
            this.txtapellido1.ValidarInt32 = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombre.AutoClear = false;
            this.txtnombre.Location = new System.Drawing.Point(12, 115);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(150, 20);
            this.txtnombre.TabIndex = 20;
            this.txtnombre.Validar = true;
            this.txtnombre.ValidarContraseñas = false;
            this.txtnombre.ValidarDouble = false;
            this.txtnombre.ValidarInt32 = false;
            // 
            // txtcedula
            // 
            this.txtcedula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcedula.AutoClear = false;
            this.txtcedula.Location = new System.Drawing.Point(12, 49);
            this.txtcedula.MaxLength = 11;
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(150, 20);
            this.txtcedula.TabIndex = 19;
            this.txtcedula.Validar = true;
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
            this.label1.Location = new System.Drawing.Point(12, 27);
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
            this.label2.Location = new System.Drawing.Point(12, 94);
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
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Primer Apellido:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelinde
            // 
            this.panelinde.Controls.Add(this.dtnacimiento);
            this.panelinde.Controls.Add(this.txtapellido2);
            this.panelinde.Controls.Add(this.cuGenero);
            this.panelinde.Controls.Add(this.label3);
            this.panelinde.Controls.Add(this.label5);
            this.panelinde.Controls.Add(this.label6);
            this.panelinde.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelinde.Location = new System.Drawing.Point(193, 0);
            this.panelinde.Name = "panelinde";
            this.panelinde.Size = new System.Drawing.Size(192, 264);
            this.panelinde.TabIndex = 28;
            // 
            // dtnacimiento
            // 
            this.dtnacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtnacimiento.AutoSize = true;
            this.dtnacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.dtnacimiento.BorderRadius = 0;
            this.dtnacimiento.ForeColor = System.Drawing.Color.White;
            this.dtnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtnacimiento.FormatCustom = null;
            this.dtnacimiento.Location = new System.Drawing.Point(15, 116);
            this.dtnacimiento.Name = "dtnacimiento";
            this.dtnacimiento.Size = new System.Drawing.Size(150, 20);
            this.dtnacimiento.TabIndex = 26;
            this.dtnacimiento.Value = new System.DateTime(2018, 2, 23, 15, 45, 25, 429);
            // 
            // txtapellido2
            // 
            this.txtapellido2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtapellido2.AutoClear = false;
            this.txtapellido2.Location = new System.Drawing.Point(15, 49);
            this.txtapellido2.MaxLength = 50;
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.Size = new System.Drawing.Size(150, 20);
            this.txtapellido2.TabIndex = 25;
            this.txtapellido2.Validar = true;
            this.txtapellido2.ValidarContraseñas = false;
            this.txtapellido2.ValidarDouble = false;
            this.txtapellido2.ValidarInt32 = false;
            // 
            // cuGenero
            // 
            this.cuGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cuGenero.Genero = true;
            this.cuGenero.Location = new System.Drawing.Point(15, 192);
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
            this.label3.Location = new System.Drawing.Point(15, 27);
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
            this.label5.Location = new System.Drawing.Point(15, 94);
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
            this.label6.Location = new System.Drawing.Point(15, 170);
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
            // paneliz
            // 
            this.paneliz.BackColor = System.Drawing.Color.White;
            this.paneliz.Controls.Add(this.bunifuThinButton22);
            this.paneliz.Controls.Add(this.btnAccion);
            this.paneliz.Controls.Add(this.bunifuCards1);
            this.paneliz.Controls.Add(this.bunifuCards4);
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
            this.btnAccion.ButtonText = "Guardar";
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
            this.bunifuCards1.Controls.Add(this.panelfin);
            this.bunifuCards1.Controls.Add(this.panel4);
            this.bunifuCards1.Controls.Add(this.panel3);
            this.bunifuCards1.Controls.Add(this.label14);
            this.bunifuCards1.Controls.Add(this.cdpadecimiento);
            this.bunifuCards1.Controls.Add(this.label9);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(33, 13);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(360, 359);
            this.bunifuCards1.TabIndex = 2;
            // 
            // panelfin
            // 
            this.panelfin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelfin.Controls.Add(this.dtpadefin);
            this.panelfin.Controls.Add(this.label17);
            this.panelfin.Location = new System.Drawing.Point(3, 157);
            this.panelfin.Name = "panelfin";
            this.panelfin.Size = new System.Drawing.Size(354, 25);
            this.panelfin.TabIndex = 40;
            this.panelfin.Visible = false;
            // 
            // dtpadefin
            // 
            this.dtpadefin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpadefin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpadefin.Location = new System.Drawing.Point(104, 2);
            this.dtpadefin.Name = "dtpadefin";
            this.dtpadefin.Size = new System.Drawing.Size(247, 20);
            this.dtpadefin.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(3, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Fecha de Fin";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btningresarpadecimiento);
            this.panel4.Controls.Add(this.dtpadeinicio);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.chbpadeestado);
            this.panel4.Location = new System.Drawing.Point(3, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 52);
            this.panel4.TabIndex = 39;
            // 
            // btningresarpadecimiento
            // 
            this.btningresarpadecimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btningresarpadecimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.btningresarpadecimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresarpadecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresarpadecimiento.Location = new System.Drawing.Point(202, 29);
            this.btningresarpadecimiento.Name = "btningresarpadecimiento";
            this.btningresarpadecimiento.Size = new System.Drawing.Size(149, 23);
            this.btningresarpadecimiento.TabIndex = 39;
            this.btningresarpadecimiento.Text = "Ingresar";
            this.btningresarpadecimiento.UseVisualStyleBackColor = false;
            this.btningresarpadecimiento.Click += new System.EventHandler(this.btningresarpadecimiento_Click);
            // 
            // dtpadeinicio
            // 
            this.dtpadeinicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpadeinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpadeinicio.Location = new System.Drawing.Point(104, 3);
            this.dtpadeinicio.Name = "dtpadeinicio";
            this.dtpadeinicio.Size = new System.Drawing.Size(247, 20);
            this.dtpadeinicio.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(3, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Fecha de Inicio";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(3, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Estado Activo";
            // 
            // chbpadeestado
            // 
            this.chbpadeestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.chbpadeestado.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chbpadeestado.Checked = true;
            this.chbpadeestado.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.chbpadeestado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbpadeestado.ForeColor = System.Drawing.Color.White;
            this.chbpadeestado.Location = new System.Drawing.Point(104, 32);
            this.chbpadeestado.Name = "chbpadeestado";
            this.chbpadeestado.Size = new System.Drawing.Size(20, 20);
            this.chbpadeestado.TabIndex = 37;
            this.chbpadeestado.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.uclistapade);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(3, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 168);
            this.panel3.TabIndex = 34;
            // 
            // uclistapade
            // 
            this.uclistapade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uclistapade.GetDelete = null;
            this.uclistapade.Location = new System.Drawing.Point(0, 0);
            this.uclistapade.Name = "uclistapade";
            this.uclistapade.Size = new System.Drawing.Size(354, 168);
            this.uclistapade.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(354, 19);
            this.label14.TabIndex = 33;
            this.label14.Text = "Diagnosticos:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cdpadecimiento
            // 
            this.cdpadecimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cdpadecimiento.AutoSize = true;
            this.cdpadecimiento.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("cdpadecimiento.Items")));
            this.cdpadecimiento.Location = new System.Drawing.Point(3, 72);
            this.cdpadecimiento.Name = "cdpadecimiento";
            this.cdpadecimiento.Size = new System.Drawing.Size(354, 24);
            this.cdpadecimiento.TabIndex = 32;
            this.cdpadecimiento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdpadecimiento.Click += new System.EventHandler(this.cuComboBoxAdd1_Click);
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
            this.label9.Size = new System.Drawing.Size(359, 28);
            this.label9.TabIndex = 26;
            this.label9.Text = "Lista de Padecimientos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards4.BorderRadius = 6;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.bunifuCards4.Controls.Add(this.label13);
            this.bunifuCards4.Controls.Add(this.label12);
            this.bunifuCards4.Controls.Add(this.cddiagnostico);
            this.bunifuCards4.LeftSahddow = true;
            this.bunifuCards4.Location = new System.Drawing.Point(33, 383);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = false;
            this.bunifuCards4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(360, 98);
            this.bunifuCards4.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(68, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(218, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Diagnostico:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label12.Size = new System.Drawing.Size(359, 28);
            this.label12.TabIndex = 27;
            this.label12.Text = "Diagnostico Actual";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cddiagnostico
            // 
            this.cddiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cddiagnostico.AutoSize = true;
            this.cddiagnostico.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("cddiagnostico.Items")));
            this.cddiagnostico.Location = new System.Drawing.Point(68, 64);
            this.cddiagnostico.Name = "cddiagnostico";
            this.cddiagnostico.Size = new System.Drawing.Size(218, 24);
            this.cddiagnostico.TabIndex = 0;
            this.cddiagnostico.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cddiagnostico.Click += new System.EventHandler(this.cuComboBoxAdd1_Click);
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
            this.bunifuCustomLabel1.Text = "Ingrese los Datos del Paciente";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 590);
            this.Name = "FrmAddPaciente";
            this.Text = "Form1";
            this.pnBody.ResumeLayout(false);
            this.panelder.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.bunifuCardspersonales.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.paneliniz.ResumeLayout(false);
            this.paneliniz.PerformLayout();
            this.panelinde.ResumeLayout(false);
            this.panelinde.PerformLayout();
            this.paneliz.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.panelfin.ResumeLayout(false);
            this.panelfin.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private CUComboBoxAdd cdpadecimiento;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private CUComboBoxAdd cddiagnostico;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private CUAdd.UCADD uclistapade;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuCheckbox chbpadeestado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelfin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpadefin;
        private System.Windows.Forms.DateTimePicker dtpadeinicio;
        private Bunifu.Framework.UI.BunifuDatepicker dtnacimiento;
        private System.Windows.Forms.Button btningresarpadecimiento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}