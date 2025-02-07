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
using System.Media;
using System.IO;

namespace LavaderoForm
{
    public partial class FormLavadero : Form
    {
        public Lavadero miLavadero;

        public Lavadero MiLavadero
        {
            get { return this.miLavadero; }
        }

        public FormLavadero()
        {
            InitializeComponent();

            this.miLavadero = new Lavadero(400,800,200);
            this.StartPosition = FormStartPosition.CenterScreen;
            VehiculoSeleccionado.DropDownStyle = ComboBoxStyle.DropDownList;
            Listado.DropDownStyle = ComboBoxStyle.DropDownList;
            OrdenamientoSeleccionado.DropDownStyle = ComboBoxStyle.DropDownList;
            this.MostrarEnVisor();
        }

        private void MostrarEnVisor()
        {
            this.ListadoVehiculos.Items.Clear();

            foreach (Vehiculo item in this.miLavadero.Vehiculos)
            {
                this.ListadoVehiculos.Items.Add(item.Mostrar());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (VehiculoSeleccionado.Text == "Auto")
                {
                FormAuto frmAuto = new FormAuto
                {
                    StartPosition = FormStartPosition.CenterScreen
                };

                if (frmAuto.ShowDialog() == DialogResult.OK)
                    {
                        this.miLavadero += frmAuto.AutitoDelForm;
                        this.MostrarEnVisor();
                    }
                }
                if (VehiculoSeleccionado.Text == "Moto")
                {
                FormMoto frmMoto = new FormMoto
                {
                    StartPosition = FormStartPosition.CenterScreen
                };

                if (frmMoto.ShowDialog() == DialogResult.OK)
                    {
                        this.miLavadero += frmMoto.MotitoDelForm;
                        this.MostrarEnVisor();
                    }
                }
                if (VehiculoSeleccionado.Text == "Camion")
                {
                FormCamion frmCamion = new FormCamion
                {
                    StartPosition = FormStartPosition.CenterScreen
                };

                if (frmCamion.ShowDialog() == DialogResult.OK)
                    {
                        this.miLavadero += frmCamion.CamionDelForm;
                        this.MostrarEnVisor();
                    }
                }
        }

        private void EliminarVehiculo_Click(object sender, EventArgs e)
        {
            int i = this.ListadoVehiculos.SelectedIndex;

            if(i >= 0 && ListadoVehiculos.Text != "Autos ingresados: " && ListadoVehiculos.Text != "Motos ingresadas: " && ListadoVehiculos.Text != "Camiones ingresados: " && ListadoVehiculos.Text != " ")
            {
                _ = this.miLavadero - this.miLavadero.Vehiculos[i];

                this.ListadoPrecios.Items.Clear();
            }

            this.MostrarEnVisor();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            if (OrdenamientoSeleccionado.Text == "Ordenar por marca")
            {
                miLavadero.Vehiculos.Sort(miLavadero.OrdenarVehiculosPorMarca);
            }
            if (OrdenamientoSeleccionado.Text == "Ordenar por patente")
            {
                miLavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            }

            this.MostrarEnVisor();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(Listado.Text == "Listado de precios totales")
            {
                this.ListadoPrecios.Items.Clear();
                this.ListadoPrecios.Items.Add("Total facturado del lavadero: " + miLavadero.MostrarTotalFacturado());
            }
            else if (Listado.Text == "Listado de precios por vehiculo")
            {
                this.ListadoPrecios.Items.Clear();
                this.ListadoPrecios.Items.Add("Total facturado de autos: " + miLavadero.MostrarTotalFacturado(EVehiculos.Auto));
                this.ListadoPrecios.Items.Add("Total facturado de motos: " + miLavadero.MostrarTotalFacturado(EVehiculos.Moto));
                this.ListadoPrecios.Items.Add("Total facturado de camiones: " + miLavadero.MostrarTotalFacturado(EVehiculos.Camion));
            }
        }
    }
}
