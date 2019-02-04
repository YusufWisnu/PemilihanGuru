using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace PemilihanGuru
{
    public partial class Register : Form
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
        public Register()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Register_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            client = new FireSharp.FirebaseClient(config);
            comboBox2.MouseWheel += new MouseEventHandler(comboBox2_MouseWheel);
            comboBox3.MouseWheel += new MouseEventHandler(comboBox2_MouseWheel);
        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                panel9.VerticalScroll.Value = e.NewValue;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Keluar Aplikasi", "SIMULASI", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
            var data = new Data
            {
                namaDepan = textBox10.Text,
                namaBelakang = textBox9.Text,
                nip = textBox8.Text,
                pangkatGol = comboBox2.Text,
                tglLahir = textBox7.Text,
                sekolah = textBox6.Text,
                mapel = comboBox3.Text,
                username = textBox1.Text,
                pwd = textBox2.Text
            };

            if (textBox2.Text == textBox3.Text)
            {
                circularProgressBar1.Visible = true;
                FirebaseResponse responseakun = await client.GetTaskAsync("Counter");
                counter ctn = responseakun.ResultAs<counter>();
                int i = 0;
                int b = 1;
                while (true)
                {
                    circularProgressBar1.Visible = true;
                    circularProgressBar1.Maximum = ctn.M;
                    circularProgressBar1.Minimum = 0;
                    circularProgressBar1.Value = i;
                    i++;
                    if (i > ctn.M)
                    {
                        break;
                    }
                    FirebaseResponse responseambil = await client.GetTaskAsync("User_Account/" + i);
                    Data obj = responseambil.ResultAs<Data>();
                        if (textBox1.Text == obj.username)
                        {
                            MessageBox.Show("Maaf, Username Sudah Terpakai", "Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            b = 2;
                            circularProgressBar1.Visible = false;
                            circularProgressBar1.Value = 0;
                        }
                        else if (textBox8.Text == obj.nip)
                        {
                            MessageBox.Show("Maaf, Tidak Dapat menggunakan NIP Yang Anda Masukkan", "Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            b = 2;
                            circularProgressBar1.Visible = false;
                            circularProgressBar1.Value = 0;
                        }

                }

                if (b == 1)
                {
                        circularProgressBar1.Visible = false;
                        var Counter = new counter
                        {
                            M = Convert.ToInt32(ctn.M + 1)
                        };
                        FirebaseResponse rsp = await client.UpdateTaskAsync("Counter", Counter);
                        counter ctn1 = rsp.ResultAs<counter>();
                        SetResponse response = await client.SetTaskAsync("User_Account/" + i, data);
                        Data result = response.ResultAs<Data>();

                        var nilai = new Penilaian
                        {
                            nama = result.namaDepan + " " + result.namaBelakang,
                            nip = result.nip,
                            C1 = 0,
                            C2 = 0,
                            C3 = 0,
                            C4 = 0,
                            C5 = 0,
                            username = result.username
                        };

                        SetResponse pushNilai = await client.SetTaskAsync("Penilaian/" + i, nilai);
                        Penilaian pen = pushNilai.ResultAs<Penilaian>();
                    }

                    if (MessageBox.Show("Registrasi Berhasil", "Registrasi", MessageBoxButtons.OK) == DialogResult.OK)
                    {

                        var lgn = new Login();
                        this.Close();
                        lgn.Show();
                    }
                
            }
            else
            {
                MessageBox.Show("Password Tidak Sama", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var lgn = new Login();
            this.Close();
            lgn.Show();
        }

        void comboBox2_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
