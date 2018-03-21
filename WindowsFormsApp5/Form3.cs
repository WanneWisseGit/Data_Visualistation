using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        string provincie = "";

        public Form3(string prov)
        {
            InitializeComponent();

            provincie = prov;
        }
        
        void button1_Click(object sender, EventArgs e)
        {
            Form2 popup = new Form2(provincie);
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }
        void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hello");
            Form4 popup = new Form4();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }
        void button3_Click(object sender, EventArgs e)
        {

        }
        
    }
}
