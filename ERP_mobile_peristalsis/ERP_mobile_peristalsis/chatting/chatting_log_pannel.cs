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
    public partial class chatting_log_pannel : UserControl
    {
        public chatting_log_pannel()
        {
            InitializeComponent();
        }
        Label[] chatting_text_list;


        private void chatting_log_pannel_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }
        private void count_list()
        {
            //여기서 채팅방 label 갯수 세어서 리스트에 넣어주기
        }
    }
}
