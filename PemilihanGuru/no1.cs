using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PemilihanGuru
{
    public partial class no1 : UserControl
    {
        Soal sl = new Soal();
        public no1()
        {
            InitializeComponent();
        }

        private static no1 _instance;
        public static no1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new no1();
                return _instance;
            }

        }

        private void no1_Load(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (Soal.nilai == 0)
                {
                    Soal.nilai = 0;
                    radioButton1.ForeColor = SystemColors.Highlight;
                    radioButton2.ForeColor = Color.Black;
                    radioButton5.ForeColor = Color.Black;
                    radioButton6.ForeColor = Color.Black;
                }
                else if (radioButton7.ForeColor == SystemColors.Highlight)
                {
                    Soal.nilai -= 2;
                    radioButton7.ForeColor = Color.Black;
                    radioButton1.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton6.ForeColor == Color.Black || radioButton5.ForeColor == Color.Black || radioButton2.ForeColor == Color.Black)
                {
                    radioButton1.ForeColor = SystemColors.Highlight;
                    radioButton2.ForeColor = Color.Black;
                    radioButton5.ForeColor = Color.Black;
                    radioButton6.ForeColor = Color.Black;
                }
                Soal.finish = 1;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (Soal.nilai == 0)
                {
                    Soal.nilai = 0;
                    radioButton2.ForeColor = SystemColors.Highlight;
                    radioButton5.ForeColor = Color.Black;
                    radioButton1.ForeColor = Color.Black;
                    radioButton6.ForeColor = Color.Black;
                }
                else if (radioButton7.ForeColor == SystemColors.Highlight)
                {
                    Soal.nilai -= 2;
                    radioButton7.ForeColor = Color.Black;
                    radioButton2.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton6.ForeColor == Color.Black || radioButton1.ForeColor == Color.Black || radioButton5.ForeColor == Color.Black)
                {
                    radioButton2.ForeColor = SystemColors.Highlight;
                    radioButton5.ForeColor = Color.Black;
                    radioButton1.ForeColor = Color.Black;
                    radioButton6.ForeColor = Color.Black;
                }
                
                Soal.finish = 1;
            }
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                if (Soal.nilai == 0)
                {
                    Soal.nilai = 0;
                    radioButton6.ForeColor = SystemColors.Highlight;
                    radioButton2.ForeColor = Color.Black;
                    radioButton1.ForeColor = Color.Black;
                    radioButton5.ForeColor = Color.Black;
                }
                else if (radioButton7.ForeColor == SystemColors.Highlight)
                {
                    Soal.nilai -= 2;
                    radioButton7.ForeColor = Color.Black;
                    radioButton6.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton5.ForeColor == Color.Black || radioButton1.ForeColor == Color.Black || radioButton2.ForeColor == Color.Black)
                {
                    radioButton6.ForeColor = SystemColors.Highlight;
                    radioButton2.ForeColor = Color.Black;
                    radioButton1.ForeColor = Color.Black;
                    radioButton5.ForeColor = Color.Black;
                }
                
                Soal.finish = 1;
            }
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                if (Soal.nilai == 0)
                {
                    Soal.nilai = 0;
                    radioButton5.ForeColor = SystemColors.Highlight;
                    radioButton2.ForeColor = Color.Black;
                    radioButton1.ForeColor = Color.Black;
                    radioButton6.ForeColor = Color.Black;
                }
                else if (radioButton7.ForeColor == SystemColors.Highlight)
                {
                    Soal.nilai -= 2;
                    radioButton7.ForeColor = Color.Black;
                    radioButton5.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton6.ForeColor == Color.Black || radioButton1.ForeColor == Color.Black || radioButton2.ForeColor == Color.Black)
                {
                    radioButton5.ForeColor = SystemColors.Highlight;
                    radioButton2.ForeColor = Color.Black;
                    radioButton1.ForeColor = Color.Black;
                    radioButton6.ForeColor = Color.Black;
                }
                
                Soal.finish = 1;
            }
        }

        //jawaban benar
        private void radioButton7_Click(object sender, EventArgs e)
        {
            if(radioButton7.ForeColor == Color.Black)
            {
                Soal.nilai += 2;
                radioButton7.ForeColor = SystemColors.Highlight;
                radioButton6.ForeColor = Color.Black;
                radioButton5.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
                radioButton1.ForeColor = Color.Black;
                MessageBox.Show(Soal.nilai.ToString());     
            }
            Soal.finish = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


   
  