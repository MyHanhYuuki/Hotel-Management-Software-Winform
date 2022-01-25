
namespace Hotel
{
    partial class UCStaffs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCStaffs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.staffpasswordtbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.xxxxx = new System.Windows.Forms.Label();
            this.gendertbl = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Deletebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Editbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.staffnumtbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.staffidtbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.staffnametbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StaffGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.staffSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridview)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAFFS INFORMATION";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.staffpasswordtbl);
            this.panel2.Controls.Add(this.xxxxx);
            this.panel2.Controls.Add(this.gendertbl);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Deletebtn);
            this.panel2.Controls.Add(this.Editbtn);
            this.panel2.Controls.Add(this.Addbtn);
            this.panel2.Controls.Add(this.staffnumtbl);
            this.panel2.Controls.Add(this.staffidtbl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.staffnametbl);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 514);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // staffpasswordtbl
            // 
            this.staffpasswordtbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffpasswordtbl.DefaultText = "";
            this.staffpasswordtbl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffpasswordtbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffpasswordtbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffpasswordtbl.DisabledState.Parent = this.staffpasswordtbl;
            this.staffpasswordtbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffpasswordtbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffpasswordtbl.FocusedState.Parent = this.staffpasswordtbl;
            this.staffpasswordtbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffpasswordtbl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffpasswordtbl.HoverState.Parent = this.staffpasswordtbl;
            this.staffpasswordtbl.Location = new System.Drawing.Point(2, 288);
            this.staffpasswordtbl.Margin = new System.Windows.Forms.Padding(2);
            this.staffpasswordtbl.Name = "staffpasswordtbl";
            this.staffpasswordtbl.PasswordChar = '\0';
            this.staffpasswordtbl.PlaceholderText = "";
            this.staffpasswordtbl.SelectedText = "";
            this.staffpasswordtbl.ShadowDecoration.Parent = this.staffpasswordtbl;
            this.staffpasswordtbl.Size = new System.Drawing.Size(260, 43);
            this.staffpasswordtbl.TabIndex = 14;
            // 
            // xxxxx
            // 
            this.xxxxx.AutoSize = true;
            this.xxxxx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xxxxx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.xxxxx.Location = new System.Drawing.Point(88, 266);
            this.xxxxx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xxxxx.Name = "xxxxx";
            this.xxxxx.Size = new System.Drawing.Size(84, 20);
            this.xxxxx.TabIndex = 13;
            this.xxxxx.Text = "PASSWORD";
            // 
            // gendertbl
            // 
            this.gendertbl.BackColor = System.Drawing.Color.Transparent;
            this.gendertbl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gendertbl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gendertbl.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gendertbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gendertbl.FocusedState.Parent = this.gendertbl;
            this.gendertbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendertbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gendertbl.HoverState.Parent = this.gendertbl;
            this.gendertbl.ItemHeight = 30;
            this.gendertbl.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.gendertbl.ItemsAppearance.Parent = this.gendertbl;
            this.gendertbl.Location = new System.Drawing.Point(37, 362);
            this.gendertbl.Margin = new System.Windows.Forms.Padding(2);
            this.gendertbl.Name = "gendertbl";
            this.gendertbl.ShadowDecoration.Parent = this.gendertbl;
            this.gendertbl.Size = new System.Drawing.Size(182, 36);
            this.gendertbl.TabIndex = 6;
            this.gendertbl.SelectedIndexChanged += new System.EventHandler(this.gendertbl_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(92, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "GENDER";
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
            this.Deletebtn.Location = new System.Drawing.Point(173, 415);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.ShadowDecoration.Parent = this.Deletebtn;
            this.Deletebtn.Size = new System.Drawing.Size(87, 41);
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
            this.Editbtn.Location = new System.Drawing.Point(85, 415);
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
            this.Addbtn.Location = new System.Drawing.Point(0, 415);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.ShadowDecoration.Parent = this.Addbtn;
            this.Addbtn.Size = new System.Drawing.Size(74, 41);
            this.Addbtn.TabIndex = 10;
            this.Addbtn.Text = "ADD";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // staffnumtbl
            // 
            this.staffnumtbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffnumtbl.DefaultText = "";
            this.staffnumtbl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffnumtbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffnumtbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffnumtbl.DisabledState.Parent = this.staffnumtbl;
            this.staffnumtbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffnumtbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffnumtbl.FocusedState.Parent = this.staffnumtbl;
            this.staffnumtbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffnumtbl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffnumtbl.HoverState.Parent = this.staffnumtbl;
            this.staffnumtbl.Location = new System.Drawing.Point(0, 207);
            this.staffnumtbl.Margin = new System.Windows.Forms.Padding(2);
            this.staffnumtbl.Name = "staffnumtbl";
            this.staffnumtbl.PasswordChar = '\0';
            this.staffnumtbl.PlaceholderText = "";
            this.staffnumtbl.SelectedText = "";
            this.staffnumtbl.ShadowDecoration.Parent = this.staffnumtbl;
            this.staffnumtbl.Size = new System.Drawing.Size(260, 43);
            this.staffnumtbl.TabIndex = 9;
            this.staffnumtbl.TextChanged += new System.EventHandler(this.staffnumtbl_TextChanged);
            // 
            // staffidtbl
            // 
            this.staffidtbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffidtbl.DefaultText = "";
            this.staffidtbl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffidtbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffidtbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffidtbl.DisabledState.Parent = this.staffidtbl;
            this.staffidtbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffidtbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffidtbl.FocusedState.Parent = this.staffidtbl;
            this.staffidtbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffidtbl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffidtbl.HoverState.Parent = this.staffidtbl;
            this.staffidtbl.Location = new System.Drawing.Point(0, 35);
            this.staffidtbl.Margin = new System.Windows.Forms.Padding(2);
            this.staffidtbl.Name = "staffidtbl";
            this.staffidtbl.PasswordChar = '\0';
            this.staffidtbl.PlaceholderText = "";
            this.staffidtbl.SelectedText = "";
            this.staffidtbl.ShadowDecoration.Parent = this.staffidtbl;
            this.staffidtbl.Size = new System.Drawing.Size(260, 43);
            this.staffidtbl.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(88, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "STAFF NUM";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(83, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "STAFFNAME";
            // 
            // staffnametbl
            // 
            this.staffnametbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffnametbl.DefaultText = "";
            this.staffnametbl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffnametbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffnametbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffnametbl.DisabledState.Parent = this.staffnametbl;
            this.staffnametbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffnametbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffnametbl.FocusedState.Parent = this.staffnametbl;
            this.staffnametbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffnametbl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffnametbl.HoverState.Parent = this.staffnametbl;
            this.staffnametbl.Location = new System.Drawing.Point(2, 120);
            this.staffnametbl.Margin = new System.Windows.Forms.Padding(2);
            this.staffnametbl.Name = "staffnametbl";
            this.staffnametbl.PasswordChar = '\0';
            this.staffnametbl.PlaceholderText = "";
            this.staffnametbl.SelectedText = "";
            this.staffnametbl.ShadowDecoration.Parent = this.staffnametbl;
            this.staffnametbl.Size = new System.Drawing.Size(260, 43);
            this.staffnametbl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(92, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "STAFFID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(262, 87);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 514);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(736, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StaffGridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.StaffGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StaffGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffGridview.BackgroundColor = System.Drawing.Color.White;
            this.StaffGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StaffGridview.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.StaffGridview.EnableHeadersVisualStyles = false;
            this.StaffGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffGridview.Location = new System.Drawing.Point(274, 154);
            this.StaffGridview.Margin = new System.Windows.Forms.Padding(2);
            this.StaffGridview.Name = "StaffGridview";
            this.StaffGridview.RowHeadersVisible = false;
            this.StaffGridview.RowHeadersWidth = 51;
            this.StaffGridview.RowTemplate.Height = 24;
            this.StaffGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffGridview.Size = new System.Drawing.Size(566, 380);
            this.StaffGridview.TabIndex = 17;
            this.StaffGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StaffGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StaffGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StaffGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StaffGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StaffGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.StaffGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StaffGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StaffGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StaffGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StaffGridview.ThemeStyle.HeaderStyle.Height = 20;
            this.StaffGridview.ThemeStyle.ReadOnly = false;
            this.StaffGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StaffGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StaffGridview.ThemeStyle.RowsStyle.Height = 24;
            this.StaffGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StaffGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridview_CellContentClick);
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
            this.guna2Button4.Location = new System.Drawing.Point(621, 106);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(97, 42);
            this.guna2Button4.TabIndex = 16;
            this.guna2Button4.Text = "SEARCH";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // staffSearch
            // 
            this.staffSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staffSearch.DefaultText = "";
            this.staffSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.staffSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.staffSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffSearch.DisabledState.Parent = this.staffSearch;
            this.staffSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.staffSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffSearch.FocusedState.Parent = this.staffSearch;
            this.staffSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.staffSearch.HoverState.Parent = this.staffSearch;
            this.staffSearch.Location = new System.Drawing.Point(274, 106);
            this.staffSearch.Margin = new System.Windows.Forms.Padding(2);
            this.staffSearch.Name = "staffSearch";
            this.staffSearch.PasswordChar = '\0';
            this.staffSearch.PlaceholderText = "";
            this.staffSearch.SelectedText = "";
            this.staffSearch.ShadowDecoration.Parent = this.staffSearch;
            this.staffSearch.Size = new System.Drawing.Size(336, 43);
            this.staffSearch.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UCStaffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StaffGridview);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.staffSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCStaffs";
            this.Size = new System.Drawing.Size(861, 601);
            this.Load += new System.EventHandler(this.UCStaffs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button Deletebtn;
        private Guna.UI2.WinForms.Guna2Button Editbtn;
        private Guna.UI2.WinForms.Guna2Button Addbtn;
        private Guna.UI2.WinForms.Guna2TextBox staffnumtbl;
        private Guna.UI2.WinForms.Guna2TextBox staffidtbl;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox gendertbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox staffnametbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView StaffGridview;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2TextBox staffSearch;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox staffpasswordtbl;
        private System.Windows.Forms.Label xxxxx;
    }
}
