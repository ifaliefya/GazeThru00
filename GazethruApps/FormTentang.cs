﻿using System;
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
    public partial class formTentang : Form
    {
        List<double> wx;
        List<double> wy;
        int lap = 0;

        public formTentang()
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

            wx[0] = 70;//prev
            wy[0] = 170;
            wx[1] = 1080;//next
            wy[1] = 400;
            wx[2] = 100;//back
            wy[2] = 620;
            wx[3] = 1080; //home
            wy[3] = 620;
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

        private void formTentang_Load(object sender, EventArgs e)
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
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            visiElektro2.BringToFront();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            visiTeti2.BringToFront();
        }

        private void visiElektro2_Load(object sender, EventArgs e)
        {

        }
    }
}
