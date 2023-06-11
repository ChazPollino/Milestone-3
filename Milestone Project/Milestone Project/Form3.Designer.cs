namespace Milestone_Project
{
    partial class AdminPortal
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HoursButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.TitleLabel.Location = new System.Drawing.Point(522, 98);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(469, 76);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Admin Portal";
            // 
            // InventoryButton
            // 
            this.InventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.InventoryButton.Location = new System.Drawing.Point(85, 408);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(369, 75);
            this.InventoryButton.TabIndex = 1;
            this.InventoryButton.Text = "Full-Inventory";
            this.InventoryButton.UseVisualStyleBackColor = true;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.EmployeeButton.Location = new System.Drawing.Point(596, 408);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(369, 75);
            this.EmployeeButton.TabIndex = 2;
            this.EmployeeButton.Text = "Employees";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ExitButton.Location = new System.Drawing.Point(596, 629);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(311, 80);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HoursButton
            // 
            this.HoursButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.HoursButton.Location = new System.Drawing.Point(1070, 408);
            this.HoursButton.Name = "HoursButton";
            this.HoursButton.Size = new System.Drawing.Size(396, 75);
            this.HoursButton.TabIndex = 5;
            this.HoursButton.Text = "Employee Hours";
            this.HoursButton.UseVisualStyleBackColor = true;
            // 
            // AdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1551, 884);
            this.Controls.Add(this.HoursButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.InventoryButton);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "AdminPortal";
            this.Text = "Admin Portal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button HoursButton;
    }
}