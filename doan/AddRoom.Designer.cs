namespace doan
{
    partial class AddRoom
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
            label5 = new Label();
            label4 = new Label();
            tbSoluong = new TextBox();
            label3 = new Label();
            tbType = new TextBox();
            button2 = new Button();
            btnRegister = new Button();
            tbGiaTien = new TextBox();
            tbDienTich = new TextBox();
            label2 = new Label();
            label = new Label();
            tbDiscription = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 255, 128);
            label5.Location = new Point(379, 98);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 73;
            label5.Text = "Discription";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 255, 128);
            label4.Location = new Point(30, 101);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 72;
            label4.Text = "Type";
            // 
            // tbSoluong
            // 
            tbSoluong.Location = new Point(194, 145);
            tbSoluong.Name = "tbSoluong";
            tbSoluong.Size = new Size(141, 31);
            tbSoluong.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(30, 148);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 71;
            label3.Text = "So Luong Toi Da";
            // 
            // tbType
            // 
            tbType.Location = new Point(194, 98);
            tbType.Name = "tbType";
            tbType.Size = new Size(141, 31);
            tbType.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(187, 479);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 69;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(34, 479);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 68;
            btnRegister.Text = "Add";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbGiaTien
            // 
            tbGiaTien.Location = new Point(194, 237);
            tbGiaTien.Name = "tbGiaTien";
            tbGiaTien.Size = new Size(141, 31);
            tbGiaTien.TabIndex = 4;
            // 
            // tbDienTich
            // 
            tbDienTich.Location = new Point(194, 190);
            tbDienTich.Name = "tbDienTich";
            tbDienTich.Size = new Size(141, 31);
            tbDienTich.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 255, 128);
            label2.Location = new Point(34, 237);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 67;
            label2.Text = "Gia Tien/1Đem";
            // 
            // label
            // 
            label.AutoSize = true;
            label.ForeColor = Color.FromArgb(255, 255, 128);
            label.Location = new Point(34, 190);
            label.Name = "label";
            label.Size = new Size(81, 25);
            label.TabIndex = 3;
            label.Text = "Dien tich";
            // 
            // tbDiscription
            // 
            tbDiscription.Location = new Point(505, 98);
            tbDiscription.Multiline = true;
            tbDiscription.Name = "tbDiscription";
            tbDiscription.Size = new Size(546, 335);
            tbDiscription.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(255, 255, 128);
            label6.Location = new Point(34, 325);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 75;
            label6.Text = "Service";
            // 
            // AddRoom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 0);
            ClientSize = new Size(1161, 574);
            Controls.Add(label6);
            Controls.Add(tbDiscription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbSoluong);
            Controls.Add(label3);
            Controls.Add(tbType);
            Controls.Add(button2);
            Controls.Add(btnRegister);
            Controls.Add(tbGiaTien);
            Controls.Add(tbDienTich);
            Controls.Add(label2);
            Controls.Add(label);
            Name = "AddRoom";
            Text = "AddRoom";
            Load += AddRoom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private TextBox tbSoluong;
        private Label label3;
        private TextBox tbType;
        private Button button2;
        private Button btnRegister;
        private TextBox tbGiaTien;
        private TextBox tbDienTich;
        private Label label2;
        private Label label;
        private TextBox tbDiscription;
        private Label label6;
    }
}