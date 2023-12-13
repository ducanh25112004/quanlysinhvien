namespace ASM_2_DDD
{
    partial class CourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewCourses = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            txtCourseName = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Location = new Point(103, 90);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.RowTemplate.Height = 25;
            dataGridViewCourses.Size = new Size(299, 192);
            dataGridViewCourses.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(103, 326);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(327, 326);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(567, 104);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(100, 23);
            txtCourseName.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(567, 163);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(479, 112);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 5;
            label1.Text = "Course Name ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 171);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 6;
            label2.Text = "Description ";
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(48, 23);
            button3.TabIndex = 15;
            button3.Text = "<-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtCourseName);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewCourses);
            Name = "CourseForm";
            Text = "Course";
            Load += CourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCourses;
        private Button button1;
        private Button button2;
        private TextBox txtCourseName;
        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private Button button3;
    }
}