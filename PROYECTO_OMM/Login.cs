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
using PROYECTO_OMM.Estudiante;

namespace PROYECTO_OMM
{
    public partial class Login : FrmBase
    {

        private SqlConnection conn;
        private SqlCommand cmd;
        private string scn;
        public Login()
        {
            InitializeComponent();
            try
            {
                conex cn = new conex();

                cn.conec();
                scn = cn.cadena;

                conn = new SqlConnection(scn);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("ERROR " + Ex.Message);
            }

        }

        public void logear(string usuario, string contra)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT Usuario, Cod_tipo, Carnet FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @contra", conn);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("contra", contra);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Program.carnet = dt.Rows[0][2].ToString();
                    if (dt.Rows[0][1].ToString()=="TU01")
                    {
                        
                        Dashboard dsb = new Dashboard();
                        dsb.Show();

                    }else if (dt.Rows[0][1].ToString() == "TU02")
                    {
                        
                        DashEstudiante lg = new DashEstudiante();
                        lg.Show();
                    }else if (dt.Rows[0][1].ToString()=="TU03")
                    {
                        DashEmpleado emp = new DashEmpleado();
                        emp.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña no encontrados");
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logear(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
