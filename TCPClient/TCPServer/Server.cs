using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;
using System.Net;

namespace TcpSrv
{
    class Program
    {
        static void Main(string[] args)
        {
            // (1) 로컬 포트 7000 을 Listen
            TcpListener Listener = new TcpListener(IPAddress.Any, 7000);
            Listener.Start();

            byte[] Buff = new byte[1024];

            while (true)
            {
                Console.WriteLine("Client 연결 대기중 . . .");
                TcpClient Client = Listener.AcceptTcpClient();

                Console.WriteLine("Client 연결 완료 !");
                NetworkStream Stream = Client.GetStream();

                int Nbytes;
                string ReceiveData = "";

                while ((Nbytes = Stream.Read(Buff, 0, Buff.Length)) > 0)
                {
                    ReceiveData = Encoding.ASCII.GetString(Buff,0,Nbytes);
                    Console.WriteLine("데이터 받는중 : " + ReceiveData + "   남은 데이터 개수 : " + Nbytes);
                    Stream.Write(Buff, 0, Nbytes);
                }

                Console.WriteLine("받아온 데이터 : " + ReceiveData);

                Stream.Close();
                Client.Close();
            }
        }
    }
}

