using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace PemilihanGuru
{
    public partial class user : UserControl
    {
        DataTable dt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };

        public user()
        {
            InitializeComponent();
        }

        private static user _instance;
        public static user Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new user();
                return _instance;
            }

        }

        private async void user_Load(object sender, EventArgs e)
        {
            int i = 0;
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = await client.GetTaskAsync("Counter/");
            counter ctn = response.ResultAs<counter>();
            
            dt.Columns.Add("Nama Depan");
            dt.Columns.Add("Nama Belakang");
            dt.Columns.Add("NIP");
            dt.Columns.Add("Tempat TglLahir");
            dt.Columns.Add("Pangkat/Golongan");
            dt.Columns.Add("Sekolah Mengajar");
            dt.Columns.Add("Mata Pelajaran");
            dt.Columns.Add("Username");
            dt.Columns.Add("Password");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Nama Depan"].Width = 90;
            dataGridView1.Columns["Nama Belakang"].Width = 90;
            dataGridView1.Columns["NIP"].Width = 150;
            dataGridView1.Columns["Tempat TglLahir"].Width = 150;
            dataGridView1.Columns["Pangkat/Golongan"].Width = 180;
            dataGridView1.Columns["Sekolah Mengajar"].Width = 150;
            dataGridView1.Columns["Mata Pelajaran"].Width = 150;
            dataGridView1.Columns["Username"].Width = 150;


            while (true)
            {
                i++;
                if (i > ctn.M)
                {
                    break;
                }
                FirebaseResponse responAkun = await client.GetTaskAsync("User_Account/" + i);
                Data data = responAkun.ResultAs<Data>();
                DataRow dr = dt.NewRow();
                dr["Nama Depan"] = data.namaDepan;
                dr["Nama Belakang"] = data.namaBelakang;
                dr["NIP"] = data.nip;
                dr["Tempat TglLahir"] = data.tglLahir;
                dr["Pangkat/Golongan"] = data.pangkatGol;
                dr["Sekolah Mengajar"] = data.sekolah;
                dr["Mata Pelajaran"] = data.mapel;
                dr["Username"] = data.username;
                dr["Password"] = data.pwd;
                dt.Rows.Add(dr);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //Edit value Tabel
        private async void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow dgv = dataGridView1.CurrentRow;
                int i = dgv.Index + 1;
                FirebaseResponse resPenilan = await client.GetTaskAsync("Penilaian/" + i);
                Penilaian ambil = resPenilan.ResultAs<Penilaian>();
                var data = new Data
                {
                    namaDepan = dgv.Cells[0].Value.ToString(),
                    namaBelakang = dgv.Cells[1].Value.ToString(),
                    nip = dgv.Cells[2].Value.ToString(),
                    tglLahir = dgv.Cells[3].Value.ToString(),
                    pangkatGol = dgv.Cells[4].Value.ToString(),
                    sekolah = dgv.Cells[5].Value.ToString(),
                    mapel = dgv.Cells[6].Value.ToString(),
                    username = dgv.Cells[7].Value.ToString(),
                    pwd = dgv.Cells[8].Value.ToString()
                };

                var nilai = new Penilaian
                {
                    nama = dgv.Cells[0].Value.ToString() +" "+ dgv.Cells[1].Value.ToString(),
                    nip = dgv.Cells[2].Value.ToString(),
                    username = dgv.Cells[7].Value.ToString(),
                    C1 = ambil.C1,
                    C2 = ambil.C2,
                    C3 = ambil.C3,
                    C4 = ambil .C4,
                    C5 = ambil.C5
                };
                FirebaseResponse response1 = await client.UpdateTaskAsync("User_Account/"+ i, data);
                Data data1 = response1.ResultAs<Data>();

                FirebaseResponse response2 = await client.UpdateTaskAsync("Penilaian/" + i, nilai);
                Penilaian penNilai = response2.ResultAs<Penilaian>();
            }
        }

        //Delete Button
        private async void button1_Click(object sender, EventArgs e)
        {
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            DialogResult result = MessageBox.Show("Apakah Anda Yakin?", "Smart Teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FirebaseResponse resCtn = await client.GetTaskAsync("Counter");
                counter ctn = resCtn.ResultAs<counter>();
                var con = new counter
                {
                    M = ctn.M - 1
                };
                DataGridViewRow dgv = dataGridView1.CurrentRow;
                int i = dgv.Index + 1;
                FirebaseResponse del = await client.DeleteTaskAsync("User_Account/" + i);
                FirebaseResponse delNilai = await client.DeleteTaskAsync("Penilaian/" + i);
                FirebaseResponse resUpdate = await client.UpdateTaskAsync("Counter", con);
                counter update = resUpdate.ResultAs<counter>();
                while (true)
                {
                    i++;
                    if (i > ctn.M)
                        break;
                    FirebaseResponse resNilai = await client.GetTaskAsync("Penilaian/" + i);
                    Penilaian penNilai = resNilai.ResultAs<Penilaian>();
                    FirebaseResponse resData = await client.GetTaskAsync("User_Account/" + i);
                    Data ambilData = resData.ResultAs<Data>();
                    var nilai = new Penilaian
                    {
                        nama = penNilai.nama,
                        nip = penNilai.nip,
                        username = penNilai.username,
                        C1 = penNilai.C1,
                        C2 = penNilai.C2,
                        C3 = penNilai.C3,
                        C4 = penNilai.C4,
                        C5 = penNilai.C5
                    };
                    var data = new Data
                    {
                        namaDepan = ambilData.namaDepan,
                        namaBelakang = ambilData.namaBelakang,
                        nip = ambilData.nip,
                        tglLahir = ambilData.tglLahir,
                        pangkatGol = ambilData.pangkatGol,
                        sekolah = ambilData.sekolah,
                        mapel = ambilData.mapel,
                        username = ambilData.username,
                        pwd = ambilData.pwd
                    };

                    SetResponse updateNilai = await client.SetTaskAsync("Penilaian/" + Convert.ToInt32(i - 1), nilai);
                    Penilaian gantiNilai = updateNilai.ResultAs<Penilaian>();
                    SetResponse updateAkun = await client.SetTaskAsync("User_Account/" + Convert.ToInt32(i - 1), data);
                    Data gantiAkun = updateAkun.ResultAs<Data>();
                    if (i == ctn.M)
                    {
                    FirebaseResponse del1 = await client.DeleteTaskAsync("User_Account/" + i);
                    FirebaseResponse del2 = await client.DeleteTaskAsync("Penilaian/" + i);
                    }
                }
            }
        }

        //Refresh Button
        private async void button3_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            int i = 0;
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = await client.GetTaskAsync("Counter/");
            counter ctn = response.ResultAs<counter>();

            while (true)
            {
                i++;
                if (i > ctn.M)
                {
                    break;
                }
                FirebaseResponse responAkun = await client.GetTaskAsync("User_Account/" + i);
                Data data = responAkun.ResultAs<Data>();
                DataRow dr = dt.NewRow();
                dr["Nama Depan"] = data.namaDepan;
                dr["Nama Belakang"] = data.namaBelakang;
                dr["NIP"] = data.nip;
                dr["Tempat TglLahir"] = data.tglLahir;
                dr["Pangkat/Golongan"] = data.pangkatGol;
                dr["Sekolah Mengajar"] = data.sekolah;
                dr["Mata Pelajaran"] = data.mapel;
                dr["Username"] = data.username;
                dr["Password"] = data.pwd;
                dt.Rows.Add(dr);
            }
        }

        //Edit Button
        private async void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgv = dataGridView1.CurrentRow;
            int i = dgv.Index + 1;
            var deu = new DialogEditUser(i);
            deu.ShowDialog();
        }
    }
}
