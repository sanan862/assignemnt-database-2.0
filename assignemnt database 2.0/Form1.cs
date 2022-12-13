using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace assignemnt_database_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            SQLiteConnection conn= new SQLiteConnection(@" data source=C:\Users\sanan\OneDrive\Documents\Databases sql lite\coursework databases question 2.db");
            conn.Open();
            string query = "Select * from Members";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt=new DataTable();
            SQLiteDataAdapter adapter= new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);
            membersDGV1.DataSource=dt;
            conn.Close();
            
        }
        private void Amenddatabase(string txtQuery)
        {
            SQLiteConnection conn = new SQLiteConnection(@"C:\Users\sanan\OneDrive\Documents\Databases sql lite\coursework databases question 2.db");
            conn.Open();
            string query=txtQuery;
            SQLiteCommand cmd=new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            IDlbl.Text = "";
            Firstnamelbl.Text = "";
            lastnamelbl.Text = "";
            DOBlbl.Text = "";
            Genderlbl.Text = "";
           
            


        }




        private void Addbtn_click(object sender, EventArgs e)
        {
            string Dbquery = "Insert into Members(Member_ID,First_name,Last_name,Date_Of_Birth,Gender_ID) values" +
                "('" + IDtxtbox.Text + "','" + txtboxfirstname.Text + "','" + txtboxlastname.Text + "','" + txtboxdob.Text + "','" + txtboxgenderid.Text + "')";
               

            Amenddatabase(Dbquery);
            LoadData();

        }
        private void Updatebtn_click(object sender, EventArgs e)
        {
            string dbquery = " Update Members set   Member_ID='" + IDlbl.Text + "' where member_ID='" + IDlbl.Text + "'";

            Amenddatabase (dbquery);
            LoadData();

           
        }

        private void deletebtn_click(object sender, EventArgs e)
        {
            string dbquery = "Delete from Members where Member_ID='" + IDlbl.Text;
            Amenddatabase(dbquery);
            LoadData();
        }




        
             

        



        private void memberslbl_Click(object sender, EventArgs e)
        {

        }

        private void memebersDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } 
}
