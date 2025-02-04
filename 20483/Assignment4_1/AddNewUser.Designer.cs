namespace Assignment4_1
{
    partial class AddNewUser
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhoneNumber = new Label();
            lblWorkNumber = new Label();
            lblAddress = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtWorkNumber = new TextBox();
            txtAddress = new TextBox();
            btnAddUser = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(228, 128);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(228, 165);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(228, 202);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(132, 25);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblWorkNumber
            // 
            lblWorkNumber.AutoSize = true;
            lblWorkNumber.Location = new Point(228, 239);
            lblWorkNumber.Name = "lblWorkNumber";
            lblWorkNumber.Size = new Size(124, 25);
            lblWorkNumber.TabIndex = 3;
            lblWorkNumber.Text = "Work Number";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(228, 276);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 25);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(402, 125);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(402, 162);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(402, 199);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(150, 31);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtWorkNumber
            // 
            txtWorkNumber.Location = new Point(402, 236);
            txtWorkNumber.Name = "txtWorkNumber";
            txtWorkNumber.Size = new Size(150, 31);
            txtWorkNumber.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(402, 276);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 9;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(373, 350);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(112, 34);
            btnAddUser.TabIndex = 10;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 56);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 11;
            label1.Text = "Person Information";
            // 
            // AddNewUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnAddUser);
            Controls.Add(txtAddress);
            Controls.Add(txtWorkNumber);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblAddress);
            Controls.Add(lblWorkNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "AddNewUser";
            Text = "AddNewUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhoneNumber;
        private Label lblWorkNumber;
        private Label lblAddress;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhoneNumber;
        private TextBox txtWorkNumber;
        private TextBox txtAddress;
        private Button btnAddUser;
        private Label label1;
    }
}