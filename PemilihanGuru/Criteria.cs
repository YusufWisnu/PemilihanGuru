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
    public partial class Criteria : UserControl
    {
        DataTable dt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };

        public Criteria()
        {
            InitializeComponent();
        }

        private static Criteria _instance;
        public static Criteria Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Criteria();
                return _instance;
            }

        }

        private async void Criteria_Load(object sender, EventArgs e)
        {
            int i = 0;
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            dt.Columns.Add("Nama Kriteria");
            dt.Columns.Add("Nilai Kriteria");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Nama Kriteria"].Width = 700;

            while (true)
            {
                i++;
                if (i > 5)
                    break;
                FirebaseResponse response = await client.GetTaskAsync("Kriteria/"+i);
                Bobot bobot = response.ResultAs<Bobot>();
                DataRow dr = dt.NewRow();
                dr["Nama Kriteria"] = bobot.Nama;
                dr["Nilai Kriteria"] = bobot.Nilai;
                dt.Rows.Add(dr);
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //Edit Button
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgv = dataGridView1.CurrentRow;
            int i = dgv.Index + 1;
            var dec = new DialogEditCriteria(i);
            dec.ShowDialog();
        }

        //Refresh Button
        private async void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            int i = 0;
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            while (true)
            {
                i++;
                if (i > 5)
                    break;
                FirebaseResponse response = await client.GetTaskAsync("Kriteria/" + i);
                Bobot bobot = response.ResultAs<Bobot>();
                DataRow dr = dt.NewRow();
                dr["Nama Kriteria"] = bobot.Nama;
                dr["Nilai Kriteria"] = bobot.Nilai;
                dt.Rows.Add(dr);
            }
        }

        private async void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow dgv = dataGridView1.CurrentRow;
                int i = dgv.Index + 1;
                var gantiBobot = new Bobot
                {
                    Nama = dgv.Cells[0].Value.ToString(),
                    Nilai = Convert.ToSingle(dgv.Cells[1].Value)
                };
                
                FirebaseResponse resBobot = await client.UpdateTaskAsync("Kriteria/" + i,gantiBobot);
                Bobot updt = resBobot.ResultAs<Bobot>();
            }
        }
    }
}
