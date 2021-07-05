using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYECTO_OMM
{
    public partial class Dashboard : FrmBase
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actividades actv = new Actividades();
            actv.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Investigaciones invest = new Investigaciones();
            invest.Show();
            this.Hide();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Personas psr = new Personas();
            psr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Opciones_Avanzadas opc = new Opciones_Avanzadas();
            opc.Show();
            this.Hide();
        }

        private void btnActividadReciente_Click(object sender, EventArgs e)
        {
            ActividadReciente ar = new ActividadReciente();
            ar.Show();
            this.Hide();
        }
    }
}
