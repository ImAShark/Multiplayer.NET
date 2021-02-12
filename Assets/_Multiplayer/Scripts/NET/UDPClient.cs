using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text;


    class UDPClient
    {
       static UdpClient _client;
        static NetworkStream _stream;
        //static string clientID = "";

        /*static void Main(String[] arguments)
        {
            Connect("127.0.0.1", 14000);
            while (true)
            {

            }
        }*/


        public void Connect(String server, Int32 port)
        {
            try
            {

                _client = new UdpClient(server, port);

                
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                
                
               // SendMessage(Console.ReadLine());
          
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void SendMessage(string Message)
        {
            try
            {
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(Message);
                _client.Send(data, data.Length);
                Console.WriteLine("Sent: {0}", Message);
                //RecieveMessage();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            RecieveMessage();
        }
        private static void RecieveMessage()
        {
            try
            {
                Byte[] data = new Byte[256];
                String responseData = String.Empty;
                Int32 bytes = _stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine("Received:", responseData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

