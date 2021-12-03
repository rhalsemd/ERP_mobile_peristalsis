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
    public partial class typing_pannel : UserControl
    {
        public typing_pannel()
        {
            InitializeComponent();
        }
        
        private void typing_pannel_Load(object sender, EventArgs e)
        {
            
        }
        
        private void enter_button1_Click(object sender, EventArgs e)
        {
            chatting_textBox1.Text = "";
            Main.Chatting_form.test();
        }

        private void chatting_textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //엔터 입력을 받았을 때
                chatting_textBox1.Text = "";
            }
        }

        private void chatting_textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
