﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformChat
{
    public partial class ChatForm : Form
    {
        NetworkStream Stream = null;

        public ChatForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Thread RecvMsgThread = new Thread(RecvMsg);
            RecvMsgThread.Start();
        }

        private void button_Input_Click(object sender, EventArgs e)
        {
            SendMsg();
        }


        private void ChatForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendMsg();                
            }
        }


        private void RecvMsg()
        {

            while (true)
            {
                if (Stream == null)
                {
                    break;
                }

                byte[] Buff = new byte[1024];
                int Nbytes;
                string ReceiveData = "";


                while ((Nbytes = Stream.Read(Buff, 0, Buff.Length)) > 0)
                {
                    ReceiveData = Encoding.Unicode.GetString(Buff, 0, Nbytes);
                    textBox_RecvMsg.Text = ReceiveData;
                }
            }


            /*TextBox NewText = new TextBox();
            NewText.Multiline = true;
            NewText.Text = ReceiveData;
            

            panel_RecvMsg.Controls.Add(NewText);*/
        }

        private void SendMsg()
        {
            string Msg = textBox_SendMsg.Text;

            if (Msg == "")
            {
                textBox_SendMsg.Focus();
                return;
            }

            byte[] Buff = Encoding.Unicode.GetBytes(Msg);

            Stream = MainManager.Instance().Client.GetStream();

            // 서버로 보내는 데이터
            Stream.Write(Buff, 0, Buff.Length);

            textBox_SendMsg.Clear();
        }


        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainManager.Instance().Client.Close();
            Stream.Close();
            Process.GetCurrentProcess().Kill();
        }        
    }
}
