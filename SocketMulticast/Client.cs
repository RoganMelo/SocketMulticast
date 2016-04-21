using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SocketMulticast
{
    public class Client
    {
        private ClientForm clientForm;
        private UdpClient client;
        private IPAddress multicastAddress;
        private IPEndPoint ipEndPoint;
        private byte[] bytes;

        public Client(ClientForm clientForm)
        {
            this.clientForm = clientForm;
            client = new UdpClient();
            multicastAddress = IPAddress.Parse("239.0.0.222");
            ipEndPoint = new IPEndPoint(IPAddress.Any, 2222);

            client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            client.ExclusiveAddressUse = false;
            client.Client.Bind(ipEndPoint);

            client.JoinMulticastGroup(multicastAddress);
        }

        public void Connect()
        {
            new Thread(new ThreadStart(() => {
                clientForm.SetMessage("Connected...");

                try
                {
                    while (true)
                    {
                        bytes = client.Receive(ref ipEndPoint);
                        string message = Encoding.Unicode.GetString(bytes);

                        clientForm.SetMessage(message);
                    }                    
                }
                catch (SocketException)
                {
                    clientForm.SetMessage("Server is offline...");
                }
                catch (ObjectDisposedException)
                {
                    clientForm.SetMessage("Server is offline...");
                }

            })).Start();
        }

        public void Disconnect()
        {
            clientForm.SetMessage("Disconnected...");
            client.Close();
        }
    }
}
