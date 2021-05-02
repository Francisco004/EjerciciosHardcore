
namespace LavaderoForm
{
    partial class FormMoto
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
            this.MarcaMotos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RuedasMoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CilindradaMoto = new System.Windows.Forms.TextBox();
            this.PatenteMoto = new System.Windows.Forms.TextBox();
            this.AgregarMoto = new System.Windows.Forms.Button();
            this.CerrarMoto = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esta ingresando una moto";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.Location = new System.Drawing.Point(102, 58);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(46, 16);
            this.Marca.TabIndex = 2;
            this.Marca.Text = "Marca";
            // 
            // MarcaMotos
            // 
            this.MarcaMotos.FormattingEnabled = true;
            this.MarcaMotos.Items.AddRange(new object[] {
            "Honda",
            "Zanella",
            "HarleyDavidson",
            "Ducati",
            "Aprilia",
            "Yamaha",
            "Kawasaki",
            "Suzuki"});
            this.MarcaMotos.Location = new System.Drawing.Point(63, 83);
            this.MarcaMotos.Name = "MarcaMotos";
            this.MarcaMotos.Size = new System.Drawing.Size(121, 21);
            this.MarcaMotos.TabIndex = 6;
            this.MarcaMotos.Text = "Honda";
            this.MarcaMotos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cilindrada";
            // 
            // RuedasMoto
            // 
            this.RuedasMoto.Location = new System.Drawing.Point(72, 202);
            this.RuedasMoto.Name = "RuedasMoto";
            this.RuedasMoto.Size = new System.Drawing.Size(100, 20);
            this.RuedasMoto.TabIndex = 9;
            this.RuedasMoto.Validating += new System.ComponentModel.CancelEventHandler(this.RuedasMoto_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad de ruedas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Patente";
            // 
            // CilindradaMoto
            // 
            this.CilindradaMoto.Location = new System.Drawing.Point(72, 142);
            this.CilindradaMoto.Name = "CilindradaMoto";
            this.CilindradaMoto.Size = new System.Drawing.Size(100, 20);
            this.CilindradaMoto.TabIndex = 12;
            this.CilindradaMoto.Validating += new System.ComponentModel.CancelEventHandler(this.CilindradaMoto_Validating);
            // 
            // PatenteMoto
            // 
            this.PatenteMoto.Location = new System.Drawing.Point(72, 263);
            this.PatenteMoto.Name = "PatenteMoto";
            this.PatenteMoto.Size = new System.Drawing.Size(100, 20);
            this.PatenteMoto.TabIndex = 13;
            this.PatenteMoto.Validating += new System.ComponentModel.CancelEventHandler(this.PatenteMoto_Validating);
            // 
            // AgregarMoto
            // 
            this.AgregarMoto.Location = new System.Drawing.Point(12, 310);
            this.AgregarMoto.Name = "AgregarMoto";
            this.AgregarMoto.Size = new System.Drawing.Size(100, 28);
            this.AgregarMoto.TabIndex = 14;
            this.AgregarMoto.Text = "Agregar";
            this.AgregarMoto.UseVisualStyleBackColor = true;
            this.AgregarMoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // CerrarMoto
            // 
            this.CerrarMoto.Location = new System.Drawing.Point(142, 310);
            this.CerrarMoto.Name = "CerrarMoto";
            this.CerrarMoto.Size = new System.Drawing.Size(100, 28);
            this.CerrarMoto.TabIndex = 15;
            this.CerrarMoto.Text = "Cerrar";
            this.CerrarMoto.UseVisualStyleBackColor = true;
            this.CerrarMoto.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 350);
            this.Controls.Add(this.CerrarMoto);
            this.Controls.Add(this.AgregarMoto);
            this.Controls.Add(this.PatenteMoto);
            this.Controls.Add(this.CilindradaMoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RuedasMoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MarcaMotos);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMoto";
            this.Text = "FormMoto";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.ComboBox MarcaMotos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RuedasMoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CilindradaMoto;
        private System.Windows.Forms.TextBox PatenteMoto;
        private System.Windows.Forms.Button AgregarMoto;
        private System.Windows.Forms.Button CerrarMoto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}