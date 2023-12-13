namespace ASM_2_DDD
{
    partial class ClassForm
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
            dataGridViewClasses = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            txtClassName = new TextBox();
            txtRoom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClasses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClasses
            // 
            dataGridViewClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClasses.Location = new Point(78, 77);
            dataGridViewClasses.Name = "dataGridViewClasses";
            dataGridViewClasses.RowTemplate.Height = 25;
            dataGridViewClasses.Size = new Size(315, 195);
            dataGridViewClasses.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(137, 320);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(258, 320);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(584, 105);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(100, 23);
            txtClassName.TabIndex = 3;
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(584, 152);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(100, 23);
            txtRoom.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 113);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 5;
            label1.Text = "Class Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(539, 160);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Room";
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
            // ClassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRoom);
            Controls.Add(txtClassName);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewClasses);
            Name = "ClassForm";
            Text = "Class";
            Load += ClassForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClasses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClasses;
        private Button button1;
        private Button button2;
        private TextBox txtClassName;
        private TextBox txtRoom;
        private Label label1;
        private Label label2;
        private Button button3;
    }
}