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
    public partial class Investigaciones : FrmBase 
    {
        static string codInv;
        public int rol;
        public Investigaciones()
        {
            InitializeComponent();
        }

        consultas cns = new consultas();
        private void Investigaciones_Load(object sender, EventArgs e)
        {
            ReloadDGV();
            //llena combobox del estado de la investigacion
            this.cmbEstado.DataSource = cns.consultar2("Estado_Investigaciones");
            this.cmbEstado.DisplayMember = "Estado";
            this.cmbEstado.ValueMember = "Cod_estado";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO Investigaciones VALUES ('IV0000','"+
                txtTitulo.Text+"','"+txtDescrip.Text+"','"+dtpfechaInicio.Value.Date.ToString("dd/MM/yyyy") + "','"+
                cmbEstado.SelectedValue.ToString()+"','"+dtpfechaFin.Value.Date.ToString("dd/MM/yyyy") + "')";

            if (cns.insertar(consulta))
            {
                MessageBox.Show("DATOS AGREGADOS");
                refresh();
            }
            else
            {
                MessageBox.Show("DATOS no AGREGADOS");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
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
        private void ReloadDGV()
        {
            cns.Consultar("SELECT Cod_Investigacion, Titulo, Detalle, Fecha_Inicio, "
                + "Fecha_Finalizacion, EI.Estado FROM Investigaciones IV "
                + "INNER JOIN Estado_Investigaciones EI ON IV.Cod_estado = EI.Cod_estado ",
                "Investigaciones");
            this.dgvinvestigaciones.DataSource = cns.ds.Tables["Investigaciones"];
            this.dgvinvestigaciones.Refresh();
        }
        private void refresh()
        {
            cmbEstado.Text = "";
            txtDescrip.Clear();
            dtpfechaInicio.Text = "";
            txtTitulo.Clear();

            dtpfechaFin.Text = "";
            codInv = null;
            ReloadDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(codInv))
            {
                if (cns.Actualizar("Investigaciones", string.Format("Titulo = '{0}',Detalle = '{1}',"
                    + "Fecha_Inicio = '{2}',Cod_estado = '{3}', Fecha_Finalizacion = '{4}'",
                    txtTitulo.Text, txtDescrip.Text, dtpfechaInicio.Value.Date.ToString("dd/MM/yyyy")
                    , cmbEstado.SelectedValue, dtpfechaFin.Value.Date.ToString("dd/MM/yyyy"))
                    , " Cod_investigacion = '" + codInv + "'"))
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(codInv))
            {
                if (cns.eliminar("Investigaciones", "Cod_investigacion = '" + codInv + "'"))
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

        private void dgvinvestigaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codInv = dgvinvestigaciones.CurrentRow.Cells[0].Value.ToString();
            cns.ConsultInv(this, codInv);
        }
    }
}
