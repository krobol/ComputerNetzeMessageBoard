﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Net;
using System.Net.Sockets;
namespace CN_Projekt
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;

        public Form1()
        {
            InitializeComponent();

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);


            textLocalIP.Text = GetLocalIP();
            textFriendsIP.Text = GetLocalIP();

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

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if(size > 0)
                {
                    byte[] receivedData = new byte[1464];

                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    listMessage.Items.Add("Friend: " + receivedMessage);

                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);


            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }


        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(textFriendsIP.Text), Convert.ToInt32(textFriendsPort.Text));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                ButtonStart.Text = "Connected";
                ButtonStart.Enabled = false;
                ButtonSend.Enabled = true;
                textMessage.Focus();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {

            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textMessage.Text);

                sck.Send(msg);

                listMessage.Items.Add("Me: " + textMessage.Text);
                textMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }


        }
    }
}
