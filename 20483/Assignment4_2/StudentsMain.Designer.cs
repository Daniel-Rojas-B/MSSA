namespace Assignment4_2
{
    partial class StudentsMain
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
            StudentsGrid = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).BeginInit();
            SuspendLayout();
            // 
            // StudentsGrid
            // 
            StudentsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsGrid.Location = new Point(83, 108);
            StudentsGrid.Name = "StudentsGrid";
            StudentsGrid.RowHeadersWidth = 62;
            StudentsGrid.Size = new Size(627, 225);
            StudentsGrid.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(207, 369);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(334, 369);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(464, 369);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StudentsMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(StudentsGrid);
            Name = "StudentsMain";
            Text = "StudentsMain";
            Load += StudentsMain_Load;
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView StudentsGrid;
        private Button btnAdd;
        private Button btnDelete;
        private Button button1;
    }
}