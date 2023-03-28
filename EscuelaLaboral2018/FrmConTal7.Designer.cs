namespace EscuelaLaboral2018
{
    partial class FrmConTal7
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
            this.lblTaller = new System.Windows.Forms.Label();
            this.grbIns = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblPoli2 = new System.Windows.Forms.Label();
            this.grbFecha = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.mskFe4 = new System.Windows.Forms.MaskedTextBox();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.grbTaller = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.rdbID_Taller = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.rdbNivel = new System.Windows.Forms.RadioButton();
            this.rdbApor = new System.Windows.Forms.RadioButton();
            this.rdbCan_Max = new System.Windows.Forms.RadioButton();
            this.rdbCant_Min = new System.Windows.Forms.RadioButton();
            this.rdbHoras = new System.Windows.Forms.RadioButton();
            this.rdbDoc_req = new System.Windows.Forms.RadioButton();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvTaller = new System.Windows.Forms.DataGridView();
            this.grbIns.SuspendLayout();
            this.grbFecha.SuspendLayout();
            this.grbTaller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaller)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaller
            // 
            this.lblTaller.AutoSize = true;
            this.lblTaller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaller.Location = new System.Drawing.Point(159, 98);
            this.lblTaller.Name = "lblTaller";
            this.lblTaller.Size = new System.Drawing.Size(172, 24);
            this.lblTaller.TabIndex = 12;
            this.lblTaller.Text = "Consulta de taller";
            // 
            // grbIns
            // 
            this.grbIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grbIns.Controls.Add(this.lbl2);
            this.grbIns.Controls.Add(this.lblPoli2);
            this.grbIns.Location = new System.Drawing.Point(12, 12);
            this.grbIns.Name = "grbIns";
            this.grbIns.Size = new System.Drawing.Size(271, 61);
            this.grbIns.TabIndex = 13;
            this.grbIns.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(63, 41);
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
            this.grbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grbFecha.Controls.Add(this.maskedTextBox2);
            this.grbFecha.Controls.Add(this.mskFe4);
            this.grbFecha.Controls.Add(this.lblHora2);
            this.grbFecha.Controls.Add(this.lblFecha2);
            this.grbFecha.Location = new System.Drawing.Point(308, 12);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(163, 70);
            this.grbFecha.TabIndex = 14;
            this.grbFecha.TabStop = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(73, 39);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(61, 20);
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
            this.lblHora2.Location = new System.Drawing.Point(24, 42);
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
            // grbTaller
            // 
            this.grbTaller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grbTaller.Controls.Add(this.txtBusqueda);
            this.grbTaller.Controls.Add(this.rdbID_Taller);
            this.grbTaller.Controls.Add(this.rdbNombre);
            this.grbTaller.Controls.Add(this.lblCriterio);
            this.grbTaller.Controls.Add(this.rdbNivel);
            this.grbTaller.Controls.Add(this.rdbApor);
            this.grbTaller.Controls.Add(this.rdbCan_Max);
            this.grbTaller.Controls.Add(this.rdbCant_Min);
            this.grbTaller.Controls.Add(this.rdbHoras);
            this.grbTaller.Controls.Add(this.rdbDoc_req);
            this.grbTaller.Controls.Add(this.btnRetornar);
            this.grbTaller.Controls.Add(this.btnBorrar);
            this.grbTaller.Controls.Add(this.btnlimp);
            this.grbTaller.Controls.Add(this.btnGuardar);
            this.grbTaller.Location = new System.Drawing.Point(68, 134);
            this.grbTaller.Name = "grbTaller";
            this.grbTaller.Size = new System.Drawing.Size(374, 161);
            this.grbTaller.TabIndex = 15;
            this.grbTaller.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(163, 20);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 52;
            // 
            // rdbID_Taller
            // 
            this.rdbID_Taller.AutoSize = true;
            this.rdbID_Taller.Location = new System.Drawing.Point(35, 75);
            this.rdbID_Taller.Name = "rdbID_Taller";
            this.rdbID_Taller.Size = new System.Drawing.Size(68, 17);
            this.rdbID_Taller.TabIndex = 48;
            this.rdbID_Taller.TabStop = true;
            this.rdbID_Taller.Text = "ID_Taller";
            this.rdbID_Taller.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(35, 98);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(62, 17);
            this.rdbNombre.TabIndex = 47;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(23, 27);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(133, 13);
            this.lblCriterio.TabIndex = 51;
            this.lblCriterio.Text = "Digite criterio de busqueda";
            // 
            // rdbNivel
            // 
            this.rdbNivel.AutoSize = true;
            this.rdbNivel.Location = new System.Drawing.Point(127, 98);
            this.rdbNivel.Name = "rdbNivel";
            this.rdbNivel.Size = new System.Drawing.Size(49, 17);
            this.rdbNivel.TabIndex = 46;
            this.rdbNivel.TabStop = true;
            this.rdbNivel.Text = "Nivel";
            this.rdbNivel.UseVisualStyleBackColor = true;
            // 
            // rdbApor
            // 
            this.rdbApor.AutoSize = true;
            this.rdbApor.Location = new System.Drawing.Point(130, 75);
            this.rdbApor.Name = "rdbApor";
            this.rdbApor.Size = new System.Drawing.Size(56, 17);
            this.rdbApor.TabIndex = 45;
            this.rdbApor.TabStop = true;
            this.rdbApor.Text = "Aporte";
            this.rdbApor.UseVisualStyleBackColor = true;
            // 
            // rdbCan_Max
            // 
            this.rdbCan_Max.AutoSize = true;
            this.rdbCan_Max.Location = new System.Drawing.Point(219, 98);
            this.rdbCan_Max.Name = "rdbCan_Max";
            this.rdbCan_Max.Size = new System.Drawing.Size(109, 17);
            this.rdbCan_Max.TabIndex = 44;
            this.rdbCan_Max.TabStop = true;
            this.rdbCan_Max.Text = "Cantidad_Máximo";
            this.rdbCan_Max.UseVisualStyleBackColor = true;
            // 
            // rdbCant_Min
            // 
            this.rdbCant_Min.AutoSize = true;
            this.rdbCant_Min.Location = new System.Drawing.Point(220, 75);
            this.rdbCant_Min.Name = "rdbCant_Min";
            this.rdbCant_Min.Size = new System.Drawing.Size(108, 17);
            this.rdbCant_Min.TabIndex = 43;
            this.rdbCant_Min.TabStop = true;
            this.rdbCant_Min.Text = "Cantidad_Mínima";
            this.rdbCant_Min.UseVisualStyleBackColor = true;
            // 
            // rdbHoras
            // 
            this.rdbHoras.AutoSize = true;
            this.rdbHoras.Location = new System.Drawing.Point(130, 52);
            this.rdbHoras.Name = "rdbHoras";
            this.rdbHoras.Size = new System.Drawing.Size(53, 17);
            this.rdbHoras.TabIndex = 42;
            this.rdbHoras.TabStop = true;
            this.rdbHoras.Text = "Horas";
            this.rdbHoras.UseVisualStyleBackColor = true;
            // 
            // rdbDoc_req
            // 
            this.rdbDoc_req.AutoSize = true;
            this.rdbDoc_req.Location = new System.Drawing.Point(219, 52);
            this.rdbDoc_req.Name = "rdbDoc_req";
            this.rdbDoc_req.Size = new System.Drawing.Size(140, 17);
            this.rdbDoc_req.TabIndex = 41;
            this.rdbDoc_req.TabStop = true;
            this.rdbDoc_req.Text = "Documentos_requeridos";
            this.rdbDoc_req.UseVisualStyleBackColor = true;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(271, 129);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(57, 24);
            this.btnRetornar.TabIndex = 40;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(194, 131);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(57, 23);
            this.btnBorrar.TabIndex = 39;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(116, 130);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(56, 23);
            this.btnlimp.TabIndex = 37;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(35, 130);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 25);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgvTaller
            // 
            this.dgvTaller.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvTaller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaller.Location = new System.Drawing.Point(23, 312);
            this.dgvTaller.Name = "dgvTaller";
            this.dgvTaller.Size = new System.Drawing.Size(431, 90);
            this.dgvTaller.TabIndex = 16;
            // 
            // FrmConTal7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(484, 414);
            this.ControlBox = false;
            this.Controls.Add(this.dgvTaller);
            this.Controls.Add(this.grbTaller);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.grbIns);
            this.Controls.Add(this.lblTaller);
            this.Name = "FrmConTal7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConTal7";
            this.Load += new System.EventHandler(this.FrmConTal7_Load);
            this.grbIns.ResumeLayout(false);
            this.grbIns.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            this.grbTaller.ResumeLayout(false);
            this.grbTaller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaller;
        private System.Windows.Forms.GroupBox grbIns;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblPoli2;
        private System.Windows.Forms.GroupBox grbFecha;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox mskFe4;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.GroupBox grbTaller;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rdbID_Taller;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbNivel;
        private System.Windows.Forms.RadioButton rdbApor;
        private System.Windows.Forms.RadioButton rdbCan_Max;
        private System.Windows.Forms.RadioButton rdbCant_Min;
        private System.Windows.Forms.RadioButton rdbHoras;
        private System.Windows.Forms.RadioButton rdbDoc_req;
        private System.Windows.Forms.DataGridView dgvTaller;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblCriterio;
    }
}