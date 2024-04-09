namespace doan
{
    partial class login
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
            label1 = new Label();
            label2 = new Label();
            tbnUsername = new TextBox();
            tbnPassword = new TextBox();
            rdHotel = new RadioButton();
            lblRegister = new Label();
            label4 = new Label();
            btnLogin = new Button();
            button2 = new Button();
            label37 = new Label();
            rdCustomer = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(61, 116);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 0;
            label1.Text = "User";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 255, 128);
            label2.Location = new Point(61, 185);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // tbnUsername
            // 
            tbnUsername.Location = new Point(166, 116);
            tbnUsername.Name = "tbnUsername";
            tbnUsername.Size = new Size(253, 31);
            tbnUsername.TabIndex = 2;
            // 
            // tbnPassword
            // 
            tbnPassword.Location = new Point(166, 185);
            tbnPassword.Name = "tbnPassword";
            tbnPassword.Size = new Size(253, 31);
            tbnPassword.TabIndex = 3;
            // 
            // rdHotel
            // 
            rdHotel.AutoSize = true;
            rdHotel.ForeColor = Color.Lime;
            rdHotel.Location = new Point(288, 150);
            rdHotel.Name = "rdHotel";
            rdHotel.Size = new Size(80, 29);
            rdHotel.TabIndex = 5;
            rdHotel.TabStop = true;
            rdHotel.Text = "Hotel";
            rdHotel.UseVisualStyleBackColor = true;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.FromArgb(255, 255, 128);
            lblRegister.Location = new Point(166, 219);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(75, 25);
            lblRegister.TabIndex = 6;
            lblRegister.Text = "Register";
            lblRegister.Click += lblRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 255, 128);
            label4.Location = new Point(275, 219);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 7;
            label4.Text = "Forget Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(94, 310);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(247, 310);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BackColor = Color.Navy;
            label37.Font = new Font("Cooper Black", 19F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label37.ForeColor = SystemColors.ActiveCaption;
            label37.Location = new Point(152, 9);
            label37.Name = "label37";
            label37.Size = new Size(191, 88);
            label37.TabIndex = 10;
            label37.Text = "Booking \r\nHotel\r\n";
            label37.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rdCustomer
            // 
            rdCustomer.AutoSize = true;
            rdCustomer.ForeColor = Color.Lime;
            rdCustomer.Location = new Point(161, 150);
            rdCustomer.Name = "rdCustomer";
            rdCustomer.Size = new Size(114, 29);
            rdCustomer.TabIndex = 11;
            rdCustomer.TabStop = true;
            rdCustomer.Text = "Customer";
            rdCustomer.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(490, 386);
            Controls.Add(rdCustomer);
            Controls.Add(label37);
            Controls.Add(button2);
            Controls.Add(btnLogin);
            Controls.Add(label4);
            Controls.Add(lblRegister);
            Controls.Add(rdHotel);
            Controls.Add(tbnPassword);
            Controls.Add(tbnUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbnUsername;
        private TextBox tbnPassword;
        private RadioButton radioButton1;
        private RadioButton rdHotel;
        private Label lblRegister;
        private Label label4;
        private Button btnLogin;
        private Button button2;
        private Label label37;
        private RadioButton rdCustomer;
    }
}