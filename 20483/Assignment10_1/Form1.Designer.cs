namespace Assignment10_1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtBalance = new TextBox();
            btnAddCustomer = new Button();
            btnJSONser = new Button();
            btnJSONdes = new Button();
            btnXMLser = new Button();
            btnXMLdes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 66);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer Id";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 128);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 1;
            label2.Text = "Customer name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 192);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 2;
            label3.Text = "Customer Balance";
            // 
            // txtId
            // 
            txtId.Location = new Point(444, 65);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(444, 128);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 4;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(444, 186);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(150, 31);
            txtBalance.TabIndex = 5;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(356, 265);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(177, 34);
            btnAddCustomer.TabIndex = 6;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnJSONser
            // 
            btnJSONser.Location = new Point(249, 328);
            btnJSONser.Name = "btnJSONser";
            btnJSONser.Size = new Size(174, 34);
            btnJSONser.TabIndex = 7;
            btnJSONser.Text = "JSON Serialize";
            btnJSONser.UseVisualStyleBackColor = true;
            btnJSONser.Click += btnJSONser_Click;
            // 
            // btnJSONdes
            // 
            btnJSONdes.Location = new Point(536, 328);
            btnJSONdes.Name = "btnJSONdes";
            btnJSONdes.Size = new Size(161, 34);
            btnJSONdes.TabIndex = 8;
            btnJSONdes.Text = "JSON Deserialize";
            btnJSONdes.UseVisualStyleBackColor = true;
            btnJSONdes.Click += btnJSONdes_Click;
            // 
            // btnXMLser
            // 
            btnXMLser.Location = new Point(249, 378);
            btnXMLser.Name = "btnXMLser";
            btnXMLser.Size = new Size(181, 34);
            btnXMLser.TabIndex = 9;
            btnXMLser.Text = "XML Serialize";
            btnXMLser.UseVisualStyleBackColor = true;
            btnXMLser.Click += btnXMLser_Click;
            // 
            // btnXMLdes
            // 
            btnXMLdes.Location = new Point(536, 378);
            btnXMLdes.Name = "btnXMLdes";
            btnXMLdes.Size = new Size(164, 34);
            btnXMLdes.TabIndex = 10;
            btnXMLdes.Text = "XML Deserialize";
            btnXMLdes.UseVisualStyleBackColor = true;
            btnXMLdes.Click += btnXMLdes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXMLdes);
            Controls.Add(btnXMLser);
            Controls.Add(btnJSONdes);
            Controls.Add(btnJSONser);
            Controls.Add(btnAddCustomer);
            Controls.Add(txtBalance);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtBalance;
        private Button btnAddCustomer;
        private Button btnJSONser;
        private Button btnJSONdes;
        private Button btnXMLser;
        private Button btnXMLdes;
    }
}
