namespace EscuelaLaboral2018
{
    partial class FrmConIns11
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbFecha = new System.Windows.Forms.GroupBox();
            this.mskHo3 = new System.Windows.Forms.MaskedTextBox();
            this.mskFe3 = new System.Windows.Forms.MaskedTextBox();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.grbIns = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.rdbOtrosDoc = new System.Windows.Forms.RadioButton();
            this.rdbPer = new System.Windows.Forms.RadioButton();
            this.rdbID_Taller = new System.Windows.Forms.RadioButton();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbID_Empleado = new System.Windows.Forms.RadioButton();
            this.rdbID_est = new System.Windows.Forms.RadioButton();
            this.rdbFoto = new System.Windows.Forms.RadioButton();
            this.rdbCedúla = new System.Windows.Forms.RadioButton();
            this.rdbID_Ins = new System.Windows.Forms.RadioButton();
            this.lblIns = new System.Windows.Forms.Label();
            this.dgvCon = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.grbFecha.SuspendLayout();
            this.grbIns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Av. Salvador,Estrella Sadhalá #60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Instituto Politécnico Nuestra Señora de las Mercedes";
            // 
            // grbFecha
            // 
            this.grbFecha.BackColor = System.Drawing.Color.AliceBlue;
            this.grbFecha.Controls.Add(this.mskHo3);
            this.grbFecha.Controls.Add(this.mskFe3);
            this.grbFecha.Controls.Add(this.lblHora2);
            this.grbFecha.Controls.Add(this.lblFecha2);
            this.grbFecha.Location = new System.Drawing.Point(438, 6);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(135, 70);
            this.grbFecha.TabIndex = 13;
            this.grbFecha.TabStop = false;
            // 
            // mskHo3
            // 
            this.mskHo3.Location = new System.Drawing.Point(75, 41);
            this.mskHo3.Mask = "00:00";
            this.mskHo3.Name = "mskHo3";
            this.mskHo3.Size = new System.Drawing.Size(36, 20);
            this.mskHo3.TabIndex = 5;
            this.mskHo3.ValidatingType = typeof(System.DateTime);
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
            // grbIns
            // 
            this.grbIns.BackColor = System.Drawing.Color.AliceBlue;
            this.grbIns.Controls.Add(this.txtBusqueda);
            this.grbIns.Controls.Add(this.lblCriterio);
            this.grbIns.Controls.Add(this.btnRetornar);
            this.grbIns.Controls.Add(this.btnBorrar);
            this.grbIns.Controls.Add(this.btnGuardar);
            this.grbIns.Controls.Add(this.btnlimp);
            this.grbIns.Controls.Add(this.rdbOtrosDoc);
            this.grbIns.Controls.Add(this.rdbPer);
            this.grbIns.Controls.Add(this.rdbID_Taller);
            this.grbIns.Controls.Add(this.rdbFecha);
            this.grbIns.Controls.Add(this.rdbID_Empleado);
            this.grbIns.Controls.Add(this.rdbID_est);
            this.grbIns.Controls.Add(this.rdbFoto);
            this.grbIns.Controls.Add(this.rdbCedúla);
            this.grbIns.Controls.Add(this.rdbID_Ins);
            this.grbIns.Location = new System.Drawing.Point(41, 158);
            this.grbIns.Name = "grbIns";
            this.grbIns.Size = new System.Drawing.Size(532, 135);
            this.grbIns.TabIndex = 14;
            this.grbIns.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(233, 16);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 50;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(40, 19);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(133, 13);
            this.lblCriterio.TabIndex = 49;
            this.lblCriterio.Text = "Digite criterio de busqueda";
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(447, 94);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(75, 23);
            this.btnRetornar.TabIndex = 22;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(358, 48);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 20);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(365, 94);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(447, 48);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(75, 20);
            this.btnlimp.TabIndex = 19;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // rdbOtrosDoc
            // 
            this.rdbOtrosDoc.AutoSize = true;
            this.rdbOtrosDoc.Location = new System.Drawing.Point(146, 100);
            this.rdbOtrosDoc.Name = "rdbOtrosDoc";
            this.rdbOtrosDoc.Size = new System.Drawing.Size(111, 17);
            this.rdbOtrosDoc.TabIndex = 8;
            this.rdbOtrosDoc.TabStop = true;
            this.rdbOtrosDoc.Text = "Otros documentos";
            this.rdbOtrosDoc.UseVisualStyleBackColor = true;
            // 
            // rdbPer
            // 
            this.rdbPer.AutoSize = true;
            this.rdbPer.Location = new System.Drawing.Point(287, 48);
            this.rdbPer.Name = "rdbPer";
            this.rdbPer.Size = new System.Drawing.Size(63, 17);
            this.rdbPer.TabIndex = 7;
            this.rdbPer.TabStop = true;
            this.rdbPer.Text = "Período";
            this.rdbPer.UseVisualStyleBackColor = true;
            // 
            // rdbID_Taller
            // 
            this.rdbID_Taller.AutoSize = true;
            this.rdbID_Taller.Location = new System.Drawing.Point(28, 100);
            this.rdbID_Taller.Name = "rdbID_Taller";
            this.rdbID_Taller.Size = new System.Drawing.Size(68, 17);
            this.rdbID_Taller.TabIndex = 6;
            this.rdbID_Taller.TabStop = true;
            this.rdbID_Taller.Text = "ID_Taller";
            this.rdbID_Taller.UseVisualStyleBackColor = true;
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Location = new System.Drawing.Point(287, 71);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(55, 17);
            this.rdbFecha.TabIndex = 5;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha";
            this.rdbFecha.UseVisualStyleBackColor = true;
            // 
            // rdbID_Empleado
            // 
            this.rdbID_Empleado.AutoSize = true;
            this.rdbID_Empleado.Location = new System.Drawing.Point(28, 77);
            this.rdbID_Empleado.Name = "rdbID_Empleado";
            this.rdbID_Empleado.Size = new System.Drawing.Size(89, 17);
            this.rdbID_Empleado.TabIndex = 4;
            this.rdbID_Empleado.TabStop = true;
            this.rdbID_Empleado.Text = "ID_Empleado";
            this.rdbID_Empleado.UseVisualStyleBackColor = true;
            // 
            // rdbID_est
            // 
            this.rdbID_est.AutoSize = true;
            this.rdbID_est.Location = new System.Drawing.Point(146, 48);
            this.rdbID_est.Name = "rdbID_est";
            this.rdbID_est.Size = new System.Drawing.Size(92, 17);
            this.rdbID_est.TabIndex = 3;
            this.rdbID_est.TabStop = true;
            this.rdbID_est.Text = "ID_Estudiante";
            this.rdbID_est.UseVisualStyleBackColor = true;
            // 
            // rdbFoto
            // 
            this.rdbFoto.AutoSize = true;
            this.rdbFoto.Location = new System.Drawing.Point(287, 100);
            this.rdbFoto.Name = "rdbFoto";
            this.rdbFoto.Size = new System.Drawing.Size(46, 17);
            this.rdbFoto.TabIndex = 2;
            this.rdbFoto.TabStop = true;
            this.rdbFoto.Text = "Foto";
            this.rdbFoto.UseVisualStyleBackColor = true;
            // 
            // rdbCedúla
            // 
            this.rdbCedúla.AutoSize = true;
            this.rdbCedúla.Location = new System.Drawing.Point(146, 77);
            this.rdbCedúla.Name = "rdbCedúla";
            this.rdbCedúla.Size = new System.Drawing.Size(124, 17);
            this.rdbCedúla.TabIndex = 1;
            this.rdbCedúla.TabStop = true;
            this.rdbCedúla.Text = "Cedúla_o_Pasaporte";
            this.rdbCedúla.UseVisualStyleBackColor = true;
            // 
            // rdbID_Ins
            // 
            this.rdbID_Ins.AutoSize = true;
            this.rdbID_Ins.Location = new System.Drawing.Point(28, 48);
            this.rdbID_Ins.Name = "rdbID_Ins";
            this.rdbID_Ins.Size = new System.Drawing.Size(93, 17);
            this.rdbID_Ins.TabIndex = 0;
            this.rdbID_Ins.TabStop = true;
            this.rdbID_Ins.Text = "ID_Inscripción";
            this.rdbID_Ins.UseVisualStyleBackColor = true;
            // 
            // lblIns
            // 
            this.lblIns.AutoSize = true;
            this.lblIns.BackColor = System.Drawing.Color.AliceBlue;
            this.lblIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIns.Location = new System.Drawing.Point(204, 107);
            this.lblIns.Name = "lblIns";
            this.lblIns.Size = new System.Drawing.Size(235, 24);
            this.lblIns.TabIndex = 15;
            this.lblIns.Text = "Consulta de Inscripción ";
            // 
            // dgvCon
            // 
            this.dgvCon.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCon.Location = new System.Drawing.Point(65, 308);
            this.dgvCon.Name = "dgvCon";
            this.dgvCon.Size = new System.Drawing.Size(484, 90);
            this.dgvCon.TabIndex = 16;
            // 
            // FrmConIns11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(585, 428);
            this.ControlBox = false;
            this.Controls.Add(this.dgvCon);
            this.Controls.Add(this.lblIns);
            this.Controls.Add(this.grbIns);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConIns11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConIns11";
            this.Load += new System.EventHandler(this.FrmConIns11_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            this.grbIns.ResumeLayout(false);
            this.grbIns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbFecha;
        private System.Windows.Forms.MaskedTextBox mskHo3;
        private System.Windows.Forms.MaskedTextBox mskFe3;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.GroupBox grbIns;
        private System.Windows.Forms.RadioButton rdbOtrosDoc;
        private System.Windows.Forms.RadioButton rdbPer;
        private System.Windows.Forms.RadioButton rdbID_Taller;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.RadioButton rdbID_Empleado;
        private System.Windows.Forms.RadioButton rdbID_est;
        private System.Windows.Forms.RadioButton rdbFoto;
        private System.Windows.Forms.RadioButton rdbCedúla;
        private System.Windows.Forms.RadioButton rdbID_Ins;
        private System.Windows.Forms.Label lblIns;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.DataGridView dgvCon;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblCriterio;
    }
}