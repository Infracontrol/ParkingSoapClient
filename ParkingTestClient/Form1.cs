using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ParkingTestClient
{
    public partial class TestClientForm : Form
    {
        public TestClientForm()
        {
            InitializeComponent();
        }

        private void buttonListSites_Click(object sender, EventArgs e)
        {
            using (var client = new ParkingInfoService.ParkingInfoSoapClient("ParkingInfoSoap", textBoxUrl.Text))
            {
                try
                {
                    var sites = client.ListSites(textBoxUsername.Text, textBoxPassword.Text);
                    textBoxResponse.Text = string.Join(Environment.NewLine, sites.Select(s => $"{s.Name}: {s.Occupancy}, Active: {s.Active}"));
                }
                catch (Exception ex)
                {
                    textBoxResponse.Text = ex.Message;
                }
            }
        }

        private void buttonListSigns_Click(object sender, EventArgs e)
        {
            using (var client = new ParkingInfoService.ParkingInfoSoapClient("ParkingInfoSoap", textBoxUrl.Text))
            {
                try
                {
                    var signs = client.ListSigns(textBoxUsername.Text, textBoxPassword.Text);
                    textBoxResponse.Text = string.Join(Environment.NewLine, signs.Select(s => $"{s.Name}: {s.CurrentMessage}"));
                }
                catch (Exception ex)
                {
                    textBoxResponse.Text = ex.Message;
                }
            }
        }
    }
}
