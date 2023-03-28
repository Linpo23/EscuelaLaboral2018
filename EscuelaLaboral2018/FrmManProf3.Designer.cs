namespace EscuelaLaboral2018
{
    partial class FrmManProf3
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
            this.grb3 = new System.Windows.Forms.GroupBox();
            this.mskHo3 = new System.Windows.Forms.MaskedTextBox();
            this.mskFe3 = new System.Windows.Forms.MaskedTextBox();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.dgvProf = new System.Windows.Forms.DataGridView();
            this.lblProfesorMan = new System.Windows.Forms.Label();
            this.grbProf = new System.Windows.Forms.GroupBox();
            this.mskMo3 = new System.Windows.Forms.MaskedTextBox();
            this.mksTel3 = new System.Windows.Forms.MaskedTextBox();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtIden = new System.Windows.Forms.TextBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.lblfot = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMov = new System.Windows.Forms.Label();
            this.lblIden = new System.Windows.Forms.Label();
            this.lblIdenti = new System.Windows.Forms.Label();
            this.lblDirec = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.grb = new System.Windows.Forms.GroupBox();
            this.lblProIng = new System.Windows.Forms.Label();
            this.grbIns.SuspendLayout();
            this.grb3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProf)).BeginInit();
            this.grbProf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.grb.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbIns
            // 
            this.grbIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grbIns.Controls.Add(this.lbl2);
            this.grbIns.Controls.Add(this.lblPoli2);
            this.grbIns.Location = new System.Drawing.Point(12, 21);
            this.grbIns.Name = "grbIns";
            this.grbIns.Size = new System.Drawing.Size(314, 72);
            this.grbIns.TabIndex = 3;
            this.grbIns.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(67, 41);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(169, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Av. Salvador,Estrella Sadhalá #60";
            // 
            // lblPoli2
            // 
            this.lblPoli2.AutoSize = true;
            this.lblPoli2.Location = new System.Drawing.Point(17, 22);
            this.lblPoli2.Name = "lblPoli2";
            this.lblPoli2.Size = new System.Drawing.Size(257, 13);
            this.lblPoli2.TabIndex = 0;
            this.lblPoli2.Text = "Instituto Politécnico Nuestra Señora de las Mercedes";
            // 
            // grb3
            // 
            this.grb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grb3.Controls.Add(this.mskHo3);
            this.grb3.Controls.Add(this.mskFe3);
            this.grb3.Controls.Add(this.lblHora2);
            this.grb3.Controls.Add(this.lblFecha2);
            this.grb3.Location = new System.Drawing.Point(441, 14);
            this.grb3.Name = "grb3";
            this.grb3.Size = new System.Drawing.Size(140, 79);
            this.grb3.TabIndex = 5;
            this.grb3.TabStop = false;
            // 
            // mskHo3
            // 
            this.mskHo3.Location = new System.Drawing.Point(62, 48);
            this.mskHo3.Mask = "00:00";
            this.mskHo3.Name = "mskHo3";
            this.mskHo3.Size = new System.Drawing.Size(35, 20);
            this.mskHo3.TabIndex = 5;
            this.mskHo3.ValidatingType = typeof(System.DateTime);
            // 
            // mskFe3
            // 
            this.mskFe3.Location = new System.Drawing.Point(62, 22);
            this.mskFe3.Mask = "00/00/0000";
            this.mskFe3.Name = "mskFe3";
            this.mskFe3.Size = new System.Drawing.Size(66, 20);
            this.mskFe3.TabIndex = 4;
            this.mskFe3.ValidatingType = typeof(System.DateTime);
            // 
            // lblHora2
            // 
            this.lblHora2.AutoSize = true;
            this.lblHora2.Location = new System.Drawing.Point(19, 52);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(30, 13);
            this.lblHora2.TabIndex = 3;
            this.lblHora2.Text = "Hora";
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(19, 22);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(37, 13);
            this.lblFecha2.TabIndex = 1;
            this.lblFecha2.Text = "Fecha";
            // 
            // dgvProf
            // 
            this.dgvProf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProf.Location = new System.Drawing.Point(6, 34);
            this.dgvProf.Name = "dgvProf";
            this.dgvProf.Size = new System.Drawing.Size(618, 106);
            this.dgvProf.TabIndex = 6;
            this.dgvProf.Click += new System.EventHandler(this.dgvProf_Click);
            // 
            // lblProfesorMan
            // 
            this.lblProfesorMan.AutoSize = true;
            this.lblProfesorMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblProfesorMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesorMan.Location = new System.Drawing.Point(259, 119);
            this.lblProfesorMan.Name = "lblProfesorMan";
            this.lblProfesorMan.Size = new System.Drawing.Size(231, 24);
            this.lblProfesorMan.TabIndex = 7;
            this.lblProfesorMan.Text = "Mantenimiento Profesor";
            // 
            // grbProf
            // 
            this.grbProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grbProf.Controls.Add(this.mskMo3);
            this.grbProf.Controls.Add(this.mksTel3);
            this.grbProf.Controls.Add(this.txtProf);
            this.grbProf.Controls.Add(this.txtNom);
            this.grbProf.Controls.Add(this.txtSex);
            this.grbProf.Controls.Add(this.txtDir);
            this.grbProf.Controls.Add(this.txtIden);
            this.grbProf.Controls.Add(this.txttipo);
            this.grbProf.Controls.Add(this.btnRetornar);
            this.grbProf.Controls.Add(this.btnBorrar);
            this.grbProf.Controls.Add(this.btnGuardar);
            this.grbProf.Controls.Add(this.btnlimp);
            this.grbProf.Controls.Add(this.pb2);
            this.grbProf.Controls.Add(this.lblfot);
            this.grbProf.Controls.Add(this.lblTel);
            this.grbProf.Controls.Add(this.lblMov);
            this.grbProf.Controls.Add(this.lblIden);
            this.grbProf.Controls.Add(this.lblIdenti);
            this.grbProf.Controls.Add(this.lblDirec);
            this.grbProf.Controls.Add(this.lblSex);
            this.grbProf.Controls.Add(this.lblNom);
            this.grbProf.Controls.Add(this.lblProf);
            this.grbProf.Location = new System.Drawing.Point(32, 168);
            this.grbProf.Name = "grbProf";
            this.grbProf.Size = new System.Drawing.Size(630, 139);
            this.grbProf.TabIndex = 8;
            this.grbProf.TabStop = false;
            // 
            // mskMo3
            // 
            this.mskMo3.Location = new System.Drawing.Point(317, 106);
            this.mskMo3.Mask = "000-000-0000";
            this.mskMo3.Name = "mskMo3";
            this.mskMo3.Size = new System.Drawing.Size(71, 20);
            this.mskMo3.TabIndex = 23;
            // 
            // mksTel3
            // 
            this.mksTel3.Location = new System.Drawing.Point(317, 76);
            this.mksTel3.Mask = "(999)000-0000";
            this.mksTel3.Name = "mksTel3";
            this.mksTel3.Size = new System.Drawing.Size(71, 20);
            this.mksTel3.TabIndex = 22;
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(97, 20);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(72, 20);
            this.txtProf.TabIndex = 21;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(97, 51);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(72, 20);
            this.txtNom.TabIndex = 20;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(97, 79);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(72, 20);
            this.txtSex.TabIndex = 19;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(97, 106);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(72, 20);
            this.txtDir.TabIndex = 18;
            // 
            // txtIden
            // 
            this.txtIden.Location = new System.Drawing.Point(317, 50);
            this.txtIden.Name = "txtIden";
            this.txtIden.Size = new System.Drawing.Size(72, 20);
            this.txtIden.TabIndex = 16;
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(317, 23);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(72, 20);
            this.txttipo.TabIndex = 15;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(533, 107);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(75, 23);
            this.btnRetornar.TabIndex = 14;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(533, 77);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(533, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(533, 45);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(75, 23);
            this.btnlimp.TabIndex = 11;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(409, 31);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(118, 95);
            this.pb2.TabIndex = 10;
            this.pb2.TabStop = false;
            // 
            // lblfot
            // 
            this.lblfot.AutoSize = true;
            this.lblfot.Location = new System.Drawing.Point(452, 16);
            this.lblfot.Name = "lblfot";
            this.lblfot.Size = new System.Drawing.Size(28, 13);
            this.lblfot.TabIndex = 9;
            this.lblfot.Text = "Foto";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(228, 79);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 13);
            this.lblTel.TabIndex = 7;
            this.lblTel.Text = "Teléfono";
            // 
            // lblMov
            // 
            this.lblMov.AutoSize = true;
            this.lblMov.Location = new System.Drawing.Point(228, 106);
            this.lblMov.Name = "lblMov";
            this.lblMov.Size = new System.Drawing.Size(32, 13);
            this.lblMov.TabIndex = 6;
            this.lblMov.Text = "Móvil";
            // 
            // lblIden
            // 
            this.lblIden.AutoSize = true;
            this.lblIden.Location = new System.Drawing.Point(208, 23);
            this.lblIden.Name = "lblIden";
            this.lblIden.Size = new System.Drawing.Size(90, 13);
            this.lblIden.TabIndex = 5;
            this.lblIden.Text = "Identificación tipo";
            // 
            // lblIdenti
            // 
            this.lblIdenti.AutoSize = true;
            this.lblIdenti.Location = new System.Drawing.Point(187, 51);
            this.lblIdenti.Name = "lblIdenti";
            this.lblIdenti.Size = new System.Drawing.Size(124, 13);
            this.lblIdenti.TabIndex = 4;
            this.lblIdenti.Text = "Número de identificación";
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.Location = new System.Drawing.Point(31, 106);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(52, 13);
            this.lblDirec.TabIndex = 3;
            this.lblDirec.Text = "Dirección";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(31, 85);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(31, 13);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "Sexo";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(31, 51);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre";
            this.lblNom.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(31, 27);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(60, 13);
            this.lblProf.TabIndex = 0;
            this.lblProf.Text = "ID Profesor";
            // 
            // grb
            // 
            this.grb.Controls.Add(this.lblProIng);
            this.grb.Controls.Add(this.dgvProf);
            this.grb.Location = new System.Drawing.Point(32, 333);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(630, 146);
            this.grb.TabIndex = 9;
            this.grb.TabStop = false;
            // 
            // lblProIng
            // 
            this.lblProIng.AutoSize = true;
            this.lblProIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProIng.Location = new System.Drawing.Point(228, 13);
            this.lblProIng.Name = "lblProIng";
            this.lblProIng.Size = new System.Drawing.Size(180, 18);
            this.lblProIng.TabIndex = 7;
            this.lblProIng.Text = "Profesores ingresados";
            // 
            // FrmManProf3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(687, 491);
            this.ControlBox = false;
            this.Controls.Add(this.grb);
            this.Controls.Add(this.grbProf);
            this.Controls.Add(this.lblProfesorMan);
            this.Controls.Add(this.grb3);
            this.Controls.Add(this.grbIns);
            this.Name = "FrmManProf3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManProf3";
            this.Activated += new System.EventHandler(this.FrmManProf3_Activated);
            this.Load += new System.EventHandler(this.FrmManProf3_Load);
            this.grbIns.ResumeLayout(false);
            this.grbIns.PerformLayout();
            this.grb3.ResumeLayout(false);
            this.grb3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProf)).EndInit();
            this.grbProf.ResumeLayout(false);
            this.grbProf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbIns;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblPoli2;
        private System.Windows.Forms.GroupBox grb3;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.DataGridView dgvProf;
        private System.Windows.Forms.Label lblProfesorMan;
        private System.Windows.Forms.GroupBox grbProf;
        private System.Windows.Forms.Label lblIden;
        private System.Windows.Forms.Label lblIdenti;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label lblfot;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMov;
        private System.Windows.Forms.MaskedTextBox mskHo3;
        private System.Windows.Forms.MaskedTextBox mskFe3;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtIden;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.MaskedTextBox mskMo3;
        private System.Windows.Forms.MaskedTextBox mksTel3;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.Label lblProIng;
    }
}