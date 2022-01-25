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

    public partial class UCReservations : UserControl
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-L3D2584\SQLEXPRESS;Initial Catalog=HOTELDTB.MDF;Integrated Security=True");
        //Hàm hiện dữ liệu đã nhập lên trên DataGridview
        public void populate()
        {
            Con.Open();
            string Myquery = "select *from Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuider = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ResGridview.DataSource = ds.Tables[0];
            Con.Close();

        }
       //Từ bảng Room_tbl lấy ra những RoomId còn Free điền vào RoomComboBox
        public void FillRoomCombo()
        {
            Con.Open();
            string roomstate = "Free";
            SqlCommand cmd = new SqlCommand("select RoomId from Room_tbl where RoomFree='"+roomstate+"'", Con);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomId", typeof(int));
            dt.Load(rd);
            roomidtbl.ValueMember = "RoomId";
            roomidtbl.DataSource = dt;
            Con.Close();
        }
        //Từ bảng Client_tbl lấy ra CLientName điền vào ClientNameComboBox
        public void FillClientCombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ClientName from Client_tbl", Con);
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName", typeof(string));
            dt.Load(rd);
            clientnametbl.ValueMember = "ClientName";
            clientnametbl.DataSource = dt;
            Con.Close();
        }
        public UCReservations()
        {
            InitializeComponent();
        }
       //Update lại RoomFree thành Busy của bảng Room_tbl sau khi phòng được đặt của Reservations và xóa RoomId khỏi RoomIdComboBox
        public void updateroomstate()
        {
            Con.Open();
            string newstate = "Busy";
            string myquery = "update Room_tbl set RoomFree='" + newstate + "'where RoomId=" + Convert.ToInt32(roomidtbl.SelectedValue.ToString()) + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Reservation successfully Edited!");
            Con.Close();
            FillRoomCombo();
        }
       //Update lại RoomFree của thành Free của bảng Room_tbl sau khi xóa đặt phòng và thêm RoomId vào ROomComboBox
        public void updateroomondelete()
        {
            Con.Open();
            string newstate = "Free";
            int roomid= Convert.ToInt32(ResGridview.SelectedRows[0].Cells[2].Value.ToString());
            string myquery = "update Room_tbl set RoomFree='" + newstate + "'where RoomId=" + roomid + ";";
            SqlCommand cmd = new SqlCommand(myquery, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Reservation successfully Edited!");
            Con.Close();
            FillRoomCombo();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongTimeString();
        }
        DateTime today;
        private void UCReservations_Load(object sender, EventArgs e)
        {
            today = datein.Value;
            datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            FillRoomCombo();
            FillClientCombo();
            populate();
        }
        //Xử lí ngày đặt phòng
        private void datein_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(datein.Value, today);
            if (res < 0)
                MessageBox.Show("Wrong date for Reservation!");
        }
        //Xử lí ngày trả phòng
        private void dateout_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateout.Value, datein.Value);
            if (res < 0)
                MessageBox.Show("Wrong dateout. Check again!");
        }
        //Xử lí nút Add
        private void Addbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservation_tbl values(" + residtbl.Text + ",'" + clientnametbl.SelectedValue.ToString() + "','" + roomidtbl.SelectedValue.ToString() + "','" + datein.Value + "','" + dateout.Value + "')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation successfully Added!");
            Con.Close();
            updateroomstate();
            populate();
        }

        private void clientnametbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            residtbl.Text = ResGridview.SelectedRows[0].Cells[0].Value.ToString();
        }
        //Xử lí nút Edit
        private void Editbtn_Click(object sender, EventArgs e)
        {
            if(residtbl.Text=="")
            {
                MessageBox.Show("ResId is empty. Please check again!!");
            }
            else
            {
                Con.Open();
                string myquery = "update Reservation_tbl set Client='" + clientnametbl.SelectedValue.ToString() + "',Room='" + roomidtbl.SelectedValue.ToString() + "',DateIn='" + datein.Value.ToString() + "',DateOut='" + dateout.Value.ToString() + "'where ResId=" + residtbl.Text + ";";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation successfully Edited!");
                Con.Close();
                populate();
            }
            
        }
        //Xử lí nút Delete
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (residtbl.Text == "")
            {
                MessageBox.Show("ResId is empty. Please check again!!");
            }
            else
            {
                Con.Open();
                string query = "delete from Reservation_tbl where ResId=" + residtbl.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation successfully Deleted!");
                Con.Close();
                updateroomondelete();
                populate();
            }
            
        }
        //Xử lí nút Search
        private void searchbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select *from Reservation_tbl where Client ='" + resSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuider = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ResGridview.DataSource = ds.Tables[0];
            Con.Close();
        }
        //Xử lí nút Reset
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
