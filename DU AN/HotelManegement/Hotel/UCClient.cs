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

namespace Hotel
{
    public partial class UCClient : UserControl
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-L3D2584\SQLEXPRESS;Initial Catalog=HOTELDTB.MDF;Integrated Security=True");
       // Hàm hiện dữ liệu đã nhập lên trên DataGridview
        public void populate()
        {
            Con.Open();
            string Myquery = "select *from Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuider = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridview.DataSource = ds.Tables[0];
            Con.Close();

        }
        public UCClient()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void UCClient_LocationChanged(object sender, EventArgs e)
        {

        }

        private void UCClient_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }
        //Xử lí nút Add
        private void Addbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client_tbl values(" + clientidtbl.Text + ",'" 
            + clientnametbl.Text + "','" + clientnumtbl.Text + "','" + countrytbl.SelectedItem.ToString() + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client successfully Added!");
            Con.Close();
            populate();
        }
        //Hiện đúng thứ tự dữ liệu đã nhập trên DataGridview
        private void ClientGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clientidtbl.Text = ClientGridview.SelectedRows[0].Cells[0].Value.ToString();
            clientnametbl.Text = ClientGridview.SelectedRows[0].Cells[1].Value.ToString();
            clientnumtbl.Text = ClientGridview.SelectedRows[0].Cells[2].Value.ToString();
        }
        //Xử lí nút Edit
        private void Editbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery="update Client_tbl set ClientName='"+clientnametbl.Text+"',ClientPhone='"+clientnumtbl.Text+"',ClientCountry='"+countrytbl.SelectedItem.ToString()+"' where ClientId=" + clientidtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client successfully Edited!");
            Con.Close();
            populate();        
        }
        //Xử lí nút Delete
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query="delete from Client_tbl where ClientId=" + clientidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client successfully Deleted!");
            Con.Close();
            populate();
        }
        //Xử lí nút Search
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select *from Client_tbl where ClientName ='"+ClientSearch.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuider = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        //xử lí nút Reset
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
