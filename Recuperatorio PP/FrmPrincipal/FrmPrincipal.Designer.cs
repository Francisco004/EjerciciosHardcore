
namespace FrmPrincipal
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.ComboBoxOrdenamientoSelec = new System.Windows.Forms.ComboBox();
            this.egresadoMostrar = new System.Windows.Forms.ListBox();
            this.ButtonBorrar = new System.Windows.Forms.Button();
            this.ButtonModificar = new System.Windows.Forms.Button();
            this.BotonEgresar = new System.Windows.Forms.Button();
            this.BotonIngresar = new System.Windows.Forms.Button();
            this.ingresadoMostrar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ComboBoxOrdenamientoSelec
            // 
            this.ComboBoxOrdenamientoSelec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOrdenamientoSelec.Items.AddRange(new object[] {
            "Legajo ascendente",
            "Legajo descendente",
            "Apellido ascendente",
            "Apellido descendente",
            "Especialidad",
            "Jornal ascendente",
            "Jornal descendente",
            "Egreso ascendente",
            "Egreso descendente"});
            this.ComboBoxOrdenamientoSelec.Location = new System.Drawing.Point(884, 392);
            this.ComboBoxOrdenamientoSelec.Name = "ComboBoxOrdenamientoSelec";
            this.ComboBoxOrdenamientoSelec.Size = new System.Drawing.Size(176, 21);
            this.ComboBoxOrdenamientoSelec.TabIndex = 1;
            this.ComboBoxOrdenamientoSelec.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOrdenamiento);
            // 
            // egresadoMostrar
            // 
            this.egresadoMostrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.egresadoMostrar.FormattingEnabled = true;
            this.egresadoMostrar.Location = new System.Drawing.Point(562, 46);
            this.egresadoMostrar.Name = "egresadoMostrar";
            this.egresadoMostrar.Size = new System.Drawing.Size(648, 312);
            this.egresadoMostrar.TabIndex = 0;
            // 
            // ButtonBorrar
            // 
            this.ButtonBorrar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBorrar.Font = new System.Drawing.Font("SF Fedora", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBorrar.Location = new System.Drawing.Point(155, 370);
            this.ButtonBorrar.Name = "ButtonBorrar";
            this.ButtonBorrar.Size = new System.Drawing.Size(117, 50);
            this.ButtonBorrar.TabIndex = 4;
            this.ButtonBorrar.UseVisualStyleBackColor = false;
            this.ButtonBorrar.Click += new System.EventHandler(this.ButtonBorrar_Click);
            this.ButtonBorrar.MouseEnter += new System.EventHandler(this.ButtonBorrar_MouseEnter);
            this.ButtonBorrar.MouseLeave += new System.EventHandler(this.ButtonBorrar_MouseLeave);
            // 
            // ButtonModificar
            // 
            this.ButtonModificar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonModificar.Font = new System.Drawing.Font("SF Fedora", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonModificar.Location = new System.Drawing.Point(287, 370);
            this.ButtonModificar.Name = "ButtonModificar";
            this.ButtonModificar.Size = new System.Drawing.Size(117, 50);
            this.ButtonModificar.TabIndex = 3;
            this.ButtonModificar.UseVisualStyleBackColor = false;
            this.ButtonModificar.Click += new System.EventHandler(this.ButtonModificar_Click);
            this.ButtonModificar.MouseEnter += new System.EventHandler(this.ButtonModificar_MouseEnter);
            this.ButtonModificar.MouseLeave += new System.EventHandler(this.ButtonModificar_MouseLeave);
            // 
            // BotonEgresar
            // 
            this.BotonEgresar.BackColor = System.Drawing.Color.Transparent;
            this.BotonEgresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEgresar.Font = new System.Drawing.Font("SF Fedora", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEgresar.Location = new System.Drawing.Point(425, 370);
            this.BotonEgresar.Name = "BotonEgresar";
            this.BotonEgresar.Size = new System.Drawing.Size(115, 50);
            this.BotonEgresar.TabIndex = 2;
            this.BotonEgresar.UseVisualStyleBackColor = false;
            this.BotonEgresar.Click += new System.EventHandler(this.ButtonEgresar);
            this.BotonEgresar.MouseEnter += new System.EventHandler(this.BotonEgresar_MouseEnter);
            this.BotonEgresar.MouseLeave += new System.EventHandler(this.BotonEgresar_MouseLeave);
            // 
            // BotonIngresar
            // 
            this.BotonIngresar.BackColor = System.Drawing.Color.Transparent;
            this.BotonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonIngresar.Font = new System.Drawing.Font("SF Fedora", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIngresar.Location = new System.Drawing.Point(22, 370);
            this.BotonIngresar.Name = "BotonIngresar";
            this.BotonIngresar.Size = new System.Drawing.Size(117, 50);
            this.BotonIngresar.TabIndex = 1;
            this.BotonIngresar.UseVisualStyleBackColor = false;
            this.BotonIngresar.Click += new System.EventHandler(this.ButtonIngresar);
            this.BotonIngresar.MouseEnter += new System.EventHandler(this.BotonIngresar_MouseEnter);
            this.BotonIngresar.MouseLeave += new System.EventHandler(this.BotonIngresar_MouseLeave);
            // 
            // ingresadoMostrar
            // 
            this.ingresadoMostrar.BackColor = System.Drawing.Color.White;
            this.ingresadoMostrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ingresadoMostrar.FormattingEnabled = true;
            this.ingresadoMostrar.Location = new System.Drawing.Point(24, 46);
            this.ingresadoMostrar.Name = "ingresadoMostrar";
            this.ingresadoMostrar.Size = new System.Drawing.Size(515, 312);
            this.ingresadoMostrar.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmPrincipal.Properties.Resources.Screenshot;
            this.ClientSize = new System.Drawing.Size(1233, 441);
            this.Controls.Add(this.BotonEgresar);
            this.Controls.Add(this.ComboBoxOrdenamientoSelec);
            this.Controls.Add(this.ButtonModificar);
            this.Controls.Add(this.egresadoMostrar);
            this.Controls.Add(this.BotonIngresar);
            this.Controls.Add(this.ButtonBorrar);
            this.Controls.Add(this.ingresadoMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Medicos Francisco Rocha";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBoxOrdenamientoSelec;
        private System.Windows.Forms.ListBox egresadoMostrar;
        private System.Windows.Forms.Button BotonEgresar;
        private System.Windows.Forms.Button BotonIngresar;
        private System.Windows.Forms.ListBox ingresadoMostrar;
        private System.Windows.Forms.Button ButtonModificar;
        private System.Windows.Forms.Button ButtonBorrar;
    }
}

