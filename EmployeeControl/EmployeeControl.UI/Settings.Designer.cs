
namespace EmployeeControl.UI
{
    partial class Settings
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
            this.dept = new System.Windows.Forms.TextBox();
            this.add_new = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // dept
            // 
            this.dept.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dept.Location = new System.Drawing.Point(179, 49);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(430, 25);
            this.dept.TabIndex = 2;
            // 
            // add_new
            // 
            this.add_new.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_new.Location = new System.Drawing.Point(422, 108);
            this.add_new.Name = "add_new";
            this.add_new.Size = new System.Drawing.Size(187, 72);
            this.add_new.TabIndex = 18;
            this.add_new.Text = "Add New";
            this.add_new.UseVisualStyleBackColor = true;
            this.add_new.Click += new System.EventHandler(this.add_new_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(71, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Department";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back.Location = new System.Drawing.Point(71, 160);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(78, 20);
            this.back.TabIndex = 19;
            this.back.TabStop = true;
            this.back.Text = "Go Back";
            this.back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_LinkClicked);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 236);
            this.Controls.Add(this.back);
            this.Controls.Add(this.add_new);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dept);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dept;
        private System.Windows.Forms.Button add_new;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel back;
    }
}