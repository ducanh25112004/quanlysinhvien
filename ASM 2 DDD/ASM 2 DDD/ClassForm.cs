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
    public partial class ClassForm : Form
    {
        string connectionString;
        SqlConnection conn;
        public ClassForm()
        {
            InitializeComponent();
            connectionString = "Data Source = DucAnh\\SQLEXPRESS; Initial Catalog = asm2; Integrated Security = true";
            conn = new SqlConnection(connectionString);
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            // Load classes into DataGridView
            LoadClasses();
        }
        private void LoadClasses()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM Classes";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridViewClasses.DataSource = dataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text;
            string room = txtRoom.Text;

            if (!string.IsNullOrEmpty(className) && !string.IsNullOrEmpty(room))
            {
                // Insert the class into the database
                InsertClassIntoDatabase(className, room);

                MessageBox.Show("Class added successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView after adding the class
                LoadClasses();
            }
            else
            {
                MessageBox.Show("Please enter both class name and room.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void InsertClassIntoDatabase(string className, string room)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlInsert = $"INSERT INTO Classes (ClassName, Room) VALUES ('{className}', '{room}')";

                using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewClasses.SelectedRows.Count > 0)
            {
                // Get the selected class's ID
                int classID = Convert.ToInt32(dataGridViewClasses.SelectedRows[0].Cells["ClassID"].Value);

                // Delete the class from the database
                DeleteClassFromDatabase(classID);

                MessageBox.Show("Class deleted successfully.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView after deleting the class
                LoadClasses();
            }
            else
            {
                MessageBox.Show("Please select a class to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DeleteClassFromDatabase(int classID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlDelete = $"DELETE FROM Classes WHERE ClassID = {classID}";

                using (SqlCommand command = new SqlCommand(sqlDelete, connection))
                {
                    command.ExecuteNonQuery();
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
