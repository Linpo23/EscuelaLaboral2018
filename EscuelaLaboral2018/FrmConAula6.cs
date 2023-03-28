using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;using System.Data.SqlClient;  //Para trabajar con SQL
using System.Threading;
using System.Globalization;
namespace EscuelaLaboral2018
{
    public partial class FrmConAula6 : Form
    {//defino variables globales 
        SqlCommand Comando = new SqlCommand();
        SqlConnection Conexion = new SqlConnection("Data Source=POLI-PC\\SQLEXPRESS; initial catalog=Escuela_Laboral2018; trusted_connection=yes");

        public FrmConAula6()
        {
            InitializeComponent();
        }
        private void RefrescarTabla()
        {
            dgvCon.DataSource = null;
            try
            {
                Conexion.Open();
                DataTable Datos = new DataTable();
                SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Aula", Conexion);
                Adaptador.Fill(Datos);
                BindingSource FuenteDatos = new BindingSource();
                FuenteDatos.DataSource = Datos;
                dgvCon.DataSource = FuenteDatos;
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

        private void FrmConAula6_Load(object sender, EventArgs e)
        {
            mskFe4.Text = DateTime.Now.ToShortDateString();
            RefrescarTabla();
        }
    }
}
