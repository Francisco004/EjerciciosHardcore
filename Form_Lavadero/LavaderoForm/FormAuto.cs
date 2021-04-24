using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaParcial;

namespace LavaderoForm
{
    public partial class FormAuto : Form
    {
        private Auto autitoDelForm;

        public Auto AutitoDelForm
        {
            get { return this.autitoDelForm; }
        }
        EMarcas variable;

        public FormAuto()
        {
            InitializeComponent();
            MarcaAuto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                this.autitoDelForm = new Auto(Convert.ToInt32(this.AsientoAuto.Text), this.PatenteAutos.Text, Convert.ToByte(this.RuedasAutos.Text), variable);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (PatenteAutos.Text == "Ford")
                {
                variable = EMarcas.Ford;
                }
                else
                {
                variable = EMarcas.Fiat;
                }
        }

        private void AsientoAuto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AsientoAuto.Text) || System.Text.RegularExpressions.Regex.IsMatch(AsientoAuto.Text, "[^0-9]"))
            {
                    e.Cancel = true;
                    AsientoAuto.Focus();
                    errorProvider1.SetError(AsientoAuto, "Porfavor ingrese los asientos sin ',' ni '.' ");
            }
            else
            {
                int prueba = Convert.ToInt32(AsientoAuto.Text);
                if (prueba > 6 || prueba < 1)
                {
                    e.Cancel = true;
                    AsientoAuto.Focus();
                    errorProvider1.SetError(AsientoAuto, "Ingrese asientos de 1 a 6 ");
                } else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(AsientoAuto, null);
                }
            }
        }

        private void RuedasAutos_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RuedasAutos.Text) || System.Text.RegularExpressions.Regex.IsMatch(RuedasAutos.Text, "[^0-9]"))
            {
                e.Cancel = true;
                RuedasAutos.Focus();
                errorProvider1.SetError(RuedasAutos, "Porfavor ingrese las ruedas ");
            }
            else
            {
                int prueba = Convert.ToInt32(RuedasAutos.Text);
                if (prueba > 6 || prueba < 1)
                {
                    e.Cancel = true;
                    RuedasAutos.Focus();
                    errorProvider1.SetError(RuedasAutos, "Porfavor ingrese ruedas de 1 a 6 ");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(RuedasAutos, null);
                }
            }
        }

        private void PatenteAutos_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PatenteAutos.Text))
            {
                e.Cancel = true;
                PatenteAutos.Focus();
                errorProvider1.SetError(PatenteAutos, "Porfavor ingrese la patente ");
            }
            else
            {
                int cantidad = PatenteAutos.Text.Length;
                if (cantidad > 6 || cantidad < 6)
                {
                    e.Cancel = true;
                    PatenteAutos.Focus();
                    errorProvider1.SetError(PatenteAutos, "Porfavor ingrese una patente de 6 digitos ");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(PatenteAutos, null);
                }
            }
        }
    }
}
