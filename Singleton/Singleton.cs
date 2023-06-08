using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Singleton
{
    public class Singleton
    {
        private readonly static SqlConnection _instance = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public static SqlConnection Instance //Creamos el acceso al atributo _instance
        {
            get { return _instance; }
        }
        private Singleton()  //Constructyor private para no se puedan crear objetos de esta clase
        {

        }
    }
}
