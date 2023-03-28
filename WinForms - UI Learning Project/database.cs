using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinForms___UI_Learning_Project
{
    internal static class database
    {

        static string path = "db.txt";

        public static void createDatabase()
        {
            if(!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                File.Open(path, FileMode.Open);
            }
        }

        public static void uploadData(string _username, string _password)
        {
            File.AppendAllText(path, _username + " " + _password);
        }

    }
}
