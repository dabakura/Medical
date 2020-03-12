using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO;
using DAL;

namespace UI
{
    public partial class CUDataGrip : DataGridView
    {
        public CUDataGrip()
        {
            InitializeComponent();
            lista = new List<CMedi>();
            this.RowPrePaint += new DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            this.Rows[e.RowIndex].DefaultCellStyle.BackColor = lista.ElementAt(e.RowIndex).GetColor();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 4) && e.Value != null)
            {
                DataGridViewCell cell = this.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = lista.ElementAt(e.RowIndex).GetMensajeAlta();
            }
            if ((e.ColumnIndex == 5) && e.Value != null)
            {
                DataGridViewCell cell = this.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = lista.ElementAt(e.RowIndex).GetMensajeBaja();
            }
            if ((e.ColumnIndex == 6) && e.Value != null)
            {
                DataGridViewCell cell = this.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = lista.ElementAt(e.RowIndex).GetMensajeSintoma();
            }
            if ((e.ColumnIndex == 7) && e.Value != null)
            {
                DataGridViewCell cell = this.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = lista.ElementAt(e.RowIndex).GetMensajeDiagnostico();
            }
        }

        public void SetMedi(CMedi medi)
        {
            this.Data().Add(medi);
            this.pintar();
        }

        public void SetData(List<CMedi> l)
        {
            Clear();
            if (l!=null)
                l.ForEach(d => SetMedi(d));
        }


        public void Removeat(int i)
        {
            if (i > -1 && i < Data().Count)
            {
                this.Data().RemoveAt(i);
                this.pintar();
            }
            
        }

        public void Modificar(CMedi medi)
        {
            int i = -1;
            if (Data().Exists(d => { if (d.GetMedicamentoCodigo() == medi.GetMedicamentoCodigo()) { i = Data().IndexOf(d); return true; } return false; }))
            {
                this.Data().RemoveAt(i);
                this.Data().Insert(i, medi);
                this.pintar();
            }
            
        }

        public PACIENTE_MEDICAMENTO GetMedi(int i)
        {
            if (i > -1 && i < Data().Count)
            {
                return Data().ElementAt(i).GetPacienteMedicamento();
            }
            return null;
        }

        private void pintar()
        {
            this.DataSource = null;
            this.DataSource = Data();
        }

        private List<CMedi> Data()
        {
            return lista;
        }

        private List<CMedi> lista;

        public void Clear()
        {
            lista.Clear();
            DataSource = null;
        }
    }
}
