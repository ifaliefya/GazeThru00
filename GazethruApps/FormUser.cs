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
    public partial class formUser : Form
    {
        List<double> wx;
        List<double> wy;
        int lap = 0;

        KendaliTombol kendali;

        public formUser()
        {
            InitializeComponent();
            wx = new List<double>();
            wy = new List<double>();
            wx.Add(0);
            wy.Add(0);
            wx.Add(0);
            wy.Add(0);
            wx.Add(0);
            wy.Add(0);

            wx[0] = 100; //lokasi awal btnInformasi
            wy[0] = 200;
            wx[1] = 1130; //lokasi awal btnPeta
            wy[1] = 430;
            wx[2] = 460; //lokasi awal btnBack
            wy[2] = 580;

            kendali = new KendaliTombol();
            kendali.TambahTombol(btnInfo, new FungsiTombol(InfoTekan));
            kendali.TambahTombol(btnPeta, new FungsiTombol(PetaTekan));
            kendali.TambahTombol(btnBack, new FungsiTombol(BackTekan));

            kendali.Start();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnInfo.Location = new Point((int)wx[0], (int)wy[0]);
            btnPeta.Location = new Point((int)wx[1], (int)wy[1]);
            btnBack.Location = new Point((int)wx[2], (int)wy[2]);

            if (lap == 0)
            {
                wy[0]++;
                wy[1]--;
                wx[2]++;
            }
            if (lap == 1)
            {
                wy[0]--;
                wy[1]++;
                wx[2]--;
            }
            if (wy[0] == 430)
            {
                lap = 1;
            }
            if (wy[0] == 200)
            {
                lap = 0;
            }

            kendali.CekTombol();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formAwal FormHome = new formAwal();
            FormHome.Show();
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            formInformasi FormInformasi = new formInformasi();
            FormInformasi.Show();
            this.Close();
        }

        private void btnPeta_Click(object sender, EventArgs e)
        {
            formPeta FormPeta = new formPeta();
            FormPeta.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formAwal FormHome = new formAwal();
            FormHome.Show();
            this.Hide();
        }
        void InfoTekan(ArgumenKendaliTombol e)
        {
            if (e.status)
            {
                formInformasi FormInformasi = new formInformasi();
                FormInformasi.Show();
                this.Hide();
            }
        }
        void PetaTekan(ArgumenKendaliTombol e)
        {
            if (e.status)
            {
                formPeta FormPeta = new formPeta();
                FormPeta.Show();
                this.Hide();
            }
        }
        void BackTekan(ArgumenKendaliTombol e)
        {
            if(e.status)
            {
                formAwal FormHome = new formAwal();
                FormHome.Show();
                this.Hide();
            }
        }
    }
}
