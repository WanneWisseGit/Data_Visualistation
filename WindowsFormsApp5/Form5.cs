using MaterialSkin.Controls;
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
{   // The main application page + menu where you switch between the tabs
    public partial class Form5 : MaterialForm
    {
        public Form5()
        {
            InitializeComponent();
            //tab 3
            
            Form1 Form1 = new Form1();
            Form4 Form4 = new Form4();
            Form6 Form6 = new Form6();

            Form1.TopLevel = false;
            Form1.Visible = true;
            Form4.TopLevel = false;
            Form4.Visible = true;
            Form6.TopLevel = false;
            Form6.Visible = true;

            tabPage3.Controls.Add(Form6);
            tabPage2.Controls.Add(Form1);
            tabPage1.Controls.Add(Form4);



        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            //creating the reference of Form1.

        }
    }
}
