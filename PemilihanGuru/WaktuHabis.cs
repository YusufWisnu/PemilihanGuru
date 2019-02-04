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

namespace PemilihanGuru
{
    public partial class WaktuHabis : Form
    {
        string username;
        double nilai;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };
        IFirebaseClient client;
        public WaktuHabis()
        {
            InitializeComponent();
        }

        public WaktuHabis(double _nilai, string _username)
            :this()
        {
            this.nilai = _nilai;
            this.username = _username;
        }

        private async void WaktuHabis_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Value = 0;
            client = new FireSharp.FirebaseClient(config);
            int i = 0;
            double nilai2 = (nilai * 10) / 3;
            FirebaseResponse responseM = await client.GetTaskAsync("Counter");
            counter ctn = responseM.ResultAs<counter>();
            circularProgressBar1.Maximum = ctn.M;
            while (true)
            {
                circularProgressBar1.Value = i;
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

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var sb = new SolidBrush(Color.FromArgb(100, 100, 100, 100));
            e.Graphics.FillRectangle(sb, this.DisplayRectangle);
        }
    }
}
