using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

namespace pomodoro_tasks
{
    public partial class ActivityDialog : Form
    {

        private void AddActivity_Load(object sender, EventArgs e)
        {
            ReloadListBoxes();
        }

        public void ReloadListBoxes()
        {
            Program.connection.Open();
            SQLiteCommand getActivities = new SQLiteCommand("select id, activity_desc, estimated from activities where is_active_task = 0 and is_completed = 0", Program.connection);
            SQLiteCommand getTasks = new SQLiteCommand("select id, activity_desc, estimated from activities where is_active_task = 1 and is_completed = 0", Program.connection);

            SQLiteDataAdapter activitiesAdapter = new SQLiteDataAdapter(getActivities);
            SQLiteDataAdapter tasksAdapter = new SQLiteDataAdapter(getTasks);
            DataSet activitiesDS = new DataSet();
            DataSet tasksDS = new DataSet();
            activitiesAdapter.Fill(activitiesDS);
            tasksAdapter.Fill(tasksDS);
            list_activities.DataSource = activitiesDS.Tables[0];
            list_tasks.DataSource = tasksDS.Tables[0];

            list_activities.DisplayMember = "activity_desc";
            list_tasks.DisplayMember = "activity_desc";
            list_activities.Refresh();
            list_tasks.Refresh();
            Program.connection.Close();

        }

        public ActivityDialog()
        {
            InitializeComponent();
        }

        private void btn_add_activity_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren()) {
                var activity = new Activity {
                    Description = txt_activity_description.Text,
                    EstimatedPomodoros = int.Parse(txt_activity_estimate.Text),
                    ActualPomodoros = 0,
                    Interruptions = 0,
                    IsActiveTask = false,
                    IsCompleted = false
                };

                SQLiteCommand cmd = new SQLiteCommand(activity.MakeInsertStatement(), Program.connection);
                Program.connection.Open();
                cmd.ExecuteNonQuery();
                Program.connection.Close();

                txt_activity_description.Clear();
                txt_activity_description.Focus();
                txt_activity_estimate.Clear();

                ReloadListBoxes();
            }

        }

        private void txt_activity_estimate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.errorProvider1.SetError(this.txt_activity_estimate,"Only numeric values are valid");
        }

        //private void add_activity_form_Validating(object sender, CancelEventArgs e)
        //{
        //    var cancel = false;
        //    int val;
        //    if(!int.TryParse(txt_activity_estimate.Text, out val)){
        //        cancel = true;
        //        this.errorProvider1.SetError(this.txt_activity_estimate, "Only numeric values are valid");
        //    }
        //    e.Cancel = cancel;
        //}

        private void txtbox_TextChanged(object sender, EventArgs e)
        {
           this.errorProvider1.Clear();
        }

        private void add_activity_Validating(object sender, CancelEventArgs e)
        {
            var cancel = false;
            int val;
            if (string.IsNullOrWhiteSpace(this.txt_activity_description.Text)) {
                cancel = true;
                this.errorProvider1.SetError(this.txt_activity_description, "Activity name must be provided");
            }
            if (!int.TryParse(txt_activity_estimate.Text, out val)) {
                cancel = true;
                this.errorProvider1.SetError(this.txt_activity_estimate, "Only numeric values are valid");
            }
            e.Cancel = cancel;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
        }

        private void btn_view_task_list_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.taskDialog.RefreshTaskList();
            Program.taskDialog.Show();
        }

        private void btn_move_activity_to_tasks_Click(object sender, EventArgs e)
        {
            var items = list_activities.SelectedItems;
            StringBuilder query = new StringBuilder();
            foreach(var item in items) {
                var row = (DataRowView)item;
                Activity rowActivity = new Activity{
                    Id = int.Parse(row[0].ToString()),
                    Description = row[1].ToString(),
                    EstimatedPomodoros = int.Parse(row[2].ToString()),
                    IsActiveTask = true
                };
                query.AppendLine(rowActivity.MakeUpdateStatement());
            }

            SQLiteCommand update = new SQLiteCommand(query.ToString(), Program.connection);
            Program.connection.Open();
            update.ExecuteNonQuery();
            Program.connection.Close();
            ReloadListBoxes();
        }

        private void btn_move_task_to_activities_Click(object sender, EventArgs e)
        {
            var items = list_tasks.SelectedItems;
            StringBuilder query = new StringBuilder();
            foreach (var item in items) {
                var row = (DataRowView)item;
                Activity rowActivity = new Activity {
                    Id = int.Parse(row[0].ToString()),
                    Description = row[1].ToString(),
                    EstimatedPomodoros = int.Parse(row[2].ToString()),
                    IsActiveTask = false
                };
                query.AppendLine(rowActivity.MakeUpdateStatement());
            }

            SQLiteCommand update = new SQLiteCommand(query.ToString(), Program.connection);
            Program.connection.Open();
            update.ExecuteNonQuery();
            Program.connection.Close();
            ReloadListBoxes();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
