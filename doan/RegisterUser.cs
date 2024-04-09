using doan.Dao;
using doan.Model;
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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picupload.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            User user = new User();
            UserDao userDao = new UserDao();
            user.fName = tbfname.Text;
            user.lName = tblname.Text;
            if (rdCustomer.Checked)
            {
                user.Role = true;
            }
            else
            {
                user.Role = false;
            }
            user.Ngaysinh = dtimeNgaysinh.Value.ToString();
            user.Sdt = tbstd.Text;
            MemoryStream ms = new MemoryStream();
            picupload.Image.Save(ms, picupload.Image.RawFormat);
            user.Image = ms;
            user.Username = tbnUsername.Text;
            user.Password = tbnPassword.Text;
            userDao.ThemUser(user);
        }

        private void RegisterUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            login login = new login();
            login.Show();
        }

        private void dtimeNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
