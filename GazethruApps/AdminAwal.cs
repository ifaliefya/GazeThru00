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
    public partial class AdminAwal : Form
    {
        public AdminAwal()
        {
            InitializeComponent();
            Sidepanel.Height = btn_Slideshow.Height;
            Sidepanel.Top = btn_Slideshow.Top;
            adminSlideshow1.BringToFront();
            AdminSlideshow OpenAdmin = new AdminSlideshow();
            OpenAdmin.SlideList("");
        }

        private void btn_Slideshow_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btn_Slideshow.Height;
            Sidepanel.Top = btn_Slideshow.Top;
            adminSlideshow1.BringToFront();
            AdminSlideshow Slideshow = new AdminSlideshow();
            Slideshow.SlideList("");
        }

        private void btn_Tentang_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btn_Tentang.Height;
            Sidepanel.Top = btn_Tentang.Top;
            adminInformasi1.BringToFront();
            AdminInformasi Tentang = new AdminInformasi();
            Tentang.InfoContent("");
        }
    }
}
