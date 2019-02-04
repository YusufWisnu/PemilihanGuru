using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace PemilihanGuru
{
    public partial class UserControl1 : UserControl
    {
        
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };
        
        private static UserControl1 _instance;
        public static UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl1();
                return _instance;
            }

        }

        public UserControl1()
        {
            InitializeComponent();
        }


        private async void UserControl1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            int z = 0;
            int b = 0;
            IFirebaseClient client = new FireSharp.FirebaseClient(config);
            FirebaseResponse resAkun = await client.GetTaskAsync("Counter");
            counter ctn = resAkun.ResultAs<counter>();
            while (true)
            {
                z++;
                if (z > ctn.M)
                {
                    break;
                }
            FirebaseResponse response = await client.GetTaskAsync("User_Account/"+z);
            Data obj = response.ResultAs<Data>();
                if(Menu.username == obj.username)
                {
                    label1.Text = obj.nip;
                    label3.Text = obj.namaDepan +" "+ obj.namaBelakang;
                    label4.Text = obj.mapel;
                    label5.Text = obj.sekolah;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
