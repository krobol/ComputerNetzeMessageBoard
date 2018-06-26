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
namespace CN_Projekt
{
    public partial class Form1 : Form
    {
        EndPoint epLocal, epRemote;
        static  HttpClient client;

        public Form1()
        {
            InitializeComponent();

            client = new HttpClient();


            textLocalIP.Text = GetLocalIP();
            textLocalIP.ReadOnly = true;
            textFriendsIP.Text = "185.17.144.10";
            textLocalPort.Text = "80";
            textFriendsPort.Text = "8080";

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

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            Task<string> task = saveMessageAsync(textMessage.Text);
            System.Diagnostics.Debug.WriteLine(task.Result);
        }


        private async Task<string> saveMessageAsync(string message)
        {
            var values = new Dictionary<string, string>
            {
                { "text", message },
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://" + textFriendsIP.Text + "/comment/saveComment", content);

            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }
    }
}
