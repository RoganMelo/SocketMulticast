using System.Windows.Forms;

namespace SocketMulticast
{
    public partial class ClientForm : Form
    {
        private Client client;

        public ClientForm()
        {
            client = new Client(this);
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, System.EventArgs e)
        {
            BtnConnect.Enabled = false;
            BtnDisconnect.Enabled = true;

            client.Connect();
        }

        private void BtnDisconnect_Click(object sender, System.EventArgs e)
        {
            BtnConnect.Enabled = true;
            BtnDisconnect.Enabled = false;

            client.Disconnect();
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
                ListBoxClientInformations.Items.Add(message);
            }
        }
    }
}
