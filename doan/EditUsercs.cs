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
    public partial class EditUsercs : Form
    {
        public EditUsercs(int iduser)
        {
            InitializeComponent();
            this.iduser = iduser;
        }
        int iduser;
        private void EditUsercs_Load(object sender, EventArgs e)
        {
            UserDao userDao = new UserDao();
            User user = new User();

            user = userDao.InfoUser(userDao.Userbyid(iduser), 0);
            DateTime ngaysinh = DateTime.ParseExact(user.Ngaysinh, "dd/MM/yyyy", null);
            dtimeNgaysinh.Value = ngaysinh;
            tbfname.Text = user.fName;
            tblname.Text = user.lName;
            tbnUsername.Text = user.Username;
            tbnPassword.Text = user.Password;
            tbstd.Text = user.Sdt;
            if (user.Role)
            {
                rdHotel.Checked = true;
            }
            else { rdCustomer.Checked = true; }
            try
            {
                Image image = Image.FromStream(user.Image);
                picupload.Image = image;
            }
            catch (Exception ex)
            {
                picupload.Image = null;
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
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
            user.Ngaysinh = dtimeNgaysinh.Text;
            user.Sdt = tbstd.Text;
            MemoryStream ms = new MemoryStream();
            picupload.Image.Save(ms, picupload.Image.RawFormat);
            user.Image = ms;
            user.Username = tbnUsername.Text;
            user.Password = tbnPassword.Text;
            userDao.UpdateUser(user);
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

        private void dtimeNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EditUsercs_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
