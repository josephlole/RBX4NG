using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace RBX4NG
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bot_Tick(object sender, EventArgs e)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890_";
            Random rnd = new Random();
            StringBuilder b = new StringBuilder(4);
            for (int i = 0; i < 4; i++)
            {
                b.Append(chars[rnd.Next(chars.Length)]);
            }
            string result = b.ToString();
            WebClient client = new WebClient();
            string pager = client.DownloadString("https://www.roblox.com/UserCheck/DoesUsernameExist?username=" + result);
            if (pager.Contains("true"))
            {

            }
            else
            {
                listBox.Items.Add(result);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bot.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            bot.Stop();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
