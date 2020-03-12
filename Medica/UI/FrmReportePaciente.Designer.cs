namespace UI
{
    partial class FrmReportePaciente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DATOSPERSONALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPaciente = new UI.DataSetPaciente();
            this.DatosPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PadecimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SIGNOS_VITALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VistaPacienteMedicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SintomasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DATOSPERSONALESTableAdapter = new UI.DataSetPacienteTableAdapters.DATOSPERSONALESTableAdapter();
            this.DatosPacienteTableAdapter = new UI.DataSetPacienteTableAdapters.DatosPacienteTableAdapter();
            this.PadecimientosTableAdapter = new UI.DataSetPacienteTableAdapters.PadecimientosTableAdapter();
            this.SintomasTableAdapter = new UI.DataSetPacienteTableAdapters.SintomasTableAdapter();
            this.SIGNOS_VITALESTableAdapter = new UI.DataSetPacienteTableAdapters.SIGNOS_VITALESTableAdapter();
            this.VistaPacienteMedicamentoTableAdapter = new UI.DataSetPacienteTableAdapters.VistaPacienteMedicamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DATOSPERSONALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PadecimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIGNOS_VITALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaPacienteMedicamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SintomasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DATOSPERSONALESBindingSource
            // 
            this.DATOSPERSONALESBindingSource.DataMember = "DATOSPERSONALES";
            this.DATOSPERSONALESBindingSource.DataSource = this.DataSetPaciente;
            // 
            // DataSetPaciente
            // 
            this.DataSetPaciente.DataSetName = "DataSetPaciente";
            this.DataSetPaciente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatosPacienteBindingSource
            // 
            this.DatosPacienteBindingSource.DataMember = "DatosPaciente";
            this.DatosPacienteBindingSource.DataSource = this.DataSetPaciente;
            // 
            // PadecimientosBindingSource
            // 
            this.PadecimientosBindingSource.DataMember = "Padecimientos";
            this.PadecimientosBindingSource.DataSource = this.DataSetPaciente;
            // 
            // SIGNOS_VITALESBindingSource
            // 
            this.SIGNOS_VITALESBindingSource.DataMember = "SIGNOS_VITALES";
            this.SIGNOS_VITALESBindingSource.DataSource = this.DataSetPaciente;
            // 
            // VistaPacienteMedicamentoBindingSource
            // 
            this.VistaPacienteMedicamentoBindingSource.DataMember = "VistaPacienteMedicamento";
            this.VistaPacienteMedicamentoBindingSource.DataSource = this.DataSetPaciente;
            // 
            // SintomasBindingSource
            // 
            this.SintomasBindingSource.DataMember = "Sintomas";
            this.SintomasBindingSource.DataSource = this.DataSetPaciente;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.reportViewer6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.reportViewer5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.reportViewer4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.reportViewer3);
            this.panel1.Controls.Add(this.reportViewer2);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 714);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(577, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sintomas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer6
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SintomasBindingSource;
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "UI.ReportPacienteSintomas.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(576, 304);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.Size = new System.Drawing.Size(350, 126);
            this.reportViewer6.TabIndex = 10;
            this.reportViewer6.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(925, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Medicamentos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer5
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.VistaPacienteMedicamentoBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "UI.ReportPacienteMedicamentos.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(0, 593);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(926, 117);
            this.reportViewer5.TabIndex = 8;
            this.reportViewer5.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(925, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Signos Vitales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer4
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.SIGNOS_VITALESBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "UI.ReportPacienteSignosVitales.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 449);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(926, 124);
            this.reportViewer4.TabIndex = 6;
            this.reportViewer4.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(571, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Padecimientos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(925, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datos del Paciente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(925, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos Personales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportViewer3
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.PadecimientosBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "UI.ReportPacientePadecimientos.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 304);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(572, 126);
            this.reportViewer3.TabIndex = 2;
            this.reportViewer3.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // reportViewer2
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.DatosPacienteBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "UI.ReportPacienteDatosPaciente.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 163);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(929, 119);
            this.reportViewer2.TabIndex = 1;
            this.reportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.IsDocumentMapWidthFixed = true;
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.DATOSPERSONALESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.ReportPacienteDatosPersonales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(929, 115);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // DATOSPERSONALESTableAdapter
            // 
            this.DATOSPERSONALESTableAdapter.ClearBeforeFill = true;
            // 
            // DatosPacienteTableAdapter
            // 
            this.DatosPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // PadecimientosTableAdapter
            // 
            this.PadecimientosTableAdapter.ClearBeforeFill = true;
            // 
            // SintomasTableAdapter
            // 
            this.SintomasTableAdapter.ClearBeforeFill = true;
            // 
            // SIGNOS_VITALESTableAdapter
            // 
            this.SIGNOS_VITALESTableAdapter.ClearBeforeFill = true;
            // 
            // VistaPacienteMedicamentoTableAdapter
            // 
            this.VistaPacienteMedicamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportePaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 714);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReportePaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Pacitente";
            this.Load += new System.EventHandler(this.FrmReportePaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATOSPERSONALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PadecimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIGNOS_VITALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VistaPacienteMedicamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SintomasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DATOSPERSONALESBindingSource;
        private DataSetPaciente DataSetPaciente;
        private DataSetPacienteTableAdapters.DATOSPERSONALESTableAdapter DATOSPERSONALESTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource DatosPacienteBindingSource;
        private DataSetPacienteTableAdapters.DatosPacienteTableAdapter DatosPacienteTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource PadecimientosBindingSource;
        private DataSetPacienteTableAdapters.PadecimientosTableAdapter PadecimientosTableAdapter;
        private System.Windows.Forms.Label label6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.BindingSource SintomasBindingSource;
        private DataSetPacienteTableAdapters.SintomasTableAdapter SintomasTableAdapter;
        private System.Windows.Forms.BindingSource SIGNOS_VITALESBindingSource;
        private DataSetPacienteTableAdapters.SIGNOS_VITALESTableAdapter SIGNOS_VITALESTableAdapter;
        private System.Windows.Forms.BindingSource VistaPacienteMedicamentoBindingSource;
        private DataSetPacienteTableAdapters.VistaPacienteMedicamentoTableAdapter VistaPacienteMedicamentoTableAdapter;
    }
}