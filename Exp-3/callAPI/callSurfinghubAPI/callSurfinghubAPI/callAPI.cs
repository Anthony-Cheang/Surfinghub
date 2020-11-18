using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using callSurfinghubAPI.SurfhubAPI;

namespace callSurfinghubAPI
{
    public partial class callAPI : Form
    {
        public callAPI()
        {
            InitializeComponent();
        }

        private void getFriendsBtn_Click(object sender, EventArgs e)
        {
            WebService1SoapClient client = new WebService1SoapClient();
            string name = inputNameBox.Text;
            outputBox.Text = client.GetFriends(name);
        }

        private void editSignBtn_Click(object sender, EventArgs e)
        {
            WebService1SoapClient client = new WebService1SoapClient();
            string name = inputNameBox.Text;
            string sign = inputSignBox.Text;
            outputBox.Text = "新个性签名\r\n" + "----------------------------------------\r\n" +
                             client.GetSigns(name)+ "\r\n\r\n\r\n" +
                             "修改反馈\r\n" + "----------------------------------------\r\n" + 
                             client.Updatesigns(name, sign);
        }

        private void getSignBtn_Click(object sender, EventArgs e)
        {
            WebService1SoapClient client = new WebService1SoapClient();
            string name = inputNameBox.Text;
            outputBox.Text = client.GetSigns(name);
        }
    }
}
