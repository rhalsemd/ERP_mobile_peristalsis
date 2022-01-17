using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ERP_mobile_peristalsis.manager
{
    class DB_Manager
    {
        string strConn = "Server=221.162.215.119;Port=5033;Database=cpp_project;Uid=cppuser;Pwd=cppuser;SSL Mode=None";
        private static DB_Manager instance_ = new DB_Manager();
        private DB_Manager()
        {
        }

        public static DB_Manager getInstance() { return instance_; }


        public DataTable select(string query)
        {
            Console.WriteLine(query);
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                rdr.Close();
            }
            return dt;
        }
        public int count_call(Query query)
        {

            DataTable dt_count = DB_Manager.getInstance().select(query.query);//여기에 채팅방 갯수를 넣어야된다.
            string st_count = "";
            foreach (DataRow row in dt_count.Rows)
            {
                st_count = row["count(*)"].ToString();
            }
            int count = Convert.ToInt32(st_count);
            return count;
        }
        
        public byte[] Image_process(string query)
        {
            UInt32 FileSize;
            byte[] rawData;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader myData = cmd.ExecuteReader();

                if (!myData.HasRows)
                    throw new Exception("There are no BLOBs ");

                myData.Read();

                FileSize = myData.GetUInt32(myData.GetOrdinal("filesize"));
                rawData = new byte[FileSize]; // 받아온 파일

                return rawData;
            }
        }

        public void update(string query)
        {
            Console.WriteLine(query);
            int rdr = 0;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {

                conn.Open();
                MySqlCommand cmd =
                      new MySqlCommand(query, conn);
                rdr = cmd.ExecuteNonQuery();

            }
        }
        public void delete(string query)
        {
            Console.WriteLine(query);
            int rdr;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd =
                      new MySqlCommand(query, conn);
                rdr = cmd.ExecuteNonQuery();

            }
        }

        public void insert(string query)
        {
            Console.WriteLine(query);
            int ret = 0;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                ret = cmd.ExecuteNonQuery();
            }
        }
        public void updatePhoto(string query, byte[] img)
        {
            Console.WriteLine(query);
            int rdr = 0;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                query = "INSERT INTO mydb.user(Id, photo) VALUES(@Id,@Img)";
                cmd.Parameters.Add("@Img", MySqlDbType.MediumBlob);
                cmd.Parameters["@Img"].Value = img;
                rdr = cmd.ExecuteNonQuery();
                if (rdr == 1)
                {
                }
            }
        }
        public DataTable selectPhoto(string query)
        {
            Console.WriteLine(query);
            DataTable dt = new DataTable();
            MySqlDataAdapter da;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                da = new MySqlDataAdapter(cmd);//
                da.Fill(dt);
                da.Dispose();
                return dt;
            }
        }
        //TODO: 여기서 시간 처리해줘야됨
        public int last_chat_num(string chatting_room_name)//마지막으로 채팅친 num을 찾아내는 함수로 typing_pannel에서 사용하고있다.
        {
            int lasttime = 0;
            string query = "select* from  Personal_Chatting_Log where Key_num = (select max(Key_num) from Personal_Chatting_Log where Title = '" + chatting_room_name + "')";//마지막으로 채팅친 내역 불러오기
            DataTable datatable = DB_Manager.getInstance().select(query);//마지막 채팅기록을 불러온다
            foreach (DataRow row in datatable.Rows)
            {
                lasttime = Convert.ToInt32(row["Key_num"]);
            }
            return lasttime;
        }
        public int chat_num(string chatting_room_name,string chatting_log)//채팅 로그를 기반으로 채팅친 num을 찾아내는 함수로 typing_pannel에서 사용하고있다.
        {
            int lasttime = 0;
            string query = "select Key_num from  Personal_Chatting_Log where Log='" + chatting_log + "' and Title = '" + chatting_room_name + "'";//마지막으로 채팅친 내역 불러오기
            DataTable datatable = DB_Manager.getInstance().select(query);//마지막 채팅기록을 불러온다
            foreach (DataRow row in datatable.Rows)
            {
                lasttime = Convert.ToInt32(row["Key_num"]);
            }
            return lasttime;
        }
    }
}
