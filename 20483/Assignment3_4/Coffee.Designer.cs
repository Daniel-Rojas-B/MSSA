namespace Assignment3_4
{
    partial class CoffeeForm: Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeForm));
            lblType = new Label();
            lblSize = new Label();
            lblStrength = new Label();
            lblRoast = new Label();
            lblMilk = new Label();
            comboType = new ComboBox();
            comboSize = new ComboBox();
            comboStrength = new ComboBox();
            comboRoast = new ComboBox();
            comboMilk = new ComboBox();
            btnOrder = new Button();
            SuspendLayout();
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(205, 103);
            lblType.Name = "lblType";
            lblType.Size = new Size(49, 25);
            lblType.TabIndex = 0;
            lblType.Text = "Type";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(205, 147);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(43, 25);
            lblSize.TabIndex = 1;
            lblSize.Text = "Size";
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.Location = new Point(205, 189);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(79, 25);
            lblStrength.TabIndex = 2;
            lblStrength.Text = "Strength";
            // 
            // lblRoast
            // 
            lblRoast.AutoSize = true;
            lblRoast.Location = new Point(205, 228);
            lblRoast.Name = "lblRoast";
            lblRoast.Size = new Size(56, 25);
            lblRoast.TabIndex = 3;
            lblRoast.Text = "Roast";
            // 
            // lblMilk
            // 
            lblMilk.AutoSize = true;
            lblMilk.Location = new Point(205, 267);
            lblMilk.Name = "lblMilk";
            lblMilk.Size = new Size(45, 25);
            lblMilk.TabIndex = 4;
            lblMilk.Text = "Milk";
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;
            comboType.Location = new Point(398, 100);
            comboType.Name = "comboType";
            comboType.Size = new Size(182, 33);
            comboType.TabIndex = 5;
            // 
            // comboSize
            // 
            comboSize.FormattingEnabled = true;
            comboSize.Location = new Point(398, 144);
            comboSize.Name = "comboSize";
            comboSize.Size = new Size(182, 33);
            comboSize.TabIndex = 6;
            // 
            // comboStrength
            // 
            comboStrength.FormattingEnabled = true;
            comboStrength.Location = new Point(398, 186);
            comboStrength.Name = "comboStrength";
            comboStrength.Size = new Size(182, 33);
            comboStrength.TabIndex = 7;
            // 
            // comboRoast
            // 
            comboRoast.FormattingEnabled = true;
            comboRoast.Location = new Point(398, 225);
            comboRoast.Name = "comboRoast";
            comboRoast.Size = new Size(182, 33);
            comboRoast.TabIndex = 8;
            // 
            // comboMilk
            // 
            comboMilk.FormattingEnabled = true;
            comboMilk.Location = new Point(398, 264);
            comboMilk.Name = "comboMilk";
            comboMilk.Size = new Size(182, 33);
            comboMilk.TabIndex = 9;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(357, 348);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(112, 34);
            btnOrder.TabIndex = 10;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // CoffeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnOrder);
            Controls.Add(comboMilk);
            Controls.Add(comboRoast);
            Controls.Add(comboStrength);
            Controls.Add(comboSize);
            Controls.Add(comboType);
            Controls.Add(lblMilk);
            Controls.Add(lblRoast);
            Controls.Add(lblStrength);
            Controls.Add(lblSize);
            Controls.Add(lblType);
            Name = "CoffeeForm";
            Text = "Coffee";
            Load += CoffeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblType;
        private Label lblSize;
        private Label lblStrength;
        private Label lblRoast;
        private Label lblMilk;
        private ComboBox comboType;
        private ComboBox comboSize;
        private ComboBox comboStrength;
        private ComboBox comboRoast;
        private ComboBox comboMilk;
        private Button btnOrder;
    }
}