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
using FireSharp.Response;
using FireSharp.Config;

namespace PemilihanGuru
{
    public partial class UserControl2 : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };
        IFirebaseClient client;

        public UserControl2()
        {
            InitializeComponent();
        }

        private static UserControl2 _instance;
        public static UserControl2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl2();
                return _instance;
            }

        }
        private async void UserControl2_Load(object sender, EventArgs e)
        {
            label7.Text = string.Empty;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            client = new FireSharp.FirebaseClient(config);
            int i = 0;
            FirebaseResponse resAkun = await client.GetTaskAsync("Counter");
            counter ctn = resAkun.ResultAs<counter>();
            circularProgressBar1.Maximum = ctn.M;
            while (true)
            {
                label8.Visible = true;
                panel3.Visible = true;
                circularProgressBar1.Value = i;
                i++;
                if (i > ctn.M)
                {
                    circularProgressBar1.Visible = false;
                    label8.Visible = false;
                    panel3.Visible = false;
                    break;
                }
                FirebaseResponse resPen = await client.GetTaskAsync("Penilaian/" + i);
                Penilaian pen = resPen.ResultAs<Penilaian>();
                if (pen.username == Menu.username && pen.C1 == 0)
                {
                    label7.Text = "Belum Mengikuti";
                    Menu.cek = 0;
                }
                else if(pen.username == Menu.username && pen.C1 != 0)
                {
                    label7.Text = "Sudah Mengikuti";
                    Menu.cek = 1;
                }
            }
        }
    }
}
