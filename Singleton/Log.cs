using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Singleton
{
    public class Log
    {
        private readonly static Log _instance = new Log();
        private string path = "log1.txt";

        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }
        private Log()
        {

        }
        public void guardarlog(string mensaje)
        {
            File.AppendAllText(path, mensaje + Environment.NewLine);
        }




    }
}
