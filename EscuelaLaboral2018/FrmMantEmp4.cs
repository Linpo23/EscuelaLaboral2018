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
    public partial class FrmMantEmp4 : Form
    {  //defino variables globales 
        SqlCommand Comando = new SqlCommand();
        SqlConnection Conexion = new SqlConnection("Data Source=POLI-PC\\SQLEXPRESS; initial catalog=Escuela_Laboral2018; trusted_connection=yes");

        public FrmMantEmp4()
        {
            InitializeComponent();
        }
        private void RefrescarTabla()
        {
            dgvEmpleado.DataSource = null;
                    try
            {
                Conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Empleado ", Conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvEmpleado.DataSource = FuenteDatos;
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

        private void FrmMantEmp4_Load(object sender, EventArgs e)
        {
            {
                mskFe4.Text = DateTime.Now.ToShortDateString();
                RefrescarTabla();
            }
        }

        private void dgvEmpleado_Click(object sender, EventArgs e)
        {
            txtIDEmp.Text = dgvEmpleado[0, dgvEmpleado.SelectedCells[0].RowIndex].Value.ToString();
            txtNombre_usuario.Text = dgvEmpleado[1, dgvEmpleado.SelectedCells[0].RowIndex].Value.ToString();
            txtNombre.Text = dgvEmpleado[2, dgvEmpleado.SelectedCells[0].RowIndex].Value.ToString();
            txtIdenTipo.Text = dgvEmpleado[3, dgvEmpleado.SelectedCells[0].RowIndex].Value.ToString();
            txtIdent.Text = dgvEmpleado[4, dgvEmpleado.SelectedCells[0].RowIndex].Value.ToString();
            txtCargo.Text = dgvEmpleado[5, dgvEmpleado.SelectedCells[0].RowIndex].Value.ToString();
            mskTel.Text = dgvEmpleado[6, dgvEmpleado.SelectedCells[0].RowIndex].Value.ToString();
            mskMóvil.Text = dgvEmpleado[7, dgvEmpleado.SelectedCells[0].RowIndex].Value.ToString();
            txtDirec.Text = dgvEmpleado[8, dgvEmpleado.SelectedCells[0].RowIndex].Value.ToString();
            txtSexo.Text = dgvEmpleado[9, dgvEmpleado.SelectedCells[0].RowIndex].Value.ToString();
            txtContraseña.Text = dgvEmpleado[10, dgvEmpleado.SelectedCells[0].RowIndex].Value.ToString();
            txtTipoUs.Text = dgvEmpleado[11, dgvEmpleado.SelectedCells[0].RowIndex].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
