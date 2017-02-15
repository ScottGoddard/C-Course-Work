namespace Morse_Code_Converter
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
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.stringPrompt = new System.Windows.Forms.Label();
            this.convertedMorseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(15, 142);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(523, 142);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(174, 63);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(263, 20);
            this.stringTextBox.TabIndex = 2;
            this.stringTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stringPrompt
            // 
            this.stringPrompt.AutoSize = true;
            this.stringPrompt.Location = new System.Drawing.Point(164, 35);
            this.stringPrompt.Name = "stringPrompt";
            this.stringPrompt.Size = new System.Drawing.Size(273, 13);
            this.stringPrompt.TabIndex = 3;
            this.stringPrompt.Text = "Please type word or sentence to convert to Morse Code.";
            // 
            // convertedMorseLabel
            // 
            this.convertedMorseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.convertedMorseLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedMorseLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.convertedMorseLabel.Location = new System.Drawing.Point(22, 100);
            this.convertedMorseLabel.Name = "convertedMorseLabel";
            this.convertedMorseLabel.Size = new System.Drawing.Size(576, 23);
            this.convertedMorseLabel.TabIndex = 4;
            this.convertedMorseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 177);
            this.Controls.Add(this.convertedMorseLabel);
            this.Controls.Add(this.stringPrompt);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Name = "Form1";
            this.Text = "Morse Code Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Label stringPrompt;
        private System.Windows.Forms.Label convertedMorseLabel;
    }
}

