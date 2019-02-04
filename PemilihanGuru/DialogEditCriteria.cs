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
    public partial class DialogEditCriteria : Form
    {
    
        public int baris { get; set; }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };
        public DialogEditCriteria()
        {
            InitializeComponent();
        }
        public DialogEditCriteria(int _baris)
            :this()
        {
            this.baris = _baris;
        }

        private async void DialogEditCriteria_Load(object sender, EventArgs e)
        {
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = await client.GetTaskAsync("Kriteria/" + baris);
            Bobot bobot = response.ResultAs<Bobot>();
            label1.Text = bobot.Nama;
            textBox1.Text = bobot.Nilai.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IFirebaseClient client = new FireSharp.FirebaseClient(config);
                var bobot = new Bobot
                {
                    Nama = label1.Text,
                    Nilai = Convert.ToSingle(textBox1.Text)
                };
                FirebaseResponse update = await client.UpdateTaskAsync("Kriteria/" + baris, bobot);
                Bobot updateBobot = update.ResultAs<Bobot>();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
