namespace UI
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCardspersonales = new Bunifu.Framework.UI.BunifuCards();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt2apellido = new UCErrorTextBox.ErrorTxtBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt1apellido = new UCErrorTextBox.ErrorTxtBox();
            this.txtnombre = new UCErrorTextBox.ErrorTxtBox();
            this.txtcedula = new UCErrorTextBox.ErrorTxtBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtrol = new UCErrorTextBox.ErrorTxtBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvpacientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.cbPacientes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnBody.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bunifuCardspersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnBody.Controls.Add(this.tableLayoutPanel1);
            this.pnBody.Controls.Add(this.label1);
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
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione le Paciente en la parte inferior";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuCardspersonales, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(810, 548);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // bunifuCardspersonales
            // 
            this.bunifuCardspersonales.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCardspersonales.BorderRadius = 5;
            this.bunifuCardspersonales.BottomSahddow = true;
            this.bunifuCardspersonales.color = System.Drawing.Color.Navy;
            this.bunifuCardspersonales.Controls.Add(this.pblogo);
            this.bunifuCardspersonales.Controls.Add(this.panel5);
            this.bunifuCardspersonales.Controls.Add(this.txtrol);
            this.bunifuCardspersonales.Controls.Add(this.label16);
            this.bunifuCardspersonales.Controls.Add(this.label9);
            this.bunifuCardspersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCardspersonales.LeftSahddow = false;
            this.bunifuCardspersonales.Location = new System.Drawing.Point(408, 3);
            this.bunifuCardspersonales.Name = "bunifuCardspersonales";
            this.bunifuCardspersonales.RightSahddow = true;
            this.bunifuCardspersonales.ShadowDepth = 40;
            this.bunifuCardspersonales.Size = new System.Drawing.Size(399, 542);
            this.bunifuCardspersonales.TabIndex = 4;
            // 
            // pblogo
            // 
            this.pblogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pblogo.Location = new System.Drawing.Point(25, 100);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(347, 193);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 31;
            this.pblogo.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.txt2apellido);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txt1apellido);
            this.panel5.Controls.Add(this.txtnombre);
            this.panel5.Controls.Add(this.txtcedula);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(3, 299);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(392, 231);
            this.panel5.TabIndex = 30;
            // 
            // txt2apellido
            // 
            this.txt2apellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt2apellido.AutoClear = false;
            this.txt2apellido.Enabled = false;
            this.txt2apellido.Location = new System.Drawing.Point(16, 191);
            this.txt2apellido.MaxLength = 50;
            this.txt2apellido.Name = "txt2apellido";
            this.txt2apellido.Size = new System.Drawing.Size(350, 20);
            this.txt2apellido.TabIndex = 25;
            this.txt2apellido.Validar = false;
            this.txt2apellido.ValidarContraseñas = false;
            this.txt2apellido.ValidarDouble = false;
            this.txt2apellido.ValidarInt32 = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(350, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Segundo Apellido:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt1apellido
            // 
            this.txt1apellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt1apellido.AutoClear = false;
            this.txt1apellido.Enabled = false;
            this.txt1apellido.Location = new System.Drawing.Point(16, 137);
            this.txt1apellido.MaxLength = 50;
            this.txt1apellido.Name = "txt1apellido";
            this.txt1apellido.Size = new System.Drawing.Size(350, 20);
            this.txt1apellido.TabIndex = 21;
            this.txt1apellido.Validar = false;
            this.txt1apellido.ValidarContraseñas = false;
            this.txt1apellido.ValidarDouble = false;
            this.txt1apellido.ValidarInt32 = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombre.AutoClear = false;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(16, 85);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(350, 20);
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
            this.txtcedula.Location = new System.Drawing.Point(16, 33);
            this.txtcedula.MaxLength = 11;
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(350, 20);
            this.txtcedula.TabIndex = 19;
            this.txtcedula.Validar = false;
            this.txtcedula.ValidarContraseñas = false;
            this.txtcedula.ValidarDouble = false;
            this.txtcedula.ValidarInt32 = false;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(16, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(350, 19);
            this.label13.TabIndex = 14;
            this.label13.Text = "Cedula:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(16, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(350, 19);
            this.label14.TabIndex = 16;
            this.label14.Text = "Nombre:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(16, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(350, 19);
            this.label15.TabIndex = 18;
            this.label15.Text = "Primer Apellido:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtrol
            // 
            this.txtrol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrol.AutoClear = false;
            this.txtrol.Enabled = false;
            this.txtrol.Location = new System.Drawing.Point(22, 72);
            this.txtrol.MaxLength = 50;
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(350, 20);
            this.txtrol.TabIndex = 27;
            this.txtrol.Validar = false;
            this.txtrol.ValidarContraseñas = false;
            this.txtrol.ValidarDouble = false;
            this.txtrol.ValidarInt32 = false;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(22, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(350, 19);
            this.label16.TabIndex = 26;
            this.label16.Text = "Rol Tipo:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(208)))));
            this.label9.Location = new System.Drawing.Point(0, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(398, 28);
            this.label9.TabIndex = 25;
            this.label9.Text = "Datos Personales";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvpacientes);
            this.panel1.Controls.Add(this.bunifuCards1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 542);
            this.panel1.TabIndex = 0;
            // 
            // lvpacientes
            // 
            this.lvpacientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvpacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvpacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvpacientes.LargeImageList = this.imageList1;
            this.lvpacientes.Location = new System.Drawing.Point(0, 97);
            this.lvpacientes.MultiSelect = false;
            this.lvpacientes.Name = "lvpacientes";
            this.lvpacientes.Size = new System.Drawing.Size(399, 445);
            this.lvpacientes.SmallImageList = this.imageList1;
            this.lvpacientes.TabIndex = 1;
            this.lvpacientes.TileSize = new System.Drawing.Size(195, 96);
            this.lvpacientes.UseCompatibleStateImageBehavior = false;
            this.lvpacientes.View = System.Windows.Forms.View.Tile;
            this.lvpacientes.SelectedIndexChanged += new System.EventHandler(this.lvpacientes_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 90;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "paciente.png");
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Navy;
            this.bunifuCards1.Controls.Add(this.cbPacientes);
            this.bunifuCards1.Controls.Add(this.label8);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 40;
            this.bunifuCards1.Size = new System.Drawing.Size(399, 97);
            this.bunifuCards1.TabIndex = 32;
            // 
            // cbPacientes
            // 
            this.cbPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPacientes.FormattingEnabled = true;
            this.cbPacientes.Location = new System.Drawing.Point(10, 50);
            this.cbPacientes.Name = "cbPacientes";
            this.cbPacientes.Size = new System.Drawing.Size(377, 21);
            this.cbPacientes.TabIndex = 26;
            this.cbPacientes.SelectedIndexChanged += new System.EventHandler(this.cbPacientes_SelectedIndexChanged);
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
            this.label8.Size = new System.Drawing.Size(398, 28);
            this.label8.TabIndex = 25;
            this.label8.Text = "Lista de Pacientes";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notify
            // 
            this.notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notify.BalloonTipTitle = "Paciente Seleccionado";
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Información";
            this.notify.BalloonTipClosed += new System.EventHandler(this.notify_BalloonTipClosed);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 590);
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.pnBody.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bunifuCardspersonales.ResumeLayout(false);
            this.bunifuCardspersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvpacientes;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCardspersonales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Panel panel5;
        private UCErrorTextBox.ErrorTxtBox txt2apellido;
        private System.Windows.Forms.Label label10;
        private UCErrorTextBox.ErrorTxtBox txt1apellido;
        private UCErrorTextBox.ErrorTxtBox txtnombre;
        private UCErrorTextBox.ErrorTxtBox txtcedula;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private UCErrorTextBox.ErrorTxtBox txtrol;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.ComboBox cbPacientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NotifyIcon notify;
    }
}