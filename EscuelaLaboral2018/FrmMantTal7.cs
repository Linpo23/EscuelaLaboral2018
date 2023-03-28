using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;  //Para trabajar con SQL
using System.Threading;
using System.Globalization;

namespace EscuelaLaboral2018
{
    public partial class FrmMantTal7 : Form
    { //defino variables globales 
        SqlCommand Comando = new SqlCommand();
        SqlConnection Conexion = new SqlConnection("Data Source=POLI-PC\\SQLEXPRESS; initial catalog=Escuela_Laboral2018; trusted_connection=yes");

        public FrmMantTal7()
        {
            InitializeComponent();
        }
        private void RefrescarTabla()
        {
            dgvTaller.DataSource = null;
                    try
            {
                Conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Taller ", Conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvTaller.DataSource = FuenteDatos;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error,   
                MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Conexion.Close();
            }

        }


        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMantTal7_Load(object sender, EventArgs e)
        {
            {
                mskFe4.Text = DateTime.Now.ToShortDateString();
                RefrescarTabla();
            }
        }

        private void dgvTaller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTaller_Click(object sender, EventArgs e)
        {
            txtTaller.Text = dgvTaller[0, dgvTaller.SelectedCells[0].RowIndex].Value.ToString();
            txtNom.Text = dgvTaller[1, dgvTaller.SelectedCells[0].RowIndex].Value.ToString();
            txtNivel.Text = dgvTaller[2, dgvTaller.SelectedCells[0].RowIndex].Value.ToString();
            txtCan_Max.Text = dgvTaller[3, dgvTaller.SelectedCells[0].RowIndex].Value.ToString();
            txtCant_Min.Text = dgvTaller[4, dgvTaller.SelectedCells[0].RowIndex].Value.ToString();
            txtHoras.Text = dgvTaller[5, dgvTaller.SelectedCells[0].RowIndex].Value.ToString();
            txtDoc_Req.Text = dgvTaller[6, dgvTaller.SelectedCells[0].RowIndex].Value.ToString();
            txtAporte.Text = dgvTaller[7, dgvTaller.SelectedCells[0].RowIndex].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
