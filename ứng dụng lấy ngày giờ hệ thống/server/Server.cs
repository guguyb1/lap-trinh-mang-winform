using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO.Pipes;

namespace server
{
    public partial class Server : Form
    {
        private TcpListener listener;
        private List<TcpClient> clients;
        private TcpClient client;
        private Thread receiveThread;
        public Server()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(btnStart.Checked == true)
            {
                btnStart.Text = "Dừng";
                connect();
                thongBao.Text += "khởi tạo server thành công đang lắng nghe các client kết nối!" + "\n";
            } else
            {
                btnStart.Text = "bắt đầu";
                listener.Stop();
            }
        }

        void connect()
        {
            listener = new TcpListener(IPAddress.Any, 8888);
            clients = new List<TcpClient>();
            List<string> nameClientList = new List<string>();
            listener.Start();

            Thread Listen = new Thread(() => {
                try
                {
                    while (true)
                    {

                        TcpClient client = listener.AcceptTcpClient();
                        clients.Add(client);
                        Thread receiveThread = new Thread(() => Receive(client));
                        receiveThread.IsBackground = true;
                        receiveThread.Start();
                    }
                }
                catch
                {
                    listener = new TcpListener(IPAddress.Any, 8888);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        void Receive(object obj)
        {
           
            TcpClient client = obj as TcpClient;
            string nameClient = client.Client.RemoteEndPoint.ToString();
            Invoke(new Action(() => {
                thongBao.Text += nameClient + ": đã kết nối \n";
                lbCountConnections.Text = "client kết nối: " + clients.Count.ToString();
                loadComboboxClients();
            }));
            try
            {
                while (true)
                {
                    NetworkStream stream = client.GetStream();
                    byte[] data = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = stream.Read(data, 0, data.Length)) > 0)
                    {
                        string message = Encoding.Unicode.GetString(data, 0, bytesRead);
                        if(message == "layNgayGio")
                        {


                            DateTime dateTime = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "yyyy-MM-dd HH:mm:ss", null);


                            send(client, dateTime.ToString());
                            Invoke(new Action(() => {
                                thongBao.Text += "Gửi thành công ngày giờ đến:" + nameClient + "\n";
                            }));
                        }
                        else
                        {
                            send(client, "không có lệnh này!");
                        }
                        Invoke(new Action(() => { thongBao.Text += nameClient +":"+ message + "\n"; }));
                    }
                    // client đóng kết nối
                    if (client.Client.Poll(0, SelectMode.SelectRead) && client.Client.Available == 0)
                    {
                        clients.Remove(client);
                        Invoke(new Action(() => { 
                            thongBao.Text += nameClient + ": đã ngắt kết nối \n"; 
                            lbCountConnections.Text = "client kết nối: " + clients.Count.ToString();
                            loadComboboxClients();
                        }));
                        break;
                    }
                }
            }
            catch
            {
                clients.Remove(client);
                client.Close();
            }
        }

        void loadComboboxClients()
        {   List<string> nameClients = new List<string>();
            foreach (var client in clients)
            {
                nameClients.Add(client.Client.RemoteEndPoint.ToString());
            }
            cbListClients.DataSource = nameClients;
        }


        void send(object obj, string message)
        {
            TcpClient client = obj as TcpClient;
            string nameClient = client.Client.RemoteEndPoint.ToString();
            try
            {
                byte[] data = Encoding.Unicode.GetBytes(message);
                if (client == null)
                {
                    MessageBox.Show("không có client nào đang kết nối");
                    return;
                }
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string nameClient = cbListClients.SelectedValue as string;
                if(nameClient == null || clients == null)
                {
                    MessageBox.Show("không có client nào đang kết nối");
                    return;
                }
                foreach (var client in clients)
                {
                    if(client.Client.RemoteEndPoint.ToString() == nameClient)
                    {
                        DateTime dateTime = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "yyyy-MM-dd HH:mm:ss", null);
                        send(client, dateTime.ToString());
                        Invoke(new Action(() => {
                            thongBao.Text += "Gửi thành công ngày giờ đến:" + nameClient + "\n";
                        }));
                    }
                }



                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
