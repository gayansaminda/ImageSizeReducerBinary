using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OL_results
{
    public partial class Form1 : Form
    {
        bool cancalRequested = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point buttonpos = new Point(637, 545);

            while(true)
            {
                LeftMouseClick(637, 545);
                Thread.Sleep(50);
                if (cancalRequested)
                {
                    break;
                }
            }

            //int num = 60252472;
            //for (int i = 0; i < 3000; i++)
            //{
            //    int val = num + i;

            //    LeftMouseClick(661, 320);
            //    Thread.Sleep(50);
            //    LeftMouseClick(661, 320);

            //    SendKeys.SendWait(val.ToString());
            //    Thread.Sleep(50);
            //    LeftMouseClick(820, 320);

            //    Thread.Sleep(1000);
            //    LeftMouseClick(702, 400);

            //    Thread.Sleep(50);
            //    SendKeys.Send("^{a}");
            //    Thread.Sleep(50);
            //    SendKeys.Send("^{c}");


            //    string txt = Clipboard.GetText().ToLower();
            //    if (txt.Contains("sheshan") || txt.Contains("nimsara"))
            //    {
            //        MessageBox.Show(txt);
            //    }
            //    Thread.Sleep(1000);
            //}
            
            
            
        }

        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            cancalRequested = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            cancalRequested = true;
        }


    }
}
