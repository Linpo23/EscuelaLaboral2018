namespace EscuelaLaboral2018
{
    partial class FrmConsEdif5
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
            this.grbEdi = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.rdbCant = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbID_id = new System.Windows.Forms.RadioButton();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblConsulEdi = new System.Windows.Forms.Label();
            this.dgvEdif = new System.Windows.Forms.DataGridView();
            this.grbIns.SuspendLayout();
            this.grbFecha.SuspendLayout();
            this.grbEdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdif)).BeginInit();
            this.SuspendLayout();
            // 
            // grbIns
            // 
            this.grbIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grbIns.Controls.Add(this.lbl2);
            this.grbIns.Controls.Add(this.lblPoli2);
            this.grbIns.Location = new System.Drawing.Point(12, 5);
            this.grbIns.Name = "grbIns";
            this.grbIns.Size = new System.Drawing.Size(282, 72);
            this.grbIns.TabIndex = 6;
            this.grbIns.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(65, 48);
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
            this.grbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grbFecha.Controls.Add(this.maskedTextBox2);
            this.grbFecha.Controls.Add(this.mskFe4);
            this.grbFecha.Controls.Add(this.lblHora2);
            this.grbFecha.Controls.Add(this.lblFecha2);
            this.grbFecha.Location = new System.Drawing.Point(364, 5);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(162, 79);
            this.grbFecha.TabIndex = 8;
            this.grbFecha.TabStop = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(67, 48);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBox2.TabIndex = 5;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // mskFe4
            // 
            this.mskFe4.Location = new System.Drawing.Point(67, 16);
            this.mskFe4.Mask = "00/00/0000";
            this.mskFe4.Name = "mskFe4";
            this.mskFe4.Size = new System.Drawing.Size(65, 20);
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
            this.lblFecha2.Location = new System.Drawing.Point(24, 19);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(37, 13);
            this.lblFecha2.TabIndex = 1;
            this.lblFecha2.Text = "Fecha";
            // 
            // grbEdi
            // 
            this.grbEdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grbEdi.Controls.Add(this.txtBusqueda);
            this.grbEdi.Controls.Add(this.lblCriterio);
            this.grbEdi.Controls.Add(this.rdbCant);
            this.grbEdi.Controls.Add(this.rdbNombre);
            this.grbEdi.Controls.Add(this.rdbID_id);
            this.grbEdi.Controls.Add(this.btnRetornar);
            this.grbEdi.Controls.Add(this.btnBorrar);
            this.grbEdi.Controls.Add(this.btnlimp);
            this.grbEdi.Controls.Add(this.btnGuardar);
            this.grbEdi.Location = new System.Drawing.Point(89, 155);
            this.grbEdi.Name = "grbEdi";
            this.grbEdi.Size = new System.Drawing.Size(394, 117);
            this.grbEdi.TabIndex = 15;
            this.grbEdi.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(178, 19);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 52;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(18, 29);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(133, 13);
            this.lblCriterio.TabIndex = 51;
            this.lblCriterio.Text = "Digite criterio de busqueda";
            // 
            // rdbCant
            // 
            this.rdbCant.AutoSize = true;
            this.rdbCant.Location = new System.Drawing.Point(248, 56);
            this.rdbCant.Name = "rdbCant";
            this.rdbCant.Size = new System.Drawing.Size(116, 17);
            this.rdbCant.TabIndex = 44;
            this.rdbCant.TabStop = true;
            this.rdbCant.Text = "Cantidad_de_aulas";
            this.rdbCant.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(135, 56);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(62, 17);
            this.rdbNombre.TabIndex = 43;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // rdbID_id
            // 
            this.rdbID_id.AutoSize = true;
            this.rdbID_id.Location = new System.Drawing.Point(29, 56);
            this.rdbID_id.Name = "rdbID_id";
            this.rdbID_id.Size = new System.Drawing.Size(78, 17);
            this.rdbID_id.TabIndex = 42;
            this.rdbID_id.TabStop = true;
            this.rdbID_id.Text = "ID_Edifício";
            this.rdbID_id.UseVisualStyleBackColor = true;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(302, 79);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(62, 24);
            this.btnRetornar.TabIndex = 38;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(216, 79);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(62, 23);
            this.btnBorrar.TabIndex = 37;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnlimp
            // 
            this.btnlimp.Location = new System.Drawing.Point(128, 81);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(61, 23);
            this.btnlimp.TabIndex = 35;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(29, 79);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 25);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblConsulEdi
            // 
            this.lblConsulEdi.AutoSize = true;
            this.lblConsulEdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblConsulEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulEdi.Location = new System.Drawing.Point(197, 107);
            this.lblConsulEdi.Name = "lblConsulEdi";
            this.lblConsulEdi.Size = new System.Drawing.Size(196, 24);
            this.lblConsulEdi.TabIndex = 16;
            this.lblConsulEdi.Text = "Consulta de Edifício";
            // 
            // dgvEdif
            // 
            this.dgvEdif.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvEdif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdif.Location = new System.Drawing.Point(58, 294);
            this.dgvEdif.Name = "dgvEdif";
            this.dgvEdif.Size = new System.Drawing.Size(450, 83);
            this.dgvEdif.TabIndex = 17;
            // 
            // FrmConsEdif5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(535, 389);
            this.ControlBox = false;
            this.Controls.Add(this.dgvEdif);
            this.Controls.Add(this.lblConsulEdi);
            this.Controls.Add(this.grbEdi);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.grbIns);
            this.Name = "FrmConsEdif5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsEdif5";
            this.Load += new System.EventHandler(this.FrmConsEdif5_Load);
            this.grbIns.ResumeLayout(false);
            this.grbIns.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            this.grbEdi.ResumeLayout(false);
            this.grbEdi.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbEdi;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblConsulEdi;
        private System.Windows.Forms.RadioButton rdbCant;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbID_id;
        private System.Windows.Forms.DataGridView dgvEdif;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblCriterio;
    }
}