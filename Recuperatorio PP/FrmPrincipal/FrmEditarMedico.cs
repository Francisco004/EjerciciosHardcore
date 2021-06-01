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
    public partial class FrmEditarMedico : FrmPersonal
    {
        private Medico medicoModificado;

        public override Personal PersonalDelForm => this.medicoModificado;

        protected Especialidad variable;

        public FrmEditarMedico(Medico medico)
        {
            InitializeComponent();

            #region Asignar valores a los campos
            this.textBoxApellido.Text = medico.Apellido;
            this.textBoxLegajo.Text = medico.Legajo.ToString();
            this.DateTimePickerIngreso.Text = medico.Ingreso.ToString();
            this.ComboBoxEspecialidad.Text = medico.Especialidad.ToString();
            #endregion
        }

        #region Form

        private void ComboxEspecialidad(object sender, EventArgs e)
        {
            switch (this.ComboBoxEspecialidad.SelectedIndex)
            {
                case 0:
                    variable = Especialidad.Cirujano;
                    break;
                case 1:
                    variable = Especialidad.Pediatra;
                    break;
                case 2:
                    variable = Especialidad.Clinico;
                    break;
            }
        }

        protected override void ButtonAceptar(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DateTime fechaForm = DateTime.Parse(DateTimePickerIngreso.Value.ToLongTimeString());

                ComboxEspecialidad(sender, e);

                this.medicoModificado = new Medico(this.textBoxApellido.Text, Convert.ToInt32(this.textBoxLegajo.Text), fechaForm, variable);
                base.ButtonAceptar(sender, e);
            }
        }
        #endregion

        #region Deshabilitar modificacion

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
        #endregion
    }
}

