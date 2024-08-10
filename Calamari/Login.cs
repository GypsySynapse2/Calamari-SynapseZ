using Calamari_CH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calamari_L
{
    public partial class Login : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Login()
        {
            InitializeComponent();
            player.URL = "jacked_up.mp3";
            player.controls.play();
        }

        bool _Login(string user, string pass)
        {
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            //if (t1 == "mnoq" && t2 == "trollservice")
            if (true)
            {
                Form1 frm = new Form1();
                frm.Show();
                this.BackgroundImage = null;
                foreach (Control c in this.Controls)
                {
                    c.BackgroundImage = null;
                }
                this.Hide();
                player.controls.stop();
            }
            else
            {
                MessageBox.Show("Wrong password or username!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            player.controls.stop();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            player.controls.play();
        }
    }
    }