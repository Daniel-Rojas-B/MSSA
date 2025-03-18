namespace Mod6Serializationdemo
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
            label4 = new Label();
            button1 = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtGPA = new TextBox();
            btnJSONser = new Button();
            btnJSONdes = new Button();
            btnXMLser = new Button();
            btnXMLdes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 40);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Id";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 85);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 133);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 2;
            label3.Text = "Student Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 182);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 3;
            label4.Text = "GPA";
            // 
            // button1
            // 
            button1.Location = new Point(400, 240);
            button1.Name = "button1";
            button1.Size = new Size(182, 34);
            button1.TabIndex = 4;
            button1.Text = "Create student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(485, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(485, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(485, 127);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 7;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(485, 176);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(150, 31);
            txtGPA.TabIndex = 8;
            // 
            // btnJSONser
            // 
            btnJSONser.Location = new Point(286, 296);
            btnJSONser.Name = "btnJSONser";
            btnJSONser.Size = new Size(181, 34);
            btnJSONser.TabIndex = 9;
            btnJSONser.Text = "JSON serialize";
            btnJSONser.UseVisualStyleBackColor = true;
            btnJSONser.Click += btnJSONser_Click;
            // 
            // btnJSONdes
            // 
            btnJSONdes.Location = new Point(509, 296);
            btnJSONdes.Name = "btnJSONdes";
            btnJSONdes.Size = new Size(181, 34);
            btnJSONdes.TabIndex = 10;
            btnJSONdes.Text = "JSON deserialize";
            btnJSONdes.UseVisualStyleBackColor = true;
            btnJSONdes.Click += btnJSONdes_Click;
            // 
            // btnXMLser
            // 
            btnXMLser.Location = new Point(319, 356);
            btnXMLser.Name = "btnXMLser";
            btnXMLser.Size = new Size(112, 34);
            btnXMLser.TabIndex = 11;
            btnXMLser.Text = "XML Ser";
            btnXMLser.UseVisualStyleBackColor = true;
            btnXMLser.Click += btnXMLser_Click;
            // 
            // btnXMLdes
            // 
            btnXMLdes.Location = new Point(535, 356);
            btnXMLdes.Name = "btnXMLdes";
            btnXMLdes.Size = new Size(112, 34);
            btnXMLdes.TabIndex = 12;
            btnXMLdes.Text = "XML Des";
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
            Controls.Add(txtGPA);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(button1);
            Controls.Add(label4);
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
        private Label label4;
        private Button button1;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtGPA;
        private Button btnJSONser;
        private Button btnJSONdes;
        private Button btnXMLser;
        private Button btnXMLdes;
    }
}
