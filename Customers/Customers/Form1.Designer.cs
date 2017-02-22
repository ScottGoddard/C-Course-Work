namespace Customers
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
            this.customerDataLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.mailingListLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.mailingListCheckBox = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.customerPropertiesListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mailingListColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDataLabel
            // 
            this.customerDataLabel.AutoSize = true;
            this.customerDataLabel.Location = new System.Drawing.Point(76, 9);
            this.customerDataLabel.Name = "customerDataLabel";
            this.customerDataLabel.Size = new System.Drawing.Size(105, 13);
            this.customerDataLabel.TabIndex = 0;
            this.customerDataLabel.Text = "Enter Customer Data";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(64, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(54, 57);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(24, 84);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(34, 109);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(68, 13);
            this.customerIDLabel.TabIndex = 4;
            this.customerIDLabel.Text = "Customer ID:";
            // 
            // mailingListLabel
            // 
            this.mailingListLabel.AutoSize = true;
            this.mailingListLabel.Location = new System.Drawing.Point(9, 134);
            this.mailingListLabel.Name = "mailingListLabel";
            this.mailingListLabel.Size = new System.Drawing.Size(96, 13);
            this.mailingListLabel.TabIndex = 5;
            this.mailingListLabel.Text = "Add to Mailing List:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(108, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(108, 56);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(108, 81);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 8;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(108, 106);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerIDTextBox.TabIndex = 9;
            // 
            // mailingListCheckBox
            // 
            this.mailingListCheckBox.AutoSize = true;
            this.mailingListCheckBox.Location = new System.Drawing.Point(111, 134);
            this.mailingListCheckBox.Name = "mailingListCheckBox";
            this.mailingListCheckBox.Size = new System.Drawing.Size(60, 17);
            this.mailingListCheckBox.TabIndex = 10;
            this.mailingListCheckBox.Text = "Check ";
            this.mailingListCheckBox.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 210);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(147, 210);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // customerPropertiesListView
            // 
            this.customerPropertiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.addressColumn,
            this.phoneNumberColumn,
            this.customerIDColumn,
            this.mailingListColumn});
            this.customerPropertiesListView.Location = new System.Drawing.Point(15, 21);
            this.customerPropertiesListView.Name = "customerPropertiesListView";
            this.customerPropertiesListView.Size = new System.Drawing.Size(524, 161);
            this.customerPropertiesListView.TabIndex = 13;
            this.customerPropertiesListView.UseCompatibleStateImageBehavior = false;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 110;
            // 
            // addressColumn
            // 
            this.addressColumn.Text = "Address";
            this.addressColumn.Width = 110;
            // 
            // phoneNumberColumn
            // 
            this.phoneNumberColumn.Text = "Phone Number";
            this.phoneNumberColumn.Width = 100;
            // 
            // customerIDColumn
            // 
            this.customerIDColumn.Text = "Customer ID";
            this.customerIDColumn.Width = 100;
            // 
            // mailingListColumn
            // 
            this.mailingListColumn.Text = "Mailing List";
            this.mailingListColumn.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerPropertiesListView);
            this.groupBox1.Location = new System.Drawing.Point(228, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 221);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Object Properties";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.mailingListCheckBox);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.mailingListLabel);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.customerDataLabel);
            this.Name = "Form1";
            this.Text = "Customers";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerDataLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label mailingListLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.CheckBox mailingListCheckBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView customerPropertiesListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader addressColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader phoneNumberColumn;
        private System.Windows.Forms.ColumnHeader customerIDColumn;
        private System.Windows.Forms.ColumnHeader mailingListColumn;
    }
}

