using System;

namespace TCPServer.App.AfzaalAhmadZeeshan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the port where to run the TCP server: ");
            int port = Convert.ToInt32(Console.ReadLine());

            TcpServer.StartServer(port);
            TcpServer.Listen();
        }
    }
}
