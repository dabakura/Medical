using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazPlugin;
using BS;
using DAL;

namespace UI
{
    public partial class FrmMasInfoMedicamento : Form
    {
        public FrmMasInfoMedicamento(MEDICAMENTO m)
        {
            InitializeComponent();
            Cargar(m);
        }

        private void Cargar(MEDICAMENTO m)
        {
            this.m = m;
            m.SINTOMA.ToList().ForEach(s => lbEfecto.Items.Add(s.VEFECTO));
            m.CONTRAINDICACION_DIAGNOSTICO.ToList().ForEach(d => lbDiagnostico.Items.Add(d.DIAGNOSTICO.VDIAGNOSTICO));
            m.INDICACION_DIAGNOSTICO.ToList().ForEach(d => lbindiDiagnostico.Items.Add(d.DIAGNOSTICO.VDIAGNOSTICO));
            m.CONTRAINDICACION_SINTOMA.ToList().ForEach(d => lbSintoma.Items.Add(d.SINTOMA.VEFECTO));
            m.INDICACION_SINTOMA.ToList().ForEach(d => lbindiSintoma.Items.Add(d.SINTOMA.VEFECTO));
            m.CONTRAINDICACION_MEDICAMENTO.ToList().ForEach(d => lbMedi.Items.Add(d.MEDICAMENTO1.MEDI_NOMBRE.First().VNOMBRE));
            ListBox[] listas = new ListBox[] { lbDiagnostico , lbSintoma , lbMedi , lbindiSintoma , lbindiDiagnostico };
            foreach (ListBox item in listas)
            {
                if (item.Items.Count > 0)
                    item.SelectedIndex = 0;
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void lcMedi_SelectedValueChanged(object sender, EventArgs e)
        {
            String nombre = lbMedi.Text;
            m.CONTRAINDICACION_MEDICAMENTO.ToList().ForEach(c => {
                if (c.MEDICAMENTO1.MEDI_NOMBRE.Any(n => n.VNOMBRE.Equals(nombre)))
                    txtMedi.Text = c.VDESCRIPCION;
                    });

        }

        private void lbSintoma_SelectedValueChanged(object sender, EventArgs e)
        {
            String nombre = lbSintoma.Text;
            m.CONTRAINDICACION_SINTOMA.ToList().ForEach(c => {
                if (c.SINTOMA.VEFECTO.Equals(nombre))
                    txtSintoma.Text = c.VDESCRIPCION;
            });
        }

        private void lbDiagnostico_SelectedValueChanged(object sender, EventArgs e)
        {
            String nombre = lbDiagnostico.Text;
            m.CONTRAINDICACION_DIAGNOSTICO.ToList().ForEach(c => {
                if (c.DIAGNOSTICO.VDIAGNOSTICO.Equals(nombre))
                    txtDiagnostico.Text = c.VDESCRIPCION;
            });
        }

        private void lbindiDiagnostico_SelectedValueChanged(object sender, EventArgs e)
        {
            String nombre = lbindiDiagnostico.Text;
            m.INDICACION_DIAGNOSTICO.ToList().ForEach(c => {
                if (c.DIAGNOSTICO.VDIAGNOSTICO.Equals(nombre))
                    txtindiDiagnostico.Text = c.VDESCRIPCION;
            });
        }

        private void lbindiSintoma_SelectedValueChanged(object sender, EventArgs e)
        {
            String nombre = lbindiSintoma.Text;
            m.INDICACION_SINTOMA.ToList().ForEach(c => {
                if (c.SINTOMA.VEFECTO.Equals(nombre))
                    txtindiSintoma.Text = c.VDESCRIPCION;
            });
        }


        private MEDICAMENTO m;
    }
}
