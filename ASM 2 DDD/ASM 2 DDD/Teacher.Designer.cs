namespace ASM_2_DDD
{
    partial class Teacher
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
            dataGridViewLecturers = new DataGridView();
            btnAddLecturer = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtLecturerName = new TextBox();
            txtDepartment = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLecturers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLecturers
            // 
            dataGridViewLecturers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLecturers.Location = new Point(34, 58);
            dataGridViewLecturers.Name = "dataGridViewLecturers";
            dataGridViewLecturers.RowTemplate.Height = 25;
            dataGridViewLecturers.Size = new Size(312, 237);
            dataGridViewLecturers.TabIndex = 0;
            // 
            // btnAddLecturer
            // 
            btnAddLecturer.Location = new Point(34, 334);
            btnAddLecturer.Name = "btnAddLecturer";
            btnAddLecturer.Size = new Size(75, 23);
            btnAddLecturer.TabIndex = 1;
            btnAddLecturer.Text = "Add Lecturer";
            btnAddLecturer.UseVisualStyleBackColor = true;
            btnAddLecturer.Click += btnAddLecturer_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(146, 334);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(271, 334);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtLecturerName
            // 
            txtLecturerName.Location = new Point(551, 88);
            txtLecturerName.Name = "txtLecturerName";
            txtLecturerName.Size = new Size(160, 23);
            txtLecturerName.TabIndex = 4;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(551, 143);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(160, 23);
            txtDepartment.TabIndex = 5;
            txtDepartment.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 91);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 6;
            label1.Text = "Lecture Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 146);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 146);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "Department";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(48, 23);
            button1.TabIndex = 15;
            button1.Text = "<-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDepartment);
            Controls.Add(txtLecturerName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddLecturer);
            Controls.Add(dataGridViewLecturers);
            Name = "Teacher";
            Text = "Teacher";
            Load += Teacher_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLecturers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewLecturers;
        private Button btnAddLecturer;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtLecturerName;
        private TextBox txtDepartment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}