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

namespace client
{
    public partial class Client : Form
    {
        public TcpClient client;
        public Thread receiveThread;
        public Client()
        {
            InitializeComponent();
        }
        private void ReceiveData()
        {
            while (true)
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    byte[] data = new byte[1024];
                    int bytes = stream.Read(data, 0, data.Length);
                    string message = Encoding.Unicode.GetString(data, 0, bytes);
                    Invoke(new Action(() => { thongBao.Text += "server:" + message + "\n"; }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
            }
        }

        public bool Connect(string ipAddress, int port)
        {
            client = new TcpClient();
            try
            {
                
                // Kết nối đến server
                client.Connect(ipAddress, port);

                // Nếu kết nối thành công thì trả về true
                return true;
            }
            catch (SocketException)
            {
                // Xử lý lỗi kết nối
                return false;
            }
        }



    private void btnStart_Click_1(object sender, EventArgs e)
        {
          
            if (btnStart.Checked == true)
            {
                btnStart.Text = "Dừng";
                if (Connect("127.0.0.1", 8888))
                {
                    thongBao.Text += "kết nói với server thành công \n";
                    receiveThread = new Thread(new ThreadStart(ReceiveData));
                    receiveThread.IsBackground = true;
                    receiveThread.Start();
                }
                else
                {
                    thongBao.Text += "kết nối với server không thành công \n";
                    btnStart.Checked = false;
                    btnStart.Text = "Bắt đầu";
                    return;
                }
            }
            else
            {
                btnStart.Text = "bắt đầu";
                receiveThread.Abort();
                client.Close();
                client.Dispose();
                client = null;
            }
        }




        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                string message = inputText.Text;
               
                byte[] data = Encoding.Unicode.GetBytes(message);
                if (client == null || client.Connected == false)
                {
                    MessageBox.Show("vui lòng kết nối với server!");
                    return;
                }
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                thongBao.Text += "me:" + message + "\n";
                inputText.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(client != null)
            {
                client.Close();
            }
           
        }
    }
}
