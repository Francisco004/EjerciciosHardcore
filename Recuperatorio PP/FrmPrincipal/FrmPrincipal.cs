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
    public partial class FrmPrincipal : Form
    {
        protected Hospital miHospital;
        protected Hospital miHospitalEgresados;
        protected List<MedicoEgresado> egresados;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.egresados = new List<MedicoEgresado>();
            this.miHospital = (Hospital)"Hospital Francisco Rocha";
            this.miHospitalEgresados = (Hospital)"EngresadosBorrados";


            StartPosition = FormStartPosition.CenterScreen;
        }

        #region Ingreso del medico
        //////Ingreso

        private void ButtonIngresar(object sender, EventArgs e)
        {
            FrmMedico FormMedico = new FrmMedico();

            if (FormMedico.ShowDialog() == DialogResult.OK)
            {
                if (YaIngresado(FormMedico))
                {

                }
                else
                {
                    Agregar(FormMedico);
                }

                this.MostrarEnVisor();
            }
        }
        #endregion

        #region Eliminar medico
        //////Eliminar

        private void ButtonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Eliminar();
                this.MostrarEnVisor();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un medico para poder borrarlo");
            }
        }
        #endregion

        #region Modificar medico
        //////Modificar

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEditarMedico FormMedicoModificado = new FrmEditarMedico((Medico)miHospital[this.ingresadoMostrar.SelectedIndex])
                {
                    StartPosition = FormStartPosition.CenterScreen
                };

                if (FormMedicoModificado.ShowDialog() == DialogResult.OK)
                {
                    Eliminar();
                    Agregar(FormMedicoModificado);
                    this.MostrarEnVisor();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un medico para poder modificarlo");
            }
        }
        #endregion

        #region Egreso del medico
        //////Egreso

        private void ButtonEgresar(object sender, EventArgs e)
        {
            try
            {
                FrmMedicoEgresado FormMedicoEgresado = new FrmMedicoEgresado((Medico)miHospital[this.ingresadoMostrar.SelectedIndex])
                {
                    StartPosition = FormStartPosition.CenterScreen
                };

                if (FormMedicoEgresado.ShowDialog() == DialogResult.OK)
                {
                    this.miHospital -= miHospital[this.ingresadoMostrar.SelectedIndex];
                    this.egresados.Add(FormMedicoEgresado.MedicoEgresadoDelForm);
                    this.MostrarEnVisor();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un medico para poder egresarlo");
            }
        }
        #endregion

        #region Mostrar y Ordenar

        private void MostrarEnVisor()
        {
            this.egresadoMostrar.Items.Clear();
            this.ingresadoMostrar.Items.Clear();

            for (int i = 0; i < this.miHospital.CantidadPersonal; i++)
            {
                this.ingresadoMostrar.Items.Add(this.miHospital[i].ToString());
            }

            foreach (Personal item in this.egresados)
            {
                this.egresadoMostrar.Items.Add(item.ToString());
            }
        }

        private void ComboBoxOrdenamiento(object sender, EventArgs e)
        {
            if (this.egresados.Count < 2 && this.ComboBoxOrdenamientoSelec.SelectedIndex != -1)
            {
                this.ComboBoxOrdenamientoSelec.SelectedIndex = -1;
                MessageBox.Show("Para ordenar debe tener egresado al menos 2 medicos");
            }

            switch (this.ComboBoxOrdenamientoSelec.SelectedIndex)
            {
                case 0:
                    this.egresados.Sort(Personal.OrdenarPorLegajoAsc);
                    break;
                case 1:
                    this.egresados.Sort(Personal.OrdenarPorLegajoDec);
                    break;
                case 2:
                    this.egresados.Sort(Personal.OrdenarPorApellidoAsc);
                    break;
                case 3:
                    this.egresados.Sort(Personal.OrdenarPorApellidoDec);
                    break;
                case 4:
                    this.egresados.Sort(MedicoEgresado.OrdenarPorEspecialidad);
                    break;
                case 5:
                    this.egresados.Sort(MedicoEgresado.OrdenarPorJornalAsc);
                    break;
                case 6:
                    this.egresados.Sort(MedicoEgresado.OrdenarPorJornalDec);
                    break;
                case 7:
                    this.egresados.Sort(MedicoEgresado.OrdenarPorFechaEgresoAsc);
                    break;
                case 8:
                    this.egresados.Sort(MedicoEgresado.OrdenarPorFechaEgresoDec);
                    break;
            }

            this.MostrarEnVisor();
        }
        #endregion

        #region Metodos
        private void Eliminar()
        {
            this.miHospital -= miHospital[this.ingresadoMostrar.SelectedIndex];
            this.miHospitalEgresados -= miHospitalEgresados[this.ingresadoMostrar.SelectedIndex];
        }

        private void Agregar(FrmPersonal agregado)
        {
            this.miHospital += agregado.PersonalDelForm;
            this.miHospitalEgresados += agregado.PersonalDelForm;
        }

        private bool YaIngresado(FrmPersonal ingresado)
        {
            bool retorno = false;

            if ((this.miHospital | ingresado.PersonalDelForm) != -1)
            {
                retorno = true;
                MessageBox.Show("Ya existe un medico con ese legajo...");
            }
            else if ((this.miHospitalEgresados | ingresado.PersonalDelForm) != -1)
            {
                retorno = true;
                MessageBox.Show("Ya se egreso un medico con ese legajo...");
            }

            return retorno;
        }
        #endregion

        private void BotonIngresar_MouseEnter(object sender, EventArgs e)
        {
            BotonIngresar.Text = "Ingresar";
        }

        private void BotonIngresar_MouseLeave(object sender, EventArgs e)
        {
            BotonIngresar.Text = "";
        }

        private void ButtonBorrar_MouseEnter(object sender, EventArgs e)
        {
            ButtonBorrar.Text = "Borrar";
        }

        private void ButtonBorrar_MouseLeave(object sender, EventArgs e)
        {
            ButtonBorrar.Text = "";
        }

        private void BotonEgresar_MouseEnter(object sender, EventArgs e)
        {
            BotonEgresar.Text = "Egresar";
        }

        private void BotonEgresar_MouseLeave(object sender, EventArgs e)
        {
            BotonEgresar.Text = "";
        }

        private void ButtonModificar_MouseEnter(object sender, EventArgs e)
        {
            ButtonModificar.Text = "Modificar";
        }

        private void ButtonModificar_MouseLeave(object sender, EventArgs e)
        {
            ButtonModificar.Text = "";
        }
    }
}
