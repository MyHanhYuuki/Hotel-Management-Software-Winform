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
    public partial class UCRooms : UserControl
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-L3D2584\SQLEXPRESS;Initial Catalog=HOTELDTB.MDF;Integrated Security=True");
        //Hàm hiện dữ liệu đã nhập lên trên DataGridview
        public void populate()
        {
            Con.Open();
            string Myquery = "select *from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuider = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridview.DataSource = ds.Tables[0];
            Con.Close();

        }
        public UCRooms()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //Xử lí nút Add
        private void Addbtn_Click(object sender, EventArgs e)
        {
            string check;
            if (yesradio.Checked == true)
                check = "Free";
            else check = "Busy";
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Room_tbl values(" + roomidtbl.Text + ",'" + roomphonetbl.Text + "','" + check + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room successfully Added!");
            Con.Close();
            populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void UCRooms_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }
        //Xử lí nút Edit
        private void Editbtn_Click(object sender, EventArgs e)
        {
            string check;
            if (yesradio.Checked == true)
                check = "Free";
            else check = "Busy";
            Con.Open();
            string myquery = "update Room_tbl set RoomPhone='" + roomphonetbl.Text + "',RoomFree='" + check + "'where RoomId=" + roomidtbl.Text + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room successfully Edited!");
            Con.Close();
            populate();
        }
        //Hiện nút trật tự của Datagridview
        private void RoomGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomidtbl.Text = RoomGridview.SelectedRows[0].Cells[0].Value.ToString();
            roomphonetbl.Text = RoomGridview.SelectedRows[0].Cells[1].Value.ToString();
           
        }
        //Xử lí nút Delete
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "delete from Room_tbl where RoomId=" + roomidtbl.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room successfully Deleted!");
            Con.Close();
            populate();
        }
        //Xử lí nút search
        private void searchbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select *from Room_tbl where RoomId ='" + roomSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuider = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        //Xử lí nút Reset
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
