using System;
using System.Threading;
using System.Windows.Forms;

namespace SocketMulticast
{
    public partial class ServerForm : Form
    {
        private Server server;

        public ServerForm()
        {
            server = new Server(this);
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(() => new ClientForm().ShowDialog())).Start();
            new Thread(new ThreadStart(() => new ClientForm().ShowDialog())).Start();
            new Thread(new ThreadStart(() => new ClientForm().ShowDialog())).Start();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            BtnStart.Enabled = false;
            BtnStop.Enabled = true;
            TextBoxMessage.Enabled = true;
            BtnSendMessage.Enabled = true;

            server.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            BtnStart.Enabled = true;
            BtnStop.Enabled = false;
            TextBoxMessage.Enabled = false;
            BtnSendMessage.Enabled = false;

            server.Stop();
        }

        private void BtnSendMessage_Click(object sender, EventArgs e)
        {
            server.SendMessage(TextBoxMessage.Text);
        }

        delegate void SetMessageCallback(string message);
        public void SetMessage(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new SetMessageCallback(SetMessage), message);
            }
            else
            {
                ListBoxServerInformations.Items.Add(message);
            }
        }
    }
}
