namespace Assignment4_1
{
    partial class UsersGrid
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
            peopleGrid = new DataGridView();
            btnAddUser = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)peopleGrid).BeginInit();
            SuspendLayout();
            // 
            // peopleGrid
            // 
            peopleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            peopleGrid.Location = new Point(37, 108);
            peopleGrid.Name = "peopleGrid";
            peopleGrid.RowHeadersWidth = 62;
            peopleGrid.Size = new Size(713, 225);
            peopleGrid.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(68, 358);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(112, 34);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(235, 358);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(407, 358);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(586, 358);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 46);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 5;
            label1.Text = "Phone / Address Book";
            // 
            // UsersGrid
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddUser);
            Controls.Add(peopleGrid);
            Name = "UsersGrid";
            Text = "UsersGrid";
            Load += UsersGrid_Load;
            ((System.ComponentModel.ISupportInitialize)peopleGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView peopleGrid;
        private Button btnAddUser;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnSearch;
        private Label label1;
    }
}