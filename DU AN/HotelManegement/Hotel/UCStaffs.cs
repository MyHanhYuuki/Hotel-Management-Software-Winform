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

    public partial class UCStaffs : UserControl
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-L3D2584\SQLEXPRESS;Initial Catalog=HOTELDTB.MDF;Integrated Security=True");
        //Hàm hiện dữ liệu đã nhập lên trên DataGridview
        public void populate()
        {
            Con.Open();
            string Myquery = "select *from Staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuider = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridview.DataSource = ds.Tables[0];
            Con.Close();

        }
        public UCStaffs()
        {
            InitializeComponent();
        }
        //Xử lí nút Add
        private void Addbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff_tbl values(" + staffidtbl.Text + ",'" + staffnametbl.Text + "','" + staffnumtbl.Text + "','" + gendertbl.SelectedItem.ToString() + "','" + staffpasswordtbl.Text + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff successfully Added!");
            Con.Close();
            populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void UCStaffs_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void staffnumtbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void gendertbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Xử lí nút Edit
        private void Editbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string myquery = "update Staff_tbl set StaffName='" + staffnametbl.Text + "',StaffPhone='" + staffnumtbl.Text + "',Gender='" + gendertbl.SelectedItem.ToString() + "' ,StaffPassword='" + staffpasswordtbl.Text + "'where StaffId=" + staffidtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff successfully Edited!");
            Con.Close();
            populate();
        }
        //Hiện đúng thứ tự dữ liệu đã nhập trên DataGridview
        private void ClientGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            staffidtbl.Text = StaffGridview.SelectedRows[0].Cells[0].Value.ToString();
            staffnametbl.Text = StaffGridview.SelectedRows[0].Cells[1].Value.ToString();
            staffnumtbl.Text = StaffGridview.SelectedRows[0].Cells[2].Value.ToString();
            staffpasswordtbl.Text = StaffGridview.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //Xử lí nút delete
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Staff_tbl where StaffId=" + staffidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client successfully Deleted!");
            Con.Close();
            populate();
        }
        //Xử lí nút Reset
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }
        //Xử lí nút Search
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select *from Staff_tbl where StaffName ='" + staffSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuider = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
    }
}
