namespace Names_Search
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
            this.girlsLabel = new System.Windows.Forms.Label();
            this.boysLabel = new System.Windows.Forms.Label();
            this.popularNameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.girlsTextBox = new System.Windows.Forms.TextBox();
            this.boysTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // girlsLabel
            // 
            this.girlsLabel.AutoSize = true;
            this.girlsLabel.Location = new System.Drawing.Point(30, 63);
            this.girlsLabel.Name = "girlsLabel";
            this.girlsLabel.Size = new System.Drawing.Size(139, 13);
            this.girlsLabel.TabIndex = 0;
            this.girlsLabel.Text = "Please provide a girls name:";
            // 
            // boysLabel
            // 
            this.boysLabel.AutoSize = true;
            this.boysLabel.Location = new System.Drawing.Point(30, 93);
            this.boysLabel.Name = "boysLabel";
            this.boysLabel.Size = new System.Drawing.Size(143, 13);
            this.boysLabel.TabIndex = 1;
            this.boysLabel.Text = "Please provide a boys name:";
            // 
            // popularNameButton
            // 
            this.popularNameButton.Location = new System.Drawing.Point(33, 139);
            this.popularNameButton.Name = "popularNameButton";
            this.popularNameButton.Size = new System.Drawing.Size(76, 34);
            this.popularNameButton.TabIndex = 2;
            this.popularNameButton.Text = "Popular Name";
            this.popularNameButton.UseVisualStyleBackColor = true;
            this.popularNameButton.Click += new System.EventHandler(this.popularNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(221, 139);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // girlsTextBox
            // 
            this.girlsTextBox.Location = new System.Drawing.Point(196, 60);
            this.girlsTextBox.Name = "girlsTextBox";
            this.girlsTextBox.Size = new System.Drawing.Size(100, 20);
            this.girlsTextBox.TabIndex = 4;
            // 
            // boysTextBox
            // 
            this.boysTextBox.Location = new System.Drawing.Point(196, 93);
            this.boysTextBox.Name = "boysTextBox";
            this.boysTextBox.Size = new System.Drawing.Size(100, 20);
            this.boysTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Provide a girl or boys name to see if it is popular.";
            // 
            // answerLabel
            // 
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.answerLabel.Location = new System.Drawing.Point(7, 188);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(320, 23);
            this.answerLabel.TabIndex = 7;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 234);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boysTextBox);
            this.Controls.Add(this.girlsTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.popularNameButton);
            this.Controls.Add(this.boysLabel);
            this.Controls.Add(this.girlsLabel);
            this.Name = "Form1";
            this.Text = "Names Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label girlsLabel;
        private System.Windows.Forms.Label boysLabel;
        private System.Windows.Forms.Button popularNameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox girlsTextBox;
        private System.Windows.Forms.TextBox boysTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label answerLabel;
    }
}

