
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLavadero));
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
            this.Listado = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ListadoPrecios = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListadoVehiculos
            // 
            this.ListadoVehiculos.BackColor = System.Drawing.Color.PaleGreen;
            this.ListadoVehiculos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ListadoVehiculos.FormattingEnabled = true;
            this.ListadoVehiculos.Location = new System.Drawing.Point(5, 35);
            this.ListadoVehiculos.Name = "ListadoVehiculos";
            this.ListadoVehiculos.Size = new System.Drawing.Size(567, 251);
            this.ListadoVehiculos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lavadero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ordenamiento";
            // 
            // OrdenamientoSeleccionado
            // 
            this.OrdenamientoSeleccionado.BackColor = System.Drawing.Color.PaleGreen;
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
            this.AgregarVehiculo.BackColor = System.Drawing.Color.PaleGreen;
            this.AgregarVehiculo.Location = new System.Drawing.Point(265, 357);
            this.AgregarVehiculo.Name = "AgregarVehiculo";
            this.AgregarVehiculo.Size = new System.Drawing.Size(99, 39);
            this.AgregarVehiculo.TabIndex = 4;
            this.AgregarVehiculo.Text = "Agregar";
            this.AgregarVehiculo.UseVisualStyleBackColor = false;
            this.AgregarVehiculo.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EliminarVehiculo
            // 
            this.EliminarVehiculo.Location = new System.Drawing.Point(264, 420);
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
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
            this.VehiculoSeleccionado.Location = new System.Drawing.Point(255, 318);
            this.VehiculoSeleccionado.Name = "VehiculoSeleccionado";
            this.VehiculoSeleccionado.Size = new System.Drawing.Size(121, 21);
            this.VehiculoSeleccionado.TabIndex = 9;
            this.VehiculoSeleccionado.Text = "Auto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 348);
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
            // Listado
            // 
            this.Listado.BackColor = System.Drawing.Color.PaleGreen;
            this.Listado.FormattingEnabled = true;
            this.Listado.Items.AddRange(new object[] {
            "Listado de precios totales",
            "Listado de precios por vehiculo"});
            this.Listado.Location = new System.Drawing.Point(18, 404);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(210, 21);
            this.Listado.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Listar Precios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Listado";
            // 
            // ListadoPrecios
            // 
            this.ListadoPrecios.BackColor = System.Drawing.Color.PaleGreen;
            this.ListadoPrecios.FormattingEnabled = true;
            this.ListadoPrecios.Location = new System.Drawing.Point(384, 384);
            this.ListadoPrecios.Name = "ListadoPrecios";
            this.ListadoPrecios.Size = new System.Drawing.Size(180, 43);
            this.ListadoPrecios.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Facturacion";
            // 
            // FormLavadero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LavaderoForm.Properties.Resources.Screenshot_22;
            this.ClientSize = new System.Drawing.Size(577, 471);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListadoPrecios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Listado);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ComboBox Listado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListadoPrecios;
        private System.Windows.Forms.Label label5;
    }
}

