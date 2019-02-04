using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;


namespace PemilihanGuru
{
    public partial class Soal1 : Form
    {
        string username;
        System.Timers.Timer t;
        int m = 30;
        int s;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };
        IFirebaseClient client;
        public static double nilai { get; set; }
        public Soal1()
        {
            InitializeComponent();
        }

        public Soal1(string _username)
            :this()
        {
            this.username = _username;
        }
        private void Soal1_Load(object sender, EventArgs e)
        {
            
            desain();
            nilai = 0;
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            t.Start();
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
                    label4.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                    if ((m == 0 && s == 0))
                    {
                        var wh = new WaktuHabis(nilai, username);
                        t.Stop();
                        MessageBox.Show("Waktu Telah habis");
                        wh.ShowDialog();
                    }
                }));
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Visible = false;
            button19.Visible = true;
            panel5.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Visible = false;
            panel5.Visible = false;
            button18.Visible = true;
        }

        //button NEXT
        private void button1_Click(object sender, EventArgs e)
        {
            if (panel6.Visible == true)
            {
                button2.Visible = true;
                label5.Text = "Soal No : 2";
                panel6.Visible = false;
                panel7.Visible = true;
                if(button4.BackColor == Color.White || button4.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel7.Visible == true)
            {
                label5.Text = "Soal No : 3";
                panel7.Visible = false;
                panel8.Visible = true;
                if (button5.BackColor == Color.White || button5.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel8.Visible == true)
            {
                label5.Text = "Soal No : 4";
                panel8.Visible = false;
                panel9.Visible = true;
                if (button6.BackColor == Color.White || button6.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel9.Visible == true)
            {
                label5.Text = "Soal No : 5";
                panel9.Visible = false;
                panel10.Visible = true;
                if (button7.BackColor == Color.White || button7.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel10.Visible == true)
            {
                label5.Text = "Soal No : 6";
                panel10.Visible = false;
                panel11.Visible = true;
                if (button8.BackColor == Color.White || button8.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel11.Visible == true)
            {
                label5.Text = "Soal No : 7";
                panel11.Visible = false;
                panel12.Visible = true;
                if (button9.BackColor == Color.White || button9.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel12.Visible == true)
            {
                label5.Text = "Soal No : 8";
                panel12.Visible = false;
                panel13.Visible = true;
                if (button10.BackColor == Color.White || button10.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel13.Visible == true)
            {
                label5.Text = "Soal No : 9";
                panel13.Visible = false;
                panel14.Visible = true;
                if (button11.BackColor == Color.White || button11.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel14.Visible == true)
            {
                label5.Text = "Soal No : 10";
                panel14.Visible = false;
                panel15.Visible = true;
                if (button12.BackColor == Color.White || button12.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel15.Visible == true)
            {
                label5.Text = "Soal No : 11";
                panel15.Visible = false;
                panel16.Visible = true;
                if (button13.BackColor == Color.White || button13.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel16.Visible == true)
            {
                label5.Text = "Soal No : 12";
                panel16.Visible = false;
                panel17.Visible = true;
                if (button14.BackColor == Color.White || button14.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel17.Visible == true)
            {
                label5.Text = "Soal No : 13";
                panel17.Visible = false;
                panel18.Visible = true;
                if (button15.BackColor == Color.White || button15.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel18.Visible == true)
            {
                label5.Text = "Soal No : 14";
                panel18.Visible = false;
                panel19.Visible = true;
                if (button16.BackColor == Color.White || button16.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel19.Visible == true)
            {
                button1.Visible = false;
                label5.Text = "Soal No : 15";
                panel19.Visible = false;
                panel20.Visible = true;
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

        //button BEFORE
        private void button2_Click(object sender, EventArgs e)
        {
            if(panel7.Visible == true)
            {
                button2.Visible = false;
                label5.Text = "Soal No : 1";
                panel7.Visible = false;
                panel6.Visible = true;
                if (button3.BackColor == Color.White || button3.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if(panel8.Visible == true)
            {
                label5.Text = "Soal No : 2";
                panel8.Visible = false;
                panel7.Visible = true;
                if (button4.BackColor == Color.White || button4.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel9.Visible == true)
            {
                label5.Text = "Soal No : 3";
                panel9.Visible = false;
                panel8.Visible = true;
                if (button5.BackColor == Color.White || button5.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel10.Visible == true)
            {
                label5.Text = "Soal No : 4";
                panel10.Visible = false;
                panel9.Visible = true;
                if (button6.BackColor == Color.White || button6.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel11.Visible == true)
            {
                label5.Text = "Soal No : 5";
                panel11.Visible = false;
                panel10.Visible = true;
                if (button7.BackColor == Color.White || button7.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel12.Visible == true)
            {
                label5.Text = "Soal No : 6";
                panel12.Visible = false;
                panel11.Visible = true;
                if (button8.BackColor == Color.White || button8.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel13.Visible == true)
            {
                label5.Text = "Soal No : 7";
                panel13.Visible = false;
                panel12.Visible = true;
                if (button9.BackColor == Color.White || button9.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel14.Visible == true)
            {
                label5.Text = "Soal No : 8";
                panel14.Visible = false;
                panel13.Visible = true;
                if (button10.BackColor == Color.White || button10.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel15.Visible == true)
            {
                label5.Text = "Soal No : 9";
                panel15.Visible = false;
                panel14.Visible = true;
                if (button11.BackColor == Color.White || button11.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel16.Visible == true)
            {
                label5.Text = "Soal No : 10";
                panel16.Visible = false;
                panel15.Visible = true;
                if (button12.BackColor == Color.White || button12.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel17.Visible == true)
            {
                label5.Text = "Soal No : 11";
                panel17.Visible = false;
                panel16.Visible = true;
                if (button13.BackColor == Color.White || button13.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel18.Visible == true)
            {
                label5.Text = "Soal No : 12";
                panel18.Visible = false;
                panel17.Visible = true;
                if (button14.BackColor == Color.White || button14.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel19.Visible == true)
            {
                label5.Text = "Soal No : 13";
                panel19.Visible = false;
                panel18.Visible = true;
                if (button15.BackColor == Color.White || button15.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }
            else if (panel20.Visible == true)
            {
                button1.Visible = true;
                label5.Text = "Soal No : 14";
                panel20.Visible = false;
                panel19.Visible = true;
                if (button16.BackColor == Color.White || button16.BackColor == SystemColors.Highlight)
                {
                    checkBox1.Checked = false;
                }
                else
                {
                    checkBox1.Checked = true;
                }
            }

        }

        //checkbox RAGU_RAGU
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if(panel6.Visible == true)
                {
                    if (button3.BackColor == SystemColors.Highlight)
                        button3.BackColor = Color.Orange;
                }
                else if(panel7.Visible == true)
                {
                    if (button4.BackColor == SystemColors.Highlight)
                        button4.BackColor = Color.Orange;
                }
                else if (panel8.Visible == true)
                {
                    if (button5.BackColor == SystemColors.Highlight)
                        button5.BackColor = Color.Orange;
                }
                else if (panel9.Visible == true)
                {
                    if (button6.BackColor == SystemColors.Highlight)
                        button6.BackColor = Color.Orange;
                }
                else if (panel10.Visible == true)
                {
                    if (button7.BackColor == SystemColors.Highlight)
                        button7.BackColor = Color.Orange;
                }
                else if (panel11.Visible == true)
                {
                    if (button8.BackColor == SystemColors.Highlight)
                        button8.BackColor = Color.Orange;
                }
                else if (panel12.Visible == true)
                {
                    if (button9.BackColor == SystemColors.Highlight)
                        button9.BackColor = Color.Orange;
                }
                else if (panel13.Visible == true)
                {
                    if (button10.BackColor == SystemColors.Highlight)
                        button10.BackColor = Color.Orange;
                }
                else if (panel14.Visible == true)
                {
                    if (button11.BackColor == SystemColors.Highlight)
                        button11.BackColor = Color.Orange;
                }
                else if (panel15.Visible == true)
                {
                    if (button12.BackColor == SystemColors.Highlight)
                        button12.BackColor = Color.Orange;
                }
                else if (panel16.Visible == true)
                {
                    if (button13.BackColor == SystemColors.Highlight)
                        button13.BackColor = Color.Orange;
                }
                else if (panel17.Visible == true)
                {
                    if (button14.BackColor == SystemColors.Highlight)
                        button14.BackColor = Color.Orange;
                }
                else if (panel18.Visible == true)
                {
                    if (button15.BackColor == SystemColors.Highlight)
                        button15.BackColor = Color.Orange;
                }
                else if (panel19.Visible == true)
                {
                    if (button16.BackColor == SystemColors.Highlight)
                        button16.BackColor = Color.Orange;
                }
                else if (panel20.Visible == true)
                {
                    if (button17.BackColor == SystemColors.Highlight)
                        button17.BackColor = Color.Orange;
                }
            }
            else if(checkBox1.Checked == false)
            {
                if(panel6.Visible == true)
                {
                    if (button3.BackColor == Color.Orange)
                        button3.BackColor = SystemColors.Highlight;
                }
                else if(panel7.Visible == true)
                {
                    if (button4.BackColor == Color.Orange)
                        button4.BackColor = SystemColors.Highlight;
                }
                else if (panel8.Visible == true)
                {
                    if (button5.BackColor == Color.Orange)
                        button5.BackColor = SystemColors.Highlight;
                }
                else if (panel9.Visible == true)
                {
                    if (button6.BackColor == Color.Orange)
                        button6.BackColor = SystemColors.Highlight;
                }
                else if (panel10.Visible == true)
                {
                    if (button7.BackColor == Color.Orange)
                        button7.BackColor = SystemColors.Highlight;
                }
                else if (panel11.Visible == true)
                {
                    if (button8.BackColor == Color.Orange)
                        button8.BackColor = SystemColors.Highlight;
                }
                else if (panel12.Visible == true)
                {
                    if (button9.BackColor == Color.Orange)
                        button9.BackColor = SystemColors.Highlight;
                }
                else if (panel13.Visible == true)
                {
                    if (button10.BackColor == Color.Orange)
                        button10.BackColor = SystemColors.Highlight;
                }
                else if (panel14.Visible == true)
                {
                    if (button11.BackColor == Color.Orange)
                        button11.BackColor = SystemColors.Highlight;
                }
                else if (panel15.Visible == true)
                {
                    if (button12.BackColor == Color.Orange)
                        button12.BackColor = SystemColors.Highlight;
                }
                else if (panel16.Visible == true)
                {
                    if (button13.BackColor == Color.Orange)
                        button13.BackColor = SystemColors.Highlight;
                }
                else if (panel17.Visible == true)
                {
                    if (button14.BackColor == Color.Orange)
                        button14.BackColor = SystemColors.Highlight;
                }
                else if (panel18.Visible == true)
                {
                    if (button15.BackColor == Color.Orange)
                        button15.BackColor = SystemColors.Highlight;
                }
                else if (panel19.Visible == true)
                {
                    if (button16.BackColor == Color.Orange)
                        button16.BackColor = SystemColors.Highlight;
                }
                else if (panel20.Visible == true)
                {
                    if (button17.BackColor == Color.Orange)
                        button17.BackColor = SystemColors.Highlight;
                }
            }
        }

        public void desain()
        {
            button18.Location = new System.Drawing.Point(1823, 224);
            button21.Location = new System.Drawing.Point(1515, 957); 
            panel6.Location = new System.Drawing.Point(62, 200);
            panel7.Location = new System.Drawing.Point(62, 200);
            panel8.Location = new System.Drawing.Point(62, 200);
            panel9.Location = new System.Drawing.Point(62, 200);
            panel10.Location = new System.Drawing.Point(62, 200);
            panel11.Location = new System.Drawing.Point(62, 200);
            panel12.Location = new System.Drawing.Point(62, 200);
            panel13.Location = new System.Drawing.Point(62, 200);
            panel14.Location = new System.Drawing.Point(62, 200);
            panel15.Location = new System.Drawing.Point(62, 200);
            panel16.Location = new System.Drawing.Point(62, 200);
            panel17.Location = new System.Drawing.Point(62, 200);
            panel18.Location = new System.Drawing.Point(62, 200);
            panel19.Location = new System.Drawing.Point(62, 200);
            if (panel6.Visible == true)
            {
                label5.Text = "Soal No : 1";
            }

        }
        //Soal 1
        //jawaban benar
        private void radioButton4_Click(object sender, EventArgs e)
        {
            if (radioButton4.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton4.ForeColor = SystemColors.Highlight;
                radioButton1.ForeColor = SystemColors.ControlText;
                radioButton3.ForeColor = SystemColors.ControlText;
                radioButton5.ForeColor = SystemColors.ControlText;
                radioButton6.ForeColor = SystemColors.ControlText;
            }
            button3.BackColor = SystemColors.Highlight;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton1.ForeColor = SystemColors.Highlight;
                    radioButton3.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.ControlText;
                    radioButton6.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton4.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton4.ForeColor = SystemColors.ControlText;
                    radioButton1.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton6.ForeColor == SystemColors.ControlText || radioButton5.ForeColor == SystemColors.ControlText || radioButton3.ForeColor == SystemColors.ControlText)
                {
                    radioButton1.ForeColor = SystemColors.Highlight;
                    radioButton3.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.ControlText;
                    radioButton6.ForeColor = SystemColors.ControlText;
                }
                button3.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton3.ForeColor = SystemColors.Highlight;
                    radioButton1.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.ControlText;
                    radioButton6.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton4.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton4.ForeColor = SystemColors.ControlText;
                    radioButton3.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton6.ForeColor == SystemColors.ControlText || radioButton5.ForeColor == SystemColors.ControlText || radioButton1.ForeColor == SystemColors.ControlText)
                {
                    radioButton3.ForeColor = SystemColors.Highlight;
                    radioButton1.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.ControlText;
                    radioButton6.ForeColor = SystemColors.ControlText;
                }
                button3.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton5.ForeColor = SystemColors.Highlight;
                    radioButton3.ForeColor = SystemColors.ControlText;
                    radioButton1.ForeColor = SystemColors.ControlText;
                    radioButton6.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton4.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton4.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton6.ForeColor == SystemColors.ControlText || radioButton1.ForeColor == SystemColors.ControlText || radioButton3.ForeColor == SystemColors.ControlText)
                {
                    radioButton5.ForeColor = SystemColors.Highlight;
                    radioButton3.ForeColor = SystemColors.ControlText;
                    radioButton1.ForeColor = SystemColors.ControlText;
                    radioButton6.ForeColor = SystemColors.ControlText;
                }
                button3.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton6.ForeColor = SystemColors.Highlight;
                    radioButton3.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.ControlText;
                    radioButton1.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton4.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton4.ForeColor = SystemColors.ControlText;
                    radioButton6.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton1.ForeColor == SystemColors.ControlText || radioButton5.ForeColor == SystemColors.ControlText || radioButton3.ForeColor == SystemColors.ControlText)
                {
                    radioButton6.ForeColor = SystemColors.Highlight;
                    radioButton3.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.ControlText;
                    radioButton1.ForeColor = SystemColors.ControlText;
                }
                button3.BackColor = SystemColors.Highlight;
            }
        }
        //End Soal 1

        //Start Soal 2
        //jawaban benar
        private void radioButton9_Click(object sender, EventArgs e)
        {
            if (radioButton9.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton9.ForeColor = SystemColors.Highlight;
                radioButton7.ForeColor = SystemColors.ControlText;
                radioButton8.ForeColor = SystemColors.ControlText;
                radioButton10.ForeColor = SystemColors.ControlText;
                radioButton11.ForeColor = SystemColors.ControlText;
            }
            button4.BackColor = SystemColors.Highlight;
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton7.ForeColor = SystemColors.Highlight;
                    radioButton8.ForeColor = SystemColors.ControlText;
                    radioButton10.ForeColor = SystemColors.ControlText;
                    radioButton11.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton9.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton9.ForeColor = SystemColors.ControlText;
                    radioButton7.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton8.ForeColor == SystemColors.ControlText || radioButton10.ForeColor == SystemColors.ControlText || radioButton11.ForeColor == SystemColors.ControlText)
                {
                    radioButton7.ForeColor = SystemColors.Highlight;
                    radioButton8.ForeColor = SystemColors.ControlText;
                    radioButton10.ForeColor = SystemColors.ControlText;
                    radioButton11.ForeColor = SystemColors.ControlText;
                }
                button4.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton8.ForeColor = SystemColors.Highlight;
                    radioButton7.ForeColor = SystemColors.ControlText;
                    radioButton10.ForeColor = SystemColors.ControlText;
                    radioButton11.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton9.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton9.ForeColor = SystemColors.ControlText;
                    radioButton8.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton7.ForeColor == SystemColors.ControlText || radioButton10.ForeColor == SystemColors.ControlText || radioButton11.ForeColor == SystemColors.ControlText)
                {
                    radioButton8.ForeColor = SystemColors.Highlight;
                    radioButton7.ForeColor = SystemColors.ControlText;
                    radioButton10.ForeColor = SystemColors.ControlText;
                    radioButton11.ForeColor = SystemColors.ControlText;
                }
                button4.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton10.ForeColor = SystemColors.Highlight;
                    radioButton8.ForeColor = SystemColors.ControlText;
                    radioButton7.ForeColor = SystemColors.ControlText;
                    radioButton11.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton9.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton9.ForeColor = SystemColors.ControlText;
                    radioButton10.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton8.ForeColor == SystemColors.ControlText || radioButton7.ForeColor == SystemColors.ControlText || radioButton11.ForeColor == SystemColors.ControlText)
                {
                    radioButton10.ForeColor = SystemColors.Highlight;
                    radioButton8.ForeColor = SystemColors.ControlText;
                    radioButton7.ForeColor = SystemColors.ControlText;
                    radioButton11.ForeColor = SystemColors.ControlText;
                }
                button4.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton11_Click(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton11.ForeColor = SystemColors.Highlight;
                    radioButton8.ForeColor = SystemColors.ControlText;
                    radioButton10.ForeColor = SystemColors.ControlText;
                    radioButton7.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton9.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton9.ForeColor = SystemColors.ControlText;
                    radioButton11.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton8.ForeColor == SystemColors.ControlText || radioButton10.ForeColor == SystemColors.ControlText || radioButton7.ForeColor == SystemColors.ControlText)
                {
                    radioButton11.ForeColor = SystemColors.Highlight;
                    radioButton8.ForeColor = SystemColors.ControlText;
                    radioButton10.ForeColor = SystemColors.ControlText;
                    radioButton7.ForeColor = SystemColors.ControlText;
                }
                button4.BackColor = SystemColors.Highlight;
            }
        }
        //End Soal 2

        //Start Soal 3
        //jawaban benar
        private void radioButton13_Click(object sender, EventArgs e)
        {
            if (radioButton13.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton13.ForeColor = SystemColors.Highlight;
                radioButton12.ForeColor = SystemColors.ControlText;
                radioButton16.ForeColor = SystemColors.ControlText;
                radioButton14.ForeColor = SystemColors.ControlText;
                radioButton15.ForeColor = SystemColors.ControlText;
            }
            button5.BackColor = SystemColors.Highlight;
        }

        private void radioButton12_Click(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton12.ForeColor = SystemColors.Highlight;
                    radioButton15.ForeColor = SystemColors.ControlText;
                    radioButton14.ForeColor = SystemColors.ControlText;
                    radioButton16.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton13.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton13.ForeColor = SystemColors.ControlText;
                    radioButton12.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton14.ForeColor == SystemColors.ControlText || radioButton15.ForeColor == SystemColors.ControlText || radioButton16.ForeColor == SystemColors.ControlText)
                {
                    radioButton12.ForeColor = SystemColors.Highlight;
                    radioButton14.ForeColor = SystemColors.ControlText;
                    radioButton15.ForeColor = SystemColors.ControlText;
                    radioButton16.ForeColor = SystemColors.ControlText;
                }
                button5.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton14_Click(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton14.ForeColor = SystemColors.Highlight;
                    radioButton15.ForeColor = SystemColors.ControlText;
                    radioButton12.ForeColor = SystemColors.ControlText;
                    radioButton16.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton13.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton13.ForeColor = SystemColors.ControlText;
                    radioButton14.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton12.ForeColor == SystemColors.ControlText || radioButton15.ForeColor == SystemColors.ControlText || radioButton16.ForeColor == SystemColors.ControlText)
                {
                    radioButton14.ForeColor = SystemColors.Highlight;
                    radioButton12.ForeColor = SystemColors.ControlText;
                    radioButton15.ForeColor = SystemColors.ControlText;
                    radioButton16.ForeColor = SystemColors.ControlText;
                }
                button5.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton15_Click(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton15.ForeColor = SystemColors.Highlight;
                    radioButton12.ForeColor = SystemColors.ControlText;
                    radioButton14.ForeColor = SystemColors.ControlText;
                    radioButton16.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton13.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton13.ForeColor = SystemColors.ControlText;
                    radioButton15.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton14.ForeColor == SystemColors.ControlText || radioButton12.ForeColor == SystemColors.ControlText || radioButton16.ForeColor == SystemColors.ControlText)
                {
                    radioButton15.ForeColor = SystemColors.Highlight;
                    radioButton14.ForeColor = SystemColors.ControlText;
                    radioButton12.ForeColor = SystemColors.ControlText;
                    radioButton16.ForeColor = SystemColors.ControlText;
                }
                button5.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton16_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton16.ForeColor = SystemColors.Highlight;
                    radioButton15.ForeColor = SystemColors.ControlText;
                    radioButton14.ForeColor = SystemColors.ControlText;
                    radioButton12.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton13.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton13.ForeColor = SystemColors.ControlText;
                    radioButton16.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton14.ForeColor == SystemColors.ControlText || radioButton15.ForeColor == SystemColors.ControlText || radioButton12.ForeColor == SystemColors.ControlText)
                {
                    radioButton16.ForeColor = SystemColors.Highlight;
                    radioButton14.ForeColor = SystemColors.ControlText;
                    radioButton15.ForeColor = SystemColors.ControlText;
                    radioButton12.ForeColor = SystemColors.ControlText;
                }
                button5.BackColor = SystemColors.Highlight;
            }
        }
        //end soal no 3

        //start soal n0 4
        //jawaban benar
        private void radioButton18_Click(object sender, EventArgs e)
        {
            if (radioButton18.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton18.ForeColor = SystemColors.Highlight;
                radioButton17.ForeColor = SystemColors.ControlText;
                radioButton19.ForeColor = SystemColors.ControlText;
                radioButton20.ForeColor = SystemColors.ControlText;
                radioButton21.ForeColor = SystemColors.ControlText;
            }
            button6.BackColor = SystemColors.Highlight;
        }

        private void radioButton17_Click(object sender, EventArgs e)
        {
            if (radioButton17.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton17.ForeColor = SystemColors.Highlight;
                    radioButton19.ForeColor = SystemColors.ControlText;
                    radioButton20.ForeColor = SystemColors.ControlText;
                    radioButton21.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton18.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton18.ForeColor = SystemColors.ControlText;
                    radioButton17.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton19.ForeColor == SystemColors.ControlText || radioButton20.ForeColor == SystemColors.ControlText || radioButton21.ForeColor == SystemColors.ControlText)
                {
                    radioButton17.ForeColor = SystemColors.Highlight;
                    radioButton19.ForeColor = SystemColors.ControlText;
                    radioButton20.ForeColor = SystemColors.ControlText;
                    radioButton21.ForeColor = SystemColors.ControlText;
                }
                button6.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton19_Click(object sender, EventArgs e)
        {
            if (radioButton19.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton19.ForeColor = SystemColors.Highlight;
                    radioButton17.ForeColor = SystemColors.ControlText;
                    radioButton20.ForeColor = SystemColors.ControlText;
                    radioButton21.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton18.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton18.ForeColor = SystemColors.ControlText;
                    radioButton19.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton17.ForeColor == SystemColors.ControlText || radioButton20.ForeColor == SystemColors.ControlText || radioButton21.ForeColor == SystemColors.ControlText)
                {
                    radioButton19.ForeColor = SystemColors.Highlight;
                    radioButton17.ForeColor = SystemColors.ControlText;
                    radioButton20.ForeColor = SystemColors.ControlText;
                    radioButton21.ForeColor = SystemColors.ControlText;
                }
                button6.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton20_Click(object sender, EventArgs e)
        {
            if (radioButton20.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton20.ForeColor = SystemColors.Highlight;
                    radioButton17.ForeColor = SystemColors.ControlText;
                    radioButton19.ForeColor = SystemColors.ControlText;
                    radioButton21.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton18.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton18.ForeColor = SystemColors.ControlText;
                    radioButton20.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton17.ForeColor == SystemColors.ControlText || radioButton19.ForeColor == SystemColors.ControlText || radioButton21.ForeColor == SystemColors.ControlText)
                {
                    radioButton20.ForeColor = SystemColors.Highlight;
                    radioButton17.ForeColor = SystemColors.ControlText;
                    radioButton19.ForeColor = SystemColors.ControlText;
                    radioButton21.ForeColor = SystemColors.ControlText;
                }
                button6.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton21_Click(object sender, EventArgs e)
        {
            if (radioButton21.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton21.ForeColor = SystemColors.Highlight;
                    radioButton17.ForeColor = SystemColors.ControlText;
                    radioButton19.ForeColor = SystemColors.ControlText;
                    radioButton20.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton18.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton18.ForeColor = SystemColors.ControlText;
                    radioButton21.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton17.ForeColor == SystemColors.ControlText || radioButton19.ForeColor == SystemColors.ControlText || radioButton20.ForeColor == SystemColors.ControlText)
                {
                    radioButton21.ForeColor = SystemColors.Highlight;
                    radioButton17.ForeColor = SystemColors.ControlText;
                    radioButton19.ForeColor = SystemColors.ControlText;
                    radioButton20.ForeColor = SystemColors.ControlText;
                }
                button6.BackColor = SystemColors.Highlight;
            }
        }
        //end soal 4

        //start soal 5
        //jawaban benar
        private void radioButton24_Click(object sender, EventArgs e)
        {
            if (radioButton24.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton24.ForeColor = SystemColors.Highlight;
                radioButton22.ForeColor = SystemColors.ControlText;
                radioButton23.ForeColor = SystemColors.ControlText;
                radioButton25.ForeColor = SystemColors.ControlText;
                radioButton26.ForeColor = SystemColors.ControlText;
            }
            button7.BackColor = SystemColors.Highlight;
        }

        private void radioButton22_Click(object sender, EventArgs e)
        {
            if (radioButton22.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton22.ForeColor = SystemColors.Highlight;
                    radioButton23.ForeColor = SystemColors.ControlText;
                    radioButton25.ForeColor = SystemColors.ControlText;
                    radioButton26.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton24.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton24.ForeColor = SystemColors.ControlText;
                    radioButton22.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton23.ForeColor == SystemColors.ControlText || radioButton25.ForeColor == SystemColors.ControlText || radioButton26.ForeColor == SystemColors.ControlText)
                {
                    radioButton22.ForeColor = SystemColors.Highlight;
                    radioButton23.ForeColor = SystemColors.ControlText;
                    radioButton25.ForeColor = SystemColors.ControlText;
                    radioButton26.ForeColor = SystemColors.ControlText;
                }
                button7.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton23_Click(object sender, EventArgs e)
        {
            if (radioButton23.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton23.ForeColor = SystemColors.Highlight;
                    radioButton22.ForeColor = SystemColors.ControlText;
                    radioButton25.ForeColor = SystemColors.ControlText;
                    radioButton26.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton24.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton24.ForeColor = SystemColors.ControlText;
                    radioButton23.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton22.ForeColor == SystemColors.ControlText || radioButton25.ForeColor == SystemColors.ControlText || radioButton26.ForeColor == SystemColors.ControlText)
                {
                    radioButton23.ForeColor = SystemColors.Highlight;
                    radioButton22.ForeColor = SystemColors.ControlText;
                    radioButton25.ForeColor = SystemColors.ControlText;
                    radioButton26.ForeColor = SystemColors.ControlText;
                }
                button7.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton25_Click(object sender, EventArgs e)
        {
            if (radioButton25.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton25.ForeColor = SystemColors.Highlight;
                    radioButton22.ForeColor = SystemColors.ControlText;
                    radioButton23.ForeColor = SystemColors.ControlText;
                    radioButton26.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton24.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton24.ForeColor = SystemColors.ControlText;
                    radioButton25.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton22.ForeColor == SystemColors.ControlText || radioButton23.ForeColor == SystemColors.ControlText || radioButton26.ForeColor == SystemColors.ControlText)
                {
                    radioButton25.ForeColor = SystemColors.Highlight;
                    radioButton22.ForeColor = SystemColors.ControlText;
                    radioButton23.ForeColor = SystemColors.ControlText;
                    radioButton26.ForeColor = SystemColors.ControlText;
                }
                button7.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton26_Click(object sender, EventArgs e)
        {
            if (radioButton26.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton26.ForeColor = SystemColors.Highlight;
                    radioButton22.ForeColor = SystemColors.ControlText;
                    radioButton25.ForeColor = SystemColors.ControlText;
                    radioButton23.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton24.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton24.ForeColor = SystemColors.ControlText;
                    radioButton26.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton22.ForeColor == SystemColors.ControlText || radioButton25.ForeColor == SystemColors.ControlText || radioButton23.ForeColor == SystemColors.ControlText)
                {
                    radioButton26.ForeColor = SystemColors.Highlight;
                    radioButton22.ForeColor = SystemColors.ControlText;
                    radioButton25.ForeColor = SystemColors.ControlText;
                    radioButton23.ForeColor = SystemColors.ControlText;
                }
                button7.BackColor = SystemColors.Highlight;
            }
        }
        //end soal no 5

        //start soal 6
        //jawaban benar
        private void radioButton30_Click(object sender, EventArgs e)
        {
            if (radioButton30.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton30.ForeColor = SystemColors.Highlight;
                radioButton27.ForeColor = SystemColors.ControlText;
                radioButton28.ForeColor = SystemColors.ControlText;
                radioButton29.ForeColor = SystemColors.ControlText;
                radioButton31.ForeColor = SystemColors.ControlText;
            }
            button8.BackColor = SystemColors.Highlight;
        }

        private void radioButton27_Click(object sender, EventArgs e)
        {
            if (radioButton27.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton27.ForeColor = SystemColors.Highlight;
                    radioButton28.ForeColor = SystemColors.ControlText;
                    radioButton29.ForeColor = SystemColors.ControlText;
                    radioButton31.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton30.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton30.ForeColor = SystemColors.ControlText;
                    radioButton27.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton28.ForeColor == SystemColors.ControlText || radioButton29.ForeColor == SystemColors.ControlText || radioButton31.ForeColor == SystemColors.ControlText)
                {
                    radioButton27.ForeColor = SystemColors.Highlight;
                    radioButton28.ForeColor = SystemColors.ControlText;
                    radioButton29.ForeColor = SystemColors.ControlText;
                    radioButton31.ForeColor = SystemColors.ControlText;
                }
                button8.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton28_Click(object sender, EventArgs e)
        {
            if (radioButton28.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton28.ForeColor = SystemColors.Highlight;
                    radioButton27.ForeColor = SystemColors.ControlText;
                    radioButton29.ForeColor = SystemColors.ControlText;
                    radioButton31.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton30.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton30.ForeColor = SystemColors.ControlText;
                    radioButton28.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton27.ForeColor == SystemColors.ControlText || radioButton29.ForeColor == SystemColors.ControlText || radioButton31.ForeColor == SystemColors.ControlText)
                {
                    radioButton28.ForeColor = SystemColors.Highlight;
                    radioButton27.ForeColor = SystemColors.ControlText;
                    radioButton29.ForeColor = SystemColors.ControlText;
                    radioButton31.ForeColor = SystemColors.ControlText;
                }
                button8.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton29_Click(object sender, EventArgs e)
        {
            if (radioButton29.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton29.ForeColor = SystemColors.Highlight;
                    radioButton27.ForeColor = SystemColors.ControlText;
                    radioButton28.ForeColor = SystemColors.ControlText;
                    radioButton31.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton30.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton30.ForeColor = SystemColors.ControlText;
                    radioButton29.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton27.ForeColor == SystemColors.ControlText || radioButton28.ForeColor == SystemColors.ControlText || radioButton31.ForeColor == SystemColors.ControlText)
                {
                    radioButton29.ForeColor = SystemColors.Highlight;
                    radioButton27.ForeColor = SystemColors.ControlText;
                    radioButton28.ForeColor = SystemColors.ControlText;
                    radioButton31.ForeColor = SystemColors.ControlText;
                }
                button8.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton31_Click(object sender, EventArgs e)
        {
            if (radioButton31.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton31.ForeColor = SystemColors.Highlight;
                    radioButton27.ForeColor = SystemColors.ControlText;
                    radioButton29.ForeColor = SystemColors.ControlText;
                    radioButton28.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton30.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton30.ForeColor = SystemColors.ControlText;
                    radioButton31.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton27.ForeColor == SystemColors.ControlText || radioButton29.ForeColor == SystemColors.ControlText || radioButton28.ForeColor == SystemColors.ControlText)
                {
                    radioButton31.ForeColor = SystemColors.Highlight;
                    radioButton27.ForeColor = SystemColors.ControlText;
                    radioButton29.ForeColor = SystemColors.ControlText;
                    radioButton28.ForeColor = SystemColors.ControlText;
                }
                button8.BackColor = SystemColors.Highlight;
            }
        }
        //end soal no 6

        //start soal no 7
        //jawaban benar
        private void radioButton36_Click(object sender, EventArgs e)
        {
            if (radioButton36.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton36.ForeColor = SystemColors.Highlight;
                radioButton32.ForeColor = SystemColors.ControlText;
                radioButton33.ForeColor = SystemColors.ControlText;
                radioButton34.ForeColor = SystemColors.ControlText;
                radioButton35.ForeColor = SystemColors.ControlText;
            }
            button9.BackColor = SystemColors.Highlight;
        }

        private void radioButton32_Click(object sender, EventArgs e)
        {
            if (radioButton32.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton32.ForeColor = SystemColors.Highlight;
                    radioButton33.ForeColor = SystemColors.ControlText;
                    radioButton34.ForeColor = SystemColors.ControlText;
                    radioButton35.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton36.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton36.ForeColor = SystemColors.ControlText;
                    radioButton32.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton33.ForeColor == SystemColors.ControlText || radioButton34.ForeColor == SystemColors.ControlText || radioButton35.ForeColor == SystemColors.ControlText)
                {
                    radioButton32.ForeColor = SystemColors.Highlight;
                    radioButton33.ForeColor = SystemColors.ControlText;
                    radioButton34.ForeColor = SystemColors.ControlText;
                    radioButton35.ForeColor = SystemColors.ControlText;
                }
                button9.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton33_Click(object sender, EventArgs e)
        {
            if (radioButton33.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton33.ForeColor = SystemColors.Highlight;
                    radioButton32.ForeColor = SystemColors.ControlText;
                    radioButton34.ForeColor = SystemColors.ControlText;
                    radioButton35.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton36.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton36.ForeColor = SystemColors.ControlText;
                    radioButton33.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton32.ForeColor == SystemColors.ControlText || radioButton34.ForeColor == SystemColors.ControlText || radioButton35.ForeColor == SystemColors.ControlText)
                {
                    radioButton33.ForeColor = SystemColors.Highlight;
                    radioButton32.ForeColor = SystemColors.ControlText;
                    radioButton34.ForeColor = SystemColors.ControlText;
                    radioButton35.ForeColor = SystemColors.ControlText;
                }
                button9.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton34_Click(object sender, EventArgs e)
        {
            if (radioButton34.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton34.ForeColor = SystemColors.Highlight;
                    radioButton33.ForeColor = SystemColors.ControlText;
                    radioButton32.ForeColor = SystemColors.ControlText;
                    radioButton35.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton36.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton36.ForeColor = SystemColors.ControlText;
                    radioButton34.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton33.ForeColor == SystemColors.ControlText || radioButton32.ForeColor == SystemColors.ControlText || radioButton35.ForeColor == SystemColors.ControlText)
                {
                    radioButton34.ForeColor = SystemColors.Highlight;
                    radioButton33.ForeColor = SystemColors.ControlText;
                    radioButton32.ForeColor = SystemColors.ControlText;
                    radioButton35.ForeColor = SystemColors.ControlText;
                }
                button9.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton35_Click(object sender, EventArgs e)
        {
            if (radioButton35.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton35.ForeColor = SystemColors.Highlight;
                    radioButton33.ForeColor = SystemColors.ControlText;
                    radioButton34.ForeColor = SystemColors.ControlText;
                    radioButton32.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton36.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton36.ForeColor = SystemColors.ControlText;
                    radioButton35.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton33.ForeColor == SystemColors.ControlText || radioButton34.ForeColor == SystemColors.ControlText || radioButton32.ForeColor == SystemColors.ControlText)
                {
                    radioButton35.ForeColor = SystemColors.Highlight;
                    radioButton33.ForeColor = SystemColors.ControlText;
                    radioButton34.ForeColor = SystemColors.ControlText;
                    radioButton32.ForeColor = SystemColors.ControlText;
                }
                button9.BackColor = SystemColors.Highlight;
            }
        }
        //end soal no 7

        //start soal no 8
        //jawaban benar B
        private void radioButton38_Click(object sender, EventArgs e)
        {
            if (radioButton38.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton38.ForeColor = SystemColors.Highlight;
                radioButton37.ForeColor = SystemColors.ControlText;
                radioButton39.ForeColor = SystemColors.ControlText;
                radioButton40.ForeColor = SystemColors.ControlText;
                radioButton41.ForeColor = SystemColors.ControlText;
            }
            button10.BackColor = SystemColors.Highlight;
        }

        private void radioButton37_Click(object sender, EventArgs e)
        {
            if (radioButton37.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton37.ForeColor = SystemColors.Highlight;
                    radioButton39.ForeColor = SystemColors.ControlText;
                    radioButton40.ForeColor = SystemColors.ControlText;
                    radioButton41.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton38.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton38.ForeColor = SystemColors.ControlText;
                    radioButton37.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton39.ForeColor == SystemColors.ControlText || radioButton40.ForeColor == SystemColors.ControlText || radioButton41.ForeColor == SystemColors.ControlText)
                {
                    radioButton37.ForeColor = SystemColors.Highlight;
                    radioButton39.ForeColor = SystemColors.ControlText;
                    radioButton40.ForeColor = SystemColors.ControlText;
                    radioButton41.ForeColor = SystemColors.ControlText;
                }
                button10.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton39_Click(object sender, EventArgs e)
        {
            if (radioButton39.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton39.ForeColor = SystemColors.Highlight;
                    radioButton37.ForeColor = SystemColors.ControlText;
                    radioButton40.ForeColor = SystemColors.ControlText;
                    radioButton41.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton38.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton38.ForeColor = SystemColors.ControlText;
                    radioButton39.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton37.ForeColor == SystemColors.ControlText || radioButton40.ForeColor == SystemColors.ControlText || radioButton41.ForeColor == SystemColors.ControlText)
                {
                    radioButton39.ForeColor = SystemColors.Highlight;
                    radioButton37.ForeColor = SystemColors.ControlText;
                    radioButton40.ForeColor = SystemColors.ControlText;
                    radioButton41.ForeColor = SystemColors.ControlText;
                }
                button10.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton40_Click(object sender, EventArgs e)
        {
            if (radioButton40.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton40.ForeColor = SystemColors.Highlight;
                    radioButton39.ForeColor = SystemColors.ControlText;
                    radioButton41.ForeColor = SystemColors.ControlText;
                    radioButton37.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton38.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton38.ForeColor = SystemColors.ControlText;
                    radioButton40.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton39.ForeColor == SystemColors.ControlText || radioButton37.ForeColor == SystemColors.ControlText || radioButton41.ForeColor == SystemColors.ControlText)
                {
                    radioButton40.ForeColor = SystemColors.Highlight;
                    radioButton39.ForeColor = SystemColors.ControlText;
                    radioButton37.ForeColor = SystemColors.ControlText;
                    radioButton41.ForeColor = SystemColors.ControlText;
                }
                button10.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton41_Click(object sender, EventArgs e)
        {
            if (radioButton41.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton41.ForeColor = SystemColors.Highlight;
                    radioButton39.ForeColor = SystemColors.ControlText;
                    radioButton40.ForeColor = SystemColors.ControlText;
                    radioButton37.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton38.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton38.ForeColor = SystemColors.ControlText;
                    radioButton41.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton39.ForeColor == SystemColors.ControlText || radioButton40.ForeColor == SystemColors.ControlText || radioButton37.ForeColor == SystemColors.ControlText)
                {
                    radioButton41.ForeColor = SystemColors.Highlight;
                    radioButton39.ForeColor = SystemColors.ControlText;
                    radioButton40.ForeColor = SystemColors.ControlText;
                    radioButton37.ForeColor = SystemColors.ControlText;
                }
                button10.BackColor = SystemColors.Highlight;
            }
        }
        //end soal 8

        //start soal 9
        //jawaban benar B
        private void radioButton43_Click(object sender, EventArgs e)
        {
            if (radioButton43.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton43.ForeColor = SystemColors.Highlight;
                radioButton42.ForeColor = SystemColors.ControlText;
                radioButton44.ForeColor = SystemColors.ControlText;
                radioButton45.ForeColor = SystemColors.ControlText;
                radioButton46.ForeColor = SystemColors.ControlText;
            }
            button11.BackColor = SystemColors.Highlight;
        }

        private void radioButton42_Click(object sender, EventArgs e)
        {
            if (radioButton42.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton42.ForeColor = SystemColors.Highlight;
                    radioButton44.ForeColor = SystemColors.ControlText;
                    radioButton45.ForeColor = SystemColors.ControlText;
                    radioButton46.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton43.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton43.ForeColor = SystemColors.ControlText;
                    radioButton42.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton44.ForeColor == SystemColors.ControlText || radioButton45.ForeColor == SystemColors.ControlText || radioButton46.ForeColor == SystemColors.ControlText)
                {
                    radioButton42.ForeColor = SystemColors.Highlight;
                    radioButton44.ForeColor = SystemColors.ControlText;
                    radioButton45.ForeColor = SystemColors.ControlText;
                    radioButton46.ForeColor = SystemColors.ControlText;
                }
                button11.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton44_Click(object sender, EventArgs e)
        {
            if (radioButton44.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton44.ForeColor = SystemColors.Highlight;
                    radioButton42.ForeColor = SystemColors.ControlText;
                    radioButton45.ForeColor = SystemColors.ControlText;
                    radioButton46.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton43.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton43.ForeColor = SystemColors.ControlText;
                    radioButton44.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton42.ForeColor == SystemColors.ControlText || radioButton45.ForeColor == SystemColors.ControlText || radioButton46.ForeColor == SystemColors.ControlText)
                {
                    radioButton44.ForeColor = SystemColors.Highlight;
                    radioButton42.ForeColor = SystemColors.ControlText;
                    radioButton45.ForeColor = SystemColors.ControlText;
                    radioButton46.ForeColor = SystemColors.ControlText;
                }
                button11.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton45_Click(object sender, EventArgs e)
        {
            if (radioButton45.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton45.ForeColor = SystemColors.Highlight;
                    radioButton44.ForeColor = SystemColors.ControlText;
                    radioButton42.ForeColor = SystemColors.ControlText;
                    radioButton46.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton43.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton43.ForeColor = SystemColors.ControlText;
                    radioButton45.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton44.ForeColor == SystemColors.ControlText || radioButton42.ForeColor == SystemColors.ControlText || radioButton46.ForeColor == SystemColors.ControlText)
                {
                    radioButton45.ForeColor = SystemColors.Highlight;
                    radioButton44.ForeColor = SystemColors.ControlText;
                    radioButton42.ForeColor = SystemColors.ControlText;
                    radioButton46.ForeColor = SystemColors.ControlText;
                }
                button11.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton46_Click(object sender, EventArgs e)
        {
            if (radioButton46.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton46.ForeColor = SystemColors.Highlight;
                    radioButton44.ForeColor = SystemColors.ControlText;
                    radioButton45.ForeColor = SystemColors.ControlText;
                    radioButton42.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton43.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton43.ForeColor = SystemColors.ControlText;
                    radioButton46.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton44.ForeColor == SystemColors.ControlText || radioButton45.ForeColor == SystemColors.ControlText || radioButton42.ForeColor == SystemColors.ControlText)
                {
                    radioButton46.ForeColor = SystemColors.Highlight;
                    radioButton44.ForeColor = SystemColors.ControlText;
                    radioButton45.ForeColor = SystemColors.ControlText;
                    radioButton42.ForeColor = SystemColors.ControlText;
                }
                button11.BackColor = SystemColors.Highlight;
            }
        }
        //end soal 9

        //start soal 10
        //jawaban benar A
        private void radioButton47_Click(object sender, EventArgs e)
        {
            if (radioButton47.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton47.ForeColor = SystemColors.Highlight;
                radioButton48.ForeColor = SystemColors.ControlText;
                radioButton49.ForeColor = SystemColors.ControlText;
                radioButton50.ForeColor = SystemColors.ControlText;
                radioButton51.ForeColor = SystemColors.ControlText;
            }
            button12.BackColor = SystemColors.Highlight;
        }

        private void radioButton48_Click(object sender, EventArgs e)
        {
            if (radioButton48.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton48.ForeColor = SystemColors.Highlight;
                    radioButton49.ForeColor = SystemColors.ControlText;
                    radioButton50.ForeColor = SystemColors.ControlText;
                    radioButton51.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton47.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton47.ForeColor = SystemColors.ControlText;
                    radioButton48.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton49.ForeColor == SystemColors.ControlText || radioButton50.ForeColor == SystemColors.ControlText || radioButton51.ForeColor == SystemColors.ControlText)
                {
                    radioButton48.ForeColor = SystemColors.Highlight;
                    radioButton49.ForeColor = SystemColors.ControlText;
                    radioButton50.ForeColor = SystemColors.ControlText;
                    radioButton51.ForeColor = SystemColors.ControlText;
                }
                button12.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton49_Click(object sender, EventArgs e)
        {
            if (radioButton49.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton49.ForeColor = SystemColors.Highlight;
                    radioButton48.ForeColor = SystemColors.ControlText;
                    radioButton50.ForeColor = SystemColors.ControlText;
                    radioButton51.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton47.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton47.ForeColor = SystemColors.ControlText;
                    radioButton49.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton48.ForeColor == SystemColors.ControlText || radioButton50.ForeColor == SystemColors.ControlText || radioButton51.ForeColor == SystemColors.ControlText)
                {
                    radioButton49.ForeColor = SystemColors.Highlight;
                    radioButton48.ForeColor = SystemColors.ControlText;
                    radioButton50.ForeColor = SystemColors.ControlText;
                    radioButton51.ForeColor = SystemColors.ControlText;
                }
                button12.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton50_Click(object sender, EventArgs e)
        {
            if (radioButton50.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton50.ForeColor = SystemColors.Highlight;
                    radioButton49.ForeColor = SystemColors.ControlText;
                    radioButton48.ForeColor = SystemColors.ControlText;
                    radioButton51.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton47.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton47.ForeColor = SystemColors.ControlText;
                    radioButton50.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton49.ForeColor == SystemColors.ControlText || radioButton48.ForeColor == SystemColors.ControlText || radioButton51.ForeColor == SystemColors.ControlText)
                {
                    radioButton50.ForeColor = SystemColors.Highlight;
                    radioButton49.ForeColor = SystemColors.ControlText;
                    radioButton48.ForeColor = SystemColors.ControlText;
                    radioButton51.ForeColor = SystemColors.ControlText;
                }
                button12.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton51_Click(object sender, EventArgs e)
        {
            if (radioButton51.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton51.ForeColor = SystemColors.Highlight;
                    radioButton49.ForeColor = SystemColors.ControlText;
                    radioButton50.ForeColor = SystemColors.ControlText;
                    radioButton48.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton47.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton47.ForeColor = SystemColors.ControlText;
                    radioButton51.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton49.ForeColor == SystemColors.ControlText || radioButton50.ForeColor == SystemColors.ControlText || radioButton48.ForeColor == SystemColors.ControlText)
                {
                    radioButton51.ForeColor = SystemColors.Highlight;
                    radioButton49.ForeColor = SystemColors.ControlText;
                    radioButton50.ForeColor = SystemColors.ControlText;
                    radioButton48.ForeColor = SystemColors.ControlText;
                }
                button12.BackColor = SystemColors.Highlight;
            }
        }
        //end soal 10

        //start soal 11
        //jawaban benar B
        private void radioButton53_Click(object sender, EventArgs e)
        {
            if (radioButton53.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton53.ForeColor = SystemColors.Highlight;
                radioButton52.ForeColor = SystemColors.ControlText;
                radioButton54.ForeColor = SystemColors.ControlText;
                radioButton55.ForeColor = SystemColors.ControlText;
                radioButton56.ForeColor = SystemColors.ControlText;
            }
            button13.BackColor = SystemColors.Highlight;
        }

        private void radioButton52_Click(object sender, EventArgs e)
        {
            if (radioButton52.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton52.ForeColor = SystemColors.Highlight;
                    radioButton54.ForeColor = SystemColors.ControlText;
                    radioButton55.ForeColor = SystemColors.ControlText;
                    radioButton56.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton53.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton53.ForeColor = SystemColors.ControlText;
                    radioButton52.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton54.ForeColor == SystemColors.ControlText || radioButton55.ForeColor == SystemColors.ControlText || radioButton56.ForeColor == SystemColors.ControlText)
                {
                    radioButton52.ForeColor = SystemColors.Highlight;
                    radioButton54.ForeColor = SystemColors.ControlText;
                    radioButton55.ForeColor = SystemColors.ControlText;
                    radioButton56.ForeColor = SystemColors.ControlText;
                }
                button13.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton54_Click(object sender, EventArgs e)
        {
            if (radioButton54.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton54.ForeColor = SystemColors.Highlight;
                    radioButton52.ForeColor = SystemColors.ControlText;
                    radioButton55.ForeColor = SystemColors.ControlText;
                    radioButton56.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton53.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton53.ForeColor = SystemColors.ControlText;
                    radioButton54.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton52.ForeColor == SystemColors.ControlText || radioButton55.ForeColor == SystemColors.ControlText || radioButton56.ForeColor == SystemColors.ControlText)
                {
                    radioButton54.ForeColor = SystemColors.Highlight;
                    radioButton52.ForeColor = SystemColors.ControlText;
                    radioButton55.ForeColor = SystemColors.ControlText;
                    radioButton56.ForeColor = SystemColors.ControlText;
                }
                button13.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton55_Click(object sender, EventArgs e)
        {
            if (radioButton55.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton55.ForeColor = SystemColors.Highlight;
                    radioButton54.ForeColor = SystemColors.ControlText;
                    radioButton52.ForeColor = SystemColors.ControlText;
                    radioButton56.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton53.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton53.ForeColor = SystemColors.ControlText;
                    radioButton55.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton54.ForeColor == SystemColors.ControlText || radioButton52.ForeColor == SystemColors.ControlText || radioButton56.ForeColor == SystemColors.ControlText)
                {
                    radioButton55.ForeColor = SystemColors.Highlight;
                    radioButton54.ForeColor = SystemColors.ControlText;
                    radioButton52.ForeColor = SystemColors.ControlText;
                    radioButton56.ForeColor = SystemColors.ControlText;
                }
                button13.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton56_Click(object sender, EventArgs e)
        {
            if (radioButton56.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton56.ForeColor = SystemColors.Highlight;
                    radioButton54.ForeColor = SystemColors.ControlText;
                    radioButton55.ForeColor = SystemColors.ControlText;
                    radioButton52.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton53.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton53.ForeColor = SystemColors.ControlText;
                    radioButton56.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton54.ForeColor == SystemColors.ControlText || radioButton55.ForeColor == SystemColors.ControlText || radioButton52.ForeColor == SystemColors.ControlText)
                {
                    radioButton56.ForeColor = SystemColors.Highlight;
                    radioButton54.ForeColor = SystemColors.ControlText;
                    radioButton55.ForeColor = SystemColors.ControlText;
                    radioButton52.ForeColor = SystemColors.ControlText;
                }
                button13.BackColor = SystemColors.Highlight;
            }
        }
        //end soal 11

        //start soal 12
        //jawaban benar D
        private void radioButton60_Click(object sender, EventArgs e)
        {
            if (radioButton60.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton60.ForeColor = SystemColors.Highlight;
                radioButton57.ForeColor = SystemColors.ControlText;
                radioButton58.ForeColor = SystemColors.ControlText;
                radioButton59.ForeColor = SystemColors.ControlText;
                radioButton61.ForeColor = SystemColors.ControlText;
            }
            button14.BackColor = SystemColors.Highlight;
        }

        private void radioButton57_Click(object sender, EventArgs e)
        {
            if (radioButton57.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton57.ForeColor = SystemColors.Highlight;
                    radioButton58.ForeColor = SystemColors.ControlText;
                    radioButton59.ForeColor = SystemColors.ControlText;
                    radioButton61.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton60.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton60.ForeColor = SystemColors.ControlText;
                    radioButton57.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton58.ForeColor == SystemColors.ControlText || radioButton59.ForeColor == SystemColors.ControlText || radioButton61.ForeColor == SystemColors.ControlText)
                {
                    radioButton57.ForeColor = SystemColors.Highlight;
                    radioButton58.ForeColor = SystemColors.ControlText;
                    radioButton59.ForeColor = SystemColors.ControlText;
                    radioButton61.ForeColor = SystemColors.ControlText;
                }
                button14.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton58_Click(object sender, EventArgs e)
        {
            if (radioButton58.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton58.ForeColor = SystemColors.Highlight;
                    radioButton57.ForeColor = SystemColors.ControlText;
                    radioButton59.ForeColor = SystemColors.ControlText;
                    radioButton61.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton60.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton60.ForeColor = SystemColors.ControlText;
                    radioButton58.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton57.ForeColor == SystemColors.ControlText || radioButton59.ForeColor == SystemColors.ControlText || radioButton61.ForeColor == SystemColors.ControlText)
                {
                    radioButton58.ForeColor = SystemColors.Highlight;
                    radioButton57.ForeColor = SystemColors.ControlText;
                    radioButton59.ForeColor = SystemColors.ControlText;
                    radioButton61.ForeColor = SystemColors.ControlText;
                }
                button14.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton59_Click(object sender, EventArgs e)
        {
            if (radioButton59.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton59.ForeColor = SystemColors.Highlight;
                    radioButton57.ForeColor = SystemColors.ControlText;
                    radioButton58.ForeColor = SystemColors.ControlText;
                    radioButton61.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton60.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton60.ForeColor = SystemColors.ControlText;
                    radioButton59.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton57.ForeColor == SystemColors.ControlText || radioButton58.ForeColor == SystemColors.ControlText || radioButton61.ForeColor == SystemColors.ControlText)
                {
                    radioButton59.ForeColor = SystemColors.Highlight;
                    radioButton57.ForeColor = SystemColors.ControlText;
                    radioButton58.ForeColor = SystemColors.ControlText;
                    radioButton61.ForeColor = SystemColors.ControlText;
                }
                button14.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton61_Click(object sender, EventArgs e)
        {
            if (radioButton61.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton61.ForeColor = SystemColors.Highlight;
                    radioButton57.ForeColor = SystemColors.ControlText;
                    radioButton58.ForeColor = SystemColors.ControlText;
                    radioButton59.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton60.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton60.ForeColor = SystemColors.ControlText;
                    radioButton61.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton57.ForeColor == SystemColors.ControlText || radioButton58.ForeColor == SystemColors.ControlText || radioButton59.ForeColor == SystemColors.ControlText)
                {
                    radioButton61.ForeColor = SystemColors.Highlight;
                    radioButton57.ForeColor = SystemColors.ControlText;
                    radioButton58.ForeColor = SystemColors.ControlText;
                    radioButton59.ForeColor = SystemColors.ControlText;
                }
                button14.BackColor = SystemColors.Highlight;
            }
        }
        //end soal 12

        //start soal 13
        //jawaban benar A
        private void radioButton62_Click(object sender, EventArgs e)
        {
            if (radioButton62.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton62.ForeColor = SystemColors.Highlight;
                radioButton63.ForeColor = SystemColors.ControlText;
                radioButton64.ForeColor = SystemColors.ControlText;
                radioButton65.ForeColor = SystemColors.ControlText;
                radioButton66.ForeColor = SystemColors.ControlText;
            }
            button15.BackColor = SystemColors.Highlight;
        }

        private void radioButton63_Click(object sender, EventArgs e)
        {
            if (radioButton63.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton63.ForeColor = SystemColors.Highlight;
                    radioButton64.ForeColor = SystemColors.ControlText;
                    radioButton65.ForeColor = SystemColors.ControlText;
                    radioButton66.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton62.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton62.ForeColor = SystemColors.ControlText;
                    radioButton63.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton64.ForeColor == SystemColors.ControlText || radioButton65.ForeColor == SystemColors.ControlText || radioButton66.ForeColor == SystemColors.ControlText)
                {
                    radioButton63.ForeColor = SystemColors.Highlight;
                    radioButton64.ForeColor = SystemColors.ControlText;
                    radioButton65.ForeColor = SystemColors.ControlText;
                    radioButton66.ForeColor = SystemColors.ControlText;
                }
                button15.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton64_Click(object sender, EventArgs e)
        {
            if (radioButton64.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton64.ForeColor = SystemColors.Highlight;
                    radioButton63.ForeColor = SystemColors.ControlText;
                    radioButton65.ForeColor = SystemColors.ControlText;
                    radioButton66.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton62.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton62.ForeColor = SystemColors.ControlText;
                    radioButton64.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton63.ForeColor == SystemColors.ControlText || radioButton65.ForeColor == SystemColors.ControlText || radioButton66.ForeColor == SystemColors.ControlText)
                {
                    radioButton64.ForeColor = SystemColors.Highlight;
                    radioButton63.ForeColor = SystemColors.ControlText;
                    radioButton65.ForeColor = SystemColors.ControlText;
                    radioButton66.ForeColor = SystemColors.ControlText;
                }
                button15.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton65_Click(object sender, EventArgs e)
        {
            if (radioButton65.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton65.ForeColor = SystemColors.Highlight;
                    radioButton64.ForeColor = SystemColors.ControlText;
                    radioButton63.ForeColor = SystemColors.ControlText;
                    radioButton66.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton62.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton62.ForeColor = SystemColors.ControlText;
                    radioButton65.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton64.ForeColor == SystemColors.ControlText || radioButton63.ForeColor == SystemColors.ControlText || radioButton66.ForeColor == SystemColors.ControlText)
                {
                    radioButton65.ForeColor = SystemColors.Highlight;
                    radioButton64.ForeColor = SystemColors.ControlText;
                    radioButton63.ForeColor = SystemColors.ControlText;
                    radioButton66.ForeColor = SystemColors.ControlText;
                }
                button15.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton66_Click(object sender, EventArgs e)
        {
            if (radioButton66.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton66.ForeColor = SystemColors.Highlight;
                    radioButton64.ForeColor = SystemColors.ControlText;
                    radioButton65.ForeColor = SystemColors.ControlText;
                    radioButton63.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton62.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton62.ForeColor = SystemColors.ControlText;
                    radioButton66.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton64.ForeColor == SystemColors.ControlText || radioButton65.ForeColor == SystemColors.ControlText || radioButton63.ForeColor == SystemColors.ControlText)
                {
                    radioButton66.ForeColor = SystemColors.Highlight;
                    radioButton64.ForeColor = SystemColors.ControlText;
                    radioButton65.ForeColor = SystemColors.ControlText;
                    radioButton63.ForeColor = SystemColors.ControlText;
                }
                button15.BackColor = SystemColors.Highlight;
            }
        }
        //end soal 13

        //start soal 14
        //jawaban benar D
        private void radioButton70_Click(object sender, EventArgs e)
        {
            if (radioButton70.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton70.ForeColor = SystemColors.Highlight;
                radioButton67.ForeColor = SystemColors.ControlText;
                radioButton68.ForeColor = SystemColors.ControlText;
                radioButton69.ForeColor = SystemColors.ControlText;
                radioButton71.ForeColor = SystemColors.ControlText;
            }
            button16.BackColor = SystemColors.Highlight;
        }

        private void radioButton67_Click(object sender, EventArgs e)
        {
            if (radioButton67.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton67.ForeColor = SystemColors.Highlight;
                    radioButton68.ForeColor = SystemColors.ControlText;
                    radioButton69.ForeColor = SystemColors.ControlText;
                    radioButton71.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton70.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton70.ForeColor = SystemColors.ControlText;
                    radioButton67.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton68.ForeColor == SystemColors.ControlText || radioButton69.ForeColor == SystemColors.ControlText || radioButton71.ForeColor == SystemColors.ControlText)
                {
                    radioButton67.ForeColor = SystemColors.Highlight;
                    radioButton68.ForeColor = SystemColors.ControlText;
                    radioButton69.ForeColor = SystemColors.ControlText;
                    radioButton71.ForeColor = SystemColors.ControlText;
                }
                button16.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton68_Click(object sender, EventArgs e)
        {
            if (radioButton68.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton68.ForeColor = SystemColors.Highlight;
                    radioButton67.ForeColor = SystemColors.ControlText;
                    radioButton69.ForeColor = SystemColors.ControlText;
                    radioButton71.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton70.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton70.ForeColor = SystemColors.ControlText;
                    radioButton68.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton67.ForeColor == SystemColors.ControlText || radioButton69.ForeColor == SystemColors.ControlText || radioButton71.ForeColor == SystemColors.ControlText)
                {
                    radioButton68.ForeColor = SystemColors.Highlight;
                    radioButton67.ForeColor = SystemColors.ControlText;
                    radioButton69.ForeColor = SystemColors.ControlText;
                    radioButton71.ForeColor = SystemColors.ControlText;
                }
                button16.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton69_Click(object sender, EventArgs e)
        {
            if (radioButton69.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton69.ForeColor = SystemColors.Highlight;
                    radioButton68.ForeColor = SystemColors.ControlText;
                    radioButton67.ForeColor = SystemColors.ControlText;
                    radioButton71.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton70.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton70.ForeColor = SystemColors.ControlText;
                    radioButton69.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton68.ForeColor == SystemColors.ControlText || radioButton67.ForeColor == SystemColors.ControlText || radioButton71.ForeColor == SystemColors.ControlText)
                {
                    radioButton69.ForeColor = SystemColors.Highlight;
                    radioButton68.ForeColor = SystemColors.ControlText;
                    radioButton67.ForeColor = SystemColors.ControlText;
                    radioButton71.ForeColor = SystemColors.ControlText;
                }
                button16.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton71_Click(object sender, EventArgs e)
        {
            if (radioButton71.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton71.ForeColor = SystemColors.Highlight;
                    radioButton68.ForeColor = SystemColors.ControlText;
                    radioButton69.ForeColor = SystemColors.ControlText;
                    radioButton67.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton70.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton70.ForeColor = SystemColors.ControlText;
                    radioButton71.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton68.ForeColor == SystemColors.ControlText || radioButton69.ForeColor == SystemColors.ControlText || radioButton67.ForeColor == SystemColors.ControlText)
                {
                    radioButton71.ForeColor = SystemColors.Highlight;
                    radioButton68.ForeColor = SystemColors.ControlText;
                    radioButton69.ForeColor = SystemColors.ControlText;
                    radioButton67.ForeColor = SystemColors.ControlText;
                }
                button16.BackColor = SystemColors.Highlight;
            }
        }
        //end soal 14

        //start soal 15
        //jawaban benar E
        private void radioButton76_Click(object sender, EventArgs e)
        {
            if (radioButton76.ForeColor == SystemColors.ControlText)
            {
                nilai += 2;
                radioButton76.ForeColor = SystemColors.Highlight;
                radioButton72.ForeColor = SystemColors.ControlText;
                radioButton73.ForeColor = SystemColors.ControlText;
                radioButton74.ForeColor = SystemColors.ControlText;
                radioButton75.ForeColor = SystemColors.ControlText;
            }
            button17.BackColor = SystemColors.Highlight;
        }

        private void radioButton72_Click(object sender, EventArgs e)
        {
            if (radioButton72.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton72.ForeColor = SystemColors.Highlight;
                    radioButton73.ForeColor = SystemColors.ControlText;
                    radioButton74.ForeColor = SystemColors.ControlText;
                    radioButton75.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton76.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton76.ForeColor = SystemColors.ControlText;
                    radioButton72.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton73.ForeColor == SystemColors.ControlText || radioButton74.ForeColor == SystemColors.ControlText || radioButton75.ForeColor == SystemColors.ControlText)
                {
                    radioButton72.ForeColor = SystemColors.Highlight;
                    radioButton73.ForeColor = SystemColors.ControlText;
                    radioButton74.ForeColor = SystemColors.ControlText;
                    radioButton75.ForeColor = SystemColors.ControlText;
                }
                button17.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton73_Click(object sender, EventArgs e)
        {
            if (radioButton73.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton73.ForeColor = SystemColors.Highlight;
                    radioButton72.ForeColor = SystemColors.ControlText;
                    radioButton74.ForeColor = SystemColors.ControlText;
                    radioButton75.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton76.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton76.ForeColor = SystemColors.ControlText;
                    radioButton73.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton72.ForeColor == SystemColors.ControlText || radioButton74.ForeColor == SystemColors.ControlText || radioButton75.ForeColor == SystemColors.ControlText)
                {
                    radioButton73.ForeColor = SystemColors.Highlight;
                    radioButton72.ForeColor = SystemColors.ControlText;
                    radioButton74.ForeColor = SystemColors.ControlText;
                    radioButton75.ForeColor = SystemColors.ControlText;
                }
                button17.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton74_Click(object sender, EventArgs e)
        {
            if (radioButton74.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton74.ForeColor = SystemColors.Highlight;
                    radioButton73.ForeColor = SystemColors.ControlText;
                    radioButton72.ForeColor = SystemColors.ControlText;
                    radioButton75.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton76.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton76.ForeColor = SystemColors.ControlText;
                    radioButton74.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton73.ForeColor == SystemColors.ControlText || radioButton72.ForeColor == SystemColors.ControlText || radioButton75.ForeColor == SystemColors.ControlText)
                {
                    radioButton74.ForeColor = SystemColors.Highlight;
                    radioButton73.ForeColor = SystemColors.ControlText;
                    radioButton72.ForeColor = SystemColors.ControlText;
                    radioButton75.ForeColor = SystemColors.ControlText;
                }
                button17.BackColor = SystemColors.Highlight;
            }
        }

        private void radioButton75_Click(object sender, EventArgs e)
        {
            if (radioButton75.Checked)
            {
                if (nilai == 0)
                {
                    nilai = 0;
                    radioButton75.ForeColor = SystemColors.Highlight;
                    radioButton73.ForeColor = SystemColors.ControlText;
                    radioButton74.ForeColor = SystemColors.ControlText;
                    radioButton72.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton76.ForeColor == SystemColors.Highlight)
                {
                    nilai -= 2;
                    radioButton76.ForeColor = SystemColors.ControlText;
                    radioButton75.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton73.ForeColor == SystemColors.ControlText || radioButton74.ForeColor == SystemColors.ControlText || radioButton72.ForeColor == SystemColors.ControlText)
                {
                    radioButton75.ForeColor = SystemColors.Highlight;
                    radioButton73.ForeColor = SystemColors.ControlText;
                    radioButton74.ForeColor = SystemColors.ControlText;
                    radioButton72.ForeColor = SystemColors.ControlText;
                }
                button17.BackColor = SystemColors.Highlight;
            }
        }
        //end soal 15
        //no1
        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 1";
            button1.Visible = true; button2.Visible = false;
            panel6.Visible = true; panel7.Visible = false; panel8.Visible = false;
            panel9.Visible = false; panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = false; panel16.Visible = false; panel17.Visible = false;
            panel18.Visible = false; panel19.Visible = false; panel20.Visible = false;
            if(button3.BackColor == Color.White || button3.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }
        //no2
        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 2";
            button1.Visible = true; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = true; panel8.Visible = false;
            panel9.Visible = false; panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = false; panel16.Visible = false; panel17.Visible = false;
            panel18.Visible = false; panel19.Visible = false; panel20.Visible = false;
            if (button4.BackColor == Color.White || button4.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }
        //no3 dst
        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 3";
            button1.Visible = true; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = true;
            panel9.Visible = false; panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = false; panel16.Visible = false; panel17.Visible = false;
            panel18.Visible = false; panel19.Visible = false; panel20.Visible = false;
            if (button5.BackColor == Color.White || button5.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 4";
            button1.Visible = true; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = false;
            panel9.Visible = true; panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = false; panel16.Visible = false; panel17.Visible = false;
            panel18.Visible = false; panel19.Visible = false; panel20.Visible = false;
            if (button6.BackColor == Color.White || button6.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 5";
            button1.Visible = true; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = false;
            panel9.Visible = false; panel10.Visible = true; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = false; panel16.Visible = false; panel17.Visible = false;
            panel18.Visible = false; panel19.Visible = false; panel20.Visible = false;
            if (button7.BackColor == Color.White || button7.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 6";
            button1.Visible = true; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = false;
            panel9.Visible = false; panel10.Visible = false; panel11.Visible = true;
            panel12.Visible = false; panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = false; panel16.Visible = false; panel17.Visible = false;
            panel18.Visible = false; panel19.Visible = false; panel20.Visible = false;
            if (button8.BackColor == Color.White || button8.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 7";
            button1.Visible = true; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = false;
            panel9.Visible = false; panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = true; panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = false; panel16.Visible = false; panel17.Visible = false;
            panel18.Visible = false; panel19.Visible = false; panel20.Visible = false;
            if (button9.BackColor == Color.White || button9.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 8";
            button1.Visible = true; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = false;
            panel9.Visible = false; panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = true; panel14.Visible = false;
            panel15.Visible = false; panel16.Visible = false; panel17.Visible = false;
            panel18.Visible = false; panel19.Visible = false; panel20.Visible = false;
            if (button10.BackColor == Color.White || button10.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 9";
            button1.Visible = true; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = false;
            panel9.Visible = false; panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = false; panel14.Visible = true;
            panel15.Visible = false; panel16.Visible = false; panel17.Visible = false;
            panel18.Visible = false; panel19.Visible = false; panel20.Visible = false;
            if (button11.BackColor == Color.White || button11.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 10";
            button1.Visible = true; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = false;
            panel9.Visible = false; panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = true; panel16.Visible = false; panel17.Visible = false;
            panel18.Visible = false; panel19.Visible = false; panel20.Visible = false;
            if (button12.BackColor == Color.White || button12.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 11";
            button1.Visible = true; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = false;
            panel9.Visible = false; panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = false; panel16.Visible = true; panel17.Visible = false;
            panel18.Visible = false; panel19.Visible = false; panel20.Visible = false;
            if (button13.BackColor == Color.White || button13.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 12";
            button1.Visible = true; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = false;
            panel9.Visible = false; panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = false; panel16.Visible = false; panel17.Visible = true;
            panel18.Visible = false; panel19.Visible = false; panel20.Visible = false;
            if (button14.BackColor == Color.White || button14.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 13";
            button1.Visible = true; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = false;
            panel9.Visible = false; panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = false; panel16.Visible = false; panel17.Visible = false;
            panel18.Visible = true; panel19.Visible = false; panel20.Visible = false;
            if (button15.BackColor == Color.White || button15.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 14";
            button1.Visible = true; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = false;
            panel9.Visible = false; panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = false; panel16.Visible = false; panel17.Visible = false;
            panel18.Visible = false; panel19.Visible = true; panel20.Visible = false;
            if (button16.BackColor == Color.White || button16.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label5.Text = "Soal No : 15";
            button1.Visible = false; button2.Visible = true;
            panel6.Visible = false; panel7.Visible = false; panel8.Visible = false;
            panel9.Visible = false; panel10.Visible = false; panel11.Visible = false;
            panel12.Visible = false; panel13.Visible = false; panel14.Visible = false;
            panel15.Visible = false; panel16.Visible = false; panel17.Visible = false;
            panel18.Visible = false; panel19.Visible = false; panel20.Visible = true;
            if (button17.BackColor == Color.White || button17.BackColor == SystemColors.Highlight)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void panel20_MouseHover(object sender, EventArgs e)
        {
            if( (button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight)&&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel19_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel18_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel17_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel16_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel15_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel14_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel13_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel12_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel11_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel10_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel9_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                            (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                            (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel8_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

        //Button Finish
        private void button21_Click(object sender, EventArgs e)
        {
            if(button3.BackColor == Color.Orange || button4.BackColor == Color.Orange || button5.BackColor == Color.Orange ||
                button6.BackColor == Color.Orange || button7.BackColor == Color.Orange || button8.BackColor == Color.Orange ||
                button9.BackColor == Color.Orange || button10.BackColor == Color.Orange || button11.BackColor == Color.Orange ||
                button12.BackColor == Color.Orange || button13.BackColor == Color.Orange || button14.BackColor == Color.Orange ||
                button15.BackColor == Color.Orange || button16.BackColor == Color.Orange || button17.BackColor == Color.Orange)
            {
                MessageBox.Show(" Harap Uncentang Ragu-ragu", "Smart Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var dm = new ModalSoal(nilai, username);
                dm.ShowDialog();
            }
        }

        private void Soal1_MouseHover(object sender, EventArgs e)
        {
            if ((button3.BackColor == Color.Orange || button3.BackColor == SystemColors.Highlight) &&
                (button4.BackColor == Color.Orange || button4.BackColor == SystemColors.Highlight) &&
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
                (button17.BackColor == Color.Orange || button17.BackColor == SystemColors.Highlight))
            {
                button1.Visible = false;
                button2.Visible = false;
                button21.Visible = true;
            }
        }

       
    }
}
