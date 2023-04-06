namespace SQL_Db_App
{
    partial class FormGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChCities = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChJobSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChJobSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // ChCities
            // 
            chartArea1.Name = "ChartArea1";
            this.ChCities.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChCities.Legends.Add(legend1);
            this.ChCities.Location = new System.Drawing.Point(13, 13);
            this.ChCities.Name = "ChCities";
            this.ChCities.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Cities";
            this.ChCities.Series.Add(series1);
            this.ChCities.Size = new System.Drawing.Size(457, 300);
            this.ChCities.TabIndex = 0;
            this.ChCities.Text = "Cities";
            // 
            // ChJobSalary
            // 
            chartArea2.Name = "ChartArea1";
            this.ChJobSalary.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChJobSalary.Legends.Add(legend2);
            this.ChJobSalary.Location = new System.Drawing.Point(491, 13);
            this.ChJobSalary.Name = "ChJobSalary";
            this.ChJobSalary.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Job-Salary";
            this.ChJobSalary.Series.Add(series2);
            this.ChJobSalary.Size = new System.Drawing.Size(457, 300);
            this.ChJobSalary.TabIndex = 1;
            this.ChJobSalary.Text = "chart2";
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 347);
            this.Controls.Add(this.ChJobSalary);
            this.Controls.Add(this.ChCities);
            this.Name = "FormGraph";
            this.Text = "FormGraph";
            this.Load += new System.EventHandler(this.FormGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChJobSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChCities;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChJobSalary;
    }
}