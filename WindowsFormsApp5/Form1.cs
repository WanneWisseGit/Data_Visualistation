using MaterialSkin.Controls;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
//henk
//henk2
namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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



            mapUserControl1.Map.ZoomLevel = 7;
            mapUserControl1.Map.Center = new Location(52.191735, 3.0369282);
            mapUserControl1.Map.CredentialsProvider = new ApplicationIdCredentialsProvider("AhAI5K2EcnQZDcORVbCzo3ny5iDZSwySoZxalua_NmT-OhfDDoXgV3gW-2Atqp0k");

        }
            /* MapPolyline polyline = new MapPolyline();
             polyline.Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Blue);
             polyline.StrokeThickness = 100;
             polyline.Opacity = 10;
             polyline.Locations = new LocationCollection() {
                  new Location(51.9278891,4.3503300),
                  new Location(51.9278891,4.3503100),
                  new Location(51.9278891,4.35032)
             };
              mapUserControl1.Map.Children.Add(polyline);
             */

            void Onb2Click(object sender, RoutedEventArgs e) {
            Pushpin p = e.Source as Pushpin;
            Form2 popup = new Form2(p.Content.ToString());
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            }

    }
}
 

