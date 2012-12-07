using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace pomodoro_tasks
{
    static class Program
    {

        public static SQLiteConnection connection;
        public static ActivityDialog activityDialog;
        public static TaskList taskDialog;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FindOrCreateSqliteDb();
            activityDialog = new ActivityDialog();
            taskDialog = new TaskList();

            Application.Run(activityDialog);

        }

        private static void FindOrCreateSqliteDb()
        {
            try {
                connection = new SQLiteConnection("Data Source=pomodoro-tasks.sqlite;Version=3;");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("select count(*) from activities", connection);
                cmd.ExecuteScalar();
            } catch (Exception ex) {
                SetUpDatabase();
            } finally {
                connection.Close();
            }
        }

        private static void SetUpDatabase()
        {
            SQLiteCommand cmd = new SQLiteCommand("create table activities ( id integer primary key autoincrement, activity_desc VARCHAR(256) unique, estimated integer, actual integer, interruptions integer, is_active_task integer, is_completed integer)", connection);
            cmd.ExecuteNonQuery();
        }
    }
}
