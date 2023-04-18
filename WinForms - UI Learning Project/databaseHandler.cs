using LiteDB;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using WinForms___UI_Learning_Project;
using System.Collections.ObjectModel;

namespace WinForms___UI_Learning_Project
{
    public class loggingInfo
    {
        public string login { get; set; }
        public string password { get; set; }
    }

    public class tasksData
    {
        [BsonId]
        public ObjectId taskId { get; set; }
        public string name { get; set; }
        public DateTime time { get; set; }
        public bool isChecked { get; set; }
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

                var task = new tasksData { name = _name, time = _date, isChecked = false, taskId = ObjectId.NewObjectId() };

                col.Insert(task);

            }

        }

        public static List<tasksData> getTasksData()
        {

            using (var db = new LiteDatabase("tasksDB.db"))
            {

                var col = db.GetCollection<tasksData>();

                var results = col
                    .FindAll()
                    .ToList();

                results.Sort((x, y) => x.time.CompareTo(y.time));

                return results;
            }

        }

        public static void deleteTask(ObjectId _id)
        {

            using (var db = new LiteDatabase("tasksDB.db"))
            {

                var col = db.GetCollection<tasksData>();

                col.DeleteMany(x => x.taskId == _id);

            }

        }

        public static void updateTask(ObjectId _id)
        {
            using (var db = new LiteDatabase("tasksDB.db"))
            {

                var col = db.GetCollection<tasksData>();

                var task = col.FindOne(x => x.taskId == _id);
                task.isChecked = true;
                col.Update(task);

            }
        }
    }
}
