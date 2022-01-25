
namespace Hotel
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.usernametb = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.peye = new System.Windows.Forms.PictureBox();
            this.phide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phide)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(213, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "HOTEL";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.HotPink;
            this.label4.Location = new System.Drawing.Point(150, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "NEW";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MintCream;
            this.label5.Location = new System.Drawing.Point(42, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(45, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 12;
            this.btnLogin.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogin.CheckedState.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(255, 405);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(127, 37);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // usernametb
            // 
            this.usernametb.BorderRadius = 12;
            this.usernametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametb.DefaultText = "";
            this.usernametb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernametb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernametb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernametb.DisabledState.Parent = this.usernametb;
            this.usernametb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernametb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernametb.FocusedState.Parent = this.usernametb;
            this.usernametb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernametb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernametb.HoverState.Parent = this.usernametb;
            this.usernametb.Location = new System.Drawing.Point(183, 222);
            this.usernametb.Margin = new System.Windows.Forms.Padding(2);
            this.usernametb.Name = "usernametb";
            this.usernametb.PasswordChar = '\0';
            this.usernametb.PlaceholderText = "";
            this.usernametb.SelectedText = "";
            this.usernametb.ShadowDecoration.Parent = this.usernametb;
            this.usernametb.Size = new System.Drawing.Size(199, 35);
            this.usernametb.TabIndex = 10;
            // 
            // passwordtb
            // 
            this.passwordtb.BorderRadius = 12;
            this.passwordtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtb.DefaultText = "";
            this.passwordtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtb.DisabledState.Parent = this.passwordtb;
            this.passwordtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtb.FocusedState.Parent = this.passwordtb;
            this.passwordtb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtb.HoverState.Parent = this.passwordtb;
            this.passwordtb.Location = new System.Drawing.Point(183, 273);
            this.passwordtb.Margin = new System.Windows.Forms.Padding(2);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '*';
            this.passwordtb.PlaceholderText = "";
            this.passwordtb.SelectedText = "";
            this.passwordtb.ShadowDecoration.Parent = this.passwordtb;
            this.passwordtb.Size = new System.Drawing.Size(199, 35);
            this.passwordtb.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(180, 357);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Create a new Account";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(394, 11);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.ShadowDecoration.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(29, 17);
            this.guna2ImageButton1.TabIndex = 12;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Properties.Resources.login__2_;
            this.pictureBox1.Location = new System.Drawing.Point(202, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // peye
            // 
            this.peye.Image = global::Hotel.Properties.Resources.open_eye1;
            this.peye.Location = new System.Drawing.Point(386, 280);
            this.peye.Margin = new System.Windows.Forms.Padding(2);
            this.peye.Name = "peye";
            this.peye.Size = new System.Drawing.Size(27, 18);
            this.peye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.peye.TabIndex = 14;
            this.peye.TabStop = false;
            this.peye.Click += new System.EventHandler(this.peye_Click);
            // 
            // phide
            // 
            this.phide.Image = global::Hotel.Properties.Resources.close_eye;
            this.phide.Location = new System.Drawing.Point(386, 280);
            this.phide.Margin = new System.Windows.Forms.Padding(2);
            this.phide.Name = "phide";
            this.phide.Size = new System.Drawing.Size(27, 18);
            this.phide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phide.TabIndex = 15;
            this.phide.TabStop = false;
            this.phide.Click += new System.EventHandler(this.phide_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.CancelButton = this.btnLogin;
            this.ClientSize = new System.Drawing.Size(434, 476);
            this.Controls.Add(this.phide);
            this.Controls.Add(this.peye);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox usernametb;
        private Guna.UI2.WinForms.Guna2TextBox passwordtb;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox peye;
        private System.Windows.Forms.PictureBox phide;
    }
}

