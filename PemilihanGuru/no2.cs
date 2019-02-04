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
    public partial class no2 : UserControl
    {

        public no2()
        {
            InitializeComponent();
        }

        private static no2 _instance;
        public static no2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new no2();
                return _instance;
            }

        }

        private void no2_Load(object sender, EventArgs e)
        {

        }

        //jawaban benar
        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                if (radioButton3.ForeColor == SystemColors.ControlText)
                {
                    Soal.nilai += 2;
                    radioButton3.ForeColor = SystemColors.Highlight;
                    radioButton4.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.ControlText;
                    radioButton2.ForeColor = SystemColors.ControlText;
                    radioButton1.ForeColor = SystemColors.ControlText;
                    MessageBox.Show(Soal.nilai.ToString());
                }
                Soal.finish = 2;
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (Soal.nilai == 0)
                {
                    Soal.nilai = 0;
                    radioButton1.ForeColor = SystemColors.Highlight;
                    radioButton2.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.ControlText;
                    radioButton4.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton3.ForeColor == SystemColors.Highlight)
                {
                    Soal.nilai -= 2;
                    radioButton1.ForeColor = SystemColors.Highlight;
                    radioButton3.ForeColor = SystemColors.ControlText;

                }
                else if (radioButton2.ForeColor == SystemColors.ControlText || radioButton4.ForeColor == SystemColors.ControlText || radioButton5.ForeColor == SystemColors.ControlText)
                {
                    radioButton1.ForeColor = SystemColors.Highlight;
                    radioButton2.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.ControlText;
                    radioButton4.ForeColor = SystemColors.ControlText;
                }
                Soal.finish = 2;
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
                    radioButton1.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.ControlText;
                    radioButton4.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton3.ForeColor == SystemColors.Highlight)
                {
                    Soal.nilai -= 2;
                    radioButton3.ForeColor = SystemColors.ControlText;
                    radioButton2.ForeColor = SystemColors.Highlight;
                }
                else if (radioButton1.ForeColor == SystemColors.ControlText || radioButton4.ForeColor == SystemColors.ControlText || radioButton5.ForeColor == SystemColors.ControlText)
                {
                    radioButton2.ForeColor = SystemColors.Highlight;
                    radioButton1.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.ControlText;
                    radioButton4.ForeColor = SystemColors.ControlText;
                }
                Soal.finish = 2;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                if (Soal.nilai == 0)
                {
                    Soal.nilai = 0;
                    radioButton4.ForeColor = SystemColors.Highlight;
                    radioButton1.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.ControlText;
                    radioButton2.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton3.ForeColor == SystemColors.Highlight)
                {
                    Soal.nilai -= 2;
                    radioButton3.ForeColor = SystemColors.ControlText;
                    radioButton4.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton1.ForeColor == SystemColors.ControlText || radioButton2.ForeColor == SystemColors.ControlText || radioButton5.ForeColor == SystemColors.ControlText)
                {
                    radioButton4.ForeColor = SystemColors.Highlight;
                    radioButton1.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.ControlText;
                    radioButton2.ForeColor = SystemColors.ControlText;
                }
                Soal.finish = 2;
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
                    radioButton1.ForeColor = SystemColors.ControlText;
                    radioButton2.ForeColor = SystemColors.ControlText;
                    radioButton4.ForeColor = SystemColors.ControlText;
                }
                else if (radioButton3.ForeColor == SystemColors.Highlight)
                {
                    Soal.nilai -= 2;
                    radioButton3.ForeColor = SystemColors.ControlText;
                    radioButton5.ForeColor = SystemColors.Highlight;

                }
                else if (radioButton1.ForeColor == SystemColors.ControlText || radioButton4.ForeColor == SystemColors.ControlText || radioButton2.ForeColor == SystemColors.ControlText)
                {
                    radioButton5.ForeColor = SystemColors.Highlight;
                    radioButton1.ForeColor = SystemColors.ControlText;
                    radioButton2.ForeColor = SystemColors.ControlText;
                    radioButton4.ForeColor = SystemColors.ControlText;
                }
                Soal.finish = 2;
            }
        }
    }
}
