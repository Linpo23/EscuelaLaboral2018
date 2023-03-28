namespace EscuelaLaboral2018
{
    partial class FrmConPag8
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
            this.grbPago = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.rdbPol = new System.Windows.Forms.RadioButton();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.rdbMonto = new System.Windows.Forms.RadioButton();
            this.rdbDes = new System.Windows.Forms.RadioButton();
            this.rdbID_Est = new System.Windows.Forms.RadioButton();
            this.rdbNúm = new System.Windows.Forms.RadioButton();
            this.dgvPago = new System.Windows.Forms.DataGridView();
            this.lblpago = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grbFecha.SuspendLayout();
            this.grbPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 72);
            this.groupBox1.TabIndex = 6;
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
            this.grbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbFecha.Controls.Add(this.mskHo3);
            this.grbFecha.Controls.Add(this.mskFe3);
            this.grbFecha.Controls.Add(this.lblHora2);
            this.grbFecha.Controls.Add(this.lblFecha2);
            this.grbFecha.Location = new System.Drawing.Point(420, 12);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(141, 72);
            this.grbFecha.TabIndex = 11;
            this.grbFecha.TabStop = false;
            // 
            // mskHo3
            // 
            this.mskHo3.Location = new System.Drawing.Point(60, 41);
            this.mskHo3.Mask = "00:00";
            this.mskHo3.Name = "mskHo3";
            this.mskHo3.Size = new System.Drawing.Size(37, 20);
            this.mskHo3.TabIndex = 5;
            this.mskHo3.ValidatingType = typeof(System.DateTime);
            // 
            // mskFe3
            // 
            this.mskFe3.Location = new System.Drawing.Point(60, 13);
            this.mskFe3.Mask = "00/00/0000";
            this.mskFe3.Name = "mskFe3";
            this.mskFe3.Size = new System.Drawing.Size(69, 20);
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
            // grbPago
            // 
            this.grbPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grbPago.Controls.Add(this.txtBusqueda);
            this.grbPago.Controls.Add(this.lblCriterio);
            this.grbPago.Controls.Add(this.btnRetornar);
            this.grbPago.Controls.Add(this.btnBorrar);
            this.grbPago.Controls.Add(this.btnGuardar);
            this.grbPago.Controls.Add(this.btnlimp);
            this.grbPago.Controls.Add(this.radioButton7);
            this.grbPago.Controls.Add(this.rdbPol);
            this.grbPago.Controls.Add(this.rdbFecha);
            this.grbPago.Controls.Add(this.rdbMonto);
            this.grbPago.Controls.Add(this.rdbDes);
            this.grbPago.Controls.Add(this.rdbID_Est);
            this.grbPago.Controls.Add(this.rdbNúm);
            this.grbPago.Location = new System.Drawing.Point(47, 163);
            this.grbPago.Name = "grbPago";
            this.grbPago.Size = new System.Drawing.Size(470, 160);
            this.grbPago.TabIndex = 12;
            this.grbPago.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(183, 19);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 50;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(38, 22);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(133, 13);
            this.lblCriterio.TabIndex = 49;
            this.lblCriterio.Text = "Digite criterio de busqueda";
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(389, 97);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(75, 23);
            this.btnRetornar.TabIndex = 18;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(289, 97);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(289, 61);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(382, 61);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(75, 23);
            this.btnlimp.TabIndex = 15;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(176, 97);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(89, 17);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "ID_Empleado";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // rdbPol
            // 
            this.rdbPol.AutoSize = true;
            this.rdbPol.Location = new System.Drawing.Point(176, 120);
            this.rdbPol.Name = "rdbPol";
            this.rdbPol.Size = new System.Drawing.Size(77, 17);
            this.rdbPol.TabIndex = 5;
            this.rdbPol.TabStop = true;
            this.rdbPol.Text = "Politécnico";
            this.rdbPol.UseVisualStyleBackColor = true;
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Location = new System.Drawing.Point(38, 75);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(85, 17);
            this.rdbFecha.TabIndex = 4;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha_pago";
            this.rdbFecha.UseVisualStyleBackColor = true;
            // 
            // rdbMonto
            // 
            this.rdbMonto.AutoSize = true;
            this.rdbMonto.Location = new System.Drawing.Point(38, 100);
            this.rdbMonto.Name = "rdbMonto";
            this.rdbMonto.Size = new System.Drawing.Size(85, 17);
            this.rdbMonto.TabIndex = 3;
            this.rdbMonto.TabStop = true;
            this.rdbMonto.Text = "Monto_pago";
            this.rdbMonto.UseVisualStyleBackColor = true;
            // 
            // rdbDes
            // 
            this.rdbDes.AutoSize = true;
            this.rdbDes.Location = new System.Drawing.Point(176, 52);
            this.rdbDes.Name = "rdbDes";
            this.rdbDes.Size = new System.Drawing.Size(84, 17);
            this.rdbDes.TabIndex = 2;
            this.rdbDes.TabStop = true;
            this.rdbDes.Text = "Descripción ";
            this.rdbDes.UseVisualStyleBackColor = true;
            this.rdbDes.CheckedChanged += new System.EventHandler(this.rdbDes_CheckedChanged);
            // 
            // rdbID_Est
            // 
            this.rdbID_Est.AutoSize = true;
            this.rdbID_Est.Location = new System.Drawing.Point(176, 74);
            this.rdbID_Est.Name = "rdbID_Est";
            this.rdbID_Est.Size = new System.Drawing.Size(92, 17);
            this.rdbID_Est.TabIndex = 1;
            this.rdbID_Est.TabStop = true;
            this.rdbID_Est.Text = "ID_Estudiante";
            this.rdbID_Est.UseVisualStyleBackColor = true;
            // 
            // rdbNúm
            // 
            this.rdbNúm.AutoSize = true;
            this.rdbNúm.Location = new System.Drawing.Point(31, 52);
            this.rdbNúm.Name = "rdbNúm";
            this.rdbNúm.Size = new System.Drawing.Size(92, 17);
            this.rdbNúm.TabIndex = 0;
            this.rdbNúm.TabStop = true;
            this.rdbNúm.Text = "Número_pago";
            this.rdbNúm.UseVisualStyleBackColor = true;
            // 
            // dgvPago
            // 
            this.dgvPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPago.Location = new System.Drawing.Point(58, 341);
            this.dgvPago.Name = "dgvPago";
            this.dgvPago.Size = new System.Drawing.Size(459, 93);
            this.dgvPago.TabIndex = 13;
            // 
            // lblpago
            // 
            this.lblpago.AutoSize = true;
            this.lblpago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpago.Location = new System.Drawing.Point(237, 110);
            this.lblpago.Name = "lblpago";
            this.lblpago.Size = new System.Drawing.Size(174, 24);
            this.lblpago.TabIndex = 14;
            this.lblpago.Text = "Consulta de pago";
            // 
            // FrmConPag8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(571, 446);
            this.ControlBox = false;
            this.Controls.Add(this.lblpago);
            this.Controls.Add(this.dgvPago);
            this.Controls.Add(this.grbPago);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConPag8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConPag8";
            this.Load += new System.EventHandler(this.FrmConPag8_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            this.grbPago.ResumeLayout(false);
            this.grbPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPago)).EndInit();
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
        private System.Windows.Forms.GroupBox grbPago;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton rdbPol;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.RadioButton rdbMonto;
        private System.Windows.Forms.RadioButton rdbDes;
        private System.Windows.Forms.RadioButton rdbID_Est;
        private System.Windows.Forms.RadioButton rdbNúm;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.DataGridView dgvPago;
        private System.Windows.Forms.Label lblpago;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblCriterio;
    }
}