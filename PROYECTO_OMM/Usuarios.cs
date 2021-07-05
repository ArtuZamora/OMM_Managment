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
using System.Data.SqlClient;


namespace PROYECTO_OMM
{
    public partial class Usuarios : FrmBase
    {
        public Usuarios()
        {
            InitializeComponent();
            dtpinscrip.MaxDate = DateTime.Today;
        }

        consultas cs = new consultas();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            //llena cmb cargo
            this.cmbcargo.DataSource = cs.consultar2("Tipo_Usuarios");
            this.cmbcargo.DisplayMember = "Tipo";
            this.cmbcargo.ValueMember = "Cod_tipo";

            reloadDGV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dsb = new Dashboard();
            dsb.Show();
            this.Hide();
        }

        private void btnregist_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Usuarios VALUES('" + txtcarnet.Text 
                + "','" + txtnombre.Text + "','" 
                + txtapellido.Text + "','" + txtuser.Text 
                + "','" + txtcontra.Text + "','" + txtcorreo.Text 
                + "','" + msktele.Text + "','" + cmbcargo.SelectedValue.ToString() 
                + "','" + dtpinscrip.Value.Date.ToString("dd/MM/yyyy") + "')";
            if (cs.insertar(sql))
            {
                MessageBox.Show("DATOS AGREGADOS");
                clear();
            }
            else
            {
                MessageBox.Show("DATOS NO AGREGADOS");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtcarnet.Text))
            {
                if (cs.Actualizar("Usuarios", string.Format("Nombre = '{0}',Apellido = '{1}',"
                    + "Usuario = '{2}',Contraseña = '{3}', Email = '{4}',"
                    + "Telefono = '{5}', Cod_tipo = '{6}', Fecha_inscrito = '{7}'",
                    txtnombre.Text, txtapellido.Text, txtuser.Text, txtcontra.Text,
                    txtcorreo.Text, msktele.Text, cmbcargo.SelectedValue.ToString(),
                    dtpinscrip.Value.Date.ToString("dd/MM/yyyy")), "Carnet = '" + txtcarnet.Text + "'"))
                {
                    MessageBox.Show(this, "Datos actualizados correctamente",
                          "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show(this, "No se pudo actualizar",
                         "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(this, "Debe ingresar un carné para modificar",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtcarnet.Text))
            {
                if(cs.eliminar("Usuarios","Carnet = '"+txtcarnet.Text+"'"))
                {
                    MessageBox.Show(this, "Datos eliminados correctamente",
                          "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show(this, "No se pudo eliminar",
                        "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(this, "Debe ingresar un carné para eliminar",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clear()
        {
            txtcarnet.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtuser.Clear();
            txtcontra.Clear();
            txtcorreo.Clear();
            msktele.Clear();
            cmbcargo.Text = "";
            dtpinscrip.Text = "";
            this.dgvuser.Refresh();
            reloadDGV();
        }

        private void dgvuser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cs.ConsultUser(this, dgvuser.CurrentRow.Cells[0].Value.ToString());
        }

        private void dtpinscrip_ValueChanged(object sender, EventArgs e)
        {
        }

        private void reloadDGV()
        {
            //llena datagridview

            cs.Consultar("SELECT Carnet,Nombre,Apellido,Usuario,Contraseña,Email,Telefono,TPU.Tipo,"
                + "Fecha_inscrito FROM Usuarios US INNER JOIN Tipo_Usuarios TPU ON US.Cod_tipo = TPU.Cod_tipo", "Usuarios");
            this.dgvuser.DataSource = cs.ds.Tables["Usuarios"];
            this.dgvuser.Refresh();
        }
    }
    
}
