using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArosimClient
{
    class ClientSend
    {
        private static void SendTCPData(Packet packet)
        {
            packet.WriteLength();
            Client.instance.tcp.SendData(packet);
        }

        #region Packets
        public static void WelcomeReceived()
        {
            Packet packet = new Packet((int)ClientPackets.welcomeReceived);
            packet.Write(Client.instance.myId);

            packet.Write("");

            SendTCPData(packet);
        }


        private static void SendUDPData(Packet packet)
        {
            packet.WriteLength();
            Client.instance.udp.SendData(packet);
        }

        internal static void UDPTestReceived()
        {
            using (Packet packet = new Packet((int)ClientPackets.updTestReceived))
            {
                packet.Write("Received a UDP packet.");

                SendUDPData(packet);
            }
        }

        public static void ClientControlCommand(string command)
        {
            Packet packet = new Packet((int)ClientPackets.ClientControlCommand);
            packet.Write(command);

            SendUDPData(packet);
        }
        #endregion
    }
}
