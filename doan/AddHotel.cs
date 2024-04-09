using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using doan.Dao;
using doan.Model;
using Microsoft.VisualBasic.ApplicationServices;
namespace doan
{
    public partial class AddHotel : Form
    {
        public AddHotel()
        {
            InitializeComponent();
        }

        private void AddHotel_Load(object sender, EventArgs e)
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            HotelDao hotelDao = new HotelDao();
            hotel.NameHotel = tbNameHotel.Text.Trim();
            hotel.Diachi = tblDiaChi.Text.Trim();
            hotel.Feedback = 0;
            hotel.Xeploai = comboBox1.SelectedIndex;
            hotel.Discription = tbstd.Text.Trim();
            MemoryStream ms = new MemoryStream();
            picupload.Image.Save(ms, picupload.Image.RawFormat);
            hotel.Image = ms;
            hotel.Score = tbnScore.Text.Trim();
            if (rdMotel.Checked = true)
            {
                hotel.Type = "1";
            }
            else if (rdMotel.Checked = true)
            {
                hotel.Type = "2";
            }
            else if (rdCanHo.Checked = true)
            {
                hotel.Type = "3";
            }
            else
            {
                MessageBox.Show("Vui long chon loai hinh cho thue");
            }
            hotel.Gianen = tbnGianen.Text.Trim();
            hotelDao.ThemHotel(hotel);
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}
