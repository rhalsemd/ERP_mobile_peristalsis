﻿using System;
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
    public partial class Chatting : Form
    {
        public Chatting()
        {
            InitializeComponent();
        }


        private void Chatting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.chatting_switch = false;
            this.Hide();
            e.Cancel = true;
        }
    }
}
