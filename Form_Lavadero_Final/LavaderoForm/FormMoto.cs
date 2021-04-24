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
    public partial class FormMoto : Form
    {
        private readonly string pathToMusic = Directory.GetCurrentDirectory();
        private readonly SoundPlayer myPlayer = new SoundPlayer();

        private Moto motitoDelForm;

        public Moto MotitoDelForm
        {
            get { return this.motitoDelForm; }
        }

        EMarcas variable;

        public FormMoto()
        {
            InitializeComponent();
            MarcaMotos.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Music(myPlayer);
        }

        private void Music(SoundPlayer myPlayer)
        {
            myPlayer.SoundLocation = this.pathToMusic + @"\samsung-car.wav";
            myPlayer.PlayLooping();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.MarcaMotos.SelectedIndex)
            {
                case 0:
                    variable = EMarcas.Honda;
                    break;
                case 1:
                    variable = EMarcas.Zanella;
                    break;
                case 2:
                    variable = EMarcas.HarleyDavidson;
                    break;
                case 3:
                    variable = EMarcas.Ducati;
                    break;
                case 4:
                    variable = EMarcas.Aprilia;
                    break;
                case 5:
                    variable = EMarcas.Yamaha;
                    break;
                case 6:
                    variable = EMarcas.Kawasaki;
                    break;
                case 7:
                    variable = EMarcas.Suzuki;
                    break;

                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.motitoDelForm = new Moto(float.Parse(this.CilindradaMoto.Text), this.PatenteMoto.Text, Convert.ToByte(this.RuedasMoto.Text), variable);

            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CilindradaMoto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CilindradaMoto.Text) || System.Text.RegularExpressions.Regex.IsMatch(CilindradaMoto.Text, "[^0-9,]"))
            {
                e.Cancel = true;
                CilindradaMoto.Focus();
                errorProvider1.SetError(CilindradaMoto, "Porfavor ingrese las cilindradas con ',' ");
            }
            else
            {
                float prueba = float.Parse(CilindradaMoto.Text);

                if (prueba > 6 || prueba < 1)
                {
                    e.Cancel = true;
                    CilindradaMoto.Focus();
                    errorProvider1.SetError(CilindradaMoto, "La cilindrada no debe superio a 6,0 ");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(CilindradaMoto, null);
                }
            }
        }

        private void RuedasMoto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RuedasMoto.Text) || System.Text.RegularExpressions.Regex.IsMatch(RuedasMoto.Text, "[^0-9]"))
            {
                e.Cancel = true;
                RuedasMoto.Focus();
                errorProvider1.SetError(RuedasMoto, "Porfavor ingrese las ruedas ");
            }
            else
            {
                int prueba = Convert.ToInt32(RuedasMoto.Text);
                if (prueba > 6 || prueba < 1)
                {
                    e.Cancel = true;
                    RuedasMoto.Focus();
                    errorProvider1.SetError(RuedasMoto, "Ingrese de 1 a 2 ruedas");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(RuedasMoto, null);
                }
            }
        }

        private void PatenteMoto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PatenteMoto.Text))
            {
                e.Cancel = true;
                PatenteMoto.Focus();
                errorProvider1.SetError(PatenteMoto, "Porfavor ingrese la patente ");
            }
            else
            {
                int cantidad = PatenteMoto.Text.Length;
                if (cantidad > 6 || cantidad < 6)
                {
                    e.Cancel = true;
                    PatenteMoto.Focus();
                    errorProvider1.SetError(PatenteMoto, "Ingrese una patente de 6 caracteres ");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(PatenteMoto, null);
                }
            }
        }
    }
}