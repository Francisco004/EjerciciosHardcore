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
    public partial class FrmMedico : FrmPersonal
    {
        private Medico medicoDelForm;

        protected Especialidad variable;

        public override Personal PersonalDelForm => this.medicoDelForm;

        public FrmMedico()
        {
            InitializeComponent();
            this.ComboBoxEspecialidad.SelectedIndex = 0;
            StartPosition = FormStartPosition.CenterScreen;
            ComboBoxEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #region Form

        protected override void ButtonAceptar(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DateTime fechaForm = DateTime.Parse(DateTimePickerIngreso.Value.ToLongTimeString());

                ComboxEspecialidad(sender, e);

                try
                {
                    this.medicoDelForm = new Medico(this.textBoxApellido.Text, Convert.ToInt32(this.textBoxLegajo.Text), fechaForm, variable);
                    base.ButtonAceptar(sender, e);
                }
                catch(FormatException)
                {
                    MessageBox.Show("El legajo solo puede tener numeros");
                }
            }
        }

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
        #endregion
    }
}
