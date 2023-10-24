using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Diagnostics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public enum CLIENT_TYPE
    {
        NONE = 0,

        FIRST,
        SECOND,

        MAX
    }

    public class Program
    {
        private static TcpListener Listener_First;
        private static TcpListener Listener_Second;
        private static TcpClient Client;
        private static NetworkStream FirstClientStream;
        private static NetworkStream SecondClientStream;


        static void Main(string[] args)
        {
            Listener_First = new TcpListener(IPAddress.Any, 7000);
            Listener_First.Start();

            Listener_Second = new TcpListener(IPAddress.Any, 7001);
            Listener_Second.Start();

            Thread Accept_FirstClientThread = new Thread(new ThreadStart(Accept_FirstClient));
            Accept_FirstClientThread.Start();

            Thread Accept_SecondClientThread = new Thread(new ThreadStart(Accept_SecondClient));
            Accept_SecondClientThread.Start();
            
            Accept_FirstClientThread.Join();
            Accept_SecondClientThread.Join();

            Client.Close();
            FirstClientStream.Close();
            SecondClientStream.Close();
            Console.WriteLine("Server Listencer Close");
        }

        public static void Accept_FirstClient()
        {
            Console.WriteLine("첫번째 Client 연결 대기중 . . .");
            Client = Listener_First.AcceptTcpClient();

            Console.WriteLine("Client 연결 완료 !");
            FirstClientStream = Client.GetStream();

            Receive_Client(CLIENT_TYPE.FIRST);
        }

        public static void Accept_SecondClient()
        {
            

            Console.WriteLine("두번째 Client 연결 대기중 . . .");
            Client = Listener_Second.AcceptTcpClient();

            Console.WriteLine("Client 연결 완료 !");
            SecondClientStream = Client.GetStream();

            Receive_Client(CLIENT_TYPE.SECOND);
        }


        public static void Receive_Client(CLIENT_TYPE ClientType)
        {
            switch(ClientType)
            {
                case CLIENT_TYPE.FIRST:
                    RecvMsgFromClient(CLIENT_TYPE.FIRST);
                    break;
                case CLIENT_TYPE.SECOND:
                    RecvMsgFromClient(CLIENT_TYPE.SECOND);
                    break;
            }
                     
        }

        public static void RecvMsgFromClient(CLIENT_TYPE ClientType)
        {
            while (true)
            {
                byte[] Buff = new byte[1024];
                int Nbytes;
                string ReceiveData = "";

                if(ClientType == CLIENT_TYPE.FIRST)
                {
                    while ((Nbytes = FirstClientStream.Read(Buff, 0, Buff.Length)) > 0)
                    {
                        ReceiveData = Encoding.Unicode.GetString(Buff, 0, Nbytes);

                        Console.WriteLine("1번 클라이언트 : " + ReceiveData);
                        SendMsgToClient(SecondClientStream, Buff);
                    }
                }
                if(ClientType == CLIENT_TYPE.SECOND) 
                {
                    while ((Nbytes = SecondClientStream.Read(Buff, 0, Buff.Length)) > 0)
                    {
                        ReceiveData = Encoding.Unicode.GetString(Buff, 0, Nbytes);

                        Console.WriteLine("2번 클라이언트 : " + ReceiveData);
                        SendMsgToClient(FirstClientStream, Buff);
                    }
                }                
            }
        }

        public static void SendMsgToClient(NetworkStream Stream, byte[] Msg)
        {
            Stream.Write(Msg);

            Stream.Flush();
        }
    }
}