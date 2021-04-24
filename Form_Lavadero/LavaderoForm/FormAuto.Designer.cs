
namespace LavaderoForm
{
    partial class FormAuto
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.Asientos = new System.Windows.Forms.Label();
            this.CantRuedas = new System.Windows.Forms.Label();
            this.Patente = new System.Windows.Forms.Label();
            this.MarcaAuto = new System.Windows.Forms.ComboBox();
            this.PatenteAutos = new System.Windows.Forms.TextBox();
            this.RuedasAutos = new System.Windows.Forms.TextBox();
            this.AsientoAuto = new System.Windows.Forms.TextBox();
            this.AgregarAuto = new System.Windows.Forms.Button();
            this.CerrarAuto = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Esta ingresando un auto";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.Location = new System.Drawing.Point(102, 58);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(46, 16);
            this.Marca.TabIndex = 1;
            this.Marca.Text = "Marca";
            // 
            // Asientos
            // 
            this.Asientos.AutoSize = true;
            this.Asientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asientos.Location = new System.Drawing.Point(94, 115);
            this.Asientos.Name = "Asientos";
            this.Asientos.Size = new System.Drawing.Size(60, 16);
            this.Asientos.TabIndex = 2;
            this.Asientos.Text = "Asientos";
            // 
            // CantRuedas
            // 
            this.CantRuedas.AutoSize = true;
            this.CantRuedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantRuedas.Location = new System.Drawing.Point(58, 174);
            this.CantRuedas.Name = "CantRuedas";
            this.CantRuedas.Size = new System.Drawing.Size(126, 16);
            this.CantRuedas.TabIndex = 3;
            this.CantRuedas.Text = "Cantidad de ruedas";
            // 
            // Patente
            // 
            this.Patente.AutoSize = true;
            this.Patente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patente.Location = new System.Drawing.Point(94, 235);
            this.Patente.Name = "Patente";
            this.Patente.Size = new System.Drawing.Size(54, 16);
            this.Patente.TabIndex = 4;
            this.Patente.Text = "Patente";
            // 
            // MarcaAuto
            // 
            this.MarcaAuto.FormattingEnabled = true;
            this.MarcaAuto.Items.AddRange(new object[] {
            "Ford",
            "Fiat"});
            this.MarcaAuto.Location = new System.Drawing.Point(63, 83);
            this.MarcaAuto.Name = "MarcaAuto";
            this.MarcaAuto.Size = new System.Drawing.Size(121, 21);
            this.MarcaAuto.TabIndex = 5;
            this.MarcaAuto.Text = "Ford";
            this.MarcaAuto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PatenteAutos
            // 
            this.PatenteAutos.Location = new System.Drawing.Point(72, 263);
            this.PatenteAutos.Name = "PatenteAutos";
            this.PatenteAutos.Size = new System.Drawing.Size(100, 20);
            this.PatenteAutos.TabIndex = 6;
            this.PatenteAutos.Validating += new System.ComponentModel.CancelEventHandler(this.PatenteAutos_Validating);
            // 
            // RuedasAutos
            // 
            this.RuedasAutos.Location = new System.Drawing.Point(72, 202);
            this.RuedasAutos.Name = "RuedasAutos";
            this.RuedasAutos.Size = new System.Drawing.Size(100, 20);
            this.RuedasAutos.TabIndex = 7;
            this.RuedasAutos.Validating += new System.ComponentModel.CancelEventHandler(this.RuedasAutos_Validating);
            // 
            // AsientoAuto
            // 
            this.AsientoAuto.Location = new System.Drawing.Point(72, 142);
            this.AsientoAuto.Name = "AsientoAuto";
            this.AsientoAuto.Size = new System.Drawing.Size(100, 20);
            this.AsientoAuto.TabIndex = 8;
            this.AsientoAuto.Validating += new System.ComponentModel.CancelEventHandler(this.AsientoAuto_Validating);
            // 
            // AgregarAuto
            // 
            this.AgregarAuto.Location = new System.Drawing.Point(12, 310);
            this.AgregarAuto.Name = "AgregarAuto";
            this.AgregarAuto.Size = new System.Drawing.Size(100, 28);
            this.AgregarAuto.TabIndex = 9;
            this.AgregarAuto.Text = "Agregar";
            this.AgregarAuto.UseVisualStyleBackColor = true;
            this.AgregarAuto.Click += new System.EventHandler(this.button1_Click);
            // 
            // CerrarAuto
            // 
            this.CerrarAuto.Location = new System.Drawing.Point(142, 310);
            this.CerrarAuto.Name = "CerrarAuto";
            this.CerrarAuto.Size = new System.Drawing.Size(100, 28);
            this.CerrarAuto.TabIndex = 10;
            this.CerrarAuto.Text = "Cerrar";
            this.CerrarAuto.UseVisualStyleBackColor = true;
            this.CerrarAuto.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 350);
            this.Controls.Add(this.CerrarAuto);
            this.Controls.Add(this.AgregarAuto);
            this.Controls.Add(this.AsientoAuto);
            this.Controls.Add(this.RuedasAutos);
            this.Controls.Add(this.PatenteAutos);
            this.Controls.Add(this.MarcaAuto);
            this.Controls.Add(this.Patente);
            this.Controls.Add(this.CantRuedas);
            this.Controls.Add(this.Asientos);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.label1);
            this.Name = "FormAuto";
            this.Text = "FormAuto";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label Asientos;
        private System.Windows.Forms.Label CantRuedas;
        private System.Windows.Forms.Label Patente;
        private System.Windows.Forms.ComboBox MarcaAuto;
        private System.Windows.Forms.TextBox PatenteAutos;
        private System.Windows.Forms.TextBox AsientoAuto;
        private System.Windows.Forms.TextBox RuedasAutos;
        private System.Windows.Forms.Button AgregarAuto;
        private System.Windows.Forms.Button CerrarAuto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}