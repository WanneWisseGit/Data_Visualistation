using System;
using System.Collections.Generic;
using MaterialSkin.Controls;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Maps.MapControl.WPF;
using System.Windows;

namespace WindowsFormsApp5
{
    public partial class Form6 : Form
    {
        private bool Slided;

        public Form6()
        {
            InitializeComponent();

            drawNewEconomyChart(2010);

            Slided = false;
            //Toggle();
        }


        private void drawNewEconomyChart(int year)
        {
            //Database connection
            SqlConnection connection;
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["WindowsFormsApp5.Properties.Settings.Database1ConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            //Open connection to run dat query
            connection.Open();

            //Query to get the population total, crime total per year per province
            string selectedHYear = "h" + year;
            SqlDataAdapter data2 = new SqlDataAdapter("(SELECT province, " + selectedHYear + " FROM Economy)", connection);

            //Query is done, close connection
            connection.Close();

            //Store query result in datatable for later use
            DataTable economy = new DataTable();
            data2.Fill(economy);

            //Empty the crimechart
            chart1.Series[0].Points.Clear();
            //TODO: needs to be done in the desinger
            chart1.ChartAreas[0].AxisX.Interval = 1;
            //chart2.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            //chart2.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            //max en min hoogte van de grafiek
            chart1.ChartAreas[0].AxisY.Maximum = 500;
            chart1.ChartAreas[0].AxisY.Minimum = -100;

            //Loop through the data to calculate the crime ratio and show it in the crimechart
            foreach (DataRow row in economy.Rows)
            {
                string province = row[0].ToString();
                int dinges = Convert.ToInt32(row[1]);
                chart1.Series["Economy"].Points.AddXY(province, dinges);
            }
        }

        //vraag economy trackbar
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int year = economyTrackbar.Value;
            drawNewEconomyChart(year);
            year1.Text = year.ToString();
        }
        //
        //
        //einde van vraagje economy

        //begin van vraagje natuur
        //
        //

        //
        //
        //einde van vraagje economy

        /*Form slide toggle
        public void Toggle()
        {
            if (Slided)
            {
                SlideOut(this, 835);
                Slided = false;
            }
            else
            {
                SlideIn(this, 0);
                Slided = true;
            }
        }

        //Form slideout
        private async void SlideOut(Form4 o, int move)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            while (move > 0)
            {
                await Task.Delay(10);
                int a = move -= 29;
                Location = new Point(workingArea.Right - move, workingArea.Top);
            }
            move = 0;
        }
        //Form slidein
        private async void SlideIn(Form4 o, int move)
        {
            Slided = true;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            while (move < 835)
            {
                await Task.Delay(10);
                int a = move += 29;
                Location = new Point(workingArea.Right - move, workingArea.Top);
            }
            move = 835;
        }

        //Hotkey for sliding
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Toggle();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Toggle slide on clicking the icon
        private void notifyIcon_Click(object sender, EventArgs e)
        {
            Toggle();
        }
        */
    }
}
