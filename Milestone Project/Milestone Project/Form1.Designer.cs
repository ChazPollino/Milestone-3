namespace Milestone_Project
{
    partial class Milestone
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
            this.AdminButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.TitleLabel.Location = new System.Drawing.Point(363, 80);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(531, 103);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "The Taco Truck!";
            // 
            // AdminButton
            // 
            this.AdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AdminButton.Location = new System.Drawing.Point(12, 186);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(393, 101);
            this.AdminButton.TabIndex = 1;
            this.AdminButton.Text = "Admin Portal";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.EmployeeButton.Location = new System.Drawing.Point(387, 362);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(476, 101);
            this.EmployeeButton.TabIndex = 2;
            this.EmployeeButton.Text = "Employee Portal";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            // 
            // CustomerButton
            // 
            this.CustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CustomerButton.Location = new System.Drawing.Point(847, 186);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(440, 101);
            this.CustomerButton.TabIndex = 3;
            this.CustomerButton.Text = "Customer Portal";
            this.CustomerButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ExitButton.Location = new System.Drawing.Point(504, 548);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(253, 99);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Milestone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1269, 710);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Milestone";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

