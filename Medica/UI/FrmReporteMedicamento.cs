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
    public partial class FrmReporteMedicamento : Form
    {
        private int id;
        public FrmReporteMedicamento(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FrmReporteMedicamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetMedicamentos.DOSIS' Puede moverla o quitarla según sea necesario.
            this.DOSISTableAdapter.Fill(this.DataSetMedicamentos.DOSIS);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMedicamentos.ViasAdministracion' Puede moverla o quitarla según sea necesario.
            this.ViasAdministracionTableAdapter.Fill(this.DataSetMedicamentos.ViasAdministracion);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMedicamentos.IndicacionSintoma' Puede moverla o quitarla según sea necesario.
            this.IndicacionSintomaTableAdapter.Fill(this.DataSetMedicamentos.IndicacionSintoma);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMedicamentos.IndicacionDiagnostico' Puede moverla o quitarla según sea necesario.
            this.IndicacionDiagnosticoTableAdapter.Fill(this.DataSetMedicamentos.IndicacionDiagnostico);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMedicamentos.ContraindicacionSintoma' Puede moverla o quitarla según sea necesario.
            this.ContraindicacionSintomaTableAdapter.Fill(this.DataSetMedicamentos.ContraindicacionSintoma);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMedicamentos.ContraindicacionDiagnostico' Puede moverla o quitarla según sea necesario.
            this.ContraindicacionDiagnosticoTableAdapter.Fill(this.DataSetMedicamentos.ContraindicacionDiagnostico);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMedicamentos.VistaMedicamentosContraindicacion' Puede moverla o quitarla según sea necesario.
            this.VistaMedicamentosContraindicacionTableAdapter.Fill(this.DataSetMedicamentos.VistaMedicamentosContraindicacion);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMedicamentos.EfectoAdverso' Puede moverla o quitarla según sea necesario.
            this.EfectoAdversoTableAdapter.Fill(this.DataSetMedicamentos.EfectoAdverso);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMedicamentos.MEDICAMENTO' Puede moverla o quitarla según sea necesario.
            this.MEDICAMENTOTableAdapter.Fill(this.DataSetMedicamentos.MEDICAMENTO);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMedicamentos.MEDI_NOMBRE' Puede moverla o quitarla según sea necesario.
            this.MEDI_NOMBRETableAdapter.Fill(this.DataSetMedicamentos.MEDI_NOMBRE);
            ReportParameter rp = new ReportParameter("Parameter", id.ToString());
            this.reportViewer1.LocalReport.SetParameters(rp);
            this.reportViewer2.LocalReport.SetParameters(rp);
            this.reportViewer3.LocalReport.SetParameters(rp);
            this.reportViewer4.LocalReport.SetParameters(rp);
            this.reportViewer5.LocalReport.SetParameters(rp);
            this.reportViewer6.LocalReport.SetParameters(rp);
            this.reportViewer7.LocalReport.SetParameters(rp);
            this.reportViewer8.LocalReport.SetParameters(rp);
            this.reportViewer9.LocalReport.SetParameters(rp);
            this.reportViewer10.LocalReport.SetParameters(rp);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
            this.reportViewer7.RefreshReport();
            this.reportViewer8.RefreshReport();
            this.reportViewer9.RefreshReport();
            this.reportViewer10.RefreshReport();
        }
        
    }
}
