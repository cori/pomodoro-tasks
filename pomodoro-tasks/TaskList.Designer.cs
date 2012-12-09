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
            this.list_tasks = new System.Windows.Forms.ListView();
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estimated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Actual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Interruptions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Complete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dg_tasks = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterruptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompleteCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            // list_tasks
            // 
            this.list_tasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description,
            this.Estimated,
            this.Actual,
            this.Interruptions,
            this.Complete});
            this.list_tasks.Location = new System.Drawing.Point(12, 29);
            this.list_tasks.Name = "list_tasks";
            this.list_tasks.Size = new System.Drawing.Size(718, 259);
            this.list_tasks.TabIndex = 4;
            this.list_tasks.UseCompatibleStateImageBehavior = false;
            this.list_tasks.View = System.Windows.Forms.View.Details;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 359;
            // 
            // Estimated
            // 
            this.Estimated.Text = "Estimated";
            this.Estimated.Width = 96;
            // 
            // Actual
            // 
            this.Actual.Text = "Actual";
            this.Actual.Width = 82;
            // 
            // Interruptions
            // 
            this.Interruptions.Text = "Interruptions";
            this.Interruptions.Width = 83;
            // 
            // Complete
            // 
            this.Complete.Text = "Complete";
            this.Complete.Width = 93;
            // 
            // dg_tasks
            // 
            this.dg_tasks.AllowUserToAddRows = false;
            this.dg_tasks.AllowUserToDeleteRows = false;
            this.dg_tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_tasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DescriptionCol,
            this.EstimatedCol,
            this.ActualCol,
            this.InterruptionCol,
            this.CompleteCol});
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
            // DescriptionCol
            // 
            this.DescriptionCol.HeaderText = "Description";
            this.DescriptionCol.Name = "DescriptionCol";
            this.DescriptionCol.ReadOnly = true;
            this.DescriptionCol.Width = 365;
            // 
            // EstimatedCol
            // 
            this.EstimatedCol.HeaderText = "Estimated";
            this.EstimatedCol.Name = "EstimatedCol";
            this.EstimatedCol.ReadOnly = true;
            this.EstimatedCol.Width = 70;
            // 
            // ActualCol
            // 
            this.ActualCol.HeaderText = "Actual";
            this.ActualCol.Name = "ActualCol";
            this.ActualCol.ReadOnly = true;
            this.ActualCol.Width = 70;
            // 
            // InterruptionCol
            // 
            this.InterruptionCol.HeaderText = "Interruptions";
            this.InterruptionCol.Name = "InterruptionCol";
            this.InterruptionCol.ReadOnly = true;
            this.InterruptionCol.Width = 70;
            // 
            // CompleteCol
            // 
            this.CompleteCol.HeaderText = "Complete";
            this.CompleteCol.Name = "CompleteCol";
            this.CompleteCol.ReadOnly = true;
            this.CompleteCol.Width = 70;
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
            this.Controls.Add(this.list_tasks);
            this.Name = "TaskList";
            this.Text = "TaskList";
            this.Activated += new System.EventHandler(this.TaskList_Activate);
            ((System.ComponentModel.ISupportInitialize)(this.dg_tasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tasks;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_activity_list;
        private System.Windows.Forms.ListView list_tasks;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Estimated;
        private System.Windows.Forms.ColumnHeader Actual;
        private System.Windows.Forms.ColumnHeader Interruptions;
        private System.Windows.Forms.ColumnHeader Complete;
        private System.Windows.Forms.DataGridView dg_tasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterruptionCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CompleteCol;
    }
}