using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lonpos505GameSolver
{
    public partial class MainForm : Form
    {
        List<PictureBox> boardPictureList = new List<PictureBox>();      
        

        public MainForm()
        {
            InitializeComponent();

            for(int i = 1; i < 56; i++)
                boardPictureList.Add((PictureBox)Controls.Find("pictureBox" + i, true)[0]);
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i< boardPictureList.Count(); i++)
            {
                if(boardPictureList[i].Bounds.IntersectsWith(movablePictureBox1.Bounds) && movablePictureBox1.Visible && Control.MouseButtons != MouseButtons.Left)
                {
                    movablePictureBox1.Bounds = boardPictureList[i].Bounds;
                }

            }
        }
    }
}
