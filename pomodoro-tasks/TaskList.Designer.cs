namespace pomodoro_tasks
{
    partial class TaskList
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
            this.lbl_tasks = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_activity_list = new System.Windows.Forms.Button();
            this.dg_tasks = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estimated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interruptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tasks
            // 
            this.lbl_tasks.AutoSize = true;
            this.lbl_tasks.Location = new System.Drawing.Point(13, 13);
            this.lbl_tasks.Name = "lbl_tasks";
            this.lbl_tasks.Size = new System.Drawing.Size(36, 13);
            this.lbl_tasks.TabIndex = 1;
            this.lbl_tasks.Text = "Tasks";
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(652, 294);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(85, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_activity_list
            // 
            this.btn_activity_list.Location = new System.Drawing.Point(560, 294);
            this.btn_activity_list.Name = "btn_activity_list";
            this.btn_activity_list.Size = new System.Drawing.Size(85, 23);
            this.btn_activity_list.TabIndex = 3;
            this.btn_activity_list.Text = "View Activities";
            this.btn_activity_list.UseVisualStyleBackColor = true;
            this.btn_activity_list.Click += new System.EventHandler(this.btn_activity_list_Click);
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
            this.dg_tasks.Location = new System.Drawing.Point(12, 29);
            this.dg_tasks.MultiSelect = false;
            this.dg_tasks.Name = "dg_tasks";
            this.dg_tasks.ReadOnly = true;
            this.dg_tasks.ShowEditingIcon = false;
            this.dg_tasks.Size = new System.Drawing.Size(718, 259);
            this.dg_tasks.TabIndex = 5;
            this.dg_tasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_tasks_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
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
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(742, 329);
            this.Controls.Add(this.btn_activity_list);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_tasks);
            this.Controls.Add(this.dg_tasks);
            this.Name = "TaskList";
            this.Text = "TaskList";
            ((System.ComponentModel.ISupportInitialize)(this.dg_tasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tasks;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_activity_list;
        private System.Windows.Forms.DataGridView dg_tasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estimated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interruptions;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completed;
    }
}