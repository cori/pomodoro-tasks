namespace pomodoro_tasks
{
    partial class ActivityDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_activities = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_actity_description = new System.Windows.Forms.Label();
            this.txt_activity_description = new System.Windows.Forms.TextBox();
            this.btn_add_activity = new System.Windows.Forms.Button();
            this.lbl_actity_estimate = new System.Windows.Forms.Label();
            this.txt_activity_estimate = new System.Windows.Forms.MaskedTextBox();
            this.btn_move_task_to_activities = new System.Windows.Forms.Button();
            this.btn_move_activity_to_tasks = new System.Windows.Forms.Button();
            this.list_activities = new System.Windows.Forms.ListBox();
            this.list_tasks = new System.Windows.Forms.ListBox();
            this.btn_view_task_list = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_tasks = new System.Windows.Forms.Panel();
            this.btn_activity_list = new System.Windows.Forms.Button();
            this.btn_tasks_exit = new System.Windows.Forms.Button();
            this.lbl_tasks = new System.Windows.Forms.Label();
            this.dg_tasks = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estimated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interruptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnl_activities.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl_tasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnl_activities
            // 
            this.pnl_activities.Controls.Add(this.groupBox1);
            this.pnl_activities.Controls.Add(this.btn_move_task_to_activities);
            this.pnl_activities.Controls.Add(this.btn_move_activity_to_tasks);
            this.pnl_activities.Controls.Add(this.list_activities);
            this.pnl_activities.Controls.Add(this.list_tasks);
            this.pnl_activities.Controls.Add(this.btn_view_task_list);
            this.pnl_activities.Controls.Add(this.btn_exit);
            this.pnl_activities.Location = new System.Drawing.Point(9, 4);
            this.pnl_activities.Name = "pnl_activities";
            this.pnl_activities.Size = new System.Drawing.Size(701, 497);
            this.pnl_activities.TabIndex = 12;
            this.pnl_activities.VisibleChanged += new System.EventHandler(this.AddActivity_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_actity_description);
            this.groupBox1.Controls.Add(this.txt_activity_description);
            this.groupBox1.Controls.Add(this.btn_add_activity);
            this.groupBox1.Controls.Add(this.lbl_actity_estimate);
            this.groupBox1.Controls.Add(this.txt_activity_estimate);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 72);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add an activity";
            // 
            // lbl_actity_description
            // 
            this.lbl_actity_description.AutoSize = true;
            this.lbl_actity_description.Location = new System.Drawing.Point(6, 20);
            this.lbl_actity_description.Name = "lbl_actity_description";
            this.lbl_actity_description.Size = new System.Drawing.Size(97, 13);
            this.lbl_actity_description.TabIndex = 3;
            this.lbl_actity_description.Text = "Activity Description";
            // 
            // txt_activity_description
            // 
            this.txt_activity_description.CausesValidation = false;
            this.txt_activity_description.Location = new System.Drawing.Point(6, 38);
            this.txt_activity_description.Name = "txt_activity_description";
            this.txt_activity_description.Size = new System.Drawing.Size(505, 20);
            this.txt_activity_description.TabIndex = 0;
            // 
            // btn_add_activity
            // 
            this.btn_add_activity.Location = new System.Drawing.Point(616, 37);
            this.btn_add_activity.Name = "btn_add_activity";
            this.btn_add_activity.Size = new System.Drawing.Size(75, 23);
            this.btn_add_activity.TabIndex = 2;
            this.btn_add_activity.Text = "Add Activity";
            this.btn_add_activity.UseVisualStyleBackColor = true;
            this.btn_add_activity.Click += new System.EventHandler(this.btn_add_activity_Click);
            // 
            // lbl_actity_estimate
            // 
            this.lbl_actity_estimate.AutoSize = true;
            this.lbl_actity_estimate.Location = new System.Drawing.Point(514, 20);
            this.lbl_actity_estimate.Name = "lbl_actity_estimate";
            this.lbl_actity_estimate.Size = new System.Drawing.Size(81, 13);
            this.lbl_actity_estimate.TabIndex = 4;
            this.lbl_actity_estimate.Text = "Est. Pomodoros";
            // 
            // txt_activity_estimate
            // 
            this.txt_activity_estimate.CausesValidation = false;
            this.txt_activity_estimate.Location = new System.Drawing.Point(517, 39);
            this.txt_activity_estimate.Mask = "0";
            this.txt_activity_estimate.Name = "txt_activity_estimate";
            this.txt_activity_estimate.PromptChar = '?';
            this.txt_activity_estimate.Size = new System.Drawing.Size(78, 20);
            this.txt_activity_estimate.TabIndex = 1;
            // 
            // btn_move_task_to_activities
            // 
            this.btn_move_task_to_activities.CausesValidation = false;
            this.btn_move_task_to_activities.Location = new System.Drawing.Point(330, 272);
            this.btn_move_task_to_activities.Name = "btn_move_task_to_activities";
            this.btn_move_task_to_activities.Size = new System.Drawing.Size(41, 23);
            this.btn_move_task_to_activities.TabIndex = 6;
            this.btn_move_task_to_activities.Text = "<<";
            this.btn_move_task_to_activities.UseVisualStyleBackColor = true;
            this.btn_move_task_to_activities.Click += new System.EventHandler(this.btn_move_task_to_activities_Click);
            // 
            // btn_move_activity_to_tasks
            // 
            this.btn_move_activity_to_tasks.CausesValidation = false;
            this.btn_move_activity_to_tasks.Location = new System.Drawing.Point(330, 226);
            this.btn_move_activity_to_tasks.Name = "btn_move_activity_to_tasks";
            this.btn_move_activity_to_tasks.Size = new System.Drawing.Size(41, 23);
            this.btn_move_activity_to_tasks.TabIndex = 4;
            this.btn_move_activity_to_tasks.Text = ">>";
            this.btn_move_activity_to_tasks.UseVisualStyleBackColor = true;
            this.btn_move_activity_to_tasks.Click += new System.EventHandler(this.btn_move_activity_to_tasks_Click);
            // 
            // list_activities
            // 
            this.list_activities.FormattingEnabled = true;
            this.list_activities.Location = new System.Drawing.Point(3, 82);
            this.list_activities.Name = "list_activities";
            this.list_activities.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list_activities.Size = new System.Drawing.Size(312, 368);
            this.list_activities.TabIndex = 3;
            // 
            // list_tasks
            // 
            this.list_tasks.FormattingEnabled = true;
            this.list_tasks.Location = new System.Drawing.Point(386, 82);
            this.list_tasks.Name = "list_tasks";
            this.list_tasks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list_tasks.Size = new System.Drawing.Size(312, 368);
            this.list_tasks.TabIndex = 5;
            // 
            // btn_view_task_list
            // 
            this.btn_view_task_list.CausesValidation = false;
            this.btn_view_task_list.Location = new System.Drawing.Point(517, 465);
            this.btn_view_task_list.Name = "btn_view_task_list";
            this.btn_view_task_list.Size = new System.Drawing.Size(85, 23);
            this.btn_view_task_list.TabIndex = 7;
            this.btn_view_task_list.Text = "View Tasks";
            this.btn_view_task_list.UseVisualStyleBackColor = true;
            this.btn_view_task_list.Click += new System.EventHandler(this.btn_view_task_list_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.CausesValidation = false;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(609, 465);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(85, 23);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_tasks
            // 
            this.pnl_tasks.Controls.Add(this.btn_activity_list);
            this.pnl_tasks.Controls.Add(this.btn_tasks_exit);
            this.pnl_tasks.Controls.Add(this.lbl_tasks);
            this.pnl_tasks.Controls.Add(this.dg_tasks);
            this.pnl_tasks.Location = new System.Drawing.Point(9, 4);
            this.pnl_tasks.Name = "pnl_tasks";
            this.pnl_tasks.Size = new System.Drawing.Size(701, 497);
            this.pnl_tasks.TabIndex = 17;
            this.pnl_tasks.Visible = false;
            // 
            // btn_activity_list
            // 
            this.btn_activity_list.Location = new System.Drawing.Point(518, 465);
            this.btn_activity_list.Name = "btn_activity_list";
            this.btn_activity_list.Size = new System.Drawing.Size(85, 23);
            this.btn_activity_list.TabIndex = 8;
            this.btn_activity_list.Text = "View Activities";
            this.btn_activity_list.UseVisualStyleBackColor = true;
            this.btn_activity_list.Click += new System.EventHandler(this.btn_activity_list_Click);
            // 
            // btn_tasks_exit
            // 
            this.btn_tasks_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_tasks_exit.Location = new System.Drawing.Point(610, 465);
            this.btn_tasks_exit.Name = "btn_tasks_exit";
            this.btn_tasks_exit.Size = new System.Drawing.Size(85, 23);
            this.btn_tasks_exit.TabIndex = 7;
            this.btn_tasks_exit.Text = "Exit";
            this.btn_tasks_exit.UseVisualStyleBackColor = true;
            this.btn_tasks_exit.Click += new System.EventHandler(this.btn_tasks_exit_Click);
            // 
            // lbl_tasks
            // 
            this.lbl_tasks.AutoSize = true;
            this.lbl_tasks.Location = new System.Drawing.Point(6, 6);
            this.lbl_tasks.Name = "lbl_tasks";
            this.lbl_tasks.Size = new System.Drawing.Size(36, 13);
            this.lbl_tasks.TabIndex = 6;
            this.lbl_tasks.Text = "Tasks";
            // 
            // dg_tasks
            // 
            this.dg_tasks.AllowUserToAddRows = false;
            this.dg_tasks.AllowUserToDeleteRows = false;
            this.dg_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_tasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.Estimated,
            this.Actual,
            this.Interruptions,
            this.Completed});
            this.dg_tasks.Location = new System.Drawing.Point(6, 22);
            this.dg_tasks.MultiSelect = false;
            this.dg_tasks.Name = "dg_tasks";
            this.dg_tasks.ReadOnly = true;
            this.dg_tasks.RowHeadersVisible = false;
            this.dg_tasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_tasks.ShowEditingIcon = false;
            this.dg_tasks.Size = new System.Drawing.Size(689, 437);
            this.dg_tasks.TabIndex = 9;
            this.dg_tasks.TabStop = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 365;
            // 
            // Estimated
            // 
            this.Estimated.HeaderText = "Estimated";
            this.Estimated.Name = "Estimated";
            this.Estimated.ReadOnly = true;
            this.Estimated.Width = 70;
            // 
            // Actual
            // 
            this.Actual.HeaderText = "Actual";
            this.Actual.Name = "Actual";
            this.Actual.ReadOnly = true;
            this.Actual.Width = 70;
            // 
            // Interruptions
            // 
            this.Interruptions.HeaderText = "Interruptions";
            this.Interruptions.Name = "Interruptions";
            this.Interruptions.ReadOnly = true;
            this.Interruptions.Width = 70;
            // 
            // Completed
            // 
            this.Completed.HeaderText = "Complete";
            this.Completed.Name = "Completed";
            this.Completed.ReadOnly = true;
            this.Completed.Width = 70;
            // 
            // ActivityDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 511);
            this.Controls.Add(this.pnl_activities);
            this.Controls.Add(this.pnl_tasks);
            this.Name = "ActivityDialog";
            this.Text = "Activities";
            this.Load += new System.EventHandler(this.AddActivity_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ActivityDialog_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnl_activities.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_tasks.ResumeLayout(false);
            this.pnl_tasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnl_activities;
        private System.Windows.Forms.Button btn_move_task_to_activities;
        private System.Windows.Forms.Button btn_move_activity_to_tasks;
        private System.Windows.Forms.ListBox list_activities;
        private System.Windows.Forms.ListBox list_tasks;
        private System.Windows.Forms.Button btn_view_task_list;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel pnl_tasks;
        private System.Windows.Forms.Button btn_activity_list;
        private System.Windows.Forms.Button btn_tasks_exit;
        private System.Windows.Forms.Label lbl_tasks;
        private System.Windows.Forms.DataGridView dg_tasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estimated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interruptions;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_actity_description;
        private System.Windows.Forms.TextBox txt_activity_description;
        private System.Windows.Forms.Button btn_add_activity;
        private System.Windows.Forms.Label lbl_actity_estimate;
        private System.Windows.Forms.MaskedTextBox txt_activity_estimate;
    }
}