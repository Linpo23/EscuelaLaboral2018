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
    public partial class FrmManProf3 : Form
    {//defino variables globales 
        SqlCommand Comando = new SqlCommand();
        SqlConnection Conexion = new SqlConnection("Data Source=POLI-PC\\SQLEXPRESS; initial catalog=Escuela_Laboral2018; trusted_connection=yes");

        public FrmManProf3()
        {
            InitializeComponent();
        }
        private void RefrescarTabla()
        {
            dgvProf.DataSource = null;
               
                try
            {
                Conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Profesor ", Conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvProf.DataSource = FuenteDatos;
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
      
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void FrmManProf3_Load(object sender, EventArgs e)
        {
            {
                mskFe3.Text = DateTime.Now.ToShortDateString();
                RefrescarTabla();
            }
        }

        private void dgvProf_Click(object sender, EventArgs e)
        {
           txtProf.Text = dgvProf[0, dgvProf.SelectedCells[0].RowIndex].Value.ToString();
           txtNom.Text = dgvProf[1, dgvProf.SelectedCells[0].RowIndex].Value.ToString();
           txtSex.Text = dgvProf[2, dgvProf.SelectedCells[0].RowIndex].Value.ToString();
           txtDir.Text = dgvProf[3, dgvProf.SelectedCells[0].RowIndex].Value.ToString();
           txttipo.Text = dgvProf[4, dgvProf.SelectedCells[0].RowIndex].Value.ToString();
           txtIden.Text = dgvProf[5, dgvProf.SelectedCells[0].RowIndex].Value.ToString();
           mksTel3.Text = dgvProf[6, dgvProf.SelectedCells[0].RowIndex].Value.ToString();
           mskMo3.Text = dgvProf[7, dgvProf.SelectedCells[0].RowIndex].Value.ToString();
           pb2.Text = dgvProf[8, dgvProf.SelectedCells[0].RowIndex].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            //si esta vacio
            {
                EscribirDatos("insert into Profesor ( Nombre,Sexo,Dirección,Identificación_tipo,Número_identificación,Teléfono,Móvil,Foto) values('" + txtNom.Text + "','"+txtSex.Text+"','"+txtDir.Text+"','"+txttipo.Text+"','"+txtIden.Text+"','"+mksTel3.Text+"','"+mskMo3.Text+")");
            }
            else
            //mofico de 
            {
                EscribirDatos("Update Profesor set Nombre='" + txtNom.Text + "', Sexo='" + txtSex.Text + "', Dirección='" + txtDir.Text + "',Identificación_tipo='" + txttipo.Text + "',Número_identificación'" + txtIden.Text + "',Teléfono='" + mksTel3.Text + "',Móvil='" + mskMo3.Text + "' where Id_Profesor='" + txtProf.Text + "'");
            }
            RefrescarTabla();
        }
        private void EscribirDatos(string Parametro)
        {    //Permite ejectuar las instrucciones recibidas en Parametro en la base de datos

            Comando.CommandText = Parametro;
            Conexion.Open();
            Comando.Transaction = Conexion.BeginTransaction();
            Comando.ExecuteNonQuery();
            Comando.Transaction.Commit();
            Conexion.Close();

        }

        private void FrmManProf3_Activated(object sender, EventArgs e)
        {
            Comando.Connection = Conexion;
        }
    }

}
