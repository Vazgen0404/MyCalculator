
namespace MyCalculator
{
    partial class CalculatorForm
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
            this.tbText = new System.Windows.Forms.TextBox();
            this.btC = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btSubtract = new System.Windows.Forms.Button();
            this.btMultiply = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btRoot = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btSign = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btSum = new System.Windows.Forms.Button();
            this.btResult = new System.Windows.Forms.Button();
            this.btPoint = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(2, 1);
            this.tbText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(364, 27);
            this.tbText.TabIndex = 0;
            this.tbText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btC
            // 
            this.btC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btC.Location = new System.Drawing.Point(2, 36);
            this.btC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(85, 65);
            this.btC.TabIndex = 1;
            this.btC.TabStop = false;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt6.Location = new System.Drawing.Point(188, 182);
            this.bt6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(85, 65);
            this.bt6.TabIndex = 2;
            this.bt6.TabStop = false;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // btSubtract
            // 
            this.btSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSubtract.Location = new System.Drawing.Point(281, 182);
            this.btSubtract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSubtract.Name = "btSubtract";
            this.btSubtract.Size = new System.Drawing.Size(85, 65);
            this.btSubtract.TabIndex = 3;
            this.btSubtract.TabStop = false;
            this.btSubtract.Text = "-";
            this.btSubtract.UseVisualStyleBackColor = true;
            this.btSubtract.Click += new System.EventHandler(this.btOperation_Click);
            // 
            // btMultiply
            // 
            this.btMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMultiply.Location = new System.Drawing.Point(282, 109);
            this.btMultiply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(85, 65);
            this.btMultiply.TabIndex = 4;
            this.btMultiply.TabStop = false;
            this.btMultiply.Text = "x";
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.btOperation_Click);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt9.Location = new System.Drawing.Point(189, 109);
            this.bt9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(85, 65);
            this.bt9.TabIndex = 5;
            this.bt9.TabStop = false;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt8.Location = new System.Drawing.Point(95, 109);
            this.bt8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(85, 65);
            this.bt8.TabIndex = 6;
            this.bt8.TabStop = false;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt7.Location = new System.Drawing.Point(2, 109);
            this.bt7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(85, 65);
            this.bt7.TabIndex = 7;
            this.bt7.TabStop = false;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // btDivide
            // 
            this.btDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDivide.Location = new System.Drawing.Point(282, 36);
            this.btDivide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(85, 65);
            this.btDivide.TabIndex = 8;
            this.btDivide.TabStop = false;
            this.btDivide.Text = "÷";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.btOperation_Click);
            // 
            // btRemove
            // 
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRemove.Location = new System.Drawing.Point(189, 36);
            this.btRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(85, 65);
            this.btRemove.TabIndex = 9;
            this.btRemove.TabStop = false;
            this.btRemove.Text = "←";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btRoot
            // 
            this.btRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRoot.Location = new System.Drawing.Point(95, 36);
            this.btRoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRoot.Name = "btRoot";
            this.btRoot.Size = new System.Drawing.Size(85, 65);
            this.btRoot.TabIndex = 10;
            this.btRoot.TabStop = false;
            this.btRoot.Text = "√";
            this.btRoot.UseVisualStyleBackColor = true;
            this.btRoot.Click += new System.EventHandler(this.btRoot_Click);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt5.Location = new System.Drawing.Point(95, 182);
            this.bt5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(85, 65);
            this.bt5.TabIndex = 11;
            this.bt5.TabStop = false;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(95, 328);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(85, 65);
            this.button11.TabIndex = 12;
            this.button11.TabStop = false;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // btSign
            // 
            this.btSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSign.Location = new System.Drawing.Point(2, 328);
            this.btSign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSign.Name = "btSign";
            this.btSign.Size = new System.Drawing.Size(85, 65);
            this.btSign.TabIndex = 13;
            this.btSign.TabStop = false;
            this.btSign.Text = "+/-";
            this.btSign.UseVisualStyleBackColor = true;
            this.btSign.Click += new System.EventHandler(this.btSign_Click);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt1.Location = new System.Drawing.Point(2, 255);
            this.bt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(85, 65);
            this.bt1.TabIndex = 14;
            this.bt1.TabStop = false;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt4.Location = new System.Drawing.Point(2, 182);
            this.bt4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(85, 65);
            this.bt4.TabIndex = 15;
            this.bt4.TabStop = false;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt3.Location = new System.Drawing.Point(189, 255);
            this.bt3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(85, 65);
            this.bt3.TabIndex = 16;
            this.bt3.TabStop = false;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // btSum
            // 
            this.btSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSum.Location = new System.Drawing.Point(281, 255);
            this.btSum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(85, 65);
            this.btSum.TabIndex = 17;
            this.btSum.TabStop = false;
            this.btSum.Text = "+";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.btOperation_Click);
            // 
            // btResult
            // 
            this.btResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btResult.Location = new System.Drawing.Point(281, 328);
            this.btResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(85, 65);
            this.btResult.TabIndex = 18;
            this.btResult.TabStop = false;
            this.btResult.Text = "=";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // btPoint
            // 
            this.btPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPoint.Location = new System.Drawing.Point(188, 328);
            this.btPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPoint.Name = "btPoint";
            this.btPoint.Size = new System.Drawing.Size(85, 65);
            this.btPoint.TabIndex = 19;
            this.btPoint.TabStop = false;
            this.btPoint.Text = ".";
            this.btPoint.UseVisualStyleBackColor = true;
            this.btPoint.Click += new System.EventHandler(this.btPoint_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt2.Location = new System.Drawing.Point(96, 255);
            this.bt2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(85, 65);
            this.bt2.TabIndex = 20;
            this.bt2.TabStop = false;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 396);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.btPoint);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btSign);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.btRoot);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.btSubtract);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.tbText);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.btNumber_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button btSubtract;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btRoot;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btSign;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.Button btPoint;
        private System.Windows.Forms.Button bt2;
    }
}

