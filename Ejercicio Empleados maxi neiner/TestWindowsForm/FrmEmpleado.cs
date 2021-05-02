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
    public partial class FrmEmpleado : Form
    {
        private Empleado empleadoDelForm;

        public Empleado EmpleadoDelForm
        {
            get { return this.empleadoDelForm; }
        }

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.empleadoDelForm = new Empleado(this.txtNombre.Text, this.txtApellido.Text, 
                                int.Parse(this.txtLegajo.Text), double.Parse(this.txtSueldo.Text));

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
