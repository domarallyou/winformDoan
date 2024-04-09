using doan.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDao userDao = new UserDao();
            int userid = userDao.UserLogin(tbnUsername.Text.Trim(), tbnPassword.Text.Trim());
            bool quanly=userDao.UserLogin1(tbnUsername.Text.Trim(), tbnPassword.Text.Trim());
           

            if (userid != 0)
            {
                Form1 form1 = new Form1(userid,quanly);
                form1.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tai khoan hoac mat khau");
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
