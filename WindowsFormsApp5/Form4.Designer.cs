namespace WindowsFormsApp5
{
    partial class Form4
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
            this.crimeRatio1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crimeTrackbar = new System.Windows.Forms.TrackBar();
            this.crimeIncrease = new MaterialSkin.Controls.MaterialRadioButton();
            this.popIncrease = new MaterialSkin.Controls.MaterialRadioButton();
            this.currentYear = new System.Windows.Forms.TextBox();
            this.chartTypeExplain = new System.Windows.Forms.TextBox();
            this.mapText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.mapUserControl1 = new WindowsFormsApp5.MapUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimeTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // crimeRatio1
            // 
            this.crimeRatio1.AutoSize = true;
            this.crimeRatio1.Depth = 0;
            this.crimeRatio1.Font = new System.Drawing.Font("Roboto", 10F);
            this.crimeRatio1.Location = new System.Drawing.Point(31, 135);
            this.crimeRatio1.Margin = new System.Windows.Forms.Padding(0);
            this.crimeRatio1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.crimeRatio1.MouseState = MaterialSkin.MouseState.HOVER;
            this.crimeRatio1.Name = "crimeRatio1";
            this.crimeRatio1.Ripple = true;
            this.crimeRatio1.Size = new System.Drawing.Size(266, 30);
            this.crimeRatio1.TabIndex = 0;
            this.crimeRatio1.TabStop = true;
            this.crimeRatio1.Text = "De verandering verhouding (veiligheid)";
            this.crimeRatio1.UseVisualStyleBackColor = true;
            this.crimeRatio1.CheckedChanged += new System.EventHandler(this.ratio_CheckedChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 270);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Criminaliteit";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(467, 306);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Criminaliteit chart1";
            // 
            // crimeTrackbar
            // 
            this.crimeTrackbar.Location = new System.Drawing.Point(31, 37);
            this.crimeTrackbar.Maximum = 2016;
            this.crimeTrackbar.Minimum = 2006;
            this.crimeTrackbar.Name = "crimeTrackbar";
            this.crimeTrackbar.Size = new System.Drawing.Size(192, 45);
            this.crimeTrackbar.TabIndex = 2;
            this.crimeTrackbar.Value = 2006;
            this.crimeTrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // crimeIncrease
            // 
            this.crimeIncrease.AutoSize = true;
            this.crimeIncrease.Depth = 0;
            this.crimeIncrease.Font = new System.Drawing.Font("Roboto", 10F);
            this.crimeIncrease.Location = new System.Drawing.Point(31, 165);
            this.crimeIncrease.Margin = new System.Windows.Forms.Padding(0);
            this.crimeIncrease.MouseLocation = new System.Drawing.Point(-1, -1);
            this.crimeIncrease.MouseState = MaterialSkin.MouseState.HOVER;
            this.crimeIncrease.Name = "crimeIncrease";
            this.crimeIncrease.Ripple = true;
            this.crimeIncrease.Size = new System.Drawing.Size(239, 30);
            this.crimeIncrease.TabIndex = 7;
            this.crimeIncrease.TabStop = true;
            this.crimeIncrease.Text = "Provincie criminaliteit verandering";
            this.crimeIncrease.UseVisualStyleBackColor = true;
            this.crimeIncrease.Click += new System.EventHandler(this.crimeIncrease_CheckedChanged);
            // 
            // popIncrease
            // 
            this.popIncrease.AutoSize = true;
            this.popIncrease.Depth = 0;
            this.popIncrease.Font = new System.Drawing.Font("Roboto", 10F);
            this.popIncrease.Location = new System.Drawing.Point(31, 195);
            this.popIncrease.Margin = new System.Windows.Forms.Padding(0);
            this.popIncrease.MouseLocation = new System.Drawing.Point(-1, -1);
            this.popIncrease.MouseState = MaterialSkin.MouseState.HOVER;
            this.popIncrease.Name = "popIncrease";
            this.popIncrease.Ripple = true;
            this.popIncrease.Size = new System.Drawing.Size(220, 30);
            this.popIncrease.TabIndex = 8;
            this.popIncrease.TabStop = true;
            this.popIncrease.Text = "Province populatie verandering";
            this.popIncrease.UseVisualStyleBackColor = true;
            this.popIncrease.Click += new System.EventHandler(this.popIncrease_CheckedChanged);
            // 
            // currentYear
            // 
            this.currentYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentYear.Location = new System.Drawing.Point(220, 58);
            this.currentYear.Name = "currentYear";
            this.currentYear.Size = new System.Drawing.Size(53, 14);
            this.currentYear.TabIndex = 9;
            this.currentYear.Text = "2006";
            // 
            // chartTypeExplain
            // 
            this.chartTypeExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chartTypeExplain.Location = new System.Drawing.Point(31, 244);
            this.chartTypeExplain.Name = "chartTypeExplain";
            this.chartTypeExplain.Size = new System.Drawing.Size(302, 13);
            this.chartTypeExplain.TabIndex = 10;
            // 
            // mapText
            // 
            this.mapText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapText.Location = new System.Drawing.Point(746, 12);
            this.mapText.Multiline = true;
            this.mapText.Name = "mapText";
            this.mapText.Size = new System.Drawing.Size(409, 103);
            this.mapText.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(31, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 14);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Selecteer een jaar om te vergelijken met 2005";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Selecteer data type voor in grafiek";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(220, 37);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 23);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "Huidig jaar:";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(485, 131);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(670, 438);
            this.elementHost1.TabIndex = 11;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.mapUserControl1;
            // 
            // Form4
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 607);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mapText);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.chartTypeExplain);
            this.Controls.Add(this.currentYear);
            this.Controls.Add(this.popIncrease);
            this.Controls.Add(this.crimeIncrease);
            this.Controls.Add(this.crimeTrackbar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.crimeRatio1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimeTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton crimeRatio1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar crimeTrackbar;
        private MaterialSkin.Controls.MaterialRadioButton crimeIncrease;
        private MaterialSkin.Controls.MaterialRadioButton popIncrease;
        private System.Windows.Forms.TextBox currentYear;
        private System.Windows.Forms.TextBox chartTypeExplain;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private MapUserControl mapUserControl1;
        private System.Windows.Forms.TextBox mapText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}