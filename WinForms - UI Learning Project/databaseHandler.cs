using LiteDB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms___UI_Learning_Project
{
    public class loggingInfo
    {
        public string login { get; set; }
        public string password { get; set; }
    }

    public class tasksData
    {
        public string name { get; set; }
        public DateTime time { get; set; }
    }

    internal static class databaseHandlerLogging
    {
        public static void insertLoggingInformation(string _login, string _password)
        {
            using (var db = new LiteDatabase("loggingDB.db"))
            {
               
                var col = db.GetCollection<loggingInfo>();

                var user = new loggingInfo { login = _login, password = _password };

                col.Insert(user);

            }
        }

        public static bool checkLoggingInformation(string _login, string _password)
        {
            using (var db = new LiteDatabase("loggingDB.db"))
            {

                var col = db.GetCollection<loggingInfo>();

                var results = col
                    .FindAll()
                    .ToList();

                foreach (var item in results) { 

                    if(item.login == _login && item.password == _password) { return true; }

                }

                return false;
            }
        }
    }

    internal static class databaseHandlerTasks
    {
        public static void insertTasksData(string _name, DateTime _date)
        {

            using (var db = new LiteDatabase("tasksDB.db"))
            {

                var col = db.GetCollection<tasksData>();

                var task = new tasksData { name = _name, time = _date };

                col.Insert(task);

            }

        }
    }
}
