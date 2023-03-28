namespace EscuelaLaboral2018
{
    partial class FrmMantAul6
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
            this.lblAula = new System.Windows.Forms.Label();
            this.lblnúm = new System.Windows.Forms.Label();
            this.lblEdi = new System.Windows.Forms.Label();
            this.lblCap_Est = new System.Windows.Forms.Label();
            this.grbAula = new System.Windows.Forms.GroupBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCap_Est = new System.Windows.Forms.TextBox();
            this.txtId_Edif = new System.Windows.Forms.TextBox();
            this.txtNum_Aula = new System.Windows.Forms.TextBox();
            this.txtID_Aula = new System.Windows.Forms.TextBox();
            this.lblID_Estudiante = new System.Windows.Forms.Label();
            this.dgvAula = new System.Windows.Forms.DataGridView();
            this.lblPoli2 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.grbIns = new System.Windows.Forms.GroupBox();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.mskFe4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.grbFecha = new System.Windows.Forms.GroupBox();
            this.grbAula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).BeginInit();
            this.grbIns.SuspendLayout();
            this.grbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula.Location = new System.Drawing.Point(224, 95);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(202, 24);
            this.lblAula.TabIndex = 9;
            this.lblAula.Text = "Mantenimiento aulas";
            // 
            // lblnúm
            // 
            this.lblnúm.AutoSize = true;
            this.lblnúm.Location = new System.Drawing.Point(39, 59);
            this.lblnúm.Name = "lblnúm";
            this.lblnúm.Size = new System.Drawing.Size(82, 13);
            this.lblnúm.TabIndex = 10;
            this.lblnúm.Text = "Número de aula";
            // 
            // lblEdi
            // 
            this.lblEdi.AutoSize = true;
            this.lblEdi.Location = new System.Drawing.Point(49, 87);
            this.lblEdi.Name = "lblEdi";
            this.lblEdi.Size = new System.Drawing.Size(57, 13);
            this.lblEdi.TabIndex = 11;
            this.lblEdi.Text = "ID Edifício";
            // 
            // lblCap_Est
            // 
            this.lblCap_Est.AutoSize = true;
            this.lblCap_Est.Location = new System.Drawing.Point(14, 112);
            this.lblCap_Est.Name = "lblCap_Est";
            this.lblCap_Est.Size = new System.Drawing.Size(130, 13);
            this.lblCap_Est.TabIndex = 12;
            this.lblCap_Est.Text = "Capacidad de estudiantes";
            // 
            // grbAula
            // 
            this.grbAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grbAula.Controls.Add(this.btnRetornar);
            this.grbAula.Controls.Add(this.btnBorrar);
            this.grbAula.Controls.Add(this.btnlimp);
            this.grbAula.Controls.Add(this.btnGuardar);
            this.grbAula.Controls.Add(this.txtCap_Est);
            this.grbAula.Controls.Add(this.txtId_Edif);
            this.grbAula.Controls.Add(this.txtNum_Aula);
            this.grbAula.Controls.Add(this.txtID_Aula);
            this.grbAula.Controls.Add(this.lblID_Estudiante);
            this.grbAula.Controls.Add(this.lblnúm);
            this.grbAula.Controls.Add(this.lblCap_Est);
            this.grbAula.Controls.Add(this.lblEdi);
            this.grbAula.Location = new System.Drawing.Point(91, 132);
            this.grbAula.Name = "grbAula";
            this.grbAula.Size = new System.Drawing.Size(426, 143);
            this.grbAula.TabIndex = 13;
            this.grbAula.TabStop = false;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(352, 75);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(62, 24);
            this.btnRetornar.TabIndex = 39;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(272, 76);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(61, 23);
            this.btnBorrar.TabIndex = 38;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(272, 27);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(61, 23);
            this.btnlimp.TabIndex = 36;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(352, 25);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(62, 25);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtCap_Est
            // 
            this.txtCap_Est.Location = new System.Drawing.Point(150, 109);
            this.txtCap_Est.Name = "txtCap_Est";
            this.txtCap_Est.Size = new System.Drawing.Size(76, 20);
            this.txtCap_Est.TabIndex = 17;
            // 
            // txtId_Edif
            // 
            this.txtId_Edif.Location = new System.Drawing.Point(150, 80);
            this.txtId_Edif.Name = "txtId_Edif";
            this.txtId_Edif.Size = new System.Drawing.Size(76, 20);
            this.txtId_Edif.TabIndex = 16;
            // 
            // txtNum_Aula
            // 
            this.txtNum_Aula.Location = new System.Drawing.Point(150, 52);
            this.txtNum_Aula.Name = "txtNum_Aula";
            this.txtNum_Aula.Size = new System.Drawing.Size(72, 20);
            this.txtNum_Aula.TabIndex = 15;
            // 
            // txtID_Aula
            // 
            this.txtID_Aula.Location = new System.Drawing.Point(150, 18);
            this.txtID_Aula.Name = "txtID_Aula";
            this.txtID_Aula.Size = new System.Drawing.Size(69, 20);
            this.txtID_Aula.TabIndex = 14;
            // 
            // lblID_Estudiante
            // 
            this.lblID_Estudiante.AutoSize = true;
            this.lblID_Estudiante.Location = new System.Drawing.Point(64, 25);
            this.lblID_Estudiante.Name = "lblID_Estudiante";
            this.lblID_Estudiante.Size = new System.Drawing.Size(42, 13);
            this.lblID_Estudiante.TabIndex = 13;
            this.lblID_Estudiante.Text = "ID Aula";
            // 
            // dgvAula
            // 
            this.dgvAula.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAula.Location = new System.Drawing.Point(4, 290);
            this.dgvAula.Name = "dgvAula";
            this.dgvAula.Size = new System.Drawing.Size(580, 114);
            this.dgvAula.TabIndex = 14;
            this.dgvAula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAula_CellContentClick);
            this.dgvAula.Click += new System.EventHandler(this.dgvAula_Click);
            // 
            // lblPoli2
            // 
            this.lblPoli2.AutoSize = true;
            this.lblPoli2.Location = new System.Drawing.Point(6, 13);
            this.lblPoli2.Name = "lblPoli2";
            this.lblPoli2.Size = new System.Drawing.Size(257, 13);
            this.lblPoli2.TabIndex = 0;
            this.lblPoli2.Text = "Instituto Politécnico Nuestra Señora de las Mercedes";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(25, 41);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(169, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Av. Salvador,Estrella Sadhalá #60";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // grbIns
            // 
            this.grbIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grbIns.Controls.Add(this.lbl2);
            this.grbIns.Controls.Add(this.lblPoli2);
            this.grbIns.Location = new System.Drawing.Point(12, 19);
            this.grbIns.Name = "grbIns";
            this.grbIns.Size = new System.Drawing.Size(271, 61);
            this.grbIns.TabIndex = 6;
            this.grbIns.TabStop = false;
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(17, 16);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(37, 13);
            this.lblFecha2.TabIndex = 1;
            this.lblFecha2.Text = "Fecha";
            // 
            // lblHora2
            // 
            this.lblHora2.AutoSize = true;
            this.lblHora2.Location = new System.Drawing.Point(24, 48);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(30, 13);
            this.lblHora2.TabIndex = 3;
            this.lblHora2.Text = "Hora";
            // 
            // mskFe4
            // 
            this.mskFe4.Location = new System.Drawing.Point(73, 13);
            this.mskFe4.Mask = "00/00/0000";
            this.mskFe4.Name = "mskFe4";
            this.mskFe4.Size = new System.Drawing.Size(73, 20);
            this.mskFe4.TabIndex = 4;
            this.mskFe4.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(73, 41);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(61, 20);
            this.maskedTextBox2.TabIndex = 5;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // grbFecha
            // 
            this.grbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grbFecha.Controls.Add(this.maskedTextBox2);
            this.grbFecha.Controls.Add(this.mskFe4);
            this.grbFecha.Controls.Add(this.lblHora2);
            this.grbFecha.Controls.Add(this.lblFecha2);
            this.grbFecha.Location = new System.Drawing.Point(421, 12);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(163, 68);
            this.grbFecha.TabIndex = 8;
            this.grbFecha.TabStop = false;
            // 
            // FrmMantAul6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(596, 416);
            this.ControlBox = false;
            this.Controls.Add(this.dgvAula);
            this.Controls.Add(this.grbAula);
            this.Controls.Add(this.lblAula);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.grbIns);
            this.Name = "FrmMantAul6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMantAul6";
            this.Load += new System.EventHandler(this.FrmMantAul6_Load);
            this.grbAula.ResumeLayout(false);
            this.grbAula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAula)).EndInit();
            this.grbIns.ResumeLayout(false);
            this.grbIns.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.Label lblnúm;
        private System.Windows.Forms.Label lblEdi;
        private System.Windows.Forms.Label lblCap_Est;
        private System.Windows.Forms.GroupBox grbAula;
        private System.Windows.Forms.Label lblID_Estudiante;
        private System.Windows.Forms.TextBox txtCap_Est;
        private System.Windows.Forms.TextBox txtId_Edif;
        private System.Windows.Forms.TextBox txtNum_Aula;
        private System.Windows.Forms.TextBox txtID_Aula;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.DataGridView dgvAula;
        private System.Windows.Forms.Label lblPoli2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.GroupBox grbIns;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.MaskedTextBox mskFe4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.GroupBox grbFecha;
    }
}