using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstWCFService_088;

namespace ServerConfigForm_P5_20190140088
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
            Host.Close();
            labelKet.Text = "Klik ON untuk Menjalankan Server";
            labelOnOrOff.Text = "Server OFF";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ON_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));
            labelOnOrOff.Text = "Server ON";
            labelKet.Text = "Klik OFF untuk Mematikkan Server";
            Host.Open();
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
