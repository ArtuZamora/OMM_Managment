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
    public partial class VerInvestigaciones : FrmBase
    {
        public VerInvestigaciones()
        {
            InitializeComponent();
            consultas cs = new consultas();
            cs.Consultar("SELECT Cod_Investigacion, Titulo, Detalle, Fecha_Inicio, "
                + "Fecha_Finalizacion, EI.Estado FROM Investigaciones IV "
                + "INNER JOIN Estado_Investigaciones EI ON IV.Cod_estado = EI.Cod_estado ",
                "Investigaciones");
            this.dgvVERInvestigaciones.DataSource = cs.ds.Tables["Investigaciones"];
            this.dgvVERInvestigaciones.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashEstudiante dsEst = new DashEstudiante();
            dsEst.Show();
            this.Hide();
        }
    }
}
