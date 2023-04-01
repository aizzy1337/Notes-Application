using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

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
            File.AppendAllText(path, _username + " " + _password + "\n");
        }

        public static bool checkData(string _username, string _password)
        {
            string[] lines = File.ReadAllLines(path);
            foreach(string line in lines)
            {
                string[] words = line.Split(' ');
                if (words[0] == _username && words[1] == _password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
