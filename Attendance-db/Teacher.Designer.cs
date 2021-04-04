namespace Attendance_db
{
    partial class Teacher
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
            this.teacherFrmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 1;
            // 
            // teacherFrmBtn
            // 
            this.teacherFrmBtn.Location = new System.Drawing.Point(326, 101);
            this.teacherFrmBtn.Name = "teacherFrmBtn";
            this.teacherFrmBtn.Size = new System.Drawing.Size(53, 23);
            this.teacherFrmBtn.TabIndex = 2;
            this.teacherFrmBtn.Text = "Add";
            this.teacherFrmBtn.UseVisualStyleBackColor = true;
            this.teacherFrmBtn.Click += new System.EventHandler(this.teacherFrmBtn_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 283);
            this.Controls.Add(this.teacherFrmBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button teacherFrmBtn;
    }
}