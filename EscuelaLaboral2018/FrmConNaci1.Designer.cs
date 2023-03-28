namespace EscuelaLaboral2018
{
    partial class FrmConNaci1
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
            this.lblConsulta = new System.Windows.Forms.Label();
            this.grbNac = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.rdbID_Nac = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.btnRet = new System.Windows.Forms.Button();
            this.btnLim = new System.Windows.Forms.Button();
            this.btnBor = new System.Windows.Forms.Button();
            this.btnGua = new System.Windows.Forms.Button();
            this.dgvNacio = new System.Windows.Forms.DataGridView();
            this.grbIns.SuspendLayout();
            this.grbFecha.SuspendLayout();
            this.grbNac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNacio)).BeginInit();
            this.SuspendLayout();
            // 
            // grbIns
            // 
            this.grbIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grbIns.Controls.Add(this.lbl2);
            this.grbIns.Controls.Add(this.lblPoli2);
            this.grbIns.Location = new System.Drawing.Point(9, 6);
            this.grbIns.Name = "grbIns";
            this.grbIns.Size = new System.Drawing.Size(271, 61);
            this.grbIns.TabIndex = 8;
            this.grbIns.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(47, 39);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(169, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Av. Salvador,Estrella Sadhalá #60";
            // 
            // lblPoli2
            // 
            this.lblPoli2.AutoSize = true;
            this.lblPoli2.Location = new System.Drawing.Point(6, 16);
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
            this.grbFecha.Location = new System.Drawing.Point(350, 6);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(163, 70);
            this.grbFecha.TabIndex = 10;
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
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(171, 92);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(246, 24);
            this.lblConsulta.TabIndex = 11;
            this.lblConsulta.Text = "Consulta de nacionalidad";
            // 
            // grbNac
            // 
            this.grbNac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grbNac.Controls.Add(this.txtBusqueda);
            this.grbNac.Controls.Add(this.lblCriterio);
            this.grbNac.Controls.Add(this.rdbID_Nac);
            this.grbNac.Controls.Add(this.rdbNombre);
            this.grbNac.Controls.Add(this.btnRet);
            this.grbNac.Controls.Add(this.btnLim);
            this.grbNac.Controls.Add(this.btnBor);
            this.grbNac.Controls.Add(this.btnGua);
            this.grbNac.Location = new System.Drawing.Point(12, 130);
            this.grbNac.Name = "grbNac";
            this.grbNac.Size = new System.Drawing.Size(501, 87);
            this.grbNac.TabIndex = 12;
            this.grbNac.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(177, 13);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 50;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(29, 16);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(133, 13);
            this.lblCriterio.TabIndex = 49;
            this.lblCriterio.Text = "Digite criterio de busqueda";
            // 
            // rdbID_Nac
            // 
            this.rdbID_Nac.AutoSize = true;
            this.rdbID_Nac.Location = new System.Drawing.Point(47, 56);
            this.rdbID_Nac.Name = "rdbID_Nac";
            this.rdbID_Nac.Size = new System.Drawing.Size(104, 17);
            this.rdbID_Nac.TabIndex = 11;
            this.rdbID_Nac.TabStop = true;
            this.rdbID_Nac.Text = "ID_Nacionalidad";
            this.rdbID_Nac.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(186, 56);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(62, 17);
            this.rdbNombre.TabIndex = 10;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // btnRet
            // 
            this.btnRet.Location = new System.Drawing.Point(409, 46);
            this.btnRet.Name = "btnRet";
            this.btnRet.Size = new System.Drawing.Size(75, 23);
            this.btnRet.TabIndex = 9;
            this.btnRet.Text = "Retornar";
            this.btnRet.UseVisualStyleBackColor = true;
            this.btnRet.Click += new System.EventHandler(this.btnRet_Click);
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(301, 46);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(75, 23);
            this.btnLim.TabIndex = 8;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
            // 
            // btnBor
            // 
            this.btnBor.Location = new System.Drawing.Point(411, 13);
            this.btnBor.Name = "btnBor";
            this.btnBor.Size = new System.Drawing.Size(75, 23);
            this.btnBor.TabIndex = 7;
            this.btnBor.Text = "Borrar";
            this.btnBor.UseVisualStyleBackColor = true;
            // 
            // btnGua
            // 
            this.btnGua.Location = new System.Drawing.Point(301, 13);
            this.btnGua.Name = "btnGua";
            this.btnGua.Size = new System.Drawing.Size(75, 23);
            this.btnGua.TabIndex = 6;
            this.btnGua.Text = "Guardar";
            this.btnGua.UseVisualStyleBackColor = true;
            // 
            // dgvNacio
            // 
            this.dgvNacio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvNacio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNacio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvNacio.Location = new System.Drawing.Point(9, 223);
            this.dgvNacio.Name = "dgvNacio";
            this.dgvNacio.Size = new System.Drawing.Size(528, 64);
            this.dgvNacio.TabIndex = 13;
            // 
            // FrmConNaci1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(542, 299);
            this.ControlBox = false;
            this.Controls.Add(this.dgvNacio);
            this.Controls.Add(this.grbNac);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.grbIns);
            this.Name = "FrmConNaci1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConNaci1";
            this.Load += new System.EventHandler(this.FrmConNaci1_Load);
            this.grbIns.ResumeLayout(false);
            this.grbIns.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            this.grbNac.ResumeLayout(false);
            this.grbNac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNacio)).EndInit();
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
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.GroupBox grbNac;
        private System.Windows.Forms.RadioButton rdbID_Nac;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.Button btnRet;
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.Button btnBor;
        private System.Windows.Forms.Button btnGua;
        private System.Windows.Forms.DataGridView dgvNacio;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblCriterio;
    }
}