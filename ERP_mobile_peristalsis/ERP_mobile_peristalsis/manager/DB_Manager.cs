using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ERP_mobile_peristalsis.manager
{
    class DB_Manager
    {
        string strConn = "Server=1.251.132.194;Port=5033;Database=cpp_project;Uid=cppuser;Pwd=cppuser;SSL Mode=None";
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

        public int insert(string query)
        {
            Console.WriteLine(query);
            int ret = 0;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                ret = cmd.ExecuteNonQuery();
            }
            return ret;
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
    }
}
