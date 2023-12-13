namespace ASM_2_DDD
{
    partial class AdminAttend
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
            dataGridViewStudents = new DataGridView();
            button2 = new Button();
            dateTimePickerAttendanceDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(173, 116);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowTemplate.Height = 25;
            dataGridViewStudents.Size = new Size(444, 201);
            dataGridViewStudents.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(48, 23);
            button2.TabIndex = 15;
            button2.Text = "<-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePickerAttendanceDate
            // 
            dateTimePickerAttendanceDate.Location = new Point(286, 359);
            dateTimePickerAttendanceDate.Name = "dateTimePickerAttendanceDate";
            dateTimePickerAttendanceDate.Size = new Size(212, 23);
            dateTimePickerAttendanceDate.TabIndex = 16;
            // 
            // AdminAttend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePickerAttendanceDate);
            Controls.Add(button2);
            Controls.Add(dataGridViewStudents);
            Name = "AdminAttend";
            Text = "AdminAttend";
            Load += AdminAttend_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewStudents;
        private Button button2;
        private DateTimePicker dateTimePickerAttendanceDate;
    }
}