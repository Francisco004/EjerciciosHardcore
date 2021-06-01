
namespace FrmPrincipal
{
    partial class FrmMedicoEgresado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Jornal = new System.Windows.Forms.Label();
            this.TextBoxJornal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(9, 39);
            this.textBoxApellido.TabStop = false;
            this.textBoxApellido.Enter += new System.EventHandler(this.TextBoxApellido_Enter);
            this.textBoxApellido.Leave += new System.EventHandler(this.TextBoxApellido_Leave);
            // 
            // textBoxLegajo
            // 
            this.textBoxLegajo.TabStop = false;
            // 
            // ComboBoxEspecialidad
            // 
            this.ComboBoxEspecialidad.TabStop = false;
            this.ComboBoxEspecialidad.Enter += new System.EventHandler(this.CombEspecialidad_Enter);
            this.ComboBoxEspecialidad.Leave += new System.EventHandler(this.CombEspecialidad_Leave);
            // 
            // DateTimePickerIngreso
            // 
            this.DateTimePickerIngreso.Location = new System.Drawing.Point(9, 145);
            this.DateTimePickerIngreso.TabStop = false;
            // 
            // Jornal
            // 
            this.Jornal.AutoSize = true;
            this.Jornal.Location = new System.Drawing.Point(9, 232);
            this.Jornal.Name = "Jornal";
            this.Jornal.Size = new System.Drawing.Size(35, 13);
            this.Jornal.TabIndex = 17;
            this.Jornal.Text = "Jornal";
            // 
            // TextBoxJornal
            // 
            this.TextBoxJornal.Location = new System.Drawing.Point(9, 248);
            this.TextBoxJornal.Name = "TextBoxJornal";
            this.TextBoxJornal.Size = new System.Drawing.Size(100, 20);
            this.TextBoxJornal.TabIndex = 18;
            this.TextBoxJornal.TabStop = false;
            this.TextBoxJornal.Enter += new System.EventHandler(this.TXTJornal_Enter);
            this.TextBoxJornal.Leave += new System.EventHandler(this.TXTJornal_Leave);
            // 
            // FrmMedicoEgresado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 363);
            this.Controls.Add(this.TextBoxJornal);
            this.Controls.Add(this.Jornal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FrmMedicoEgresado";
            this.Text = "Egreso de medico";
            this.Controls.SetChildIndex(this.BotonAceptar, 0);
            this.Controls.SetChildIndex(this.BotonCancelar, 0);
            this.Controls.SetChildIndex(this.textBoxApellido, 0);
            this.Controls.SetChildIndex(this.textBoxLegajo, 0);
            this.Controls.SetChildIndex(this.DateTimePickerIngreso, 0);
            this.Controls.SetChildIndex(this.ComboBoxEspecialidad, 0);
            this.Controls.SetChildIndex(this.Jornal, 0);
            this.Controls.SetChildIndex(this.TextBoxJornal, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label Jornal;
        private System.Windows.Forms.TextBox TextBoxJornal;
    }
}