namespace EscuelaLaboral2018
{
    partial class FrmConEmp4
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
            this.grbIns = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblPoli2 = new System.Windows.Forms.Label();
            this.grbFecha = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.mskFe4 = new System.Windows.Forms.MaskedTextBox();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnLim = new System.Windows.Forms.Button();
            this.rdbDire = new System.Windows.Forms.RadioButton();
            this.rdCargo = new System.Windows.Forms.RadioButton();
            this.rdbmóvil = new System.Windows.Forms.RadioButton();
            this.rdbID_empleado = new System.Windows.Forms.RadioButton();
            this.rdbNombre_de_Usuario = new System.Windows.Forms.RadioButton();
            this.rdbIden = new System.Windows.Forms.RadioButton();
            this.rdbTipo = new System.Windows.Forms.RadioButton();
            this.rdbContraseña = new System.Windows.Forms.RadioButton();
            this.rdbTeléfono = new System.Windows.Forms.RadioButton();
            this.rdbIden_tipo = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbSexo = new System.Windows.Forms.RadioButton();
            this.grbEmpleado = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.grbIns.SuspendLayout();
            this.grbFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.grbEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbIns
            // 
            this.grbIns.BackColor = System.Drawing.Color.Green;
            this.grbIns.Controls.Add(this.lbl2);
            this.grbIns.Controls.Add(this.lblPoli2);
            this.grbIns.Location = new System.Drawing.Point(12, 19);
            this.grbIns.Name = "grbIns";
            this.grbIns.Size = new System.Drawing.Size(270, 72);
            this.grbIns.TabIndex = 5;
            this.grbIns.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(59, 40);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(169, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Av. Salvador,Estrella Sadhalá #60";
            // 
            // lblPoli2
            // 
            this.lblPoli2.AutoSize = true;
            this.lblPoli2.Location = new System.Drawing.Point(6, 16);
            this.lblPoli2.Name = "lblPoli2";
            this.lblPoli2.Size = new System.Drawing.Size(257, 13);
            this.lblPoli2.TabIndex = 0;
            this.lblPoli2.Text = "Instituto Politécnico Nuestra Señora de las Mercedes";
            // 
            // grbFecha
            // 
            this.grbFecha.BackColor = System.Drawing.Color.Green;
            this.grbFecha.Controls.Add(this.maskedTextBox2);
            this.grbFecha.Controls.Add(this.mskFe4);
            this.grbFecha.Controls.Add(this.lblHora2);
            this.grbFecha.Controls.Add(this.lblFecha2);
            this.grbFecha.Location = new System.Drawing.Point(461, 12);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(139, 79);
            this.grbFecha.TabIndex = 7;
            this.grbFecha.TabStop = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(70, 49);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(45, 20);
            this.maskedTextBox2.TabIndex = 5;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // mskFe4
            // 
            this.mskFe4.Location = new System.Drawing.Point(61, 18);
            this.mskFe4.Mask = "00/00/0000";
            this.mskFe4.Name = "mskFe4";
            this.mskFe4.Size = new System.Drawing.Size(66, 20);
            this.mskFe4.TabIndex = 4;
            this.mskFe4.ValidatingType = typeof(System.DateTime);
            // 
            // lblHora2
            // 
            this.lblHora2.AutoSize = true;
            this.lblHora2.Location = new System.Drawing.Point(25, 52);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(30, 13);
            this.lblHora2.TabIndex = 3;
            this.lblHora2.Text = "Hora";
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(18, 21);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(37, 13);
            this.lblFecha2.TabIndex = 1;
            this.lblFecha2.Text = "Fecha";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.BackColor = System.Drawing.Color.Green;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(254, 107);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(230, 24);
            this.lblCon.TabIndex = 8;
            this.lblCon.Text = "Consulta de empleados";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.Green;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 350);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(714, 66);
            this.dgvConsulta.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(622, 86);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 25);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(550, 140);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(56, 23);
            this.btnBorrar.TabIndex = 36;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(622, 140);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(56, 24);
            this.btnRetornar.TabIndex = 37;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(547, 86);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(56, 24);
            this.btnLim.TabIndex = 38;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
            // 
            // rdbDire
            // 
            this.rdbDire.AutoSize = true;
            this.rdbDire.Location = new System.Drawing.Point(440, 86);
            this.rdbDire.Name = "rdbDire";
            this.rdbDire.Size = new System.Drawing.Size(70, 17);
            this.rdbDire.TabIndex = 39;
            this.rdbDire.TabStop = true;
            this.rdbDire.Text = "Dirección";
            this.rdbDire.UseVisualStyleBackColor = true;
            // 
            // rdCargo
            // 
            this.rdCargo.AutoSize = true;
            this.rdCargo.Location = new System.Drawing.Point(202, 115);
            this.rdCargo.Name = "rdCargo";
            this.rdCargo.Size = new System.Drawing.Size(53, 17);
            this.rdCargo.TabIndex = 40;
            this.rdCargo.TabStop = true;
            this.rdCargo.Text = "Cargo";
            this.rdCargo.UseVisualStyleBackColor = true;
            // 
            // rdbmóvil
            // 
            this.rdbmóvil.AutoSize = true;
            this.rdbmóvil.Location = new System.Drawing.Point(325, 148);
            this.rdbmóvil.Name = "rdbmóvil";
            this.rdbmóvil.Size = new System.Drawing.Size(50, 17);
            this.rdbmóvil.TabIndex = 42;
            this.rdbmóvil.TabStop = true;
            this.rdbmóvil.Text = "Móvil";
            this.rdbmóvil.UseVisualStyleBackColor = true;
            // 
            // rdbID_empleado
            // 
            this.rdbID_empleado.AutoSize = true;
            this.rdbID_empleado.Location = new System.Drawing.Point(31, 115);
            this.rdbID_empleado.Name = "rdbID_empleado";
            this.rdbID_empleado.Size = new System.Drawing.Size(89, 17);
            this.rdbID_empleado.TabIndex = 43;
            this.rdbID_empleado.TabStop = true;
            this.rdbID_empleado.Text = "ID_Empleado";
            this.rdbID_empleado.UseVisualStyleBackColor = true;
            // 
            // rdbNombre_de_Usuario
            // 
            this.rdbNombre_de_Usuario.AutoSize = true;
            this.rdbNombre_de_Usuario.Location = new System.Drawing.Point(31, 74);
            this.rdbNombre_de_Usuario.Name = "rdbNombre_de_Usuario";
            this.rdbNombre_de_Usuario.Size = new System.Drawing.Size(120, 17);
            this.rdbNombre_de_Usuario.TabIndex = 44;
            this.rdbNombre_de_Usuario.TabStop = true;
            this.rdbNombre_de_Usuario.Text = "Nombre_de_usuario";
            this.rdbNombre_de_Usuario.UseVisualStyleBackColor = true;
            // 
            // rdbIden
            // 
            this.rdbIden.AutoSize = true;
            this.rdbIden.Location = new System.Drawing.Point(317, 74);
            this.rdbIden.Name = "rdbIden";
            this.rdbIden.Size = new System.Drawing.Size(88, 17);
            this.rdbIden.TabIndex = 45;
            this.rdbIden.TabStop = true;
            this.rdbIden.Text = "Identificación";
            this.rdbIden.UseVisualStyleBackColor = true;
            // 
            // rdbTipo
            // 
            this.rdbTipo.AutoSize = true;
            this.rdbTipo.Location = new System.Drawing.Point(440, 148);
            this.rdbTipo.Name = "rdbTipo";
            this.rdbTipo.Size = new System.Drawing.Size(104, 17);
            this.rdbTipo.TabIndex = 46;
            this.rdbTipo.TabStop = true;
            this.rdbTipo.Text = "Tipo_de_usuario";
            this.rdbTipo.UseVisualStyleBackColor = true;
            // 
            // rdbContraseña
            // 
            this.rdbContraseña.AutoSize = true;
            this.rdbContraseña.Location = new System.Drawing.Point(202, 148);
            this.rdbContraseña.Name = "rdbContraseña";
            this.rdbContraseña.Size = new System.Drawing.Size(79, 17);
            this.rdbContraseña.TabIndex = 47;
            this.rdbContraseña.TabStop = true;
            this.rdbContraseña.Text = "Contraseña";
            this.rdbContraseña.UseVisualStyleBackColor = true;
            // 
            // rdbTeléfono
            // 
            this.rdbTeléfono.AutoSize = true;
            this.rdbTeléfono.Location = new System.Drawing.Point(325, 115);
            this.rdbTeléfono.Name = "rdbTeléfono";
            this.rdbTeléfono.Size = new System.Drawing.Size(67, 17);
            this.rdbTeléfono.TabIndex = 48;
            this.rdbTeléfono.TabStop = true;
            this.rdbTeléfono.Text = "Teléfono";
            this.rdbTeléfono.UseVisualStyleBackColor = true;
            // 
            // rdbIden_tipo
            // 
            this.rdbIden_tipo.AutoSize = true;
            this.rdbIden_tipo.Location = new System.Drawing.Point(31, 148);
            this.rdbIden_tipo.Name = "rdbIden_tipo";
            this.rdbIden_tipo.Size = new System.Drawing.Size(111, 17);
            this.rdbIden_tipo.TabIndex = 49;
            this.rdbIden_tipo.TabStop = true;
            this.rdbIden_tipo.Text = "Identificación_tipo";
            this.rdbIden_tipo.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(199, 74);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(62, 17);
            this.rdbNombre.TabIndex = 50;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // rdbSexo
            // 
            this.rdbSexo.AutoSize = true;
            this.rdbSexo.Location = new System.Drawing.Point(440, 115);
            this.rdbSexo.Name = "rdbSexo";
            this.rdbSexo.Size = new System.Drawing.Size(49, 17);
            this.rdbSexo.TabIndex = 51;
            this.rdbSexo.TabStop = true;
            this.rdbSexo.Text = "Sexo";
            this.rdbSexo.UseVisualStyleBackColor = true;
            // 
            // grbEmpleado
            // 
            this.grbEmpleado.BackColor = System.Drawing.Color.Green;
            this.grbEmpleado.Controls.Add(this.txtBusqueda);
            this.grbEmpleado.Controls.Add(this.lblCriterio);
            this.grbEmpleado.Controls.Add(this.rdbSexo);
            this.grbEmpleado.Controls.Add(this.rdbNombre);
            this.grbEmpleado.Controls.Add(this.rdbIden_tipo);
            this.grbEmpleado.Controls.Add(this.rdbTeléfono);
            this.grbEmpleado.Controls.Add(this.rdbContraseña);
            this.grbEmpleado.Controls.Add(this.rdbTipo);
            this.grbEmpleado.Controls.Add(this.rdbIden);
            this.grbEmpleado.Controls.Add(this.rdbNombre_de_Usuario);
            this.grbEmpleado.Controls.Add(this.rdbID_empleado);
            this.grbEmpleado.Controls.Add(this.rdbmóvil);
            this.grbEmpleado.Controls.Add(this.rdCargo);
            this.grbEmpleado.Controls.Add(this.rdbDire);
            this.grbEmpleado.Controls.Add(this.btnLim);
            this.grbEmpleado.Controls.Add(this.btnRetornar);
            this.grbEmpleado.Controls.Add(this.btnBorrar);
            this.grbEmpleado.Controls.Add(this.btnGuardar);
            this.grbEmpleado.Location = new System.Drawing.Point(21, 143);
            this.grbEmpleado.Name = "grbEmpleado";
            this.grbEmpleado.Size = new System.Drawing.Size(695, 189);
            this.grbEmpleado.TabIndex = 10;
            this.grbEmpleado.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(354, 31);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 53;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(199, 38);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(133, 13);
            this.lblCriterio.TabIndex = 52;
            this.lblCriterio.Text = "Digite criterio de busqueda";
            // 
            // FrmConEmp4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(736, 428);
            this.ControlBox = false;
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.grbEmpleado);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.grbIns);
            this.Name = "FrmConEmp4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConEmp4";
            this.Load += new System.EventHandler(this.FrmConEmp4_Load);
            this.grbIns.ResumeLayout(false);
            this.grbIns.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.grbEmpleado.ResumeLayout(false);
            this.grbEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbIns;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblPoli2;
        private System.Windows.Forms.GroupBox grbFecha;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox mskFe4;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.RadioButton rdbDire;
        private System.Windows.Forms.RadioButton rdCargo;
        private System.Windows.Forms.RadioButton rdbmóvil;
        private System.Windows.Forms.RadioButton rdbID_empleado;
        private System.Windows.Forms.RadioButton rdbNombre_de_Usuario;
        private System.Windows.Forms.RadioButton rdbIden;
        private System.Windows.Forms.RadioButton rdbTipo;
        private System.Windows.Forms.RadioButton rdbContraseña;
        private System.Windows.Forms.RadioButton rdbTeléfono;
        private System.Windows.Forms.RadioButton rdbIden_tipo;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbSexo;
        private System.Windows.Forms.GroupBox grbEmpleado;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblCriterio;
    }
}