namespace EscuelaLaboral2018
{
    partial class FrmManEstu2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblpoli = new System.Windows.Forms.Label();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.lblav = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblFe = new System.Windows.Forms.Label();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.mskHo2 = new System.Windows.Forms.MaskedTextBox();
            this.mskFe2 = new System.Windows.Forms.MaskedTextBox();
            this.lblNa = new System.Windows.Forms.Label();
            this.dgvEstu = new System.Windows.Forms.DataGridView();
            this.lblDire = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblIdEs = new System.Windows.Forms.Label();
            this.lblfechadenacimiento = new System.Windows.Forms.Label();
            this.lblidentificacion = new System.Windows.Forms.Label();
            this.lblnacimiento = new System.Windows.Forms.Label();
            this.lblMóvil = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.lblNivelacadémico = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtNacimiento = new System.Windows.Forms.TextBox();
            this.txtdirección = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtidentificación = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtestudiante = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnLim = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskMO = new System.Windows.Forms.MaskedTextBox();
            this.dtpNan = new System.Windows.Forms.DateTimePicker();
            this.grbEst = new System.Windows.Forms.GroupBox();
            this.chkAct = new System.Windows.Forms.CheckBox();
            this.txtAct = new System.Windows.Forms.TextBox();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.grbEst.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblpoli
            // 
            this.lblpoli.AutoSize = true;
            this.lblpoli.Location = new System.Drawing.Point(5, 14);
            this.lblpoli.Name = "lblpoli";
            this.lblpoli.Size = new System.Drawing.Size(257, 13);
            this.lblpoli.TabIndex = 0;
            this.lblpoli.Text = "Instituto Politécnico Nuestra Señora de las Mercedes";
            // 
            // grb1
            // 
            this.grb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grb1.Controls.Add(this.lblav);
            this.grb1.Controls.Add(this.lblpoli);
            this.grb1.Location = new System.Drawing.Point(30, 12);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(271, 65);
            this.grb1.TabIndex = 1;
            this.grb1.TabStop = false;
            // 
            // lblav
            // 
            this.lblav.AutoSize = true;
            this.lblav.Location = new System.Drawing.Point(27, 41);
            this.lblav.Name = "lblav";
            this.lblav.Size = new System.Drawing.Size(169, 13);
            this.lblav.TabIndex = 11;
            this.lblav.Text = "Av. Salvador,Estrella Sadhalá #60";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(6, 42);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(30, 13);
            this.lblhora.TabIndex = 6;
            this.lblhora.Text = "Hora";
            // 
            // lblFe
            // 
            this.lblFe.AutoSize = true;
            this.lblFe.Location = new System.Drawing.Point(6, 16);
            this.lblFe.Name = "lblFe";
            this.lblFe.Size = new System.Drawing.Size(37, 13);
            this.lblFe.TabIndex = 7;
            this.lblFe.Text = "Fecha";
            // 
            // grb2
            // 
            this.grb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grb2.Controls.Add(this.mskHo2);
            this.grb2.Controls.Add(this.mskFe2);
            this.grb2.Controls.Add(this.lblFe);
            this.grb2.Controls.Add(this.lblhora);
            this.grb2.Location = new System.Drawing.Point(646, 12);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(143, 65);
            this.grb2.TabIndex = 8;
            this.grb2.TabStop = false;
            // 
            // mskHo2
            // 
            this.mskHo2.Location = new System.Drawing.Point(54, 39);
            this.mskHo2.Mask = "00:00";
            this.mskHo2.Name = "mskHo2";
            this.mskHo2.Size = new System.Drawing.Size(41, 20);
            this.mskHo2.TabIndex = 9;
            this.mskHo2.ValidatingType = typeof(System.DateTime);
            // 
            // mskFe2
            // 
            this.mskFe2.Location = new System.Drawing.Point(54, 13);
            this.mskFe2.Mask = "00/00/0000";
            this.mskFe2.Name = "mskFe2";
            this.mskFe2.Size = new System.Drawing.Size(63, 20);
            this.mskFe2.TabIndex = 8;
            this.mskFe2.ValidatingType = typeof(System.DateTime);
            // 
            // lblNa
            // 
            this.lblNa.AutoSize = true;
            this.lblNa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNa.Location = new System.Drawing.Point(323, 102);
            this.lblNa.Name = "lblNa";
            this.lblNa.Size = new System.Drawing.Size(261, 24);
            this.lblNa.TabIndex = 7;
            this.lblNa.Text = "Mantenimiento Estudiantes";
            // 
            // dgvEstu
            // 
            this.dgvEstu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEstu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstu.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEstu.Location = new System.Drawing.Point(30, 432);
            this.dgvEstu.Name = "dgvEstu";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEstu.Size = new System.Drawing.Size(792, 120);
            this.dgvEstu.TabIndex = 10;
            this.dgvEstu.Click += new System.EventHandler(this.dgvEstu_Click);
            // 
            // lblDire
            // 
            this.lblDire.AutoSize = true;
            this.lblDire.Location = new System.Drawing.Point(27, 173);
            this.lblDire.Name = "lblDire";
            this.lblDire.Size = new System.Drawing.Size(52, 13);
            this.lblDire.TabIndex = 5;
            this.lblDire.Text = "Dirección";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(27, 142);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(27, 70);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nombre";
            // 
            // lblIdEs
            // 
            this.lblIdEs.AutoSize = true;
            this.lblIdEs.Location = new System.Drawing.Point(6, 40);
            this.lblIdEs.Name = "lblIdEs";
            this.lblIdEs.Size = new System.Drawing.Size(71, 13);
            this.lblIdEs.TabIndex = 2;
            this.lblIdEs.Text = "ID Estudiante";
            // 
            // lblfechadenacimiento
            // 
            this.lblfechadenacimiento.AutoSize = true;
            this.lblfechadenacimiento.Location = new System.Drawing.Point(212, 37);
            this.lblfechadenacimiento.Name = "lblfechadenacimiento";
            this.lblfechadenacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblfechadenacimiento.TabIndex = 6;
            this.lblfechadenacimiento.Text = "Fecha de nacimiento";
            // 
            // lblidentificacion
            // 
            this.lblidentificacion.AutoSize = true;
            this.lblidentificacion.Location = new System.Drawing.Point(6, 106);
            this.lblidentificacion.Name = "lblidentificacion";
            this.lblidentificacion.Size = new System.Drawing.Size(90, 13);
            this.lblidentificacion.TabIndex = 7;
            this.lblidentificacion.Text = "Identificación tipo";
            // 
            // lblnacimiento
            // 
            this.lblnacimiento.AutoSize = true;
            this.lblnacimiento.Location = new System.Drawing.Point(457, 36);
            this.lblnacimiento.Name = "lblnacimiento";
            this.lblnacimiento.Size = new System.Drawing.Size(77, 13);
            this.lblnacimiento.TabIndex = 8;
            this.lblnacimiento.Text = "ID Nacimiento ";
            // 
            // lblMóvil
            // 
            this.lblMóvil.AutoSize = true;
            this.lblMóvil.Location = new System.Drawing.Point(251, 125);
            this.lblMóvil.Name = "lblMóvil";
            this.lblMóvil.Size = new System.Drawing.Size(32, 13);
            this.lblMóvil.TabIndex = 10;
            this.lblMóvil.Text = "Móvil";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(245, 80);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "Teléfono";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(255, 173);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(28, 13);
            this.lblFoto.TabIndex = 12;
            this.lblFoto.Text = "Foto";
            // 
            // lblNivelacadémico
            // 
            this.lblNivelacadémico.AutoSize = true;
            this.lblNivelacadémico.Location = new System.Drawing.Point(457, 118);
            this.lblNivelacadémico.Name = "lblNivelacadémico";
            this.lblNivelacadémico.Size = new System.Drawing.Size(87, 13);
            this.lblNivelacadémico.TabIndex = 15;
            this.lblNivelacadémico.Text = "Nivel Académico";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(572, 115);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(82, 20);
            this.txtNivel.TabIndex = 22;
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.Location = new System.Drawing.Point(572, 37);
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(82, 20);
            this.txtNacimiento.TabIndex = 24;
            // 
            // txtdirección
            // 
            this.txtdirección.Location = new System.Drawing.Point(108, 170);
            this.txtdirección.Name = "txtdirección";
            this.txtdirección.Size = new System.Drawing.Size(82, 20);
            this.txtdirección.TabIndex = 27;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(108, 135);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(82, 20);
            this.txtSexo.TabIndex = 28;
            // 
            // txtidentificación
            // 
            this.txtidentificación.Location = new System.Drawing.Point(108, 102);
            this.txtidentificación.Name = "txtidentificación";
            this.txtidentificación.Size = new System.Drawing.Size(82, 20);
            this.txtidentificación.TabIndex = 29;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(82, 20);
            this.txtNombre.TabIndex = 30;
            // 
            // txtestudiante
            // 
            this.txtestudiante.Location = new System.Drawing.Point(108, 33);
            this.txtestudiante.Name = "txtestudiante";
            this.txtestudiante.Size = new System.Drawing.Size(82, 20);
            this.txtestudiante.TabIndex = 31;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(672, 34);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 25);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(672, 210);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(70, 24);
            this.btnRetornar.TabIndex = 33;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(672, 100);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(70, 24);
            this.btnLim.TabIndex = 34;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(672, 151);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(70, 25);
            this.btnBorrar.TabIndex = 35;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(315, 170);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(101, 64);
            this.pb1.TabIndex = 38;
            this.pb1.TabStop = false;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(324, 73);
            this.mskTel.Mask = "(999)000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(100, 20);
            this.mskTel.TabIndex = 39;
            // 
            // mskMO
            // 
            this.mskMO.Location = new System.Drawing.Point(315, 125);
            this.mskMO.Mask = "000-000-0000";
            this.mskMO.Name = "mskMO";
            this.mskMO.Size = new System.Drawing.Size(100, 20);
            this.mskMO.TabIndex = 41;
            // 
            // dtpNan
            // 
            this.dtpNan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNan.Location = new System.Drawing.Point(324, 31);
            this.dtpNan.Name = "dtpNan";
            this.dtpNan.Size = new System.Drawing.Size(100, 20);
            this.dtpNan.TabIndex = 42;
            // 
            // grbEst
            // 
            this.grbEst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grbEst.Controls.Add(this.chkAct);
            this.grbEst.Controls.Add(this.txtAct);
            this.grbEst.Controls.Add(this.dtpNan);
            this.grbEst.Controls.Add(this.mskMO);
            this.grbEst.Controls.Add(this.mskTel);
            this.grbEst.Controls.Add(this.pb1);
            this.grbEst.Controls.Add(this.btnBorrar);
            this.grbEst.Controls.Add(this.btnLim);
            this.grbEst.Controls.Add(this.btnRetornar);
            this.grbEst.Controls.Add(this.btnGuardar);
            this.grbEst.Controls.Add(this.txtestudiante);
            this.grbEst.Controls.Add(this.txtNombre);
            this.grbEst.Controls.Add(this.txtidentificación);
            this.grbEst.Controls.Add(this.txtSexo);
            this.grbEst.Controls.Add(this.txtdirección);
            this.grbEst.Controls.Add(this.txtNacimiento);
            this.grbEst.Controls.Add(this.txtNivel);
            this.grbEst.Controls.Add(this.lblNivelacadémico);
            this.grbEst.Controls.Add(this.lblFoto);
            this.grbEst.Controls.Add(this.lblTel);
            this.grbEst.Controls.Add(this.lblMóvil);
            this.grbEst.Controls.Add(this.lblnacimiento);
            this.grbEst.Controls.Add(this.lblidentificacion);
            this.grbEst.Controls.Add(this.lblfechadenacimiento);
            this.grbEst.Controls.Add(this.lblIdEs);
            this.grbEst.Controls.Add(this.lblNom);
            this.grbEst.Controls.Add(this.lblSexo);
            this.grbEst.Controls.Add(this.lblDire);
            this.grbEst.Location = new System.Drawing.Point(69, 155);
            this.grbEst.Name = "grbEst";
            this.grbEst.Size = new System.Drawing.Size(748, 252);
            this.grbEst.TabIndex = 9;
            this.grbEst.TabStop = false;
            this.grbEst.Enter += new System.EventHandler(this.grbEst_Enter);
            // 
            // chkAct
            // 
            this.chkAct.AutoSize = true;
            this.chkAct.Location = new System.Drawing.Point(459, 76);
            this.chkAct.Name = "chkAct";
            this.chkAct.Size = new System.Drawing.Size(56, 17);
            this.chkAct.TabIndex = 44;
            this.chkAct.Text = "Activo";
            this.chkAct.UseVisualStyleBackColor = true;
            // 
            // txtAct
            // 
            this.txtAct.Location = new System.Drawing.Point(572, 73);
            this.txtAct.Name = "txtAct";
            this.txtAct.Size = new System.Drawing.Size(82, 20);
            this.txtAct.TabIndex = 43;
            this.txtAct.Visible = false;
            this.txtAct.TextChanged += new System.EventHandler(this.txtAct_TextChanged);
            // 
            // FrmManEstu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(829, 564);
            this.ControlBox = false;
            this.Controls.Add(this.dgvEstu);
            this.Controls.Add(this.lblNa);
            this.Controls.Add(this.grbEst);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Name = "FrmManEstu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManEstu2.cs";
            this.Activated += new System.EventHandler(this.FrmManEstu2_Activated);
            this.Load += new System.EventHandler(this.FrmManEstu2_Load);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grb2.ResumeLayout(false);
            this.grb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.grbEst.ResumeLayout(false);
            this.grbEst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpoli;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblFe;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.Label lblNa;
        private System.Windows.Forms.Label lblav;
        private System.Windows.Forms.DataGridView dgvEstu;
        private System.Windows.Forms.MaskedTextBox mskHo2;
        private System.Windows.Forms.MaskedTextBox mskFe2;
        private System.Windows.Forms.Label lblDire;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblIdEs;
        private System.Windows.Forms.Label lblfechadenacimiento;
        private System.Windows.Forms.Label lblidentificacion;
        private System.Windows.Forms.Label lblnacimiento;
        private System.Windows.Forms.Label lblMóvil;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label lblNivelacadémico;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtNacimiento;
        private System.Windows.Forms.TextBox txtdirección;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtidentificación;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtestudiante;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskMO;
        private System.Windows.Forms.DateTimePicker dtpNan;
        private System.Windows.Forms.GroupBox grbEst;
        private System.Windows.Forms.TextBox txtAct;
        private System.Windows.Forms.CheckBox chkAct;
    }
}

