using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;

namespace PemilihanGuru
{
    public partial class Soal : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };
        IFirebaseClient client;

        string username;
        SoalSelesai ss;
        System.Timers.Timer t;
        int m = 1;
        int s;
        public static double nilai { get; set; }
        public static int finish { get; set; }

        public Soal()
        {
            InitializeComponent();
        }

        public Soal(string _username)
            :this()
        {
            this.username = _username;
        }

        private void Soal_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            nilai = 0;
            finish = 0;
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            t.Start();
            label6.Text = "SOAL NO: 1";
            panel4.Location = new System.Drawing.Point(874, 1000);
            panel2.Location = new System.Drawing.Point(1758, 125);
            panel3.Location = new System.Drawing.Point(1639, 125);
            panel6.Location = new System.Drawing.Point(25, 200);
            panel7.Location = new System.Drawing.Point(1910, 225);
            panel6.Size = new System.Drawing.Size(1780, 780);
            button3.Location = new System.Drawing.Point(1817, 225);
            button1.Location = new System.Drawing.Point(1671, 1000);
            button2.Location = new System.Drawing.Point(50, 1000);
            button2.Visible = false;
            button20.Location = new System.Drawing.Point(1671, 1000);
            button20.Visible = false;

            if (!panel6.Controls.Contains(no1.Instance))
            {
                panel6.Controls.Add(no1.Instance);
                no1.Instance.BringToFront();
            }
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            if (IsHandleCreated)
            {
            Invoke(new Action(() =>
            {
                s -= 1;
                if (s < 0)
                {
                    s = 59;
                    m -= 1;
                }
                label2.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            if ((m == 0 && s == 0))
                {
                    ss = new SoalSelesai();
                    t.Stop();
                    MessageBox.Show("Waktu Telah habis");
                    waktuHabis();
                    this.Close();
                    ss.Show();
                }
            }));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                panel6.Controls.Remove(no1.Instance);
                panel6.Controls.Add(no2.Instance);
                no2.Instance.BringToFront();
                label6.Text = "SOAL NO: 2";
                button2.Visible = true;
                if (button5.BackColor == Color.White || button5.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no2.Instance))
            {
                panel6.Controls.Remove(no2.Instance);
                panel6.Controls.Add(no3.Instance);
                no3.Instance.BringToFront();
                label6.Text = "SOAL NO: 3";
                if (button6.BackColor == Color.White || button6.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no3.Instance))
            {
                panel6.Controls.Remove(no3.Instance);
                panel6.Controls.Add(no4.Instance);
                no4.Instance.BringToFront();
                label6.Text = "SOAL NO: 4";
                if (button7.BackColor == Color.White || button7.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no4.Instance))
            {
                panel6.Controls.Remove(no4.Instance);
                panel6.Controls.Add(no5.Instance);
                no5.Instance.BringToFront();
                label6.Text = "SOAL NO: 5";
                if (button8.BackColor == Color.White || button8.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no5.Instance))
            {
                panel6.Controls.Remove(no5.Instance);
                panel6.Controls.Add(no6.Instance);
                no6.Instance.BringToFront();
                label6.Text = "SOAL NO: 6";
                if (button9.BackColor == Color.White || button9.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no6.Instance))
            {
                panel6.Controls.Remove(no6.Instance);
                panel6.Controls.Add(no7.Instance);
                no7.Instance.BringToFront();
                label6.Text = "SOAL NO: 7";
                if (button10.BackColor == Color.White || button10.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no7.Instance))
            {
                panel6.Controls.Remove(no7.Instance);
                panel6.Controls.Add(no8.Instance);
                no8.Instance.BringToFront();
                label6.Text = "SOAL NO: 8";
                if (button11.BackColor == Color.White || button11.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no8.Instance))
            {
                panel6.Controls.Remove(no8.Instance);
                panel6.Controls.Add(no9.Instance);
                no9.Instance.BringToFront();
                label6.Text = "SOAL NO: 9";
                if (button12.BackColor == Color.White || button12.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no9.Instance))
            {
                panel6.Controls.Remove(no9.Instance);
                panel6.Controls.Add(no10.Instance);
                no10.Instance.BringToFront();
                label6.Text = "SOAL NO: 10";
                if (button13.BackColor == Color.White || button13.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no10.Instance))
            {
                panel6.Controls.Remove(no10.Instance);
                panel6.Controls.Add(no11.Instance);
                no11.Instance.BringToFront();
                label6.Text = "SOAL NO: 11";
                if (button14.BackColor == Color.White || button14.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no11.Instance))
            {
                panel6.Controls.Remove(no11.Instance);
                panel6.Controls.Add(no12.Instance);
                no12.Instance.BringToFront();
                label6.Text = "SOAL NO: 12";
                if (button15.BackColor == Color.White || button15.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no12.Instance))
            {
                panel6.Controls.Remove(no12.Instance);
                panel6.Controls.Add(no13.Instance);
                no13.Instance.BringToFront();
                label6.Text = "SOAL NO: 13";
                if (button16.BackColor == Color.White || button16.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no13.Instance))
            {
                panel6.Controls.Remove(no13.Instance);
                panel6.Controls.Add(no14.Instance);
                no14.Instance.BringToFront();
                label6.Text = "SOAL NO: 14";
                if (button17.BackColor == Color.White || button17.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no14.Instance))
            {
                panel6.Controls.Remove(no14.Instance);
                panel6.Controls.Add(no15.Instance);
                no15.Instance.BringToFront();
                label6.Text = "SOAL NO: 15";
                button1.Visible = false;
                if (button18.BackColor == Color.White || button18.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no2.Instance))
            {
                panel6.Controls.Remove(no2.Instance);
                panel6.Controls.Add(no1.Instance);
                no1.Instance.BringToFront();
                label6.Text = "SOAL NO: 1";
                button2.Visible = false;
                if (button4.BackColor == Color.White || button4.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no3.Instance))
            {
                panel6.Controls.Remove(no3.Instance);
                panel6.Controls.Add(no2.Instance);
                no2.Instance.BringToFront();
                label6.Text = "SOAL NO: 2";
                if (button5.BackColor == Color.White || button5.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no4.Instance))
            {
                panel6.Controls.Remove(no4.Instance);
                panel6.Controls.Add(no3.Instance);
                no3.Instance.BringToFront();
                label6.Text = "SOAL NO: 3";
                if (button6.BackColor == Color.White || button6.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no5.Instance))
            {
                panel6.Controls.Remove(no5.Instance);
                panel6.Controls.Add(no4.Instance);
                no4.Instance.BringToFront();
                label6.Text = "SOAL NO: 4";
                if (button7.BackColor == Color.White || button7.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no6.Instance))
            {
                panel6.Controls.Remove(no6.Instance);
                panel6.Controls.Add(no5.Instance);
                no5.Instance.BringToFront();
                label6.Text = "SOAL NO: 5";
                if (button8.BackColor == Color.White || button8.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no7.Instance))
            {
                panel6.Controls.Remove(no7.Instance);
                panel6.Controls.Add(no6.Instance);
                no6.Instance.BringToFront();
                label6.Text = "SOAL NO: 6";
                if (button9.BackColor == Color.White || button9.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no8.Instance))
            {
                panel6.Controls.Remove(no8.Instance);
                panel6.Controls.Add(no7.Instance);
                no7.Instance.BringToFront();
                label6.Text = "SOAL NO: 7";
                if (button10.BackColor == Color.White || button10.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no9.Instance))
            {
                panel6.Controls.Remove(no9.Instance);
                panel6.Controls.Add(no8.Instance);
                no8.Instance.BringToFront();
                label6.Text = "SOAL NO: 8";
                if (button11.BackColor == Color.White || button11.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no10.Instance))
            {
                panel6.Controls.Remove(no10.Instance);
                panel6.Controls.Add(no9.Instance);
                no9.Instance.BringToFront();
                label6.Text = "SOAL NO: 9";
                if (button12.BackColor == Color.White || button12.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no11.Instance))
            {
                panel6.Controls.Remove(no11.Instance);
                panel6.Controls.Add(no10.Instance);
                no10.Instance.BringToFront();
                label6.Text = "SOAL NO: 10";
                if (button13.BackColor == Color.White || button13.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no12.Instance))
            {
                panel6.Controls.Remove(no12.Instance);
                panel6.Controls.Add(no11.Instance);
                no11.Instance.BringToFront();
                label6.Text = "SOAL NO: 11";
                if (button14.BackColor == Color.White || button14.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no13.Instance))
            {
                panel6.Controls.Remove(no13.Instance);
                panel6.Controls.Add(no12.Instance);
                no12.Instance.BringToFront();
                label6.Text = "SOAL NO: 12";
                if (button15.BackColor == Color.White || button15.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no14.Instance))
            {
                panel6.Controls.Remove(no14.Instance);
                panel6.Controls.Add(no13.Instance);
                no13.Instance.BringToFront();
                label6.Text = "SOAL NO: 13";
                if (button16.BackColor == Color.White || button16.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                panel6.Controls.Remove(no15.Instance);
                panel6.Controls.Add(no14.Instance);
                no14.Instance.BringToFront();
                label6.Text = "SOAL NO: 14";
                button1.Visible = true;
                if (button17.BackColor == Color.White || button17.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
        }

        //checked RAGU-RAGU
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (panel6.Controls.Contains(no1.Instance))
                {
                    if (button4.BackColor == SystemColors.Highlight)
                        button4.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no2.Instance))
                {
                    if (button5.BackColor == SystemColors.Highlight)
                        button5.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no3.Instance))
                {
                    if (button6.BackColor == SystemColors.Highlight)
                        button6.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no4.Instance))
                {
                    if (button7.BackColor == SystemColors.Highlight)
                        button7.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no5.Instance))
                {
                    if (button8.BackColor == SystemColors.Highlight)
                        button8.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no6.Instance))
                {
                    if (button9.BackColor == SystemColors.Highlight)
                        button9.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no7.Instance))
                {
                    if (button10.BackColor == SystemColors.Highlight)
                        button10.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no8.Instance))
                {
                    if (button11.BackColor == SystemColors.Highlight)
                        button11.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no9.Instance))
                {
                    if (button12.BackColor == SystemColors.Highlight)
                        button12.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no10.Instance))
                {
                    if (button13.BackColor == SystemColors.Highlight)
                        button13.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no11.Instance))
                {
                    if (button14.BackColor == SystemColors.Highlight)
                        button14.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no12.Instance))
                {
                    if (button15.BackColor == SystemColors.Highlight)
                        button15.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no13.Instance))
                {
                    if (button16.BackColor == SystemColors.Highlight)
                        button16.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no14.Instance))
                {
                    if (button17.BackColor == SystemColors.Highlight)
                        button17.BackColor = Color.Orange;
                }
                else if (panel6.Controls.Contains(no15.Instance))
                {
                    if (button18.BackColor == SystemColors.Highlight)
                        button18.BackColor = Color.Orange;
                }
            }
            else if (checkBox1.Checked == false)
            {
                if (panel6.Controls.Contains(no1.Instance))
                {
                    if (button4.BackColor == Color.Orange)
                        button4.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no2.Instance))
                {
                    if (button5.BackColor == Color.Orange)
                        button5.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no3.Instance))
                {
                    if (button6.BackColor == Color.Orange)
                        button6.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no4.Instance))
                {
                    if (button7.BackColor == Color.Orange)
                        button7.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no5.Instance))
                {
                    if (button8.BackColor == Color.Orange)
                        button8.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no6.Instance))
                {
                    if (button9.BackColor == Color.Orange)
                        button9.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no7.Instance))
                {
                    if (button10.BackColor == Color.Orange)
                        button10.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no8.Instance))
                {
                    if (button11.BackColor == Color.Orange)
                        button11.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no9.Instance))
                {
                    if (button12.BackColor == Color.Orange)
                        button12.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no10.Instance))
                {
                    if (button13.BackColor == Color.Orange)
                        button13.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no11.Instance))
                {
                    if (button14.BackColor == Color.Orange)
                        button14.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no12.Instance))
                {
                    if (button15.BackColor == Color.Orange)
                        button15.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no13.Instance))
                {
                    if (button16.BackColor == Color.Orange)
                        button16.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no14.Instance))
                {
                    if (button17.BackColor == Color.Orange)
                        button17.BackColor = SystemColors.Highlight;
                }
                else if (panel6.Controls.Contains(no15.Instance))
                {
                    if (button18.BackColor == Color.Orange)
                        button18.BackColor = SystemColors.Highlight;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button3.Location = new System.Drawing.Point(1606, 225);
            button19.Location = new System.Drawing.Point(1669, 225);
            button19.Visible = true;
            button3.Visible = false;
            panel7.Location = new System.Drawing.Point(1710, 225);
            panel7.Size = new System.Drawing.Size(200, 250);
            panel7.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Visible = false;
            button3.Visible = true;
            panel7.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no15.Instance))
                button1.Visible = true;
            panel6.Controls.Clear();
            panel6.Controls.Add(no1.Instance);
            no1.Instance.BringToFront();
            label6.Text = "SOAL NO: 1";
            button2.Visible = false;
            if (button4.BackColor == Color.White || button4.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                button2.Visible = true;
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                button1.Visible = true;
            }
            panel6.Controls.Clear();
            panel6.Controls.Add(no2.Instance);
            no2.Instance.BringToFront();
            label6.Text = "SOAL NO: 2";
            if (button5.BackColor == Color.White || button5.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                button2.Visible = true;
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                button1.Visible = true;
            }
            panel6.Controls.Clear();
            panel6.Controls.Add(no3.Instance);
            no3.Instance.BringToFront();
            label6.Text = "SOAL NO: 3";
            if (button6.BackColor == Color.White || button6.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                button2.Visible = true;
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                button1.Visible = true;
            }
            panel6.Controls.Clear();
            panel6.Controls.Add(no4.Instance);
            no4.Instance.BringToFront();
            label6.Text = "SOAL NO: 4";
            if (button7.BackColor == Color.White || button7.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                button2.Visible = true;
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                button1.Visible = true;
            }
            panel6.Controls.Clear();
            panel6.Controls.Add(no5.Instance);
            no5.Instance.BringToFront();
            label6.Text = "SOAL NO: 5";
            if (button8.BackColor == Color.White || button8.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                button2.Visible = true;
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                button1.Visible = true;
            }
            panel6.Controls.Clear();
            panel6.Controls.Add(no6.Instance);
            no6.Instance.BringToFront();
            label6.Text = "SOAL NO: 6";
            if (button9.BackColor == Color.White || button9.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                button2.Visible = true;
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                button1.Visible = true;
            }
            panel6.Controls.Clear();
            panel6.Controls.Add(no7.Instance);
            no7.Instance.BringToFront();
            label6.Text = "SOAL NO: 7";
            if (button10.BackColor == Color.White || button10.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                button2.Visible = true;
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                button1.Visible = true;
            }
            panel6.Controls.Clear();
            panel6.Controls.Add(no8.Instance);
            no8.Instance.BringToFront();
            label6.Text = "SOAL NO: 8";
            if (button11.BackColor == Color.White || button11.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                button2.Visible = true;
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                button1.Visible = true;
            }
            panel6.Controls.Clear();
            panel6.Controls.Add(no9.Instance);
            no9.Instance.BringToFront();
            label6.Text = "SOAL NO: 9";
            if (button12.BackColor == Color.White || button12.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                button2.Visible = true;
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                button1.Visible = true;
            }
            panel6.Controls.Clear();
            panel6.Controls.Add(no10.Instance);
            no10.Instance.BringToFront();
            label6.Text = "SOAL NO: 10";
            if (button13.BackColor == Color.White || button13.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                button2.Visible = true;
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                button1.Visible = true;
            }
            panel6.Controls.Clear();
            panel6.Controls.Add(no11.Instance);
            no11.Instance.BringToFront();
            label6.Text = "SOAL NO: 11";
            if (button14.BackColor == Color.White || button14.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                button2.Visible = true;
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                button1.Visible = true;
            }
            panel6.Controls.Clear();
            panel6.Controls.Add(no12.Instance);
            no12.Instance.BringToFront();
            label6.Text = "SOAL NO: 12";
            if (button15.BackColor == Color.White || button15.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                button2.Visible = true;
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                button1.Visible = true;
            }
            panel6.Controls.Clear();
            panel6.Controls.Add(no13.Instance);
            no13.Instance.BringToFront();
            label6.Text = "SOAL NO: 13";
            if (button16.BackColor == Color.White || button16.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
            {
                button2.Visible = true;
            }
            else if (panel6.Controls.Contains(no15.Instance))
            {
                button1.Visible = true;
            }
            panel6.Controls.Clear();
            panel6.Controls.Add(no14.Instance);
            no14.Instance.BringToFront();
            label6.Text = "SOAL NO: 14";
            if (button17.BackColor == Color.White || button17.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (panel6.Controls.Contains(no1.Instance))
                button2.Visible = true;
            panel6.Controls.Clear();
            panel6.Controls.Add(no15.Instance);
            no15.Instance.BringToFront();
            label6.Text = "SOAL NO: 15";
            button1.Visible = false;
            if (button18.BackColor == Color.White || button18.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void Soal_Click(object sender, EventArgs e)
        {

        }

        private void button4_EnabledChanged(object sender, EventArgs e)
        {

        }

        //start pewarnaan soal
        private void Soal_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button15_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button16_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button17_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button18_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }

            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            switch (finish)
            {
                case 1:
                    if (button4.BackColor == Color.Orange)
                    {
                        button4.BackColor = Color.Orange;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 2:
                    if (button5.BackColor == Color.Orange)
                    {
                        button5.BackColor = Color.Orange;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 3:
                    if (button6.BackColor == Color.Orange)
                    {
                        button6.BackColor = Color.Orange;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 4:
                    if (button7.BackColor == Color.Orange)
                    {
                        button7.BackColor = Color.Orange;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 5:
                    if (button8.BackColor == Color.Orange)
                    {
                        button8.BackColor = Color.Orange;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 6:
                    if (button9.BackColor == Color.Orange)
                    {
                        button9.BackColor = Color.Orange;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 7:
                    if (button10.BackColor == Color.Orange)
                    {
                        button10.BackColor = Color.Orange;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 8:
                    if (button11.BackColor == Color.Orange)
                    {
                        button11.BackColor = Color.Orange;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 9:
                    if (button12.BackColor == Color.Orange)
                    {
                        button12.BackColor = Color.Orange;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 10:
                    if (button13.BackColor == Color.Orange)
                    {
                        button13.BackColor = Color.Orange;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 11:
                    if (button14.BackColor == Color.Orange)
                    {
                        button14.BackColor = Color.Orange;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 12:
                    if (button15.BackColor == Color.Orange)
                    {
                        button15.BackColor = Color.Orange;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 13:
                    if (button16.BackColor == Color.Orange)
                    {
                        button16.BackColor = Color.Orange;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 14:
                    if (button17.BackColor == Color.Orange)
                    {
                        button17.BackColor = Color.Orange;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
                case 15:
                    if (button18.BackColor == Color.Orange)
                    {
                        button18.BackColor = Color.Orange;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.SystemColors.Highlight;
                    }
                    break;
            }
            if ((button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
                (button5.BackColor == Color.Orange || button5.BackColor == SystemColors.Highlight) &&
                (button6.BackColor == Color.Orange || button6.BackColor == SystemColors.Highlight) &&
                (button7.BackColor == Color.Orange || button7.BackColor == SystemColors.Highlight) &&
                (button8.BackColor == Color.Orange || button8.BackColor == SystemColors.Highlight) &&
                (button9.BackColor == Color.Orange || button9.BackColor == SystemColors.Highlight) &&
                (button10.BackColor == Color.Orange || button10.BackColor == SystemColors.Highlight) &&
                (button11.BackColor == Color.Orange || button11.BackColor == SystemColors.Highlight) &&
                (button12.BackColor == Color.Orange || button12.BackColor == SystemColors.Highlight) &&
                (button13.BackColor == Color.Orange || button13.BackColor == SystemColors.Highlight) &&
                (button14.BackColor == Color.Orange || button14.BackColor == SystemColors.Highlight) &&
                (button15.BackColor == Color.Orange || button15.BackColor == SystemColors.Highlight) &&
                (button16.BackColor == Color.Orange || button16.BackColor == SystemColors.Highlight) &&
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight) &&
                (button18.BackColor == Color.Orange || button18.BackColor == SystemColors.Highlight)
                )
            {
                button20.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private async void button20_Click(object sender, EventArgs e)
        {
            
            if (button4.BackColor == Color.Orange || button5.BackColor == Color.Orange ||
                button6.BackColor == Color.Orange || button7.BackColor == Color.Orange ||
                button8.BackColor == Color.Orange || button9.BackColor == Color.Orange ||
                button10.BackColor == Color.Orange || button11.BackColor == Color.Orange ||
                button12.BackColor == Color.Orange || button13.BackColor == Color.Orange ||
                button14.BackColor == Color.Orange || button15.BackColor == Color.Orange ||
                button16.BackColor == Color.Orange || button17.BackColor == Color.Orange ||
                button18.BackColor == Color.Orange)
            {
                MessageBox.Show("Harap Isi Semua Soal Dengan Tidak Ragu-Ragu", "Smart Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var dm = new ModalSoal(nilai, username);
                dm.ShowDialog();
            }


        }

        private void Soal_FormClosing(object sender, FormClosingEventArgs e)
        {
            m = 0;
            s = 0;
        }

        public async void waktuHabis()
        {
            int i = 0;
            double nilai2 = (nilai * 10) / 3;
            FirebaseResponse resCtn = await client.GetTaskAsync("Counter");
            counter ctn = resCtn.ResultAs<counter>();
            while (true)
            {
                i++;
                if (i > ctn.M)
                    break;

                FirebaseResponse resAkun = await client.GetTaskAsync("User_Account/" + i);
                Data dt = resAkun.ResultAs<Data>();
                if (username == dt.username)
                {
                    var hasil = new Penilaian
                    {
                        nama = dt.namaDepan + " " + dt.namaBelakang,
                        nip = dt.nip,
                        C1 = Convert.ToSingle(string.Format("{0:0.##}", nilai2)),
                        C2 = 0,
                        C3 = 0,
                        C4 = 0,
                        C5 = 0,
                        username = username
                    };
                    FirebaseResponse resUpdate = await client.UpdateTaskAsync("Penilaian/" + i, hasil);
                    Penilaian pen = resUpdate.ResultAs<Penilaian>();
                }
            }
        }
    }
}
