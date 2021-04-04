using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Attendance_db
{
    public partial class mainForm : Form
    {

       static string connectoionSQL = "server=localhost;database=attendance_db;uid=root;password=;";
        MySqlConnection conn = new MySqlConnection(connectoionSQL);

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.getTeachers();
            this.getLabs();
            this.getCourses();
            this.getAttendances();

        }


        private void addLabBtn_Click(object sender, EventArgs e)
        {
            Form labForm = new Lab(this);
            labForm.Show(this);
        }

        public void getLabs()
        {
   
            try
            {
                conn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("select id,name from attendance_db.lab", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "lab");
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = ds.Tables["lab"];

                conn.Close();

            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Can't connect to database\n" + ex.ToString());
            }

        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            Form courseForm = new Course(this);
            courseForm.Show(this);

        }

        public void getCourses()
        {
     
            try
            {
                conn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("select id,name from attendance_db.courses", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "courses");
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "id";
                comboBox2.DataSource = ds.Tables["courses"];

                conn.Close();

            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Can't connect to database\n" + ex.ToString());
            }

        }

        private void addTeacherBtn_Click(object sender, EventArgs e)
        {
            Form teacherForm = new Teacher(this);
            teacherForm.Show(this);
        }

        public void getTeachers()
        {

            try
            {
                conn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("select id,name from attendance_db.teachers", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "teachers");
                comboBox3.DisplayMember = "name";
                comboBox3.ValueMember = "id";
                comboBox3.DataSource = ds.Tables["teachers"];
                conn.Close();

            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Can't connect to database\n" + ex.ToString());
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
         
            try
            {
                String sql = "INSERT INTO attendances (date,start_time,end_time,lab_id,course_id,teacher_id) VALUES (@date,@startTime,@endTime,@labId,@courseId,@teacherId)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("@date", MySqlDbType.Date).Value = date.Value;
                cmd.Parameters.Add("@startTime", MySqlDbType.Datetime).Value = startTime.Value;
                cmd.Parameters.Add("@endTime", MySqlDbType.Datetime).Value = endTime.Value;
                cmd.Parameters.Add("@labId", MySqlDbType.Int24).Value = comboBox1.SelectedValue;
                cmd.Parameters.Add("@courseId", MySqlDbType.Int24).Value = comboBox2.SelectedValue;
                cmd.Parameters.Add("@teacherId", MySqlDbType.Int24).Value = comboBox3.SelectedValue;



                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Can't connect to database\n" + ex.ToString());
            }

            this.getAttendances();
        }

        private void getAttendances()
        {
            dataGridView1.DataSource = null;
            MySqlDataAdapter da = new MySqlDataAdapter("select attendances.date,attendances.start_time,attendances.end_time,lab.name as 'lab_name',courses.name as 'course_name',teachers.name as 'teacher_name' from attendance_db.attendances ,attendance_db.courses, attendance_db.lab , attendance_db.teachers where attendance_db.attendances.lab_id= attendance_db.lab.id and attendance_db.attendances.course_id= attendance_db.courses.id and  attendance_db.attendances.teacher_id= attendance_db.teachers.id", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "attendances");
            dataGridView1.DataSource = ds.Tables["attendances"];
        }

    }
}
