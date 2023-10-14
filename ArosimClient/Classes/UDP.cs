using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ArosimClient.Classes
{
    class UDP
    {
        private int id;

        public UdpClient socket;
        public IPEndPoint endPoint;

        public UDP(int clientId, string ip , int port)
        {
            id = clientId;
            endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
        }

        public void Connect(int _localPort)
        {
            socket = new UdpClient(_localPort);

            socket.Connect(endPoint);
            socket.BeginReceive(ReceiveCallback, null);

            using (Packet _packet = new Packet())
            {
                SendData(_packet);
            }
        }

        public void SendData(Packet _packet)
        {
            try
            {
                _packet.InsertInt(id);
                if (socket != null)
                {
                    socket.BeginSend(_packet.ToArray(), _packet.Length(), null, null);
                }
            }
            catch (Exception _ex)
            {
                Console.WriteLine($"Error sending data to server via UDP: {_ex}");
            }
        }

        private void ReceiveCallback(IAsyncResult _result)
        {
            try
            {
                byte[] _data = socket.EndReceive(_result, ref endPoint);
                socket.BeginReceive(ReceiveCallback, null);

                if (_data.Length < 4)
                {
                    // TODO: disconnect -> Posible error
                    Client.instance.Disconnect();
                    return;
                }

                HandleData(_data);
            }
            catch
            {
                // TODO: disconnect
                Disconnect();
            }
        }

        private void HandleData(byte[] _data)
        {
            using (Packet _packet = new Packet(_data))
            {
                int _packetLength = _packet.ReadInt();
                _data = _packet.ReadBytes(_packetLength);
            }

            ThreadManager.ExecuteOnMainThread(() =>
            {
                using (Packet _packet = new Packet(_data))
                {
                    int _packetId = _packet.ReadInt();
                    Client.packetHandlers[_packetId](_packet);
                }
            });
        }

        public void Disconnect()
        {
            Client.instance.Disconnect();

            endPoint = null;
            socket = null;
        }
    }
}
