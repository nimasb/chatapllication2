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

namespace nimaGap
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        SimpleTcpServer Server;
        //datas.DB db;
        private void home_Load(object sender, EventArgs e)
        {
            //db=new datas.DB();

            //ip_txt.Text = db.newsetting_tbl.FirstOrDefault().settings_port;
            Server = new SimpleTcpServer(ip_txt.Text);
            start_btn.Enabled = true;
            Server.Events.ClientConnected += Events_ClientConnected;
            Server.Events.ClientDisconnected += Events_ClientDisconnected;
            Server.Events.DataReceived += Events_DataReceived;
        }

        List<datas.user_tbl> userlist=new List<datas.user_tbl>();

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            string Data=Encoding.UTF8.GetString(e.Data);
            if (Data.Substring(0, 2) == "##")
            {
                datas.user_tbl newuser=new datas.user_tbl();
                newuser.userport = e.IpPort;
                newuser.username= Data.Substring(2);
                userlist.Add(newuser);
                status_txt.Text = newuser.userport + " : " + newuser.username+" connected"+Environment.NewLine;
            }else if(Data.Substring(0,2) == "++")
            {
                int count = 1;
                foreach (var item in Data.Substring(2))
                {
                    if (item == '#')
                    {
                        break;
                    }
                    count++;
                }
                string usersend=Data.Substring(2,count-1);
                status_txt.Text +=usersend+Environment.NewLine;
                var qUser = userlist.Where(p => p.username == usersend).FirstOrDefault();
                if (qUser != null)
                {
                    Server.Send(qUser.userport, Data.Substring(count + 2));
                }
            }
        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            status_txt.Text += e.IpPort + " : " + "Disconnected" + Environment.NewLine;
            userlist_lst.Items.Remove(e.IpPort);
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            status_txt.Text += e.IpPort + ":" + "connected" + Environment.NewLine;
            userlist_lst.Items.Add(e.IpPort);
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Server.Start();
            status_txt.Enabled = true;
            data_txt.Enabled = true;
            send_btn.Enabled = true;
            userlist_lst.Enabled = true;
            status_txt.Text += "server enabled" + Environment.NewLine;

        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            if (Server.IsListening)
            {
                if (!string.IsNullOrEmpty(data_txt.Text)) { 
                Server.Send(userlist_lst.SelectedItem.ToString(), data_txt.Text);
                status_txt.Text += "server : "+data_txt.Text+Environment.NewLine;
                data_txt.Text = string.Empty;
                }
            }
        }
    }
}
