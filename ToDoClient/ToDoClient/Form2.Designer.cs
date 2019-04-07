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
            this.completeTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.getDescription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 36);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 276);
            this.listBox1.TabIndex = 0;
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(364, 36);
            this.addTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(108, 37);
            this.addTask.TabIndex = 1;
            this.addTask.Text = "Add";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(364, 87);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(108, 37);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(364, 139);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(108, 37);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // taskTitle
            // 
            this.taskTitle.AutoSize = true;
            this.taskTitle.Location = new System.Drawing.Point(536, 36);
            this.taskTitle.Name = "taskTitle";
            this.taskTitle.Size = new System.Drawing.Size(74, 17);
            this.taskTitle.TabIndex = 4;
            this.taskTitle.Text = "Task Title:";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(536, 107);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(83, 17);
            this.description.TabIndex = 5;
            this.description.Text = "Description:";
            // 
            // taskTitleBox
            // 
            this.taskTitleBox.Location = new System.Drawing.Point(539, 67);
            this.taskTitleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskTitleBox.Name = "taskTitleBox";
            this.taskTitleBox.Size = new System.Drawing.Size(191, 22);
            this.taskTitleBox.TabIndex = 6;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(539, 139);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(191, 69);
            this.descriptionBox.TabIndex = 7;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(563, 236);
            this.confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(139, 38);
            this.confirm.TabIndex = 8;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // completeTask
            // 
            this.completeTask.Location = new System.Drawing.Point(364, 192);
            this.completeTask.Name = "completeTask";
            this.completeTask.Size = new System.Drawing.Size(108, 55);
            this.completeTask.TabIndex = 9;
            this.completeTask.Text = "Complete Task";
            this.completeTask.UseVisualStyleBackColor = true;
            this.completeTask.Click += new System.EventHandler(this.completeTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(282, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 10;
            // 
            // getDescription
            // 
            this.getDescription.Location = new System.Drawing.Point(364, 265);
            this.getDescription.Name = "getDescription";
            this.getDescription.Size = new System.Drawing.Size(108, 47);
            this.getDescription.TabIndex = 11;
            this.getDescription.Text = "Get Description";
            this.getDescription.UseVisualStyleBackColor = true;
            this.getDescription.Click += new System.EventHandler(this.getDescription_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.getDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.completeTask);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.taskTitleBox);
            this.Controls.Add(this.description);
            this.Controls.Add(this.taskTitle);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button completeTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getDescription;
    }
}