using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form1 : Form
    {
        private const string URL = "http://www.google.com/ig/api?weather=";

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text;
            string getWeather = URL + location;
            System.Xml.Serialization ser = 
                new System.Xml.Serialization.XmlSerializer(typeof(xml_api


        }
    }
}
