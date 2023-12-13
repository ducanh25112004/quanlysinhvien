namespace ASM_2_DDD
{
    partial class AdminForm
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
            Button btnDelete;
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtClassID = new TextBox();
            cmbGender = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            label5 = new Label();
            button1 = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(597, 352);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 46);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(439, 207);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 84);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 152);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Student Name";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(199, 81);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(147, 23);
            txtStudentID.TabIndex = 3;
            txtStudentID.TextChanged += textBox1_TextChanged;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(199, 144);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(147, 23);
            txtStudentName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 84);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(467, 152);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 6;
            label4.Text = "Class ID";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(530, 144);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(121, 23);
            txtClassID.TabIndex = 8;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(530, 81);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(597, 226);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 46);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Insert";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(597, 289);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 46);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(306, 24);
            label5.Name = "label5";
            label5.Size = new Size(206, 25);
            label5.TabIndex = 13;
            label5.Text = "Student Management";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(48, 23);
            button1.TabIndex = 14;
            button1.Text = "<-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(cmbGender);
            Controls.Add(txtClassID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "AdminForm";
            Text = "admin";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private Label label3;
        private Label label4;
        private TextBox txtClassID;
        private ComboBox cmbGender;
        private Button btnAdd;
        private Button btnEdit;
        private Label label5;
        private Button button1;
    }
}