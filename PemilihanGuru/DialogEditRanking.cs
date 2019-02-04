using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace PemilihanGuru
{
    public partial class DialogEditRanking : Form
    {
        int baris;
        public DialogEditRanking()
        {
            InitializeComponent();
        }

        public DialogEditRanking(int _baris)
            :this()
        {
            this.baris = _baris;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            FirebaseResponse resNilai = await client.GetTaskAsync("Penilaian/" + baris);
            Penilaian ambil = resNilai.ResultAs<Penilaian>();
            var nilai = new Penilaian
            {
                nama = label1.Text,
                nip = ambil.nip,
                username = ambil.username,
                C5 = Convert.ToSingle(textBox1.Text),
                C2 = Convert.ToSingle(textBox2.Text),
                C3 = Convert.ToSingle(textBox3.Text),
                C4 = Convert.ToSingle(textBox4.Text),
                C1 = Convert.ToSingle(textBox5.Text),
            };
            FirebaseResponse update = await client.UpdateTaskAsync("Penilaian/" + baris, nilai);
            Penilaian pen1 = update.ResultAs<Penilaian>();
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DialogEditRanking_Load(object sender, EventArgs e)
        {
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            FirebaseResponse resPen = await client.GetTaskAsync("Penilaian/" + baris);
            Penilaian pen = resPen.ResultAs<Penilaian>();
            label1.Text = pen.nama;
            textBox1.Text = pen.C5.ToString();
            textBox2.Text = pen.C2.ToString();
            textBox3.Text = pen.C3.ToString();
            textBox4.Text = pen.C4.ToString();
            textBox5.Text = pen.C1.ToString();
        }
    }
}
