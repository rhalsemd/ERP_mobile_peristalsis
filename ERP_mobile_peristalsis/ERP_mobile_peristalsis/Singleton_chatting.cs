using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_mobile_peristalsis
{
    class Singleton_chatting
    {
        public int check = 0;
        public static SplitContainer splitcontainer_instance;
        private static Singleton_chatting chatting_instance;
        public static chatting_log_pannel log_instance;
        private Singleton_chatting()
        {
        }
        public static Singleton_chatting instance( )
        {
            if (chatting_instance == null)
            {
                chatting_instance = new Singleton_chatting();
            }
            return chatting_instance;
        }
        public void splitcontainer_set(SplitContainer add_instance)
        {
            splitcontainer_instance = add_instance;
        }
        public SplitContainer splitcontainer_get()
        {
            return splitcontainer_instance;
        }
        public void log_set(chatting_log_pannel parameter_log)
        {
            log_instance = parameter_log;
        }
        public chatting_log_pannel log_get()
        {
            return log_instance;
        }
        public void log_clean()
        {
            //log_instance 내부 싹 날리는 방식으로 진행
        }
    }

}
