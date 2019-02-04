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
    public partial class blankUC : UserControl
    {
        public blankUC()
        {
            InitializeComponent();
        }

        private void blankUC_Load(object sender, EventArgs e)
        {
            this.Hide();
            var uc = new no1();
            no1.Instance.Show();
        }
    }
}
