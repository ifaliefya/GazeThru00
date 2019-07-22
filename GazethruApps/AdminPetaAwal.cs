using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace GazethruApps
{
    public partial class AdminPetaAwal : UserControl
    {
        private static AdminPetaAwal _instance;
        public static AdminPetaAwal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminPetaAwal();
                return _instance;
            }
        }

        public AdminPetaAwal()
        {
            InitializeComponent();
        }

        public static int PetaIDchoose;
        public static int PreviewID;
        public static int FirstID;
        public static int LastID;
        public static bool addShow;

        SqlConnection con = new SqlConnection(Properties.Settings.Default.sqlcon);

        private void AdminPetaAwal_Load(object sender, EventArgs e)
        {
            addShow = false;
            AddView(addShow);

            PetaList();
            GetFirstID(con);
            GetLastID(con);

            PreviewID = FirstID;
            PreviewImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PetaList();
        }

        public void PetaList()
        {
            SqlCommand command = new SqlCommand("SELECT No, Judul FROM Peta", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command); //adapter perintah query sql

            DataTable table = new DataTable(); //bikin DataTable namanya table                  

            adapter.Fill(table); //perintah query sql disimpan di table

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = table; //datagrid datasourcenya dari table

            CreateButtonColumn();
            CreateDeleteButton();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CreateButtonColumn()
        {
            DataGridViewButtonColumn buttonCol = new DataGridViewButtonColumn();
            buttonCol.HeaderText = "";
            buttonCol.Name = "Detail";
            buttonCol.Text = "Detail";

            buttonCol.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(buttonCol);

        }

        //Add a delete button column. 
        private void CreateDeleteButton()
        {
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.HeaderText = "";
            deleteBtn.Name = "Delete";
            deleteBtn.Text = "Delete";

            deleteBtn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(deleteBtn);
        }

        void PreviewImage()
        {
            con.Open();
            string SelectQuery = "SELECT Judul, Gambar FROM Peta WHERE No=" + PreviewID;
            SqlCommand command = new SqlCommand(SelectQuery, con);
            SqlDataReader read = command.ExecuteReader();
            if (read.Read())
            {
                string judul = (String)(read["Judul"]);
                labelJudulPeta.Text = judul;

                Byte[] img = (Byte[])(read["Gambar"]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
                pictureBox1.Image = null;
            }
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["No"].ReadOnly = true;
            this.dataGridView1.Rows[e.RowIndex].Cells["Judul"].ReadOnly = true;

            PetaIDchoose = (int)dataGridView1.Rows[e.RowIndex].Cells["No"].Value;

            if (e.ColumnIndex == dataGridView1.Columns["Detail"].Index && e.RowIndex >= 0)
            {

                //AdminSlideEdit editInfo = new AdminSlideEdit(this);
                //editInfo.Show();
                AdminPetaNew addNewLantai = new AdminPetaNew();
                addNewLantai.Show();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {


                SqlCommand command = new SqlCommand("DELETE FROM Peta WHERE No=" + PetaIDchoose, con);

                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExecMyQuery(command, "Data Deleted");
                    GetLastID(con);
                }

            }
            else
            {
                PreviewID = PetaIDchoose;
                PreviewImage();
            }
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
            PetaList();
            GetLastID(con);
        }

        public void GetFirstID(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(
              "SELECT MIN(No) FROM Peta", connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    FirstID = reader.GetInt32(0);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            connection.Close();
        }

        public void GetLastID(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(
              "SELECT MAX(No) FROM Peta", connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    LastID = reader.GetInt32(0);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            connection.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //addShow = true;
            //AddView(addShow);
            PetaIDchoose = 0;
            AdminPetaNew addNewLantai = new AdminPetaNew();
            addNewLantai.Show();

        }
        public void AddView (Boolean show)
        {
            panelEdit.Visible = show;
            textBoxJudul.Visible = show;
            btnCancel.Visible = show;
            btnInsert.Visible = show;
            pictureBox1.Enabled = show;
            if (show == true)
            {
                //Nanti diganti click here to choose image
                pictureBox1.Image = null;
            }
            else
            {
                PreviewID = FirstID;
                PreviewImage();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            addShow = false;
            AddView(addShow);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.JPG; *.PNG; *.GIF)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void textBoxJudul_Click(object sender, EventArgs e)
        {
            textBoxJudul.Text = null;
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null | textBoxJudul == null )
            {
                MessageBox.Show("Masukkan gambar dan isi judul terlebih dahulu");
            }

            else
            {
                try
                {
                    string InsertQuery =
                    "DBCC CHECKIDENT (Peta, RESEED," + LastID + "); " + //ERROR DBCC adalah menyalahi aturan increment dan unique, semoga tidak error
                    "INSERT INTO Peta(Judul, Gambar) VALUES (@judul, @gambar);";
                    SqlCommand command = new SqlCommand(InsertQuery, con);

                    command.Parameters.Add("@judul", SqlDbType.VarChar).Value = textBoxJudul.Text;
                    command.Parameters.Add("@gambar", SqlDbType.Image).Value = GetPic(pictureBox1.Image);
                    ExecMyQuery(command, "Data Inserted");
                    addShow = false;
                    AddView(addShow);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
    }
}
