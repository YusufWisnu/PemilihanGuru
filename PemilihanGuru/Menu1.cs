using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace PemilihanGuru
{
    public partial class Menu1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };
        IFirebaseClient client;

        Data data;
        public static string username { get; set; }
        public Menu1()
        {
            InitializeComponent();
        }

        public Menu1(Data _data)
            : this()
        {
            this.data = _data;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu1_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            label22.Parent = panel3;
            circularProgressBar1.Parent = panel3;
            lokasi();
            client = new FireSharp.FirebaseClient(config);
            username = data.username;
            koneksi();

        }

        void lokasi()
        {
            panel3.Location = new System.Drawing.Point(114, 276);
            panel8.Location = new System.Drawing.Point(114, 276);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel12.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel8.Visible = false;
            panel12.Visible = false;
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
        }
        public async void koneksi()
        {
            int i = 0;
            FirebaseResponse resAkun = await client.GetTaskAsync("Counter");
            counter ctn = resAkun.ResultAs<counter>();
            circularProgressBar1.Maximum = ctn.M;
            while (true)
            {
                circularProgressBar1.Visible = true;
                label22.Visible = true;
                circularProgressBar1.Value = i;
                i++;
                if (i > ctn.M)
                {
                    circularProgressBar1.Visible = false;
                    label22.Visible = false;
                    break;
                }
                FirebaseResponse response = await client.GetTaskAsync("User_Account/" + i);
                Data obj = response.ResultAs<Data>();
                FirebaseResponse resPen = await client.GetTaskAsync("Penilaian/" + i);
                Penilaian pen = resPen.ResultAs<Penilaian>();
                if (username == obj.username)
                {
                    label10.Text = obj.nip;
                    label11.Text = obj.namaDepan + " " + obj.namaBelakang;
                    label12.Text = obj.mapel;
                    label13.Text = obj.sekolah;
                }
                if (pen.username == username && pen.C1 == 0)
                {
                    label19.Text = "Belum Mengikuti";
                }
                else if (pen.username == username && pen.C1 != 0)
                {
                    label19.Text = "Sudah Mengikuti";
                    button3.Enabled = false;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var lgn = new Login();
            this.Close();
            lgn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var soal1 = new Soal1(username);
            this.Close();
            soal1.Show();
        }
    }
}
