namespace Assignment4_2
{
    partial class AddStudent
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
            btnAddStudent = new Button();
            lblId = new Label();
            lblName = new Label();
            lblGPA = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(335, 334);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(128, 34);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(233, 126);
            lblId.Name = "lblId";
            lblId.Size = new Size(94, 25);
            lblId.TabIndex = 1;
            lblId.Text = "Student Id";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(233, 189);
            lblName.Name = "lblName";
            lblName.Size = new Size(125, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Student Name";
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Location = new Point(233, 257);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(45, 25);
            lblGPA.TabIndex = 3;
            lblGPA.Text = "GPA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(424, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(424, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(424, 251);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 31);
            textBox3.TabIndex = 6;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblGPA);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(btnAddStudent);
            Name = "AddStudent";
            Text = "AddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddStudent;
        private Label lblId;
        private Label lblName;
        private Label lblGPA;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}