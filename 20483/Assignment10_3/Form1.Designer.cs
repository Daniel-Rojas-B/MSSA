namespace Assignment10_3
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
            carGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtVIN = new TextBox();
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtYear = new TextBox();
            txtPrice = new TextBox();
            btnVIN = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)carGrid).BeginInit();
            SuspendLayout();
            // 
            // carGrid
            // 
            carGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carGrid.Location = new Point(62, 56);
            carGrid.Name = "carGrid";
            carGrid.RowHeadersWidth = 62;
            carGrid.Size = new Size(1031, 225);
            carGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 298);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 1;
            label1.Text = "VIN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 482);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 2;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 420);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 3;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 361);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 4;
            label4.Text = "Make";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 533);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 5;
            label5.Text = "Price";
            // 
            // txtVIN
            // 
            txtVIN.Location = new Point(257, 298);
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(215, 31);
            txtVIN.TabIndex = 6;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(257, 361);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(215, 31);
            txtMake.TabIndex = 7;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(257, 420);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(215, 31);
            txtModel.TabIndex = 8;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(257, 482);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(215, 31);
            txtYear.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(257, 533);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(215, 31);
            txtPrice.TabIndex = 10;
            // 
            // btnVIN
            // 
            btnVIN.Location = new Point(646, 314);
            btnVIN.Name = "btnVIN";
            btnVIN.Size = new Size(160, 34);
            btnVIN.TabIndex = 11;
            btnVIN.Text = "Generate VIN";
            btnVIN.UseVisualStyleBackColor = true;
            btnVIN.Click += btnVIN_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(646, 463);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(646, 525);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(646, 361);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(646, 411);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(174, 34);
            btnSelect.TabIndex = 15;
            btnSelect.Text = "Select to Update";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 587);
            Controls.Add(btnSelect);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnVIN);
            Controls.Add(txtPrice);
            Controls.Add(txtYear);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(txtVIN);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(carGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)carGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView carGrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtVIN;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtYear;
        private TextBox txtPrice;
        private Button btnVIN;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnSelect;
    }
}
