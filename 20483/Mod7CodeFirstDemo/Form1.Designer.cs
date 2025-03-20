namespace Mod7CodeFirstDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            empGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEid = new TextBox();
            txtName = new TextBox();
            txtSalary = new TextBox();
            comboDept = new ComboBox();
            btnAdd = new Button();
            btnSubmit = new Button();
            btnSelect = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)empGrid).BeginInit();
            SuspendLayout();
            // 
            // empGrid
            // 
            empGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empGrid.Location = new Point(174, 26);
            empGrid.Name = "empGrid";
            empGrid.RowHeadersWidth = 62;
            empGrid.Size = new Size(603, 173);
            empGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 223);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 1;
            label1.Text = "Employee Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 273);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 2;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 367);
            label3.Name = "label3";
            label3.Size = new Size(190, 25);
            label3.TabIndex = 3;
            label3.Text = "Employee Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 316);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 4;
            label4.Text = "Employee Salary";
            // 
            // txtEid
            // 
            txtEid.Location = new Point(421, 217);
            txtEid.Name = "txtEid";
            txtEid.Size = new Size(150, 31);
            txtEid.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(421, 267);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 6;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(421, 310);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(150, 31);
            txtSalary.TabIndex = 7;
            // 
            // comboDept
            // 
            comboDept.FormattingEnabled = true;
            comboDept.Location = new Point(421, 364);
            comboDept.Name = "comboDept";
            comboDept.Size = new Size(182, 33);
            comboDept.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(733, 227);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(176, 34);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add Employee";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(733, 267);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(176, 34);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit Employee";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(733, 316);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(176, 34);
            btnSelect.TabIndex = 12;
            btnSelect.Text = "Select to Update";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(733, 396);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 34);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete Employee";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(733, 356);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(176, 34);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update Employee";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(733, 436);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(176, 34);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 498);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSelect);
            Controls.Add(btnSubmit);
            Controls.Add(btnAdd);
            Controls.Add(comboDept);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(txtEid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(empGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)empGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView empGrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEid;
        private TextBox txtName;
        private TextBox txtSalary;
        private ComboBox comboDept;
        private Button btnAdd;
        private Button btnSubmit;
        private Button btnSelect;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRefresh;
    }
}
