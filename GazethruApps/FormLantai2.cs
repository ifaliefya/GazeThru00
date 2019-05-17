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
    public partial class formLantai2 : Form
    {
        List<double> wx;
        List<double> wy;
        int lap = 0;

        public formLantai2()
        {
            InitializeComponent();
            wx = new List<double>();
            wy = new List<double>();
            wx.Add(0); //point1
            wy.Add(0);
            wx.Add(0); //point2
            wy.Add(0);
            wx.Add(0); //point3
            wy.Add(0);
            wx.Add(0); //point4
            wy.Add(0);
            wx.Add(0); //back
            wy.Add(0);

            wx[0] = 50; //point1
            wy[0] = 45;
            wx[1] = 420; //point2
            wy[1] = 95;
            wx[2] = 500; //point3
            wy[2] = 350;
            wx[3] = 50; //point4
            wy[3] = 500;
            wx[4] = 330; //back
            wy[4] = 620;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formPeta FormPeta = new formPeta();
            FormPeta.Show();
            this.Close();
        }

        private void formLantai2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            point1.Location = new Point((int)wx[0], (int)wy[0]);
            point2.Location = new Point((int)wx[1], (int)wy[1]);
            point3.Location = new Point((int)wx[2], (int)wy[2]);
            point4.Location = new Point((int)wx[3], (int)wy[3]);
            btnBack.Location = new Point((int)wx[4], (int)wy[4]);

            if (lap == 0)
            {
                wy[0]++;
                wx[1]--;
                wy[2]--;
                wx[3]++;
                wy[3] = wy[3] - 0.60f;
                wx[4]++;
            }
            if (lap == 1)
            {
                wy[0]--;
                wx[1]++;
                wy[2]++;
                wx[3]--;
                wy[3] = wy[3] + 0.60f;
                wx[4]--;
            }
            if (wx[4] == 600)
            {
                lap = 1;
            }
            if (wx[4] == 330)
            {
                lap = 0;
            }
        }
    }
}
