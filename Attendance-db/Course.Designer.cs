namespace Attendance_db
{
    partial class Course
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.courseFrmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 1;
            // 
            // courseFrmBtn
            // 
            this.courseFrmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseFrmBtn.Location = new System.Drawing.Point(299, 98);
            this.courseFrmBtn.Name = "courseFrmBtn";
            this.courseFrmBtn.Size = new System.Drawing.Size(75, 23);
            this.courseFrmBtn.TabIndex = 2;
            this.courseFrmBtn.Text = "Add";
            this.courseFrmBtn.UseVisualStyleBackColor = true;
            this.courseFrmBtn.Click += new System.EventHandler(this.courseFrmBtn_Click);
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 279);
            this.Controls.Add(this.courseFrmBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Course";
            this.Text = "Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button courseFrmBtn;
    }
}