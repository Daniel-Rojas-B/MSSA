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
            txtId = new TextBox();
            txtName = new TextBox();
            txtGPA = new TextBox();
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
            btnAddStudent.Click += btnAddStudent_Click;
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
            // txtId
            // 
            txtId.Location = new Point(424, 125);
            txtId.Name = "txtId";
            txtId.Size = new Size(163, 31);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(424, 189);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 31);
            txtName.TabIndex = 5;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(424, 251);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(163, 31);
            txtGPA.TabIndex = 6;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtGPA);
            Controls.Add(txtName);
            Controls.Add(txtId);
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
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtGPA;
    }
}