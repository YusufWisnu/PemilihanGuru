using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace PemilihanGuru
{


    public partial class Login : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };
        IFirebaseClient client;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            client = new FireSharp.FirebaseClient(config);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var regist = new Register();
            regist.Show();
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                var admin = new Admin();
                this.Hide();
                admin.Show();
            }
            else
            {
                int i = 0;
                int b = 0;
                circularProgressBar1.Minimum = 0;
                label4.Visible = true;
                FirebaseResponse responsecounter = await client.GetTaskAsync("Counter");
                counter ctn = responsecounter.ResultAs<counter>();
                circularProgressBar1.Maximum = ctn.M;
                while (true)
                {
                    circularProgressBar1.Value = i;
                    i++;

                    if (i > ctn.M)
                    {
                        label4.Visible = false;
                        circularProgressBar1.Visible = false;
                        break;
                    }
                    FirebaseResponse response = await client.GetTaskAsync("User_Account/" + i);
                    Data obj = response.ResultAs<Data>();
                    if (textBox1.Text == obj.username && textBox2.Text == obj.pwd)
                    {
                        b = 1;
                    }
                }

                if (b == 1)
                {
                    var data = new Data();
                    data.username = textBox1.Text;
                    Menu1 mn = new Menu1(data);
                    this.Hide();
                    mn.Show();

                }
                else
                {
                    MessageBox.Show("Harap Periksa Username dan Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah Anda Yakin Keluar Aplikasi","SIMULASI", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
