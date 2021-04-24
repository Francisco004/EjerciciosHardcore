
namespace LavaderoForm
{
    partial class FormCamion
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
            this.MarcaCamion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TaraCamion = new System.Windows.Forms.TextBox();
            this.CantidadDeRuedas = new System.Windows.Forms.Label();
            this.RuedasCamion = new System.Windows.Forms.TextBox();
            this.Patentee = new System.Windows.Forms.Label();
            this.PatenteCamion = new System.Windows.Forms.TextBox();
            this.CerrarCamion = new System.Windows.Forms.Button();
            this.AgregarCamion = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Esta ingresando una camion";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.Location = new System.Drawing.Point(102, 58);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(46, 16);
            this.Marca.TabIndex = 3;
            this.Marca.Text = "Marca";
            // 
            // MarcaCamion
            // 
            this.MarcaCamion.FormattingEnabled = true;
            this.MarcaCamion.Items.AddRange(new object[] {
            "Scania",
            "Iveco",
            "RenaultTrucks",
            "Volvo",
            "Man",
            "Daf",
            "Mitsubishi",
            "Nissan",
            "Isuzu",
            "Mercedesbenz"});
            this.MarcaCamion.Location = new System.Drawing.Point(63, 83);
            this.MarcaCamion.Name = "MarcaCamion";
            this.MarcaCamion.Size = new System.Drawing.Size(121, 21);
            this.MarcaCamion.TabIndex = 7;
            this.MarcaCamion.Text = "Scania";
            this.MarcaCamion.SelectedIndexChanged += new System.EventHandler(this.Marcass_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tara";
            // 
            // TaraCamion
            // 
            this.TaraCamion.Location = new System.Drawing.Point(72, 142);
            this.TaraCamion.Name = "TaraCamion";
            this.TaraCamion.Size = new System.Drawing.Size(100, 20);
            this.TaraCamion.TabIndex = 13;
            this.TaraCamion.Validating += new System.ComponentModel.CancelEventHandler(this.TaraCamion_Validating);
            // 
            // CantidadDeRuedas
            // 
            this.CantidadDeRuedas.AutoSize = true;
            this.CantidadDeRuedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadDeRuedas.Location = new System.Drawing.Point(58, 174);
            this.CantidadDeRuedas.Name = "CantidadDeRuedas";
            this.CantidadDeRuedas.Size = new System.Drawing.Size(126, 16);
            this.CantidadDeRuedas.TabIndex = 14;
            this.CantidadDeRuedas.Text = "Cantidad de ruedas";
            // 
            // RuedasCamion
            // 
            this.RuedasCamion.Location = new System.Drawing.Point(72, 202);
            this.RuedasCamion.Name = "RuedasCamion";
            this.RuedasCamion.Size = new System.Drawing.Size(100, 20);
            this.RuedasCamion.TabIndex = 15;
            this.RuedasCamion.Validating += new System.ComponentModel.CancelEventHandler(this.RuedasCamion_Validating);
            // 
            // Patentee
            // 
            this.Patentee.AutoSize = true;
            this.Patentee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patentee.Location = new System.Drawing.Point(94, 235);
            this.Patentee.Name = "Patentee";
            this.Patentee.Size = new System.Drawing.Size(54, 16);
            this.Patentee.TabIndex = 16;
            this.Patentee.Text = "Patente";
            // 
            // PatenteCamion
            // 
            this.PatenteCamion.Location = new System.Drawing.Point(72, 263);
            this.PatenteCamion.Name = "PatenteCamion";
            this.PatenteCamion.Size = new System.Drawing.Size(100, 20);
            this.PatenteCamion.TabIndex = 17;
            this.PatenteCamion.Validating += new System.ComponentModel.CancelEventHandler(this.PatenteCamion_Validating);
            // 
            // CerrarCamion
            // 
            this.CerrarCamion.Location = new System.Drawing.Point(142, 310);
            this.CerrarCamion.Name = "CerrarCamion";
            this.CerrarCamion.Size = new System.Drawing.Size(100, 28);
            this.CerrarCamion.TabIndex = 18;
            this.CerrarCamion.Text = "Cerrar";
            this.CerrarCamion.UseVisualStyleBackColor = true;
            this.CerrarCamion.Click += new System.EventHandler(this.button2_Click);
            // 
            // AgregarCamion
            // 
            this.AgregarCamion.Location = new System.Drawing.Point(12, 310);
            this.AgregarCamion.Name = "AgregarCamion";
            this.AgregarCamion.Size = new System.Drawing.Size(100, 28);
            this.AgregarCamion.TabIndex = 19;
            this.AgregarCamion.Text = "Agregar";
            this.AgregarCamion.UseVisualStyleBackColor = true;
            this.AgregarCamion.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LavaderoForm.Properties.Resources.Screenshot_6;
            this.ClientSize = new System.Drawing.Size(254, 350);
            this.Controls.Add(this.AgregarCamion);
            this.Controls.Add(this.CerrarCamion);
            this.Controls.Add(this.PatenteCamion);
            this.Controls.Add(this.Patentee);
            this.Controls.Add(this.RuedasCamion);
            this.Controls.Add(this.CantidadDeRuedas);
            this.Controls.Add(this.TaraCamion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MarcaCamion);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.label1);
            this.Name = "FormCamion";
            this.Text = "FormCamion";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.ComboBox MarcaCamion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TaraCamion;
        private System.Windows.Forms.Label CantidadDeRuedas;
        private System.Windows.Forms.TextBox RuedasCamion;
        private System.Windows.Forms.Label Patentee;
        private System.Windows.Forms.TextBox PatenteCamion;
        private System.Windows.Forms.Button CerrarCamion;
        private System.Windows.Forms.Button AgregarCamion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}