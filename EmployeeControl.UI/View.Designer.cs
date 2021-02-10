
namespace EmployeeControl.UI
{
    partial class View
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.view_all_emp = new System.Windows.Forms.Button();
            this.view_by_dept = new System.Windows.Forms.Button();
            this.view_by_salary = new System.Windows.Forms.Button();
            this.view_unassigned = new System.Windows.Forms.Button();
            this.view_all_everything = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.LinkLabel();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(775, 372);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // view_all_emp
            // 
            this.view_all_emp.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_all_emp.Location = new System.Drawing.Point(50, 427);
            this.view_all_emp.Name = "view_all_emp";
            this.view_all_emp.Size = new System.Drawing.Size(187, 72);
            this.view_all_emp.TabIndex = 37;
            this.view_all_emp.Text = "View All Employees";
            this.view_all_emp.UseVisualStyleBackColor = true;
            this.view_all_emp.Click += new System.EventHandler(this.view_all_emp_Click);
            // 
            // view_by_dept
            // 
            this.view_by_dept.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_by_dept.Location = new System.Drawing.Point(531, 427);
            this.view_by_dept.Name = "view_by_dept";
            this.view_by_dept.Size = new System.Drawing.Size(187, 72);
            this.view_by_dept.TabIndex = 38;
            this.view_by_dept.Text = "View by Department";
            this.view_by_dept.UseVisualStyleBackColor = true;
            this.view_by_dept.Click += new System.EventHandler(this.view_by_dept_Click);
            // 
            // view_by_salary
            // 
            this.view_by_salary.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_by_salary.Location = new System.Drawing.Point(296, 444);
            this.view_by_salary.Name = "view_by_salary";
            this.view_by_salary.Size = new System.Drawing.Size(187, 142);
            this.view_by_salary.TabIndex = 39;
            this.view_by_salary.Text = "View All Earning between 150,000 and 300,000";
            this.view_by_salary.UseVisualStyleBackColor = true;
            this.view_by_salary.Click += new System.EventHandler(this.view_by_salary_Click);
            // 
            // view_unassigned
            // 
            this.view_unassigned.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_unassigned.Location = new System.Drawing.Point(50, 530);
            this.view_unassigned.Name = "view_unassigned";
            this.view_unassigned.Size = new System.Drawing.Size(187, 72);
            this.view_unassigned.TabIndex = 40;
            this.view_unassigned.Text = "View Unassigned Departments";
            this.view_unassigned.UseVisualStyleBackColor = true;
            this.view_unassigned.Click += new System.EventHandler(this.view_unassigned_Click);
            // 
            // view_all_everything
            // 
            this.view_all_everything.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_all_everything.Location = new System.Drawing.Point(531, 530);
            this.view_all_everything.Name = "view_all_everything";
            this.view_all_everything.Size = new System.Drawing.Size(187, 72);
            this.view_all_everything.TabIndex = 41;
            this.view_all_everything.Text = "View All Employees and Departments";
            this.view_all_everything.UseVisualStyleBackColor = true;
            this.view_all_everything.Click += new System.EventHandler(this.view_all_everything_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back.Location = new System.Drawing.Point(50, 616);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(78, 20);
            this.back.TabIndex = 42;
            this.back.TabStop = true;
            this.back.Text = "Go Back";
            this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_LinkClicked);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(667, 391);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(121, 30);
            this.clear.TabIndex = 43;
            this.clear.Text = "Clear All";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.back);
            this.Controls.Add(this.view_all_everything);
            this.Controls.Add(this.view_unassigned);
            this.Controls.Add(this.view_by_salary);
            this.Controls.Add(this.view_by_dept);
            this.Controls.Add(this.view_all_emp);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button view_all_emp;
        private System.Windows.Forms.Button view_by_dept;
        private System.Windows.Forms.Button view_by_salary;
        private System.Windows.Forms.Button view_unassigned;
        private System.Windows.Forms.Button view_all_everything;
        private System.Windows.Forms.LinkLabel back;
        private System.Windows.Forms.Button clear;
    }
}