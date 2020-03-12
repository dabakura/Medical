using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCErrorTextBox
{
    public class Comprobacion
    {
        private static String contraseña1, contraseña2;
        private static Boolean Validar;

        public static Boolean ValidarCampos(Control objeto, ErrorProvider error)
        {
            Validar = true;
            return ValidarCamposE(objeto, error);
        }

        private static Boolean ValidarCamposE(Control objeto, ErrorProvider error)
        {
            foreach (Control Item in objeto.Controls)
            {
                if (Item.HasChildren)
                {
                    Validar = ValidarCamposE(Item, error);
                }
                else if (Item is ErrorTxtBox)
                {
                    ErrorTxtBox errorTxtBox = (ErrorTxtBox)Item;
                    if (errorTxtBox.Validar == true)
                    {
                        if (string.IsNullOrEmpty(errorTxtBox.Text.Trim()))
                        {
                            error.SetError(errorTxtBox, "No puede estar vacio");
                            Validar = false;
                        }
                    }
                }
            }
            return Validar;
        }

        public static void LimpiarCampos(Control objeto)
        {
            foreach (Control Item in objeto.Controls)
            {
                if (Item.HasChildren)
                {
                    LimpiarCampos(Item);
                }
                else if (Item is ErrorTxtBox )
                {
                    ErrorTxtBox errorTxtBox = (ErrorTxtBox)Item;
                    if (errorTxtBox.AutoClear == true)
                    {
                        errorTxtBox.Clear();
                    }
                }
            }
        }

        public static Boolean ValidarContraseñas(Control objeto, ErrorProvider error)
        {
            Validar = true;
            contraseña1 = contraseña2 = null;
            return ValidarContraseñasE(objeto, error);
        }

        private static Boolean ValidarContraseñasE(Control objeto, ErrorProvider error)
        {
            foreach (Control Item in objeto.Controls)
            {
                if (Item.HasChildren)
                {
                    Validar = ValidarContraseñasE(Item, error);
                }
                else if (Item is ErrorTxtBox )
                {
                    ErrorTxtBox errorTxtBox = (ErrorTxtBox)Item;
                    if (errorTxtBox.ValidarContraseñas == true)
                    {
                        if (string.IsNullOrEmpty(contraseña1))
                        {
                            contraseña1 = errorTxtBox.Text;
                        }
                        else
                        {
                            contraseña2 = errorTxtBox.Text;
                            System.Diagnostics.Debug.WriteLine(contraseña1 + " " + contraseña2);
                            if (!contraseña1.Equals(contraseña2))
                            {
                                error.SetError(errorTxtBox, "Contraseñas no Coinciden");
                                return false;
                            }
                        }
                    }
                }
            }
            return Validar;
        }

        public string Contraseña1 { get { return contraseña1; } set { contraseña1 = value; } }
        public string Contraseña2 { get { return contraseña2; } set { contraseña2 = value; } }
    }
}
