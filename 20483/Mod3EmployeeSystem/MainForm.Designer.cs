namespace Mod3EmployeeSystem
{
    partial class MainForm
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
            lblHeading = new Label();
            empGrid = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            button1 = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)empGrid).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Location = new Point(388, 27);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(140, 25);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Employee Portal";
            // 
            // empGrid
            // 
            empGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empGrid.Location = new Point(62, 79);
            empGrid.Name = "empGrid";
            empGrid.RowHeadersWidth = 62;
            empGrid.Size = new Size(782, 225);
            empGrid.TabIndex = 1;
            empGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(62, 347);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(223, 62);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Employee";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(590, 347);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(254, 62);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Employee";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(448, 374);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(365, 334);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 88);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 447);
            Controls.Add(btnRefresh);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(empGrid);
            Controls.Add(lblHeading);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)empGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private DataGridView empGrid;
        private Button btnAdd;
        private Button btnDelete;
        private Button button1;
        private Button btnRefresh;
    }
}