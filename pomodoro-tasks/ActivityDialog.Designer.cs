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
            this.txt_activity_description = new System.Windows.Forms.TextBox();
            this.btn_add_activity = new System.Windows.Forms.Button();
            this.lbl_actity_description = new System.Windows.Forms.Label();
            this.lbl_actity_estimate = new System.Windows.Forms.Label();
            this.txt_activity_estimate = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_view_task_list = new System.Windows.Forms.Button();
            this.list_tasks = new System.Windows.Forms.ListBox();
            this.list_activities = new System.Windows.Forms.ListBox();
            this.btn_move_activity_to_tasks = new System.Windows.Forms.Button();
            this.btn_move_task_to_activities = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_activity_description
            // 
            this.txt_activity_description.CausesValidation = false;
            this.txt_activity_description.Location = new System.Drawing.Point(6, 41);
            this.txt_activity_description.Name = "txt_activity_description";
            this.txt_activity_description.Size = new System.Drawing.Size(322, 20);
            this.txt_activity_description.TabIndex = 0;
            this.txt_activity_description.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            // 
            // btn_add_activity
            // 
            this.btn_add_activity.Location = new System.Drawing.Point(446, 39);
            this.btn_add_activity.Name = "btn_add_activity";
            this.btn_add_activity.Size = new System.Drawing.Size(75, 23);
            this.btn_add_activity.TabIndex = 2;
            this.btn_add_activity.Text = "Add Activity";
            this.btn_add_activity.UseVisualStyleBackColor = true;
            this.btn_add_activity.Click += new System.EventHandler(this.btn_add_activity_Click);
            this.btn_add_activity.Validating += new System.ComponentModel.CancelEventHandler(this.add_activity_Validating);
            // 
            // lbl_actity_description
            // 
            this.lbl_actity_description.AutoSize = true;
            this.lbl_actity_description.Location = new System.Drawing.Point(6, 22);
            this.lbl_actity_description.Name = "lbl_actity_description";
            this.lbl_actity_description.Size = new System.Drawing.Size(97, 13);
            this.lbl_actity_description.TabIndex = 3;
            this.lbl_actity_description.Text = "Activity Description";
            // 
            // lbl_actity_estimate
            // 
            this.lbl_actity_estimate.AutoSize = true;
            this.lbl_actity_estimate.Location = new System.Drawing.Point(340, 21);
            this.lbl_actity_estimate.Name = "lbl_actity_estimate";
            this.lbl_actity_estimate.Size = new System.Drawing.Size(81, 13);
            this.lbl_actity_estimate.TabIndex = 4;
            this.lbl_actity_estimate.Text = "Est. Pomodoros";
            // 
            // txt_activity_estimate
            // 
            this.txt_activity_estimate.CausesValidation = false;
            this.txt_activity_estimate.Location = new System.Drawing.Point(343, 40);
            this.txt_activity_estimate.Mask = "0";
            this.txt_activity_estimate.Name = "txt_activity_estimate";
            this.txt_activity_estimate.PromptChar = '?';
            this.txt_activity_estimate.Size = new System.Drawing.Size(78, 20);
            this.txt_activity_estimate.TabIndex = 2;
            this.txt_activity_estimate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_activity_estimate_MaskInputRejected);
            this.txt_activity_estimate.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_exit
            // 
            this.btn_exit.CausesValidation = false;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(453, 480);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_view_task_list
            // 
            this.btn_view_task_list.CausesValidation = false;
            this.btn_view_task_list.Location = new System.Drawing.Point(372, 480);
            this.btn_view_task_list.Name = "btn_view_task_list";
            this.btn_view_task_list.Size = new System.Drawing.Size(75, 23);
            this.btn_view_task_list.TabIndex = 6;
            this.btn_view_task_list.Text = "View Tasks";
            this.btn_view_task_list.UseVisualStyleBackColor = true;
            this.btn_view_task_list.Click += new System.EventHandler(this.btn_view_task_list_Click);
            // 
            // list_tasks
            // 
            this.list_tasks.FormattingEnabled = true;
            this.list_tasks.Location = new System.Drawing.Point(297, 97);
            this.list_tasks.Name = "list_tasks";
            this.list_tasks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list_tasks.Size = new System.Drawing.Size(231, 368);
            this.list_tasks.TabIndex = 7;
            // 
            // list_activities
            // 
            this.list_activities.FormattingEnabled = true;
            this.list_activities.Location = new System.Drawing.Point(12, 96);
            this.list_activities.Name = "list_activities";
            this.list_activities.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list_activities.Size = new System.Drawing.Size(231, 368);
            this.list_activities.TabIndex = 8;
            // 
            // btn_move_activity_to_tasks
            // 
            this.btn_move_activity_to_tasks.CausesValidation = false;
            this.btn_move_activity_to_tasks.Location = new System.Drawing.Point(250, 234);
            this.btn_move_activity_to_tasks.Name = "btn_move_activity_to_tasks";
            this.btn_move_activity_to_tasks.Size = new System.Drawing.Size(41, 23);
            this.btn_move_activity_to_tasks.TabIndex = 9;
            this.btn_move_activity_to_tasks.Text = ">>";
            this.btn_move_activity_to_tasks.UseVisualStyleBackColor = true;
            this.btn_move_activity_to_tasks.Click += new System.EventHandler(this.btn_move_activity_to_tasks_Click);
            // 
            // btn_move_task_to_activities
            // 
            this.btn_move_task_to_activities.CausesValidation = false;
            this.btn_move_task_to_activities.Location = new System.Drawing.Point(250, 281);
            this.btn_move_task_to_activities.Name = "btn_move_task_to_activities";
            this.btn_move_task_to_activities.Size = new System.Drawing.Size(41, 23);
            this.btn_move_task_to_activities.TabIndex = 10;
            this.btn_move_task_to_activities.Text = "<<";
            this.btn_move_task_to_activities.UseVisualStyleBackColor = true;
            this.btn_move_task_to_activities.Click += new System.EventHandler(this.btn_move_task_to_activities_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_actity_description);
            this.groupBox1.Controls.Add(this.txt_activity_description);
            this.groupBox1.Controls.Add(this.btn_add_activity);
            this.groupBox1.Controls.Add(this.lbl_actity_estimate);
            this.groupBox1.Controls.Add(this.txt_activity_estimate);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 72);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add an activity";
            // 
            // ActivityDialog
            // 
            this.AcceptButton = this.btn_add_activity;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(540, 511);
            this.Controls.Add(this.btn_move_task_to_activities);
            this.Controls.Add(this.btn_move_activity_to_tasks);
            this.Controls.Add(this.list_activities);
            this.Controls.Add(this.list_tasks);
            this.Controls.Add(this.btn_view_task_list);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox1);
            this.Name = "ActivityDialog";
            this.Text = "Activities";
            this.Load += new System.EventHandler(this.AddActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_activity_description;
        private System.Windows.Forms.Button btn_add_activity;
        private System.Windows.Forms.Label lbl_actity_description;
        private System.Windows.Forms.Label lbl_actity_estimate;
        private System.Windows.Forms.MaskedTextBox txt_activity_estimate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_move_task_to_activities;
        private System.Windows.Forms.Button btn_move_activity_to_tasks;
        private System.Windows.Forms.ListBox list_activities;
        private System.Windows.Forms.ListBox list_tasks;
        private System.Windows.Forms.Button btn_view_task_list;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}