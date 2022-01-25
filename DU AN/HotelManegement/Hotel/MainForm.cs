using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class MainForm : Form
    {
        static MainForm _obj;
        
        public static MainForm Instance
        {
            get
            {
                if(_obj==null)
                {
                    _obj = new MainForm();
                }
                return _obj;
            }
        }
        public Panel PanelContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        public MainForm()
        {
            InitializeComponent();
        }
        //Nhấn nút thoát để trở về Login
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
        //Nhấn vào nút client để hiện UcClient
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(!MainForm.Instance.PanelContainer.Controls.ContainsKey("UCClient"))
            {
                UCClient un = new UCClient();
                un.Dock = DockStyle.Fill;
                MainForm.Instance.PanelContainer.Controls.Add(un);               

            }
            MainForm.Instance.PanelContainer.Controls["UCClient"].BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _obj = this;
           
        }
        //Nhấn vào nút Staffs để hiện UcStaff
        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (!MainForm.Instance.PanelContainer.Controls.ContainsKey("UCStaffs"))
            {
                UCStaffs un = new UCStaffs();
                un.Dock = DockStyle.Fill;
                MainForm.Instance.PanelContainer.Controls.Add(un);

            }
            MainForm.Instance.PanelContainer.Controls["UCStaffs"].BringToFront();
        }
        //Nhấn vào nút Room để hiện UcRoom
        private void guna2Button3_Click_1(object sender, EventArgs e)
        {

            if (!MainForm.Instance.PanelContainer.Controls.ContainsKey("UCRooms"))
            {
                UCRooms un = new UCRooms();
                un.Dock = DockStyle.Fill;
                MainForm.Instance.PanelContainer.Controls.Add(un);

            }
            MainForm.Instance.PanelContainer.Controls["UCRooms"].BringToFront();
        }
        //Nhấn vào nút Reservation để hiện UcReservation
        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            if (!MainForm.Instance.PanelContainer.Controls.ContainsKey("UCReservations"))
            {
                UCReservations un = new UCReservations();
                un.Dock = DockStyle.Fill;
                MainForm.Instance.PanelContainer.Controls.Add(un);

            }
            MainForm.Instance.PanelContainer.Controls["UCReservations"].BringToFront();
        }
    }
}
