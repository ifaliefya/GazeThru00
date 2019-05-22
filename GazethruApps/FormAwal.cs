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
    public partial class formAwal : Form
    {
        List<double> wx;
        List<double> wy;
        int lap = 0;
        public formAwal()
        {
            InitializeComponent();

            wx = new List<double>();
            wy = new List<double>();
            wx.Add(0);
            wy.Add(0);

            wx[0] = 710; //lokasi awal
            wy[0] = 520;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
            //timer2.Interval = 1;
            //timer2.Start();
        }

        //private int imageNumber = 1;
        //private void LoadNextImage()
        //{
        //    if (imageNumber == 4)
        //    {
        //        imageNumber = 1;
        //    }
        //    pictureBox1.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
        //    imageNumber++;
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            btnUser.Location = new Point((int)wx[0], (int)wy[0]);

            if (lap == 0) //titik awal
            {
                wx[0]++;         
            }

            if (lap == 1) //titik akhir, balik
            {
                wx[0]--;
            }

            if (wx[0] == 940)
            {
                lap = 1; //titik akhir
            }

            if (wx[0] == 710)
            {
                lap = 0;
            }
          
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            formUser FormUser = new formUser();
            FormUser.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin LoginAdmin = new AdminLogin();
            LoginAdmin.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           // LoadNextImage();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
           // LoadNextImage();
        }
    }
}
