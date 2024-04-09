namespace doan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbFind = new TextBox();
            panel1 = new Panel();
            findFilter = new ComboBox();
            btnfind = new Button();
            datefilerstart = new DateTimePicker();
            datefilterend = new DateTimePicker();
            panel15 = new Panel();
            button6 = new Button();
            btmanageacc = new Button();
            label37 = new Label();
            lblLogin = new Label();
            lblUserName = new Label();
            picUser = new PictureBox();
            btnNext = new Button();
            btnPrevious = new Button();
            pnbackground3 = new Panel();
            lblservice33 = new Label();
            lblDiachi3 = new Label();
            lblservice31 = new Label();
            lblservice34 = new Label();
            label8 = new Label();
            lblservice32 = new Label();
            lblGiatien3 = new Label();
            btnview3 = new Button();
            label27 = new Label();
            panel10 = new Panel();
            lblfeedback3 = new Label();
            panel11 = new Panel();
            lblScore3 = new Label();
            lblXeploaiScore3 = new Label();
            lblXeploai3 = new Label();
            lblTen3 = new Label();
            pic3 = new PictureBox();
            pnbackground2 = new Panel();
            lblservice23 = new Label();
            lblservice21 = new Label();
            lblservice24 = new Label();
            lblservice22 = new Label();
            lblDiachi2 = new Label();
            label5 = new Label();
            lblGiatien2 = new Label();
            btnview2 = new Button();
            label19 = new Label();
            panel7 = new Panel();
            lblfeedback2 = new Label();
            panel8 = new Panel();
            lblScore2 = new Label();
            lblXeploaiScore2 = new Label();
            lblXeploai2 = new Label();
            lblTen2 = new Label();
            pic2 = new PictureBox();
            pnbackground1 = new Panel();
            lblservice13 = new Label();
            lblDiachi1 = new Label();
            lblservice11 = new Label();
            label7 = new Label();
            lblservice14 = new Label();
            btnview1 = new Button();
            lblservice12 = new Label();
            label13 = new Label();
            panel4 = new Panel();
            lblfeedback1 = new Label();
            panel5 = new Panel();
            lblScore1 = new Label();
            lblXeploaiScore1 = new Label();
            lblGiatien1 = new Label();
            lblXeploai1 = new Label();
            lblTen1 = new Label();
            pic1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            label2 = new Label();
            panel = new Panel();
            rdStar1 = new RadioButton();
            rdStar2 = new RadioButton();
            rdStar3 = new RadioButton();
            rdStar4 = new RadioButton();
            rdStar5 = new RadioButton();
            rdNguyenCan = new RadioButton();
            rdMotel = new RadioButton();
            label3 = new Label();
            rdHotel = new RadioButton();
            label1 = new Label();
            panel1.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnbackground3.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            pnbackground2.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            pnbackground1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            panel2.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // tbFind
            // 
            tbFind.BackColor = SystemColors.Info;
            tbFind.ForeColor = SystemColors.InfoText;
            tbFind.Location = new Point(641, 95);
            tbFind.Name = "tbFind";
            tbFind.Size = new Size(455, 31);
            tbFind.TabIndex = 1;
            tbFind.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(findFilter);
            panel1.Controls.Add(btnfind);
            panel1.Controls.Add(datefilerstart);
            panel1.Controls.Add(datefilterend);
            panel1.Controls.Add(panel15);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnPrevious);
            panel1.Controls.Add(pnbackground3);
            panel1.Controls.Add(pnbackground2);
            panel1.Controls.Add(pnbackground1);
            panel1.Controls.Add(tbFind);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 1050);
            panel1.TabIndex = 4;
            // 
            // findFilter
            // 
            findFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            findFilter.Items.AddRange(new object[] { "By Name", "By Dia Chi", "By date" });
            findFilter.Location = new Point(1483, 91);
            findFilter.Name = "findFilter";
            findFilter.Size = new Size(162, 33);
            findFilter.TabIndex = 28;
            findFilter.SelectedIndexChanged += findFilter_SelectedIndexChanged;
            // 
            // btnfind
            // 
            btnfind.BackColor = Color.DodgerBlue;
            btnfind.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnfind.ForeColor = SystemColors.ButtonFace;
            btnfind.Location = new Point(1666, 88);
            btnfind.Name = "btnfind";
            btnfind.Size = new Size(130, 38);
            btnfind.TabIndex = 9;
            btnfind.Text = "Find";
            btnfind.UseVisualStyleBackColor = false;
            btnfind.Click += btnfind_Click;
            // 
            // datefilerstart
            // 
            datefilerstart.Location = new Point(1102, 93);
            datefilerstart.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            datefilerstart.Name = "datefilerstart";
            datefilerstart.Size = new Size(177, 31);
            datefilerstart.TabIndex = 25;
            // 
            // datefilterend
            // 
            datefilterend.Location = new Point(1299, 93);
            datefilterend.Name = "datefilterend";
            datefilterend.Size = new Size(164, 31);
            datefilterend.TabIndex = 24;
            // 
            // panel15
            // 
            panel15.BackColor = Color.Navy;
            panel15.Controls.Add(button6);
            panel15.Controls.Add(btmanageacc);
            panel15.Controls.Add(label37);
            panel15.Controls.Add(lblLogin);
            panel15.Controls.Add(lblUserName);
            panel15.Controls.Add(picUser);
            panel15.Dock = DockStyle.Left;
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(225, 1050);
            panel15.TabIndex = 20;
            // 
            // button6
            // 
            button6.BackColor = Color.Navy;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ActiveCaption;
            button6.Location = new Point(12, 278);
            button6.Name = "button6";
            button6.Size = new Size(200, 59);
            button6.TabIndex = 16;
            button6.Text = "Booking";
            button6.UseVisualStyleBackColor = false;
            // 
            // btmanageacc
            // 
            btmanageacc.BackColor = Color.Navy;
            btmanageacc.BackgroundImageLayout = ImageLayout.Zoom;
            btmanageacc.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btmanageacc.ForeColor = SystemColors.ActiveCaption;
            btmanageacc.Location = new Point(12, 218);
            btmanageacc.Name = "btmanageacc";
            btmanageacc.Size = new Size(200, 54);
            btmanageacc.TabIndex = 15;
            btmanageacc.Text = "Manage Accound";
            btmanageacc.UseVisualStyleBackColor = false;
            btmanageacc.Click += btmanageacc_Click;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Cooper Black", 19F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label37.ForeColor = SystemColors.ActiveCaption;
            label37.Location = new Point(21, 24);
            label37.Name = "label37";
            label37.Size = new Size(191, 88);
            label37.TabIndex = 6;
            label37.Text = "Booking \r\nHotel\r\n";
            label37.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            lblLogin.Font = new Font("Calibri", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.ImageAlign = ContentAlignment.TopCenter;
            lblLogin.Location = new Point(86, 160);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(88, 33);
            lblLogin.TabIndex = 7;
            lblLogin.Text = "Đăng xuất";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            lblLogin.Click += lblLogin_Click;
            // 
            // lblUserName
            // 
            lblUserName.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = SystemColors.ButtonHighlight;
            lblUserName.Location = new Point(86, 126);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(113, 34);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "Khanh Long";
            lblUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picUser
            // 
            picUser.Image = Properties.Resources.Screenshot_2023_05_15_212854;
            picUser.Location = new Point(12, 124);
            picUser.Name = "picUser";
            picUser.Size = new Size(68, 67);
            picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1699, 837);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(210, 34);
            btnNext.TabIndex = 19;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(1483, 837);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(210, 34);
            btnPrevious.TabIndex = 18;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // pnbackground3
            // 
            pnbackground3.BackColor = Color.AliceBlue;
            pnbackground3.Controls.Add(lblservice33);
            pnbackground3.Controls.Add(lblDiachi3);
            pnbackground3.Controls.Add(lblservice31);
            pnbackground3.Controls.Add(lblservice34);
            pnbackground3.Controls.Add(label8);
            pnbackground3.Controls.Add(lblservice32);
            pnbackground3.Controls.Add(lblGiatien3);
            pnbackground3.Controls.Add(btnview3);
            pnbackground3.Controls.Add(label27);
            pnbackground3.Controls.Add(panel10);
            pnbackground3.Controls.Add(lblXeploai3);
            pnbackground3.Controls.Add(lblTen3);
            pnbackground3.Controls.Add(pic3);
            pnbackground3.Location = new Point(638, 602);
            pnbackground3.Name = "pnbackground3";
            pnbackground3.Size = new Size(1271, 229);
            pnbackground3.TabIndex = 9;
            pnbackground3.Click += pnbackground3_Click;
            // 
            // lblservice33
            // 
            lblservice33.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblservice33.ForeColor = Color.LimeGreen;
            lblservice33.Location = new Point(239, 98);
            lblservice33.Name = "lblservice33";
            lblservice33.Size = new Size(260, 35);
            lblservice33.TabIndex = 27;
            lblservice33.Text = "label9";
            // 
            // lblDiachi3
            // 
            lblDiachi3.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiachi3.ForeColor = Color.FromArgb(64, 64, 64);
            lblDiachi3.Location = new Point(262, 173);
            lblDiachi3.Name = "lblDiachi3";
            lblDiachi3.Size = new Size(689, 51);
            lblDiachi3.TabIndex = 10;
            lblDiachi3.UseWaitCursor = true;
            // 
            // lblservice31
            // 
            lblservice31.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblservice31.ForeColor = Color.LimeGreen;
            lblservice31.Location = new Point(239, 63);
            lblservice31.Name = "lblservice31";
            lblservice31.Size = new Size(260, 35);
            lblservice31.TabIndex = 26;
            lblservice31.Text = "lblservice31";
            // 
            // lblservice34
            // 
            lblservice34.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblservice34.ForeColor = Color.LimeGreen;
            lblservice34.Location = new Point(596, 98);
            lblservice34.Name = "lblservice34";
            lblservice34.Size = new Size(260, 35);
            lblservice34.TabIndex = 25;
            lblservice34.Text = "label14";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(239, 143);
            label8.Name = "label8";
            label8.Size = new Size(75, 25);
            label8.TabIndex = 9;
            label8.Text = "Dia Chi";
            // 
            // lblservice32
            // 
            lblservice32.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblservice32.ForeColor = Color.LimeGreen;
            lblservice32.Location = new Point(596, 63);
            lblservice32.Name = "lblservice32";
            lblservice32.Size = new Size(260, 35);
            lblservice32.TabIndex = 24;
            lblservice32.Text = "lblservice32";
            // 
            // lblGiatien3
            // 
            lblGiatien3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblGiatien3.Font = new Font("Rockwell", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGiatien3.ForeColor = Color.IndianRed;
            lblGiatien3.ImageAlign = ContentAlignment.TopLeft;
            lblGiatien3.Location = new Point(1024, 139);
            lblGiatien3.Name = "lblGiatien3";
            lblGiatien3.RightToLeft = RightToLeft.No;
            lblGiatien3.Size = new Size(236, 44);
            lblGiatien3.TabIndex = 12;
            lblGiatien3.Text = "1875000 VND";
            lblGiatien3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnview3
            // 
            btnview3.BackColor = Color.DodgerBlue;
            btnview3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnview3.ForeColor = SystemColors.ButtonFace;
            btnview3.Location = new Point(1071, 186);
            btnview3.Name = "btnview3";
            btnview3.Size = new Size(193, 38);
            btnview3.TabIndex = 6;
            btnview3.Text = "Xem chỗ trống";
            btnview3.UseVisualStyleBackColor = false;
            btnview3.Click += btnview3_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(1104, 87);
            label27.Name = "label27";
            label27.Size = new Size(160, 25);
            label27.TabIndex = 4;
            label27.Text = "1 đêm 2 người lớn";
            // 
            // panel10
            // 
            panel10.Controls.Add(lblfeedback3);
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(lblXeploaiScore3);
            panel10.Location = new Point(1049, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(217, 70);
            panel10.TabIndex = 3;
            // 
            // lblfeedback3
            // 
            lblfeedback3.AutoSize = true;
            lblfeedback3.Font = new Font("Calibri Light", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblfeedback3.Location = new Point(3, 32);
            lblfeedback3.Name = "lblfeedback3";
            lblfeedback3.Size = new Size(125, 24);
            lblfeedback3.TabIndex = 5;
            lblfeedback3.Text = "1453 đánh giá";
            lblfeedback3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel11
            // 
            panel11.BackColor = Color.MidnightBlue;
            panel11.BackgroundImageLayout = ImageLayout.Center;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(lblScore3);
            panel11.Location = new Point(134, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(74, 64);
            panel11.TabIndex = 4;
            // 
            // lblScore3
            // 
            lblScore3.AutoSize = true;
            lblScore3.Font = new Font("Cooper Black", 19F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore3.ForeColor = SystemColors.ActiveCaption;
            lblScore3.Location = new Point(0, 8);
            lblScore3.Name = "lblScore3";
            lblScore3.Size = new Size(76, 44);
            lblScore3.TabIndex = 5;
            lblScore3.Text = "9,7";
            lblScore3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblXeploaiScore3
            // 
            lblXeploaiScore3.AutoSize = true;
            lblXeploaiScore3.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXeploaiScore3.Location = new Point(38, 5);
            lblXeploaiScore3.Name = "lblXeploaiScore3";
            lblXeploaiScore3.Size = new Size(90, 27);
            lblXeploaiScore3.TabIndex = 4;
            lblXeploaiScore3.Text = "Xuất Sắc";
            lblXeploaiScore3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblXeploai3
            // 
            lblXeploai3.AutoSize = true;
            lblXeploai3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXeploai3.ForeColor = Color.Goldenrod;
            lblXeploai3.Location = new Point(239, 33);
            lblXeploai3.Name = "lblXeploai3";
            lblXeploai3.Size = new Size(76, 30);
            lblXeploai3.TabIndex = 2;
            lblXeploai3.Text = "5 Star";
            // 
            // lblTen3
            // 
            lblTen3.AutoSize = true;
            lblTen3.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTen3.ForeColor = SystemColors.Highlight;
            lblTen3.Location = new Point(239, 3);
            lblTen3.Name = "lblTen3";
            lblTen3.Size = new Size(470, 30);
            lblTen3.TabIndex = 1;
            lblTen3.Text = "Hotel Des Arts Saigon Mgallery Collection";
            lblTen3.Click += lblTen3_Click;
            // 
            // pic3
            // 
            pic3.Image = Properties.Resources._529993275;
            pic3.Location = new Point(3, 3);
            pic3.Name = "pic3";
            pic3.Size = new Size(230, 221);
            pic3.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3.TabIndex = 0;
            pic3.TabStop = false;
            // 
            // pnbackground2
            // 
            pnbackground2.BackColor = Color.AliceBlue;
            pnbackground2.Controls.Add(lblservice23);
            pnbackground2.Controls.Add(lblservice21);
            pnbackground2.Controls.Add(lblservice24);
            pnbackground2.Controls.Add(lblservice22);
            pnbackground2.Controls.Add(lblDiachi2);
            pnbackground2.Controls.Add(label5);
            pnbackground2.Controls.Add(lblGiatien2);
            pnbackground2.Controls.Add(btnview2);
            pnbackground2.Controls.Add(label19);
            pnbackground2.Controls.Add(panel7);
            pnbackground2.Controls.Add(lblXeploai2);
            pnbackground2.Controls.Add(lblTen2);
            pnbackground2.Controls.Add(pic2);
            pnbackground2.Location = new Point(638, 367);
            pnbackground2.Name = "pnbackground2";
            pnbackground2.Size = new Size(1271, 229);
            pnbackground2.TabIndex = 9;
            pnbackground2.Click += pnbackground2_Click;
            // 
            // lblservice23
            // 
            lblservice23.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblservice23.ForeColor = Color.LimeGreen;
            lblservice23.Location = new Point(239, 98);
            lblservice23.Name = "lblservice23";
            lblservice23.Size = new Size(260, 35);
            lblservice23.TabIndex = 23;
            lblservice23.Text = "label9";
            // 
            // lblservice21
            // 
            lblservice21.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblservice21.ForeColor = Color.LimeGreen;
            lblservice21.Location = new Point(239, 63);
            lblservice21.Name = "lblservice21";
            lblservice21.Size = new Size(260, 35);
            lblservice21.TabIndex = 22;
            lblservice21.Text = "label10";
            // 
            // lblservice24
            // 
            lblservice24.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblservice24.ForeColor = Color.LimeGreen;
            lblservice24.Location = new Point(596, 98);
            lblservice24.Name = "lblservice24";
            lblservice24.Size = new Size(260, 35);
            lblservice24.TabIndex = 21;
            lblservice24.Text = "label14";
            // 
            // lblservice22
            // 
            lblservice22.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblservice22.ForeColor = Color.LimeGreen;
            lblservice22.Location = new Point(596, 63);
            lblservice22.Name = "lblservice22";
            lblservice22.Size = new Size(260, 35);
            lblservice22.TabIndex = 20;
            lblservice22.Text = "label15";
            // 
            // lblDiachi2
            // 
            lblDiachi2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiachi2.ForeColor = Color.FromArgb(64, 64, 64);
            lblDiachi2.Location = new Point(262, 169);
            lblDiachi2.Name = "lblDiachi2";
            lblDiachi2.Size = new Size(689, 51);
            lblDiachi2.TabIndex = 12;
            lblDiachi2.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(239, 139);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 11;
            label5.Text = "Dia Chi";
            // 
            // lblGiatien2
            // 
            lblGiatien2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblGiatien2.Font = new Font("Rockwell", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGiatien2.ForeColor = Color.IndianRed;
            lblGiatien2.ImageAlign = ContentAlignment.TopLeft;
            lblGiatien2.Location = new Point(1028, 139);
            lblGiatien2.Name = "lblGiatien2";
            lblGiatien2.RightToLeft = RightToLeft.No;
            lblGiatien2.Size = new Size(236, 44);
            lblGiatien2.TabIndex = 10;
            lblGiatien2.Text = "1875000 VND";
            lblGiatien2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnview2
            // 
            btnview2.BackColor = Color.DodgerBlue;
            btnview2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnview2.ForeColor = SystemColors.ButtonFace;
            btnview2.Location = new Point(1071, 186);
            btnview2.Name = "btnview2";
            btnview2.Size = new Size(193, 38);
            btnview2.TabIndex = 6;
            btnview2.Text = "Xem chỗ trống";
            btnview2.UseVisualStyleBackColor = false;
            btnview2.Click += btnview2_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(1104, 87);
            label19.Name = "label19";
            label19.Size = new Size(160, 25);
            label19.TabIndex = 4;
            label19.Text = "1 đêm 2 người lớn";
            // 
            // panel7
            // 
            panel7.Controls.Add(lblfeedback2);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(lblXeploaiScore2);
            panel7.Location = new Point(1049, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(217, 70);
            panel7.TabIndex = 3;
            // 
            // lblfeedback2
            // 
            lblfeedback2.AutoSize = true;
            lblfeedback2.Font = new Font("Calibri Light", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblfeedback2.Location = new Point(3, 32);
            lblfeedback2.Name = "lblfeedback2";
            lblfeedback2.Size = new Size(125, 24);
            lblfeedback2.TabIndex = 5;
            lblfeedback2.Text = "1453 đánh giá";
            lblfeedback2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            panel8.BackColor = Color.MidnightBlue;
            panel8.BackgroundImageLayout = ImageLayout.Center;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(lblScore2);
            panel8.Location = new Point(134, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(74, 64);
            panel8.TabIndex = 4;
            // 
            // lblScore2
            // 
            lblScore2.AutoSize = true;
            lblScore2.Font = new Font("Cooper Black", 19F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore2.ForeColor = SystemColors.ActiveCaption;
            lblScore2.Location = new Point(0, 8);
            lblScore2.Name = "lblScore2";
            lblScore2.Size = new Size(76, 44);
            lblScore2.TabIndex = 5;
            lblScore2.Text = "9,7";
            lblScore2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblXeploaiScore2
            // 
            lblXeploaiScore2.AutoSize = true;
            lblXeploaiScore2.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXeploaiScore2.Location = new Point(38, 5);
            lblXeploaiScore2.Name = "lblXeploaiScore2";
            lblXeploaiScore2.Size = new Size(90, 27);
            lblXeploaiScore2.TabIndex = 4;
            lblXeploaiScore2.Text = "Xuất Sắc";
            lblXeploaiScore2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblXeploai2
            // 
            lblXeploai2.AutoSize = true;
            lblXeploai2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXeploai2.ForeColor = Color.Goldenrod;
            lblXeploai2.Location = new Point(239, 33);
            lblXeploai2.Name = "lblXeploai2";
            lblXeploai2.Size = new Size(76, 30);
            lblXeploai2.TabIndex = 2;
            lblXeploai2.Text = "5 Star";
            // 
            // lblTen2
            // 
            lblTen2.AutoSize = true;
            lblTen2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTen2.ForeColor = SystemColors.Highlight;
            lblTen2.Location = new Point(239, 3);
            lblTen2.Name = "lblTen2";
            lblTen2.Size = new Size(470, 30);
            lblTen2.TabIndex = 1;
            lblTen2.Text = "Hotel Des Arts Saigon Mgallery Collection";
            lblTen2.Click += lblTen2_Click;
            // 
            // pic2
            // 
            pic2.Image = Properties.Resources._529993275;
            pic2.Location = new Point(3, 3);
            pic2.Name = "pic2";
            pic2.Size = new Size(230, 221);
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.TabIndex = 0;
            pic2.TabStop = false;
            // 
            // pnbackground1
            // 
            pnbackground1.BackColor = Color.AliceBlue;
            pnbackground1.Controls.Add(lblservice13);
            pnbackground1.Controls.Add(lblDiachi1);
            pnbackground1.Controls.Add(lblservice11);
            pnbackground1.Controls.Add(label7);
            pnbackground1.Controls.Add(lblservice14);
            pnbackground1.Controls.Add(btnview1);
            pnbackground1.Controls.Add(lblservice12);
            pnbackground1.Controls.Add(label13);
            pnbackground1.Controls.Add(panel4);
            pnbackground1.Controls.Add(lblGiatien1);
            pnbackground1.Controls.Add(lblXeploai1);
            pnbackground1.Controls.Add(lblTen1);
            pnbackground1.Controls.Add(pic1);
            pnbackground1.ForeColor = SystemColors.ControlDarkDark;
            pnbackground1.Location = new Point(638, 132);
            pnbackground1.Name = "pnbackground1";
            pnbackground1.Size = new Size(1271, 229);
            pnbackground1.TabIndex = 5;
            pnbackground1.Click += pnbackground1_Click;
            // 
            // lblservice13
            // 
            lblservice13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblservice13.ForeColor = Color.LimeGreen;
            lblservice13.Location = new Point(239, 99);
            lblservice13.Name = "lblservice13";
            lblservice13.Size = new Size(260, 35);
            lblservice13.TabIndex = 19;
            lblservice13.Text = "label9";
            // 
            // lblDiachi1
            // 
            lblDiachi1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiachi1.ForeColor = Color.FromArgb(64, 64, 64);
            lblDiachi1.Location = new Point(262, 169);
            lblDiachi1.Name = "lblDiachi1";
            lblDiachi1.Size = new Size(689, 51);
            lblDiachi1.TabIndex = 8;
            lblDiachi1.UseWaitCursor = true;
            lblDiachi1.Click += lblDiachi1_Click;
            // 
            // lblservice11
            // 
            lblservice11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblservice11.ForeColor = Color.LimeGreen;
            lblservice11.Location = new Point(239, 64);
            lblservice11.Name = "lblservice11";
            lblservice11.Size = new Size(260, 35);
            lblservice11.TabIndex = 18;
            lblservice11.Text = "label10";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(239, 139);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 7;
            label7.Text = "Dia Chi";
            // 
            // lblservice14
            // 
            lblservice14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblservice14.ForeColor = Color.LimeGreen;
            lblservice14.Location = new Point(596, 99);
            lblservice14.Name = "lblservice14";
            lblservice14.Size = new Size(260, 35);
            lblservice14.TabIndex = 17;
            lblservice14.Text = "label14";
            // 
            // btnview1
            // 
            btnview1.BackColor = Color.DodgerBlue;
            btnview1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnview1.ForeColor = SystemColors.ButtonFace;
            btnview1.Location = new Point(1071, 186);
            btnview1.Name = "btnview1";
            btnview1.Size = new Size(193, 38);
            btnview1.TabIndex = 6;
            btnview1.Text = "Xem chỗ trống";
            btnview1.UseVisualStyleBackColor = false;
            btnview1.Click += btnview1_Click;
            // 
            // lblservice12
            // 
            lblservice12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblservice12.ForeColor = Color.LimeGreen;
            lblservice12.Location = new Point(596, 64);
            lblservice12.Name = "lblservice12";
            lblservice12.Size = new Size(260, 35);
            lblservice12.TabIndex = 16;
            lblservice12.Text = "label15";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1104, 87);
            label13.Name = "label13";
            label13.Size = new Size(160, 25);
            label13.TabIndex = 4;
            label13.Text = "1 đêm 2 người lớn";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblfeedback1);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(lblXeploaiScore1);
            panel4.Location = new Point(1049, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(217, 70);
            panel4.TabIndex = 3;
            // 
            // lblfeedback1
            // 
            lblfeedback1.AutoSize = true;
            lblfeedback1.Font = new Font("Calibri Light", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblfeedback1.Location = new Point(3, 32);
            lblfeedback1.Name = "lblfeedback1";
            lblfeedback1.Size = new Size(125, 24);
            lblfeedback1.TabIndex = 5;
            lblfeedback1.Text = "1453 đánh giá";
            lblfeedback1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MidnightBlue;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblScore1);
            panel5.Location = new Point(134, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(74, 64);
            panel5.TabIndex = 4;
            // 
            // lblScore1
            // 
            lblScore1.AutoSize = true;
            lblScore1.Font = new Font("Cooper Black", 19F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore1.ForeColor = SystemColors.ActiveCaption;
            lblScore1.Location = new Point(0, 8);
            lblScore1.Name = "lblScore1";
            lblScore1.Size = new Size(76, 44);
            lblScore1.TabIndex = 5;
            lblScore1.Text = "9,7";
            lblScore1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblXeploaiScore1
            // 
            lblXeploaiScore1.AutoSize = true;
            lblXeploaiScore1.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXeploaiScore1.Location = new Point(38, 5);
            lblXeploaiScore1.Name = "lblXeploaiScore1";
            lblXeploaiScore1.Size = new Size(90, 27);
            lblXeploaiScore1.TabIndex = 4;
            lblXeploaiScore1.Text = "Xuất Sắc";
            lblXeploaiScore1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGiatien1
            // 
            lblGiatien1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblGiatien1.Font = new Font("Rockwell", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGiatien1.ForeColor = Color.IndianRed;
            lblGiatien1.ImageAlign = ContentAlignment.TopLeft;
            lblGiatien1.Location = new Point(1028, 139);
            lblGiatien1.Name = "lblGiatien1";
            lblGiatien1.RightToLeft = RightToLeft.No;
            lblGiatien1.Size = new Size(236, 44);
            lblGiatien1.TabIndex = 5;
            lblGiatien1.Text = "1875000 VND";
            lblGiatien1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblXeploai1
            // 
            lblXeploai1.AutoSize = true;
            lblXeploai1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXeploai1.ForeColor = Color.Goldenrod;
            lblXeploai1.Location = new Point(239, 33);
            lblXeploai1.Name = "lblXeploai1";
            lblXeploai1.Size = new Size(76, 30);
            lblXeploai1.TabIndex = 2;
            lblXeploai1.Text = "5 Star";
            // 
            // lblTen1
            // 
            lblTen1.AutoSize = true;
            lblTen1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTen1.ForeColor = SystemColors.Highlight;
            lblTen1.Location = new Point(239, 3);
            lblTen1.Name = "lblTen1";
            lblTen1.Size = new Size(470, 30);
            lblTen1.TabIndex = 1;
            lblTen1.Text = "Hotel Des Arts Saigon Mgallery Collection";
            lblTen1.Click += lblTen1_Click;
            // 
            // pic1
            // 
            pic1.Image = Properties.Resources._529993275;
            pic1.Location = new Point(3, 3);
            pic1.Name = "pic1";
            pic1.Size = new Size(230, 221);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 0;
            pic1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel);
            panel2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(231, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 737);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(9, 687);
            button1.Name = "button1";
            button1.Size = new Size(244, 34);
            button1.TabIndex = 14;
            button1.Text = "filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 3;
            label2.Text = "Filter";
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ActiveCaption;
            panel.Controls.Add(rdStar1);
            panel.Controls.Add(rdStar2);
            panel.Controls.Add(rdStar3);
            panel.Controls.Add(rdStar4);
            panel.Controls.Add(rdStar5);
            panel.Controls.Add(rdNguyenCan);
            panel.Controls.Add(rdMotel);
            panel.Controls.Add(label3);
            panel.Controls.Add(rdHotel);
            panel.Controls.Add(label1);
            panel.Location = new Point(3, 47);
            panel.Name = "panel";
            panel.Size = new Size(395, 532);
            panel.TabIndex = 15;
            // 
            // rdStar1
            // 
            rdStar1.AutoSize = true;
            rdStar1.Location = new Point(6, 318);
            rdStar1.Name = "rdStar1";
            rdStar1.Size = new Size(81, 29);
            rdStar1.TabIndex = 18;
            rdStar1.TabStop = true;
            rdStar1.Text = "1 Star";
            rdStar1.UseVisualStyleBackColor = true;
            // 
            // rdStar2
            // 
            rdStar2.AutoSize = true;
            rdStar2.Location = new Point(6, 283);
            rdStar2.Name = "rdStar2";
            rdStar2.Size = new Size(84, 29);
            rdStar2.TabIndex = 17;
            rdStar2.TabStop = true;
            rdStar2.Text = "2 Star";
            rdStar2.UseVisualStyleBackColor = true;
            // 
            // rdStar3
            // 
            rdStar3.AutoSize = true;
            rdStar3.Location = new Point(6, 248);
            rdStar3.Name = "rdStar3";
            rdStar3.Size = new Size(84, 29);
            rdStar3.TabIndex = 16;
            rdStar3.TabStop = true;
            rdStar3.Text = "3 Star";
            rdStar3.UseVisualStyleBackColor = true;
            // 
            // rdStar4
            // 
            rdStar4.AutoSize = true;
            rdStar4.Location = new Point(6, 213);
            rdStar4.Name = "rdStar4";
            rdStar4.Size = new Size(84, 29);
            rdStar4.TabIndex = 15;
            rdStar4.TabStop = true;
            rdStar4.Text = "4 Star";
            rdStar4.UseVisualStyleBackColor = true;
            // 
            // rdStar5
            // 
            rdStar5.AutoSize = true;
            rdStar5.Location = new Point(6, 178);
            rdStar5.Name = "rdStar5";
            rdStar5.Size = new Size(84, 29);
            rdStar5.TabIndex = 14;
            rdStar5.TabStop = true;
            rdStar5.Text = "5 Star";
            rdStar5.UseVisualStyleBackColor = true;
            // 
            // rdNguyenCan
            // 
            rdNguyenCan.AutoSize = true;
            rdNguyenCan.Location = new Point(6, 108);
            rdNguyenCan.Name = "rdNguyenCan";
            rdNguyenCan.Size = new Size(139, 29);
            rdNguyenCan.TabIndex = 13;
            rdNguyenCan.TabStop = true;
            rdNguyenCan.Text = "Nguyen Can";
            rdNguyenCan.UseVisualStyleBackColor = true;
            // 
            // rdMotel
            // 
            rdMotel.AutoSize = true;
            rdMotel.Location = new Point(6, 73);
            rdMotel.Name = "rdMotel";
            rdMotel.Size = new Size(87, 29);
            rdMotel.TabIndex = 12;
            rdMotel.TabStop = true;
            rdMotel.Text = "Motel";
            rdMotel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(6, 150);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 10;
            label3.Text = "Xếp Loại";
            // 
            // rdHotel
            // 
            rdHotel.AutoSize = true;
            rdHotel.Location = new Point(6, 38);
            rdHotel.Name = "rdHotel";
            rdHotel.Size = new Size(83, 29);
            rdHotel.TabIndex = 11;
            rdHotel.TabStop = true;
            rdHotel.Text = "Hotel";
            rdHotel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 10;
            label1.Text = "Loại Chỗ Ở";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnbackground3.ResumeLayout(false);
            pnbackground3.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            pnbackground2.ResumeLayout(false);
            pnbackground2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            pnbackground1.ResumeLayout(false);
            pnbackground1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbFind;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel pnbackground1;
        private PictureBox pic1;
        private Label lblTen1;
        private Label lblXeploai1;
        private Panel panel4;
        private Panel panel5;
        private Label lblXeploaiScore1;
        private Label lblScore1;
        private Label lblfeedback1;
        private Label lblGiatien1;
        private Label label13;
        private Button btnview1;
        private Label lblDiachi1;
        private Label label7;
        private Panel pnbackground3;
        private Label lblGiatien3;
        private Button btnview3;
        private Label label27;
        private Panel panel10;
        private Label lblfeedback3;
        private Panel panel11;
        private Label lblScore3;
        private Label lblXeploaiScore3;
        private Label lblXeploai3;
        private Label lblTen3;
        private PictureBox pic3;
        private Panel pnbackground2;
        private Label lblGiatien2;
        private Button btnview2;
        private Label label19;
        private Panel panel7;
        private Label lblfeedback2;
        private Panel panel8;
        private Label lblScore2;
        private Label lblXeploaiScore2;
        private Label lblXeploai2;
        private Label lblTen2;
        private PictureBox pic2;
        private Panel panel;
        private Label label1;
        private Button btnNext;
        private Button btnPrevious;
        private Panel panel15;
        private Label lblUserName;
        private PictureBox picUser;
        private Label lblLogin;
        private Label label37;
        private DateTimePicker datefilerstart;
        private DateTimePicker datefilterend;
        private TextBox tbDiaChi;
        private Label label38;
        private Button btnfind;
        private ComboBox findFilter;
        private Label label2;
        private RadioButton rdStar1;
        private RadioButton rdStar2;
        private RadioButton rdStar3;
        private RadioButton rdStar4;
        private RadioButton rdStar5;
        private RadioButton rdNguyenCan;
        private RadioButton rdMotel;
        private Label label3;
        private RadioButton rdHotel;
        private Button btmanageacc;
        private Button button6;
        private Label lblDiachi3;
        private Label label8;
        private Label lblDiachi2;
        private Label label5;
        private Label lblservice13;
        private Label lblservice11;
        private Label lblservice14;
        private Label lblservice12;
        private Label lblservice33;
        private Label lblservice31;
        private Label lblservice34;
        private Label lblservice32;
        private Label lblservice23;
        private Label lblservice21;
        private Label lblservice24;
        private Label lblservice22;
    }
}
