namespace EscuelaLaboral2018
{
    partial class FrmConPro3
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
            this.lblProfesorMan = new System.Windows.Forms.Label();
            this.grbProf = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.rdbMóvil = new System.Windows.Forms.RadioButton();
            this.rdbTel = new System.Windows.Forms.RadioButton();
            this.rdbNum = new System.Windows.Forms.RadioButton();
            this.rdbFoto = new System.Windows.Forms.RadioButton();
            this.rdbId_Prof = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdbDire = new System.Windows.Forms.RadioButton();
            this.rdbIden = new System.Windows.Forms.RadioButton();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.grbFecha = new System.Windows.Forms.GroupBox();
            this.mskHo3 = new System.Windows.Forms.MaskedTextBox();
            this.mskFe3 = new System.Windows.Forms.MaskedTextBox();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.dgvPro = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbProf.SuspendLayout();
            this.grbFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProfesorMan
            // 
            this.lblProfesorMan.AutoSize = true;
            this.lblProfesorMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblProfesorMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesorMan.Location = new System.Drawing.Point(278, 98);
            this.lblProfesorMan.Name = "lblProfesorMan";
            this.lblProfesorMan.Size = new System.Drawing.Size(231, 24);
            this.lblProfesorMan.TabIndex = 8;
            this.lblProfesorMan.Text = "Mantenimiento Profesor";
            // 
            // grbProf
            // 
            this.grbProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbProf.Controls.Add(this.txtBusqueda);
            this.grbProf.Controls.Add(this.lblCriterio);
            this.grbProf.Controls.Add(this.rdbMóvil);
            this.grbProf.Controls.Add(this.rdbTel);
            this.grbProf.Controls.Add(this.rdbNum);
            this.grbProf.Controls.Add(this.rdbFoto);
            this.grbProf.Controls.Add(this.rdbId_Prof);
            this.grbProf.Controls.Add(this.rdbNombre);
            this.grbProf.Controls.Add(this.radioButton3);
            this.grbProf.Controls.Add(this.rdbDire);
            this.grbProf.Controls.Add(this.rdbIden);
            this.grbProf.Controls.Add(this.btnRetornar);
            this.grbProf.Controls.Add(this.btnBorrar);
            this.grbProf.Controls.Add(this.btnGuardar);
            this.grbProf.Controls.Add(this.btnlimp);
            this.grbProf.Location = new System.Drawing.Point(21, 136);
            this.grbProf.Name = "grbProf";
            this.grbProf.Size = new System.Drawing.Size(592, 141);
            this.grbProf.TabIndex = 9;
            this.grbProf.TabStop = false;
            this.grbProf.Enter += new System.EventHandler(this.grb_Enter);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(208, 16);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 50;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(55, 16);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(133, 13);
            this.lblCriterio.TabIndex = 49;
            this.lblCriterio.Text = "Digite criterio de busqueda";
            // 
            // rdbMóvil
            // 
            this.rdbMóvil.AutoSize = true;
            this.rdbMóvil.Location = new System.Drawing.Point(303, 77);
            this.rdbMóvil.Name = "rdbMóvil";
            this.rdbMóvil.Size = new System.Drawing.Size(50, 17);
            this.rdbMóvil.TabIndex = 23;
            this.rdbMóvil.TabStop = true;
            this.rdbMóvil.Text = "Móvil";
            this.rdbMóvil.UseVisualStyleBackColor = true;
            // 
            // rdbTel
            // 
            this.rdbTel.AutoSize = true;
            this.rdbTel.Location = new System.Drawing.Point(303, 48);
            this.rdbTel.Name = "rdbTel";
            this.rdbTel.Size = new System.Drawing.Size(67, 17);
            this.rdbTel.TabIndex = 22;
            this.rdbTel.TabStop = true;
            this.rdbTel.Text = "Teléfono";
            this.rdbTel.UseVisualStyleBackColor = true;
            // 
            // rdbNum
            // 
            this.rdbNum.AutoSize = true;
            this.rdbNum.Location = new System.Drawing.Point(153, 105);
            this.rdbNum.Name = "rdbNum";
            this.rdbNum.Size = new System.Drawing.Size(148, 17);
            this.rdbNum.TabIndex = 21;
            this.rdbNum.TabStop = true;
            this.rdbNum.Text = "Número_de_idemtificacón";
            this.rdbNum.UseVisualStyleBackColor = true;
            // 
            // rdbFoto
            // 
            this.rdbFoto.AutoSize = true;
            this.rdbFoto.Location = new System.Drawing.Point(307, 105);
            this.rdbFoto.Name = "rdbFoto";
            this.rdbFoto.Size = new System.Drawing.Size(46, 17);
            this.rdbFoto.TabIndex = 20;
            this.rdbFoto.TabStop = true;
            this.rdbFoto.Text = "Foto";
            this.rdbFoto.UseVisualStyleBackColor = true;
            // 
            // rdbId_Prof
            // 
            this.rdbId_Prof.AutoSize = true;
            this.rdbId_Prof.Location = new System.Drawing.Point(44, 48);
            this.rdbId_Prof.Name = "rdbId_Prof";
            this.rdbId_Prof.Size = new System.Drawing.Size(81, 17);
            this.rdbId_Prof.TabIndex = 19;
            this.rdbId_Prof.TabStop = true;
            this.rdbId_Prof.Text = "ID_Profesor";
            this.rdbId_Prof.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(44, 82);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(62, 17);
            this.rdbNombre.TabIndex = 18;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(44, 105);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(49, 17);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Sexo";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rdbDire
            // 
            this.rdbDire.AutoSize = true;
            this.rdbDire.Location = new System.Drawing.Point(157, 51);
            this.rdbDire.Name = "rdbDire";
            this.rdbDire.Size = new System.Drawing.Size(70, 17);
            this.rdbDire.TabIndex = 16;
            this.rdbDire.TabStop = true;
            this.rdbDire.Text = "Dirección";
            this.rdbDire.UseVisualStyleBackColor = true;
            // 
            // rdbIden
            // 
            this.rdbIden.AutoSize = true;
            this.rdbIden.Location = new System.Drawing.Point(157, 77);
            this.rdbIden.Name = "rdbIden";
            this.rdbIden.Size = new System.Drawing.Size(111, 17);
            this.rdbIden.TabIndex = 15;
            this.rdbIden.TabStop = true;
            this.rdbIden.Text = "Identificación_tipo";
            this.rdbIden.UseVisualStyleBackColor = true;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(501, 105);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(75, 23);
            this.btnRetornar.TabIndex = 14;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(393, 105);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(393, 48);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(492, 48);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(75, 23);
            this.btnlimp.TabIndex = 11;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // grbFecha
            // 
            this.grbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbFecha.Controls.Add(this.mskHo3);
            this.grbFecha.Controls.Add(this.mskFe3);
            this.grbFecha.Controls.Add(this.lblHora2);
            this.grbFecha.Controls.Add(this.lblFecha2);
            this.grbFecha.Location = new System.Drawing.Point(513, 6);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(135, 72);
            this.grbFecha.TabIndex = 10;
            this.grbFecha.TabStop = false;
            // 
            // mskHo3
            // 
            this.mskHo3.Location = new System.Drawing.Point(60, 48);
            this.mskHo3.Mask = "00:00";
            this.mskHo3.Name = "mskHo3";
            this.mskHo3.Size = new System.Drawing.Size(36, 20);
            this.mskHo3.TabIndex = 5;
            this.mskHo3.ValidatingType = typeof(System.DateTime);
            this.mskHo3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskHo3_MaskInputRejected);
            // 
            // mskFe3
            // 
            this.mskFe3.Location = new System.Drawing.Point(60, 13);
            this.mskFe3.Mask = "00/00/0000";
            this.mskFe3.Name = "mskFe3";
            this.mskFe3.Size = new System.Drawing.Size(65, 20);
            this.mskFe3.TabIndex = 4;
            this.mskFe3.ValidatingType = typeof(System.DateTime);
            // 
            // lblHora2
            // 
            this.lblHora2.AutoSize = true;
            this.lblHora2.Location = new System.Drawing.Point(6, 44);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(30, 13);
            this.lblHora2.TabIndex = 3;
            this.lblHora2.Text = "Hora";
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(6, 16);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(37, 13);
            this.lblFecha2.TabIndex = 1;
            this.lblFecha2.Text = "Fecha";
            // 
            // dgvPro
            // 
            this.dgvPro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPro.Location = new System.Drawing.Point(40, 283);
            this.dgvPro.Name = "dgvPro";
            this.dgvPro.Size = new System.Drawing.Size(598, 94);
            this.dgvPro.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Instito Politécnico Nuestra Señora de las Mercedes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Av. Salvador,Estrella Sadhalá";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // FrmConPro3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(660, 389);
            this.ControlBox = false;
            this.Controls.Add(this.dgvPro);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.grbProf);
            this.Controls.Add(this.lblProfesorMan);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConPro3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConPro3";
            this.Load += new System.EventHandler(this.FrmConPro3_Load);
            this.grbProf.ResumeLayout(false);
            this.grbProf.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesorMan;
        private System.Windows.Forms.GroupBox grbProf;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.GroupBox grbFecha;
        private System.Windows.Forms.MaskedTextBox mskHo3;
        private System.Windows.Forms.MaskedTextBox mskFe3;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.RadioButton rdbTel;
        private System.Windows.Forms.RadioButton rdbNum;
        private System.Windows.Forms.RadioButton rdbFoto;
        private System.Windows.Forms.RadioButton rdbId_Prof;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdbDire;
        private System.Windows.Forms.RadioButton rdbIden;
        private System.Windows.Forms.RadioButton rdbMóvil;
        private System.Windows.Forms.DataGridView dgvPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblCriterio;
    }
}