using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ASM_2_DDD
{
    public partial class Login : Form
    {
        string connectionString;
        SqlConnection conn;
        public Login()
        {
            InitializeComponent();
            connectionString = "Data Source = DucAnh\\SQLEXPRESS; Initial Catalog = asm2; Integrated Security = true";
            conn = new SqlConnection(connectionString);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string role = result.ToString();
                        MessageBox.Show($"Logged in successfully! Role: {role}");

                        OpenRoleFormAndHide(role);
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Please check your username and password again.");
                    }
                }
            }
        }
        private void OpenRoleFormAndHide(string role)
        {
            switch (role)
            {
                case "admin":
                    HomeAdmin homeAdmin = new HomeAdmin();
                    homeAdmin.Show();
                    this.Hide(); // Ẩn giao diện đăng nhập
                    break;
                case "user":
                    UserForm userForm = new UserForm();
                    userForm.Show();
                    this.Hide(); // Ẩn giao diện đăng nhập
                    break;
                default:
                    MessageBox.Show("Invalid role.");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}