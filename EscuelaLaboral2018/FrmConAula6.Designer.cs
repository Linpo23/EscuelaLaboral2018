namespace EscuelaLaboral2018
{
    partial class FrmConAula6
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
            this.grbCon = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.rdbCap = new System.Windows.Forms.RadioButton();
            this.rdbNúm = new System.Windows.Forms.RadioButton();
            this.rdbId_Edi = new System.Windows.Forms.RadioButton();
            this.rdbId_aula = new System.Windows.Forms.RadioButton();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbIns = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblPoli2 = new System.Windows.Forms.Label();
            this.grbFecha = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.mskFe4 = new System.Windows.Forms.MaskedTextBox();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblAula = new System.Windows.Forms.Label();
            this.dgvCon = new System.Windows.Forms.DataGridView();
            this.grbCon.SuspendLayout();
            this.grbIns.SuspendLayout();
            this.grbFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCon
            // 
            this.grbCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grbCon.Controls.Add(this.txtBusqueda);
            this.grbCon.Controls.Add(this.lblCriterio);
            this.grbCon.Controls.Add(this.rdbCap);
            this.grbCon.Controls.Add(this.rdbNúm);
            this.grbCon.Controls.Add(this.rdbId_Edi);
            this.grbCon.Controls.Add(this.rdbId_aula);
            this.grbCon.Controls.Add(this.btnRetornar);
            this.grbCon.Controls.Add(this.btnBorrar);
            this.grbCon.Controls.Add(this.btnlimp);
            this.grbCon.Controls.Add(this.btnGuardar);
            this.grbCon.Location = new System.Drawing.Point(167, 143);
            this.grbCon.Name = "grbCon";
            this.grbCon.Size = new System.Drawing.Size(380, 144);
            this.grbCon.TabIndex = 15;
            this.grbCon.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(211, 16);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 46;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(63, 16);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(133, 13);
            this.lblCriterio.TabIndex = 45;
            this.lblCriterio.Text = "Digite criterio de busqueda";
            // 
            // rdbCap
            // 
            this.rdbCap.AutoSize = true;
            this.rdbCap.Location = new System.Drawing.Point(26, 112);
            this.rdbCap.Name = "rdbCap";
            this.rdbCap.Size = new System.Drawing.Size(154, 17);
            this.rdbCap.TabIndex = 44;
            this.rdbCap.TabStop = true;
            this.rdbCap.Text = "Capacidad_de_estudiantes";
            this.rdbCap.UseVisualStyleBackColor = true;
            // 
            // rdbNúm
            // 
            this.rdbNúm.AutoSize = true;
            this.rdbNúm.Location = new System.Drawing.Point(26, 66);
            this.rdbNúm.Name = "rdbNúm";
            this.rdbNúm.Size = new System.Drawing.Size(106, 17);
            this.rdbNúm.TabIndex = 42;
            this.rdbNúm.TabStop = true;
            this.rdbNúm.Text = "Número_de_aula";
            this.rdbNúm.UseVisualStyleBackColor = true;
            // 
            // rdbId_Edi
            // 
            this.rdbId_Edi.AutoSize = true;
            this.rdbId_Edi.Location = new System.Drawing.Point(26, 89);
            this.rdbId_Edi.Name = "rdbId_Edi";
            this.rdbId_Edi.Size = new System.Drawing.Size(78, 17);
            this.rdbId_Edi.TabIndex = 41;
            this.rdbId_Edi.TabStop = true;
            this.rdbId_Edi.Text = "ID_Edifício";
            this.rdbId_Edi.UseVisualStyleBackColor = true;
            // 
            // rdbId_aula
            // 
            this.rdbId_aula.AutoSize = true;
            this.rdbId_aula.Location = new System.Drawing.Point(26, 43);
            this.rdbId_aula.Name = "rdbId_aula";
            this.rdbId_aula.Size = new System.Drawing.Size(63, 17);
            this.rdbId_aula.TabIndex = 40;
            this.rdbId_aula.TabStop = true;
            this.rdbId_aula.Text = "ID_Aula";
            this.rdbId_aula.UseVisualStyleBackColor = true;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(295, 105);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(62, 24);
            this.btnRetornar.TabIndex = 39;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(196, 109);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(62, 23);
            this.btnBorrar.TabIndex = 38;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(296, 58);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(61, 23);
            this.btnlimp.TabIndex = 36;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(196, 58);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(62, 25);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // grbIns
            // 
            this.grbIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grbIns.Controls.Add(this.lbl2);
            this.grbIns.Controls.Add(this.lblPoli2);
            this.grbIns.Location = new System.Drawing.Point(12, 12);
            this.grbIns.Name = "grbIns";
            this.grbIns.Size = new System.Drawing.Size(271, 61);
            this.grbIns.TabIndex = 16;
            this.grbIns.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(54, 29);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(169, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Av. Salvador,Estrella Sadhalá #60";
            // 
            // lblPoli2
            // 
            this.lblPoli2.AutoSize = true;
            this.lblPoli2.Location = new System.Drawing.Point(8, 16);
            this.lblPoli2.Name = "lblPoli2";
            this.lblPoli2.Size = new System.Drawing.Size(257, 13);
            this.lblPoli2.TabIndex = 0;
            this.lblPoli2.Text = "Instituto Politécnico Nuestra Señora de las Mercedes";
            // 
            // grbFecha
            // 
            this.grbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grbFecha.Controls.Add(this.maskedTextBox2);
            this.grbFecha.Controls.Add(this.mskFe4);
            this.grbFecha.Controls.Add(this.lblHora2);
            this.grbFecha.Controls.Add(this.lblFecha2);
            this.grbFecha.Location = new System.Drawing.Point(521, 12);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(163, 79);
            this.grbFecha.TabIndex = 17;
            this.grbFecha.TabStop = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(73, 48);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(39, 20);
            this.maskedTextBox2.TabIndex = 5;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
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
            // lblHora2
            // 
            this.lblHora2.AutoSize = true;
            this.lblHora2.Location = new System.Drawing.Point(24, 52);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(30, 13);
            this.lblHora2.TabIndex = 3;
            this.lblHora2.Text = "Hora";
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
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula.Location = new System.Drawing.Point(302, 88);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(176, 24);
            this.lblAula.TabIndex = 18;
            this.lblAula.Text = "Consulta de aulas";
            // 
            // dgvCon
            // 
            this.dgvCon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCon.Location = new System.Drawing.Point(69, 305);
            this.dgvCon.Name = "dgvCon";
            this.dgvCon.Size = new System.Drawing.Size(586, 109);
            this.dgvCon.TabIndex = 19;
            // 
            // FrmConAula6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(730, 426);
            this.ControlBox = false;
            this.Controls.Add(this.dgvCon);
            this.Controls.Add(this.lblAula);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.grbIns);
            this.Controls.Add(this.grbCon);
            this.Name = "FrmConAula6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConAula6";
            this.Load += new System.EventHandler(this.FrmConAula6_Load);
            this.grbCon.ResumeLayout(false);
            this.grbCon.PerformLayout();
            this.grbIns.ResumeLayout(false);
            this.grbIns.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCon;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grbIns;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblPoli2;
        private System.Windows.Forms.GroupBox grbFecha;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox mskFe4;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.RadioButton rdbCap;
        private System.Windows.Forms.RadioButton rdbNúm;
        private System.Windows.Forms.RadioButton rdbId_Edi;
        private System.Windows.Forms.RadioButton rdbId_aula;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.DataGridView dgvCon;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblCriterio;

    }
}