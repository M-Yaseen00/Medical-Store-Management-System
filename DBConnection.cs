using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseProject
{
    internal class DBConnection
    {
       public static string server = "localhost";
       public static string database = "project";
       public static string username = "root";
       public static string password = "";

        public static string conString = "server=" + server + ";" + "database=" + database + ";" + "uid=" + username + ";" + "password=" + password + ";";
    }
}
