
namespace Hotel
{
    partial class UCReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCReservations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roomidtbl = new Guna.UI2.WinForms.Guna2ComboBox();
            this.clientnametbl = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateout = new System.Windows.Forms.DateTimePicker();
            this.datein = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Deletebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Editbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.residtbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchbtn = new Guna.UI2.WinForms.Guna2Button();
            this.resSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResGridview)).BeginInit();
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
            this.panel1.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(286, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESERVATIONS INFORMATION";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.roomidtbl);
            this.panel2.Controls.Add(this.clientnametbl);
            this.panel2.Controls.Add(this.dateout);
            this.panel2.Controls.Add(this.datein);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Deletebtn);
            this.panel2.Controls.Add(this.Editbtn);
            this.panel2.Controls.Add(this.Addbtn);
            this.panel2.Controls.Add(this.residtbl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 514);
            this.panel2.TabIndex = 4;
            // 
            // roomidtbl
            // 
            this.roomidtbl.BackColor = System.Drawing.Color.Transparent;
            this.roomidtbl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomidtbl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomidtbl.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomidtbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomidtbl.FocusedState.Parent = this.roomidtbl;
            this.roomidtbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomidtbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roomidtbl.HoverState.Parent = this.roomidtbl;
            this.roomidtbl.ItemHeight = 30;
            this.roomidtbl.ItemsAppearance.Parent = this.roomidtbl;
            this.roomidtbl.Location = new System.Drawing.Point(16, 202);
            this.roomidtbl.Margin = new System.Windows.Forms.Padding(2);
            this.roomidtbl.Name = "roomidtbl";
            this.roomidtbl.ShadowDecoration.Parent = this.roomidtbl;
            this.roomidtbl.Size = new System.Drawing.Size(224, 36);
            this.roomidtbl.TabIndex = 24;
            // 
            // clientnametbl
            // 
            this.clientnametbl.BackColor = System.Drawing.Color.Transparent;
            this.clientnametbl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clientnametbl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientnametbl.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientnametbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientnametbl.FocusedState.Parent = this.clientnametbl;
            this.clientnametbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientnametbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.clientnametbl.HoverState.Parent = this.clientnametbl;
            this.clientnametbl.ItemHeight = 30;
            this.clientnametbl.ItemsAppearance.Parent = this.clientnametbl;
            this.clientnametbl.Location = new System.Drawing.Point(16, 128);
            this.clientnametbl.Margin = new System.Windows.Forms.Padding(2);
            this.clientnametbl.Name = "clientnametbl";
            this.clientnametbl.ShadowDecoration.Parent = this.clientnametbl;
            this.clientnametbl.Size = new System.Drawing.Size(232, 36);
            this.clientnametbl.TabIndex = 23;
            this.clientnametbl.SelectedIndexChanged += new System.EventHandler(this.clientnametbl_SelectedIndexChanged);
            // 
            // dateout
            // 
            this.dateout.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.dateout.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateout.Location = new System.Drawing.Point(93, 326);
            this.dateout.Margin = new System.Windows.Forms.Padding(2);
            this.dateout.Name = "dateout";
            this.dateout.Size = new System.Drawing.Size(151, 20);
            this.dateout.TabIndex = 22;
            this.dateout.ValueChanged += new System.EventHandler(this.dateout_ValueChanged);
            // 
            // datein
            // 
            this.datein.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.datein.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datein.Location = new System.Drawing.Point(93, 279);
            this.datein.Margin = new System.Windows.Forms.Padding(2);
            this.datein.Name = "datein";
            this.datein.Size = new System.Drawing.Size(151, 20);
            this.datein.TabIndex = 21;
            this.datein.ValueChanged += new System.EventHandler(this.datein_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label8.Location = new System.Drawing.Point(2, 326);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "DATEOUT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label7.Location = new System.Drawing.Point(98, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "ROOMID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(2, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "DATEIN";
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
            this.Deletebtn.Location = new System.Drawing.Point(165, 393);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.ShadowDecoration.Parent = this.Deletebtn;
            this.Deletebtn.Size = new System.Drawing.Size(93, 41);
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
            this.Editbtn.Location = new System.Drawing.Point(85, 393);
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
            this.Addbtn.Location = new System.Drawing.Point(6, 393);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.ShadowDecoration.Parent = this.Addbtn;
            this.Addbtn.Size = new System.Drawing.Size(74, 41);
            this.Addbtn.TabIndex = 10;
            this.Addbtn.Text = "ADD";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // residtbl
            // 
            this.residtbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.residtbl.DefaultText = "";
            this.residtbl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.residtbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.residtbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.residtbl.DisabledState.Parent = this.residtbl;
            this.residtbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.residtbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.residtbl.FocusedState.Parent = this.residtbl;
            this.residtbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residtbl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.residtbl.HoverState.Parent = this.residtbl;
            this.residtbl.Location = new System.Drawing.Point(0, 43);
            this.residtbl.Margin = new System.Windows.Forms.Padding(2);
            this.residtbl.Name = "residtbl";
            this.residtbl.PasswordChar = '\0';
            this.residtbl.PlaceholderText = "";
            this.residtbl.SelectedText = "";
            this.residtbl.ShadowDecoration.Parent = this.residtbl;
            this.residtbl.Size = new System.Drawing.Size(260, 43);
            this.residtbl.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(81, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "CLIENTNAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(70, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "RESERVATIONID";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(752, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ResGridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ResGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ResGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResGridview.BackgroundColor = System.Drawing.Color.White;
            this.ResGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ResGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ResGridview.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.ResGridview.EnableHeadersVisualStyles = false;
            this.ResGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ResGridview.Location = new System.Drawing.Point(279, 159);
            this.ResGridview.Margin = new System.Windows.Forms.Padding(2);
            this.ResGridview.Name = "ResGridview";
            this.ResGridview.RowHeadersVisible = false;
            this.ResGridview.RowHeadersWidth = 51;
            this.ResGridview.RowTemplate.Height = 24;
            this.ResGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResGridview.Size = new System.Drawing.Size(566, 380);
            this.ResGridview.TabIndex = 21;
            this.ResGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ResGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ResGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ResGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ResGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ResGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ResGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ResGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ResGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ResGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ResGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ResGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ResGridview.ThemeStyle.HeaderStyle.Height = 20;
            this.ResGridview.ThemeStyle.ReadOnly = false;
            this.ResGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ResGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ResGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ResGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ResGridview.ThemeStyle.RowsStyle.Height = 24;
            this.ResGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ResGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ResGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResGridview_CellContentClick);
            // 
            // searchbtn
            // 
            this.searchbtn.BorderRadius = 10;
            this.searchbtn.CheckedState.Parent = this.searchbtn;
            this.searchbtn.CustomImages.Parent = this.searchbtn;
            this.searchbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchbtn.DisabledState.Parent = this.searchbtn;
            this.searchbtn.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.HoverState.Parent = this.searchbtn;
            this.searchbtn.Location = new System.Drawing.Point(626, 111);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.ShadowDecoration.Parent = this.searchbtn;
            this.searchbtn.Size = new System.Drawing.Size(109, 42);
            this.searchbtn.TabIndex = 20;
            this.searchbtn.Text = "SEARCH";
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // resSearch
            // 
            this.resSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resSearch.DefaultText = "";
            this.resSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.resSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.resSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resSearch.DisabledState.Parent = this.resSearch;
            this.resSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.resSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resSearch.FocusedState.Parent = this.resSearch;
            this.resSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.resSearch.HoverState.Parent = this.resSearch;
            this.resSearch.Location = new System.Drawing.Point(279, 111);
            this.resSearch.Margin = new System.Windows.Forms.Padding(2);
            this.resSearch.Name = "resSearch";
            this.resSearch.PasswordChar = '\0';
            this.resSearch.PlaceholderText = "";
            this.resSearch.SelectedText = "";
            this.resSearch.ShadowDecoration.Parent = this.resSearch;
            this.resSearch.Size = new System.Drawing.Size(337, 43);
            this.resSearch.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(262, 87);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 514);
            this.panel3.TabIndex = 23;
            // 
            // UCReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResGridview);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.resSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCReservations";
            this.Size = new System.Drawing.Size(861, 601);
            this.Load += new System.EventHandler(this.UCReservations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button Deletebtn;
        private Guna.UI2.WinForms.Guna2Button Editbtn;
        private Guna.UI2.WinForms.Guna2Button Addbtn;
        private Guna.UI2.WinForms.Guna2TextBox residtbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView ResGridview;
        private Guna.UI2.WinForms.Guna2Button searchbtn;
        private Guna.UI2.WinForms.Guna2TextBox resSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datein;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateout;
        private Guna.UI2.WinForms.Guna2ComboBox roomidtbl;
        private Guna.UI2.WinForms.Guna2ComboBox clientnametbl;
    }
}
