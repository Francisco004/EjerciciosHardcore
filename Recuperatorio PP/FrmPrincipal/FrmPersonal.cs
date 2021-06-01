using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesRPP;

namespace FrmPrincipal
{
    public abstract partial class FrmPersonal : Form
    {
        public abstract Personal PersonalDelForm { get; }

        public FrmPersonal()
        {
            InitializeComponent();
        }

        #region Validaciones
        private void TextBoxApellido_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxApellido.Text))
            {
                e.Cancel = true;
                textBoxApellido.Focus();
                errorProvider1.SetError(textBoxApellido, "Porfavor ingrese el apellido");
            }
            else if(SoloLetras())
            {
                e.Cancel = true;
                textBoxApellido.Focus();
                errorProvider1.SetError(textBoxApellido, "El apellido no debe incluir numeros");
            }
            else
            {
                if (textBoxApellido.Text.Length < 3)
                {
                    e.Cancel = true;
                    textBoxLegajo.Focus();
                    errorProvider1.SetError(textBoxApellido, "El nombre debe tener al menos 3 letras");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(textBoxApellido, null);
                }
            }
        }

        private void TextBoxLegajo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLegajo.Text))
            {
                e.Cancel = true;
                textBoxLegajo.Focus();
                errorProvider1.SetError(textBoxLegajo, "Porfavor ingrese el legajo");
            }
            else
            {
                if (textBoxLegajo.Text.Length > 6 || textBoxLegajo.Text.Length < 6)
                {
                    e.Cancel = true;
                    textBoxLegajo.Focus();
                    errorProvider1.SetError(textBoxLegajo, "El legajo debe tener 6 numeros");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(textBoxLegajo, null);
                }
            }
        }

        private bool SoloLetras()
        {
            bool letras = false;

            for (int i = 0; i < this.textBoxApellido.Text.Length; i++)
            {
                if(!System.Text.RegularExpressions.Regex.IsMatch(textBoxApellido.Text[i].ToString(), "^[a-zA-Z ]"))
                {
                    letras = true;
                    break;
                }
            }

            return letras;
        }
        #endregion

        #region Virtual
        protected virtual void ButtonAceptar(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        protected void ButtonCancelar(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected virtual void FechaIngreso_Enter(object sender, EventArgs e)
        {

        }

        protected virtual void FechaIngreso_Leave(object sender, EventArgs e)
        {

        }

        protected virtual void TextBoxLegajo_Enter(object sender, EventArgs e)
        {

        }

        protected virtual void TextBoxLegajo_Leave(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
