using System;
using System.Net.Sockets;
using System.Text;
using TCPClient;

namespace TcpCli
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientManager.Instance().ConnectToServer();            
        }
    }
}