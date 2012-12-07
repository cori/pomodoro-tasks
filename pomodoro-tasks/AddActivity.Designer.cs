namespace pomodoro_tasks
{
    partial class AddActivity
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_activity_description
            // 
            this.txt_activity_description.Location = new System.Drawing.Point(12, 37);
            this.txt_activity_description.Name = "txt_activity_description";
            this.txt_activity_description.Size = new System.Drawing.Size(322, 20);
            this.txt_activity_description.TabIndex = 0;
            this.txt_activity_description.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            this.txt_activity_description.Validating += new System.ComponentModel.CancelEventHandler(this.txt_activity_description_Validating);
            // 
            // btn_add_activity
            // 
            this.btn_add_activity.Location = new System.Drawing.Point(452, 35);
            this.btn_add_activity.Name = "btn_add_activity";
            this.btn_add_activity.Size = new System.Drawing.Size(75, 23);
            this.btn_add_activity.TabIndex = 2;
            this.btn_add_activity.Text = "Add Activity";
            this.btn_add_activity.UseVisualStyleBackColor = true;
            this.btn_add_activity.Click += new System.EventHandler(this.btn_add_activity_Click);
            // 
            // lbl_actity_description
            // 
            this.lbl_actity_description.AutoSize = true;
            this.lbl_actity_description.Location = new System.Drawing.Point(12, 18);
            this.lbl_actity_description.Name = "lbl_actity_description";
            this.lbl_actity_description.Size = new System.Drawing.Size(97, 13);
            this.lbl_actity_description.TabIndex = 3;
            this.lbl_actity_description.Text = "Activity Description";
            // 
            // lbl_actity_estimate
            // 
            this.lbl_actity_estimate.AutoSize = true;
            this.lbl_actity_estimate.Location = new System.Drawing.Point(346, 17);
            this.lbl_actity_estimate.Name = "lbl_actity_estimate";
            this.lbl_actity_estimate.Size = new System.Drawing.Size(81, 13);
            this.lbl_actity_estimate.TabIndex = 4;
            this.lbl_actity_estimate.Text = "Est. Pomodoros";
            // 
            // txt_activity_estimate
            // 
            this.txt_activity_estimate.Location = new System.Drawing.Point(349, 36);
            this.txt_activity_estimate.Mask = "0";
            this.txt_activity_estimate.Name = "txt_activity_estimate";
            this.txt_activity_estimate.PromptChar = '?';
            this.txt_activity_estimate.Size = new System.Drawing.Size(78, 20);
            this.txt_activity_estimate.TabIndex = 2;
            this.txt_activity_estimate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_activity_estimate_MaskInputRejected);
            this.txt_activity_estimate.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            this.txt_activity_estimate.Validating += new System.ComponentModel.CancelEventHandler(this.add_activity_form_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(453, 447);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_view_task_list
            // 
            this.btn_view_task_list.Location = new System.Drawing.Point(372, 447);
            this.btn_view_task_list.Name = "btn_view_task_list";
            this.btn_view_task_list.Size = new System.Drawing.Size(75, 23);
            this.btn_view_task_list.TabIndex = 6;
            this.btn_view_task_list.Text = "View Tasks";
            this.btn_view_task_list.UseVisualStyleBackColor = true;
            // 
            // list_tasks
            // 
            this.list_tasks.FormattingEnabled = true;
            this.list_tasks.Location = new System.Drawing.Point(297, 64);
            this.list_tasks.Name = "list_tasks";
            this.list_tasks.Size = new System.Drawing.Size(231, 368);
            this.list_tasks.TabIndex = 7;
            // 
            // list_activities
            // 
            this.list_activities.FormattingEnabled = true;
            this.list_activities.Location = new System.Drawing.Point(12, 63);
            this.list_activities.Name = "list_activities";
            this.list_activities.Size = new System.Drawing.Size(231, 368);
            this.list_activities.TabIndex = 8;
            // 
            // btn_move_activity_to_tasks
            // 
            this.btn_move_activity_to_tasks.Location = new System.Drawing.Point(250, 183);
            this.btn_move_activity_to_tasks.Name = "btn_move_activity_to_tasks";
            this.btn_move_activity_to_tasks.Size = new System.Drawing.Size(41, 23);
            this.btn_move_activity_to_tasks.TabIndex = 9;
            this.btn_move_activity_to_tasks.Text = ">>";
            this.btn_move_activity_to_tasks.UseVisualStyleBackColor = true;
            // 
            // btn_move_task_to_activities
            // 
            this.btn_move_task_to_activities.Location = new System.Drawing.Point(250, 230);
            this.btn_move_task_to_activities.Name = "btn_move_task_to_activities";
            this.btn_move_task_to_activities.Size = new System.Drawing.Size(41, 23);
            this.btn_move_task_to_activities.TabIndex = 10;
            this.btn_move_task_to_activities.Text = "<<";
            this.btn_move_task_to_activities.UseVisualStyleBackColor = true;
            // 
            // AddActivity
            // 
            this.AcceptButton = this.btn_add_activity;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 482);
            this.Controls.Add(this.btn_move_task_to_activities);
            this.Controls.Add(this.btn_move_activity_to_tasks);
            this.Controls.Add(this.list_activities);
            this.Controls.Add(this.list_tasks);
            this.Controls.Add(this.btn_view_task_list);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_activity_estimate);
            this.Controls.Add(this.lbl_actity_estimate);
            this.Controls.Add(this.lbl_actity_description);
            this.Controls.Add(this.btn_add_activity);
            this.Controls.Add(this.txt_activity_description);
            this.Name = "AddActivity";
            this.Text = "Add Activity";
            this.Load += new System.EventHandler(this.AddActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}