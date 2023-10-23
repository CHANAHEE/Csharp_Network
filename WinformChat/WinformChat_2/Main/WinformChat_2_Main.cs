using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformChat
{
    public class WinformChat_2_Main
    {
        public bool Init()
        {
            if(UIManager.Instance().Init() == false)
            {
                return false;
            }
            if(MainManager.Instance().Init() == false) 
            {
                return false;
            }

            return true;
        }

        public void Close()
        {
            
        }
    }
}
