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

using System.Net.Http;
using System.Net.Sockets;
using Newtonsoft.Json; //you might have to install the pacckage via NuGet

namespace CN_Projekt
{
    public class Message
    {
        public string id;
        public string userID;
        public string text;
        public string date;
        public string replyTo;
        public string replies;
        public string color;
        public string reported;
        public string publicName;
    }

    public partial class Form1 : Form
    {
        static  HttpClient client;
        private delegate void DELEGATE(); //needed to update ui from another thread
        static string messages; 

        public Form1()
        {
            messages = "";
            InitializeComponent();

            client = new HttpClient();

            //textLocalIP.Text = GetLocalIP();
            //textLocalIP.ReadOnly = true;
            textFriendsIP.Text = "185.17.144.10";
            //textLocalPort.Text = "80";
            textFriendsPort.Text = "80";

            //refresh messages every second
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(refreshMessageBoard);
            timer.Interval = 1000;      
            timer.Enabled = true;
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }

            }

            return "127.0.0.1";

        }

        private async void ButtonSend_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, string>
            {
                { "text", textMessage.Text },
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://" + textFriendsIP.Text + ":" + textFriendsPort.Text + "/comment/saveComment", content);

            var responseString = await response.Content.ReadAsStringAsync();

            textMessage.Text = "";

        }

        private void refreshMessageBoard(object sender, EventArgs e)
        {
            //create delegate to update ui element, otherwise an exception is thrown since this is not the thread that created the ui element
            Delegate del = new DELEGATE(_refreshMessageBoard);
            this.Invoke(del);
        }

        private async void _refreshMessageBoard()
        {
            try
            {
                var responseString = await client.GetStringAsync("http://" + textFriendsIP.Text + ":" + textFriendsPort.Text + "/messageBoard/getMessages");

                if (responseString == messages)
                    return;
                messages = responseString;

                var list = JsonConvert.DeserializeObject<List<Message>>(responseString);
                listMessage.Items.Clear();
                foreach (var message in list)
                {
                    listMessage.Items.Add("Friend: " + message.text);
                }
            }
            catch(HttpRequestException e)
            {
                messages = e.Message;
                listMessage.Items.Clear();
                listMessage.Items.Add(e.Message);
            }
        }
    }
}
