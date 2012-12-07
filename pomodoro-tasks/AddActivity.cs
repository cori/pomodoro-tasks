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

            SQLiteCommand getActivities = "select activity_desc, estimated from activities where is_active_task = 0";
            SQLiteCommand getTasks = "select activity_desc, estimated from activities where is_active_task = 1";

            throw new NotImplementedException();
        }

        public AddActivity()
        {
            InitializeComponent();
        }

        private void btn_add_activity_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
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

        }

        private void txt_activity_estimate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.errorProvider1.SetError(this.txt_activity_estimate,"Only numeric values are valid");
        }

        private void add_activity_form_Validating(object sender, CancelEventArgs e)
        {
            var cancel = false;
            int val;
            if(!int.TryParse(txt_activity_estimate.Text, out val)){
                cancel = true;
                this.errorProvider1.SetError(this.txt_activity_estimate, "Only numeric values are valid");
            }
            e.Cancel = cancel;
        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {
           this.errorProvider1.Clear();
        }

        private void txt_activity_description_Validating(object sender, CancelEventArgs e)
        {
            var cancel = false;
            int val;
            if (string.IsNullOrWhiteSpace(this.txt_activity_description.Text)) {
                cancel = true;
                this.errorProvider1.SetError(this.txt_activity_description, "Activity name must be provided");
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
