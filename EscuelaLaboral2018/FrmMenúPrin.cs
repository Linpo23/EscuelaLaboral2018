using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EscuelaLaboral2018
{
    public partial class FrmMenúPrin : Form
    {
        public FrmMenúPrin()
        {
            InitializeComponent();
        }

        private void nacionalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManNaci1 formulario = new FrmManNaci1();
            formulario.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManEstu2 formulario = new FrmManEstu2();
            formulario.Show();

        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManProf3 formulario = new FrmManProf3();
            formulario.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantEmp4 formulario = new FrmMantEmp4();
            formulario.Show();

        }

        private void edifíciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantEdi5 formulario = new FrmMantEdi5();
            formulario.Show();
        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantAul6 formulario = new FrmMantAul6();
            formulario.Show();

        }

        private void tallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantTal7 formulario = new FrmMantTal7();
            formulario.Show();

        }

        private void nacionalidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConNaci1 formulario = new FrmConNaci1();
            formulario.Show();

        }

        private void estudiantesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConEst2 formulario = new FrmConEst2();
            formulario.Show();
        }

        private void profesoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConPro3 formulario = new FrmConPro3();
            formulario.Show();

        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConEmp4 formulario = new FrmConEmp4();
            formulario.Show();
        }

        private void edifíciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsEdif5 formulario = new FrmConsEdif5();
            formulario.Show();

        }

        private void aulasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConAula6 formulario = new FrmConAula6();
            formulario.Show();

        }

        private void talleresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConTal7 formulario = new FrmConTal7();
            formulario.Show();

        }

        private void pagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConPag8 formulario = new FrmConPag8();
            formulario.Show();
        }

        private void historialDeCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConHis9 formulario = new FrmConHis9();
            formulario.Show();
        }

        private void calificaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConCal10 formulario = new FrmConCal10();
            formulario.Show();
        }

        private void inscripciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConIns11 formulario = new FrmConIns11();
            formulario.Show();
        }

        private void registroDeTalleresPorPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
