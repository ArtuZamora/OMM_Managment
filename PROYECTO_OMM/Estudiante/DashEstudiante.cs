using PROYECTO_OMM.Conexiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_OMM.Estudiante
{
    public partial class DashEstudiante : Dashboard
    {
        public DashEstudiante()
        {
            InitializeComponent();
        }

        private void btnInvest_Click(object sender, EventArgs e)
        {

        }

        private void btnAct_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerEncargados encarEs = new VerEncargados();
            encarEs.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VerInvestigaciones investEs = new VerInvestigaciones();
            investEs.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerActividades actEs = new VerActividades();
            actEs.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consultas cs = new consultas();
            MessageBox.Show(this, string.Format("Tus horas sociales actuales:\n {0} hora(s)",cs.ConsultHoras()),
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnActividadReciente_Click(object sender, EventArgs e)
        {
            ActividadReciente ar = new ActividadReciente();
            ar.rol = 1;
            ar.Show();
            this.Hide();
        }
    }
}
