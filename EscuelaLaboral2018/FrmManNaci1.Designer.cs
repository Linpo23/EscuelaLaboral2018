namespace EscuelaLaboral2018
{
    partial class FrmManNaci1
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
            this.lblFecha2 = new System.Windows.Forms.Label();
            this.lblHora2 = new System.Windows.Forms.Label();
            this.grbFecha = new System.Windows.Forms.GroupBox();
            this.mskHo1 = new System.Windows.Forms.MaskedTextBox();
            this.mskFe1 = new System.Windows.Forms.MaskedTextBox();
            this.lblMantNac = new System.Windows.Forms.Label();
            this.grbNac = new System.Windows.Forms.GroupBox();
            this.btnRet = new System.Windows.Forms.Button();
            this.btnLim = new System.Windows.Forms.Button();
            this.btnBor = new System.Windows.Forms.Button();
            this.btnGua = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNac = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNac = new System.Windows.Forms.TextBox();
            this.dgvNac = new System.Windows.Forms.DataGridView();
            this.grbIns.SuspendLayout();
            this.grbFecha.SuspendLayout();
            this.grbNac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNac)).BeginInit();
            this.SuspendLayout();
            // 
            // grbIns
            // 
            this.grbIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grbIns.Controls.Add(this.lbl2);
            this.grbIns.Controls.Add(this.lblPoli2);
            this.grbIns.Location = new System.Drawing.Point(12, 12);
            this.grbIns.Name = "grbIns";
            this.grbIns.Size = new System.Drawing.Size(314, 72);
            this.grbIns.TabIndex = 2;
            this.grbIns.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(64, 52);
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
            // lblFecha2
            // 
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.Location = new System.Drawing.Point(50, 22);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(37, 13);
            this.lblFecha2.TabIndex = 1;
            this.lblFecha2.Text = "Fecha";
            // 
            // lblHora2
            // 
            this.lblHora2.AutoSize = true;
            this.lblHora2.Location = new System.Drawing.Point(50, 53);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(30, 13);
            this.lblHora2.TabIndex = 3;
            this.lblHora2.Text = "Hora";
            // 
            // grbFecha
            // 
            this.grbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grbFecha.Controls.Add(this.mskHo1);
            this.grbFecha.Controls.Add(this.mskFe1);
            this.grbFecha.Controls.Add(this.lblHora2);
            this.grbFecha.Controls.Add(this.lblFecha2);
            this.grbFecha.Location = new System.Drawing.Point(410, 12);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(185, 79);
            this.grbFecha.TabIndex = 4;
            this.grbFecha.TabStop = false;
            // 
            // mskHo1
            // 
            this.mskHo1.Location = new System.Drawing.Point(96, 50);
            this.mskHo1.Mask = "00:00";
            this.mskHo1.Name = "mskHo1";
            this.mskHo1.Size = new System.Drawing.Size(32, 20);
            this.mskHo1.TabIndex = 6;
            this.mskHo1.ValidatingType = typeof(System.DateTime);
            // 
            // mskFe1
            // 
            this.mskFe1.Location = new System.Drawing.Point(93, 19);
            this.mskFe1.Mask = "00/00/0000";
            this.mskFe1.Name = "mskFe1";
            this.mskFe1.Size = new System.Drawing.Size(70, 20);
            this.mskFe1.TabIndex = 5;
            this.mskFe1.ValidatingType = typeof(System.DateTime);
            // 
            // lblMantNac
            // 
            this.lblMantNac.AutoSize = true;
            this.lblMantNac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMantNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantNac.Location = new System.Drawing.Point(167, 116);
            this.lblMantNac.Name = "lblMantNac";
            this.lblMantNac.Size = new System.Drawing.Size(310, 25);
            this.lblMantNac.TabIndex = 5;
            this.lblMantNac.Text = "Mantenimiento Nacionalidad";
            // 
            // grbNac
            // 
            this.grbNac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grbNac.Controls.Add(this.btnRet);
            this.grbNac.Controls.Add(this.btnLim);
            this.grbNac.Controls.Add(this.btnBor);
            this.grbNac.Controls.Add(this.btnGua);
            this.grbNac.Controls.Add(this.lblNom);
            this.grbNac.Controls.Add(this.lblNac);
            this.grbNac.Controls.Add(this.txtNom);
            this.grbNac.Controls.Add(this.txtNac);
            this.grbNac.Location = new System.Drawing.Point(134, 159);
            this.grbNac.Name = "grbNac";
            this.grbNac.Size = new System.Drawing.Size(363, 130);
            this.grbNac.TabIndex = 6;
            this.grbNac.TabStop = false;
            // 
            // btnRet
            // 
            this.btnRet.Location = new System.Drawing.Point(254, 101);
            this.btnRet.Name = "btnRet";
            this.btnRet.Size = new System.Drawing.Size(75, 23);
            this.btnRet.TabIndex = 9;
            this.btnRet.Text = "Retornar";
            this.btnRet.UseVisualStyleBackColor = true;
            this.btnRet.Click += new System.EventHandler(this.btnRet_Click);
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(254, 45);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(75, 23);
            this.btnLim.TabIndex = 8;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // btnBor
            // 
            this.btnBor.Location = new System.Drawing.Point(254, 72);
            this.btnBor.Name = "btnBor";
            this.btnBor.Size = new System.Drawing.Size(75, 23);
            this.btnBor.TabIndex = 7;
            this.btnBor.Text = "Borrar";
            this.btnBor.UseVisualStyleBackColor = true;
            this.btnBor.Click += new System.EventHandler(this.btnBor_Click);
            // 
            // btnGua
            // 
            this.btnGua.Location = new System.Drawing.Point(254, 16);
            this.btnGua.Name = "btnGua";
            this.btnGua.Size = new System.Drawing.Size(75, 23);
            this.btnGua.TabIndex = 6;
            this.btnGua.Text = "Guardar";
            this.btnGua.UseVisualStyleBackColor = true;
            this.btnGua.Click += new System.EventHandler(this.btnGua_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(35, 57);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nombre";
            // 
            // lblNac
            // 
            this.lblNac.AutoSize = true;
            this.lblNac.Location = new System.Drawing.Point(19, 26);
            this.lblNac.Name = "lblNac";
            this.lblNac.Size = new System.Drawing.Size(83, 13);
            this.lblNac.TabIndex = 5;
            this.lblNac.Text = "ID Nacionalidad";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(108, 59);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 4;
            // 
            // txtNac
            // 
            this.txtNac.Location = new System.Drawing.Point(108, 23);
            this.txtNac.Name = "txtNac";
            this.txtNac.Size = new System.Drawing.Size(100, 20);
            this.txtNac.TabIndex = 5;
            // 
            // dgvNac
            // 
            this.dgvNac.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvNac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNac.Location = new System.Drawing.Point(13, 305);
            this.dgvNac.Name = "dgvNac";
            this.dgvNac.Size = new System.Drawing.Size(582, 108);
            this.dgvNac.TabIndex = 7;
            this.dgvNac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNac_CellContentClick);
            this.dgvNac.Click += new System.EventHandler(this.dgvNac_Click);
            // 
            // FrmManNaci1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(613, 425);
            this.ControlBox = false;
            this.Controls.Add(this.dgvNac);
            this.Controls.Add(this.grbNac);
            this.Controls.Add(this.lblMantNac);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.grbIns);
            this.Name = "FrmManNaci1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManNaci1";
            this.Activated += new System.EventHandler(this.FrmManNaci1_Activated);
            this.Load += new System.EventHandler(this.FrmManNaci1_Load);
            this.grbIns.ResumeLayout(false);
            this.grbIns.PerformLayout();
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            this.grbNac.ResumeLayout(false);
            this.grbNac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbIns;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblPoli2;
        private System.Windows.Forms.Label lblFecha2;
        private System.Windows.Forms.Label lblHora2;
        private System.Windows.Forms.GroupBox grbFecha;
        private System.Windows.Forms.Label lblMantNac;
        private System.Windows.Forms.GroupBox grbNac;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNac;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNac;
        private System.Windows.Forms.Button btnGua;
        private System.Windows.Forms.Button btnRet;
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.Button btnBor;
        private System.Windows.Forms.DataGridView dgvNac;
        private System.Windows.Forms.MaskedTextBox mskHo1;
        private System.Windows.Forms.MaskedTextBox mskFe1;
    }
}