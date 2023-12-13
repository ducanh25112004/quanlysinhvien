using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_2_DDD
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminAttend adminAttend = new AdminAttend();
            adminAttend.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Show();
            this.Hide();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClassForm classForm = new ClassForm();
            classForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
            this.Hide();
        }
    }
}
