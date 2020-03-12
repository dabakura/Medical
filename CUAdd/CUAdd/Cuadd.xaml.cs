using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CUAdd
{
    /// <summary>
    /// Lógica de interacción para CUAdd.xaml
    /// </summary>
    

    public partial class Cuadd: UserControl
    {
        private DeleteChanged delete;

        public Cuadd()
        {
            InitializeComponent();
            Listas = new List<CTitulos>();
        }
        private List<CTitulos> Listas;

        public DeleteChanged Delete { get { return delete; } set { delete = value; } }
        

        public void AddSource(string diagnostico)
        {
            Listas.Add(new CTitulos() { Titulo = diagnostico });
            this.listboxloli.ItemsSource = null;
            this.listboxloli.ItemsSource = Listas;
        }

        public void remover(CTitulos o)
        {
            Listas.Remove(o);
            if (Delete != null)
                Delete.Invoke(o.Titulo);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            Grid grid = (Grid)bt.Parent;
            CTitulos loli = (CTitulos)grid.DataContext;
            if (loli != null)
            {
                remover(loli);
                this.listboxloli.ItemsSource = null;
                this.listboxloli.ItemsSource = Listas;
            }
        }
        
        public void Clear()
        {
            //this.listboxloli.Items.Clear();
            this.Listas.Clear();
            this.listboxloli.ItemsSource = null;
        }
    }
}
