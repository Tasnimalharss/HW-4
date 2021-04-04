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
    public partial class Teacher : Form
    {
        mainForm f;
        public Teacher(mainForm parent)
        {
            InitializeComponent();
            f = parent;

        }

        private void teacherFrmBtn_Click(object sender, EventArgs e)
        {
            string connectoionSQL = "server=localhost;database=attendance_db;uid=root;password=;";
            MySqlConnection conn = new MySqlConnection(connectoionSQL);
            try
            {
                String sql = "INSERT INTO teachers (name) VALUES (@name)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }

            catch (MySqlException ex)
            {

                MessageBox.Show("Can't connect to database\n" + ex.ToString());
            }

            this.Hide();
            f.comboBox3.Items.Add(textBox1.Text);

        }
    }
}
