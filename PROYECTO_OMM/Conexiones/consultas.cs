using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PROYECTO_OMM.Conexiones;
using System.Windows.Forms;
using System.Data;

namespace PROYECTO_OMM.Conexiones
{

    class consultas
    {
        public SqlConnection conn;
        
        private SqlCommandBuilder cmb;
        private string scn;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand cmd;

        private void connex(){
            try
            {
                conex cn = new conex();

                cn.conec();
                scn = cn.cadena;

                conn = new SqlConnection(scn);
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        public consultas()
        {
            connex();
        }

        //CONSULTAR
        public void Consultar(string sql, string tabla)
        {
            try
            {
                ds.Tables.Clear();
                da = new SqlDataAdapter(sql, conn);
                cmb = new SqlCommandBuilder(da);
                da.Fill(ds, tabla);
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR " + e.Message);
            }

        }
        //ELIMINAR

        public bool eliminar(string tabla, string condicion)
        {
            conn.Open();
            string sql = "DELETE FROM " + tabla + " WHERE " + condicion;
            cmd = new SqlCommand(sql, conn);
            int i = cmd.ExecuteNonQuery();

            conn.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Actualizar
        /// </summary>
        public bool Actualizar(string tabla, string campos, string condicion)
        {
            conn.Open();
            string sql = "UPDATE "+ tabla +" SET " + campos + " WHERE "+  condicion;

            cmd = new SqlCommand(sql, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable consultar2(string tabla)
        {
            string sql = "SELECT * FROM " + tabla;
            da = new SqlDataAdapter(sql,conn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;

        }

        public bool insertar(string sql)
        {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
        public void ConsultUser(Usuarios form, string carnet)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Usuarios WHERE Carnet = '" + carnet + "'",conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                form.txtcarnet.Text = reader[0].ToString();
                form.txtnombre.Text = reader[1].ToString();
                form.txtapellido.Text = reader[2].ToString();
                form.txtuser.Text = reader[3].ToString();
                form.txtcontra.Text = reader[4].ToString();
                form.txtcorreo.Text = reader[5].ToString();
                form.msktele.Text = reader[6].ToString();
                form.cmbcargo.SelectedValue = reader[7].ToString();
                form.dtpinscrip.Text = reader[8].ToString();
            }
            reader.Close();
            conn.Close();
        }
        public void ConsultInv(Investigaciones form, string codi)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Investigaciones WHERE Cod_investigacion = '" + codi + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                form.txtTitulo.Text = reader[1].ToString();
                form.txtDescrip.Text = reader[2].ToString();
                form.dtpfechaInicio.Text = reader[3].ToString();
                form.cmbEstado.SelectedValue = reader[4].ToString();
                form.dtpfechaFin.Text = reader[5].ToString();
            }
            reader.Close();
            conn.Close();
        }
        public void ConsultEstado(Opciones_Avanzadas form, string codi)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Estado_investigaciones WHERE Cod_estado = " + codi, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                form.txtEstadoInves.Text = reader[1].ToString();
            }
            reader.Close();
            conn.Close();
        }
        public void ConsultTipoAct(Opciones_Avanzadas form, string codi)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Tipo_actividades WHERE Cod_tipo = '" + codi + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                form.txtTipoAct.Text = reader[1].ToString();
            }
            reader.Close();
            conn.Close();
        }
        public void ConsultInst(Opciones_Avanzadas form, string codi)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Instituciones WHERE Cod_institucion = '" + codi + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                form.txtINST.Text = reader[1].ToString();
            }
            reader.Close();
            conn.Close();
        }
        public void ConsultAct(Actividades form, string codi)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Actividades WHERE Cod_actividad = '" + codi + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                form.cmbTipoActividad.SelectedValue = reader[1].ToString();
                form.txtActividad.Text = reader[2].ToString();
                form.txtcupos.Text = reader[3].ToString();
                form.msktxtHora.Text = reader[4].ToString();
                form.cmbTipoInstitucion.SelectedValue = reader[5].ToString();
                form.dtpfecha.Text = reader[6].ToString();
            }
            reader.Close();
            conn.Close();
        }
        public void ConsultPer(Personas form, string codi)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Personas WHERE Cod_persona = '" + codi + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                form.txtnombre.Text = reader[1].ToString();
                form.txtcorreo.Text = reader[2].ToString();
                form.cmbAct.SelectedValue = reader[3].ToString();
            }
            reader.Close();
            conn.Close();
        }
        public void ConsultInv(Opc_Avanzadas2 form, string inv, string ayud)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Registro_investigaciones "
                + " WHERE Carnet = '" + ayud + "' AND Cod_investigacion = '" + inv + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                form.cmbCarn1.SelectedValue = reader[0].ToString();
                form.cmbInv.SelectedValue = reader[1].ToString();
            }
            reader.Close();
            conn.Close();
        }
        public void ConsultAct(Opc_Avanzadas2 form, string act, string enc)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Involucrados_actividades "
                + " WHERE Carnet = '" + enc + "' AND Cod_actividad = '" + act + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                form.cmbCarne2.SelectedValue = reader[0].ToString();
                form.cmbAct.SelectedValue = reader[1].ToString();
            }
            reader.Close();
            conn.Close();
        }
        public string ConsultHoras()
        {
            string horas = null;
            conn.Open();
            cmd = new SqlCommand("EXEC Proce_HorasSociales '"+Program.carnet+"'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                horas = reader[0].ToString();
            }
            reader.Close();
            conn.Close();
            return horas;
        }
    }
}
