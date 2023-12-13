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
    public partial class Teacher : Form
    {
        string connectionString;
        SqlConnection conn;
        public Teacher()
        {
            InitializeComponent();
            connectionString = "Data Source = DucAnh\\SQLEXPRESS; Initial Catalog = asm2; Integrated Security = true";
            conn = new SqlConnection(connectionString);
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            // Load lecturers into DataGridView
            LoadLecturers();
        }
        private void LoadLecturers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Lecturers";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridViewLecturers.DataSource = dataTable;
                }
            }
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            string lecturerName = txtLecturerName.Text;
            string department = txtDepartment.Text;

            if (!string.IsNullOrEmpty(lecturerName) && !string.IsNullOrEmpty(department))
            {
                // Insert the lecturer into the database
                InsertLecturerIntoDatabase(lecturerName, department);

                MessageBox.Show("Lecturer added successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView after adding the lecturer
                LoadLecturers();
            }
            else
            {
                MessageBox.Show("Please enter both lecturer name and department.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void InsertLecturerIntoDatabase(string lecturerName, string department)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlInsert = $"INSERT INTO Lecturers (LecturerName, Department) VALUES ('{lecturerName}', '{department}')";

                using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewLecturers.SelectedRows.Count > 0)
            {
                // Get the selected lecturer's ID
                int lecturerID = Convert.ToInt32(dataGridViewLecturers.SelectedRows[0].Cells["LecturerID"].Value);

                // Delete the lecturer from the database
                DeleteLecturerFromDatabase(lecturerID);

                MessageBox.Show("Lecturer deleted successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView after deleting the lecturer
                LoadLecturers();
            }
            else
            {
                MessageBox.Show("Please select a lecturer to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DeleteLecturerFromDatabase(int lecturerID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlDelete = $"DELETE FROM Lecturers WHERE LecturerID = {lecturerID}";

                using (SqlCommand command = new SqlCommand(sqlDelete, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

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
