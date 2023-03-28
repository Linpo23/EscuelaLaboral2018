namespace EscuelaLaboral2018
{
    partial class FrmMantEdi5
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
            this.grbFecha = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.mskFe4 = new System.Windows.Forms.MaskedTextBox();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblMantEdi = new System.Windows.Forms.Label();
            this.lblCant_aula = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblIDEdificio = new System.Windows.Forms.Label();
            this.grbedificio = new System.Windows.Forms.GroupBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdificio = new System.Windows.Forms.TextBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvEdif = new System.Windows.Forms.DataGridView();
            this.grbIns.SuspendLayout();
            this.grbFecha.SuspendLayout();
            this.grbedificio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdif)).BeginInit();
            this.SuspendLayout();
            // 
            // grbIns
            // 
            this.grbIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grbIns.Controls.Add(this.lbl2);
            this.grbIns.Controls.Add(this.lblPoli2);
            this.grbIns.Location = new System.Drawing.Point(12, 12);
            this.grbIns.Name = "grbIns";
            this.grbIns.Size = new System.Drawing.Size(314, 72);
            this.grbIns.TabIndex = 5;
            this.grbIns.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(74, 44);
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
            // grbFecha
            // 
            this.grbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grbFecha.Controls.Add(this.maskedTextBox2);
            this.grbFecha.Controls.Add(this.mskFe4);
            this.grbFecha.Controls.Add(this.lblHora2);
            this.grbFecha.Controls.Add(this.lblFecha2);
            this.grbFecha.Location = new System.Drawing.Point(431, 12);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(141, 72);
            this.grbFecha.TabIndex = 7;
            this.grbFecha.TabStop = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(68, 46);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(39, 20);
            this.maskedTextBox2.TabIndex = 5;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // mskFe4
            // 
            this.mskFe4.Location = new System.Drawing.Point(68, 16);
            this.mskFe4.Mask = "00/00/0000";
            this.mskFe4.Name = "mskFe4";
            this.mskFe4.Size = new System.Drawing.Size(69, 20);
            this.mskFe4.TabIndex = 4;
            this.mskFe4.ValidatingType = typeof(System.DateTime);
            // 
            // lblHora2
            // 
            this.lblHora2.AutoSize = true;
            this.lblHora2.Location = new System.Drawing.Point(16, 52);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(30, 13);
            this.lblHora2.TabIndex = 3;
            this.lblHora2.Text = "Hora";
            // 
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(16, 19);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(37, 13);
            this.lblFecha2.TabIndex = 1;
            this.lblFecha2.Text = "Fecha";
            // 
            // lblMantEdi
            // 
            this.lblMantEdi.AutoSize = true;
            this.lblMantEdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMantEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantEdi.Location = new System.Drawing.Point(252, 103);
            this.lblMantEdi.Name = "lblMantEdi";
            this.lblMantEdi.Size = new System.Drawing.Size(232, 24);
            this.lblMantEdi.TabIndex = 8;
            this.lblMantEdi.Text = "Mantenimiento Edifícios";
            // 
            // lblCant_aula
            // 
            this.lblCant_aula.AutoSize = true;
            this.lblCant_aula.Location = new System.Drawing.Point(343, 37);
            this.lblCant_aula.Name = "lblCant_aula";
            this.lblCant_aula.Size = new System.Drawing.Size(92, 13);
            this.lblCant_aula.TabIndex = 10;
            this.lblCant_aula.Text = "Cantidad de aulas";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(184, 30);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 11;
            this.lblnombre.Text = "Nombre";
            // 
            // lblIDEdificio
            // 
            this.lblIDEdificio.AutoSize = true;
            this.lblIDEdificio.Location = new System.Drawing.Point(18, 30);
            this.lblIDEdificio.Name = "lblIDEdificio";
            this.lblIDEdificio.Size = new System.Drawing.Size(57, 13);
            this.lblIDEdificio.TabIndex = 12;
            this.lblIDEdificio.Text = "ID Edifício";
            // 
            // grbedificio
            // 
            this.grbedificio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grbedificio.Controls.Add(this.txtCant);
            this.grbedificio.Controls.Add(this.txtNombre);
            this.grbedificio.Controls.Add(this.txtEdificio);
            this.grbedificio.Controls.Add(this.btnRetornar);
            this.grbedificio.Controls.Add(this.btnBorrar);
            this.grbedificio.Controls.Add(this.btnlimp);
            this.grbedificio.Controls.Add(this.btnGuardar);
            this.grbedificio.Controls.Add(this.lblIDEdificio);
            this.grbedificio.Controls.Add(this.lblCant_aula);
            this.grbedificio.Controls.Add(this.lblnombre);
            this.grbedificio.Location = new System.Drawing.Point(58, 153);
            this.grbedificio.Name = "grbedificio";
            this.grbedificio.Size = new System.Drawing.Size(545, 102);
            this.grbedificio.TabIndex = 13;
            this.grbedificio.TabStop = false;
            this.grbedificio.Enter += new System.EventHandler(this.grbedificio_Enter);
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(441, 34);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(73, 20);
            this.txtCant.TabIndex = 41;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(234, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(80, 20);
            this.txtNombre.TabIndex = 40;
            // 
            // txtEdificio
            // 
            this.txtEdificio.Location = new System.Drawing.Point(81, 27);
            this.txtEdificio.Name = "txtEdificio";
            this.txtEdificio.Size = new System.Drawing.Size(100, 20);
            this.txtEdificio.TabIndex = 39;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(373, 65);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(62, 24);
            this.btnRetornar.TabIndex = 38;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(270, 67);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(62, 23);
            this.btnBorrar.TabIndex = 37;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(167, 65);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(61, 23);
            this.btnlimp.TabIndex = 35;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(67, 63);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 25);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgvEdif
            // 
            this.dgvEdif.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvEdif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdif.Location = new System.Drawing.Point(58, 279);
            this.dgvEdif.Name = "dgvEdif";
            this.dgvEdif.Size = new System.Drawing.Size(558, 77);
            this.dgvEdif.TabIndex = 14;
            this.dgvEdif.Click += new System.EventHandler(this.dgvEdif_Click);
            // 
            // FrmMantEdi5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(656, 368);
            this.ControlBox = false;
            this.Controls.Add(this.dgvEdif);
            this.Controls.Add(this.grbedificio);
            this.Controls.Add(this.lblMantEdi);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.grbIns);
            this.Name = "FrmMantEdi5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMantEdi5";
            this.Load += new System.EventHandler(this.FrmMantEdi5_Load);
            this.grbIns.ResumeLayout(false);
            this.grbIns.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            this.grbedificio.ResumeLayout(false);
            this.grbedificio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbIns;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblPoli2;
        private System.Windows.Forms.GroupBox grbFecha;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox mskFe4;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblMantEdi;
        private System.Windows.Forms.Label lblCant_aula;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblIDEdificio;
        private System.Windows.Forms.GroupBox grbedificio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdificio;
        private System.Windows.Forms.DataGridView dgvEdif;
    }
}