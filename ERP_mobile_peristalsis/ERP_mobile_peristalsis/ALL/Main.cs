using ERP_mobile_peristalsis.manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Reflection;
using ERP_mobile_peristalsis.ALL.manager_form;
using System.Security.Cryptography;
using System.IO;

namespace ERP_mobile_peristalsis
{
    public partial class Main : Form
    {
        public static Main Main_form = new Main();
        public static Approval_add Approval_add_form = new Approval_add(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
        public static Approval_list Approval_list_form = new Approval_list(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
        public static Chatting Chatting_form = new Chatting();
        public static Go_to_work Go_to_work_form = new Go_to_work(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
        public static Inventory Inventory_form = new Inventory(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
        public static organization_chart organization_chart_form = new organization_chart(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
        public static Schedule Schedule_form = new Schedule(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
        public static Work_Add Work_Add_form = new Work_Add(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
        public static Work_list_check Work_list_check_form = new Work_list_check(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
        public static Log log_form = new Log();
        private SHA256Managed sha256Managed = new SHA256Managed();
        private RijndaelManaged aes = new RijndaelManaged();
        public static void level()
        {
            Approval_add_form.TopLevel = false;
            Approval_list_form.TopLevel = false;
            Go_to_work_form.TopLevel = false;
            Inventory_form.TopLevel = false;
            organization_chart_form.TopLevel = false;
            Schedule_form.TopLevel = false;
            Work_Add_form.TopLevel = false;
            Work_list_check_form.TopLevel = false;
        }
        public static bool login_switch = false;
        public static bool[] form_switch = new bool[10] { false, false, false, false, false, false, false, false, false, false}; //위의 approval_add부터 순서대로
        public Main()
        {
            InitializeComponent();
            Mainmenu.Visible = false;
        }
        private void 본인일정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            if (Schedule_form.IsDisposed)
            {
                Schedule_form = new Schedule(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
                Schedule_form.TopLevel = false;
                Action_panel.Controls.Add(Schedule_form);
                Schedule_form.Show();
            }
            else
            {
                Schedule_form.TopLevel = false;
                Action_panel.Controls.Add(Schedule_form);
                Schedule_form.Show();
            }
            Schedule_form.Text = "";
            Schedule_form.ControlBox = false;
            form_switch[7] = true;
        }

        private void 출근현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            if (Go_to_work_form.IsDisposed)
            {
                Go_to_work_form = new Go_to_work(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
                Go_to_work_form.TopLevel = false;
                Action_panel.Controls.Add(Go_to_work_form);
                Go_to_work_form.Show();
            }
            else
            {
                Go_to_work_form.TopLevel = false;
                Action_panel.Controls.Add(Go_to_work_form);
                Go_to_work_form.Show();
            }
            Go_to_work_form.Text = "";
            Go_to_work_form.ControlBox = false;
            form_switch[4] = true;
        }
        
        private void 채팅창ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_switch[2] == false)
            {
                Chatting_form = new Chatting();
                Chatting_form.init(); //채팅창 초기화하는 함수
                Chatting_form.Show();
                form_switch[2] = true;
            }
            else if (form_switch[2] == true)
            {
            }
        }

        private void 업무등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            if (Work_Add_form.IsDisposed)
            {
                Work_Add_form = new Work_Add(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
                Work_Add_form.TopLevel = false;
                Work_Add_form.Show();
            }
            else
            {
                Work_Add_form.TopLevel = false;
                Action_panel.Controls.Add(Work_Add_form);
                Work_Add_form.Show();
            }
            Work_Add_form.Text = "";
            Work_Add_form.ControlBox = false;
            form_switch[8] = true;
        }

        private void 업무확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            if (Work_list_check_form.IsDisposed)
            {
                Work_list_check_form = new Work_list_check(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
                Work_list_check_form.TopLevel = false;
                Action_panel.Controls.Add(Work_list_check_form);
                Work_list_check_form.Show();
            }
            else
            {
                Work_list_check_form.TopLevel = false;
                Action_panel.Controls.Add(Work_list_check_form);
                Work_list_check_form.Show();
            }
            Work_list_check_form.Text = "";
            Work_list_check_form.ControlBox = false;
            form_switch[9] = true;
        }

        private void 결재등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            if (Approval_add_form.IsDisposed)
            {
                Approval_add_form = new Approval_add(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
                Approval_add_form.TopLevel = false;
                Action_panel.Controls.Add(Approval_add_form);
                Approval_add_form.Show();
            }
            else
            {
                Approval_add_form.TopLevel = false;
                Action_panel.Controls.Add(Approval_add_form);
                Approval_add_form.Show();
            }
            Approval_add_form.Text = "";
            Approval_add_form.ControlBox = false;
            form_switch[0] = true;
        }

        private void 결재내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            if (Approval_list_form.IsDisposed)
            {
                Approval_list_form = new Approval_list(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
                Approval_list_form.TopLevel = false;
                Action_panel.Controls.Add(Approval_list_form);
                Approval_list_form.Show();
            }
            else
            {
                Approval_list_form.TopLevel = false;
                Action_panel.Controls.Add(Approval_list_form);
                Approval_list_form.Show();
            }
            Approval_list_form.Text = "";
            Approval_list_form.ControlBox = false;
            form_switch[1] = true;
        }

        private void 조직도검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            if (organization_chart_form.IsDisposed)
            {
                organization_chart_form = new organization_chart(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
                organization_chart_form.TopLevel = false;
                Action_panel.Controls.Add(organization_chart_form);
                organization_chart_form.Show();
            }
            else
            {
                organization_chart_form.TopLevel = false;
                Action_panel.Controls.Add(organization_chart_form);
                organization_chart_form.Show();
            }
            organization_chart_form.Text = "";
            organization_chart_form.ControlBox = false;
            form_switch[6] = true;
        }

        private void 재고ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_panel.Controls.Clear();
            if (Inventory_form.IsDisposed)
            {
                Inventory_form = new Inventory(Config_Manager.GetInstance().userid, Config_Manager.GetInstance().admin);
                Inventory_form.TopLevel = false;
                Action_panel.Controls.Add(Inventory_form);
                Inventory_form.Show();
            }
            else
            {
                Inventory_form.TopLevel = false;
                Action_panel.Controls.Add(Inventory_form);
                Inventory_form.Show();
            }
            Inventory_form.Text = "";
            Inventory_form.ControlBox = false;
            form_switch[3] = true;
        }
        private void Logout_button_Click(object sender, EventArgs e)
        {
            if (Config_Manager.GetInstance().aboutLogin == true)
            {
                if (MessageBox.Show("로그아웃 하시겠습니까?\n(로그아웃 시 현재 작업하고 있는 모든 것들이 저장되지 않습니다!)", "YesORNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Config_Manager.GetInstance().aboutLogin = false;
                    logout_Action();
                }  
            }
            else if (Config_Manager.GetInstance().aboutLogin == false)
            {
                try
                {
                    String user = "";
                    
                    Config_Manager.GetInstance().userid = ID_textbox.Text;
                    Config_Manager.GetInstance().password = PW_textbox.Text;

                    var rsa_password = "w'uTJQlW+uVS9uY";
                    var byteArray = Encoding.UTF8.GetBytes(Config_Manager.GetInstance().password);
                    byte[] encryptedArray = AESEncrypt256(byteArray, rsa_password);
                    string last_encoding_password= Encoding.UTF8.GetString(encryptedArray);

                    Query query = new Query().Select("ID, Admin").From("cpp_project.User").Where("ID='" + Config_Manager.GetInstance().userid + "' AND " + "PW_AES='" + last_encoding_password + "'");
                    DataTable dt = DB_Manager.getInstance().select(query.query);

                    foreach (DataRow row in dt.Rows)
                    {
                        user = row["ID"].ToString();
                        Config_Manager.GetInstance().admin = Convert.ToInt32(row["Admin"].ToString());
                    }
                    if (user != "")
                    {
                        Config_Manager.GetInstance().userid = user;
                        Config_Manager.GetInstance().aboutLogin = true;
                        login_Action();
                        Query query_name = new Query().Select("Name").From("cpp_project.User").Where("ID='" + Config_Manager.GetInstance().userid + "' AND " + "PW_AES='" + last_encoding_password + "'");
                        
                        DataTable dt_name = DB_Manager.getInstance().select(query_name.query);
                        foreach(DataRow row in dt_name.Rows)
                        {
                            Config_Manager.GetInstance().userName = row["Name"].ToString();
                            string a = Config_Manager.GetInstance().userName;
                            string b = a;
                        }

                    }
                    else
                    {
                        MessageBox.Show("아이디가 존재하지 않거나 비밀번호 오류입니다.");
                    }


                }
                catch { }
            }
        }

        public void AESEncrypt()
        {
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
        }


        //AES_256 암호화
        public byte[] AESEncrypt256(byte[] encryptData, String password)
        {
            // Salt는 비밀번호의 길이를 SHA256 해쉬값으로 한다.
            var salt = sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(password.Length.ToString()));
            Console.WriteLine("Salt(Base64) : " + Convert.ToBase64String(salt));


            //PBKDF2(Password-Based Key Derivation Function)
            //반복은 65535번
            var PBKDF2Key = new Rfc2898DeriveBytes(password, salt, 65535, HashAlgorithmName.SHA256);
            var secretKey = PBKDF2Key.GetBytes(aes.KeySize / 8);
            var iv = PBKDF2Key.GetBytes(aes.BlockSize / 8);

            Console.WriteLine("SecretKey(Base64) : " + Convert.ToBase64String(secretKey));
            Console.WriteLine("IV(Base64) : " + Convert.ToBase64String(iv));

            byte[] xBuff = null;
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateEncryptor(secretKey, iv), CryptoStreamMode.Write))
                {
                    cs.Write(encryptData, 0, encryptData.Length);
                }
                xBuff = ms.ToArray();
            }
            return xBuff;
        }

        //AES_256 복호화 확인용
        public byte[] AESDecrypt256(byte[] decryptData, String password)
        {
            // Salt는 비밀번호의 길이를 SHA256 해쉬값으로 한다.
            var salt = sha256Managed.ComputeHash(Encoding.UTF8.GetBytes(password.Length.ToString()));

            //PBKDF2(Password-Based Key Derivation Function)
            //반복은 65535번
            var PBKDF2Key = new Rfc2898DeriveBytes(password, salt, 65535, HashAlgorithmName.SHA256);
            var secretKey = PBKDF2Key.GetBytes(aes.KeySize / 8);
            var iv = PBKDF2Key.GetBytes(aes.BlockSize / 8);

            byte[] xBuff = null;
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(secretKey, iv), CryptoStreamMode.Write))
                {
                    cs.Write(decryptData, 0, decryptData.Length);
                }
                xBuff = ms.ToArray();
            }
            return xBuff;
        }
    private void login_Action()
        {
            Mainmenu.Visible = true;
            ID_label.Visible = false;
            ID_textbox.Visible = false;
            PW_label.Visible = false;
            PW_textbox.Visible = false;
            Action_panel.Visible = true;
            ID_textbox.Text = "";
            PW_textbox.Text = "";

            if (Config_Manager.GetInstance().admin >= 2)
            {
                Menu_manager.Visible = true;
            }
            else
            {
                Menu_manager.Visible = false;
            }

            manager.Query query = new manager.Query().Select("distinct(now())").From("cpp_project.User");
            DataTable dt = DB_Manager.getInstance().select(query.query);
            string now_time = "";
            foreach (DataRow row in dt.Rows)
            {
                now_time = row["(now())"].ToString();
            }
            DateTime date = new DateTime();
            date = Convert.ToDateTime(now_time);
            now_time = date.ToString("yyyy-MM-dd HH:mm:ss");
            string login_s = "login";
            query = new manager.Query().Insert("cpp_project.Login_log(ID, Log_time, Login_type)").Values("'" + Config_Manager.GetInstance().userid + "','" + now_time + "','" + login_s + "'");
            manager.DB_Manager.getInstance().insert(query.query);

            login_switch = true;
            Login_out_button.Text = "로그아웃";

        }
        private void logout_Action()
        {
            Mainmenu.Visible = false;
            ID_label.Visible = true;
            ID_textbox.Visible = true;
            PW_label.Visible = true;
            PW_textbox.Visible = true;
            Action_panel.Visible = false;
            Action_panel.Controls.Clear();
            Login_out_button.Text = "로그인";

            manager.Query query = new manager.Query().Select("distinct(now())").From("cpp_project.User");
            DataTable dt = DB_Manager.getInstance().select(query.query);
            string now_time = "";
            foreach (DataRow row in dt.Rows)
            {
                now_time = row["(now())"].ToString();
            }
            DateTime date = new DateTime();
            date = Convert.ToDateTime(now_time);
            now_time = date.ToString("yyyy-MM-dd HH:mm:ss");
            string logout_s = "logout";
            query = new manager.Query().Insert("cpp_project.Login_log(ID, Log_time, Login_type)").Values("'" + Config_Manager.GetInstance().userid + "','" + now_time + "','" + logout_s + "'");
            manager.DB_Manager.getInstance().insert(query.query);

            login_switch = false;
            formclosed();
        }
        public string RSAEncrypt(string getValue, string pubKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(); //암호화
            rsa.FromXmlString(pubKey);

            //암호화할 문자열을 UFT8인코딩
            byte[] inbuf = (new UTF8Encoding()).GetBytes(getValue);

            //암호화
            byte[] encbuf = rsa.Encrypt(inbuf, false);

            //암호화된 문자열 Base64인코딩
            return Convert.ToBase64String(encbuf);
        }

        // RSA 복호화
        public static string RSADecrypt(string getValue, string priKey)
        {
            //RSA객체생성
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(); //복호화
            rsa.FromXmlString(priKey);

            //sValue문자열을 바이트배열로 변환
            byte[] srcbuf = Convert.FromBase64String(getValue);

            //바이트배열 복호화
            byte[] decbuf = rsa.Decrypt(srcbuf, false);

            //복호화 바이트배열을 문자열로 변환
            string sDec = (new UTF8Encoding()).GetString(decbuf, 0, decbuf.Length);
            return sDec;
        }
        public void formclosed()
        {

            if (form_switch[0] == true)
            {
                Approval_add_form.Close();
            }
            if (form_switch[1] == true)
            {
                Approval_list_form.Close();
            }
            if (form_switch[2] == true)
            {
                Chatting_form.Close();
            }
            if (form_switch[3] == true)
            {
                Inventory_form.Close();
            }
            if (form_switch[4] == true)
            {
                Go_to_work_form.Close();
            }
            if (form_switch[5] == true)
            {
                organization_chart_form.Close();
            }
            if (form_switch[6] == true)
            {
                Schedule_form.Close();
            }
            if (form_switch[7] == true)
            {
                Work_Add_form.Close();
            }
            if (form_switch[8] == true)
            {
                Work_list_check_form.Close();
            }
            if (form_switch[9] == true)
            {
                log_form.Close();
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (login_switch == true)
            {
                manager.Query query = new manager.Query().Select("distinct(now())").From("cpp_project.User");
                DataTable dt = DB_Manager.getInstance().select(query.query);
                string now_time = "";
                foreach (DataRow row in dt.Rows)
                {
                    now_time = row["(now())"].ToString();
                }
                DateTime date = new DateTime();
                date = Convert.ToDateTime(now_time);
                now_time = date.ToString("yyyy-MM-dd HH:mm:ss");
                string logout_s = "logout";
                query = new manager.Query().Insert("cpp_project.Login_log(ID, Log_time, Login_type)").Values("'" + Config_Manager.GetInstance().userid + "','" + now_time + "','" + logout_s + "'");
                manager.DB_Manager.getInstance().insert(query.query);
            }

        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (login_switch == true)
            {
                manager.Query query = new manager.Query().Select("distinct(now())").From("cpp_project.User");
                DataTable dt = DB_Manager.getInstance().select(query.query);
                string now_time = "";
                foreach (DataRow row in dt.Rows)
                {
                    now_time = row["(now())"].ToString();
                }
                DateTime date = new DateTime();
                date = Convert.ToDateTime(now_time);
                now_time = date.ToString("yyyy-MM-dd HH:mm:ss");
                string logout_s = "logout";
                query = new manager.Query().Insert("cpp_project.Login_log(ID, Log_time, Login_type)").Values("'" + Config_Manager.GetInstance().userid + "','" + now_time + "','" + logout_s + "'");
                manager.DB_Manager.getInstance().insert(query.query);
            }
            Chatting_form.Close();
            log_form.Close();
        }

        private void 로그관련ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_switch[9] == false)
            {
                log_form = new Log();
                log_form.Show();
                form_switch[9] = true;
            }
            else if (form_switch[9] == true)
            {
            }
        }
    }
}
