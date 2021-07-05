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
using PROYECTO_OMM.Conexiones;
using PROYECTO_OMM.Empleado;

namespace PROYECTO_OMM
{
    public partial class Actividades : FrmBase
    {
        string IDAct;
        public int rol = 0;
        public Actividades()
        {
            InitializeComponent();

        }
        consultas cs = new consultas();


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void Actividades_Load(object sender, EventArgs e)
        {
            refresh();

            //llena combobos de Tipos de Actividades
            this.cmbTipoActividad.DataSource = cs.consultar2("Tipo_actividades");
            this.cmbTipoActividad.DisplayMember = "Tipo";
            this.cmbTipoActividad.ValueMember = "Cod_tipo";

            ///llena combobox de institucion
            this.cmbTipoInstitucion.DataSource = cs.consultar2("Instituciones");
            this.cmbTipoInstitucion.DisplayMember = "Nombre";
            this.cmbTipoInstitucion.ValueMember = "Cod_institucion";
        }

        private void cmbTipoInstitucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Actividades VALUES('A00000','"+cmbTipoActividad.SelectedValue.ToString()
                +"','"+txtActividad.Text+"',"+txtcupos.Text
                +", CAST('"+msktxtHora.Text+"' AS TIME),'"+
                cmbTipoInstitucion.SelectedValue.ToString()+
                "','"+dtpfecha.Value.Date.ToString("dd/MM/yyyy") + "')";
            if (cs.insertar(sql))
            {
                MessageBox.Show("DATOS AGREGADOS");

                refresh();
            }
            else
            {
                MessageBox.Show("DATOS no AGREGADOS");
            }

        }
        private void refresh()
        {
            IDAct = null;
            txtActividad.Clear();
            txtcupos.Clear();
            msktxtHora.Clear();
            //llena DATAGRIDVIEW
            cs.Consultar("SELECT Cod_actividad,TA.Tipo,AC.Nombre,Cupos,Hora,INS.Nombre AS [INSTITUCIÓN],Fecha_realizacion FROM Actividades AC INNER JOIN Tipo_actividades TA ON AC.Cod_tipo = TA.Cod_tipo INNER JOIN Instituciones INS ON AC.Cod_institucion = INS.Cod_institucion", "Actividades");
            this.dgvActividades.DataSource = cs.ds.Tables["ACtividades"];
            this.dgvActividades.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (rol == 1)
            {
                DashEmpleado ds = new DashEmpleado();
                ds.Show();
                this.Hide();
            }
            else
            {
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Hide();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDAct))
            {
                if (cs.Actualizar("Actividades", string.Format("Cod_tipo = '{0}',Nombre = '{1}',"
                    + "Cupos = '{2}',Hora = CAST('{3}' AS TIME), Cod_institucion = '{4}', Fecha_realizacion = '{5}'",
                    cmbTipoActividad.SelectedValue.ToString(), txtActividad.Text,
                    txtcupos.Text, msktxtHora.Text, cmbTipoInstitucion.SelectedValue.ToString(),
                    dtpfecha.Value.Date.ToString("dd/MM/yyyy")
                    )
                    , " Cod_actividad = '" + IDAct + "'"))
                {
                    MessageBox.Show(this, "Datos actualizados correctamente",
                          "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show(this, "No se pudo actualizar",
                         "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(this, "Debe ingresar un codigo para modificar",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDAct))
            {
                if (cs.eliminar("Actividades", "Cod_actividad = '" + IDAct + "'"))
                {
                    MessageBox.Show(this, "Datos eliminados correctamente",
                          "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show(this, "No se pudo eliminar",
                        "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(this, "Debe ingresar un codigo para eliminar",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDAct = dgvActividades.CurrentRow.Cells[0].Value.ToString();
            cs.ConsultAct(this, IDAct);
        }
    }
}
