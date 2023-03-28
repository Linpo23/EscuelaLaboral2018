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

    public partial class FrmManNaci1 : Form
    { //defino variables globales 
        SqlCommand Comando = new SqlCommand();
        SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-6K4KFDB\\SQLEXPRESS; initial catalog=Escuela_Laboral2018; trusted_connection=yes");

        public FrmManNaci1()
        {
            InitializeComponent();
        }
        private void RefrescarTabla()
        {
            dgvNac.DataSource = null;
            try
            {
                Conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Nacionalidad ", Conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvNac.DataSource = FuenteDatos;
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

        private void btnRet_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvNac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void FrmManNaci1_Load(object sender, EventArgs e)
        {
            {
                mskFe1.Text = DateTime.Now.ToShortDateString();
                RefrescarTabla();
            }

        }

        private void dgvNac_Click(object sender, EventArgs e)
        {
            txtNac.Text = dgvNac[0, dgvNac.SelectedCells[0].RowIndex].Value.ToString();
            txtNom.Text = dgvNac[1, dgvNac.SelectedCells[0].RowIndex].Value.ToString();

        }

        private void btnGua_Click(object sender, EventArgs e)
        {

            if (txtNac.Text == "")
            //si esta vacio
            {
                EscribirDatos("insert into Nacionalidad (Nombre) values('" + txtNom.Text + "')");
            }
            else
            //mofico de 
            {
                EscribirDatos("Update Nacionalidad set Nombre='" + txtNom.Text + "' where Id_Nacionalidad ='" + txtNac.Text + "'");
            }
            RefrescarTabla();
        }



        private void FrmManNaci1_Activated(object sender, EventArgs e)
        {
            Comando.Connection = Conexion;
        }

        private void EscribirDatos(string Parametro)
        {


            //Permite ejectuar las instrucciones recibidas en Parametro en la base de datos
            Conexion.Close();
            Comando.CommandText = Parametro;
            Conexion.Open();
            Comando.Transaction = Conexion.BeginTransaction();
            Comando.ExecuteNonQuery();
            Comando.Transaction.Commit();
            Conexion.Close();
        }

        private void btnBor_Click(object sender, EventArgs e)
        {
            EscribirDatos("Delete from Nacionalidad where Id_Nacionalidad='" + txtNac.Text + "'");

            RefrescarTabla();

        }


        private bool EsNu(char caracter)
        {
            if (caracter >= 48 && caracter <= 57 || caracter == 8)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        private void txtNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = EsNu(e.KeyChar);
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = EsNu(e.KeyChar);
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtNac.Text = "";
            txtNom.Text = "";
        }
    }
}

