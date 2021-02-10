
namespace EmployeeControl.UI
{
    partial class UpdateOld
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
            this.id = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.LinkLabel();
            this.update = new System.Windows.Forms.Button();
            this.dept = new System.Windows.Forms.ComboBox();
            this.hiredate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id.Location = new System.Drawing.Point(198, 38);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(430, 25);
            this.id.TabIndex = 3;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label0.Location = new System.Drawing.Point(56, 41);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(99, 17);
            this.label0.TabIndex = 2;
            this.label0.Text = "Employee ID";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back.Location = new System.Drawing.Point(106, 705);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(78, 20);
            this.back.TabIndex = 35;
            this.back.TabStop = true;
            this.back.Text = "Go Back";
            this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_LinkClicked);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.update.Location = new System.Drawing.Point(441, 663);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(187, 72);
            this.update.TabIndex = 34;
            this.update.Text = "Update Record";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // dept
            // 
            this.dept.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dept.FormattingEnabled = true;
            this.dept.Items.AddRange(new object[] {
            "IT",
            "Sales",
            "Management",
            "Human Resources"});
            this.dept.Location = new System.Drawing.Point(198, 598);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(430, 25);
            this.dept.TabIndex = 33;
            // 
            // hiredate
            // 
            this.hiredate.CalendarFont = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hiredate.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hiredate.Location = new System.Drawing.Point(198, 458);
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(430, 25);
            this.hiredate.TabIndex = 29;
            this.hiredate.Value = new System.DateTime(2021, 2, 10, 8, 44, 26, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(63, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Department";
            // 
            // salary
            // 
            this.salary.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salary.Location = new System.Drawing.Point(198, 528);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(430, 25);
            this.salary.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(104, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(79, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Hire Date";
            // 
            // pnumber
            // 
            this.pnumber.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnumber.Location = new System.Drawing.Point(198, 388);
            this.pnumber.Name = "pnumber";
            this.pnumber.Size = new System.Drawing.Size(430, 25);
            this.pnumber.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Phonenumber";
            // 
            // state
            // 
            this.state.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.state.Location = new System.Drawing.Point(198, 318);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(430, 25);
            this.state.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(112, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "State";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(198, 248);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(430, 25);
            this.email.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(107, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email";
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lname.Location = new System.Drawing.Point(198, 178);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(430, 25);
            this.lname.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(80, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lastname";
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fname.Location = new System.Drawing.Point(198, 108);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(430, 25);
            this.fname.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Firstname";
            // 
            // UpdateOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 754);
            this.Controls.Add(this.back);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.hiredate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label0);
            this.Name = "UpdateOld";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.LinkLabel back;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ComboBox dept;
        private System.Windows.Forms.DateTimePicker hiredate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pnumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label1;
    }
}