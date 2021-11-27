using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ERP_mobile_peristalsis
{
    
    public class mysql_connect
    {
        private static mysql_connect instance = new mysql_connect();
        static SQLDataBase myconn = new SQLDataBase();
        private mysql_connect() { }
        public static mysql_connect GetInstance()
        {
            return instance;
        }
        public int get_result()
        {
            return myconn.Count();
        }

    }

    class SQLDataBase
    {
        public MySqlConnection connection;

        // 생성자
        public SQLDataBase()
        {
            Initialize();
        }

        // MySQL DB셋팅 초기화
        private void Initialize()
        {
            Console.WriteLine("DataBse Initialize");

            string connectionString;
            connectionString = "Server=1.251.132.194;Port=5033;Database=cpp_project;Uid=cppuser;Pwd=cppuser;SSL Mode=None";

            connection = new MySqlConnection(connectionString);
        }

        // 데이터베이스 연결을 Open
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("DataBase연동 성공");
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("데이터베이스 서버에 연결할 수 없습니다.");
                        break;

                    case 1045:
                        Console.WriteLine("유저 ID 또는 Password를 확인해주세요.");
                        break;
                }
                return false;
            }
        }

        // 데이터베이스 연결을 Close
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Insert, Delete, Update처럼 DataBase를 Write하는 기능은 아래 함수로 통일할 수 있다.
        public void ExecuteMySQLQuery(string userQuery)
        {
            string query = userQuery;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        // DataBase에서 원하는 요소를 Select.

        // DataBase Table Row의 수를 Count
        public int Count()
        {
            string query = $"SELECT Count(*) FROM login";
            int Count = -1;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                Count = int.Parse(cmd.ExecuteScalar() + "");

                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
