using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capaNegocio;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace capaDatos
{
    public class clsConexion
    {
        MySqlConnection cn;
        public void conectar()
        {
            cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlconex"].ConnectionString);
            cn.Open();
        }

        public void cerrar()
        {
            cn.Close();
        }

        }
    }
