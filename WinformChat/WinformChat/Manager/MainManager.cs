using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinformChat
{
    public class MainManager
    {
        private static MainManager mainMngInstance;

        public TcpClient Client;

        public static MainManager Instance()
        {
            if(mainMngInstance == null)
            {
                mainMngInstance = new MainManager();
            }

            return mainMngInstance;
        }

        public bool Init()
        {
            StartForm();
            //ConnectToServer();
            return true;
        }

        public void StartForm()
        {
            ChatForm MainForm = new ChatForm();

            UIManager.Instance().FORM_LIST.Add(FORM_KIND.MAIN, MainForm);

            if (UIManager.Instance().FORM_LIST.ContainsKey(FORM_KIND.MAIN))
            {
                UIManager.Instance().FORM_LIST[FORM_KIND.MAIN].Show();
            }
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
            NetworkStream Stream = null;

            
        }
    }
}
