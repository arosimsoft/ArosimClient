using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ArosimClient.Classes
{
    public class TCP
    {
        public TcpClient socket;

        private readonly int id;
        private NetworkStream stream;
        private byte[] receiveBuffer;
        private Packet receivedData;

        public TCP(int tcpId)
        {
            id = tcpId;
        }

        public void Connect()
        {
            socket = new TcpClient
            {
                ReceiveBufferSize = Client.dataBufferSize,
                SendBufferSize = Client.dataBufferSize
            };

            receiveBuffer = new byte[Client.dataBufferSize];
            socket.BeginConnect(Client.instance.ip, Client.instance.portConnection, ConnectCallback, socket);
        }

        private void ConnectCallback(IAsyncResult result)
        {
            socket.EndConnect(result);
            if (!socket.Connected)
            {
                return;
            }

            stream = socket.GetStream();

            receivedData = new Packet();

            stream.BeginRead(receiveBuffer, 0, Client.dataBufferSize, ReceiveCallback, null);
        }

        public void SendData(Packet packet)
        {
            try
            {
                if (socket != null)
                {
                    stream.BeginWrite(packet.ToArray(), 0, packet.Length(), null, null);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending data to server via TCP: {ex}");
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                int byteLength = stream.EndRead(ar);
                if (byteLength <= 0)
                {
                    // Disconnect
                    Client.instance.Disconnect();
                    return;
                }

                byte[] data = new byte[byteLength];
                Array.Copy(receiveBuffer, data, byteLength);

                // Handle data
                receivedData.Reset(HandleData(data));
                stream.BeginRead(receiveBuffer, 0, Client.dataBufferSize, ReceiveCallback, null);
            }
            catch
            {
                // Disconnect
                Disconnect();
            }

        }

        private bool HandleData(byte[] data)
        {
            int packetLength = 0;

            receivedData.SetBytes(data);

            if (receivedData.UnreadLength() >= 4)
            {
                packetLength = receivedData.ReadInt();
                if (packetLength <= 0)
                {
                    return true;
                }
            }

            while (packetLength > 0 && packetLength <= receivedData.UnreadLength())
            {
                byte[] packetBytes = receivedData.ReadBytes(packetLength);
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    using (Packet packet = new Packet(packetBytes))
                    {
                        int packetId = packet.ReadInt();
                        Client.packetHandlers[packetId](packet);

                    }
                });

                packetLength = 0;
                if (receivedData.UnreadLength() >= 4)
                {
                    packetLength = receivedData.ReadInt();
                    if (packetLength <= 0)
                    {
                        return true;
                    }
                }
            }

            if (packetLength <= 1)
            {
                return true;
            }

            return false;
        }

        private void Disconnect()
        {
            Client.instance.Disconnect();

            stream = null;
            receivedData = null;
            receiveBuffer = null;
            socket = null;
        }

    }
}
