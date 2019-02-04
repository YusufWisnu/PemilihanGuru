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
using FireSharp.Response;
using FireSharp.Config;
using System.Runtime.InteropServices;

namespace PemilihanGuru
{
    public partial class DialogEditUser : Form
    {
        public int baris { get; set; }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };

        public DialogEditUser()
        {
            InitializeComponent();
        }
        public DialogEditUser(int _baris)
            :this()
        {
            this.baris = _baris;
        }

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

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            FirebaseResponse resPenilan = await client.GetTaskAsync("Penilaian/" + baris);
            Penilaian ambil = resPenilan.ResultAs<Penilaian>();
            FirebaseResponse resData = await client.GetTaskAsync("User_Account/" + baris);
            Data data = resData.ResultAs<Data>();
            var akun = new Data
            {
                namaDepan = textBox2.Text,
                namaBelakang = textBox1.Text,
                nip = textBox3.Text,
                tglLahir = textBox4.Text,
                sekolah = textBox6.Text,
                pangkatGol = comboBox1.Text,
                mapel = comboBox2.Text,
                username = textBox8.Text,
                pwd = textBox9.Text
            };

            var nilai = new Penilaian
            {
                nama = textBox2.Text+" "+textBox1.Text,
                nip = textBox3.Text,
                username = textBox8.Text,
                C1 = ambil.C1,
                C2 = ambil.C2,
                C3 = ambil.C3,
                C4 = ambil.C4,
                C5 = ambil.C5
            };

            FirebaseResponse response1 = await client.UpdateTaskAsync("User_Account/" + baris, akun);
            Data data1 = response1.ResultAs<Data>();

            FirebaseResponse response2 = await client.UpdateTaskAsync("Penilaian/" + baris, nilai);
            Penilaian penNilai = response2.ResultAs<Penilaian>();

            MessageBox.Show("Edit Berhasi", "Smart Teacher", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DialogEditUser_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            FirebaseResponse resData = await client.GetTaskAsync("User_Account/" + baris);
            Data data = resData.ResultAs<Data>();
            textBox2.Text = data.namaDepan;
            textBox1.Text = data.namaBelakang;
            textBox3.Text = data.nip;
            textBox4.Text = data.tglLahir;
            textBox6.Text = data.sekolah;
            textBox8.Text = data.username;
            textBox9.Text = data.pwd;
            comboBox1.Text = data.pangkatGol;
            comboBox2.Text = data.mapel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
