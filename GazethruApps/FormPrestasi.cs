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
    public partial class formPrestasi : Form
    {
        List<double> wx;
        List<double> wy;
        int lap = 0;

        KendaliTombol kendali;

        public formPrestasi()
        {
            InitializeComponent();
            wx = new List<double>();
            wy = new List<double>();
            wx.Add(0); //prev
            wy.Add(0);
            wx.Add(0); //next
            wy.Add(0);
            wx.Add(0); //back
            wy.Add(0);
            wx.Add(0); //home
            wy.Add(0);

            wx[0] = 70; //prev
            wy[0] = 170;
            wx[1] = 1080; //next
            wy[1] = 400;
            wx[2] = 100; //back
            wy[2] = 620;
            wx[3] = 1080; //home
            wy[3] = 620;

            kendali = new KendaliTombol();
            kendali.TambahTombol(btnBack, new FungsiTombol(BackTekan));
            kendali.TambahTombol(btnHome, new FungsiTombol(HomeTekan));
            kendali.TambahTombol(btnNext, new FungsiTombol(NextTekan));
            kendali.TambahTombol(btnPrev, new FungsiTombol(PrevTekan));

            kendali.Start();
        }

        void BackTekan(ArgumenKendaliTombol e)
        {
            if(e.status)
            {
                formInformasi FormInformasi = new formInformasi();
                FormInformasi.Show();
                this.Close();
            }
        }
        void HomeTekan(ArgumenKendaliTombol e)
        {
            if(e.status)
            {
                formUser Home = new formUser();
                Home.Show();
                this.Close();
            }
        }
        void NextTekan(ArgumenKendaliTombol e)
        {
            if(e.status)
            {
                prestasi21.BringToFront();
            }
        }
        void PrevTekan(ArgumenKendaliTombol e)
        {
            if(e.status)
            {
                prestasi11.BringToFront();
            }
        }

        private void formPrestasi_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnPrev.Location = new Point((int)wx[0], (int)wy[0]);
            btnNext.Location = new Point((int)wx[1], (int)wy[1]);
            btnBack.Location = new Point((int)wx[2], (int)wy[2]);
            btnHome.Location = new Point((int)wx[3], (int)wy[3]);

            if(lap==0)
            {
                wy[0]++;
                wy[1]--;
                wx[2]++;
                wx[3]--;
            }
            if(lap==1)
            {
                wy[0]--;
                wy[1]++;
                wx[2]--;
                wx[3]++;
            }
            if(wy[0]==400)
            {
                lap = 1;
            }
            if(wy[0]==170)
            {
                lap = 0;
            }
            kendali.CekTombol();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formInformasi FormInformasi = new formInformasi();
            FormInformasi.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formUser Home = new formUser();
            Home.Show();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            prestasi21.BringToFront();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            prestasi11.BringToFront();
        }
    }
}
