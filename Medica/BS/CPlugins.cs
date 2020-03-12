using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfazPlugin;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using DAL;

namespace BS
{
    public class CPlugins
    {
        private static List<string> nombres;

        public static List<string> Nombres { get { return (nombres != null) ? nombres : nombres = new List<string>(); } set { nombres = value; } }

        public static void CargarPulgins(ListView listView, ImageList imageList)
        {
            Nombres = Utiles.DeSerializarXML<string>("plugins.xml");
            for (int i = 1; i < imageList.Images.Count; i++)
                imageList.Images.RemoveAt(i);
            foreach (string name in Nombres)
            {
                Assembly assembly = null;
                try
                {
                    assembly = Assembly.LoadFrom(name);
                    var clase = from c in assembly.GetTypes() where c.IsClass && c.GetInterface("IVentana") != null && c.Name == "CPluginMedical" select c;
                    foreach (Type item in clase)
                    {
                        var pluginInfo = from a in item.GetCustomAttributes(false) where a.GetType() == typeof(CVentanaPlugin.CInfoPlugIn) select a;
                        CVentanaPlugin.IVentana ventana = (CVentanaPlugin.IVentana)assembly.CreateInstance(item.FullName, true);
                        foreach (CVentanaPlugin.CInfoPlugIn a in pluginInfo)
                        {
                            imageList.Images.Add(ventana.Icono);
                            ListViewItem listViewItem = new ListViewItem(a.Nombre);
                            listViewItem.ImageIndex = imageList.Images.Count - 1;
                            listViewItem.Tag = name;
                            listView.Items.Add(listViewItem);
                            break;
                        }
                        break;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error ocurrido al cargar el plugin\n"+e.Message, "Plugin Invalido o Corrupto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                listView.Refresh();
            }
        }

        public static void CargarPulgin(object name)
        {
            Assembly assembly = null;
            try
            {
                assembly = Assembly.LoadFrom(name.ToString());
                var clase = from c in assembly.GetTypes() where c.IsClass && c.GetInterface("IVentana") != null && c.Name == "CPluginMedical" select c;
                foreach (Type item in clase)
                {
                    CVentanaPlugin.IVentana ventana = (CVentanaPlugin.IVentana)assembly.CreateInstance(item.FullName, true);
                    ventana.Util = CWindows.Ventana.Util;
                    ventana.Ventana = CWindows.Ventana;
                    CWindows.Ventana.CambiarVentana(ventana);
                    break;
                }
            }catch (Exception e)
            {
                MessageBox.Show("Error ocurrido al cargar el plugin\n" + e.Message, "Plugin Invalido o Corrupto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void GuardarPulgin()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (DialogResult.OK == openFile.ShowDialog())
            {
                if (!Nombres.Contains(openFile.SafeFileName))
                {
                    Assembly assembly = null;
                    Boolean encontrado = false;
                    try
                    {
                        assembly = Assembly.LoadFrom(openFile.FileName);
                        var clase = from c in assembly.GetTypes() where c.IsClass && c.GetInterface("IVentana") != null && c.Name == "CPluginMedical" select c;
                        foreach (Type item in clase)
                        {
                            encontrado = true;
                            break;
                        }
                        if (encontrado)
                        {
                            Nombres.Add(openFile.SafeFileName);
                            Utiles.SerializarXML<string>(Nombres, "plugins.xml");
                            FileStream fileStream = new FileStream(openFile.SafeFileName, FileMode.Create, FileAccess.Write);
                            openFile.OpenFile().CopyTo(fileStream);
                            fileStream.Close();
                        }
                        else
                        {
                            MessageBox.Show("Este no es un plugin valido", "Plugin Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Este no es un plugin valido\n"+e.Message, "Plugin Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Este plugin ya esta instalado","Plugin Existente",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
