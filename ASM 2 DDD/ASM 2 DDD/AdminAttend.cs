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
    public partial class AdminAttend : Form
    {
        string connectionString;
        SqlConnection conn;
        public AdminAttend()
        {
            InitializeComponent();
            connectionString = "Data Source = DucAnh\\SQLEXPRESS; Initial Catalog = asm2; Integrated Security = true";
            conn = new SqlConnection(connectionString);
        }

        private void AdminAttend_Load(object sender, EventArgs e)
        {
            // Load attendance records into DataGridView
            LoadAttendance();
        }
        private void LoadAttendance()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT StudentID, StudentName FROM Students";
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Thêm cột checkbox
                    DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                    checkboxColumn.HeaderText = "Is Present";
                    checkboxColumn.Name = "IsPresent";
                    dataGridViewStudents.Columns.Add(checkboxColumn);

                    // Gán dữ liệu vào DataGridView
                    dataGridViewStudents.DataSource = dataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewStudents.Rows)
            {
                if (row.Cells["IsPresent"].Value != null && (bool)row.Cells["IsPresent"].Value)
                {
                    int studentID = Convert.ToInt32(row.Cells["StudentID"].Value);
                    DateTime currentDate = DateTime.Now.Date;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Kiểm tra xem sinh viên đã được điểm danh chưa
                        string checkAttendanceQuery = "SELECT * FROM Attendance WHERE StudentID = @StudentID AND AttendanceDate = @AttendanceDate";
                        using (SqlCommand checkCommand = new SqlCommand(checkAttendanceQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@StudentID", studentID);
                            checkCommand.Parameters.AddWithValue("@AttendanceDate", currentDate);

                            using (SqlDataReader reader = checkCommand.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    MessageBox.Show("Sinh viên đã được điểm danh hôm nay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                        }

                        // Thêm bản ghi điểm danh mới
                        string markAttendanceQuery = "INSERT INTO Attendance (StudentID, AttendanceDate, IsPresent) VALUES (@StudentID, @AttendanceDate, @IsPresent)";
                        using (SqlCommand markCommand = new SqlCommand(markAttendanceQuery, connection))
                        {
                            markCommand.Parameters.AddWithValue("@StudentID", studentID);
                            markCommand.Parameters.AddWithValue("@AttendanceDate", currentDate);
                            markCommand.Parameters.AddWithValue("@IsPresent", true); // Điều này có thể được điều chỉnh tùy thuộc vào yêu cầu thực tế

                            markCommand.ExecuteNonQuery();

                            MessageBox.Show("Điểm danh thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }


        private void MarkAttendance(int studentID, int courseID, DateTime attendanceDate, bool isPresent)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Điều hướng về trang chủ
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.Show();
            // Đóng form hiện tại
            this.Close();
        }
    }
}
