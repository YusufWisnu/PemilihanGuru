using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Diagnostics;

namespace PemilihanGuru
{
    public partial class ranking : UserControl
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        public ranking()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };

        private static ranking _instance;
        public static ranking Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ranking();
                return _instance;
            }

        }
        private async void ranking_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            int i = 0;
            loadgrid2();
            loadgrid1();
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            this.dataGridView1.Sort(this.dataGridView1.Columns["Nilai Akhir"], ListSortDirection.Descending);
            

            FirebaseResponse response = await client.GetTaskAsync("Counter");
            counter ctn = response.ResultAs<counter>();
            while (true)
            {
                i++;
                if (i > ctn.M)
                {
                    break;
                }
                
                FirebaseResponse responseNilai = await client.GetTaskAsync("Penilaian/" + i);
                Penilaian obj = responseNilai.ResultAs<Penilaian>();
                DataRow dr = dt2.NewRow();
                dr["Nama"] = obj.nama;
                dr["NIP"] = obj.nip;
                dr["Dokumen Portofolio"] = obj.C5;
                dr["Kinerja Guru"] = obj.C2;
                dr["Presentasi Best Practice"] = obj.C3;
                dr["Wawancara"] = obj.C4;
                dr["Test Tulis"] = obj.C1;
                dt2.Rows.Add(dr);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            label3.Visible = true;
            pictureBox1.Visible = true;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            try
            {
            int c=0;
            int k = 0;
            int i, j;
            double[,] result = new double[99, 99];
            double[,] salin = new double[99, 99];
            double[,] temp = new double[99, 99];
            double[,] temp2 = new double[99, 99];
            double[,] fix = new double[99, 99];
            double[,] a = new double[99, 99];
            double[] temporary = new double[99];

            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            FirebaseResponse delete = await client.DeleteTaskAsync("Ranking");
            FirebaseResponse response = await client.GetTaskAsync("Counter/");
            counter bts  = response.ResultAs<counter>();
            //cetak matriks
            for (i = 1; i <= bts.M; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    FirebaseResponse responNilai = await client.GetTaskAsync("Penilaian/" + i);
                    Penilaian obj = responNilai.ResultAs<Penilaian>();
                    if (j == 1)
                    {
                        a[i, j] = obj.C1;
                        salin[i, j] = obj.C1;
                    }
                    else if (j == 2)
                    {
                        a[i, j] = obj.C2;
                        salin[i, j] = obj.C2;
                    }
                    else if (j == 3)
                    {
                        a[i, j] = obj.C3;
                        salin[i, j] = obj.C3;
                    }
                    else if (j == 4)
                    {
                        a[i, j] = obj.C4;
                        salin[i, j] = obj.C4;
                    }else if (j == 5)
                    {
                        a[i, j] = obj.C5;
                        salin[i, j] = obj.C5;
                    }
                    ////Debug.Write(string.Format("{0:N2} ", salin[i, j]));
                }
                ////Debug.WriteLine("");
            }
            //end cetak matriks

            //cetak hasil akar
            for (j = 1; j <= 5; j++)
            {
                for (i = 1; i <= bts.M; i++)
                {
                    if (i == 1)
                    {
                        salin[i + 1, j] = Math.Pow(salin[i + 1, j], 2) + Math.Pow(salin[i, j], 2);

                    }
                    else if (i > 1)
                    {
                        salin[i + 1, j] = Math.Pow(salin[i + 1, j], 2) + salin[i, j];

                    }
                    result[i, j] = Math.Sqrt(salin[i, j]);
                    //if (i % 2 == 0)
                    //{
                        Debug.WriteLine(result[i, j]);
                   // }
                }
            }
            //end cetak hasil akar

            //cetak Xij + perkalian bobot
            Debug.WriteLine("");
            for (j = 1; j <= 5; j++)
            {
                for (i = 1; i <= bts.M; i++)
                {
                    
                    temp[i, j] = a[i, j] / result[bts.M, j];
                    if(j==1)
                        temp2[i, j] = temp[i, j] * 0.25;
                    else if(j==2)
                        temp2[i, j] = temp[i, j] * 0.15;
                    else if (j==3)
                        temp2[i, j] = temp[i, j] * 0.1;
                    else if(j==4)
                        temp2[i, j] = temp[i, j] * 0.25;
                    else if(j==5)
                        temp2[i, j] = temp[i, j] * 0.25;

                    Debug.Write(" " + temp2[i, j]);
                }

                Debug.WriteLine("");
            }

            Debug.WriteLine("");

            //penjumlahan kriteria beserta bobot
            for (i = 1; i <= bts.M; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    temp2[i, j + 1] = temp2[i, j + 1] + temp2[i, j];
                    
                }
                temporary[i] = temp2[i, 5];
                Debug.WriteLine(" "+temp2[i,5]);
            }
            Debug.WriteLine("");
            
            
            while (true)
            {
                
                DataRow dr = dt.NewRow();
                k++;
                if (k > bts.M)
                {
                    c = 1;
                    break;
                }
                FirebaseResponse resAkun = await client.GetTaskAsync("User_Account/" + k);
                Data data = resAkun.ResultAs<Data>();
                dr["Nama"] = data.namaDepan + " " + data.namaBelakang;
                dr["NIP"] = data.nip;
                dr["Pangkat/Gol"] = data.pangkatGol;
                dr["Sekolah Mengajar"] = data.sekolah;
                dr["Mapel"] = data.mapel;
                dr["Nilai Akhir"] = temporary[k];
                dt.Rows.Add(dr);
                c = 1;
            }
            if (c == 1)
            {
                k = 0;
                while (true)
                {
                    k++;
                    if (k > bts.M)
                        break;
                    FirebaseResponse resAkun = await client.GetTaskAsync("User_Account/" + k);
                    Data data = resAkun.ResultAs<Data>();
                    DataGridViewRow dgv = dataGridView1.Rows[k-1];
                    if(dgv.Index < 3)
                    {
                        dgv.DefaultCellStyle.BackColor = Color.Green;
                    }
                    var nilaiFix = new Ranked
                    {
                        nama = dgv.Cells[0].Value.ToString(),
                        nip = dgv.Cells[1].Value.ToString(),
                        PangkatGol = dgv.Cells[2].Value.ToString(),
                        sekolah = dgv.Cells[3].Value.ToString(),
                        mapel = dgv.Cells[4].Value.ToString(),
                        nilaiAkhir = Convert.ToSingle(dgv.Cells[5].Value)
                    };
                    var hit = new RankCount
                    {
                        count = bts.M
                    };
                    SetResponse pushNilai = await client.SetTaskAsync("Ranking/" + k, nilaiFix);
                    Ranked push = pushNilai.ResultAs<Ranked>();
                    FirebaseResponse countUpdate = await client.UpdateTaskAsync("Count",hit);
                    RankCount hitUpdate = countUpdate.ResultAs<RankCount>();
                }
                FirebaseResponse realTime = await client.GetTaskAsync("Ranking/"+bts.M);
                if(realTime.ResultAs<Ranked>() == null)
                {
                    pictureBox1.Visible = true;
                    label3.Visible = true;
                }
                    pictureBox1.Visible = false;
                    label3.Visible = false;

            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            dt2.Rows.Clear();
            int i = 0;
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = await client.GetTaskAsync("Counter");
            counter ctn = response.ResultAs<counter>();
            while (true)
            {
                i++;
                if (i > ctn.M)
                {
                    break;
                }

                FirebaseResponse responseNilai = await client.GetTaskAsync("Penilaian/" + i);
                Penilaian obj = responseNilai.ResultAs<Penilaian>();
                DataRow dr = dt2.NewRow();
                dr["Nama"] = obj.nama;
                dr["NIP"] = obj.nip;
                dr["Dokumen Portofolio"] = obj.C5;
                dr["Kinerja Guru"] = obj.C2;
                dr["Presentasi Best Practice"] = obj.C3;
                dr["Wawancara"] = obj.C4;
                dr["Test Tulis"] = obj.C1;
                dt2.Rows.Add(dr);
            }
        }

        public void loadgrid2()
        {
            dt2.Columns.Add("Nama");
            dt2.Columns.Add("NIP");
            dt2.Columns.Add("Dokumen Portofolio");
            dt2.Columns.Add("Kinerja Guru");
            dt2.Columns.Add("Presentasi Best Practice");
            dt2.Columns.Add("Wawancara");
            dt2.Columns.Add("Test Tulis");
            dataGridView2.DataSource = dt2;

            dataGridView2.Columns["Nama"].Width = 150;
            dataGridView2.Columns["NIP"].Width = 128;
            dataGridView2.Columns["Presentasi Best Practice"].Width = 200;
            dataGridView2.Columns["Dokumen Portofolio"].Width = 180;
            dataGridView2.Columns["Kinerja Guru"].Width = 150;
            dataGridView2.Columns["Test Tulis"].Width = 120;
        }

        public void loadgrid1()
        {
            dt.Columns.Add("Nama");
            dt.Columns.Add("NIP");
            dt.Columns.Add("Pangkat/Gol");
            dt.Columns.Add("Sekolah Mengajar");
            dt.Columns.Add("Mapel");
            dt.Columns.Add("Nilai Akhir");
            dataGridView1.DataSource = dt;

            dataGridView1.Columns["Nama"].Width = 250;
            dataGridView1.Columns["NIP"].Width = 200;
            dataGridView1.Columns["Pangkat/Gol"].Width = 200;
            dataGridView1.Columns["Sekolah Mengajar"].Width = 200;
            dataGridView1.Columns["Mapel"].Width = 200;
        }

        private async void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView2.CurrentRow != null)
            {
                string awal, akhir;
                IFirebaseClient client = new FireSharp.FirebaseClient(config);
                DataGridViewRow dgv = dataGridView2.CurrentRow;
                int i = dgv.Index + 1;
                FirebaseResponse resPenilan = await client.GetTaskAsync("User_Account/" + i);
                Data ambil = resPenilan.ResultAs<Data>();
                string[] returnedArray = dgv.Cells[0].Value.ToString().Split(new[] {' '},2);
                awal = returnedArray[0];
                akhir = returnedArray[1];

                var data = new Data
                {
                    namaDepan = awal,
                    namaBelakang = akhir,
                    nip = dgv.Cells[1].Value.ToString(),
                    tglLahir = ambil.tglLahir,
                    pangkatGol = ambil.pangkatGol,
                    sekolah =ambil.sekolah,
                    mapel = ambil.mapel,
                    username = ambil.username,
                    pwd = ambil.pwd
                };

                var nilai = new Penilaian
                {
                    nama = dgv.Cells[0].Value.ToString(),
                    nip = dgv.Cells[1].Value.ToString(),
                    username = ambil.username,
                    C1 = Convert.ToSingle(dgv.Cells[6].Value),
                    C2 = Convert.ToSingle(dgv.Cells[3].Value),
                    C3 = Convert.ToSingle(dgv.Cells[4].Value),
                    C4 = Convert.ToSingle(dgv.Cells[5].Value),
                    C5 = Convert.ToSingle(dgv.Cells[2].Value),
                };
                FirebaseResponse response1 = await client.UpdateTaskAsync("User_Account/" + i, data);
                Data data1 = response1.ResultAs<Data>();

                FirebaseResponse response2 = await client.UpdateTaskAsync("Penilaian/" + i, nilai);
                Penilaian penNilai = response2.ResultAs<Penilaian>();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgv = dataGridView2.CurrentRow;
            int i = dgv.Index + 1;
            var der = new DialogEditRanking(i);
            der.ShowDialog();
        }
    }
}
