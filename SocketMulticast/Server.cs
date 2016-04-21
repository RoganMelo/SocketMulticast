using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketMulticast
{
    public class Server
    {
        private ServerForm serverForm;
        private const int port = 11000;
        private UdpClient client;
        private static IPAddress multicastAddress;
        private IPEndPoint ipEndPoint;
        private byte[] bytes;

        public Server(ServerForm serverForm)
        {
            this.serverForm = serverForm;
            client = new UdpClient(port);
            multicastAddress = IPAddress.Parse("239.0.0.222");
            ipEndPoint = new IPEndPoint(multicastAddress, 2222);

            client.JoinMulticastGroup(multicastAddress);
        }

        public void Start()
        {
            serverForm.SetMessage("Server started...");
        }

        public void Stop()
        {
            serverForm.SetMessage("Server stoped...");
            client.Close();
        }

        public void SendMessage(string message)
        {
            serverForm.SetMessage("Sending message...");

            bytes = Encoding.Unicode.GetBytes(message);
            client.Send(bytes, bytes.Length, ipEndPoint);
        }
    }
}
