namespace Card_Identifier
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
            this.cardPictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardPictureBox2 = new System.Windows.Forms.PictureBox();
            this.cardPictureBox3 = new System.Windows.Forms.PictureBox();
            this.cardPictureBox4 = new System.Windows.Forms.PictureBox();
            this.cardPictureBox5 = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.cardLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // cardPictureBox1
            // 
            this.cardPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardPictureBox1.Image = global::Card_Identifier.Properties.Resources._8_Diamonds;
            this.cardPictureBox1.Location = new System.Drawing.Point(29, 46);
            this.cardPictureBox1.Name = "cardPictureBox1";
            this.cardPictureBox1.Size = new System.Drawing.Size(100, 140);
            this.cardPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPictureBox1.TabIndex = 0;
            this.cardPictureBox1.TabStop = false;
            this.cardPictureBox1.Click += new System.EventHandler(this.cardPictureBox1_Click);
            // 
            // cardPictureBox2
            // 
            this.cardPictureBox2.Image = global::Card_Identifier.Properties.Resources._2_Clubs;
            this.cardPictureBox2.Location = new System.Drawing.Point(156, 46);
            this.cardPictureBox2.Name = "cardPictureBox2";
            this.cardPictureBox2.Size = new System.Drawing.Size(100, 140);
            this.cardPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPictureBox2.TabIndex = 1;
            this.cardPictureBox2.TabStop = false;
            this.cardPictureBox2.Click += new System.EventHandler(this.cardPictureBox2_Click);
            // 
            // cardPictureBox3
            // 
            this.cardPictureBox3.Image = global::Card_Identifier.Properties.Resources.King_Spades;
            this.cardPictureBox3.Location = new System.Drawing.Point(280, 46);
            this.cardPictureBox3.Name = "cardPictureBox3";
            this.cardPictureBox3.Size = new System.Drawing.Size(100, 140);
            this.cardPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPictureBox3.TabIndex = 2;
            this.cardPictureBox3.TabStop = false;
            this.cardPictureBox3.Click += new System.EventHandler(this.cardPictureBox3_Click);
            // 
            // cardPictureBox4
            // 
            this.cardPictureBox4.Image = global::Card_Identifier.Properties.Resources.Ace_Spades;
            this.cardPictureBox4.Location = new System.Drawing.Point(406, 46);
            this.cardPictureBox4.Name = "cardPictureBox4";
            this.cardPictureBox4.Size = new System.Drawing.Size(100, 140);
            this.cardPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPictureBox4.TabIndex = 3;
            this.cardPictureBox4.TabStop = false;
            this.cardPictureBox4.Click += new System.EventHandler(this.cardPictureBox4_Click);
            // 
            // cardPictureBox5
            // 
            this.cardPictureBox5.Image = global::Card_Identifier.Properties.Resources.Joker_Black;
            this.cardPictureBox5.Location = new System.Drawing.Point(529, 46);
            this.cardPictureBox5.Name = "cardPictureBox5";
            this.cardPictureBox5.Size = new System.Drawing.Size(100, 140);
            this.cardPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardPictureBox5.TabIndex = 4;
            this.cardPictureBox5.TabStop = false;
            this.cardPictureBox5.Click += new System.EventHandler(this.cardPictureBox5_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(239, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(181, 16);
            this.instructionLabel.TabIndex = 5;
            this.instructionLabel.Text = "Click a Card to See It\'s Name";
            // 
            // cardLabel
            // 
            this.cardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardLabel.Location = new System.Drawing.Point(29, 206);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(600, 23);
            this.cardLabel.TabIndex = 6;
            this.cardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 254);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.cardPictureBox5);
            this.Controls.Add(this.cardPictureBox4);
            this.Controls.Add(this.cardPictureBox3);
            this.Controls.Add(this.cardPictureBox2);
            this.Controls.Add(this.cardPictureBox1);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cardPictureBox1;
        private System.Windows.Forms.PictureBox cardPictureBox2;
        private System.Windows.Forms.PictureBox cardPictureBox3;
        private System.Windows.Forms.PictureBox cardPictureBox4;
        private System.Windows.Forms.PictureBox cardPictureBox5;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label cardLabel;
    }
}

