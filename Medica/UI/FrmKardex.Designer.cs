namespace UI
{
    partial class FrmKardex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKardex));
            this.cuSignos1 = new UI.CUSignos();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.cuDataGrip3 = new UI.CUDataGrip();
            this.bgpMedicamento = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.cbMedicamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdosis = new UCErrorTextBox.ErrorTxtBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRango = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbViaAdministracion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregarMedicamento = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificarMedicamento = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminarMedicamento = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cdsintoma = new UI.CUComboBoxAdd();
            this.btningresarsintoma = new System.Windows.Forms.Button();
            this.uclistasintoma = new CUAdd.UCADD();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPadecimientos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.bnguardar = new System.Windows.Forms.Button();
            this.flpLateral = new System.Windows.Forms.FlowLayoutPanel();
            this.pnBody.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuDataGrip3)).BeginInit();
            this.bgpMedicamento.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.White;
            this.pnBody.Controls.Add(this.tabControl1);
            this.pnBody.Controls.Add(this.cuSignos1);
            // 
            // cuSignos1
            // 
            this.cuSignos1.BackColor = System.Drawing.Color.White;
            this.cuSignos1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cuSignos1.Location = new System.Drawing.Point(0, 0);
            this.cuSignos1.Name = "cuSignos1";
            this.cuSignos1.Size = new System.Drawing.Size(810, 130);
            this.cuSignos1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 22);
            this.tabControl1.Location = new System.Drawing.Point(0, 130);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 460);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Controls.Add(this.bgpMedicamento);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kardex";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtnota, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.cuDataGrip3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(316, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(461, 446);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(455, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Descripción o Nota";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(455, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tabla de Medicamentos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnota
            // 
            this.txtnota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtnota.Location = new System.Drawing.Point(3, 335);
            this.txtnota.Multiline = true;
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(455, 108);
            this.txtnota.TabIndex = 20;
            // 
            // cuDataGrip3
            // 
            this.cuDataGrip3.AllowUserToAddRows = false;
            this.cuDataGrip3.AllowUserToDeleteRows = false;
            this.cuDataGrip3.AllowUserToResizeRows = false;
            this.cuDataGrip3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cuDataGrip3.BackgroundColor = System.Drawing.Color.White;
            this.cuDataGrip3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cuDataGrip3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuDataGrip3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cuDataGrip3.Location = new System.Drawing.Point(3, 29);
            this.cuDataGrip3.MultiSelect = false;
            this.cuDataGrip3.Name = "cuDataGrip3";
            this.cuDataGrip3.ReadOnly = true;
            this.cuDataGrip3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cuDataGrip3.Size = new System.Drawing.Size(455, 274);
            this.cuDataGrip3.TabIndex = 21;
            this.cuDataGrip3.SelectionChanged += new System.EventHandler(this.cuDataGrip3_SelectionChanged);
            // 
            // bgpMedicamento
            // 
            this.bgpMedicamento.BackColor = System.Drawing.Color.Transparent;
            this.bgpMedicamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bgpMedicamento.BackgroundImage")));
            this.bgpMedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bgpMedicamento.Controls.Add(this.cbMedicamento);
            this.bgpMedicamento.Controls.Add(this.label12);
            this.bgpMedicamento.Controls.Add(this.txtInfo);
            this.bgpMedicamento.Controls.Add(this.btnAceptar);
            this.bgpMedicamento.Controls.Add(this.btnCancelar);
            this.bgpMedicamento.Controls.Add(this.label11);
            this.bgpMedicamento.Controls.Add(this.tableLayoutPanel4);
            this.bgpMedicamento.Controls.Add(this.label8);
            this.bgpMedicamento.Controls.Add(this.cbViaAdministracion);
            this.bgpMedicamento.Controls.Add(this.label7);
            this.bgpMedicamento.Controls.Add(this.label5);
            this.bgpMedicamento.Dock = System.Windows.Forms.DockStyle.Left;
            this.bgpMedicamento.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.bgpMedicamento.GradientBottomRight = System.Drawing.Color.White;
            this.bgpMedicamento.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.bgpMedicamento.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.bgpMedicamento.Location = new System.Drawing.Point(26, 3);
            this.bgpMedicamento.Name = "bgpMedicamento";
            this.bgpMedicamento.Quality = 10;
            this.bgpMedicamento.Size = new System.Drawing.Size(290, 446);
            this.bgpMedicamento.TabIndex = 1;
            this.bgpMedicamento.Visible = false;
            // 
            // cbMedicamento
            // 
            this.cbMedicamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbMedicamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedicamento.FormattingEnabled = true;
            this.cbMedicamento.Location = new System.Drawing.Point(5, 168);
            this.cbMedicamento.Name = "cbMedicamento";
            this.cbMedicamento.Size = new System.Drawing.Size(278, 24);
            this.cbMedicamento.TabIndex = 52;
            this.cbMedicamento.Text = "--- Seleccione ---";
            this.cbMedicamento.SelectedIndexChanged += new System.EventHandler(this.cbMedicamento_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(290, 21);
            this.label12.TabIndex = 51;
            this.label12.Text = "Informacion del Medicamento";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Visible = false;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.White;
            this.txtInfo.Location = new System.Drawing.Point(5, 24);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(282, 114);
            this.txtInfo.TabIndex = 50;
            this.txtInfo.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.ActiveBorderThickness = 1;
            this.btnAceptar.ActiveCornerRadius = 20;
            this.btnAceptar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAceptar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAceptar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.ButtonText = "Aceptar";
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAceptar.IdleBorderThickness = 1;
            this.btnAceptar.IdleCornerRadius = 20;
            this.btnAceptar.IdleFillColor = System.Drawing.Color.White;
            this.btnAceptar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAceptar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAceptar.Location = new System.Drawing.Point(5, 398);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 41);
            this.btnAceptar.TabIndex = 49;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.Tomato;
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.Tomato;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Tomato;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 20;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.White;
            this.btnCancelar.IdleForecolor = System.Drawing.Color.Tomato;
            this.btnCancelar.IdleLineColor = System.Drawing.Color.Tomato;
            this.btnCancelar.Location = new System.Drawing.Point(166, 398);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 41);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(2, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(284, 24);
            this.label11.TabIndex = 47;
            this.label11.Text = "La descripcion Ingresela  → →";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.28777F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.71223F));
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtdosis, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbRango, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 298);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(278, 58);
            this.tableLayoutPanel4.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 29);
            this.label10.TabIndex = 48;
            this.label10.Text = "Dosis";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdosis
            // 
            this.txtdosis.AutoClear = false;
            this.txtdosis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtdosis.Location = new System.Drawing.Point(114, 32);
            this.txtdosis.Name = "txtdosis";
            this.txtdosis.Size = new System.Drawing.Size(161, 20);
            this.txtdosis.TabIndex = 49;
            this.txtdosis.Validar = false;
            this.txtdosis.ValidarContraseñas = false;
            this.txtdosis.ValidarDouble = true;
            this.txtdosis.ValidarInt32 = false;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 29);
            this.label9.TabIndex = 47;
            this.label9.Text = "Rango";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbRango
            // 
            this.cbRango.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRango.FormattingEnabled = true;
            this.cbRango.Location = new System.Drawing.Point(114, 3);
            this.cbRango.Name = "cbRango";
            this.cbRango.Size = new System.Drawing.Size(161, 21);
            this.cbRango.TabIndex = 50;
            this.cbRango.Text = "--- Seleccione ---";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(2, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 24);
            this.label8.TabIndex = 45;
            this.label8.Text = "Dosis a Administrar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbViaAdministracion
            // 
            this.cbViaAdministracion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbViaAdministracion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbViaAdministracion.FormattingEnabled = true;
            this.cbViaAdministracion.Location = new System.Drawing.Point(5, 233);
            this.cbViaAdministracion.Name = "cbViaAdministracion";
            this.cbViaAdministracion.Size = new System.Drawing.Size(278, 21);
            this.cbViaAdministracion.TabIndex = 44;
            this.cbViaAdministracion.Text = "--- Seleccione ---";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(2, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Seleccione la via de Administración";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seleccione el Medicamento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarMedicamento,
            this.toolStripSeparator1,
            this.btnModificarMedicamento,
            this.toolStripSeparator2,
            this.btnEliminarMedicamento});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(23, 446);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Eliminar Medicamento";
            this.toolStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // btnAgregarMedicamento
            // 
            this.btnAgregarMedicamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAgregarMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMedicamento.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMedicamento.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarMedicamento.Image")));
            this.btnAgregarMedicamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            this.btnAgregarMedicamento.Size = new System.Drawing.Size(22, 115);
            this.btnAgregarMedicamento.Text = "Agregar Medicamento";
            this.btnAgregarMedicamento.Click += new System.EventHandler(this.btnAgregarMedicamento_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(22, 6);
            this.toolStripSeparator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // btnModificarMedicamento
            // 
            this.btnModificarMedicamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnModificarMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMedicamento.ForeColor = System.Drawing.Color.White;
            this.btnModificarMedicamento.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarMedicamento.Image")));
            this.btnModificarMedicamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificarMedicamento.Name = "btnModificarMedicamento";
            this.btnModificarMedicamento.Size = new System.Drawing.Size(22, 121);
            this.btnModificarMedicamento.Text = "Modificar Medicamento";
            this.btnModificarMedicamento.Click += new System.EventHandler(this.btnModificarMedicamento_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(22, 6);
            this.toolStripSeparator2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // btnEliminarMedicamento
            // 
            this.btnEliminarMedicamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEliminarMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMedicamento.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMedicamento.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarMedicamento.Image")));
            this.btnEliminarMedicamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarMedicamento.Name = "btnEliminarMedicamento";
            this.btnEliminarMedicamento.Size = new System.Drawing.Size(22, 114);
            this.btnEliminarMedicamento.Text = "Eliminar Medicamento";
            this.btnEliminarMedicamento.Click += new System.EventHandler(this.btnEliminarMedicamento_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diagnosticos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(774, 446);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cdsintoma);
            this.panel2.Controls.Add(this.btningresarsintoma);
            this.panel2.Controls.Add(this.uclistasintoma);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(390, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 440);
            this.panel2.TabIndex = 1;
            // 
            // cdsintoma
            // 
            this.cdsintoma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cdsintoma.AutoSize = true;
            this.cdsintoma.Items = ((System.Collections.Generic.List<string>)(resources.GetObject("cdsintoma.Items")));
            this.cdsintoma.Location = new System.Drawing.Point(3, 35);
            this.cdsintoma.Name = "cdsintoma";
            this.cdsintoma.Size = new System.Drawing.Size(375, 24);
            this.cdsintoma.TabIndex = 41;
            this.cdsintoma.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdsintoma.Texto = "";
            this.cdsintoma.TextSelect = "";
            this.cdsintoma.Click += new System.EventHandler(this.cdsintoma_Click);
            // 
            // btningresarsintoma
            // 
            this.btningresarsintoma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btningresarsintoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.btningresarsintoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresarsintoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresarsintoma.Location = new System.Drawing.Point(229, 74);
            this.btningresarsintoma.Name = "btningresarsintoma";
            this.btningresarsintoma.Size = new System.Drawing.Size(149, 23);
            this.btningresarsintoma.TabIndex = 42;
            this.btningresarsintoma.Text = "Ingresar";
            this.btningresarsintoma.UseVisualStyleBackColor = false;
            this.btningresarsintoma.Click += new System.EventHandler(this.btningresarsintoma_Click);
            // 
            // uclistasintoma
            // 
            this.uclistasintoma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uclistasintoma.GetDelete = null;
            this.uclistasintoma.Location = new System.Drawing.Point(0, 122);
            this.uclistasintoma.Name = "uclistasintoma";
            this.uclistasintoma.Size = new System.Drawing.Size(378, 318);
            this.uclistasintoma.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lista de Sintomas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDiagnostico);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbPadecimientos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 440);
            this.panel1.TabIndex = 0;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiagnostico.Enabled = false;
            this.txtDiagnostico.Location = new System.Drawing.Point(3, 398);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(375, 20);
            this.txtDiagnostico.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Diagnostico Actual";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPadecimientos
            // 
            this.lbPadecimientos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPadecimientos.FormattingEnabled = true;
            this.lbPadecimientos.Location = new System.Drawing.Point(2, 59);
            this.lbPadecimientos.Name = "lbPadecimientos";
            this.lbPadecimientos.Size = new System.Drawing.Size(379, 238);
            this.lbPadecimientos.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lista de Padecimientos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtDescripcion);
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Controls.Add(this.flpLateral);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Observaciones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AcceptsReturn = true;
            this.txtDescripcion.AcceptsTab = true;
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Location = new System.Drawing.Point(3, 3);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(673, 414);
            this.txtDescripcion.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btneliminar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bnguardar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 417);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 32);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(227, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nueva Descripción";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Red;
            this.btneliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(451, 3);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(219, 26);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.Text = "Eliminar Descripción";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // bnguardar
            // 
            this.bnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.bnguardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnguardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnguardar.ForeColor = System.Drawing.Color.White;
            this.bnguardar.Location = new System.Drawing.Point(3, 3);
            this.bnguardar.Name = "bnguardar";
            this.bnguardar.Size = new System.Drawing.Size(218, 26);
            this.bnguardar.TabIndex = 0;
            this.bnguardar.Text = "Guardar Descripción";
            this.bnguardar.UseVisualStyleBackColor = false;
            this.bnguardar.Click += new System.EventHandler(this.bnguardar_Click);
            // 
            // flpLateral
            // 
            this.flpLateral.AutoScroll = true;
            this.flpLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpLateral.Location = new System.Drawing.Point(676, 3);
            this.flpLateral.Name = "flpLateral";
            this.flpLateral.Size = new System.Drawing.Size(101, 446);
            this.flpLateral.TabIndex = 1;
            // 
            // FrmKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 590);
            this.Name = "FrmKardex";
            this.Text = "FrmKardex";
            this.pnBody.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuDataGrip3)).EndInit();
            this.bgpMedicamento.ResumeLayout(false);
            this.bgpMedicamento.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CUSignos cuSignos1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button bnguardar;
        private System.Windows.Forms.FlowLayoutPanel flpLateral;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbPadecimientos;
        private CUComboBoxAdd cdsintoma;
        private System.Windows.Forms.Button btningresarsintoma;
        private CUAdd.UCADD uclistasintoma;
        private Bunifu.Framework.UI.BunifuGradientPanel bgpMedicamento;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregarMedicamento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModificarMedicamento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminarMedicamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbViaAdministracion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label10;
        private UCErrorTextBox.ErrorTxtBox txtdosis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbRango;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtInfo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAceptar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMedicamento;
        private CUDataGrip cuDataGrip3;
    }
}