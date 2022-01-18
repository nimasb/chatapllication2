using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTcp;

namespace nimaGap_client
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        SimpleTcpClient Client;
        private void home_Load(object sender, EventArgs e)
        {
            Client = new SimpleTcpClient(connect_txt.Text);
            Client.Events.Connected += Events_Connected;
            Client.Events.Disconnected += Events_Disconnected;
            Client.Events.DataReceived += Events_DataReceived;
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            gap_txt.Text += "disconnected";
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            gap_txt.Text += Encoding.UTF8.GetString(e.Data) + Environment.NewLine;
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            gap_txt.Text += "connected"+Environment.NewLine;
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (username_txt.Text != String.Empty)
                {
                    Client.Connect();
                    Client.Send("##"+username_txt.Text);
                    gap_txt.Enabled = true;
                    message_txt.Enabled = true;
                    send_btn.Enabled = true;
                    contact_txt.Enabled = true;
                    connect_btn.Enabled = false;
                    connect_txt.Enabled = false;
                    username_txt.Enabled = false;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            if (Client.IsConnected)
            {
                if (!String.IsNullOrEmpty(message_txt.Text)) { 
                Client.Send("++"+contact_txt.Text+"#"+message_txt.Text);
                gap_txt.Text +="Me : "+ message_txt.Text + Environment.NewLine;
                message_txt.Text = String.Empty;
                }
            }
        }
    }
}
