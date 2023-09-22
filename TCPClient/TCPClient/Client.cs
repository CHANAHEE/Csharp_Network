using System;
using System.Net.Sockets;
using System.Text;

namespace TcpCli
{
    class Client
    {
        static void Main(string[] args)
        {
            // (1) IP 주소와 포트를 지정하고 TCP 연결 
            TcpClient Client = new TcpClient("127.0.0.1", 7000);
            //TcpClient tc = new TcpClient("localhost", 7000);

            string Msg = "Hello World";
            byte[] Buff = Encoding.ASCII.GetBytes(Msg);

            // (2) NetworkStream을 얻어옴 
            NetworkStream Stream = Client.GetStream();

            // (3) 스트림에 바이트 데이타 전송
            Stream.Write(Buff, 0, Buff.Length);

            // (4) 스트림으로부터 바이트 데이타 읽기
            byte[] Outbuf = new byte[1024];
            int Nbytes = Stream.Read(Outbuf, 0, Outbuf.Length);
            string Output = Encoding.ASCII.GetString(Outbuf, 0, Nbytes);

            // (5) 스트림과 TcpClient 객체 닫기
            Stream.Close();
            Client.Close();

            Console.WriteLine($"{Nbytes} bytes: {Output}");
        }
    }
}