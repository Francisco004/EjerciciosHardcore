
namespace LavaderoForm
{
    partial class FormLavadero
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListadoVehiculos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrdenamientoSeleccionado = new System.Windows.Forms.ComboBox();
            this.AgregarVehiculo = new System.Windows.Forms.Button();
            this.EliminarVehiculo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.VehiculoSeleccionado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ConfirmacionOrdena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListadoVehiculos
            // 
            this.ListadoVehiculos.FormattingEnabled = true;
            this.ListadoVehiculos.Location = new System.Drawing.Point(17, 35);
            this.ListadoVehiculos.Name = "ListadoVehiculos";
            this.ListadoVehiculos.Size = new System.Drawing.Size(607, 264);
            this.ListadoVehiculos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lavadero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ordenamiento";
            // 
            // OrdenamientoSeleccionado
            // 
            this.OrdenamientoSeleccionado.FormattingEnabled = true;
            this.OrdenamientoSeleccionado.Items.AddRange(new object[] {
            "Ordenar por marca",
            "Ordenar por patente"});
            this.OrdenamientoSeleccionado.Location = new System.Drawing.Point(17, 318);
            this.OrdenamientoSeleccionado.Name = "OrdenamientoSeleccionado";
            this.OrdenamientoSeleccionado.Size = new System.Drawing.Size(210, 21);
            this.OrdenamientoSeleccionado.TabIndex = 3;
            // 
            // AgregarVehiculo
            // 
            this.AgregarVehiculo.Location = new System.Drawing.Point(420, 328);
            this.AgregarVehiculo.Name = "AgregarVehiculo";
            this.AgregarVehiculo.Size = new System.Drawing.Size(99, 39);
            this.AgregarVehiculo.TabIndex = 4;
            this.AgregarVehiculo.Text = "Agregar";
            this.AgregarVehiculo.UseVisualStyleBackColor = true;
            this.AgregarVehiculo.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EliminarVehiculo
            // 
            this.EliminarVehiculo.Location = new System.Drawing.Point(525, 328);
            this.EliminarVehiculo.Name = "EliminarVehiculo";
            this.EliminarVehiculo.Size = new System.Drawing.Size(99, 39);
            this.EliminarVehiculo.TabIndex = 5;
            this.EliminarVehiculo.Text = "Eliminar";
            this.EliminarVehiculo.UseVisualStyleBackColor = true;
            this.EliminarVehiculo.Click += new System.EventHandler(this.EliminarVehiculo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de vehiculo ";
            // 
            // VehiculoSeleccionado
            // 
            this.VehiculoSeleccionado.FormattingEnabled = true;
            this.VehiculoSeleccionado.Items.AddRange(new object[] {
            "Auto",
            "Moto",
            "Camion"});
            this.VehiculoSeleccionado.Location = new System.Drawing.Point(269, 324);
            this.VehiculoSeleccionado.Name = "VehiculoSeleccionado";
            this.VehiculoSeleccionado.Size = new System.Drawing.Size(121, 21);
            this.VehiculoSeleccionado.TabIndex = 9;
            this.VehiculoSeleccionado.Text = "Auto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Listar ordenamiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // ConfirmacionOrdena
            // 
            this.ConfirmacionOrdena.AutoSize = true;
            this.ConfirmacionOrdena.Location = new System.Drawing.Point(182, 357);
            this.ConfirmacionOrdena.Name = "ConfirmacionOrdena";
            this.ConfirmacionOrdena.Size = new System.Drawing.Size(0, 13);
            this.ConfirmacionOrdena.TabIndex = 11;
            // 
            // FormLavadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 387);
            this.Controls.Add(this.ConfirmacionOrdena);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VehiculoSeleccionado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EliminarVehiculo);
            this.Controls.Add(this.AgregarVehiculo);
            this.Controls.Add(this.OrdenamientoSeleccionado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListadoVehiculos);
            this.Name = "FormLavadero";
            this.Text = "Lavadero Francisco Rocha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListadoVehiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox OrdenamientoSeleccionado;
        private System.Windows.Forms.Button AgregarVehiculo;
        private System.Windows.Forms.Button EliminarVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox VehiculoSeleccionado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ConfirmacionOrdena;
    }
}

