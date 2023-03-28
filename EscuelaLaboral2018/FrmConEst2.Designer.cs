namespace EscuelaLaboral2018
{
    partial class FrmConEst2
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
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.lblav = new System.Windows.Forms.Label();
            this.lblpoli = new System.Windows.Forms.Label();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.mskHo2 = new System.Windows.Forms.MaskedTextBox();
            this.mskFe2 = new System.Windows.Forms.MaskedTextBox();
            this.lblFe = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblNa = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnLim = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grbEst = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.rdbNivel_Acdemíco = new System.Windows.Forms.RadioButton();
            this.rdbId_nacionalidad = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbDire = new System.Windows.Forms.RadioButton();
            this.rdbIden_Tipo = new System.Windows.Forms.RadioButton();
            this.rdbSexo = new System.Windows.Forms.RadioButton();
            this.rdbId_Est = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbFot = new System.Windows.Forms.RadioButton();
            this.rdbMóvil = new System.Windows.Forms.RadioButton();
            this.rdbTeléfono = new System.Windows.Forms.RadioButton();
            this.rdbFecha_nac = new System.Windows.Forms.RadioButton();
            this.dgvEst = new System.Windows.Forms.DataGridView();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.grbEst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst)).BeginInit();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.BackColor = System.Drawing.Color.Cyan;
            this.grb1.Controls.Add(this.lblav);
            this.grb1.Controls.Add(this.lblpoli);
            this.grb1.Location = new System.Drawing.Point(12, 12);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(271, 66);
            this.grb1.TabIndex = 2;
            this.grb1.TabStop = false;
            // 
            // lblav
            // 
            this.lblav.AutoSize = true;
            this.lblav.Location = new System.Drawing.Point(56, 39);
            this.lblav.Name = "lblav";
            this.lblav.Size = new System.Drawing.Size(169, 13);
            this.lblav.TabIndex = 11;
            this.lblav.Text = "Av. Salvador,Estrella Sadhalá #60";
            // 
            // lblpoli
            // 
            this.lblpoli.AutoSize = true;
            this.lblpoli.Location = new System.Drawing.Point(8, 16);
            this.lblpoli.Name = "lblpoli";
            this.lblpoli.Size = new System.Drawing.Size(257, 13);
            this.lblpoli.TabIndex = 0;
            this.lblpoli.Text = "Instituto Politécnico Nuestra Señora de las Mercedes";
            // 
            // grb2
            // 
            this.grb2.BackColor = System.Drawing.Color.Cyan;
            this.grb2.Controls.Add(this.mskHo2);
            this.grb2.Controls.Add(this.mskFe2);
            this.grb2.Controls.Add(this.lblFe);
            this.grb2.Controls.Add(this.lblhora);
            this.grb2.Location = new System.Drawing.Point(536, 12);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(166, 65);
            this.grb2.TabIndex = 9;
            this.grb2.TabStop = false;
            // 
            // mskHo2
            // 
            this.mskHo2.Location = new System.Drawing.Point(54, 39);
            this.mskHo2.Mask = "00:00";
            this.mskHo2.Name = "mskHo2";
            this.mskHo2.Size = new System.Drawing.Size(100, 20);
            this.mskHo2.TabIndex = 9;
            this.mskHo2.ValidatingType = typeof(System.DateTime);
            // 
            // mskFe2
            // 
            this.mskFe2.Location = new System.Drawing.Point(54, 13);
            this.mskFe2.Mask = "00/00/0000";
            this.mskFe2.Name = "mskFe2";
            this.mskFe2.Size = new System.Drawing.Size(100, 20);
            this.mskFe2.TabIndex = 8;
            this.mskFe2.ValidatingType = typeof(System.DateTime);
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
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(6, 40);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(30, 13);
            this.lblhora.TabIndex = 6;
            this.lblhora.Text = "Hora";
            // 
            // lblNa
            // 
            this.lblNa.AutoSize = true;
            this.lblNa.BackColor = System.Drawing.Color.Cyan;
            this.lblNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNa.Location = new System.Drawing.Point(289, 75);
            this.lblNa.Name = "lblNa";
            this.lblNa.Size = new System.Drawing.Size(235, 24);
            this.lblNa.TabIndex = 10;
            this.lblNa.Text = "Consulta de Estudiantes";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(494, 56);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 25);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(561, 97);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(62, 24);
            this.btnRetornar.TabIndex = 33;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(494, 97);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(56, 24);
            this.btnLim.TabIndex = 34;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(561, 58);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(62, 23);
            this.btnBorrar.TabIndex = 35;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // grbEst
            // 
            this.grbEst.BackColor = System.Drawing.Color.Cyan;
            this.grbEst.Controls.Add(this.txtBusqueda);
            this.grbEst.Controls.Add(this.lblCriterio);
            this.grbEst.Controls.Add(this.rdbNivel_Acdemíco);
            this.grbEst.Controls.Add(this.rdbId_nacionalidad);
            this.grbEst.Controls.Add(this.rdbActivo);
            this.grbEst.Controls.Add(this.rdbDire);
            this.grbEst.Controls.Add(this.rdbIden_Tipo);
            this.grbEst.Controls.Add(this.rdbSexo);
            this.grbEst.Controls.Add(this.rdbId_Est);
            this.grbEst.Controls.Add(this.rdbNombre);
            this.grbEst.Controls.Add(this.rdbFot);
            this.grbEst.Controls.Add(this.rdbMóvil);
            this.grbEst.Controls.Add(this.rdbTeléfono);
            this.grbEst.Controls.Add(this.rdbFecha_nac);
            this.grbEst.Controls.Add(this.btnBorrar);
            this.grbEst.Controls.Add(this.btnLim);
            this.grbEst.Controls.Add(this.btnRetornar);
            this.grbEst.Controls.Add(this.btnGuardar);
            this.grbEst.Location = new System.Drawing.Point(51, 118);
            this.grbEst.Name = "grbEst";
            this.grbEst.Size = new System.Drawing.Size(639, 136);
            this.grbEst.TabIndex = 11;
            this.grbEst.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(314, 19);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 50;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(163, 26);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(133, 13);
            this.lblCriterio.TabIndex = 49;
            this.lblCriterio.Text = "Digite criterio de busqueda";
            // 
            // rdbNivel_Acdemíco
            // 
            this.rdbNivel_Acdemíco.AutoSize = true;
            this.rdbNivel_Acdemíco.Location = new System.Drawing.Point(378, 104);
            this.rdbNivel_Acdemíco.Name = "rdbNivel_Acdemíco";
            this.rdbNivel_Acdemíco.Size = new System.Drawing.Size(110, 17);
            this.rdbNivel_Acdemíco.TabIndex = 47;
            this.rdbNivel_Acdemíco.TabStop = true;
            this.rdbNivel_Acdemíco.Text = "Nivel_Academíco";
            this.rdbNivel_Acdemíco.UseVisualStyleBackColor = true;
            // 
            // rdbId_nacionalidad
            // 
            this.rdbId_nacionalidad.AutoSize = true;
            this.rdbId_nacionalidad.Location = new System.Drawing.Point(378, 81);
            this.rdbId_nacionalidad.Name = "rdbId_nacionalidad";
            this.rdbId_nacionalidad.Size = new System.Drawing.Size(104, 17);
            this.rdbId_nacionalidad.TabIndex = 46;
            this.rdbId_nacionalidad.TabStop = true;
            this.rdbId_nacionalidad.Text = "ID_Nacionalidad";
            this.rdbId_nacionalidad.UseVisualStyleBackColor = true;
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(378, 56);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(55, 17);
            this.rdbActivo.TabIndex = 45;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // rdbDire
            // 
            this.rdbDire.AutoSize = true;
            this.rdbDire.Location = new System.Drawing.Point(153, 81);
            this.rdbDire.Name = "rdbDire";
            this.rdbDire.Size = new System.Drawing.Size(70, 17);
            this.rdbDire.TabIndex = 44;
            this.rdbDire.TabStop = true;
            this.rdbDire.Text = "Dirección";
            this.rdbDire.UseVisualStyleBackColor = true;
            // 
            // rdbIden_Tipo
            // 
            this.rdbIden_Tipo.AutoSize = true;
            this.rdbIden_Tipo.Location = new System.Drawing.Point(21, 104);
            this.rdbIden_Tipo.Name = "rdbIden_Tipo";
            this.rdbIden_Tipo.Size = new System.Drawing.Size(112, 17);
            this.rdbIden_Tipo.TabIndex = 43;
            this.rdbIden_Tipo.TabStop = true;
            this.rdbIden_Tipo.Text = "identificacíon_tipo";
            this.rdbIden_Tipo.UseVisualStyleBackColor = true;
            // 
            // rdbSexo
            // 
            this.rdbSexo.AutoSize = true;
            this.rdbSexo.Location = new System.Drawing.Point(153, 56);
            this.rdbSexo.Name = "rdbSexo";
            this.rdbSexo.Size = new System.Drawing.Size(49, 17);
            this.rdbSexo.TabIndex = 42;
            this.rdbSexo.TabStop = true;
            this.rdbSexo.Text = "Sexo";
            this.rdbSexo.UseVisualStyleBackColor = true;
            // 
            // rdbId_Est
            // 
            this.rdbId_Est.AutoSize = true;
            this.rdbId_Est.Location = new System.Drawing.Point(21, 56);
            this.rdbId_Est.Name = "rdbId_Est";
            this.rdbId_Est.Size = new System.Drawing.Size(92, 17);
            this.rdbId_Est.TabIndex = 41;
            this.rdbId_Est.TabStop = true;
            this.rdbId_Est.Text = "ID_Estudiante";
            this.rdbId_Est.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(21, 81);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(62, 17);
            this.rdbNombre.TabIndex = 40;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // rdbFot
            // 
            this.rdbFot.AutoSize = true;
            this.rdbFot.Location = new System.Drawing.Point(298, 104);
            this.rdbFot.Name = "rdbFot";
            this.rdbFot.Size = new System.Drawing.Size(46, 17);
            this.rdbFot.TabIndex = 39;
            this.rdbFot.TabStop = true;
            this.rdbFot.Text = "Foto";
            this.rdbFot.UseVisualStyleBackColor = true;
            // 
            // rdbMóvil
            // 
            this.rdbMóvil.AutoSize = true;
            this.rdbMóvil.Location = new System.Drawing.Point(294, 81);
            this.rdbMóvil.Name = "rdbMóvil";
            this.rdbMóvil.Size = new System.Drawing.Size(50, 17);
            this.rdbMóvil.TabIndex = 38;
            this.rdbMóvil.TabStop = true;
            this.rdbMóvil.Text = "Móvil";
            this.rdbMóvil.UseVisualStyleBackColor = true;
            // 
            // rdbTeléfono
            // 
            this.rdbTeléfono.AutoSize = true;
            this.rdbTeléfono.Location = new System.Drawing.Point(294, 56);
            this.rdbTeléfono.Name = "rdbTeléfono";
            this.rdbTeléfono.Size = new System.Drawing.Size(67, 17);
            this.rdbTeléfono.TabIndex = 37;
            this.rdbTeléfono.TabStop = true;
            this.rdbTeléfono.Text = "Teléfono";
            this.rdbTeléfono.UseVisualStyleBackColor = true;
            // 
            // rdbFecha_nac
            // 
            this.rdbFecha_nac.AutoSize = true;
            this.rdbFecha_nac.Location = new System.Drawing.Point(153, 104);
            this.rdbFecha_nac.Name = "rdbFecha_nac";
            this.rdbFecha_nac.Size = new System.Drawing.Size(130, 17);
            this.rdbFecha_nac.TabIndex = 36;
            this.rdbFecha_nac.TabStop = true;
            this.rdbFecha_nac.Text = "Fecha_de_nacimiento";
            this.rdbFecha_nac.UseVisualStyleBackColor = true;
            // 
            // dgvEst
            // 
            this.dgvEst.BackgroundColor = System.Drawing.Color.Cyan;
            this.dgvEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEst.Location = new System.Drawing.Point(71, 281);
            this.dgvEst.Name = "dgvEst";
            this.dgvEst.Size = new System.Drawing.Size(588, 112);
            this.dgvEst.TabIndex = 12;
            // 
            // FrmConEst2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(709, 414);
            this.ControlBox = false;
            this.Controls.Add(this.dgvEst);
            this.Controls.Add(this.grbEst);
            this.Controls.Add(this.lblNa);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Name = "FrmConEst2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConEst2";
            this.Load += new System.EventHandler(this.FrmConEst2_Load);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grb2.ResumeLayout(false);
            this.grb2.PerformLayout();
            this.grbEst.ResumeLayout(false);
            this.grbEst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Label lblav;
        private System.Windows.Forms.Label lblpoli;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.MaskedTextBox mskHo2;
        private System.Windows.Forms.MaskedTextBox mskFe2;
        private System.Windows.Forms.Label lblFe;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblNa;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox grbEst;
        private System.Windows.Forms.RadioButton rdbDire;
        private System.Windows.Forms.RadioButton rdbIden_Tipo;
        private System.Windows.Forms.RadioButton rdbSexo;
        private System.Windows.Forms.RadioButton rdbId_Est;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbFot;
        private System.Windows.Forms.RadioButton rdbMóvil;
        private System.Windows.Forms.RadioButton rdbTeléfono;
        private System.Windows.Forms.RadioButton rdbFecha_nac;
        private System.Windows.Forms.DataGridView dgvEst;
        private System.Windows.Forms.RadioButton rdbNivel_Acdemíco;
        private System.Windows.Forms.RadioButton rdbId_nacionalidad;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblCriterio;
    }
}