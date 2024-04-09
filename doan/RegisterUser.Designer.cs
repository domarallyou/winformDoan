namespace doan
{
    partial class RegisterUser
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
            label37 = new Label();
            button2 = new Button();
            btnRegister = new Button();
            tbnPassword = new TextBox();
            tbnUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbfname = new TextBox();
            lblfname = new Label();
            tblname = new TextBox();
            label3 = new Label();
            rdHotel = new RadioButton();
            rdCustomer = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            dtimeNgaysinh = new DateTimePicker();
            tbstd = new TextBox();
            label6 = new Label();
            picupload = new PictureBox();
            label7 = new Label();
            btnupload = new Button();
            ((System.ComponentModel.ISupportInitialize)picupload).BeginInit();
            SuspendLayout();
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BackColor = Color.Navy;
            label37.Font = new Font("Cooper Black", 19F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label37.ForeColor = SystemColors.ActiveCaption;
            label37.Location = new Point(198, 20);
            label37.Name = "label37";
            label37.Size = new Size(181, 44);
            label37.TabIndex = 21;
            label37.Text = "Register";
            label37.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(558, 381);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 20;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(405, 381);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button1_Click;
            // 
            // tbnPassword
            // 
            tbnPassword.Location = new Point(162, 302);
            tbnPassword.Name = "tbnPassword";
            tbnPassword.Size = new Size(253, 31);
            tbnPassword.TabIndex = 14;
            // 
            // tbnUsername
            // 
            tbnUsername.Location = new Point(162, 250);
            tbnUsername.Name = "tbnUsername";
            tbnUsername.Size = new Size(253, 31);
            tbnUsername.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 255, 128);
            label2.Location = new Point(57, 302);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(57, 250);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 11;
            label1.Text = "User";
            // 
            // tbfname
            // 
            tbfname.Location = new Point(162, 115);
            tbfname.Name = "tbfname";
            tbfname.Size = new Size(253, 31);
            tbfname.TabIndex = 23;
            // 
            // lblfname
            // 
            lblfname.AutoSize = true;
            lblfname.ForeColor = Color.FromArgb(255, 255, 128);
            lblfname.Location = new Point(57, 115);
            lblfname.Name = "lblfname";
            lblfname.Size = new Size(97, 25);
            lblfname.TabIndex = 22;
            lblfname.Text = "First Name";
            // 
            // tblname
            // 
            tblname.Location = new Point(162, 162);
            tblname.Name = "tblname";
            tblname.Size = new Size(253, 31);
            tblname.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(57, 162);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 24;
            label3.Text = "Last Name";
            // 
            // rdHotel
            // 
            rdHotel.AutoSize = true;
            rdHotel.ForeColor = Color.Lime;
            rdHotel.Location = new Point(290, 199);
            rdHotel.Name = "rdHotel";
            rdHotel.Size = new Size(80, 29);
            rdHotel.TabIndex = 27;
            rdHotel.TabStop = true;
            rdHotel.Text = "Hotel";
            rdHotel.UseVisualStyleBackColor = true;
            // 
            // rdCustomer
            // 
            rdCustomer.AutoSize = true;
            rdCustomer.ForeColor = Color.Lime;
            rdCustomer.Location = new Point(168, 199);
            rdCustomer.Name = "rdCustomer";
            rdCustomer.Size = new Size(114, 29);
            rdCustomer.TabIndex = 26;
            rdCustomer.TabStop = true;
            rdCustomer.Text = "Customer";
            rdCustomer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 255, 128);
            label4.Location = new Point(57, 203);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 28;
            label4.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 255, 128);
            label5.Location = new Point(471, 115);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 29;
            label5.Text = "NgaySinh";
            // 
            // dtimeNgaysinh
            // 
            dtimeNgaysinh.CustomFormat = "dd/mm/yyyy";
            dtimeNgaysinh.Location = new Point(602, 115);
            dtimeNgaysinh.Name = "dtimeNgaysinh";
            dtimeNgaysinh.Size = new Size(300, 31);
            dtimeNgaysinh.TabIndex = 30;
            dtimeNgaysinh.Value = new DateTime(2024, 4, 6, 0, 0, 0, 0);
            dtimeNgaysinh.ValueChanged += dtimeNgaysinh_ValueChanged;
            // 
            // tbstd
            // 
            tbstd.Location = new Point(602, 159);
            tbstd.Name = "tbstd";
            tbstd.Size = new Size(253, 31);
            tbstd.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(255, 255, 128);
            label6.Location = new Point(474, 162);
            label6.Name = "label6";
            label6.Size = new Size(127, 25);
            label6.TabIndex = 31;
            label6.Text = "NumberPhone";
            // 
            // picupload
            // 
            picupload.BackColor = Color.FromArgb(128, 255, 255);
            picupload.BackgroundImageLayout = ImageLayout.Stretch;
            picupload.Location = new Point(602, 200);
            picupload.Name = "picupload";
            picupload.Size = new Size(300, 127);
            picupload.TabIndex = 33;
            picupload.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(255, 255, 128);
            label7.Location = new Point(469, 203);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 34;
            label7.Text = "Picture";
            // 
            // btnupload
            // 
            btnupload.Location = new Point(602, 324);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(300, 34);
            btnupload.TabIndex = 35;
            btnupload.Text = "upload";
            btnupload.UseVisualStyleBackColor = true;
            btnupload.Click += btnupload_Click;
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1017, 450);
            Controls.Add(btnupload);
            Controls.Add(label7);
            Controls.Add(picupload);
            Controls.Add(tbstd);
            Controls.Add(label6);
            Controls.Add(dtimeNgaysinh);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(rdHotel);
            Controls.Add(rdCustomer);
            Controls.Add(tblname);
            Controls.Add(label3);
            Controls.Add(tbfname);
            Controls.Add(lblfname);
            Controls.Add(label37);
            Controls.Add(button2);
            Controls.Add(btnRegister);
            Controls.Add(tbnPassword);
            Controls.Add(tbnUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterUser";
            Text = "RegisterUser";
            FormClosed += RegisterUser_FormClosed;
            Load += RegisterUser_Load;
            ((System.ComponentModel.ISupportInitialize)picupload).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label37;
        private Button button2;
        private Button btnRegister;
        private TextBox tbnPassword;
        private TextBox tbnUsername;
        private Label label2;
        private Label label1;
        private TextBox tbfname;
        private Label lblfname;
        private TextBox tblname;
        private Label label3;
        private RadioButton rdHotel;
        private RadioButton rdCustomer;
        private Label label4;
        private Label label5;
        private DateTimePicker dtimeNgaysinh;
        private TextBox tbstd;
        private Label label6;
        private PictureBox picupload;
        private Label label7;
        private Button btnupload;
    }
}