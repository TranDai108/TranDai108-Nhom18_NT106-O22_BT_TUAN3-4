using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        // Create tcp listener and listen thread
        private TcpListener server;
        private Thread listen;
        public Server()
        {
            InitializeComponent();
        }
        private void UpdateTextThreadSafe(string text, RichTextBox control)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() =>
                {
                    UpdateTextThreadSafe(text, control);
                }));
            }
            else
            {
                control.AppendText("\r\n" + text);
                control.ScrollToCaret();
            }
        }

        public void serverListen()
        {
            // Create server by using IP endpoint
            IPAddress ipadd = IPAddress.Parse(tbIPServer.Text);
            int port = Convert.ToInt32(tbPort.Text);
            IPEndPoint ipend = new IPEndPoint(ipadd, port);
            server = new TcpListener(ipend);
            // Start the server
            server.Start();
            // Define listen thread
            listen = new Thread(() => {
                try
                {
                    while (true)
                    {
                        // Create client connect to server
                        TcpClient client = server.AcceptTcpClient();
                        // Get data from client
                        NetworkStream stream = client.GetStream();                       
                        // Create array to store encoded message
                        byte[] buffer = new byte[1024];
                        // Count bytes in stream
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        // Encode bytes array to get perfect message
                        string Data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        // Show message
                        UpdateTextThreadSafe(Data, rtbView);
                    }
                    // Handle when program catches exception
                }
                catch (SocketException)
                {

                }
            });
            // Start listen thread
            listen.Start();
        }

        private void serverClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the server
            server.Stop();
            // Stop listen thread
            if (listen.IsAlive) listen.Abort();
        }

        private void btListen_Click(object sender, EventArgs e)
        {
            serverListen();
        }
    }
}
