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
    public partial class UserForm : Form
    {
        string connectionString;
        SqlConnection conn;
        public UserForm()
        {
            InitializeComponent();
            connectionString = "Data Source = DucAnh\\SQLEXPRESS; Initial Catalog = asm2; Integrated Security = true";
            conn = new SqlConnection(connectionString);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo câu lệnh SQL để lấy dữ liệu từ bảng Students
                string sqlQuery = "SELECT * FROM Students";

                // Tạo SqlDataAdapter để lấy dữ liệu và DataTable để lưu trữ nó
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection);
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                dataAdapter.Fill(dataTable);

                // Hiển thị dữ liệu từ DataTable lên DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells["StudentID"].Value.ToString();
                txtStudentName.Text = row.Cells["StudentName"].Value.ToString();
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                txtClassID.Text = row.Cells["ClassID"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                SearchStudents(keyword);
            }
            else
            {
                // If the search keyword is empty, load all students
                LoadStudents();
            }
        }
        private void LoadStudents()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Students";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        private void SearchStudents(string keyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Students WHERE StudentName LIKE @Keyword OR Gender LIKE @Keyword OR StudentID LIKE @Keyword";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Keyword", $"%{keyword}%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
    }
}
