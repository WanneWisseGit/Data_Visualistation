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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.mapUserControl1 = new WindowsFormsApp5.MapUserControl();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimeTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // crimeRatio1
            // 
            this.crimeRatio1.AutoSize = true;
            this.crimeRatio1.Depth = 0;
            this.crimeRatio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.crimeRatio1.Location = new System.Drawing.Point(523, 41);
            this.crimeRatio1.Margin = new System.Windows.Forms.Padding(0);
            this.crimeRatio1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.crimeRatio1.MouseState = MaterialSkin.MouseState.HOVER;
            this.crimeRatio1.Name = "crimeRatio1";
            this.crimeRatio1.Ripple = true;
            this.crimeRatio1.Size = new System.Drawing.Size(285, 30);
            this.crimeRatio1.TabIndex = 0;
            this.crimeRatio1.TabStop = true;
            this.crimeRatio1.Text = "Criminaliteit per 100 inwoners (veiligheid)";
            this.crimeRatio1.UseVisualStyleBackColor = true;
            this.crimeRatio1.CheckedChanged += new System.EventHandler(this.ratio_CheckedChanged);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(446, 147);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 10;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Criminaliteit";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(885, 425);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Criminaliteit chart1";
            // 
            // crimeTrackbar
            // 
            this.crimeTrackbar.Location = new System.Drawing.Point(31, 41);
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
            this.crimeIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.crimeIncrease.Location = new System.Drawing.Point(523, 76);
            this.crimeIncrease.Margin = new System.Windows.Forms.Padding(0);
            this.crimeIncrease.MouseLocation = new System.Drawing.Point(-1, -1);
            this.crimeIncrease.MouseState = MaterialSkin.MouseState.HOVER;
            this.crimeIncrease.Name = "crimeIncrease";
            this.crimeIncrease.Ripple = true;
            this.crimeIncrease.Size = new System.Drawing.Size(144, 30);
            this.crimeIncrease.TabIndex = 7;
            this.crimeIncrease.TabStop = true;
            this.crimeIncrease.Text = "Totale criminaliteit";
            this.crimeIncrease.UseVisualStyleBackColor = true;
            this.crimeIncrease.Click += new System.EventHandler(this.crimeIncrease_CheckedChanged);
            // 
            // popIncrease
            // 
            this.popIncrease.AutoSize = true;
            this.popIncrease.Depth = 0;
            this.popIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.popIncrease.Location = new System.Drawing.Point(523, 106);
            this.popIncrease.Margin = new System.Windows.Forms.Padding(0);
            this.popIncrease.MouseLocation = new System.Drawing.Point(-1, -1);
            this.popIncrease.MouseState = MaterialSkin.MouseState.HOVER;
            this.popIncrease.Name = "popIncrease";
            this.popIncrease.Ripple = true;
            this.popIncrease.Size = new System.Drawing.Size(129, 30);
            this.popIncrease.TabIndex = 8;
            this.popIncrease.TabStop = true;
            this.popIncrease.Text = "Totale populatie";
            this.popIncrease.UseVisualStyleBackColor = true;
            this.popIncrease.Click += new System.EventHandler(this.popIncrease_CheckedChanged);
            // 
            // currentYear
            // 
            this.currentYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentYear.Location = new System.Drawing.Point(229, 50);
            this.currentYear.Name = "currentYear";
            this.currentYear.Size = new System.Drawing.Size(53, 17);
            this.currentYear.TabIndex = 9;
            this.currentYear.Text = "2006";
            // 
            // chartTypeExplain
            // 
            this.chartTypeExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chartTypeExplain.Location = new System.Drawing.Point(31, 86);
            this.chartTypeExplain.Name = "chartTypeExplain";
            this.chartTypeExplain.Size = new System.Drawing.Size(302, 13);
            this.chartTypeExplain.TabIndex = 10;
            // 
            // mapText
            // 
            this.mapText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapText.Location = new System.Drawing.Point(31, 82);
            this.mapText.Multiline = true;
            this.mapText.Name = "mapText";
            this.mapText.Size = new System.Drawing.Size(429, 96);
            this.mapText.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(31, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 26);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Selecteer een jaar";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(523, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(637, 27);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "Drenthe";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(31, 183);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(429, 377);
            this.elementHost1.TabIndex = 11;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.mapUserControl1;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(528, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 15);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "Aantal procent inwoners die een misdaad hebben gepleegd 2005-2016";
            // 
            // Form4
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 569);
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