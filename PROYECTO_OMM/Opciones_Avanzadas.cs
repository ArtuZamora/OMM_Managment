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

namespace PROYECTO_OMM
{
    public partial class Opciones_Avanzadas : FrmBase
    {
        consultas cns = new consultas();
        string IDEstado;
        string IDTipoAct;
        string IDInstit;
        public Opciones_Avanzadas()
        {
            InitializeComponent();
            refresh1();
            refresh2();
            refresh3();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dsb = new Dashboard();
            dsb.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Opc_Avanzadas2 opca2 = new Opc_Avanzadas2();
            opca2.Show();
            this.Hide();
        }

        private void btnAddEI_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO Estado_investigaciones (Estado) "
                + "VALUES ('"+txtEstadoInves.Text+"')";

            if (cns.insertar(consulta))
            {
                MessageBox.Show("DATOS AGREGADOS");
                refresh1();
            }
            else
            {
                MessageBox.Show("DATOS no AGREGADOS");
            }
        }

        private void btnUpdateEI_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDEstado))
            {
                if (cns.Actualizar("Estado_investigaciones", " Estado = '" + txtEstadoInves.Text + "'"
                    , "Cod_estado = " + IDEstado))
                {
                    MessageBox.Show(this, "Datos actualizados correctamente",
                          "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh1();
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
        private void btnDeleteEI_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDEstado))
            {
                if (cns.eliminar("Estado_investigaciones", "Cod_estado = '" + IDEstado + "'"))
                {
                    MessageBox.Show(this, "Datos eliminados correctamente",
                          "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh1();
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

        private void btnAddTDA_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO Tipo_actividades (Cod_tipo, Tipo) "
                + "VALUES ( 'TA00' ,'" + txtTipoAct.Text + "')";

            if (cns.insertar(consulta))
            {
                MessageBox.Show("DATOS AGREGADOS");
                refresh2();
            }
            else
            {
                MessageBox.Show("DATOS no AGREGADOS");
            }
        }

        private void btnUpdateTDA_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDTipoAct))
            {
                if (cns.Actualizar("Tipo_actividades", " Tipo = '" + txtTipoAct.Text + "'"
                    , "Cod_tipo = '" + IDTipoAct + "'"))
                {
                    MessageBox.Show(this, "Datos actualizados correctamente",
                          "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh2();
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

        private void btnDeleteTDA_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDTipoAct))
            {
                if (cns.eliminar("Tipo_actividades", "Cod_tipo = '" + IDTipoAct + "'"))
                {
                    MessageBox.Show(this, "Datos eliminados correctamente",
                          "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh2();
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

        private void btnAddINS_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO Instituciones (Cod_institucion, Nombre) "
                + "VALUES ('I00000','" + txtINST.Text + "')";

            if (cns.insertar(consulta))
            {
                MessageBox.Show("DATOS AGREGADOS");
                refresh3();
            }
            else
            {
                MessageBox.Show("DATOS no AGREGADOS");
            }
        }

        private void btnUpdateINS_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDInstit))
            {
                if (cns.Actualizar("Instituciones", " Nombre = '" + txtINST.Text + "'"
                    , "Cod_institucion = '" + IDInstit + "'"))
                {
                    MessageBox.Show(this, "Datos actualizados correctamente",
                          "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh3();
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

        private void btnDeleteINS_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDInstit))
            {
                if (cns.eliminar("Instituciones", "Cod_institucion = '" + IDInstit + "'"))
                {
                    MessageBox.Show(this, "Datos eliminados correctamente",
                          "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh3();
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
        private void refresh1()
        {
            txtEstadoInves.Clear();
            cns.Consultar("SELECT * FROM Estado_investigaciones","Estado_investigaciones");
            this.dataGridView1.DataSource = cns.ds.Tables["Estado_investigaciones"];
            this.dataGridView1.Refresh();
        }
        private void refresh2()
        {
            txtTipoAct.Clear();
            cns.Consultar("SELECT * FROM Tipo_actividades", "Tipo_actividades");
            this.dataGridView2.DataSource = cns.ds.Tables["Tipo_actividades"];
            this.dataGridView2.Refresh();
        }
        private void refresh3()
        {
            txtINST.Clear();
            cns.Consultar("SELECT * FROM Instituciones", "Instituciones");
            this.dataGridView3.DataSource = cns.ds.Tables["Instituciones"];
            this.dataGridView3.Refresh();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDEstado = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cns.ConsultEstado(this, IDEstado);
            IDEstado = null;
            IDTipoAct = null;
            IDInstit = null;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTipoAct = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            cns.ConsultTipoAct(this, IDTipoAct);
            IDEstado = null;
            IDTipoAct = null;
            IDInstit = null;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDInstit = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            cns.ConsultInst(this, IDInstit);
            IDEstado = null;
            IDTipoAct = null;
            IDInstit = null;
        }
    }
}
