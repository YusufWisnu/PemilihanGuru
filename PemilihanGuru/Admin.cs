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
using System.Windows.Forms.DataVisualization.Charting;

namespace PemilihanGuru
{
    public partial class Admin : Form
    {
        int warna = 0;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };
        IFirebaseClient client;

        public Admin()
        {
            InitializeComponent();
        }

        private async void Admin_Load(object sender, EventArgs e)
        {
            
            if (!panel8.Controls.Contains(panel9))
            {
                panel8.Controls.Add(panel9);
                panel9.BringToFront();
            }
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = await client.GetTaskAsync("Counter");
            counter ctn = response.ResultAs<counter>();
            label3.Text = ctn.M.ToString();
            grafik();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panel8.Controls.Contains(panel9))
            {
                panel8.Controls.Clear();
                panel8.Controls.Add(panel9);
                panel9.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!panel8.Controls.Contains(user.Instance))
            {
                panel8.Controls.Clear();
                panel8.Controls.Add(user.Instance);
                user.Instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel8.Controls.Contains(ranking.Instance))
            {
                panel8.Controls.Clear();
                panel8.Controls.Add(ranking.Instance);
                ranking.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel8.Controls.Contains(Criteria.Instance))
            {
                panel8.Controls.Clear();
                panel8.Controls.Add(Criteria.Instance);
                Criteria.Instance.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        public async void grafik()
        {
            int i = 0;
            int a = 0; int h = 0;
            int b = 0; int n = 0;
            int c = 0; int j = 0;
            int d = 0; int k = 0;
            int e = 0; int l = 0;
            int f = 0; int m = 0;
            int g = 0; int o = 0;
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse resCtn = await client.GetTaskAsync("Count");
            RankCount ctn = resCtn.ResultAs<RankCount>();
            chart1.Series["Series1"].Label = "#PERCENT";


            while (true)
            {
                i++;
                if (i > 10)
                    break;
                FirebaseResponse response = await client.GetTaskAsync("Ranking/" + i);
                Ranked rank = response.ResultAs<Ranked>();
                if (rank.mapel == "Matematika")
                    a += 1;
                else if (rank.mapel == "Biologi")
                    b += 1;
                else if (rank.mapel == "Bahasa Inggris")
                    c += 1;
                else if (rank.mapel == "Fisika")
                    d += 1;
                else if (rank.mapel == "Kimia")
                    e += 1;
                else if (rank.mapel == "Bahasa Indonesia")
                    f += 1;
                else if (rank.mapel == "Sejarah")
                    g += 1;
                else if (rank.mapel == "Geografi")
                    h += 1;
                else if (rank.mapel == "Sosiologi dan Anthropologi")
                    j += 1;
                else if (rank.mapel == "Ekonomi")
                    k += 1;
                else if (rank.mapel == "Agama Islam")
                    l += 1;
                else if (rank.mapel == "Pendidikan Pancasila dan Kewarganegaraan")
                    m += 1;
                else if (rank.mapel == "Seni Budaya")
                    n += 1;
                else if (rank.mapel == "Pendidikan Jasmani, Olahraga dan Kebugaran")
                    o += 1;
            }

            chart1.Series["Series1"].Points.AddY(a);
            chart1.Series["Series1"].Points.AddY(b);
            chart1.Series["Series1"].Points.AddY(c);
            chart1.Series["Series1"].Points.AddY(d);
            chart1.Series["Series1"].Points.AddY(e);
            chart1.Series["Series1"].Points.AddY(f);
            chart1.Series["Series1"].Points.AddY(g);
            chart1.Series["Series1"].Points.AddY(h);
            chart1.Series["Series1"].Points.AddY(j);
            chart1.Series["Series1"].Points.AddY(k);
            chart1.Series["Series1"].Points.AddY(l);
            chart1.Series["Series1"].Points.AddY(m);
            chart1.Series["Series1"].Points.AddY(n);
            chart1.Series["Series1"].Points.AddY(o);
            chart1.Series["Series1"].Points[0].LegendText = "Matematika";
            chart1.Series["Series1"].Points[1].LegendText = "Biologi";
            chart1.Series["Series1"].Points[2].LegendText = "Bahasa Inggris";
            chart1.Series["Series1"].Points[3].LegendText = "Fisika";
            chart1.Series["Series1"].Points[5].LegendText = "Kimia";
            chart1.Series["Series1"].Points[4].LegendText = "Bahasa Indonesia";
            chart1.Series["Series1"].Points[6].LegendText = "Sejarah";
            chart1.Series["Series1"].Points[7].LegendText = "Geografi";
            chart1.Series["Series1"].Points[8].LegendText = "Sosiologi dan Anthropologi";
            chart1.Series["Series1"].Points[9].LegendText = "Ekonomi";
            chart1.Series["Series1"].Points[10].LegendText = "Agama Islam";
            chart1.Series["Series1"].Points[11].LegendText = "Pendidikan Pancasila dan Kewarganegaraan";
            chart1.Series["Series1"].Points[12].LegendText = "Seni Budaya";
            chart1.Series["Series1"].Points[13].LegendText = "Pendidikan Jasmani, Olahraga dan Kebugaran";

            foreach (DataPoint dp in chart1.Series["Series1"].Points)
            {
                if (dp.YValues.Length > 0 && (double)dp.YValues.GetValue(0) == 0)
                {
                    dp.IsValueShownAsLabel = false;
                    dp.Label = "";
                }
                else
                {
                    dp.IsValueShownAsLabel = true;
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X + 5, label1.Location.Y);
            if(label1.Location.X > this.Width)
            {
                label1.Location = new Point(0 - label1.Width, label1.Location.Y);
                
            }
            if(warna == 0)
            {
                label1.ForeColor = Color.PaleGoldenrod;
                warna = 1;
            }
            else if(warna == 1)
            {
                label1.ForeColor = SystemColors.Highlight;
                warna = 2;
            }
            else
            {
                label1.ForeColor = Color.Black;
                warna = 0;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            panel8.Controls.Clear();
            panel8.Controls.Add(user.Instance);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel8.Controls.Clear();
            panel8.Controls.Add(user.Instance);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel8.Controls.Clear();
            panel8.Controls.Add(user.Instance);
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private async void button1_MouseUp(object sender, MouseEventArgs e)
        {
            label3.Text = "";
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = await client.GetTaskAsync("Counter");
            counter ctn1 = response.ResultAs<counter>();
            label3.Text = ctn1.M.ToString();

            int i = 0;
            int a = 0; int h = 0;
            int b = 0; int n = 0;
            int c = 0; int j = 0;
            int d = 0; int k = 0;
            int p = 0; int l = 0;
            int f = 0; int m = 0;
            int g = 0; int o = 0;
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse resCtn = await client.GetTaskAsync("Count");
            RankCount ctn = resCtn.ResultAs<RankCount>();
            chart1.Series["Series1"].Label = "#PERCENT";
            chart1.Series["Series1"].Points[0].SetValueY(0);
            chart1.Series["Series1"].Points[1].SetValueY(0);
            chart1.Series["Series1"].Points[2].SetValueY(0);
            chart1.Series["Series1"].Points[3].SetValueY(0);
            chart1.Series["Series1"].Points[4].SetValueY(0);
            chart1.Series["Series1"].Points[5].SetValueY(0);
            chart1.Series["Series1"].Points[6].SetValueY(0);
            chart1.Series["Series1"].Points[7].SetValueY(0);
            chart1.Series["Series1"].Points[8].SetValueY(0);
            chart1.Series["Series1"].Points[9].SetValueY(0);
            chart1.Series["Series1"].Points[10].SetValueY(0);
            chart1.Series["Series1"].Points[11].SetValueY(0);
            chart1.Series["Series1"].Points[12].SetValueY(0);
            chart1.Series["Series1"].Points[13].SetValueY(0);

            while (true)
            {
                i++;
                if (i > 10)
                    break;
                FirebaseResponse response1 = await client.GetTaskAsync("Ranking/" + i);
                Ranked rank = response1.ResultAs<Ranked>();
                if (rank.mapel == "Matematika")
                    a += 1;
                else if (rank.mapel == "Biologi")
                    b += 1;
                else if (rank.mapel == "Bahasa Inggris")
                    c += 1;
                else if (rank.mapel == "Fisika")
                    d += 1;
                else if (rank.mapel == "Kimia")
                    p += 1;
                else if (rank.mapel == "Bahasa Indonesia")
                    f += 1;
                else if (rank.mapel == "Sejarah")
                    g += 1;
                else if (rank.mapel == "Geografi")
                    h += 1;
                else if (rank.mapel == "Sosiologi dan Anthropologi")
                    j += 1;
                else if (rank.mapel == "Ekonomi")
                    k += 1;
                else if (rank.mapel == "Agama Islam")
                    l += 1;
                else if (rank.mapel == "Pendidikan Pancasila dan Kewarganegaraan")
                    m += 1;
                else if (rank.mapel == "Seni Budaya")
                    n += 1;
                else if (rank.mapel == "Pendidikan Jasmani, Olahraga dan Kebugaran")
                    o += 1;
            }

            chart1.Series["Series1"].Points[0].SetValueY(a);
            chart1.Series["Series1"].Points[1].SetValueY(b);
            chart1.Series["Series1"].Points[2].SetValueY(c);
            chart1.Series["Series1"].Points[3].SetValueY(d);
            chart1.Series["Series1"].Points[4].SetValueY(p);
            chart1.Series["Series1"].Points[5].SetValueY(f);
            chart1.Series["Series1"].Points[6].SetValueY(g);
            chart1.Series["Series1"].Points[7].SetValueY(h);
            chart1.Series["Series1"].Points[8].SetValueY(j);
            chart1.Series["Series1"].Points[9].SetValueY(k);
            chart1.Series["Series1"].Points[10].SetValueY(l);
            chart1.Series["Series1"].Points[11].SetValueY(m);
            chart1.Series["Series1"].Points[12].SetValueY(n);
            chart1.Series["Series1"].Points[13].SetValueY(o);

            foreach (DataPoint dp in chart1.Series["Series1"].Points)
            {
                if (dp.YValues.Length > 0 && (double)dp.YValues.GetValue(0) == 0)
                {
                    dp.IsValueShownAsLabel = false;
                    dp.Label = "";
                }
                else
                {
                    dp.IsValueShownAsLabel = true;
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panel8.Controls.Clear();
            var login = new Login();
            login.Show();
            this.Close();
        }
    }
}
