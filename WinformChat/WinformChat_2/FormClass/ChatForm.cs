using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
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
        }

        private void button_Input_Click(object sender, EventArgs e)
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
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainManager.Instance().Client.Close();
            Stream.Close();
            Process.GetCurrentProcess().Kill();
        }
    }
}
