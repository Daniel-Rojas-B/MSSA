namespace Assignment4_1_2
{
    partial class Calculator
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            Number = new Button();
            btn0 = new Button();
            btnAdd = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            btnSub = new Button();
            btnClear = new Button();
            txtResult = new TextBox();
            btnEquals = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(246, 306);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 80);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Number_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(341, 306);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 80);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Number_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(438, 306);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 80);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Number_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(438, 220);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 80);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Number_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(341, 220);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 80);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Number_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(246, 220);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 80);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Number_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(438, 134);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 80);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Number_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(341, 134);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 80);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Number_Click;
            // 
            // Number
            // 
            Number.Location = new Point(246, 134);
            Number.Name = "Number";
            Number.Size = new Size(80, 80);
            Number.TabIndex = 6;
            Number.Text = "7";
            Number.UseVisualStyleBackColor = true;
            Number.Click += Number_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(341, 392);
            btn0.Name = "btn0";
            btn0.Size = new Size(80, 80);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Number_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(541, 392);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 80);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += Operator_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(541, 134);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(80, 80);
            btnDiv.TabIndex = 12;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += Operator_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(541, 220);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(80, 80);
            btnMul.TabIndex = 11;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += Operator_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(541, 306);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(80, 80);
            btnSub.TabIndex = 10;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += Operator_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(438, 392);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 80);
            btnClear.TabIndex = 14;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(246, 60);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(375, 50);
            txtResult.TabIndex = 15;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(246, 392);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(80, 80);
            btnEquals.TabIndex = 16;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 494);
            Controls.Add(btnEquals);
            Controls.Add(txtResult);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(Number);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button Number;
        private Button btn0;
        private Button btnAdd;
        private Button btnDiv;
        private Button btnMul;
        private Button btnSub;
        private Button btnClear;
        private TextBox txtResult;
        private Button btnEquals;
    }
}