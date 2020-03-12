using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace UI
{
    public partial class FrmReportePaciente : Form
    {
        private string id;
        public FrmReportePaciente(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FrmReportePaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPaciente.VistaPacienteMedicamento' Puede moverla o quitarla según sea necesario.
            this.VistaPacienteMedicamentoTableAdapter.Fill(this.DataSetPaciente.VistaPacienteMedicamento);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPaciente.SIGNOS_VITALES' Puede moverla o quitarla según sea necesario.
            this.SIGNOS_VITALESTableAdapter.Fill(this.DataSetPaciente.SIGNOS_VITALES);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPaciente.Sintomas' Puede moverla o quitarla según sea necesario.
            this.SintomasTableAdapter.Fill(this.DataSetPaciente.Sintomas);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPaciente.Padecimientos' Puede moverla o quitarla según sea necesario.
            this.PadecimientosTableAdapter.Fill(this.DataSetPaciente.Padecimientos);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPaciente.DatosPaciente' Puede moverla o quitarla según sea necesario.
            this.DatosPacienteTableAdapter.Fill(this.DataSetPaciente.DatosPaciente);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPaciente.DATOSPERSONALES' Puede moverla o quitarla según sea necesario.

            this.DATOSPERSONALESTableAdapter.Fill(this.DataSetPaciente.DATOSPERSONALES);
            ReportParameter rp = new ReportParameter("Parameter",id);
            this.reportViewer1.LocalReport.SetParameters(rp);
            this.reportViewer2.LocalReport.SetParameters(rp);
            this.reportViewer3.LocalReport.SetParameters(rp);
            this.reportViewer4.LocalReport.SetParameters(rp);
            this.reportViewer5.LocalReport.SetParameters(rp);
            this.reportViewer6.LocalReport.SetParameters(rp);
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
        }
    }
}
