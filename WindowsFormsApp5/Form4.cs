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
{   // Form 4: criminality tab within the application
    public partial class Form4 : Form
    {
        private bool Slided;
        private string selectedCrimeChartInfoType = "crimeratio";
        public string province = "Drenthe";

        public Form4()
        {
            InitializeComponent();
            mapUserControl1.Map.ZoomLevel = 7;
            mapUserControl1.Map.Center = new Location(52.191735, 3.0369282);
            mapUserControl1.Map.CredentialsProvider = new ApplicationIdCredentialsProvider("AhAI5K2EcnQZDcORVbCzo3ny5iDZSwySoZxalua_NmT-OhfDDoXgV3gW-2Atqp0k");

            SqlConnection connection;
            string connectionString;
            string commandText = "SELECT * From GeolocProv";

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["WindowsFormsApp5.Properties.Settings.Database1ConnectionString"].ConnectionString;
            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                connection.Open();


                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable ProvinGeo = new DataTable();
                    adapter.Fill(ProvinGeo);
                    foreach (DataRow row in ProvinGeo.Rows)
                    {
                        string prov = (string)row["Provin"];
                        float lat = float.Parse(row["lat"].ToString());
                        float lon = float.Parse(row["lon"].ToString());

                        Pushpin pins = new Pushpin();
                        pins.Name = "hallo";
                        pins.Content = prov;
                        pins.Location = new Location(lat, lon); 
                        pins.AddHandler(Pushpin.MouseDownEvent, new RoutedEventHandler(Onb2Click));
                        // Adds the pushpin to the map.
                        mapUserControl1.Map.Children.Add(pins);

                    }
                }
            }

            drawNewCrimeChart(2006);

            crimeRatio1.Checked = true;

            Slided = false;

        }
  
        private void drawNewCrimeChart(int year)
        {
            //Database connection
            SqlConnection connection;
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["WindowsFormsApp5.Properties.Settings.Database1ConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            //Open connection to run dat query
            connection.Open();

            //Query to get the population total, crime total per year per province
            string selectedPopYear = "b" + year;
            string selectedCrimeYear = "m" + year;
            SqlDataAdapter data = new SqlDataAdapter("(SELECT Province, " + selectedPopYear + ",b2005," + selectedCrimeYear + ",m2005 FROM Crime)", connection);

            //Query is done, close connection
            connection.Close();

            //Store query result in datatable for later use
            DataTable misdrijf = new DataTable();

            data.Fill(misdrijf);
            //Empty the crimechart
            chart1.Series[0].Points.Clear();
            //TODO: needs to be done in the desinger
            chart1.ChartAreas[0].AxisX.Interval = 1;
            //chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            //chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            //Loop through the data to calculate the crime ratio and show it in the crimechart
            foreach (DataRow row in misdrijf.Rows)
            {
        
                string provincie = row[0].ToString();
                int popIncrease = Convert.ToInt32(row[1]) - Convert.ToInt32(row[2]);
                int crimeIncrease = Convert.ToInt32(row[3]) - Convert.ToInt32(row[4]);
                int crimeRatio = (popIncrease / crimeIncrease);
             

                if (selectedCrimeChartInfoType == "pop")
                {
                    chart1.ChartAreas[0].AxisY.Maximum = 200000;
                    chart1.ChartAreas[0].AxisY.Minimum = -25000;
                    chart1.Series["Criminaliteit"].Points.AddXY(provincie, popIncrease);
                }
                else if (selectedCrimeChartInfoType == "crime")
                {
                    chart1.ChartAreas[0].AxisY.Maximum = 5000;
                    chart1.ChartAreas[0].AxisY.Minimum = -100000;
                    chart1.Series["Criminaliteit"].Points.AddXY(provincie, crimeIncrease);
                }
                else if (selectedCrimeChartInfoType == "crimeratio")
                {
                    chart1.ChartAreas[0].AxisY.Maximum = 14;
                    chart1.ChartAreas[0].AxisY.Minimum = -45;
                    chart1.Series["Criminaliteit"].Points.AddXY(provincie, crimeRatio);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int year = crimeTrackbar.Value;
            drawNewCrimeChart(year);
            getNewMapData(province);
            currentYear.Text = year.ToString();
        }
        //Set crimechart type to populution increase
        private void popIncrease_CheckedChanged(object sender, EventArgs e)
        {
            selectedCrimeChartInfoType = "pop";
            drawNewCrimeChart(crimeTrackbar.Value);
            getNewMapData(province);
            chartTypeExplain.Text = "Popululation change since 2005";
        }

        //Set crimechart  to crime increase
        private void crimeIncrease_CheckedChanged(object sender, EventArgs e)
        {
            selectedCrimeChartInfoType = "crime";
            drawNewCrimeChart(crimeTrackbar.Value);
            getNewMapData(province);
            chartTypeExplain.Text = "Crime change since 2005";
        }

        //Set crimechart type to ratio
        private void ratio_CheckedChanged(object sender, EventArgs e)
        {
            selectedCrimeChartInfoType = "crimeratio";
            drawNewCrimeChart(crimeTrackbar.Value);
            getNewMapData(province);
            chartTypeExplain.Text = "pop/crime ratio. The change of population total and crime total since 2005.";
        }

        public void Onb2Click(object sender, RoutedEventArgs e)
        {
            Pushpin p = e.Source as Pushpin;
            setProv(p);
            getNewMapData(province);
        }

        private void setProv(Pushpin p)
        {
            province = p.Content.ToString();
        }

        private void getNewMapData(string prov)
        {
            SqlConnection connection;
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["WindowsFormsApp5.Properties.Settings.Database1ConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            //Open connection to run dat query
            connection.Open();

            //Query to get the population total, crime total for the selected year and province
            string year = crimeTrackbar.Value.ToString();
            string selectedPopYear = "b" + year;
            string selectedCrimeYear = "m" + year;
            string selectedProvince = province;
            SqlDataAdapter data = new SqlDataAdapter("(SELECT province, " + selectedPopYear + ", " + selectedCrimeYear + ", b2005, m2005  FROM Crime WHERE province = '" + selectedProvince + "')", connection);

            //Query is done, close connection
            connection.Close();

            //Store query result in datatable for later use
            DataTable misdrijf = new DataTable();

            data.Fill(misdrijf);
            foreach (DataRow row in misdrijf.Rows)
            { //row[0].ToString() + row[1].ToString() + row[2].ToString() + row[3].ToString() + row[4].ToString();

                string provincie = row[0].ToString();
                int pop = Convert.ToInt32(row[1]);
                int crime = Convert.ToInt32(row[2]);
                int popIncreaseDiff = Convert.ToInt32(row[1]) - Convert.ToInt32(row[3]);
                int crimeIncreaseDiff = Convert.ToInt32(row[2]) - Convert.ToInt32(row[4]);
                int crimeRatioDiff = (popIncreaseDiff / crimeIncreaseDiff);

                mapText.Text = "Provincie: " + provincie + "\r\npopulatie in " + year + ": " + pop + "\r\nCriminaliteit in " + year + ": " + crime + "\r\nVerandering populatie sinds 2005: " + popIncreaseDiff + "\r\nVerandering criminaliteit sinds 2005: " + crimeIncreaseDiff + "";
            }
        }
        //
        //                       
        //einde van vraagje crime
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




           
                
              

    