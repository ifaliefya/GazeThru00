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
    public partial class formLantai1 : Form
    {
        List<double> wx;
        List<double> wy;
        int lap = 0;
        public formLantai1()
        {
            InitializeComponent();
            wx = new List<double>();
            wy = new List<double>();
            wx.Add(0); //down
            wy.Add(0);
            wx.Add(0); //left
            wy.Add(0);
            wx.Add(0); //up
            wy.Add(0);
            wx.Add(0); //right
            wy.Add(0);
            wx.Add(0); //kembali
            wy.Add(0);

            wx[0] = 28; //down
            wy[0] = 220;
            wx[1] = 400; //left
            wy[1] = 54;
            wx[2] = 550; //up
            wy[2] = 450;
            wx[3] = 170; //right
            wy[3] = 653;
            wx[4] = 915; //back
            wy[4] = 653;
        }

        private void FormLantai1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnDown.Location = new Point((int)wx[0], (int)wy[0]);
            btnLeft.Location = new Point((int)wx[1], (int)wy[1]);
            btnUp.Location = new Point((int)wx[2], (int)wy[2]);
            btnRight.Location = new Point((int)wx[3], (int)wy[3]);
            btnBack.Location = new Point((int)wx[4], (int)wy[4]);

            if (lap==0)
            {
                wy[0]++;
                wx[1]--;
                wy[2]--;
                wx[3]++;
                wx[4]++;
                wy[4] = wy[4] - 0.60f;
                
            }
            if (lap == 1)
            {
                wy[0]--;
                wx[1]++;
                wy[2]++;
                wx[3]--;
                wx[4]--;
                wy[4] = wy[4] + 0.60f;
                
            }
            if(wy[0]==450)
            {
                lap = 1;
            }
            if(wy[0]==220)
            {
                lap = 0;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formPeta FormPeta = new formPeta();
            FormPeta.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void point3_Click(object sender, EventArgs e)
        {

        }
    }
}
