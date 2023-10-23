using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformChat
{
    public class UIManager
    {
        private static UIManager uiMngInstance;

        private Dictionary<FORM_KIND, Form> form_List = new Dictionary<FORM_KIND, Form>();

        public Dictionary<FORM_KIND, Form> FORM_LIST = new Dictionary<FORM_KIND, Form>();

        public static UIManager Instance()
        {
            if(uiMngInstance == null)
            {
                uiMngInstance = new UIManager();
            }

            return uiMngInstance;
        }

        public bool Init()
        {
            return true;
        }
    }
}
