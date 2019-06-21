using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazethruApps
{
    public partial class formLantai3 : Form
    {
        List<double> wx;
        List<double> wy;
        int lap = 0;

        public formLantai3()
        {
            InitializeComponent();
            wx = new List<double>();
            wy = new List<double>();
            wx.Add(0); //next
            wy.Add(0);
            wx.Add(0); //prev
            wy.Add(0);
            wx.Add(0); //back
            wy.Add(0);

            wx[0] = 1030; //next
            wy[0] = 370;
            wx[1] = 255; //prev
            wy[1] = 140;
            wx[2] = 470; //back
            wy[2] = 640;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formPeta FormPeta = new formPeta();
            FormPeta.Show();
            this.Close();
        }

        private void formLantai3_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnNext.Location = new Point((int)wx[0], (int)wy[0]);
            btnPrev.Location = new Point((int)wx[1], (int)wy[1]);
            btnBack.Location = new Point((int)wx[2], (int)wy[2]);

            if (lap == 0)
            {
                wy[0]--;
                wy[1]++;
                wx[2]++;
            }
            if (lap == 1)
            {
                wy[0]++;
                wy[1]--;
                wx[2]--;
            }
            if (wy[0] == 140)
            {
                lap = 1;
            }
            if (wy[0] == 370)
            {
                lap = 0;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lantai3_021.BringToFront();
            picPointer.Location = new Point(705, 285); 
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            lantai3_011.BringToFront();
            picPointer.Location = new Point(705, 230);
        }
    }
}
