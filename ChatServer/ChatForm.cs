namespace ChatServer
{
    public partial class ChatForm : Form
    {
        Session session;
        public ChatForm()
        {
            InitializeComponent();
            session = new Session(this);
            session.Open();
        }

        public void AddMessage(string name, string response)
        {
            if (session.IsConnected())
            {
                panelSendMessage.Enabled = true;
            }
            showMessage.AppendText(string.Format("{0}: {1}", name, response));
            showMessage.AppendText(Environment.NewLine);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            txtMessage.Text = string.Empty;
            AddMessage("You", message);
            session.SendMessage(message);
        }

        public void Close(object sender, FormClosedEventArgs e)
        {
            session.closed = true;
            Application.Exit();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
