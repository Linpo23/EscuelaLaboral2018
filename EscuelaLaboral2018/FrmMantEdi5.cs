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
    public partial class FrmMantEdi5 : Form
    {

         //defino variables globales 
        SqlCommand Comando = new SqlCommand();
        SqlConnection Conexion = new SqlConnection("Data Source=POLI-PC\\SQLEXPRESS; initial catalog=Escuela_Laboral2018; trusted_connection=yes");

        public FrmMantEdi5()
        {
            InitializeComponent();
        }
        private void RefrescarTabla()
        {
            dgvEdif.DataSource = null;
                    try
            {
                Conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Edifício ", Conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvEdif.DataSource = FuenteDatos;
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

        private void FrmMantEdi5_Load(object sender, EventArgs e)
        {


            {
                mskFe4.Text = DateTime.Now.ToShortDateString();
                RefrescarTabla();
            }
        }

        private void dgvEdif_Click(object sender, EventArgs e)
        {
            txtEdificio.Text = dgvEdif[0, dgvEdif.SelectedCells[0].RowIndex].Value.ToString();
            txtNombre.Text = dgvEdif[1, dgvEdif.SelectedCells[0].RowIndex].Value.ToString();
            txtCant.Text = dgvEdif[2, dgvEdif.SelectedCells[0].RowIndex].Value.ToString();
        }

        private void grbedificio_Enter(object sender, EventArgs e)
        {

        }
    }
}
