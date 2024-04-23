using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jocuri.SqlDataAccess
{
    public class DataAccess
    {
        public static string GetConnectionPath()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public static string GetUtilizatoriPath()
        {
            return ConfigurationManager.AppSettings["UtilizatoriPath"];
        }
        public static string GetRezultatePath()
        {
            return ConfigurationManager.AppSettings["RezultatePath"];
        }

    }
}
