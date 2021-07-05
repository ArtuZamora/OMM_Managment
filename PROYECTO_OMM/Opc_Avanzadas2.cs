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
    public partial class Opc_Avanzadas2 : FrmBase
    {   
        consultas cs = new consultas();
        string IDAyInv;
        string IDInv;
        string IDAyAct;
        string IDAct;
        public Opc_Avanzadas2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Opciones_Avanzadas opca = new Opciones_Avanzadas();
            opca.Show();
            this.Hide();
        }
        private void refresh2()
        {
            IDAyAct = null;
            //llena DATAGRIDVIEW
            cs.Consultar("SELECT A.Cod_actividad [ID] ,A.Nombre [Actividad], "
                + "U.Carnet [Carné] ,U.Nombre [Encargado]"
                + "FROM Involucrados_actividades IA "
                + "INNER JOIN Usuarios U ON U.Carnet = IA.Carnet "
                + "INNER JOIN Actividades A ON A.Cod_actividad = IA.Cod_actividad "
                + "ORDER BY A.Nombre "
                , "Involucrados_actividades");
            this.DGVAct.DataSource = cs.ds.Tables["Involucrados_actividades"];
            this.DGVAct.Refresh();
        }

        private void refresh1()
        {
            IDInv = null;
            //llena DATAGRIDVIEW
            cs.Consultar("SELECT I.Cod_investigacion [ID], I.Titulo [Titulo de Investigacion], "
                + "U.Carnet [Carné],U.Nombre [Investigador]"
                + "FROM Registro_investigaciones RI "
                + "INNER JOIN Usuarios U ON U.Carnet = RI.Carnet "
                + "INNER JOIN Investigaciones I ON I.Cod_investigacion = RI.Cod_investigacion "
                + "ORDER BY I.Titulo "
                , "Registro_investigaciones");
            this.DGVInv.DataSource = cs.ds.Tables["Registro_investigaciones"];
            this.DGVInv.Refresh();
        }

        private void Opc_Avanzadas2_Load(object sender, EventArgs e)
        {
            this.cmbCarn1.DataSource = cs.consultar2("Usuarios");
            this.cmbCarn1.DisplayMember = "Nombre";
            this.cmbCarn1.ValueMember = "Carnet";

            this.cmbCarne2.DataSource = cs.consultar2("Usuarios");
            this.cmbCarne2.DisplayMember = "Nombre";
            this.cmbCarne2.ValueMember = "Carnet";

            this.cmbAct.DataSource = cs.consultar2("Actividades");
            this.cmbAct.DisplayMember = "Nombre";
            this.cmbAct.ValueMember = "Cod_actividad";

            this.cmbInv.DataSource = cs.consultar2("Investigaciones");
            this.cmbInv.DisplayMember = "Titulo";
            this.cmbInv.ValueMember = "Cod_investigacion";

            refresh1();
            refresh2();
        }

        private void btnAddAYI_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Registro_investigaciones (Carnet, Cod_investigacion) "
                + "VALUES('" + cmbCarn1.SelectedValue.ToString()
                + "','" + cmbInv.SelectedValue.ToString() + "')";
            if (cs.insertar(sql))
            {
                MessageBox.Show("DATOS AGREGADOS");
                refresh1();
            }
            else
            {
                MessageBox.Show("DATOS no AGREGADOS");
            }
        }

        private void btnUpdateAYI_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDInv) && !String.IsNullOrEmpty(IDAyInv))
            {
                if (cs.Actualizar("Registro_investigaciones", 
                    string.Format("Carnet = '{0}',Cod_investigacion = '{1}'",
                    cmbCarn1.SelectedValue.ToString(), cmbInv.SelectedValue.ToString()
                    )
                    , " Carnet = '" + IDAyInv + "' AND  Cod_investigacion = '" + IDInv + "'"))
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

        private void btnDeleteAYI_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDInv) && !String.IsNullOrEmpty(IDAyInv))
            {
                if (cs.eliminar("Registro_investigaciones",
                    "Carnet = '" + IDAyInv + "' AND Cod_investigacion = '" + IDInv + "'"))
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

        private void btnAddAYA_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Involucrados_actividades (Carnet, Cod_actividad) "
                    + "VALUES('" + cmbCarne2.SelectedValue.ToString()
                    + "','" + cmbAct.SelectedValue.ToString() + "')";
            if (cs.insertar(sql))
            {
                MessageBox.Show("DATOS AGREGADOS");
                refresh2();
            }
            else
            {
                MessageBox.Show("DATOS no AGREGADOS");
            }
        }

        private void btnUpdateAYA_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDAct) && !String.IsNullOrEmpty(IDAyAct))
            {
                if (cs.Actualizar("Involucrados_actividades",
                    string.Format("Carnet = '{0}',Cod_actividad = '{1}'",
                    cmbCarne2.SelectedValue.ToString(), cmbAct.SelectedValue.ToString()
                    )
                    , " Carnet = '" + IDAyAct + "' AND  Cod_actividad = '" + IDAct + "'"))
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

        private void btnDeleteAYA_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDAct) && !String.IsNullOrEmpty(IDAyAct))
            {
                if (cs.eliminar("Involucrados_actividades",
                    "Carnet = '" + IDAyAct + "' AND Cod_actividad = '" + IDAct + "'"))
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

        private void DGVInv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDInv = DGVInv.CurrentRow.Cells[0].Value.ToString();
            IDAyInv = DGVInv.CurrentRow.Cells[2].Value.ToString();
            cs.ConsultInv(this, IDInv ,IDAyInv);
        }

        private void DGVAct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDAct = DGVAct.CurrentRow.Cells[0].Value.ToString();
            IDAyAct = DGVAct.CurrentRow.Cells[2].Value.ToString();
            cs.ConsultAct(this, IDAct, IDAyAct);
        }
    }
}
