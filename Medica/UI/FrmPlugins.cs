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
using System.Reflection;

namespace UI
{
    public partial class FrmPlugins : FormBase, CVentanaPlugin.IVentana
    {
        public FrmPlugins()
        {
            InitializeComponent();
        }

        public Panel Panel { get { return pnBody; } set { throw new NotImplementedException(); } }

        public IUtiles Util { get { return Utiles.Util; } set { throw new NotImplementedException(); } }

        public CVentanaPlugin.IVentana Ventana { get { return CWindows.Ventana; } set { throw new NotImplementedException(); } }

        public Image Icono { get { throw new NotImplementedException(); } }

        public void CambiarVentana(CVentanaPlugin.IVentana ventana)
        {
            Ventana.CambiarVentana(ventana);
        }

        public void load()
        {
            CPlugins.CargarPulgins(listView1,imageList1);
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected){
                if (e.ItemIndex == 0)
                {
                    CPlugins.GuardarPulgin();
                    CambiarVentana(new FrmPlugins());
                } 
                else if (e.ItemIndex > 0)
                {
                    CPlugins.CargarPulgin(e.Item.Tag);
                }
            }
        }
    }
}
