namespace Assignment3_4
{
    partial class Main
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
            label1 = new Label();
            coffeeOrdersGrid = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)coffeeOrdersGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 45);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 0;
            label1.Text = "Coffee Ordering";
            // 
            // coffeeOrdersGrid
            // 
            coffeeOrdersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coffeeOrdersGrid.Location = new Point(78, 109);
            coffeeOrdersGrid.Name = "coffeeOrdersGrid";
            coffeeOrdersGrid.RowHeadersWidth = 62;
            coffeeOrdersGrid.Size = new Size(747, 225);
            coffeeOrdersGrid.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(250, 375);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(563, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(407, 375);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 462);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(coffeeOrdersGrid);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)coffeeOrdersGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView coffeeOrdersGrid;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnRefresh;
    }
}