namespace Card_Flip
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
            this.showBackButton = new System.Windows.Forms.Button();
            this.ShowFaceButton = new System.Windows.Forms.Button();
            this.cardBackPictureBox = new System.Windows.Forms.PictureBox();
            this.cardFacePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showBackButton
            // 
            this.showBackButton.Location = new System.Drawing.Point(32, 204);
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Size = new System.Drawing.Size(81, 46);
            this.showBackButton.TabIndex = 0;
            this.showBackButton.Text = " Show the Card Back";
            this.showBackButton.UseVisualStyleBackColor = true;
            this.showBackButton.Click += new System.EventHandler(this.showBackButton_Click);
            // 
            // ShowFaceButton
            // 
            this.ShowFaceButton.Location = new System.Drawing.Point(150, 204);
            this.ShowFaceButton.Name = "ShowFaceButton";
            this.ShowFaceButton.Size = new System.Drawing.Size(82, 46);
            this.ShowFaceButton.TabIndex = 1;
            this.ShowFaceButton.Text = "Show the Card Face";
            this.ShowFaceButton.UseVisualStyleBackColor = true;
            this.ShowFaceButton.Click += new System.EventHandler(this.ShowFaceButton_Click);
            // 
            // cardBackPictureBox
            // 
            this.cardBackPictureBox.Image = global::Card_Flip.Properties.Resources.Backface_Blue;
            this.cardBackPictureBox.Location = new System.Drawing.Point(23, 47);
            this.cardBackPictureBox.Name = "cardBackPictureBox";
            this.cardBackPictureBox.Size = new System.Drawing.Size(100, 140);
            this.cardBackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardBackPictureBox.TabIndex = 2;
            this.cardBackPictureBox.TabStop = false;
            // 
            // cardFacePictureBox
            // 
            this.cardFacePictureBox.Image = global::Card_Flip.Properties.Resources.Ace_Spades;
            this.cardFacePictureBox.Location = new System.Drawing.Point(141, 47);
            this.cardFacePictureBox.Name = "cardFacePictureBox";
            this.cardFacePictureBox.Size = new System.Drawing.Size(100, 140);
            this.cardFacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFacePictureBox.TabIndex = 3;
            this.cardFacePictureBox.TabStop = false;
            this.cardFacePictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cardFacePictureBox);
            this.Controls.Add(this.cardBackPictureBox);
            this.Controls.Add(this.ShowFaceButton);
            this.Controls.Add(this.showBackButton);
            this.Name = "Form1";
            this.Text = "Card Flip";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showBackButton;
        private System.Windows.Forms.Button ShowFaceButton;
        private System.Windows.Forms.PictureBox cardBackPictureBox;
        private System.Windows.Forms.PictureBox cardFacePictureBox;
    }
}

