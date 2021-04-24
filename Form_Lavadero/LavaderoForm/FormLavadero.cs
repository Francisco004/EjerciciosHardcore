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
            OrdenamientoSeleccionado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void MostrarEnVisor()
        {
            this.ListadoVehiculos.Items.Clear();

            foreach (Vehiculo item in this.miLavadero.Vehiculos)
            {
                if (item is Auto auto)
                {
                     this.ListadoVehiculos.Items.Add("Auto ingresado: --- " + auto.MostrarAuto());
                }
                if (item is Camion camion)
                {
                    this.ListadoVehiculos.Items.Add("Camion ingresado: --- " + camion.MostrarCamion());
                }
                if (item is Moto moto)
                {
                    this.ListadoVehiculos.Items.Add("Moto ingresado: --- " + moto.MostrarMoto());
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
                if(VehiculoSeleccionado.Text == "Auto")
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

            if(i >= 0)
            {
                _ = this.miLavadero - this.miLavadero.Vehiculos[i];
            }

            this.MostrarEnVisor();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            if (OrdenamientoSeleccionado.Text == "Ordenar por marca")
            {
                miLavadero.Vehiculos.Sort(miLavadero.OrdenarVehiculosPorMarca);
                ConfirmacionOrdena.Text = "Ordenado por marca";
            }
            if (OrdenamientoSeleccionado.Text == "Ordenar por patente")
            {
                miLavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
                ConfirmacionOrdena.Text = "Ordenado por patente";
            }

            this.MostrarEnVisor();
        }
    }
}
