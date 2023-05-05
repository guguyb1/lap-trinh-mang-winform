using ChatServer;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class Session
{
    public ChatForm form;
    public int _port = 1308;
    private IPEndPoint _remoteEP;
    public UdpClient _server;
    public bool closed;

    public Session(ChatForm form)
    {
        this.form = form;
    }

    public void Open()
    {
        _server = new UdpClient(_port);
        Thread t = new Thread(() =>
        {
            while (!closed)
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
        _server.Send(_buffer, _buffer.Length, _remoteEP);
    }



    public void ReceiveMessage()
    {
        var _buffer = _server.Receive(ref _remoteEP);
        var _response = Encoding.UTF8.GetString(_buffer);
        form.AddMessage("Client", _response);
    }
}

