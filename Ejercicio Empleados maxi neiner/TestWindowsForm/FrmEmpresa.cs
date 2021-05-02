using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace HerenciaWindowsForm
{
    public partial class FrmEmpresa : Form
    {
        private Empresa miEmpresa;

        public Empresa MiEmpresa
        {
            get { return  this.miEmpresa; }
        }

        public FrmEmpresa()
        {
            InitializeComponent();

            this.miEmpresa = new Empresa("Accentuna");

            this.Text = this.miEmpresa.nombre;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            this.cboOrdenamiento.SelectedIndex = 0;
            this.cboOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;         
        }

        private void cboOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comparison<Empleado> comparador = null;

            switch (this.cboOrdenamiento.SelectedIndex)
            {
                case 0:
                    comparador = Empleado.OrdernarPorLegajoAsc;
                    break;
                case 1:
                    comparador = Empleado.OrdernarPorLegajoDesc;
                    break;
                case 2:
                    comparador = Empleado.OrdernarPorSueldoAsc;
                    break;
                case 3:
                    comparador = Empleado.OrdernarPorSueldoDesc;
                    break;
                case 4:
                    comparador = Empleado.OrdernarPorApellidoAsc;
                    break;
                case 5:
                    comparador = Empleado.OrdernarPorApellidoDesc;
                    break;

                default:
                    break;
            }

            this.miEmpresa.Empleados.Sort(comparador);

            this.MostrarEnVisor();
        }

        private void MostrarEnVisor()
        {
            this.lstVisor.Items.Clear();

            foreach (Empleado item in this.miEmpresa.Empleados)
            {
                this.lstVisor.Items.Add(item.MostrarEmpleado());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEmpleado frm = new FrmEmpleado();

            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.miEmpresa += frm.EmpleadoDelForm;

                this.MostrarEnVisor();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = this.lstVisor.SelectedIndex;

            if (i > -1)
            {
                bool rta = this.miEmpresa - this.miEmpresa.Empleados[i];

                if (! rta)
                {
                    MessageBox.Show("No se pudo eliminar");
                    return;
                }

                this.MostrarEnVisor();
            }
        }
    }
}
