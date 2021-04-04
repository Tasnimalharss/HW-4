namespace Attendance_db
{
    partial class mainForm
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.end_time = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.addLabBtn = new System.Windows.Forms.Button();
            this.addTeacherBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(71, 44);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(141, 26);
            this.date.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(13, 47);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 20);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(263, 48);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(78, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Start time";
            // 
            // startTime
            // 
            this.startTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(351, 46);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(180, 26);
            this.startTime.TabIndex = 3;
            // 
            // end_time
            // 
            this.end_time.AutoSize = true;
            this.end_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_time.Location = new System.Drawing.Point(591, 49);
            this.end_time.Name = "end_time";
            this.end_time.Size = new System.Drawing.Size(72, 20);
            this.end_time.TabIndex = 4;
            this.end_time.Text = "End time";
            // 
            // endTime
            // 
            this.endTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTime.Location = new System.Drawing.Point(682, 47);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(145, 26);
            this.endTime.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(350, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(682, 109);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(143, 24);
            this.comboBox3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lab";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Teacher";
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.Location = new System.Drawing.Point(536, 106);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(45, 23);
            this.addCourseBtn.TabIndex = 13;
            this.addCourseBtn.Text = "Add";
            this.addCourseBtn.UseVisualStyleBackColor = true;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // addLabBtn
            // 
            this.addLabBtn.Location = new System.Drawing.Point(217, 101);
            this.addLabBtn.Name = "addLabBtn";
            this.addLabBtn.Size = new System.Drawing.Size(45, 23);
            this.addLabBtn.TabIndex = 14;
            this.addLabBtn.Text = "Add";
            this.addLabBtn.UseVisualStyleBackColor = true;
            this.addLabBtn.Click += new System.EventHandler(this.addLabBtn_Click);
            // 
            // addTeacherBtn
            // 
            this.addTeacherBtn.Location = new System.Drawing.Point(831, 109);
            this.addTeacherBtn.Name = "addTeacherBtn";
            this.addTeacherBtn.Size = new System.Drawing.Size(45, 23);
            this.addTeacherBtn.TabIndex = 15;
            this.addTeacherBtn.Text = "Add";
            this.addTeacherBtn.UseVisualStyleBackColor = true;
            this.addTeacherBtn.Click += new System.EventHandler(this.addTeacherBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 237);
            this.dataGridView1.TabIndex = 16;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.LightCoral;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(384, 160);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 28);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addTeacherBtn);
            this.Controls.Add(this.addLabBtn);
            this.Controls.Add(this.addCourseBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.end_time);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.date);
            this.Name = "mainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Label end_time;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.Button addLabBtn;
        private System.Windows.Forms.Button addTeacherBtn;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button saveBtn;
    }
}

