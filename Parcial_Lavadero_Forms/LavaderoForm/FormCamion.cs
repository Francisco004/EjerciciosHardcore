﻿using System;
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
    public partial class FormCamion : Form
    {
        private Camion camionDelForm;

        public Camion CamionDelForm
        {
            get { return this.camionDelForm; }
        }

        EMarcas variable;

        public FormCamion()
        {
            InitializeComponent();
            MarcaCamion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Marcass_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.MarcaCamion.SelectedIndex)
            {
                case 0:
                    variable = EMarcas.Scania;
                    break;
                case 1:
                    variable = EMarcas.Iveco;
                    break;
                case 2:
                    variable = EMarcas.RenaultTrucks;
                    break;
                case 3:
                    variable = EMarcas.Volvo;
                    break;
                case 4:
                    variable = EMarcas.Man;
                    break;
                case 5:
                    variable = EMarcas.Daf;
                    break;
                case 6:
                    variable = EMarcas.Mitsubishi;
                    break;
                case 7:
                    variable = EMarcas.Nissan;
                    break;
                case 8:
                    variable = EMarcas.Isuzu;
                    break;
                case 9:
                    variable = EMarcas.MercedesBenz;
                    break;

                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.camionDelForm = new Camion(float.Parse(this.TaraCamion.Text), this.PatenteCamion.Text, Byte.Parse(this.RuedasCamion.Text), variable);

            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TaraCamion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TaraCamion.Text) || System.Text.RegularExpressions.Regex.IsMatch(TaraCamion.Text, "[^0-9,]"))
            {
                e.Cancel = true;
                TaraCamion.Focus();
                errorProvider1.SetError(TaraCamion, "Porfavor ingrese el peso de la tara con ',' ");
            }
            else
            {
                float prueba = float.Parse(TaraCamion.Text);

                if (prueba > 6 || prueba < 1)
                {
                    e.Cancel = true;
                    TaraCamion.Focus();
                    errorProvider1.SetError(TaraCamion, "El peso de la tara no puede ser superior a 1,500 ");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(TaraCamion, null);
                }
            }
        }

        private void RuedasCamion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(RuedasCamion.Text) || System.Text.RegularExpressions.Regex.IsMatch(RuedasCamion.Text, "[^0-9]"))
            {
                e.Cancel = true;
                RuedasCamion.Focus();
                errorProvider1.SetError(RuedasCamion, "Porfavor ingrese las ruedas ");
            }
            else
            {
                int prueba = Convert.ToInt32(RuedasCamion.Text);
                if (prueba > 12 || prueba < 1)
                {
                    e.Cancel = true;
                    RuedasCamion.Focus();
                    errorProvider1.SetError(RuedasCamion, "Ingrese ruedas de 1 a 12 ");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(RuedasCamion, null);
                }
            }
        }

        private void PatenteCamion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PatenteCamion.Text))
            {
                e.Cancel = true;
                PatenteCamion.Focus();
                errorProvider1.SetError(PatenteCamion, "Porfavor ingrese la patente ");
            }
            else
            {
                int cantidad = PatenteCamion.Text.Length;
                if (cantidad > 6 || cantidad < 6)
                {
                    e.Cancel = true;
                    PatenteCamion.Focus();
                    errorProvider1.SetError(PatenteCamion, "Ingrese una patente de 6 caracteres ");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(PatenteCamion, null);
                }
            }
        }
    }
}
