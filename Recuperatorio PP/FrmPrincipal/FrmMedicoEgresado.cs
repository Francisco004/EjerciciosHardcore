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
    public partial class FrmMedicoEgresado : FrmMedico
    {
        private readonly MedicoEgresado medicoEgresadoDelForm;

        public MedicoEgresado MedicoEgresadoDelForm
        {
            get { return this.medicoEgresadoDelForm; }
        }

        public FrmMedicoEgresado(Medico medico)
        {
            InitializeComponent();
            
            this.medicoEgresadoDelForm = new MedicoEgresado(medico);

            #region Asignar valores a los campos
            this.textBoxApellido.Text = medicoEgresadoDelForm.Apellido;
            this.textBoxLegajo.Text = medicoEgresadoDelForm.Legajo.ToString();
            this.DateTimePickerIngreso.Text = medicoEgresadoDelForm.Ingreso.ToString();
            this.ComboBoxEspecialidad.Text = medicoEgresadoDelForm.Especialidad.ToString();
            this.TextBoxJornal.Text = this.medicoEgresadoDelForm.Jornal.ToString();
            #endregion
        }

        #region Deshabilitar modificacion

        protected override void ButtonAceptar(object sender, EventArgs e)
        {
            base.ButtonAceptar(sender, e);
        }

        private void TextBoxApellido_Enter(object sender, EventArgs e)
        {
            this.textBoxApellido.ReadOnly = true;
        }

        private void TextBoxApellido_Leave(object sender, EventArgs e)
        {
            this.textBoxApellido.ReadOnly = false;
        }

        protected override void TextBoxLegajo_Enter(object sender, EventArgs e)
        {
            this.textBoxLegajo.ReadOnly = true;
        }

        protected override void TextBoxLegajo_Leave(object sender, EventArgs e)
        {
            this.textBoxLegajo.ReadOnly = false;
        }

        protected override void FechaIngreso_Enter(object sender, EventArgs e)
        {
            this.DateTimePickerIngreso.Enabled = false;
        }

        protected override void FechaIngreso_Leave(object sender, EventArgs e)
        {
            this.DateTimePickerIngreso.Enabled = true;
        }

        private void CombEspecialidad_Enter(object sender, EventArgs e)
        {
            this.ComboBoxEspecialidad.Enabled = false;
        }

        private void CombEspecialidad_Leave(object sender, EventArgs e)
        {
            this.ComboBoxEspecialidad.Enabled = true;
        }

        private void TXTJornal_Enter(object sender, EventArgs e)
        {
            this.TextBoxJornal.ReadOnly = true;
        }

        private void TXTJornal_Leave(object sender, EventArgs e)
        {
            this.TextBoxJornal.ReadOnly = false;
        }
        #endregion
    }
}
