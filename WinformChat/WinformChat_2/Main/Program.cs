using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformChat
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WinformChat_2_Main WinformChatMain = new WinformChat_2_Main();

            if(WinformChatMain.Init() == false)
            {
                return;
            }

            Application.Run();

            WinformChatMain.Close();
        }
    }
}
