﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIO
{
    public partial class CustomerChatPage : Form
    {
        int time;
        string customerName = "Berkay";
        bool siyah;
        Thread th;
        public CustomerChatPage()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            th = new Thread(x);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();

        }
        private void x()
        {
            Application.Run(new UserProfile());
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (siyah)
            {
                messageScreenListBox.Items.Add("" + customerName + ": " + messageTextBox.Text);
                messageScreenListBox.Items.Add("AIO: " + aioAnswer("s"));
            }

        }

        private string aioAnswer(string customerAsk)
        {

            return "x";
        }

        private void CustomerChatPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void messageTextBox_Enter(object sender, EventArgs e)
        {
            if (messageTextBox.Text == "MESSAGE")
            {
                messageTextBox.Text = "";
                messageTextBox.ForeColor = Color.Black;
                siyah = true;
            }
        }

        private void messageTextBox_Leave(object sender, EventArgs e)
        {
            if (messageTextBox.Text == "")
            {
                messageTextBox.Text = "MESSAGE";
                messageTextBox.ForeColor = Color.Silver;
                siyah = false;
            }
        }
    }
}
