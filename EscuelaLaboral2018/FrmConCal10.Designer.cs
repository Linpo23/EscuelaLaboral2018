namespace EscuelaLaboral2018
{
    partial class FrmConCal10
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
            this.lblCal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.rdbAprobado = new System.Windows.Forms.RadioButton();
            this.rdbID_Cal = new System.Windows.Forms.RadioButton();
            this.rdbID_est = new System.Windows.Forms.RadioButton();
            this.rdbID_Taller = new System.Windows.Forms.RadioButton();
            this.rdbCal = new System.Windows.Forms.RadioButton();
            this.dgvConCal = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.grbFecha.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConCal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 72);
            this.groupBox1.TabIndex = 7;
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
            this.grbFecha.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.grbFecha.Controls.Add(this.mskHo3);
            this.grbFecha.Controls.Add(this.mskFe3);
            this.grbFecha.Controls.Add(this.lblHora2);
            this.grbFecha.Controls.Add(this.lblFecha2);
            this.grbFecha.Location = new System.Drawing.Point(336, 12);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(135, 70);
            this.grbFecha.TabIndex = 12;
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
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCal.Location = new System.Drawing.Point(126, 108);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(256, 24);
            this.lblCal.TabIndex = 13;
            this.lblCal.Text = "Consulta de Calificaciones";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox2.Controls.Add(this.txtBusqueda);
            this.groupBox2.Controls.Add(this.lblCriterio);
            this.groupBox2.Controls.Add(this.btnRetornar);
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnlimp);
            this.groupBox2.Controls.Add(this.rdbAprobado);
            this.groupBox2.Controls.Add(this.rdbID_Cal);
            this.groupBox2.Controls.Add(this.rdbID_est);
            this.groupBox2.Controls.Add(this.rdbID_Taller);
            this.groupBox2.Controls.Add(this.rdbCal);
            this.groupBox2.Location = new System.Drawing.Point(21, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 113);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(183, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 48;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(41, 13);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(133, 13);
            this.lblCriterio.TabIndex = 47;
            this.lblCriterio.Text = "Digite criterio de busqueda";
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(365, 80);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(75, 23);
            this.btnRetornar.TabIndex = 18;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(276, 80);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 20);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(283, 38);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(369, 38);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(75, 23);
            this.btnlimp.TabIndex = 15;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // rdbAprobado
            // 
            this.rdbAprobado.AutoSize = true;
            this.rdbAprobado.Location = new System.Drawing.Point(183, 38);
            this.rdbAprobado.Name = "rdbAprobado";
            this.rdbAprobado.Size = new System.Drawing.Size(71, 17);
            this.rdbAprobado.TabIndex = 4;
            this.rdbAprobado.TabStop = true;
            this.rdbAprobado.Text = "Aprobado";
            this.rdbAprobado.UseVisualStyleBackColor = true;
            // 
            // rdbID_Cal
            // 
            this.rdbID_Cal.AutoSize = true;
            this.rdbID_Cal.Location = new System.Drawing.Point(19, 38);
            this.rdbID_Cal.Name = "rdbID_Cal";
            this.rdbID_Cal.Size = new System.Drawing.Size(88, 17);
            this.rdbID_Cal.TabIndex = 3;
            this.rdbID_Cal.TabStop = true;
            this.rdbID_Cal.Text = "ID_Califación";
            this.rdbID_Cal.UseVisualStyleBackColor = true;
            // 
            // rdbID_est
            // 
            this.rdbID_est.AutoSize = true;
            this.rdbID_est.Location = new System.Drawing.Point(15, 83);
            this.rdbID_est.Name = "rdbID_est";
            this.rdbID_est.Size = new System.Drawing.Size(92, 17);
            this.rdbID_est.TabIndex = 2;
            this.rdbID_est.TabStop = true;
            this.rdbID_est.Text = "ID_Estudiante";
            this.rdbID_est.UseVisualStyleBackColor = true;
            // 
            // rdbID_Taller
            // 
            this.rdbID_Taller.AutoSize = true;
            this.rdbID_Taller.Location = new System.Drawing.Point(109, 59);
            this.rdbID_Taller.Name = "rdbID_Taller";
            this.rdbID_Taller.Size = new System.Drawing.Size(68, 17);
            this.rdbID_Taller.TabIndex = 1;
            this.rdbID_Taller.TabStop = true;
            this.rdbID_Taller.Text = "ID_Taller";
            this.rdbID_Taller.UseVisualStyleBackColor = true;
            // 
            // rdbCal
            // 
            this.rdbCal.AutoSize = true;
            this.rdbCal.Location = new System.Drawing.Point(183, 83);
            this.rdbCal.Name = "rdbCal";
            this.rdbCal.Size = new System.Drawing.Size(79, 17);
            this.rdbCal.TabIndex = 0;
            this.rdbCal.TabStop = true;
            this.rdbCal.Text = "Calificación";
            this.rdbCal.UseVisualStyleBackColor = true;
            // 
            // dgvConCal
            // 
            this.dgvConCal.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvConCal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConCal.Location = new System.Drawing.Point(12, 270);
            this.dgvConCal.Name = "dgvConCal";
            this.dgvConCal.Size = new System.Drawing.Size(477, 63);
            this.dgvConCal.TabIndex = 15;
            // 
            // FrmConCal10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(501, 345);
            this.ControlBox = false;
            this.Controls.Add(this.dgvConCal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblCal);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConCal10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConCal10";
            this.Load += new System.EventHandler(this.FrmConCal10_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConCal)).EndInit();
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
        private System.Windows.Forms.Label lblCal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbAprobado;
        private System.Windows.Forms.RadioButton rdbID_Cal;
        private System.Windows.Forms.RadioButton rdbID_est;
        private System.Windows.Forms.RadioButton rdbID_Taller;
        private System.Windows.Forms.RadioButton rdbCal;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.DataGridView dgvConCal;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblCriterio;
    }
}