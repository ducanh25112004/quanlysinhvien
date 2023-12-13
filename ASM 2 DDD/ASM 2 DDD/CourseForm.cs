using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_2_DDD
{
    public partial class CourseForm : Form
    {
        string connectionString;
        SqlConnection conn;
        public CourseForm()
        {
            InitializeComponent();
            connectionString = "Data Source = DucAnh\\SQLEXPRESS; Initial Catalog = asm2; Integrated Security = true";
            conn = new SqlConnection(connectionString);
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            // Load courses into DataGridView
            LoadCourses();
        }
        private void LoadCourses()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Courses";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridViewCourses.DataSource = dataTable;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Điều hướng về trang chủ
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.Show();
            // Đóng form hiện tại
            this.Close();
        }
    }
}
