
namespace Bookstore.BookForm
{
    partial class Statistics_form
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.no_purchases_label = new System.Windows.Forms.Label();
            this.no_comments_label = new System.Windows.Forms.Label();
            this.overall_critiques_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.MediumAquamarine;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(38, 44);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Αγορές";
            series1.Name = "purchases";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(730, 307);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.MediumAquamarine;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(210, 417);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Score";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(406, 307);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Αστέρια";
            this.chart2.Titles.Add(title1);
            // 
            // no_purchases_label
            // 
            this.no_purchases_label.AutoSize = true;
            this.no_purchases_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_purchases_label.Location = new System.Drawing.Point(130, 354);
            this.no_purchases_label.Name = "no_purchases_label";
            this.no_purchases_label.Size = new System.Drawing.Size(548, 31);
            this.no_purchases_label.TabIndex = 2;
            this.no_purchases_label.Text = "Δεν έχει αγοράσει κανένας το βιβλίο ακόμα.";
            this.no_purchases_label.Visible = false;
            // 
            // no_comments_label
            // 
            this.no_comments_label.AutoSize = true;
            this.no_comments_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_comments_label.Location = new System.Drawing.Point(204, 560);
            this.no_comments_label.Name = "no_comments_label";
            this.no_comments_label.Size = new System.Drawing.Size(380, 31);
            this.no_comments_label.TabIndex = 2;
            this.no_comments_label.Text = "Δεν υπάρχουν κριτικές ακόμα.";
            this.no_comments_label.Visible = false;
            // 
            // overall_critiques_label
            // 
            this.overall_critiques_label.AutoSize = true;
            this.overall_critiques_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overall_critiques_label.Location = new System.Drawing.Point(255, 727);
            this.overall_critiques_label.Name = "overall_critiques_label";
            this.overall_critiques_label.Size = new System.Drawing.Size(204, 25);
            this.overall_critiques_label.TabIndex = 2;
            this.overall_critiques_label.Text = "Συνολικές κριτικές: ";
            // 
            // Statistics_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(821, 812);
            this.Controls.Add(this.overall_critiques_label);
            this.Controls.Add(this.no_comments_label);
            this.Controls.Add(this.no_purchases_label);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Statistics_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics_form";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label no_purchases_label;
        private System.Windows.Forms.Label no_comments_label;
        private System.Windows.Forms.Label overall_critiques_label;
    }
}