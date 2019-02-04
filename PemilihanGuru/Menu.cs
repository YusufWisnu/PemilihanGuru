using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace PemilihanGuru
{
    public partial class Menu : Form
    {
        Data data;
        public static string username { get; set; }
        public static int cek { get; set; }
        public Menu()
        {
            InitializeComponent();
            
        }
        public Menu(Data _data)
            :this()
        {
            this.data = _data;
        }
       

        /*
        //start disable alt+tab
        private delegate int LowLevelKeyboardProcDelegate(int nCode, int wParam, ref KBDLLHOOKSTRUCT lParam);
        [DllImport("user32.dll", EntryPoint = "SetWindowsHookExA", CharSet = CharSet.Ansi)]
        private static extern int SetWindowsHookEx(int idHook, LowLevelKeyboardProcDelegate lpfn, int hMod, int dwThreadId);
        [DllImport("user32.dll", EntryPoint = "UnHookWindowsHookEx", CharSet = CharSet.Ansi)]
        private static extern int UnHookWindowsEx(int hHook);
        [DllImport("user32.dll", EntryPoint = "CallNextHookEx", CharSet = CharSet.Ansi)]
        private static extern int CallNextHookEx(int hHook, int nCode, int
        wParam, ref KBDLLHOOKSTRUCT lParam);
        const int WH_KEYBOARD_LL = 13;
        public struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            int scanCode;
            public int flags;
            int time;
            int dwExtraInfo;
        }
        private int intLLKey;
        private KBDLLHOOKSTRUCT lParam;

        private int LowLevelKeyboardProc(int nCode, int wParam, ref
        KBDLLHOOKSTRUCT lParam)
        {
            bool blnEat = false;
            switch (wParam)
            {
                case 256:
                case 257:
                case 260:
                case 261:
                    //Alt+Tab, Alt+Esc, Ctrl+Esc, Windows Key
                    if (((lParam.vkCode == 9) && (lParam.flags == 32)) ||
                    ((lParam.vkCode == 27) && (lParam.flags == 32)) || ((lParam.vkCode ==
                    27) && (lParam.flags == 0)) || ((lParam.vkCode == 91) && (lParam.flags
                    == 1)) || ((lParam.vkCode == 92) && (lParam.flags == 1)) || ((true) &&
                    (lParam.flags == 32)))
                    {
                        blnEat = true;
                    }
                    break;
            }

            if (blnEat)
                return 1;
            else return CallNextHookEx(0, nCode, wParam, ref lParam);

        }
        //end disable alt+tab
        */
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "L7p4KR0UZVIMpPwGSfvZoAWvY5deCncATCMmKu6L",
            BasePath = "https://modsim-84fa4.firebaseio.com/"
        };
        IFirebaseClient client;
        FirebaseResponse response;

        

        private void Menu_Load(object sender, EventArgs e)
        {
            cek = 0;
            var lgn = new Login();
            username = data.username;
            button1.Location = new System.Drawing.Point(1600, 750);
            button3.Location = new System.Drawing.Point(110, 900);
            //intLLKey = SetWindowsHookEx(WH_KEYBOARD_LL, new
            //LowLevelKeyboardProcDelegate(LowLevelKeyboardProc),
            //System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
            if (!panel3.Controls.Contains(UserControl1.Instance))
            {
                panel3.Size = new System.Drawing.Size(1700, 500);
                panel3.Location = new System.Drawing.Point(110, 220);
                panel3.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();
            }
            else
            {
                UserControl1.Instance.BringToFront();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserControl1.Instance.label1.Text = string.Empty;
            this.Hide();
            var fm1 = new Login();
            fm1.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = true;
            button2.Visible = true;
            button2.Location = new System.Drawing.Point(1109, 345);
            panel4.Size = new System.Drawing.Size(585,125);
            panel4.Location = new System.Drawing.Point(1000,0);
            panel3.Controls.Remove(UserControl1.Instance);
            panel3.Controls.Add(UserControl2.Instance);
            panel4.Controls.Add(UserControl3.Instance);
            UserControl2.Instance.BringToFront();
            UserControl3.Instance.BringToFront();
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            this.Close();
            var sl = new Soal(username);
            sl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            panel3.Controls.Remove(UserControl2.Instance);
            panel4.Controls.Remove(UserControl3.Instance);
            panel3.Controls.Add(UserControl1.Instance);
            UserControl1.Instance.BringToFront();

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            if (cek != 0)
                button2.Enabled = false;
            else
                button2.Enabled = true;
        }

        private void Menu_MouseHover(object sender, EventArgs e)
        {
            if (cek != 0)
                button2.Enabled = false;
            else
                button2.Enabled = true;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            if (cek != 0)
                button2.Enabled = false;
            else
                button2.Enabled = true;
        }
    }
}
