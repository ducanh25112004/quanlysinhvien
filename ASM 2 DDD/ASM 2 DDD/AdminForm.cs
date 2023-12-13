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
    public partial class AdminForm : Form
    {
        string connectionString;
        SqlConnection conn;
        public AdminForm()
        {
            InitializeComponent();
            connectionString = "Data Source = DucAnh\\SQLEXPRESS; Initial Catalog = asm2; Integrated Security = true";
            conn = new SqlConnection(connectionString);

        }

        private void AdminForm_Load(object sender, EventArgs e)
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
                // Gán sự kiện CellClick cho DataGridView
                dataGridView1.CellClick += dataGridView1_CellContentClick;
            }
        }
        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Students";
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if all required fields are provided
            if (string.IsNullOrEmpty(txtStudentID.Text) || string.IsNullOrEmpty(txtStudentName.Text) || string.IsNullOrEmpty(cmbGender.Text) || string.IsNullOrEmpty(txtClassID.Text))
            {
                MessageBox.Show("Please enter all required information before adding a new student.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Continue with adding the new student
            int studentID = Convert.ToInt32(txtStudentID.Text);
            string studentName = txtStudentName.Text;
            string gender = cmbGender.Text;
            int classID = Convert.ToInt32(txtClassID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create SQL command to insert data into the Students table
                string sqlInsert = $"INSERT INTO Students (StudentID, StudentName, Gender, ClassID) VALUES ({studentID}, '{studentName}', '{gender}', {classID})";

                // Execute the SQL command
                using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student has been added successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No student has been added.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            // After adding data, refresh the DataGridView
            LoadDataIntoDataGridView();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Students SET StudentName = @StudentName, Gender = @Gender, ClassID = @ClassID WHERE StudentID = @StudentID";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                    updateCommand.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
                    updateCommand.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    updateCommand.Parameters.AddWithValue("@ClassID", txtClassID.Text);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student data has been updated successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No student data has been updated.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Refresh DataGridView to display the new data
                LoadDataIntoDataGridView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if the StudentID is provided
            if (string.IsNullOrEmpty(txtStudentID.Text))
            {
                MessageBox.Show("Please enter a StudentID before deleting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Students WHERE StudentID = @StudentID";

                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@StudentID", txtStudentID.Text);

                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student has been deleted successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No student has been deleted. Please check if the StudentID is correct.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Refresh DataGridView to display the new data
                LoadDataIntoDataGridView();
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
            // Điều hướng về trang chủ
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.Show();
            // Đóng form hiện tại
            this.Close();
        }
    }
}
