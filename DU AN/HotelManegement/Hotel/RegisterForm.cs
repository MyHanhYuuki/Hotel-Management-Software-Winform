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
    public partial class RegisterForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-L3D2584\SQLEXPRESS;Initial Catalog=HOTELDTB.MDF;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //Nhấn nút Resgister
        private void Registerbtn_Click(object sender, EventArgs e)
        {
            if(staffidtbl.Text==""&&staffpasswordtbl.Text==""&&ConfPasstbl.Text=="")
            {
                MessageBox.Show("Username and Password are empty!", "Registration failed!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if(staffpasswordtbl.Text == ConfPasstbl.Text)
            {
                Con.Open();
                string res="insert into Staff_tbl values(" + staffidtbl.Text + ",'" + staffnametbl.Text + "','" + staffnumtbl.Text + "','" 
                                                           + gendertbl.SelectedItem.ToString() + "','" + staffpasswordtbl.Text + "')";
                cmd = new SqlCommand(res, Con);
                cmd.ExecuteNonQuery();
                Con.Close();

                staffidtbl.Text = "";
                staffnametbl.Text = "";
                staffnumtbl.Text = "";
                staffpasswordtbl.Text = "";
                ConfPasstbl.Text = "";

                MessageBox.Show("Your Account has been Created Successfully!", "Resgistation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords does not Match. Please check again!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                staffpasswordtbl.Text = "";
                ConfPasstbl.Text = "";
                staffpasswordtbl.Focus();

            }
        }

        private void xxxxx_Click(object sender, EventArgs e)
        {

        }

        private void staffnumtbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffpasswordtbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void staffnametbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void staffidtbl_TextChanged(object sender, EventArgs e)
        {

        }
        //Check box - password
        private void checkBxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBxShowPas.Checked)
            {
                staffpasswordtbl.PasswordChar = '\0';
                ConfPasstbl.PasswordChar = '\0';
            }
            else
            {
                staffpasswordtbl.PasswordChar = '•';
                ConfPasstbl.PasswordChar = '•';

            }
        }

        //Xóa username và password đã nhập
        private void CLearbtn_Click(object sender, EventArgs e)
        {
            staffidtbl.Text = "";
            staffnametbl.Text = "";
            staffnumtbl.Text = "";
            staffpasswordtbl.Text = "";
            ConfPasstbl.Text = "";
            staffidtbl.Focus();
        }
        //Nút quay trở về Login
        private void label10_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        //Nút X
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Are you sure you want to Exit?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }
    }
}
