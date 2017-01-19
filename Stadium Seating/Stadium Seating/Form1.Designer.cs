namespace Stadium_Seating
{
    partial class stadiumSeatingForm
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
            this.ticketsSoldGroupBox = new System.Windows.Forms.GroupBox();
            this.classASeatTextBox = new System.Windows.Forms.TextBox();
            this.classBSeatTextBox = new System.Windows.Forms.TextBox();
            this.classCSeatTextBox = new System.Windows.Forms.TextBox();
            this.classASeatLabel = new System.Windows.Forms.Label();
            this.classBSeatLabel = new System.Windows.Forms.Label();
            this.classCSeatLabel = new System.Windows.Forms.Label();
            this.instructionLabel2 = new System.Windows.Forms.Label();
            this.instructionLabel1 = new System.Windows.Forms.Label();
            this.revenueGeneratedGroupBox = new System.Windows.Forms.GroupBox();
            this.totalRevenueLabel = new System.Windows.Forms.Label();
            this.classCTotalLabel = new System.Windows.Forms.Label();
            this.classBTotalLabel = new System.Windows.Forms.Label();
            this.classATotalLabel = new System.Windows.Forms.Label();
            this.classARevenueLabel = new System.Windows.Forms.Label();
            this.classBRevenueLabel = new System.Windows.Forms.Label();
            this.classCRevenueLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateRevenueButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketsSoldGroupBox.SuspendLayout();
            this.revenueGeneratedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketsSoldGroupBox
            // 
            this.ticketsSoldGroupBox.Controls.Add(this.classASeatTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classBSeatTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classCSeatTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classASeatLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classBSeatLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classCSeatLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.instructionLabel2);
            this.ticketsSoldGroupBox.Controls.Add(this.instructionLabel1);
            this.ticketsSoldGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ticketsSoldGroupBox.Name = "ticketsSoldGroupBox";
            this.ticketsSoldGroupBox.Size = new System.Drawing.Size(218, 206);
            this.ticketsSoldGroupBox.TabIndex = 1;
            this.ticketsSoldGroupBox.TabStop = false;
            this.ticketsSoldGroupBox.Text = "Tickets Sold";
            // 
            // classASeatTextBox
            // 
            this.classASeatTextBox.Location = new System.Drawing.Point(83, 71);
            this.classASeatTextBox.Name = "classASeatTextBox";
            this.classASeatTextBox.Size = new System.Drawing.Size(100, 20);
            this.classASeatTextBox.TabIndex = 2;
            this.classASeatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // classBSeatTextBox
            // 
            this.classBSeatTextBox.Location = new System.Drawing.Point(83, 100);
            this.classBSeatTextBox.Name = "classBSeatTextBox";
            this.classBSeatTextBox.Size = new System.Drawing.Size(100, 20);
            this.classBSeatTextBox.TabIndex = 3;
            this.classBSeatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // classCSeatTextBox
            // 
            this.classCSeatTextBox.Location = new System.Drawing.Point(83, 130);
            this.classCSeatTextBox.Name = "classCSeatTextBox";
            this.classCSeatTextBox.Size = new System.Drawing.Size(100, 20);
            this.classCSeatTextBox.TabIndex = 4;
            this.classCSeatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // classASeatLabel
            // 
            this.classASeatLabel.AutoSize = true;
            this.classASeatLabel.Location = new System.Drawing.Point(32, 74);
            this.classASeatLabel.Name = "classASeatLabel";
            this.classASeatLabel.Size = new System.Drawing.Size(45, 13);
            this.classASeatLabel.TabIndex = 2;
            this.classASeatLabel.Text = "Class A:";
            // 
            // classBSeatLabel
            // 
            this.classBSeatLabel.AutoSize = true;
            this.classBSeatLabel.Location = new System.Drawing.Point(32, 103);
            this.classBSeatLabel.Name = "classBSeatLabel";
            this.classBSeatLabel.Size = new System.Drawing.Size(45, 13);
            this.classBSeatLabel.TabIndex = 3;
            this.classBSeatLabel.Text = "Class B:";
            // 
            // classCSeatLabel
            // 
            this.classCSeatLabel.AutoSize = true;
            this.classCSeatLabel.Location = new System.Drawing.Point(32, 133);
            this.classCSeatLabel.Name = "classCSeatLabel";
            this.classCSeatLabel.Size = new System.Drawing.Size(45, 13);
            this.classCSeatLabel.TabIndex = 4;
            this.classCSeatLabel.Text = "Class C:";
            // 
            // instructionLabel2
            // 
            this.instructionLabel2.AutoSize = true;
            this.instructionLabel2.Location = new System.Drawing.Point(32, 47);
            this.instructionLabel2.Name = "instructionLabel2";
            this.instructionLabel2.Size = new System.Drawing.Size(116, 13);
            this.instructionLabel2.TabIndex = 1;
            this.instructionLabel2.Text = "for each class of seats.";
            // 
            // instructionLabel1
            // 
            this.instructionLabel1.AutoSize = true;
            this.instructionLabel1.Location = new System.Drawing.Point(32, 34);
            this.instructionLabel1.Name = "instructionLabel1";
            this.instructionLabel1.Size = new System.Drawing.Size(159, 13);
            this.instructionLabel1.TabIndex = 0;
            this.instructionLabel1.Text = "Enter the number of tickets sold ";
            // 
            // revenueGeneratedGroupBox
            // 
            this.revenueGeneratedGroupBox.Controls.Add(this.totalRevenueLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classCTotalLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classBTotalLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classATotalLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classARevenueLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classBRevenueLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classCRevenueLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.label4);
            this.revenueGeneratedGroupBox.Location = new System.Drawing.Point(260, 12);
            this.revenueGeneratedGroupBox.Name = "revenueGeneratedGroupBox";
            this.revenueGeneratedGroupBox.Size = new System.Drawing.Size(235, 206);
            this.revenueGeneratedGroupBox.TabIndex = 0;
            this.revenueGeneratedGroupBox.TabStop = false;
            this.revenueGeneratedGroupBox.Text = "Revenue Generated";
            // 
            // totalRevenueLabel
            // 
            this.totalRevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRevenueLabel.Location = new System.Drawing.Point(66, 163);
            this.totalRevenueLabel.Name = "totalRevenueLabel";
            this.totalRevenueLabel.Size = new System.Drawing.Size(100, 23);
            this.totalRevenueLabel.TabIndex = 11;
            this.totalRevenueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classCTotalLabel
            // 
            this.classCTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCTotalLabel.Location = new System.Drawing.Point(66, 132);
            this.classCTotalLabel.Name = "classCTotalLabel";
            this.classCTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.classCTotalLabel.TabIndex = 10;
            this.classCTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classBTotalLabel
            // 
            this.classBTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBTotalLabel.Location = new System.Drawing.Point(66, 100);
            this.classBTotalLabel.Name = "classBTotalLabel";
            this.classBTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.classBTotalLabel.TabIndex = 9;
            this.classBTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classATotalLabel
            // 
            this.classATotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classATotalLabel.Location = new System.Drawing.Point(66, 68);
            this.classATotalLabel.Name = "classATotalLabel";
            this.classATotalLabel.Size = new System.Drawing.Size(100, 23);
            this.classATotalLabel.TabIndex = 5;
            this.classATotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classARevenueLabel
            // 
            this.classARevenueLabel.AutoSize = true;
            this.classARevenueLabel.Location = new System.Drawing.Point(15, 74);
            this.classARevenueLabel.Name = "classARevenueLabel";
            this.classARevenueLabel.Size = new System.Drawing.Size(45, 13);
            this.classARevenueLabel.TabIndex = 5;
            this.classARevenueLabel.Text = "Class A:";
            // 
            // classBRevenueLabel
            // 
            this.classBRevenueLabel.AutoSize = true;
            this.classBRevenueLabel.Location = new System.Drawing.Point(15, 103);
            this.classBRevenueLabel.Name = "classBRevenueLabel";
            this.classBRevenueLabel.Size = new System.Drawing.Size(45, 13);
            this.classBRevenueLabel.TabIndex = 6;
            this.classBRevenueLabel.Text = "Class B:";
            // 
            // classCRevenueLabel
            // 
            this.classCRevenueLabel.AutoSize = true;
            this.classCRevenueLabel.Location = new System.Drawing.Point(15, 133);
            this.classCRevenueLabel.Name = "classCRevenueLabel";
            this.classCRevenueLabel.Size = new System.Drawing.Size(45, 13);
            this.classCRevenueLabel.TabIndex = 7;
            this.classCRevenueLabel.Text = "Class C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            // 
            // calculateRevenueButton
            // 
            this.calculateRevenueButton.Location = new System.Drawing.Point(85, 234);
            this.calculateRevenueButton.Name = "calculateRevenueButton";
            this.calculateRevenueButton.Size = new System.Drawing.Size(75, 41);
            this.calculateRevenueButton.TabIndex = 2;
            this.calculateRevenueButton.Text = "Calculate Revenue";
            this.calculateRevenueButton.UseVisualStyleBackColor = true;
            this.calculateRevenueButton.Click += new System.EventHandler(this.calculateRevenueButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(213, 234);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(74, 41);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(342, 234);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(68, 41);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stadiumSeatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 309);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateRevenueButton);
            this.Controls.Add(this.revenueGeneratedGroupBox);
            this.Controls.Add(this.ticketsSoldGroupBox);
            this.Name = "stadiumSeatingForm";
            this.Text = "Stadium Seating";
            this.ticketsSoldGroupBox.ResumeLayout(false);
            this.ticketsSoldGroupBox.PerformLayout();
            this.revenueGeneratedGroupBox.ResumeLayout(false);
            this.revenueGeneratedGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ticketsSoldGroupBox;
        private System.Windows.Forms.GroupBox revenueGeneratedGroupBox;
        private System.Windows.Forms.TextBox classASeatTextBox;
        private System.Windows.Forms.TextBox classBSeatTextBox;
        private System.Windows.Forms.TextBox classCSeatTextBox;
        private System.Windows.Forms.Label classASeatLabel;
        private System.Windows.Forms.Label classBSeatLabel;
        private System.Windows.Forms.Label classCSeatLabel;
        private System.Windows.Forms.Label instructionLabel2;
        private System.Windows.Forms.Label instructionLabel1;
        private System.Windows.Forms.Label classARevenueLabel;
        private System.Windows.Forms.Label classBRevenueLabel;
        private System.Windows.Forms.Label classCRevenueLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateRevenueButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalRevenueLabel;
        private System.Windows.Forms.Label classCTotalLabel;
        private System.Windows.Forms.Label classBTotalLabel;
        private System.Windows.Forms.Label classATotalLabel;
    }
}

