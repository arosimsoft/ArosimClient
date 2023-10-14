using ArosimClient.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ArosimClient
{
    class ClientHandle
    {
        public static void Welcome(Packet packet)
        {
            string msg = packet.ReadString();
            int myId = packet.ReadInt();

            Console.WriteLine($"Message from server: {msg}");
            Client.instance.myId = myId;
            ClientSend.WelcomeReceived();

            Client.instance.udp.Connect(((IPEndPoint)Client.instance.tcp.socket.Client.LocalEndPoint).Port);
        }

        public static void UDPTest(Packet packet)
        {
            string msg = packet.ReadString();

            Console.WriteLine($"Received packet via UDP. Contains message: {msg}");
            ClientSend.UDPTestReceived();
        }

        public static void AllCoordinates(Packet packet)
        {

            ClientManager.jointsList.Clear();

            string coords_string = packet.ReadString();

            string[] joints_coords = coords_string.Split(';');

            foreach(string joint_coords in joints_coords)
            {
                if(joint_coords != "")
                {
                    string[] data = joint_coords.Split(',');

                    Joint newJoint = new Joint();
                    newJoint.name = data[0];
                    newJoint.x = float.Parse(data[1]);
                    newJoint.y = float.Parse(data[2]);
                    newJoint.z = float.Parse(data[3]);

                    newJoint.angle_x = float.Parse(data[4]);
                    newJoint.angle_y = float.Parse(data[5]);
                    newJoint.angle_z = float.Parse(data[6]);

                    ClientManager.jointsList.Add(newJoint);
                }
            }

            // Console.WriteLine(ClientManager.jointsList[0].ToString());

            // Console.WriteLine($"Server send: {coords_string.Split(';')[0]}");
        }
    }
}
