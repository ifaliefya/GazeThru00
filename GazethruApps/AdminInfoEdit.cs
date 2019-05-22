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
    public partial class AdminInfoEdit : Form
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aliefya\source\repos\GazeThru00\GazethruApps\GazeThruDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(connectionString);

        public AdminInfoEdit()
        {
            InitializeComponent();
            //NoInfo.Text = InfoID;
            //textBoxJudul.Text = JudulInfo;
           // String[] descs = { IsiInfo };
           // foreach (String desc in descs)
            //{
              //  textBoxIsi.Text = desc;
               // Int32 offset = textBoxIsi.Rtf.IndexOf(@"\f0\fs17") + 8;
               // Int32 len = textBoxIsi.Rtf.LastIndexOf(@"\par") - offset;
               // Console.WriteLine("{0,-15} : {1}", desc, textBoxIsi.Rtf.Substring(offset, len).Trim());
           // }
           // pictureBox1.Image = img; 
        }

        private void AdminInfoEdit_Load(object sender, EventArgs e)
        {
            EditInfoContent();
        }

        public void EditInfoContent()
        {
            
            con.Open();
            string SelectQuery = "SELECT * FROM Info WHERE No=" + AdminInformasi.infoIDchoose;
            SqlCommand command = new SqlCommand(SelectQuery, con);
            SqlDataReader read = command.ExecuteReader();
            if (read.Read())
            {
                NoInfo.Text = (read["No"].ToString());
                textBoxJudul.Text = (read["Judul"].ToString());
                textBoxIsi.Text = (read["Isi"].ToString());
                if (!Convert.IsDBNull(read["Gambar"]))
                {
                    Byte[] img = (Byte[])(read["Gambar"]);
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                }               
            }
            else
            {
                textBoxJudul.Text = "";
                textBoxIsi.Text = "";
                pictureBox1.Image = null;
            }

            con.Close();
        }

        private void buttonBrowsePict_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG; *.PNG; *.GIF)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            SqlCommand command = new SqlCommand("UPDATE Info SET Judul=@judul, Isi=@isi, Gambar=@gambar WHERE No="+ AdminInformasi.infoIDchoose, con);

            command.Parameters.Add("@judul", SqlDbType.VarChar).Value = textBoxJudul.Text;
            command.Parameters.Add("@isi", SqlDbType.VarChar).Value = textBoxIsi.Text;
            command.Parameters.Add("@gambar", SqlDbType.Image).Value = img; 

            ExecMyQuery(command, "Data Inserted");
        }

        public void ExecMyQuery(SqlCommand mcomd, string myMsg)
        {
            con.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(myMsg);

            }
            else
            {

                MessageBox.Show("Query Not Executed");

            }

            con.Close();
            this.Close();
            //??
            AdminInformasi load = new AdminInformasi();
            load.InfoContent("");

        }
    }
}
