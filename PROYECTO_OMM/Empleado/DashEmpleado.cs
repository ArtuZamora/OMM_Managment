using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_OMM.Empleado
{
    public partial class DashEmpleado : Dashboard
    {
        public DashEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void btnAct_Click(object sender, EventArgs e)
        {

        }

        private void btnInvest_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personas pes = new Personas();
            pes.rol = 1;
            pes.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Actividades actemp = new Actividades();
            actemp.rol = 1;
            actemp.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Investigaciones invemp = new Investigaciones();
            invemp.rol = 1;
            invemp.Show();
            this.Hide();
        }

        private void btnActividadReciente_Click(object sender, EventArgs e)
        {
            ActividadReciente ar = new ActividadReciente();
            ar.rol = 2;
            ar.Show();
            this.Hide();
        }
    }
}
