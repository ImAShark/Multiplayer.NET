using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text;

    class MainSockets
    {

        /*static void Main(String[] arguments)
        {
            //MainSockets("127.0.0.1", 13000, "127.0.0.1", 14000);
            TCPClient tcpClient = new TCPClient();
            UDPClient udpClient = new UDPClient();

            tcpClient.Connect("127.0.0.1", 13000);
            udpClient.Connect("127.0.0.1", 14000);
            while (true)
            {

            }
        }*/
        public MainSockets(String serverTCP , Int32 portTCP , String serverUDP, Int32 portUDP)
        {
            TCPClient tcpClient = new TCPClient(portTCP, serverTCP);
            UDPClient udpClient = new UDPClient();

            tcpClient.AttemptConnection();
            //udpClient.Connect(serverUDP, portUDP);
        }
    }
