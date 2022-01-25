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
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-L3D2584\SQLEXPRESS;Initial Catalog=HOTELDTB.MDF;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Focus();
        }
        //Nhấn login để đăng nhập
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string login="select  *from Staff_tbl where StaffName='"+usernametb.Text+"'and StaffPassword='"+passwordtb.Text+"' ";
            cmd = new SqlCommand(login, Con);
            SqlDataReader rd = cmd.ExecuteReader();
            if(rd.Read()==true)
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usernametb.Text = "";
                passwordtb.Text = "";
            }
            Con.Close();
        }
         //Nhấn X để tắt 
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Are you sure you want to Exit?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }
        //Nhấn để xuất hiện trang Register
        private void label7_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        // Ẩn hiện mật khẩu ( mắt đóng)
        private void phide_Click(object sender, EventArgs e)
        {
            if (passwordtb.PasswordChar == '*')
            {
                peye.BringToFront();
                passwordtb.PasswordChar = '\0';
            }

        }

        // Ẩn hiện mật khẩu ( mắt mở)
        private void peye_Click(object sender, EventArgs e)
        {
            if (passwordtb.PasswordChar == '\0')
            {
                phide.BringToFront();
                passwordtb.PasswordChar = '*';
            }

        }
    }
}
