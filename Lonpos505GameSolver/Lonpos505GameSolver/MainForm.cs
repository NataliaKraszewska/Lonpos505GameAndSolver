using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Lonpos505GameSolver
{
    public partial class MainForm : Form
    {
        private static Timer loopTimer;
        private Button formButton;

        public MainForm()
        {
            InitializeComponent();
            //Console.WriteLine(movablePictureBox1.point);

            //loop timer
            loopTimer = new Timer();
            loopTimer.Interval = 500;
            loopTimer.Enabled = false;
            loopTimer.Elapsed += loopTimerEvent;
            loopTimer.AutoReset = true;
            //form button
            this.MouseDown += mouseDownEvent;
            this.MouseUp += mouseUpEvent;
        }
        private  void loopTimerEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (pictureBox56.Bounds.IntersectsWith(movablePictureBox1.Bounds) && movablePictureBox1.Visible)
            {
                pictureBox56.Image = movablePictureBox1.Image;
                movablePictureBox1.Hide();
            }
        }
        private static void mouseDownEvent(object sender, MouseEventArgs e)
        {
            loopTimer.Enabled = true;
        }
        private static void mouseUpEvent(object sender, MouseEventArgs e)
        {
            loopTimer.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox56.Bounds.IntersectsWith(movablePictureBox1.Bounds) && movablePictureBox1.Visible) 
            {
                pictureBox56.Image = movablePictureBox1.Image;
                movablePictureBox1.Hide();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
