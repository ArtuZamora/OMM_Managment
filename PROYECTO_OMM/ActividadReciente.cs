using PROYECTO_OMM.Conexiones;
using PROYECTO_OMM.Empleado;
using PROYECTO_OMM.Estudiante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_OMM
{
    public partial class ActividadReciente : FrmBase
    {
        public int rol = 0;
        public ActividadReciente()
        {
            InitializeComponent();
        }

        private void ActividadReciente_Load(object sender, EventArgs e)
        {
            consultas cs = new consultas();
            cs.Consultar("SELECT * FROM Actividades_Recientes", "ActividadR");
            this.DGVAct.DataSource = cs.ds.Tables["ActividadR"];
            this.DGVAct.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rol == 2)
            {
                DashEmpleado ds = new DashEmpleado();
                ds.Show();
                this.Visible = false;
            }
            else if(rol == 1)
            {
                DashEstudiante ds = new DashEstudiante();
                ds.Show();
                this.Visible = false;
            }
            else
            {
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Visible = false;
            }
        }
    }
}
