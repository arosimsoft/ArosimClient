using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using ArosimClient.Classes;

namespace ArosimClient
{
    class Client
    {
        public static Client instance;

        public static int dataBufferSize = 4096;

        public int id;

        public string ip = "127.0.0.1";

        public int portConnection = 585;

        public int myId = 1;

        public TCP tcp;

        public UDP udp;


        private bool isConnected = false;

        public delegate void PacketHandler(Packet packet);

        public static Dictionary<int, PacketHandler> packetHandlers;

        public Client(int clientID)
        {
            id = clientID;
            ip = "127.0.0.1";
            portConnection = 585;

            tcp = new TCP(id);
            udp = new UDP(id, ip, portConnection);
            instance = this;
        }

        public Client(int clientID, string ipAddress, int portConn)
        {
            id = clientID;
            ip = ipAddress;
            portConnection = portConn;

            tcp = new TCP(id);
            udp = new UDP(id, ip, portConnection);
            instance = this;
        }

        public static Client GetInstance(int id, string ipAddress, int portConn)
        {
            if(instance == null)
            {
                instance = new Client(id, ipAddress, portConn);
            }
            return instance;
        }

        public void ConnectToServer()
        {
            InitializeClientData();

            tcp.Connect();

            isConnected = true; 

        }

        private void InitializeClientData()
        {
            packetHandlers = new Dictionary<int, PacketHandler>()
            {
                {(int)ServerPackets.welcome, ClientHandle.Welcome},
                {(int)ServerPackets.udpTest, ClientHandle.UDPTest},
                {(int)ServerPackets.AllCoordinates, ClientHandle.AllCoordinates }
            };
            Console.WriteLine("Initialized packages");
        }

        public void Disconnect()
        {
            if (isConnected)
            {
                isConnected = false;
                tcp.socket.Close();
                udp.socket.Close();

                Console.WriteLine("Disconnected from Server");

            }
        }
    }
}
