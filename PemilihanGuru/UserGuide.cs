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
    public partial class UserGuide : UserControl
    {
        public UserGuide()
        {
            InitializeComponent();
        }

        private static UserGuide _instance;
        public static UserGuide Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserGuide();
                return _instance;
            }

        }

        private void UserGuide_Load(object sender, EventArgs e)
        {

        }
    }
}
