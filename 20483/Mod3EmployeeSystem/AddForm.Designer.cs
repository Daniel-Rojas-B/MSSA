namespace Mod3EmployeeSystem
{
    partial class AddForm
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
            grpEmployee = new GroupBox();
            comboDept = new ComboBox();
            txtSalary = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            txtEid = new TextBox();
            lblDepartment = new Label();
            lblSalary = new Label();
            lblAddress = new Label();
            lblName = new Label();
            lblEmpid = new Label();
            btnSubmit = new Button();
            grpEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // grpEmployee
            // 
            grpEmployee.Controls.Add(comboDept);
            grpEmployee.Controls.Add(txtSalary);
            grpEmployee.Controls.Add(txtAddress);
            grpEmployee.Controls.Add(txtName);
            grpEmployee.Controls.Add(txtEid);
            grpEmployee.Controls.Add(lblDepartment);
            grpEmployee.Controls.Add(lblSalary);
            grpEmployee.Controls.Add(lblAddress);
            grpEmployee.Controls.Add(lblName);
            grpEmployee.Controls.Add(lblEmpid);
            grpEmployee.Font = new Font("Microsoft JhengHei", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpEmployee.Location = new Point(115, 44);
            grpEmployee.Name = "grpEmployee";
            grpEmployee.Size = new Size(537, 321);
            grpEmployee.TabIndex = 0;
            grpEmployee.TabStop = false;
            grpEmployee.Text = "Employee Record";
            // 
            // comboDept
            // 
            comboDept.FormattingEnabled = true;
            comboDept.Location = new Point(260, 269);
            comboDept.Name = "comboDept";
            comboDept.Size = new Size(182, 33);
            comboDept.TabIndex = 9;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(253, 201);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(207, 34);
            txtSalary.TabIndex = 8;
            txtSalary.Validating += txtSalary_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(253, 148);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(207, 34);
            txtAddress.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(253, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(207, 34);
            txtName.TabIndex = 6;
            // 
            // txtEid
            // 
            txtEid.Location = new Point(253, 51);
            txtEid.Name = "txtEid";
            txtEid.Size = new Size(207, 34);
            txtEid.TabIndex = 5;
            txtEid.Validating += txtEid_Validating;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(53, 273);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(125, 25);
            lblDepartment.TabIndex = 4;
            lblDepartment.Text = "Department";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(51, 201);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(67, 25);
            lblSalary.TabIndex = 3;
            lblSalary.Text = "Salary";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(53, 148);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(88, 25);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(70, 102);
            lblName.Name = "lblName";
            lblName.Size = new Size(69, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblEmpid
            // 
            lblEmpid.AutoSize = true;
            lblEmpid.Location = new Point(49, 51);
            lblEmpid.Name = "lblEmpid";
            lblEmpid.Size = new Size(129, 25);
            lblEmpid.TabIndex = 0;
            lblEmpid.Text = "Employee Id";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(351, 385);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(grpEmployee);
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            grpEmployee.ResumeLayout(false);
            grpEmployee.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEmployee;
        private TextBox txtSalary;
        private TextBox txtAddress;
        private TextBox txtName;
        private TextBox txtEid;
        private Label lblDepartment;
        private Label lblSalary;
        private Label lblAddress;
        private Label lblName;
        private Label lblEmpid;
        private ComboBox comboDept;
        private Button btnSubmit;
    }
}