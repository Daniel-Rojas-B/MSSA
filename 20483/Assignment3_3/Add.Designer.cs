namespace Assignment3_3
{
    partial class Add
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
            lblTitle = new Label();
            lblSid = new Label();
            lblFirstname = new Label();
            lblLastname = new Label();
            lblAddress = new Label();
            lblMonthadm = new Label();
            lblGrade = new Label();
            btnSubmit = new Button();
            txtSid = new TextBox();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtAddress = new TextBox();
            txtGrade = new TextBox();
            comboMonth = new ComboBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(285, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(159, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Student Form";
            // 
            // lblSid
            // 
            lblSid.AutoSize = true;
            lblSid.Location = new Point(72, 77);
            lblSid.Name = "lblSid";
            lblSid.Size = new Size(94, 25);
            lblSid.TabIndex = 1;
            lblSid.Text = "Student Id";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(71, 114);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(97, 25);
            lblFirstname.TabIndex = 2;
            lblFirstname.Text = "First Name";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(73, 151);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(95, 25);
            lblLastname.TabIndex = 3;
            lblLastname.Text = "Last Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(72, 188);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 25);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblMonthadm
            // 
            lblMonthadm.AutoSize = true;
            lblMonthadm.Location = new Point(71, 225);
            lblMonthadm.Name = "lblMonthadm";
            lblMonthadm.Size = new Size(176, 25);
            lblMonthadm.TabIndex = 5;
            lblMonthadm.Text = "Month of Admission";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(73, 262);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(59, 25);
            lblGrade.TabIndex = 6;
            lblGrade.Text = "Grade";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(304, 342);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtSid
            // 
            txtSid.Location = new Point(318, 71);
            txtSid.Name = "txtSid";
            txtSid.Size = new Size(265, 31);
            txtSid.TabIndex = 8;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(318, 108);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(265, 31);
            txtFirstname.TabIndex = 9;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(318, 145);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(265, 31);
            txtLastname.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(318, 182);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(265, 31);
            txtAddress.TabIndex = 11;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(318, 256);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(265, 31);
            txtGrade.TabIndex = 13;
            // 
            // comboMonth
            // 
            comboMonth.FormattingEnabled = true;
            comboMonth.Location = new Point(318, 217);
            comboMonth.Name = "comboMonth";
            comboMonth.Size = new Size(265, 33);
            comboMonth.TabIndex = 14;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboMonth);
            Controls.Add(txtGrade);
            Controls.Add(txtAddress);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(txtSid);
            Controls.Add(btnSubmit);
            Controls.Add(lblGrade);
            Controls.Add(lblMonthadm);
            Controls.Add(lblAddress);
            Controls.Add(lblLastname);
            Controls.Add(lblFirstname);
            Controls.Add(lblSid);
            Controls.Add(lblTitle);
            Name = "Add";
            Text = "Add";
            Load += Add_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSid;
        private Label lblFirstname;
        private Label lblLastname;
        private Label lblAddress;
        private Label lblMonthadm;
        private Label lblGrade;
        private Button btnSubmit;
        private TextBox txtSid;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtAddress;
        private TextBox txtGrade;
        private ComboBox comboMonth;
    }
}