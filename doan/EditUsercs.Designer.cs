namespace doan
{
    partial class EditUsercs
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
            btnupload = new Button();
            label7 = new Label();
            picupload = new PictureBox();
            tbstd = new TextBox();
            label6 = new Label();
            dtimeNgaysinh = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            rdHotel = new RadioButton();
            rdCustomer = new RadioButton();
            tblname = new TextBox();
            label3 = new Label();
            tbfname = new TextBox();
            lblfname = new Label();
            button2 = new Button();
            btnEdit = new Button();
            tbnPassword = new TextBox();
            tbnUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label37 = new Label();
            ((System.ComponentModel.ISupportInitialize)picupload).BeginInit();
            SuspendLayout();
            // 
            // btnupload
            // 
            btnupload.Location = new Point(620, 355);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(300, 34);
            btnupload.TabIndex = 55;
            btnupload.Text = "upload";
            btnupload.UseVisualStyleBackColor = true;
            btnupload.Click += btnupload_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(255, 255, 128);
            label7.Location = new Point(492, 234);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 54;
            label7.Text = "Picture";
            // 
            // picupload
            // 
            picupload.BackColor = Color.FromArgb(128, 255, 255);
            picupload.BackgroundImageLayout = ImageLayout.Stretch;
            picupload.Location = new Point(620, 231);
            picupload.Name = "picupload";
            picupload.Size = new Size(300, 127);
            picupload.TabIndex = 53;
            picupload.TabStop = false;
            // 
            // tbstd
            // 
            tbstd.Location = new Point(620, 190);
            tbstd.Name = "tbstd";
            tbstd.Size = new Size(253, 31);
            tbstd.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(255, 255, 128);
            label6.Location = new Point(492, 193);
            label6.Name = "label6";
            label6.Size = new Size(127, 25);
            label6.TabIndex = 51;
            label6.Text = "NumberPhone";
            // 
            // dtimeNgaysinh
            // 
            dtimeNgaysinh.CustomFormat = "dd/MM/yyyy";
            dtimeNgaysinh.Format = DateTimePickerFormat.Short;
            dtimeNgaysinh.Location = new Point(620, 146);
            dtimeNgaysinh.Name = "dtimeNgaysinh";
            dtimeNgaysinh.Size = new Size(156, 31);
            dtimeNgaysinh.TabIndex = 6;
            dtimeNgaysinh.ValueChanged += dtimeNgaysinh_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 255, 128);
            label5.Location = new Point(489, 146);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 49;
            label5.Text = "NgaySinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 255, 128);
            label4.Location = new Point(75, 234);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 48;
            label4.Text = "Role";
            // 
            // rdHotel
            // 
            rdHotel.AutoSize = true;
            rdHotel.Enabled = false;
            rdHotel.ForeColor = Color.Lime;
            rdHotel.Location = new Point(308, 230);
            rdHotel.Name = "rdHotel";
            rdHotel.Size = new Size(80, 29);
            rdHotel.TabIndex = 47;
            rdHotel.TabStop = true;
            rdHotel.Text = "Hotel";
            rdHotel.UseVisualStyleBackColor = true;
            // 
            // rdCustomer
            // 
            rdCustomer.AutoSize = true;
            rdCustomer.Enabled = false;
            rdCustomer.ForeColor = Color.Lime;
            rdCustomer.Location = new Point(186, 230);
            rdCustomer.Name = "rdCustomer";
            rdCustomer.Size = new Size(114, 29);
            rdCustomer.TabIndex = 46;
            rdCustomer.TabStop = true;
            rdCustomer.Text = "Customer";
            rdCustomer.UseVisualStyleBackColor = true;
            // 
            // tblname
            // 
            tblname.Location = new Point(180, 193);
            tblname.Name = "tblname";
            tblname.Size = new Size(253, 31);
            tblname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(75, 193);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 44;
            label3.Text = "Last Name";
            // 
            // tbfname
            // 
            tbfname.Location = new Point(180, 146);
            tbfname.Name = "tbfname";
            tbfname.Size = new Size(253, 31);
            tbfname.TabIndex = 1;
            // 
            // lblfname
            // 
            lblfname.AutoSize = true;
            lblfname.ForeColor = Color.FromArgb(255, 255, 128);
            lblfname.Location = new Point(75, 146);
            lblfname.Name = "lblfname";
            lblfname.Size = new Size(97, 25);
            lblfname.TabIndex = 42;
            lblfname.Text = "First Name";
            // 
            // button2
            // 
            button2.Location = new Point(576, 412);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 41;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(423, 412);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 40;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnRegister_Click;
            // 
            // tbnPassword
            // 
            tbnPassword.Location = new Point(180, 333);
            tbnPassword.Name = "tbnPassword";
            tbnPassword.Size = new Size(253, 31);
            tbnPassword.TabIndex = 4;
            // 
            // tbnUsername
            // 
            tbnUsername.Enabled = false;
            tbnUsername.Location = new Point(180, 281);
            tbnUsername.Name = "tbnUsername";
            tbnUsername.Size = new Size(253, 31);
            tbnUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 255, 128);
            label2.Location = new Point(75, 333);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 37;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(75, 281);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 36;
            label1.Text = "User";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BackColor = Color.Navy;
            label37.Font = new Font("Cooper Black", 19F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label37.ForeColor = SystemColors.ActiveCaption;
            label37.Location = new Point(423, 29);
            label37.Name = "label37";
            label37.Size = new Size(181, 44);
            label37.TabIndex = 56;
            label37.Text = "Register";
            label37.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditUsercs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1028, 511);
            Controls.Add(label37);
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
            Controls.Add(button2);
            Controls.Add(btnEdit);
            Controls.Add(tbnPassword);
            Controls.Add(tbnUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditUsercs";
            Text = "EditUsercs";
            FormClosed += EditUsercs_FormClosed;
            Load += EditUsercs_Load;
            ((System.ComponentModel.ISupportInitialize)picupload).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnupload;
        private Label label7;
        private PictureBox picupload;
        private TextBox tbstd;
        private Label label6;
        private DateTimePicker dtimeNgaysinh;
        private Label label5;
        private Label label4;
        private RadioButton rdHotel;
        private RadioButton rdCustomer;
        private TextBox tblname;
        private Label label3;
        private TextBox tbfname;
        private Label lblfname;
        private Button button2;
        private Button btnEdit;
        private TextBox tbnPassword;
        private TextBox tbnUsername;
        private Label label2;
        private Label label1;
        private Label label37;
    }
}