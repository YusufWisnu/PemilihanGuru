using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace PemilihanGuru
{
    public partial class ModalSoal : Form
    {
        double nilai;
        string username;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };
        IFirebaseClient client;

        public ModalSoal()
        {
            InitializeComponent();
        }

        public ModalSoal(double _nilai, string _username)
            : this()
        {
            this.nilai = _nilai;
            this.username = _username;
        }

        private void ModalSoal_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            panel3.BackColor = Color.White;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var sb = new SolidBrush(Color.FromArgb(100, 100, 100, 100));
            e.Graphics.FillRectangle(sb, this.DisplayRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int i = 0;
                double nilai2 = (nilai * 10) / 3;
                FirebaseResponse responseM = await client.GetTaskAsync("Counter");
                counter ctn = responseM.ResultAs<counter>();
                while (true)
                {
                    i++;
                    if (i > ctn.M)
                    {
                        break;
                    }

                    FirebaseResponse response = await client.GetTaskAsync("User_Account/" + i);
                    Data data = response.ResultAs<Data>();
                    if (username == data.username)
                    {
                        var penilaian = new Penilaian
                        {
                            nama = data.namaDepan + data.namaBelakang,
                            nip = data.nip,
                            C1 = Convert.ToSingle(string.Format("{0:0.##}", nilai2)),
                            C2 = 0,
                            C3 = 0,
                            C4 = 0,
                            C5 = 0,
                            username = data.username
                        };
                        FirebaseResponse updt = await client.UpdateTaskAsync("Penilaian/" + i, penilaian);
                        Penilaian pn = updt.ResultAs<Penilaian>();
                    }
                }
                var ss = new SoalSelesai();
                Soal1 obj = (Soal1)Application.OpenForms["Soal1"];
                obj.Close();
                this.Close();
                ss.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
