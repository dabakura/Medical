namespace UI
{
    partial class FrmWindows
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWindows));
            this.ElipsePanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnLateral = new System.Windows.Forms.Panel();
            this.bfbPlugins = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbExpediente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbSignosVitales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbKardex = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbMedicamentos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbPacientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bibMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bibHelp = new Bunifu.Framework.UI.BunifuImageButton();
            this.bibMini = new Bunifu.Framework.UI.BunifuImageButton();
            this.bibExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnBody = new System.Windows.Forms.Panel();
            this.DragControlMove = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TransitionLogo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.TransitionPanel = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibExit)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipsePanel
            // 
            this.ElipsePanel.ElipseRadius = 10;
            this.ElipsePanel.TargetControl = this;
            // 
            // pnLateral
            // 
            this.pnLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.pnLateral.Controls.Add(this.bfbPlugins);
            this.pnLateral.Controls.Add(this.bfbExpediente);
            this.pnLateral.Controls.Add(this.bfbSignosVitales);
            this.pnLateral.Controls.Add(this.bfbKardex);
            this.pnLateral.Controls.Add(this.bfbMedicamentos);
            this.pnLateral.Controls.Add(this.bfbPacientes);
            this.pnLateral.Controls.Add(this.bfbInicio);
            this.pnLateral.Controls.Add(this.bibMenu);
            this.pnLateral.Controls.Add(this.pbLogo);
            this.TransitionPanel.SetDecoration(this.pnLateral, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.pnLateral, BunifuAnimatorNS.DecorationType.None);
            this.pnLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLateral.Location = new System.Drawing.Point(0, 44);
            this.pnLateral.Name = "pnLateral";
            this.pnLateral.Size = new System.Drawing.Size(200, 590);
            this.pnLateral.TabIndex = 0;
            // 
            // bfbPlugins
            // 
            this.bfbPlugins.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbPlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.bfbPlugins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbPlugins.BorderRadius = 0;
            this.bfbPlugins.ButtonText = "     Plugins";
            this.bfbPlugins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanel.SetDecoration(this.bfbPlugins, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.bfbPlugins, BunifuAnimatorNS.DecorationType.None);
            this.bfbPlugins.DisabledColor = System.Drawing.Color.Gray;
            this.bfbPlugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbPlugins.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbPlugins.Iconimage = global::UI.Properties.Resources.plugin;
            this.bfbPlugins.Iconimage_right = null;
            this.bfbPlugins.Iconimage_right_Selected = null;
            this.bfbPlugins.Iconimage_Selected = null;
            this.bfbPlugins.IconMarginLeft = 0;
            this.bfbPlugins.IconMarginRight = 0;
            this.bfbPlugins.IconRightVisible = true;
            this.bfbPlugins.IconRightZoom = 0D;
            this.bfbPlugins.IconVisible = true;
            this.bfbPlugins.IconZoom = 50D;
            this.bfbPlugins.IsTab = true;
            this.bfbPlugins.Location = new System.Drawing.Point(0, 440);
            this.bfbPlugins.Margin = new System.Windows.Forms.Padding(4);
            this.bfbPlugins.Name = "bfbPlugins";
            this.bfbPlugins.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.bfbPlugins.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.bfbPlugins.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbPlugins.selected = false;
            this.bfbPlugins.Size = new System.Drawing.Size(200, 46);
            this.bfbPlugins.TabIndex = 8;
            this.bfbPlugins.Text = "     Plugins";
            this.bfbPlugins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbPlugins.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.bfbPlugins.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbPlugins.Click += new System.EventHandler(this.bfbPlugins_Click);
            // 
            // bfbExpediente
            // 
            this.bfbExpediente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbExpediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.bfbExpediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbExpediente.BorderRadius = 0;
            this.bfbExpediente.ButtonText = "     Expediente";
            this.bfbExpediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanel.SetDecoration(this.bfbExpediente, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.bfbExpediente, BunifuAnimatorNS.DecorationType.None);
            this.bfbExpediente.DisabledColor = System.Drawing.Color.Gray;
            this.bfbExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbExpediente.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbExpediente.Iconimage = global::UI.Properties.Resources.expediente;
            this.bfbExpediente.Iconimage_right = null;
            this.bfbExpediente.Iconimage_right_Selected = null;
            this.bfbExpediente.Iconimage_Selected = null;
            this.bfbExpediente.IconMarginLeft = 0;
            this.bfbExpediente.IconMarginRight = 0;
            this.bfbExpediente.IconRightVisible = true;
            this.bfbExpediente.IconRightZoom = 0D;
            this.bfbExpediente.IconVisible = true;
            this.bfbExpediente.IconZoom = 50D;
            this.bfbExpediente.IsTab = true;
            this.bfbExpediente.Location = new System.Drawing.Point(0, 386);
            this.bfbExpediente.Margin = new System.Windows.Forms.Padding(4);
            this.bfbExpediente.Name = "bfbExpediente";
            this.bfbExpediente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.bfbExpediente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.bfbExpediente.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbExpediente.selected = false;
            this.bfbExpediente.Size = new System.Drawing.Size(200, 46);
            this.bfbExpediente.TabIndex = 7;
            this.bfbExpediente.Text = "     Expediente";
            this.bfbExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbExpediente.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.bfbExpediente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbExpediente.Click += new System.EventHandler(this.bfbExpediente_Click);
            // 
            // bfbSignosVitales
            // 
            this.bfbSignosVitales.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbSignosVitales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.bfbSignosVitales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbSignosVitales.BorderRadius = 0;
            this.bfbSignosVitales.ButtonText = "     Signos Vitales";
            this.bfbSignosVitales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanel.SetDecoration(this.bfbSignosVitales, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.bfbSignosVitales, BunifuAnimatorNS.DecorationType.None);
            this.bfbSignosVitales.DisabledColor = System.Drawing.Color.Gray;
            this.bfbSignosVitales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbSignosVitales.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbSignosVitales.Iconimage = global::UI.Properties.Resources.signovital;
            this.bfbSignosVitales.Iconimage_right = null;
            this.bfbSignosVitales.Iconimage_right_Selected = null;
            this.bfbSignosVitales.Iconimage_Selected = null;
            this.bfbSignosVitales.IconMarginLeft = 0;
            this.bfbSignosVitales.IconMarginRight = 0;
            this.bfbSignosVitales.IconRightVisible = true;
            this.bfbSignosVitales.IconRightZoom = 0D;
            this.bfbSignosVitales.IconVisible = true;
            this.bfbSignosVitales.IconZoom = 50D;
            this.bfbSignosVitales.IsTab = true;
            this.bfbSignosVitales.Location = new System.Drawing.Point(0, 332);
            this.bfbSignosVitales.Margin = new System.Windows.Forms.Padding(4);
            this.bfbSignosVitales.Name = "bfbSignosVitales";
            this.bfbSignosVitales.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.bfbSignosVitales.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.bfbSignosVitales.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbSignosVitales.selected = false;
            this.bfbSignosVitales.Size = new System.Drawing.Size(200, 46);
            this.bfbSignosVitales.TabIndex = 6;
            this.bfbSignosVitales.Text = "     Signos Vitales";
            this.bfbSignosVitales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbSignosVitales.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.bfbSignosVitales.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbSignosVitales.Click += new System.EventHandler(this.bfbSignosVitales_Click);
            // 
            // bfbKardex
            // 
            this.bfbKardex.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbKardex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.bfbKardex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbKardex.BorderRadius = 0;
            this.bfbKardex.ButtonText = "     Kardex";
            this.bfbKardex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanel.SetDecoration(this.bfbKardex, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.bfbKardex, BunifuAnimatorNS.DecorationType.None);
            this.bfbKardex.DisabledColor = System.Drawing.Color.Gray;
            this.bfbKardex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbKardex.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbKardex.Iconimage = global::UI.Properties.Resources.cardex;
            this.bfbKardex.Iconimage_right = null;
            this.bfbKardex.Iconimage_right_Selected = null;
            this.bfbKardex.Iconimage_Selected = null;
            this.bfbKardex.IconMarginLeft = 0;
            this.bfbKardex.IconMarginRight = 0;
            this.bfbKardex.IconRightVisible = true;
            this.bfbKardex.IconRightZoom = 0D;
            this.bfbKardex.IconVisible = true;
            this.bfbKardex.IconZoom = 50D;
            this.bfbKardex.IsTab = true;
            this.bfbKardex.Location = new System.Drawing.Point(0, 278);
            this.bfbKardex.Margin = new System.Windows.Forms.Padding(4);
            this.bfbKardex.Name = "bfbKardex";
            this.bfbKardex.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.bfbKardex.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.bfbKardex.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbKardex.selected = false;
            this.bfbKardex.Size = new System.Drawing.Size(200, 46);
            this.bfbKardex.TabIndex = 5;
            this.bfbKardex.Text = "     Kardex";
            this.bfbKardex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbKardex.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.bfbKardex.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbKardex.Click += new System.EventHandler(this.bfbKardex_Click);
            // 
            // bfbMedicamentos
            // 
            this.bfbMedicamentos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbMedicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.bfbMedicamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbMedicamentos.BorderRadius = 0;
            this.bfbMedicamentos.ButtonText = "     Medicamentos";
            this.bfbMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanel.SetDecoration(this.bfbMedicamentos, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.bfbMedicamentos, BunifuAnimatorNS.DecorationType.None);
            this.bfbMedicamentos.DisabledColor = System.Drawing.Color.Gray;
            this.bfbMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbMedicamentos.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbMedicamentos.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbMedicamentos.Iconimage")));
            this.bfbMedicamentos.Iconimage_right = null;
            this.bfbMedicamentos.Iconimage_right_Selected = null;
            this.bfbMedicamentos.Iconimage_Selected = null;
            this.bfbMedicamentos.IconMarginLeft = 0;
            this.bfbMedicamentos.IconMarginRight = 0;
            this.bfbMedicamentos.IconRightVisible = true;
            this.bfbMedicamentos.IconRightZoom = 0D;
            this.bfbMedicamentos.IconVisible = true;
            this.bfbMedicamentos.IconZoom = 50D;
            this.bfbMedicamentos.IsTab = true;
            this.bfbMedicamentos.Location = new System.Drawing.Point(0, 224);
            this.bfbMedicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.bfbMedicamentos.Name = "bfbMedicamentos";
            this.bfbMedicamentos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.bfbMedicamentos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.bfbMedicamentos.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbMedicamentos.selected = false;
            this.bfbMedicamentos.Size = new System.Drawing.Size(200, 46);
            this.bfbMedicamentos.TabIndex = 4;
            this.bfbMedicamentos.Text = "     Medicamentos";
            this.bfbMedicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbMedicamentos.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.bfbMedicamentos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbMedicamentos.Click += new System.EventHandler(this.bfbMedicamentos_Click);
            // 
            // bfbPacientes
            // 
            this.bfbPacientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.bfbPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbPacientes.BorderRadius = 0;
            this.bfbPacientes.ButtonText = "     Pacientes";
            this.bfbPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanel.SetDecoration(this.bfbPacientes, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.bfbPacientes, BunifuAnimatorNS.DecorationType.None);
            this.bfbPacientes.DisabledColor = System.Drawing.Color.Gray;
            this.bfbPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbPacientes.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbPacientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbPacientes.Iconimage")));
            this.bfbPacientes.Iconimage_right = null;
            this.bfbPacientes.Iconimage_right_Selected = null;
            this.bfbPacientes.Iconimage_Selected = null;
            this.bfbPacientes.IconMarginLeft = 0;
            this.bfbPacientes.IconMarginRight = 0;
            this.bfbPacientes.IconRightVisible = true;
            this.bfbPacientes.IconRightZoom = 0D;
            this.bfbPacientes.IconVisible = true;
            this.bfbPacientes.IconZoom = 50D;
            this.bfbPacientes.IsTab = true;
            this.bfbPacientes.Location = new System.Drawing.Point(0, 170);
            this.bfbPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.bfbPacientes.Name = "bfbPacientes";
            this.bfbPacientes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.bfbPacientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.bfbPacientes.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbPacientes.selected = false;
            this.bfbPacientes.Size = new System.Drawing.Size(200, 46);
            this.bfbPacientes.TabIndex = 3;
            this.bfbPacientes.Text = "     Pacientes";
            this.bfbPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbPacientes.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.bfbPacientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbPacientes.Click += new System.EventHandler(this.bfbPacientes_Click);
            // 
            // bfbInicio
            // 
            this.bfbInicio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbInicio.BorderRadius = 0;
            this.bfbInicio.ButtonText = "     Inicio";
            this.bfbInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransitionPanel.SetDecoration(this.bfbInicio, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.bfbInicio, BunifuAnimatorNS.DecorationType.None);
            this.bfbInicio.DisabledColor = System.Drawing.Color.Gray;
            this.bfbInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbInicio.Iconimage = global::UI.Properties.Resources.inicio;
            this.bfbInicio.Iconimage_right = null;
            this.bfbInicio.Iconimage_right_Selected = null;
            this.bfbInicio.Iconimage_Selected = null;
            this.bfbInicio.IconMarginLeft = 0;
            this.bfbInicio.IconMarginRight = 0;
            this.bfbInicio.IconRightVisible = true;
            this.bfbInicio.IconRightZoom = 0D;
            this.bfbInicio.IconVisible = true;
            this.bfbInicio.IconZoom = 50D;
            this.bfbInicio.IsTab = true;
            this.bfbInicio.Location = new System.Drawing.Point(0, 116);
            this.bfbInicio.Margin = new System.Windows.Forms.Padding(4);
            this.bfbInicio.Name = "bfbInicio";
            this.bfbInicio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.bfbInicio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.bfbInicio.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.bfbInicio.selected = true;
            this.bfbInicio.Size = new System.Drawing.Size(200, 46);
            this.bfbInicio.TabIndex = 2;
            this.bfbInicio.Text = "     Inicio";
            this.bfbInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbInicio.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.bfbInicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbInicio.Click += new System.EventHandler(this.bfbInicio_Click);
            // 
            // bibMenu
            // 
            this.bibMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bibMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.TransitionPanel.SetDecoration(this.bibMenu, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.bibMenu, BunifuAnimatorNS.DecorationType.None);
            this.bibMenu.Image = global::UI.Properties.Resources.Menu;
            this.bibMenu.ImageActive = null;
            this.bibMenu.Location = new System.Drawing.Point(159, 6);
            this.bibMenu.Name = "bibMenu";
            this.bibMenu.Size = new System.Drawing.Size(35, 35);
            this.bibMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bibMenu.TabIndex = 1;
            this.bibMenu.TabStop = false;
            this.bibMenu.Zoom = 10;
            this.bibMenu.Click += new System.EventHandler(this.bibMenu_Click);
            // 
            // pbLogo
            // 
            this.TransitionLogo.SetDecoration(this.pbLogo, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanel.SetDecoration(this.pbLogo, BunifuAnimatorNS.DecorationType.None);
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 6);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(120, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.pnHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnHeader.Controls.Add(this.bunifuImageButton1);
            this.pnHeader.Controls.Add(this.bibHelp);
            this.pnHeader.Controls.Add(this.bibMini);
            this.pnHeader.Controls.Add(this.bibExit);
            this.TransitionPanel.SetDecoration(this.pnHeader, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.pnHeader, BunifuAnimatorNS.DecorationType.None);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1010, 44);
            this.pnHeader.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.TransitionLogo.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanel.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(35, 15);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 19);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Medical";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.TransitionPanel.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::UI.Properties.Resources.Medical;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            // 
            // bibHelp
            // 
            this.bibHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.TransitionPanel.SetDecoration(this.bibHelp, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.bibHelp, BunifuAnimatorNS.DecorationType.None);
            this.bibHelp.Image = global::UI.Properties.Resources.help;
            this.bibHelp.ImageActive = null;
            this.bibHelp.Location = new System.Drawing.Point(889, 3);
            this.bibHelp.Name = "bibHelp";
            this.bibHelp.Size = new System.Drawing.Size(36, 36);
            this.bibHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bibHelp.TabIndex = 4;
            this.bibHelp.TabStop = false;
            this.bibHelp.Zoom = 20;
            this.bibHelp.MouseEnter += new System.EventHandler(this.bibHelp_MouseEnter);
            this.bibHelp.MouseLeave += new System.EventHandler(this.bunifuImageButton3_MouseLeave);
            // 
            // bibMini
            // 
            this.bibMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.TransitionPanel.SetDecoration(this.bibMini, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.bibMini, BunifuAnimatorNS.DecorationType.None);
            this.bibMini.Image = global::UI.Properties.Resources.min;
            this.bibMini.ImageActive = null;
            this.bibMini.Location = new System.Drawing.Point(931, 3);
            this.bibMini.Name = "bibMini";
            this.bibMini.Size = new System.Drawing.Size(36, 36);
            this.bibMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bibMini.TabIndex = 3;
            this.bibMini.TabStop = false;
            this.bibMini.Zoom = 20;
            this.bibMini.Click += new System.EventHandler(this.bibMini_Click);
            this.bibMini.MouseEnter += new System.EventHandler(this.bibMini_MouseEnter);
            this.bibMini.MouseLeave += new System.EventHandler(this.bunifuImageButton3_MouseLeave);
            // 
            // bibExit
            // 
            this.bibExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.TransitionPanel.SetDecoration(this.bibExit, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.bibExit, BunifuAnimatorNS.DecorationType.None);
            this.bibExit.Image = global::UI.Properties.Resources.exit;
            this.bibExit.ImageActive = null;
            this.bibExit.Location = new System.Drawing.Point(971, 3);
            this.bibExit.Name = "bibExit";
            this.bibExit.Size = new System.Drawing.Size(36, 36);
            this.bibExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bibExit.TabIndex = 2;
            this.bibExit.TabStop = false;
            this.bibExit.Zoom = 20;
            this.bibExit.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            this.bibExit.MouseEnter += new System.EventHandler(this.bibExit_MouseEnter);
            this.bibExit.MouseLeave += new System.EventHandler(this.bunifuImageButton3_MouseLeave);
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(55)))), ((int)(((byte)(76)))));
            this.TransitionPanel.SetDecoration(this.pnBody, BunifuAnimatorNS.DecorationType.None);
            this.TransitionLogo.SetDecoration(this.pnBody, BunifuAnimatorNS.DecorationType.None);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(200, 44);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(810, 590);
            this.pnBody.TabIndex = 2;
            // 
            // DragControlMove
            // 
            this.DragControlMove.Fixed = true;
            this.DragControlMove.Horizontal = true;
            this.DragControlMove.TargetControl = this.pnHeader;
            this.DragControlMove.Vertical = true;
            // 
            // TransitionLogo
            // 
            this.TransitionLogo.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.TransitionLogo.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.TransitionLogo.DefaultAnimation = animation2;
            // 
            // TransitionPanel
            // 
            this.TransitionPanel.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.TransitionPanel.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.TransitionPanel.DefaultAnimation = animation1;
            // 
            // FrmWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1010, 634);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnLateral);
            this.Controls.Add(this.pnHeader);
            this.TransitionLogo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.TransitionPanel.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical";
            this.Load += new System.EventHandler(this.FrmWindows_Load);
            this.pnLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bibMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipsePanel;
        private System.Windows.Forms.Panel pnLateral;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.PictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuImageButton bibMenu;
        private Bunifu.Framework.UI.BunifuDragControl DragControlMove;
        private Bunifu.Framework.UI.BunifuImageButton bibExit;
        private Bunifu.Framework.UI.BunifuFlatButton bfbInicio;
        private Bunifu.Framework.UI.BunifuFlatButton bfbMedicamentos;
        private Bunifu.Framework.UI.BunifuFlatButton bfbPacientes;
        private BunifuAnimatorNS.BunifuTransition TransitionPanel;
        private BunifuAnimatorNS.BunifuTransition TransitionLogo;
        private Bunifu.Framework.UI.BunifuImageButton bibHelp;
        private Bunifu.Framework.UI.BunifuImageButton bibMini;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bfbPlugins;
        private Bunifu.Framework.UI.BunifuFlatButton bfbExpediente;
        private Bunifu.Framework.UI.BunifuFlatButton bfbSignosVitales;
        private Bunifu.Framework.UI.BunifuFlatButton bfbKardex;
    }
}