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

namespace GazethruApps
{
    public partial class AdminInformasi : UserControl
    {
        public AdminInformasi()
        {
            InitializeComponent();
        }

        public static int infoIDchoose;
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aliefya\source\repos\GazeThru00\GazethruApps\GazeThruDB.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection con = new SqlConnection(connectionString);
        

        private void AdminInformasi_Load(object sender, EventArgs e)
        {
            InfoContent("");
        }

        public void InfoContent(string valueToSearch)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Info WHERE CONCAT(No, Judul, Isi) LIKE '%" + valueToSearch + "%'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command); //adapter perintah query sql

            DataTable table = new DataTable(); //bikin DataTable namanya table                  

            adapter.Fill(table); //perintah query sql disimpan di table

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.AllowUserToAddRows = false;
      
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = table; //datagrid datasourcenya dari table

            CreateImageColumn();
            CreateButtonColumn();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void CreateImageColumn()
        {
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridView1.Columns[3];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        //Add a button column. 
        private void CreateButtonColumn()
        {
            DataGridViewButtonColumn buttonCol = new DataGridViewButtonColumn();
            buttonCol.HeaderText = "";
            buttonCol.Name = "Edit";
            buttonCol.Text = "Edit";

            // Use the Text property for the button text for all cells rather
            // than using each cell's value as the text for its own button.
            buttonCol.UseColumnTextForButtonValue = true;

            // Add the button column to the control.
            //dataGridView1.Columns.Insert(4, buttonCol);
            dataGridView1.Columns.Add(buttonCol);

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            InfoContent(textBoxSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminInfoNew addInfo = new AdminInfoNew();
            addInfo.Show();
        }

        protected void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex !=
                dataGridView1.Columns["edit"].Index) return;

            // Retrieve the content info ID.
            //int infoID = (Int32)dataGridView1[0, e.RowIndex].Value;

            int selected = 0;
            Int32.TryParse(dataGridView1.Rows[e.RowIndex].Cells["No"].Value.ToString(), out selected);
            infoIDchoose = selected;

            AdminInfoEdit editInfo = new AdminInfoEdit();
            editInfo.Show();

            //if (e.RowIndex>0) { 
            //    string InfoID = dataGridView1.SelectedRows[1].Cells["No"].Value.ToString();
            //    string JudulInfo = dataGridView1.SelectedRows[1].Cells["Judul"].Value.ToString();
            //    string IsiInfo = dataGridView1.SelectedRows[1].Cells["Isi"].Value.ToString();
            //   Image imgInfo = (Image)dataGridView1.SelectedRows[1].Cells["Gambar"].Value;

            //    AdminInfoEdit editInfo = new AdminInfoEdit(InfoID, JudulInfo,IsiInfo, imgInfo);
            //    editInfo.Show();
           // }
        }
    }
}
