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
    public partial class FrmManEstu2 : Form
    {  //defino variables globales 
        SqlCommand Comando = new SqlCommand();
        SqlConnection Conexion = new SqlConnection("Data Source=POLI-PC\\SQLEXPRESS; initial catalog=Escuela_Laboral2018; trusted_connection=yes");

 
        private void RefrescarTabla()
        {
            dgvEstu.DataSource = null;
                    try
            {
                Conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Estudiante ", Conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvEstu.DataSource = FuenteDatos;
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
        public FrmManEstu2()
        {
            InitializeComponent();
        }

       

        private void FrmManEstu2_Load(object sender, EventArgs e)
        {
            {
                mskFe2.Text = DateTime.Now.ToShortDateString();
                RefrescarTabla();
            }

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grbEst_Enter(object sender, EventArgs e)
        {

        }

        private void dgvEstu_Click(object sender, EventArgs e)
        {
            txtestudiante.Text = dgvEstu[0, dgvEstu.SelectedCells[0].RowIndex].Value.ToString();
            txtNombre.Text = dgvEstu[1, dgvEstu.SelectedCells[0].RowIndex].Value.ToString();
            txtidentificación.Text = dgvEstu[2, dgvEstu.SelectedCells[0].RowIndex].Value.ToString();
            txtSexo.Text = dgvEstu[3, dgvEstu.SelectedCells[0].RowIndex].Value.ToString();
            txtdirección.Text = dgvEstu[4, dgvEstu.SelectedCells[0].RowIndex].Value.ToString();
            dtpNan.Text = dgvEstu[5, dgvEstu.SelectedCells[0].RowIndex].Value.ToString();
            pb1.Text = dgvEstu[6, dgvEstu.SelectedCells[0].RowIndex].Value.ToString();
            mskTel.Text = dgvEstu[7, dgvEstu.SelectedCells[0].RowIndex].Value.ToString();
            mskMO.Text = dgvEstu[8, dgvEstu.SelectedCells[0].RowIndex].Value.ToString();
            txtNacimiento.Text = dgvEstu[9, dgvEstu.SelectedCells[0].RowIndex].Value.ToString();
            txtAct.Text = dgvEstu[10, dgvEstu.SelectedCells[0].RowIndex].Value.ToString();
            txtNivel.Text = dgvEstu[11, dgvEstu.SelectedCells[0].RowIndex].Value.ToString();

            if (txtAct.Text == "Sí")
            {
                chkAct.Checked = true;

            }
            else 
            {
                chkAct.Checked = false;
            }
        }

        private void txtAct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtestudiante.Text == "")
                //si esta vacio
            {
                EscribirDatos("insert into Estudiante (Nombre, Identificación_tipo,Sexo,Dirección,Fecha_Nac,Teléfono,Móvil,Id_Nac,Activo,Nivel_académico) values('"+txtNombre.Text+"','"+txtidentificación.Text+"','"+txtSexo.Text+"','"+txtdirección.Text+"','"+dtpNan.Text+"','"+mskTel.Text+"','"+mskMO.Text+"','"+txtNacimiento.Text+"','"+txtAct.Text+"','"+txtNivel.Text+"')");
            }
            else
                //mofico de 
            {
                EscribirDatos("Update Estudiante set Nombre='"+txtNombre.Text+"', Identificación_tipo'"+txtidentificación.Text+"',Sexo='"+txtSexo.Text+"', Dirección='"+txtdirección.Text+"',Fecha_Nac='"+dtpNan.Text+"',Teléfono='"+mskTel.Text+"',Móvil='"+mskMO.Text+"',Id_Nac'"+txtNacimiento.Text+"',Activo='"+chkAct.Text+"',Nivel_académico='"+txtNivel.Text+"' where Id_Estudiante='" + txtestudiante.Text + "'");
            }
            RefrescarTabla();
        }
        private void EscribirDatos(string Parametro)
        {

            //Permite ejectuar las instrucciones recibidas en Parametro en la base de datos

            Comando.CommandText = Parametro;
            Conexion.Open();
            Comando.Transaction = Conexion.BeginTransaction();
            Comando.ExecuteNonQuery();
            Comando.Transaction.Commit();
            Conexion.Close();

        }

        private void FrmManEstu2_Activated(object sender, EventArgs e)
        {
            Comando.Connection = Conexion;
        }
    }
}
