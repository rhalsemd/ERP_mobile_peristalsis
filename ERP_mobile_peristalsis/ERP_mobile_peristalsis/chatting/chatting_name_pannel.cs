using ERP_mobile_peristalsis.chatting;
using ERP_mobile_peristalsis.manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_mobile_peristalsis
{
    public partial class chatting_name_pannel : UserControl
    {
        public string chatting_room_name = "";
        public chatting_name_pannel()
        {
            InitializeComponent();
        }
        private void chatting_name_pannel_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(192,192,192);
        }
        private void chatting_name_pannel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        private void chatting_name_pannel_Click(object sender, EventArgs e)
        {             
            SplitContainer getsplit = Main.Chatting_form.splitcontainer;
            if (Main.Chatting_form.check_chatting_log_panel == 0)
            {
                Main.Chatting_form.check_chatting_log_panel++;
                this.BackColor = Color.FromArgb(0, 0, 0);
                typing_pannel typping_add = new typing_pannel();
                typping_add.Size = new Size(getsplit.Panel2.Width, 100);
                typping_add.Dock = DockStyle.Bottom;
                getsplit.Panel2.Controls.Add(typping_add);

                chatting_log_pannel log = new chatting_log_pannel();
                log.Size = new Size(getsplit.Panel2.Width, getsplit.Panel2.Height - 100);
                log.Dock = DockStyle.Top;
                log.BackColor = Color.Black;
                getsplit.Panel2.Controls.Add(log);
                //여기 아래부터는 for 를 통해서 자동 생성할 부분들 스크롤 처리 테스트한다고 미리 만들어둠
                //여기 하단부터 채팅 내역을 그대로 불러와서 넣는 작업이 필요하다.
                for (int i = 0; i < 10; i++)
                {
                    chatting_log_column for_add1 = new chatting_log_column(true, this.Width);
                    for_add1.BackColor = Color.White;
                    log.Controls.Add(for_add1);
                    for_add1.Dock = DockStyle.Top;
                    for_add1.BorderStyle = BorderStyle.FixedSingle;
                }
                for (int i = 0; i < 10; i++)
                {
                    chatting_log_column for_add1 = new chatting_log_column(false, this.Width);
                    for_add1.BackColor = Color.White;
                    log.Controls.Add(for_add1);
                    for_add1.Dock = DockStyle.Top;
                    for_add1.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }
    }
}
