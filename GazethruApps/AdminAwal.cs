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
        //private readonly formAwal _Home;
        public static string Category;

        public AdminAwal()
        {
            InitializeComponent();
            //_Home = Home;
            Sidepanel.Height = btn_Slideshow.Height;
            Sidepanel.Top = btn_Slideshow.Top;
            if (!panelUC.Controls.Contains(AdminSlideshow.Instance))
            {
                panelUC.Controls.Add(AdminSlideshow.Instance);
                AdminSlideshow.Instance.Dock = DockStyle.Fill;
                AdminSlideshow.Instance.BringToFront();
                AdminSlideshow Slideshow = new AdminSlideshow();
                Slideshow.SlideList("");
            }
            else
                AdminSlideshow.Instance.BringToFront();
        }

        private void btn_Slideshow_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btn_Slideshow.Height;
            Sidepanel.Top = btn_Slideshow.Top;
            //adminSlideshow1.BringToFront();
            //AdminSlideshow Slideshow = new AdminSlideshow();
            //Slideshow.SlideList("");
            if (!panelUC.Controls.Contains(AdminSlideshow.Instance))
            {
                panelUC.Controls.Add(AdminSlideshow.Instance);
                AdminSlideshow.Instance.Dock = DockStyle.Fill;
                AdminSlideshow.Instance.BringToFront();
                AdminSlideshow Slideshow = new AdminSlideshow();
                Slideshow.SlideList("");
            }
            else
                AdminSlideshow.Instance.BringToFront();
        }

        private void btn_Tentang_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btn_Tentang.Height;
            Sidepanel.Top = btn_Tentang.Top;

            //adminInformasi1.BringToFront();
            //AdminInformasi Tentang = new AdminInformasi();
            //Tentang.InfoContent("");
            if (!panelUC.Controls.Contains(AdminInformasi.Instance)||Category!="Info")
            {
                Category = "Info";
                panelUC.Controls.Add(AdminInformasi.Instance);
                AdminInformasi.Instance.Dock = DockStyle.Fill;
                AdminInformasi.Instance.BringToFront();
                AdminInformasi Tentang = new AdminInformasi();
                Tentang.InfoContent("");
            }
            else
                AdminInformasi.Instance.BringToFront();
        }

        private void btn_Prestasi_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btn_Prestasi.Height;
            Sidepanel.Top = btn_Prestasi.Top;

            if (!panelUC.Controls.Contains(AdminPrestasi.Instance) || Category != "Prestasi")
            {
                Category = "Prestasi";
                panelUC.Controls.Add(AdminPrestasi.Instance);
                AdminPrestasi.Instance.Dock = DockStyle.Fill;
                AdminPrestasi.Instance.BringToFront();
                AdminPrestasi Pres = new AdminPrestasi();
                Pres.PrestasiContent("");
            }
            else
                AdminPrestasi.Instance.BringToFront();
        }

        private void btn_Kegiatan_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btn_Kegiatan.Height;
            Sidepanel.Top = btn_Kegiatan.Top;

            if (!panelUC.Controls.Contains(AdminKegiatan.Instance) || Category != "Kegiatan")
            {
                Category = "Kegiatan";
                panelUC.Controls.Add(AdminKegiatan.Instance);
                AdminKegiatan.Instance.Dock = DockStyle.Fill;
                AdminKegiatan.Instance.BringToFront();
                AdminKegiatan Keg = new AdminKegiatan();
                Keg.KegiatanContent("");
            }
            else
                AdminKegiatan.Instance.BringToFront();
        }

        private void btn_Peta_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btn_Peta.Height;
            Sidepanel.Top = btn_Peta.Top;

            if (!panelUC.Controls.Contains(AdminPetaAwal.Instance))
            {
                panelUC.Controls.Add(AdminPetaAwal.Instance);
                AdminPetaAwal.Instance.Dock = DockStyle.Fill;
                AdminPetaAwal.Instance.BringToFront();
                AdminPetaAwal Peta = new AdminPetaAwal();
                //Peta.KegiatanContent("");
            }
            else
                AdminPetaAwal.Instance.BringToFront();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            formAwal Home = new formAwal();
            Home.Show();
            this.Hide();
        }

        
    }
}
