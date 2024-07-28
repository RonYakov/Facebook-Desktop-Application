namespace BasicFacebookFeatures
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPostData = new System.Windows.Forms.Label();
            this.chartPosts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartImages = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxYearPosts = new System.Windows.Forms.ComboBox();
            this.comboBoxYearImages = new System.Windows.Forms.ComboBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartImages)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelPostData);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 102);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(29, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 86);
            this.label4.TabIndex = 19;
            this.label4.Text = "Facebook";
            // 
            // labelPostData
            // 
            this.labelPostData.AutoSize = true;
            this.labelPostData.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostData.Location = new System.Drawing.Point(216, 38);
            this.labelPostData.Name = "labelPostData";
            this.labelPostData.Size = new System.Drawing.Size(0, 25);
            this.labelPostData.TabIndex = 13;
            // 
            // chartPosts
            // 
            chartArea9.Name = "ChartArea1";
            this.chartPosts.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartPosts.Legends.Add(legend9);
            this.chartPosts.Location = new System.Drawing.Point(42, 161);
            this.chartPosts.Name = "chartPosts";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartPosts.Series.Add(series9);
            this.chartPosts.Size = new System.Drawing.Size(1130, 135);
            this.chartPosts.TabIndex = 16;
            this.chartPosts.Text = "chart1";
            // 
            // chartImages
            // 
            chartArea10.Name = "ChartArea1";
            this.chartImages.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartImages.Legends.Add(legend10);
            this.chartImages.Location = new System.Drawing.Point(42, 353);
            this.chartImages.Name = "chartImages";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartImages.Series.Add(series10);
            this.chartImages.Size = new System.Drawing.Size(1130, 135);
            this.chartImages.TabIndex = 17;
            this.chartImages.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hadassah Friedlaender", 11.25F);
            this.label1.Location = new System.Drawing.Point(39, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Posts statistics:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hadassah Friedlaender", 11.25F);
            this.label2.Location = new System.Drawing.Point(39, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Images statistics:";
            // 
            // comboBoxYearPosts
            // 
            this.comboBoxYearPosts.FormattingEnabled = true;
            this.comboBoxYearPosts.Location = new System.Drawing.Point(1033, 170);
            this.comboBoxYearPosts.Name = "comboBoxYearPosts";
            this.comboBoxYearPosts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYearPosts.TabIndex = 20;
            this.comboBoxYearPosts.SelectedIndexChanged += new System.EventHandler(this.comboBoxYearPosts_SelectedIndexChanged);
            // 
            // comboBoxYearImages
            // 
            this.comboBoxYearImages.FormattingEnabled = true;
            this.comboBoxYearImages.Location = new System.Drawing.Point(1033, 362);
            this.comboBoxYearImages.Name = "comboBoxYearImages";
            this.comboBoxYearImages.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYearImages.TabIndex = 21;
            this.comboBoxYearImages.SelectedIndexChanged += new System.EventHandler(this.comboBoxYearImages_SelectedIndexChanged);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(1052, 527);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(119, 57);
            this.buttonReturn.TabIndex = 22;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 600);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.comboBoxYearImages);
            this.Controls.Add(this.comboBoxYearPosts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartImages);
            this.Controls.Add(this.chartPosts);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1234, 639);
            this.MinimumSize = new System.Drawing.Size(1234, 639);
            this.Name = "FormStatistics";
            this.Text = "Facebook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPostData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPosts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxYearPosts;
        private System.Windows.Forms.ComboBox comboBoxYearImages;
        private System.Windows.Forms.Button buttonReturn;
    }
}