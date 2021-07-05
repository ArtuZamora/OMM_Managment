using PROYECTO_OMM.Conexiones;
using PROYECTO_OMM.Empleado;
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
    public partial class Personas : FrmBase
    {
        consultas cs = new consultas();
        string IDPer;
        public int rol = 0;
        public Personas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(rol == 1)
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

        private void Personas_Load(object sender, EventArgs e)
        {
            refresh();
            IDPer = null;
            this.cmbAct.DataSource = cs.consultar2("Actividades");
            this.cmbAct.DisplayMember = "Nombre";
            this.cmbAct.ValueMember = "Cod_actividad";
        }
        private void refresh()
        {
            txtnombre.Clear();
            txtcorreo.Clear();
            //llena DATAGRIDVIEW
            cs.Consultar("SELECT Cod_persona [ID], NombreCompleto [Nombre], Email, A.Nombre [Actividad] FROM Personas P "
                + "INNER JOIN Actividades A ON P.Cod_actividad = A.Cod_actividad", "Personas");
            this.DGVpersona.DataSource = cs.ds.Tables["Personas"];
            this.DGVpersona.Refresh();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Personas (NombreCompleto, Email, Cod_actividad) "
                + "VALUES('" + txtnombre.Text
                + "','" + txtcorreo.Text + "', '" + cmbAct.SelectedValue.ToString() + "')";
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

        private void actualizar_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(IDPer))
            {
                if (cs.Actualizar("Personas", string.Format("NombreCompleto = '{0}',Email = '{1}',"
                    + "Cod_actividad = '{2}' ",
                    txtnombre.Text, txtcorreo.Text,
                    cmbAct.SelectedValue.ToString()
                    )
                    , " Cod_persona = '" + IDPer + "'"))
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

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDPer))
            {
                if (cs.eliminar("Personas", "Cod_persona = '" + IDPer + "'"))
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

        private void DGVpersona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDPer = DGVpersona.CurrentRow.Cells[0].Value.ToString();
            cs.ConsultPer(this, IDPer);
        }
    }
}
