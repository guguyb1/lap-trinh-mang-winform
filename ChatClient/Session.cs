using System.Net;
using System;
using System.Net.Sockets;
using System.Text;
using ChatClient;
using System.Threading;

public class Session
{
    public ChatForm form;
    public int _port = 1308;
    public string _host = "127.0.0.1";
    public UdpClient _client;
    private IPEndPoint _remoteEP;
    public bool closed;

    public Session(ChatForm form)
    {
        this.form = form;
    }

    public void Connect()
    {
        _client = new UdpClient();
        _client.Connect(_host, _port);
        Thread t = new Thread(() =>
        {
            while(!closed)
            {
                ReceiveMessage();
            }
        });
        t.Start();
        t.Join();
    }

    public bool IsConnected()
    {
        return _remoteEP != null;
    }

    public void SendMessage(string message)
    {
        var _buffer = Encoding.UTF8.GetBytes(message);
        _client.Send(_buffer, _buffer.Length);
    }

    public void ReceiveMessage()
    {
        var _buffer = _client.Receive(ref _remoteEP);
        var _response = Encoding.UTF8.GetString(_buffer);
        form.AddMessage("Server", _response);
    }
}
