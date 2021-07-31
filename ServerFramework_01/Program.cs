using System;
using System.Net;
using System.Net.Sockets;

namespace ServerFramework_01
{
    class Program
    {
        private static UdpClient _socket = new UdpClient();

        static void Main()
        {
            while (true)
            {
                IPEndPoint ep = null;
                Console.WriteLine(_socket.Client.LocalEndPoint.ToString());
                _ = _socket.Receive(ref ep);
            }
        }
    }
}
