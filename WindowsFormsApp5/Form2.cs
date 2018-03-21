using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Web.Script.Serialization;
using Microsoft.Maps.MapControl.WPF;
using System.Windows;
using System.Globalization;
using System.Windows.Media;
using MaterialSkin.Controls;

namespace WindowsFormsApp5
{
    public partial class Form2 : MaterialForm
    {


        public Form2(string plaats)
        {

            InitializeComponent();
            string url = @"https://maps.googleapis.com/maps/api/place/textsearch/json?query=natuur+parken+in+" + plaats + "&key=AIzaSyBcQRoZeMCFZwcr-nJKpWTy_TVaSHAay9s";
            var json = new WebClient().DownloadString(url);




            var ds = new JavaScriptSerializer();

            var JSONObj = ds.Deserialize<dynamic>(json);

            if (JSONObj["results"][0]["photos"][0]["photo_reference"] != null)
            {
                var hi = (JSONObj["results"][0]["photos"][0]["photo_reference"]);
                var request = WebRequest.Create("https://maps.googleapis.com/maps/api/place/photo?maxwidth=400&photoreference=" + hi + "&key=AIzaSyBcQRoZeMCFZwcr-nJKpWTy_TVaSHAay9s");
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBox1.Image = Bitmap.FromStream(stream);
                }
            }
            else
            {
                pictureBox1.Image = null;
            }

          


            foreach (var r in JSONObj["results"]) {
                decimal lat = (r["geometry"]["location"]["lat"]);
                decimal len = (r["geometry"]["location"]["lng"]);
                Console.WriteLine(lat);
                double latd = (double)lat;
                double lend = (double)len;
                Pushpin pins = new Pushpin()
                {
                    Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 255, 0))
                };
                pins.Name = "hallo";
                pins.Location = new Location(latd, lend);
                // Adds the pushpin to the map.
                mapUserControl1.Map.Children.Add(pins);
            } 
           
           



            label1.Text = (JSONObj["results"][0]["formatted_address"] + "\n" + JSONObj["results"][1]["formatted_address"] + "\n" + JSONObj["results"][2]["formatted_address"]);

            SqlConnection connection;
            Console.WriteLine(plaats);
            string connectionString;
            string commandText = "SELECT * From GEMEENTE WHERE Gemeente =@plaats";
            

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["WindowsFormsApp5.Properties.Settings.Database1ConnectionString"].ConnectionString;
            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@plaats", plaats);
                //command.Parameters.Add("@plaats", SqlDbType.VarChar);
                //command.Parameters["@plaats"].Value = plaats;
                connection.Open();


                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    Console.WriteLine(adapter.ToString());
                    DataTable GEMEENTE = new DataTable();
                    adapter.Fill(GEMEENTE);


                    


                    foreach (DataRow row in GEMEENTE.Rows)
                    {
                        Console.WriteLine("Hallo");
                        this.chart1.Series["Groen1"].Points.AddXY("2010", row["J2010"].ToString());
                        this.chart1.Series["Groen1"].Points.AddXY("2011", row["J2011"].ToString());
                        this.chart1.Series["Groen1"].Points.AddXY("2012", row["J2012"].ToString());
                        this.chart1.Series["Groen1"].Points.AddXY("2013", row["J2013"].ToString());
                        this.chart1.Series["Groen1"].Points.AddXY("2014", row["J2014"].ToString());
                        this.chart1.Series["Groen1"].Points.AddXY("2015", row["J2015"].ToString());
                        this.chart1.Series["Groen1"].Points.AddXY("2016", row["J2017"].ToString());





                    }

                }


            }
            mapUserControl1.Map.ZoomLevel = 7;
            mapUserControl1.Map.Center = new Location(52.191735, 3.0369282);
            mapUserControl1.Map.CredentialsProvider = new ApplicationIdCredentialsProvider("AhAI5K2EcnQZDcORVbCzo3ny5iDZSwySoZxalua_NmT-OhfDDoXgV3gW-2Atqp0k");



        }
    }
}

