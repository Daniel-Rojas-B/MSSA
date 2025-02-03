namespace Mod3Week4Windowsform
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
            lblAccount = new Label();
            lblBalance = new Label();
            txtAccount = new TextBox();
            txtBalance = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Location = new Point(217, 132);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(115, 25);
            lblAccount.TabIndex = 0;
            lblAccount.Text = "BankAccount";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(217, 196);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(174, 25);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "BankAccountBalance";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(462, 134);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(150, 31);
            txtAccount.TabIndex = 2;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(462, 193);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(150, 31);
            txtBalance.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(363, 319);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 4;
            btnCreate.TabStop = false;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(txtBalance);
            Controls.Add(txtAccount);
            Controls.Add(lblBalance);
            Controls.Add(lblAccount);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccount;
        private Label lblBalance;
        private TextBox txtAccount;
        private TextBox txtBalance;
        private Button btnCreate;
    }
}
