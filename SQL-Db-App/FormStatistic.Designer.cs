namespace SQL_Db_App
{
    partial class FormStatistic
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
            this.LblTotalEmployees = new System.Windows.Forms.Label();
            this.LblMEmployees = new System.Windows.Forms.Label();
            this.LblSEmployees = new System.Windows.Forms.Label();
            this.LblCities = new System.Windows.Forms.Label();
            this.LblTSalary = new System.Windows.Forms.Label();
            this.LblAvgSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTotalEmployees
            // 
            this.LblTotalEmployees.AutoSize = true;
            this.LblTotalEmployees.Location = new System.Drawing.Point(53, 33);
            this.LblTotalEmployees.Name = "LblTotalEmployees";
            this.LblTotalEmployees.Size = new System.Drawing.Size(144, 23);
            this.LblTotalEmployees.TabIndex = 0;
            this.LblTotalEmployees.Text = "Total Employees:";
            // 
            // LblMEmployees
            // 
            this.LblMEmployees.AutoSize = true;
            this.LblMEmployees.Location = new System.Drawing.Point(53, 66);
            this.LblMEmployees.Name = "LblMEmployees";
            this.LblMEmployees.Size = new System.Drawing.Size(164, 23);
            this.LblMEmployees.TabIndex = 1;
            this.LblMEmployees.Text = "Married Employees:";
            // 
            // LblSEmployees
            // 
            this.LblSEmployees.AutoSize = true;
            this.LblSEmployees.Location = new System.Drawing.Point(54, 103);
            this.LblSEmployees.Name = "LblSEmployees";
            this.LblSEmployees.Size = new System.Drawing.Size(151, 23);
            this.LblSEmployees.TabIndex = 2;
            this.LblSEmployees.Text = "Single Employees:";
            // 
            // LblCities
            // 
            this.LblCities.AutoSize = true;
            this.LblCities.Location = new System.Drawing.Point(54, 138);
            this.LblCities.Name = "LblCities";
            this.LblCities.Size = new System.Drawing.Size(46, 23);
            this.LblCities.TabIndex = 3;
            this.LblCities.Text = "City:";
            // 
            // LblTSalary
            // 
            this.LblTSalary.AutoSize = true;
            this.LblTSalary.Location = new System.Drawing.Point(54, 174);
            this.LblTSalary.Name = "LblTSalary";
            this.LblTSalary.Size = new System.Drawing.Size(106, 23);
            this.LblTSalary.TabIndex = 4;
            this.LblTSalary.Text = "Total Salary:";
            // 
            // LblAvgSalary
            // 
            this.LblAvgSalary.AutoSize = true;
            this.LblAvgSalary.Location = new System.Drawing.Point(54, 208);
            this.LblAvgSalary.Name = "LblAvgSalary";
            this.LblAvgSalary.Size = new System.Drawing.Size(130, 23);
            this.LblAvgSalary.TabIndex = 5;
            this.LblAvgSalary.Text = "Average Salary:";
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 272);
            this.Controls.Add(this.LblAvgSalary);
            this.Controls.Add(this.LblTSalary);
            this.Controls.Add(this.LblCities);
            this.Controls.Add(this.LblSEmployees);
            this.Controls.Add(this.LblMEmployees);
            this.Controls.Add(this.LblTotalEmployees);
            this.Font = new System.Drawing.Font("Corbel", 14F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormStatistic";
            this.Text = "FormStatistic";
            this.Load += new System.EventHandler(this.FormStatistic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTotalEmployees;
        private System.Windows.Forms.Label LblMEmployees;
        private System.Windows.Forms.Label LblSEmployees;
        private System.Windows.Forms.Label LblCities;
        private System.Windows.Forms.Label LblTSalary;
        private System.Windows.Forms.Label LblAvgSalary;
    }
}