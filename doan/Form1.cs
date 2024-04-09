using doan.Dao;
using doan.Model;
using System.Data;
using System.Windows.Forms;

namespace doan
{
    public partial class Form1 : Form
    {
        public Form1(int iduser, bool quanly)
        {
            InitializeComponent();
            userid = iduser;
            this.quanly = quanly;
        }


        int page, userid;
        bool quanly = false;
        DataTable maindt;


        void loaddata(DataTable dt, int page)
        {
            btnNext.Enabled = true;
            int page1;
            page1 = page - 1;
            for (int j = 1; j < page; j++)
            {
                page1 = page1 + 2;
            }
            HotelDao hotelDao = new HotelDao();
            Hotel hotel = new Hotel();
            Hotel hoteltest = hotelDao.InfoHotel(dt, page1 + 3);
            if (hoteltest.test == false)
            {
                btnNext.Enabled = false;
            }


            hotel = hotelDao.InfoHotel(dt, page1);
            DataTable service = hotelDao.serviceHotel(Convert.ToInt32(hotel.Id));
            string[] lblNames = hotelDao.takeservice(service, "Service",4);

            lblservice11.Text = lblNames[0];
            lblservice12.Text = lblNames[1];
            lblservice13.Text = lblNames[2];
            lblservice14.Text = lblNames[3];


            lblTen1.Text = hotel.NameHotel;
            lblScore1.Text = hotel.Score;
            lblXeploai1.Text = hotel.Xeploai + " Star";
            lblfeedback1.Text = hotel.Feedback + " đánh giá";
            lblGiatien1.Text = hotel.Gianen + " VND";
            lblDiachi1.Text = hotel.Diachi;

            using (hotel.Image)
            {
                try
                {
                    Image image = Image.FromStream(hotel.Image);
                    pic1.Image = image;
                }
                catch (Exception ex)
                {
                    pic1.Image = null;
                }
            }

            hotel = hotelDao.InfoHotel(dt, page1 + 1);
            DataTable service1 = hotelDao.serviceHotel(Convert.ToInt32(hotel.Id));
            lblNames=hotelDao.takeservice(service1,"Service", 4);
            lblservice21.Text = lblNames[0];
            lblservice22.Text = lblNames[1];
            lblservice23.Text = lblNames[2];
            lblservice24.Text = lblNames[3];

            lblTen2.Text = hotel.NameHotel;
            lblScore2.Text = hotel.Score;
            lblXeploai2.Text = hotel.Xeploai + " Star";
            lblfeedback2.Text = hotel.Feedback + " đánh giá";
            lblGiatien2.Text = hotel.Gianen + " VND";
            lblDiachi2.Text = hotel.Diachi;

            using (hotel.Image)
            {
                try
                {
                    Image image = Image.FromStream(hotel.Image);
                    pic2.Image = image;
                }
                catch (Exception ex)
                {
                    pic2.Image = null;

                }
            }

            hotel = hotelDao.InfoHotel(dt, page1 + 2);
            DataTable service2 = hotelDao.serviceHotel(Convert.ToInt32(hotel.Id));

            lblNames = hotelDao.takeservice(service2, "Service", 4);
            lblservice31.Text = lblNames[0];
            lblservice32.Text = lblNames[1];
            lblservice33.Text = lblNames[2];
            lblservice34.Text = lblNames[3];


            lblTen3.Text = hotel.NameHotel;
            lblScore3.Text = hotel.Score;
            lblXeploai3.Text = hotel.Xeploai + " Star";
            lblfeedback3.Text = hotel.Feedback + " đánh giá";
            lblGiatien3.Text = hotel.Gianen + " VND";
            lblDiachi3.Text = hotel.Diachi;
            using (hotel.Image)
            {
                try
                {
                    Image image = Image.FromStream(hotel.Image);
                    pic3.Image = image;
                }
                catch (Exception ex)
                {
                    pic3.Image = null;
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            datefilerstart.Enabled = false;
            datefilterend.Enabled = false;
            btnPrevious.Enabled = false;
            page = 1;
            UserDao userdao = new UserDao();
            HotelDao hoteldao = new HotelDao();
            maindt = hoteldao.TimHotel2();
            User user = userdao.InfoUser(userdao.Userbyid(userid), 0);
            lblUserName.Text = user.fName.ToString().Trim();
            lblLogin.Text = "Dang xuat";
            loaddata(maindt, page);
            try
            {
                Image image = Image.FromStream(user.Image);
                picUser.Image = image;
            }
            catch (Exception ex)
            {
                picUser.Image = null;
            }
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            page++;
            HotelDao hoteldao = new HotelDao();
            loaddata(maindt, page);
            btnPrevious.Enabled = true;

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (page > 2)
            {
                page--;
                HotelDao hoteldao = new HotelDao();
                loaddata(maindt, page);
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
            }
            else if (page == 2)
            {
                page--;
                HotelDao hoteldao = new HotelDao();
                loaddata(maindt, page);
                btnPrevious.Enabled = false;
                btnNext.Enabled = true;
            }
        }

        private void lblTen1_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail(page);
            detail.ShowDialog();
        }

        private void lblTen2_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail(page + 1);
            detail.ShowDialog();
        }

        private void lblTen3_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail(page + 2);
            detail.ShowDialog();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            HotelDao hoteldao = new HotelDao();
            if (rdHotel.Checked)
            {
                page = 1;
                maindt = hoteldao.findbytype(1);
                loaddata(maindt, page);
            }
            else if (rdMotel.Checked)
            {
                page = 1;
                maindt = hoteldao.findbytype(2);
                loaddata(maindt, page);
            }
            else if (rdNguyenCan.Checked)
            {
                page = 1;
                maindt = hoteldao.findbytype(3);
                loaddata(maindt, page);
            }
            else if (rdStar1.Checked)
            {
                page = 1;
                maindt = hoteldao.findbyStar(1);
                loaddata(maindt, page);
            }
            else if (rdStar2.Checked)
            {
                page = 1;
                maindt = hoteldao.findbyStar(2);
                loaddata(maindt, page);
            }
            else if (rdStar3.Checked)
            {
                page = 1;
                maindt = hoteldao.findbyStar(3);
                loaddata(maindt, page);
            }
            else if (rdStar4.Checked)
            {
                page = 1;
                maindt = hoteldao.findbyStar(4);
                loaddata(maindt, page);
            }
            else if (rdStar5.Checked)
            {
                page = 1;
                maindt = hoteldao.findbyStar(5);
                loaddata(maindt, page);
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            HotelDao hoteldao = new HotelDao();

            if (findFilter.Text.Trim() == "By Name")
            {
                page = 1;
                maindt = hoteldao.findbyName(tbFind.Text.Trim());
                loaddata(maindt, page);
            }
            else if (findFilter.Text.Trim() == "By Dia Chi")
            {
                page = 1;
                maindt = hoteldao.findbyDiachi(tbFind.Text.Trim());
                loaddata(maindt, page);
            }
            else if (findFilter.Text.Trim() == "By date")
            {
                page = 1;
                maindt = hoteldao.findbyDiachi(tbFind.Text.Trim());
                loaddata(maindt, page);
            }
        }

        private void findFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (findFilter.SelectedIndex.Equals("By date"))
            {
                datefilerstart.Enabled = true;
                datefilterend.Enabled = true;
            }
        }

        private void btmanageacc_Click(object sender, EventArgs e)
        {
            EditUsercs editUsercs = new EditUsercs(userid);
            editUsercs.ShowDialog();
        }

        private void lblDiachi1_Click(object sender, EventArgs e)
        {

        }



        private void btnview3_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail(page + 2);
            detail.ShowDialog();
        }

        private void btnview2_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail(page + 1);
            detail.ShowDialog();
        }

        private void btnview1_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail(page);
            detail.ShowDialog();
        }

        private void pnbackground1_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail(page);
            detail.ShowDialog();
        }

        private void pnbackground2_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail(page + 1);
            detail.ShowDialog();
        }

        private void pnbackground3_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail(page+2);
            detail.ShowDialog();
        }
    }
}
