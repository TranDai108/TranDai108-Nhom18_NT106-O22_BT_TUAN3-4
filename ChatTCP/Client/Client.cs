using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        private Socket socket;

        
        public Client()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipadd = IPAddress.Parse(tbIPHost.Text);
            int port = Convert.ToInt32(tbPort.Text);
            IPEndPoint ipend = new IPEndPoint(ipadd, port);

            try
            {
                socket.Connect(ipend); // Kết nối đến máy chủ
                Byte[] sendBytes = Encoding.UTF8.GetBytes(tbName.Text + " : " + rtbMessage.Text);
                socket.Send(sendBytes); // Gửi dữ liệu đã mã hóa đến máy chủ
                rtbMessage.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối đến máy chủ: " + ex.Message);
            }

        }
    }
}
