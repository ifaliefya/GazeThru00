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
    public partial class AdminSlideshow : UserControl
    {
        private static AdminSlideshow _instance;
        public static AdminSlideshow Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminSlideshow();
                return _instance;
            }
        }

        public AdminSlideshow()
        {
            InitializeComponent();
        }

        public static int infoIDchoose;
        public static string EditMode;
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aliefya\source\repos\GazeThru00\GazethruApps\GazeThruDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con = new SqlConnection(connectionString);

        private void AdminSlideshow_Load(object sender, EventArgs e)
        {
            SlideList("");
        }

        public void SlideList(string valueToSearch)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Slider WHERE CONCAT(No, Judul, Tanggal, Show) LIKE '%" + valueToSearch + "%'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command); //adapter perintah query sql

            DataTable table = new DataTable(); //bikin DataTable namanya table                  

            adapter.Fill(table); //perintah query sql disimpan di table

            dataGridView1.RowTemplate.Height = 70;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = table; //datagrid datasourcenya dari table

            CreateImageColumn();
            CreateButtonColumn();
            CreateDeleteButton();
            //CreateShowCheckbox();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SlideList(textBoxSearch.Text);
        }

        private void CreateImageColumn()
        {
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[3];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        //Add a edit button column. 
        private void CreateButtonColumn()
        {
            DataGridViewButtonColumn buttonCol = new DataGridViewButtonColumn();
            buttonCol.HeaderText = "";
            buttonCol.Name = "Edit";
            buttonCol.Text = "Edit";

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditMode = "New";
            AdminSlideNew addSlider = new AdminSlideNew();
            addSlider.Show();
        }

        //Add checkbox hide show
        private void CreateShowCheckbox ()
        {
            DataGridViewCheckBoxColumn showCheck = new DataGridViewCheckBoxColumn();
            showCheck.HeaderText = "Show";
            showCheck.Name = "Show";


            dataGridView1.Columns.Add(showCheck);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SlideList("");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = 0;
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                Int32.TryParse(dataGridView1.Rows[e.RowIndex].Cells["No"].Value.ToString(), out selected);
                infoIDchoose = selected;
                EditMode = "Edit";
                AdminSlideNew editInfo = new AdminSlideNew();
                editInfo.Show();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {

                Int32.TryParse(dataGridView1.Rows[e.RowIndex].Cells["No"].Value.ToString(), out selected);
                infoIDchoose = selected;
                SqlCommand command = new SqlCommand("DELETE FROM Info WHERE No=" + infoIDchoose, con);

                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ExecMyQuery(command, "Data Deleted");
                }

            }
            else
            {
                return;
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
            SlideList("");

        }
    }


}
