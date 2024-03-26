using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace Client
{
    public partial class Client : Form
    {
        private Socket socket;
        private delegate void SafeCallDelegate(string text, Control obj);
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
                Byte[] sendBytes = Encoding.UTF8.GetBytes(tbName.Text + " : " + tbMessage.Text);
                socket.Send(sendBytes); // Gửi dữ liệu đã mã hóa đến máy chủ
                tbMessage.Text = "";
                Task.Run(() => ReceiveData());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối đến máy chủ: " + ex.Message);
            }
        }

        private void ReceiveData()
        {
            try
            {
                while (true)
                {
                    byte[] receivedBytes = new byte[1024];
                    int byteCount = socket.Receive(receivedBytes);
                    if (byteCount > 0)
                    {
                        string receivedText = Encoding.UTF8.GetString(receivedBytes, 0, byteCount);
                        DisplayReceivedData(receivedText);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhận dữ liệu từ máy chủ: " + ex.Message);
            }
        }

        private void DisplayReceivedData(string data)
        {
            // Đảm bảo rằng việc cập nhật giao diện người dùng xảy ra từ luồng giao diện người dùng chính
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate {
                    rtbMessage.AppendText(data + Environment.NewLine);
                });
            }
            else
            {
                rtbMessage.AppendText(data + Environment.NewLine);
            }
        }

    }
}
