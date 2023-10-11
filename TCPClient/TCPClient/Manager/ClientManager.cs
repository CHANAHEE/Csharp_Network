using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TcpCli;

namespace TCPClient
{
    
    public class ClientManager
    {
        private static ClientManager clientMngInstance;

        private TcpClient Client;

        static public ClientManager Instance()
        {
            if(clientMngInstance == null)
            {
                clientMngInstance = new ClientManager();
            }

            return clientMngInstance;
        }

        public void ConnectToServer()
        {
            // (1) IP 주소와 포트를 지정하고 TCP 연결 
            while (true)
            {
                try
                {
                    Console.WriteLine("Client 연결 요청 중 . . .");
                    Client = new TcpClient("127.0.0.1", 7000);

                    Thread.Sleep(1000);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            Console.WriteLine("서버 연결 완료 !! ==============================");
            SendDataToServer();
        }


        public void SendDataToServer()
        {
            Console.WriteLine("서버로 데이터 보내는 중 . . .");

            string Msg = "Hello World";
            byte[] Buff = Encoding.ASCII.GetBytes(Msg);
            int Nbytes = 0;

            NetworkStream Stream = Client.GetStream();

            // 서버로 보내는 데이터
            Stream.Write(Buff, 0, Buff.Length);

            // 서버로 부터 받을 데이터 준비
            byte[] Outbuf = new byte[1024];

            while ((Nbytes = Stream.Read(Outbuf, 0, Outbuf.Length)) > 0)
            {
                string receivedData = Encoding.ASCII.GetString(Buff, 0, Nbytes);
                Console.WriteLine("서버로부터 받은 데이터 : " + receivedData);
            }

            Stream.Close();
            Client.Close();
        }
    }
}
