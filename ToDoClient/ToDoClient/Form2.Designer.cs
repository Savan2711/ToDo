namespace ToDoClient
{
    partial class Form2
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
            if (disposing && (components != null))
            {
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addTask = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.taskTitle = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.taskTitleBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(186, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 173);
            this.listBox1.TabIndex = 0;
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(186, 215);
            this.addTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(81, 30);
            this.addTask.TabIndex = 1;
            this.addTask.Text = "Add";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(284, 215);
            this.update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(74, 30);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(369, 215);
            this.delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(66, 30);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // taskTitle
            // 
            this.taskTitle.AutoSize = true;
            this.taskTitle.Location = new System.Drawing.Point(202, 282);
            this.taskTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taskTitle.Name = "taskTitle";
            this.taskTitle.Size = new System.Drawing.Size(57, 13);
            this.taskTitle.TabIndex = 4;
            this.taskTitle.Text = "Task Title:";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(202, 324);
            this.description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(63, 13);
            this.description.TabIndex = 5;
            this.description.Text = "Description:";
            // 
            // taskTitleBox
            // 
            this.taskTitleBox.Location = new System.Drawing.Point(284, 282);
            this.taskTitleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.taskTitleBox.Name = "taskTitleBox";
            this.taskTitleBox.Size = new System.Drawing.Size(144, 20);
            this.taskTitleBox.TabIndex = 6;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(284, 324);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(144, 20);
            this.descriptionBox.TabIndex = 7;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(262, 356);
            this.confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(104, 31);
            this.confirm.TabIndex = 8;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 396);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.taskTitleBox);
            this.Controls.Add(this.description);
            this.Controls.Add(this.taskTitle);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label taskTitle;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox taskTitleBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button confirm;
    }
}