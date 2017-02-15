namespace Employee_Class
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
            this.employeeDataGroupBox = new System.Windows.Forms.GroupBox();
            this.employeePropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idnumberLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.idnumberTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.postionTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.employeePropertiesListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departmentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.positionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeDataGroupBox.SuspendLayout();
            this.employeePropertiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeDataGroupBox
            // 
            this.employeeDataGroupBox.Controls.Add(this.postionTextBox);
            this.employeeDataGroupBox.Controls.Add(this.departmentTextBox);
            this.employeeDataGroupBox.Controls.Add(this.idnumberTextBox);
            this.employeeDataGroupBox.Controls.Add(this.positionLabel);
            this.employeeDataGroupBox.Controls.Add(this.departmentLabel);
            this.employeeDataGroupBox.Controls.Add(this.idnumberLabel);
            this.employeeDataGroupBox.Controls.Add(this.nameTextBox);
            this.employeeDataGroupBox.Controls.Add(this.numberLabel);
            this.employeeDataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.employeeDataGroupBox.Name = "employeeDataGroupBox";
            this.employeeDataGroupBox.Size = new System.Drawing.Size(208, 181);
            this.employeeDataGroupBox.TabIndex = 1;
            this.employeeDataGroupBox.TabStop = false;
            this.employeeDataGroupBox.Text = "Enter Employee Data";
            // 
            // employeePropertiesGroupBox
            // 
            this.employeePropertiesGroupBox.Controls.Add(this.employeePropertiesListView);
            this.employeePropertiesGroupBox.Location = new System.Drawing.Point(226, 12);
            this.employeePropertiesGroupBox.Name = "employeePropertiesGroupBox";
            this.employeePropertiesGroupBox.Size = new System.Drawing.Size(446, 196);
            this.employeePropertiesGroupBox.TabIndex = 2;
            this.employeePropertiesGroupBox.TabStop = false;
            this.employeePropertiesGroupBox.Text = "Employee Object Properties";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(45, 40);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(38, 13);
            this.numberLabel.TabIndex = 3;
            this.numberLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(89, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // idnumberLabel
            // 
            this.idnumberLabel.AutoSize = true;
            this.idnumberLabel.Location = new System.Drawing.Point(22, 66);
            this.idnumberLabel.Name = "idnumberLabel";
            this.idnumberLabel.Size = new System.Drawing.Size(61, 13);
            this.idnumberLabel.TabIndex = 3;
            this.idnumberLabel.Text = "ID Number:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(18, 92);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(65, 13);
            this.departmentLabel.TabIndex = 3;
            this.departmentLabel.Text = "Department:";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(36, 119);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(47, 13);
            this.positionLabel.TabIndex = 3;
            this.positionLabel.Text = "Position:";
            // 
            // idnumberTextBox
            // 
            this.idnumberTextBox.Location = new System.Drawing.Point(89, 63);
            this.idnumberTextBox.Name = "idnumberTextBox";
            this.idnumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.idnumberTextBox.TabIndex = 4;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(89, 89);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.departmentTextBox.TabIndex = 5;
            // 
            // postionTextBox
            // 
            this.postionTextBox.Location = new System.Drawing.Point(89, 116);
            this.postionTextBox.Name = "postionTextBox";
            this.postionTextBox.Size = new System.Drawing.Size(100, 20);
            this.postionTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(86, 214);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(270, 214);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // employeePropertiesListView
            // 
            this.employeePropertiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.idColumn,
            this.departmentColumn,
            this.positionColumn});
            this.employeePropertiesListView.GridLines = true;
            this.employeePropertiesListView.Location = new System.Drawing.Point(19, 19);
            this.employeePropertiesListView.Name = "employeePropertiesListView";
            this.employeePropertiesListView.Size = new System.Drawing.Size(409, 162);
            this.employeePropertiesListView.TabIndex = 1;
            this.employeePropertiesListView.UseCompatibleStateImageBehavior = false;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 100;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID Number";
            this.idColumn.Width = 100;
            // 
            // departmentColumn
            // 
            this.departmentColumn.Text = "Department";
            this.departmentColumn.Width = 100;
            // 
            // positionColumn
            // 
            this.positionColumn.Text = "Position";
            this.positionColumn.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 300);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.employeePropertiesGroupBox);
            this.Controls.Add(this.employeeDataGroupBox);
            this.Name = "Form1";
            this.Text = "Employee Data";
            this.employeeDataGroupBox.ResumeLayout(false);
            this.employeeDataGroupBox.PerformLayout();
            this.employeePropertiesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox employeeDataGroupBox;
        private System.Windows.Forms.TextBox postionTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox idnumberTextBox;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label idnumberLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.GroupBox employeePropertiesGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView employeePropertiesListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader departmentColumn;
        private System.Windows.Forms.ColumnHeader positionColumn;
    }
}

