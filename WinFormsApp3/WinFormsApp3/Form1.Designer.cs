namespace WinFormsApp3
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
            this.resultButton = new System.Windows.Forms.Button();
            this.resultOut = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.Words = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.convertFlag2 = new System.Windows.Forms.RadioButton();
            this.convertFlag1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // resultButton
            // 
            this.resultButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultButton.Location = new System.Drawing.Point(323, 256);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(100, 39);
            this.resultButton.TabIndex = 15;
            this.resultButton.Text = "Вычислить";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // resultOut
            // 
            this.resultOut.AutoSize = true;
            this.resultOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultOut.Location = new System.Drawing.Point(374, 359);
            this.resultOut.Name = "resultOut";
            this.resultOut.Size = new System.Drawing.Size(0, 19);
            this.resultOut.TabIndex = 14;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(225, 359);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(75, 19);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.Text = "Результат:";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueLabel.Location = new System.Drawing.Point(433, 154);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(133, 19);
            this.valueLabel.TabIndex = 12;
            this.valueLabel.Text = "Введите значение:";
            // 
            // Words
            // 
            this.Words.AutoSize = true;
            this.Words.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Words.Location = new System.Drawing.Point(124, 73);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(581, 21);
            this.Words.TabIndex = 11;
            this.Words.Text = "Программа перевода значений в метрах в значения в метрах и обратно";
            // 
            // value
            // 
            this.value.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value.Location = new System.Drawing.Point(572, 147);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(100, 26);
            this.value.TabIndex = 10;
            // 
            // convertFlag2
            // 
            this.convertFlag2.AutoSize = true;
            this.convertFlag2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertFlag2.Location = new System.Drawing.Point(96, 166);
            this.convertFlag2.Name = "convertFlag2";
            this.convertFlag2.Size = new System.Drawing.Size(146, 23);
            this.convertFlag2.TabIndex = 9;
            this.convertFlag2.TabStop = true;
            this.convertFlag2.Text = "Из футов в метры";
            this.convertFlag2.UseVisualStyleBackColor = true;
            this.convertFlag2.CheckedChanged += new System.EventHandler(this.convertFlag2_CheckedChanged);
            // 
            // convertFlag1
            // 
            this.convertFlag1.AutoSize = true;
            this.convertFlag1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertFlag1.Location = new System.Drawing.Point(96, 131);
            this.convertFlag1.Name = "convertFlag1";
            this.convertFlag1.Size = new System.Drawing.Size(146, 23);
            this.convertFlag1.TabIndex = 8;
            this.convertFlag1.TabStop = true;
            this.convertFlag1.Text = "Из метров в футы";
            this.convertFlag1.UseVisualStyleBackColor = true;
            this.convertFlag1.CheckedChanged += new System.EventHandler(this.convertFlag1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.resultOut);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.value);
            this.Controls.Add(this.convertFlag2);
            this.Controls.Add(this.convertFlag1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button resultButton;
        private Label resultOut;
        private Label resultLabel;
        private Label valueLabel;
        private Label Words;
        private TextBox value;
        private RadioButton convertFlag2;
        private RadioButton convertFlag1;
    }
}