
namespace Hotel
{
    partial class UCClient
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Deletebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Editbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.clientnumtbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.clientidtbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.countrytbl = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientnametbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClientSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.ClientGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.datelbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 87);
            this.panel1.TabIndex = 0;
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datelbl.Location = new System.Drawing.Point(657, 58);
            this.datelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(61, 26);
            this.datelbl.TabIndex = 1;
            this.datelbl.Text = "DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(313, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENT INFORMATION";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Deletebtn);
            this.panel2.Controls.Add(this.Editbtn);
            this.panel2.Controls.Add(this.Addbtn);
            this.panel2.Controls.Add(this.clientnumtbl);
            this.panel2.Controls.Add(this.clientidtbl);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.countrytbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.clientnametbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 514);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BorderRadius = 20;
            this.Deletebtn.CheckedState.Parent = this.Deletebtn;
            this.Deletebtn.CustomImages.Parent = this.Deletebtn;
            this.Deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Deletebtn.DisabledState.Parent = this.Deletebtn;
            this.Deletebtn.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.HoverState.Parent = this.Deletebtn;
            this.Deletebtn.Location = new System.Drawing.Point(166, 385);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.ShadowDecoration.Parent = this.Deletebtn;
            this.Deletebtn.Size = new System.Drawing.Size(92, 41);
            this.Deletebtn.TabIndex = 12;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.BorderRadius = 20;
            this.Editbtn.CheckedState.Parent = this.Editbtn;
            this.Editbtn.CustomImages.Parent = this.Editbtn;
            this.Editbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Editbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Editbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Editbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Editbtn.DisabledState.Parent = this.Editbtn;
            this.Editbtn.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbtn.ForeColor = System.Drawing.Color.White;
            this.Editbtn.HoverState.Parent = this.Editbtn;
            this.Editbtn.Location = new System.Drawing.Point(87, 385);
            this.Editbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.ShadowDecoration.Parent = this.Editbtn;
            this.Editbtn.Size = new System.Drawing.Size(75, 41);
            this.Editbtn.TabIndex = 11;
            this.Editbtn.Text = "EDIT";
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BorderRadius = 20;
            this.Addbtn.CheckedState.Parent = this.Addbtn;
            this.Addbtn.CustomImages.Parent = this.Addbtn;
            this.Addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Addbtn.DisabledState.Parent = this.Addbtn;
            this.Addbtn.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.HoverState.Parent = this.Addbtn;
            this.Addbtn.Location = new System.Drawing.Point(2, 385);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.ShadowDecoration.Parent = this.Addbtn;
            this.Addbtn.Size = new System.Drawing.Size(74, 41);
            this.Addbtn.TabIndex = 10;
            this.Addbtn.Text = "ADD";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // clientnumtbl
            // 
            this.clientnumtbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientnumtbl.DefaultText = "";
            this.clientnumtbl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientnumtbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientnumtbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientnumtbl.DisabledState.Parent = this.clientnumtbl;
            this.clientnumtbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientnumtbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientnumtbl.FocusedState.Parent = this.clientnumtbl;
            this.clientnumtbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientnumtbl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientnumtbl.HoverState.Parent = this.clientnumtbl;
            this.clientnumtbl.Location = new System.Drawing.Point(1, 236);
            this.clientnumtbl.Margin = new System.Windows.Forms.Padding(2);
            this.clientnumtbl.Name = "clientnumtbl";
            this.clientnumtbl.PasswordChar = '\0';
            this.clientnumtbl.PlaceholderText = "";
            this.clientnumtbl.SelectedText = "";
            this.clientnumtbl.ShadowDecoration.Parent = this.clientnumtbl;
            this.clientnumtbl.Size = new System.Drawing.Size(260, 43);
            this.clientnumtbl.TabIndex = 9;
            // 
            // clientidtbl
            // 
            this.clientidtbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientidtbl.DefaultText = "";
            this.clientidtbl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientidtbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientidtbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientidtbl.DisabledState.Parent = this.clientidtbl;
            this.clientidtbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientidtbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientidtbl.FocusedState.Parent = this.clientidtbl;
            this.clientidtbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientidtbl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientidtbl.HoverState.Parent = this.clientidtbl;
            this.clientidtbl.Location = new System.Drawing.Point(0, 60);
            this.clientidtbl.Margin = new System.Windows.Forms.Padding(2);
            this.clientidtbl.Name = "clientidtbl";
            this.clientidtbl.PasswordChar = '\0';
            this.clientidtbl.PlaceholderText = "";
            this.clientidtbl.SelectedText = "";
            this.clientidtbl.ShadowDecoration.Parent = this.clientidtbl;
            this.clientidtbl.Size = new System.Drawing.Size(260, 43);
            this.clientidtbl.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(94, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "COUNTRY";
            // 
            // countrytbl
            // 
            this.countrytbl.BackColor = System.Drawing.Color.Transparent;
            this.countrytbl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.countrytbl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countrytbl.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.countrytbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.countrytbl.FocusedState.Parent = this.countrytbl;
            this.countrytbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.countrytbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.countrytbl.HoverState.Parent = this.countrytbl;
            this.countrytbl.ItemHeight = 30;
            this.countrytbl.Items.AddRange(new object[] {
            "An Giang",
            "Vung Tau",
            "Bac Giang",
            "Bac Kan",
            "Bac Lieu",
            "Bac Ninh",
            "Ben Tre",
            "Binh Đinh",
            "Binh Duong",
            "Binh Phuoc",
            "Binh Thuan",
            "Ca Mau",
            "Can Tho",
            "Cao Bang ",
            "Da Nang",
            "Dak Lak",
            "Dak Nong",
            "Dien Bien",
            "Dong Nai",
            "Dong Thap",
            "Gia Lai",
            "Ha Giang",
            "Ha Nam",
            "Ha Noi ",
            "Ha Tinh",
            "Hai Duong",
            "Hai Phong",
            "Hau Giang",
            "Hoa Binh",
            "Hung Yen",
            "Khanh Hoa",
            "Kien Giang",
            "Kon Tum",
            "Lai Chau",
            "Lam Dong",
            "Lang Son",
            "Lao Cai",
            "Long An",
            "Nam Dinh",
            "Nghe An",
            "Ninh Binh",
            "Ninh Thuan",
            "Phu Tho",
            "Phu Yen",
            "Quang Binh",
            "Quang Nam",
            "Quang Ngai",
            "Quang Ninh",
            "Quang Tri",
            "Soc Trang",
            "Son La",
            "Tay Ninh",
            "Thai Binh",
            "Thai Nguyen",
            "Thanh Hoa",
            "Thua Thien Hue",
            "Tien Giang",
            "Tp. Ho Chi Minh",
            "Tra Vinh",
            "Tuyen Quang",
            "Vinh Long",
            "Vinh Phuc",
            "Yen Bai"});
            this.countrytbl.ItemsAppearance.Parent = this.countrytbl;
            this.countrytbl.Location = new System.Drawing.Point(38, 320);
            this.countrytbl.Margin = new System.Windows.Forms.Padding(2);
            this.countrytbl.Name = "countrytbl";
            this.countrytbl.ShadowDecoration.Parent = this.countrytbl;
            this.countrytbl.Size = new System.Drawing.Size(182, 36);
            this.countrytbl.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(81, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "CLIENT NUM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(81, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "CLIENTNAME";
            // 
            // clientnametbl
            // 
            this.clientnametbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientnametbl.DefaultText = "";
            this.clientnametbl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientnametbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientnametbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientnametbl.DisabledState.Parent = this.clientnametbl;
            this.clientnametbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientnametbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientnametbl.FocusedState.Parent = this.clientnametbl;
            this.clientnametbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientnametbl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientnametbl.HoverState.Parent = this.clientnametbl;
            this.clientnametbl.Location = new System.Drawing.Point(2, 145);
            this.clientnametbl.Margin = new System.Windows.Forms.Padding(2);
            this.clientnametbl.Name = "clientnametbl";
            this.clientnametbl.PasswordChar = '\0';
            this.clientnametbl.PlaceholderText = "";
            this.clientnametbl.SelectedText = "";
            this.clientnametbl.ShadowDecoration.Parent = this.clientnametbl;
            this.clientnametbl.Size = new System.Drawing.Size(260, 43);
            this.clientnametbl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(92, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CLIENTID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(262, 87);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 514);
            this.panel3.TabIndex = 3;
            // 
            // ClientSearch
            // 
            this.ClientSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClientSearch.DefaultText = "";
            this.ClientSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientSearch.DisabledState.Parent = this.ClientSearch;
            this.ClientSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientSearch.FocusedState.Parent = this.ClientSearch;
            this.ClientSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientSearch.HoverState.Parent = this.ClientSearch;
            this.ClientSearch.Location = new System.Drawing.Point(281, 105);
            this.ClientSearch.Margin = new System.Windows.Forms.Padding(2);
            this.ClientSearch.Name = "ClientSearch";
            this.ClientSearch.PasswordChar = '\0';
            this.ClientSearch.PlaceholderText = "";
            this.ClientSearch.SelectedText = "";
            this.ClientSearch.ShadowDecoration.Parent = this.ClientSearch;
            this.ClientSearch.Size = new System.Drawing.Size(337, 43);
            this.ClientSearch.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.DisabledState.Parent = this.guna2Button4;
            this.guna2Button4.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(642, 105);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(90, 42);
            this.guna2Button4.TabIndex = 12;
            this.guna2Button4.Text = "SEARCH";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // ClientGridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ClientGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientGridview.BackgroundColor = System.Drawing.Color.White;
            this.ClientGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClientGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientGridview.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientGridview.EnableHeadersVisualStyles = false;
            this.ClientGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientGridview.Location = new System.Drawing.Point(281, 153);
            this.ClientGridview.Margin = new System.Windows.Forms.Padding(2);
            this.ClientGridview.Name = "ClientGridview";
            this.ClientGridview.RowHeadersVisible = false;
            this.ClientGridview.RowHeadersWidth = 51;
            this.ClientGridview.RowTemplate.Height = 24;
            this.ClientGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientGridview.Size = new System.Drawing.Size(566, 353);
            this.ClientGridview.TabIndex = 13;
            this.ClientGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ClientGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ClientGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ClientGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ClientGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ClientGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ClientGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ClientGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ClientGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClientGridview.ThemeStyle.HeaderStyle.Height = 20;
            this.ClientGridview.ThemeStyle.ReadOnly = false;
            this.ClientGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ClientGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClientGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ClientGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ClientGridview.ThemeStyle.RowsStyle.Height = 24;
            this.ClientGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ClientGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ClientGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridview_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(750, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UCClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClientGridview);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.ClientSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCClient";
            this.Size = new System.Drawing.Size(861, 601);
            this.Load += new System.EventHandler(this.UCClient_Load);
            this.LocationChanged += new System.EventHandler(this.UCClient_LocationChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox clientidtbl;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox countrytbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox clientnametbl;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox clientnumtbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label datelbl;
        private Guna.UI2.WinForms.Guna2Button Deletebtn;
        private Guna.UI2.WinForms.Guna2Button Editbtn;
        private Guna.UI2.WinForms.Guna2Button Addbtn;
        private Guna.UI2.WinForms.Guna2TextBox ClientSearch;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2DataGridView ClientGridview;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
