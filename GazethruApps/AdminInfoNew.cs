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
    public partial class AdminInfoNew : Form
    {
        private readonly  AdminInformasi _InfoAwal;
        public AdminInfoNew(AdminInformasi InfoAwal)
        {
            _InfoAwal = InfoAwal;
            InitializeComponent();
            ShowHide.Checked = true;
        }

        public static int infoIDlast;
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aliefya\source\repos\GazeThru00\GazethruApps\GazeThruDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(connectionString);
        
        private void buttonBrowsePict_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG; *.PNG; *.GIF)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void AdminInfoNew_Load(object sender, EventArgs e)
        {
            HasRows(con);
            NoInfo.Text = infoIDlast.ToString();
            //NoInfo.Text = "";
        }


        public void HasRows(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(
              "SELECT MAX(No) FROM Info", connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    infoIDlast = reader.GetInt32(0) + 1;
                    //Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                    //    reader.GetString(1));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            connection.Close();
        }

        public void GetLastID()
        {
            con.Open();
            string SelectQuery = "SELECT MAX(No) + 1 as maxVal FROM Info";
            //string GetID =
            //  "DECLARE @maxVal INT;" +
            //  "SELECT @maxVal = ISNULL(MAX(No), 0) + 1 FROM Info;";
            SqlCommand command = new SqlCommand(SelectQuery, con);
            //command.Parameters.Add("MaxNo", SqlDbType.Int);
            //command.Parameters["@MaxNo"].Value = infoIDlast;
            NoInfo.Text = command.ExecuteScalar().ToString();
            //SqlDataReader read = command.ExecuteReader();
            //if (read.Read())
            //{
            //    NoInfo.Text = (read["@MaxNo"].ToString());
            //}
            //else
            //{
            //    NoInfo.Text = "";
            //}
            con.Close();
        }

        private byte[] GetPic(Image img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Position = 0;
                byte[] data = new byte[stream.Length];
                stream.Read(data, 0, data.Length);
                return data;
            }
        }
        
        private void buttonInsert_Click(object sender, EventArgs e)
        {

            string InsertQuery =
                //"DECLARE @maxVal INT;"+
                //"SELECT @maxVal = ISNULL(MAX(No), 0) + 1 FROM Info;"+
                //"DBCC CHECKIDENT (Info, RESEED, @maxVal); " +
                "INSERT INTO Info(Judul, Isi, Show, Gambar) VALUES (@judul , @isi, @show, @gambar);";
            SqlCommand command = new SqlCommand(InsertQuery, con);

            command.Parameters.Add("@judul", SqlDbType.VarChar).Value = textBoxJudul.Text;
            command.Parameters.Add("@isi", SqlDbType.VarChar).Value = textBoxIsi.Text;
            command.Parameters.Add("@show", SqlDbType.Bit).Value = ShowHide.Checked;
            if (pictureBox1.Image == null)
            {
                command.Parameters.Add("@gambar", SqlDbType.VarBinary).Value = DBNull.Value;
            }
            else
            {
                command.Parameters.Add("@gambar", SqlDbType.Image).Value = GetPic(pictureBox1.Image);
            }

            ExecMyQuery(command, "Data Inserted");
        }

        public void ExecMyQuery(SqlCommand mcomd, string myMsg)
        {
                con.Open();
                if (mcomd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(myMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Query Not Executed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
                _InfoAwal.InfoContent("");
                this.Close();
        }
    }
}
