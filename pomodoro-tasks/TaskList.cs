using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace pomodoro_tasks
{
    public partial class TaskList : Form
    {
        public TaskList()
        {
            InitializeComponent();
        }

        private void TaskList_Activate(object sender, EventArgs e)
        {
            List<Activity> tasks = new List<Activity>();
            SQLiteCommand cmd = new SQLiteCommand("select * from activities where is_active_task = 1 and is_completed = 0", Program.connection);
            Program.connection.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read()) {
                var vals = reader.GetValues();
                tasks.Add(new Activity {
                    Id = int.Parse(vals["id"]),
                    Description = vals["activity_desc"].ToString(),
                    EstimatedPomodoros = int.Parse(vals["estimated"]),
                    ActualPomodoros = int.Parse(vals["actual"]),
                    Interruptions = int.Parse(vals["interruptions"]),
                    IsActiveTask = int.Parse(vals["is_active_task"]) == 1 ? true : false,
                    IsCompleted = int.Parse(vals["is_completed"]) == 1 ? true : false
                });
            }
            addTasksToListView(tasks);
            Program.connection.Close();
        }

        private void addTasksToListView(List<Activity> tasks)
        {
            tasks.ForEach(task => {
                //dg_tasks.Rows.Add(new object[] { task.Description,
                //    task.EstimatedPomodoros.ToString(),
                //    task.ActualPomodoros.ToString(),
                //    task.Interruptions.ToString(),
                //    task.IsCompleted.ToString()}
                //    );
                var item = list_tasks.Items.Add(task.Description);
                item.SubItems.Add(task.EstimatedPomodoros.ToString());
                item.SubItems.Add(task.ActualPomodoros.ToString());
                item.SubItems.Add(task.Interruptions.ToString());
                item.SubItems.Add(task.IsCompleted.ToString());
            });

        }

        private void btn_activity_list_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.activityDialog.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
