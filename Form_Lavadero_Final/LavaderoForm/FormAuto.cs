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
using System.Media;
using System.IO;

namespace LavaderoForm
{
    public partial class FormAuto : Form
    {
        private readonly string pathToMusic = Directory.GetCurrentDirectory();
        private readonly SoundPlayer myPlayer = new SoundPlayer();

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
            this.Music(myPlayer);
        }

        private void Music(SoundPlayer myPlayer)
        {
            myPlayer.SoundLocation = this.pathToMusic + @"\twitter.wav";
            myPlayer.PlayLooping();
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
            switch (this.MarcaAuto.SelectedIndex)
            {
                case 0:
                    variable = EMarcas.Ford;
                    break;
                case 1:
                    variable = EMarcas.Fiat;
                    break;
                case 2:
                    variable = EMarcas.BMW;
                    break;
                case 3:
                    variable = EMarcas.MercedesBenz;
                    break;
                case 4:
                    variable = EMarcas.Audi;
                    break;
                case 5:
                    variable = EMarcas.Lexus;
                    break;
                case 6:
                    variable = EMarcas.Renault;
                    break;
                case 7:
                    variable = EMarcas.Opel;
                    break;
                case 8:
                    variable = EMarcas.Seat;
                    break;
                case 9:
                    variable = EMarcas.Suzuki;
                    break;

                default:
                    break;
            }
        }

        private void AsientoAuto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AsientoAuto.Text) || System.Text.RegularExpressions.Regex.IsMatch(AsientoAuto.Text, "[^0-9]"))
            {
                    e.Cancel = true;
                    AsientoAuto.Focus();
                    errorProvider1.SetError(AsientoAuto, "Porfavor ingrese los asientos sin letras, comas o puntos ");
            }
            else
            {
                int prueba = Convert.ToInt32(AsientoAuto.Text);
                if (prueba > 6 || prueba < 1)
                {
                    e.Cancel = true;
                    AsientoAuto.Focus();
                    errorProvider1.SetError(AsientoAuto, "Ingrese de 1 a 6 asientos");
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
                    errorProvider1.SetError(RuedasAutos, "Ingrese de 1 a 6 ruedas");
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
                    errorProvider1.SetError(PatenteAutos, "Ingrese una patente de 6 caracteres ");
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
