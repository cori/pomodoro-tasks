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
    public partial class AddActivity : Form
    {

        private void AddActivity_Load(object sender, EventArgs e)
        {
            ReloadListBoxes();
        }

        private void ReloadListBoxes()
        {
            Program.connection.Open();
            SQLiteCommand getActivities = new SQLiteCommand("select activity_desc, estimated from activities where is_active_task = 0", Program.connection);
            SQLiteCommand getTasks = new SQLiteCommand("select activity_desc, estimated from activities where is_active_task = 1", Program.connection);
            //var activitiesReader = getActivities.ExecuteReader();
            //var tasksReader = getTasks.ExecuteReader();
            //var activityVals = activitiesReader.GetValues();
            //var taskVals = tasksReader.GetValues();


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

        public AddActivity()
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
    
    }

}
