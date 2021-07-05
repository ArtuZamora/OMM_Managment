using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PROYECTO_OMM.Conexiones
{


    class conex
    {
        public string db;
        public string cadena;

        public void conec()
        {
            db = "GestionOMM";

            cadena = "Data Source=.\\SQLEXPRESS;Initial Catalog=" + db + ";Integrated Security=True;";
        }
    }
}
