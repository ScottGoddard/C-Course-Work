namespace Savings_Account
{
    partial class Form1
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
            this.presentValuePromptLabel = new System.Windows.Forms.Label();
            this.futureValuePromptLabel = new System.Windows.Forms.Label();
            this.annualInterestPromptLabel = new System.Windows.Forms.Label();
            this.numberYearsPrompt = new System.Windows.Forms.Label();
            this.presentValueLabel = new System.Windows.Forms.Label();
            this.futureValueTextbox = new System.Windows.Forms.TextBox();
            this.annualInterestTextBox = new System.Windows.Forms.TextBox();
            this.numYearsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // presentValuePromptLabel
            // 
            this.presentValuePromptLabel.AutoSize = true;
            this.presentValuePromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentValuePromptLabel.Location = new System.Drawing.Point(45, 20);
            this.presentValuePromptLabel.Name = "presentValuePromptLabel";
            this.presentValuePromptLabel.Size = new System.Drawing.Size(95, 16);
            this.presentValuePromptLabel.TabIndex = 0;
            this.presentValuePromptLabel.Text = "Present Value:";
            // 
            // futureValuePromptLabel
            // 
            this.futureValuePromptLabel.AutoSize = true;
            this.futureValuePromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureValuePromptLabel.Location = new System.Drawing.Point(51, 55);
            this.futureValuePromptLabel.Name = "futureValuePromptLabel";
            this.futureValuePromptLabel.Size = new System.Drawing.Size(86, 16);
            this.futureValuePromptLabel.TabIndex = 1;
            this.futureValuePromptLabel.Text = "Future Value:";
            // 
            // annualInterestPromptLabel
            // 
            this.annualInterestPromptLabel.AutoSize = true;
            this.annualInterestPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualInterestPromptLabel.Location = new System.Drawing.Point(40, 88);
            this.annualInterestPromptLabel.Name = "annualInterestPromptLabel";
            this.annualInterestPromptLabel.Size = new System.Drawing.Size(98, 16);
            this.annualInterestPromptLabel.TabIndex = 2;
            this.annualInterestPromptLabel.Text = "Annual Interest:";
            // 
            // numberYearsPrompt
            // 
            this.numberYearsPrompt.AutoSize = true;
            this.numberYearsPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberYearsPrompt.Location = new System.Drawing.Point(25, 126);
            this.numberYearsPrompt.Name = "numberYearsPrompt";
            this.numberYearsPrompt.Size = new System.Drawing.Size(112, 16);
            this.numberYearsPrompt.TabIndex = 3;
            this.numberYearsPrompt.Text = "Number of Years:";
            // 
            // presentValueLabel
            // 
            this.presentValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presentValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentValueLabel.Location = new System.Drawing.Point(143, 20);
            this.presentValueLabel.Name = "presentValueLabel";
            this.presentValueLabel.Size = new System.Drawing.Size(100, 20);
            this.presentValueLabel.TabIndex = 4;
            this.presentValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // futureValueTextbox
            // 
            this.futureValueTextbox.Location = new System.Drawing.Point(143, 55);
            this.futureValueTextbox.Name = "futureValueTextbox";
            this.futureValueTextbox.Size = new System.Drawing.Size(100, 20);
            this.futureValueTextbox.TabIndex = 5;
            this.futureValueTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // annualInterestTextBox
            // 
            this.annualInterestTextBox.Location = new System.Drawing.Point(143, 88);
            this.annualInterestTextBox.Name = "annualInterestTextBox";
            this.annualInterestTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualInterestTextBox.TabIndex = 6;
            this.annualInterestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numYearsTextBox
            // 
            this.numYearsTextBox.Location = new System.Drawing.Point(143, 125);
            this.numYearsTextBox.Name = "numYearsTextBox";
            this.numYearsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numYearsTextBox.TabIndex = 7;
            this.numYearsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(28, 178);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(169, 178);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 227);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numYearsTextBox);
            this.Controls.Add(this.annualInterestTextBox);
            this.Controls.Add(this.futureValueTextbox);
            this.Controls.Add(this.presentValueLabel);
            this.Controls.Add(this.numberYearsPrompt);
            this.Controls.Add(this.annualInterestPromptLabel);
            this.Controls.Add(this.futureValuePromptLabel);
            this.Controls.Add(this.presentValuePromptLabel);
            this.Name = "Form1";
            this.Text = "Calculate Present Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label presentValuePromptLabel;
        private System.Windows.Forms.Label futureValuePromptLabel;
        private System.Windows.Forms.Label annualInterestPromptLabel;
        private System.Windows.Forms.Label numberYearsPrompt;
        private System.Windows.Forms.Label presentValueLabel;
        private System.Windows.Forms.TextBox futureValueTextbox;
        private System.Windows.Forms.TextBox annualInterestTextBox;
        private System.Windows.Forms.TextBox numYearsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

