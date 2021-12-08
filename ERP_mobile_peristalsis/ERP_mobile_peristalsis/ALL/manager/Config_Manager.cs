using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_mobile_peristalsis.manager
{
    class Config_Manager
    {
        public string userid = "";
        public string password = "";
        public bool aboutLogin = false;
        public int admin = -1;
        private static Config_Manager instance_ = new Config_Manager();

        public static Config_Manager GetInstance() { return instance_; }

        private Config_Manager()
        { }
        public string GetUid()
        {
            return userid;
        }
        public string GetPassword()
        {
            return password;
        }
    }
}
