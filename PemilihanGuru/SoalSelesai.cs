using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PemilihanGuru
{
    public partial class SoalSelesai : Form
    {
        public SoalSelesai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lgn = new Login();
            this.Close();
            lgn.Show();
        }
    }
}
