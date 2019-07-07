using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace GazethruApps
{


    public partial class formAwal : Form
    {
        //private static formAwal _instance;
        //public static formAwal Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new formAwal();
        //        return _instance;
        //    }
        //}

        List<double> wx;
        List<double> wy;
        int lap = 0;

        KendaliTombol kendali;
        public formAwal()
        {
            InitializeComponent();
            kendali = new KendaliTombol();

            wx = new List<double>();
            wy = new List<double>();
            wx.Add(0);
            wy.Add(0);

            wx[0] = 870; //lokasi awal
            wy[0] = 520;

            kendali.TambahTombol(btnUser, new FungsiTombol(TombolUserTekan));

            kendali.Start();
            GetLastID(con);
        }

        private static int imageNumber = 1;
        private static int LastID;
        //public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aliefya\source\repos\GazeThru00\GazethruApps\GazeThruDB.mdf;Integrated Security=True;Connect Timeout=30";
        //SqlConnection con = new SqlConnection(connectionString);
        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);

        void TombolUserTekan(ArgumenKendaliTombol e)
        {
            if (e.status)
            {
                formUser FormUser = new formUser();
                FormUser.Show();
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formAwal_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
            timer2.Start();
        }

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

            if (wx[0] == 1000)
            {
                lap = 1; //titik akhir
            }

            if (wx[0] == 770)
            {
                lap = 0;
            }

            //kendali.CekTombol();
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

        private void buttonAdmin2_Click(object sender, EventArgs e)
        {
            //AdminLogin LoginAdmin = new AdminLogin();
            //LoginAdmin.Show();
            AdminAwal test = new AdminAwal();
            test.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        public void LoadNextImage ()
        {
            con.Open();
            string SelectQuery = "SELECT * FROM Slider WHERE No=" + imageNumber;
            SqlCommand command = new SqlCommand(SelectQuery, con);
            SqlDataReader read = command.ExecuteReader();
            if (read.Read())
            {
                //Boolean check = Convert.ToBoolean(read["Show"].ToString());
                Boolean check = (Boolean)(read["Show"]);

                if (check == true)
                {
                    Byte[] img = (Byte[])(read["Gambar"]);
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                //else
                //{
                //    imageNumber++;
                //}
            }
            else
            {
                pictureBox1.Image = null;
            }
            con.Close();
            if (imageNumber == LastID)
            {
                imageNumber = 1;
            }
            else
            {
                imageNumber++;
            }
        }

        public void GetLastID(SqlConnection connection)
        {

            SqlCommand command = new SqlCommand(
              "SELECT MAX(No) FROM Slider", connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    LastID = reader.GetInt32(0)+1;
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            connection.Close();
        }
    }           
}

