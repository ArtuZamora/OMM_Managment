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
    public partial class VerActividades : FrmBase
    {
        public VerActividades()
        {
            InitializeComponent();
            consultas cs = new consultas();
            cs.Consultar("SELECT Cod_actividad,TA.Tipo,AC.Nombre,Cupos,Hora,INS.Nombre AS [INSTITUCIÓN],Fecha_realizacion FROM Actividades AC INNER JOIN Tipo_actividades TA ON AC.Cod_tipo = TA.Cod_tipo INNER JOIN Instituciones INS ON AC.Cod_institucion = INS.Cod_institucion", "Actividades");
            this.dgvVerActividades.DataSource = cs.ds.Tables["ACtividades"];
            this.dgvVerActividades.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashEstudiante dsEst = new DashEstudiante();
            dsEst.Show();
            this.Hide();
        }
    }
}
