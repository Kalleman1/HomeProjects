using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int LEFTUP = 0x0004;
        private const int LEFTDOWN = 0x0002;
        public int intervals = 5;
        public bool ShouldClick = false;
        public int parsedValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread AC = new Thread(AutoClick);
            backgroundWorker1.RunWorkerAsync();
            AC.Start();
        }
        
        private void AutoClick()
        {
            while(true)
            {
                if(ShouldClick == true)
                { 
                    mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(1);
                    mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                    Thread.Sleep(intervals);
                }
                Thread.Sleep(2);
            } 
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (EnableCheckBox.Checked)
                {
                    if (GetAsyncKeyState(Keys.F2)<0)
                    {
                        ShouldClick = false;
                    }
                    else if (GetAsyncKeyState(Keys.F1)<0)
                    {
                        ShouldClick = true;
                    }
                    Thread.Sleep(1);
                }
                Thread.Sleep(2);
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            
            while (true)
            {
                if (RandomCheckBox.Checked)
                {
                    if (GetAsyncKeyState(Keys.F3)<0)
                    {
                        
                    }
                    else if (GetAsyncKeyState(Keys.F4) < 0)
                    {
                        System.Windows.Forms.Cursor.Position = new Point(Cursor.Position.Y + 5);
                    }
                    Thread.Sleep(1);
                }
            }
        }

        //private void MoveCursor(Point CursorPoint)
        //{
        //    Point cursorPoint = new Point(Cursor.Position.X, Cursor.Position.Y);
        //    cursorPoint.X = 5;
        //    cursorPoint.Y = 6;


        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show("Please enter a true value :)");
                return;
            }

            if (int.Parse(textBox1.Text) > 100)
            {
                MessageBox.Show("Please do not enter a value higher than 100");
                return;
            }

            else
            {
                intervals = int.Parse(textBox1.Text);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ShouldClick = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ShouldClick = false;
        }
    }
}
