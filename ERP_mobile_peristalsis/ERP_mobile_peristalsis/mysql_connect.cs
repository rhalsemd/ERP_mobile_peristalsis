using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ERP_mobile_peristalsis
{
    
    class mysql_connect
    {
        string _server = "169.254.28.57";
        int _port = 5033;
        string _database = "cpp_project";
        string _id = "cppuser";
        string _pw = "cppuser";
        public void mysql_connect_return() {
            string _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        
        }
        public string chatting_log_query()
        {
            string query = "";//쿼리 만들기 

            return query;
        }
    }
}
