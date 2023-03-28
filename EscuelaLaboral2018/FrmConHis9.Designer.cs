namespace EscuelaLaboral2018
{
    partial class FrmConHis9
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
            this.lblCon = new System.Windows.Forms.Label();
            this.grbConsul = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.rdbID_Est = new System.Windows.Forms.RadioButton();
            this.rdbId_Taller = new System.Windows.Forms.RadioButton();
            this.rdbPeríodo = new System.Windows.Forms.RadioButton();
            this.rdbId_His = new System.Windows.Forms.RadioButton();
            this.dgvHisto = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.grbFecha.SuspendLayout();
            this.grbConsul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.grbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbFecha.Controls.Add(this.mskHo3);
            this.grbFecha.Controls.Add(this.mskFe3);
            this.grbFecha.Controls.Add(this.lblHora2);
            this.grbFecha.Controls.Add(this.lblFecha2);
            this.grbFecha.Location = new System.Drawing.Point(392, 12);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(135, 72);
            this.grbFecha.TabIndex = 11;
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
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.BackColor = System.Drawing.Color.LightGray;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(145, 97);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(298, 24);
            this.lblCon.TabIndex = 12;
            this.lblCon.Text = "Consulta de historial de pagos ";
            // 
            // grbConsul
            // 
            this.grbConsul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbConsul.Controls.Add(this.txtBusqueda);
            this.grbConsul.Controls.Add(this.lblCriterio);
            this.grbConsul.Controls.Add(this.btnRetornar);
            this.grbConsul.Controls.Add(this.btnBorrar);
            this.grbConsul.Controls.Add(this.btnGuardar);
            this.grbConsul.Controls.Add(this.btnlimp);
            this.grbConsul.Controls.Add(this.rdbID_Est);
            this.grbConsul.Controls.Add(this.rdbId_Taller);
            this.grbConsul.Controls.Add(this.rdbPeríodo);
            this.grbConsul.Controls.Add(this.rdbId_His);
            this.grbConsul.Location = new System.Drawing.Point(38, 139);
            this.grbConsul.Name = "grbConsul";
            this.grbConsul.Size = new System.Drawing.Size(450, 122);
            this.grbConsul.TabIndex = 13;
            this.grbConsul.TabStop = false;
            this.grbConsul.Enter += new System.EventHandler(this.grbConsul_Enter);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(146, 23);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 50;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(10, 26);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(133, 13);
            this.lblCriterio.TabIndex = 49;
            this.lblCriterio.Text = "Digite criterio de busqueda";
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(354, 83);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(75, 23);
            this.btnRetornar.TabIndex = 18;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(252, 83);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(252, 50);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(354, 50);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(75, 23);
            this.btnlimp.TabIndex = 15;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // rdbID_Est
            // 
            this.rdbID_Est.AutoSize = true;
            this.rdbID_Est.Location = new System.Drawing.Point(27, 83);
            this.rdbID_Est.Name = "rdbID_Est";
            this.rdbID_Est.Size = new System.Drawing.Size(92, 17);
            this.rdbID_Est.TabIndex = 3;
            this.rdbID_Est.TabStop = true;
            this.rdbID_Est.Text = "ID_Estudiante";
            this.rdbID_Est.UseVisualStyleBackColor = true;
            // 
            // rdbId_Taller
            // 
            this.rdbId_Taller.AutoSize = true;
            this.rdbId_Taller.Location = new System.Drawing.Point(154, 60);
            this.rdbId_Taller.Name = "rdbId_Taller";
            this.rdbId_Taller.Size = new System.Drawing.Size(68, 17);
            this.rdbId_Taller.TabIndex = 2;
            this.rdbId_Taller.TabStop = true;
            this.rdbId_Taller.Text = "ID_Taller";
            this.rdbId_Taller.UseVisualStyleBackColor = true;
            // 
            // rdbPeríodo
            // 
            this.rdbPeríodo.AutoSize = true;
            this.rdbPeríodo.Location = new System.Drawing.Point(154, 83);
            this.rdbPeríodo.Name = "rdbPeríodo";
            this.rdbPeríodo.Size = new System.Drawing.Size(63, 17);
            this.rdbPeríodo.TabIndex = 1;
            this.rdbPeríodo.TabStop = true;
            this.rdbPeríodo.Text = "Período";
            this.rdbPeríodo.UseVisualStyleBackColor = true;
            // 
            // rdbId_His
            // 
            this.rdbId_His.AutoSize = true;
            this.rdbId_His.Location = new System.Drawing.Point(27, 60);
            this.rdbId_His.Name = "rdbId_His";
            this.rdbId_His.Size = new System.Drawing.Size(79, 17);
            this.rdbId_His.TabIndex = 0;
            this.rdbId_His.TabStop = true;
            this.rdbId_His.Text = "ID_Historial";
            this.rdbId_His.UseVisualStyleBackColor = true;
            // 
            // dgvHisto
            // 
            this.dgvHisto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHisto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHisto.Location = new System.Drawing.Point(21, 282);
            this.dgvHisto.Name = "dgvHisto";
            this.dgvHisto.Size = new System.Drawing.Size(479, 79);
            this.dgvHisto.TabIndex = 14;
            // 
            // FrmConHis9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(540, 373);
            this.ControlBox = false;
            this.Controls.Add(this.dgvHisto);
            this.Controls.Add(this.grbConsul);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConHis9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConHis9";
            this.Load += new System.EventHandler(this.FrmConHis9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            this.grbConsul.ResumeLayout(false);
            this.grbConsul.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHisto)).EndInit();
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
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.GroupBox grbConsul;
        private System.Windows.Forms.RadioButton rdbID_Est;
        private System.Windows.Forms.RadioButton rdbId_Taller;
        private System.Windows.Forms.RadioButton rdbPeríodo;
        private System.Windows.Forms.RadioButton rdbId_His;
        private System.Windows.Forms.DataGridView dgvHisto;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblCriterio;
    }
}