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
    public partial class VerEncargados : FrmBase
    {
        public VerEncargados()
        {
            InitializeComponent();
            consultas cs = new consultas();
            cs.Consultar("SELECT A.Nombre [Actividad], "
                + "CONCAT(U.Nombre, ' ', U.Apellido) [Encargado]"
                + "FROM Involucrados_actividades IA "
                + "INNER JOIN Usuarios U ON U.Carnet = IA.Carnet "
                + "INNER JOIN Actividades A ON A.Cod_actividad = IA.Cod_actividad "
                + "ORDER BY A.Nombre "
                , "Involucrados_actividades");
            this.dgvEncargados.DataSource = cs.ds.Tables["Involucrados_actividades"];
            this.dgvEncargados.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashEstudiante dsEst = new DashEstudiante();
            dsEst.Show();
            this.Hide();
        }
    }
}
