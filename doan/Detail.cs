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
    public partial class Detail : Form
    {
        int idhotel;
        int page = 1;
        public Detail(int i)
        {
            InitializeComponent();
            idhotel = i;
        }
        void loaddataRoom(int i, int page)
        {
            int page1;
            page1 = page - 1;
            for (int j = 1; j < page; j++)
            {
                page1 = page1 + 1;
            }
            RoomDao roomDao = new RoomDao();
            Room room = new Room();
            DataTable dt1 = roomDao.FindRoombyId(idhotel);
            room = roomDao.InfoRoom(dt1, page1);
            int test = page1 + 2;
            Room roomtest = roomDao.InfoRoom(dt1, test);
            if (roomtest.test == false)
            {
                btnNext.Enabled = false;
            }
            lblRoomname1.Text = room.Type.ToString();
            lblSLng1.Text = room.SoLuongToiDa.ToString();
            lblGiatien1.Text = room.GiaTien.ToString();
            lblDientich1.Text = room.Dientich.ToString() + "m2";
            string[] lblNames = roomDao.takeservice(roomDao.serviceRoom(room.Id), "ServiceRoom", 8);
            lblserviceroom11.Text = lblNames[0];
            lblserviceroom12.Text = lblNames[1];
            lblserviceroom13.Text = lblNames[2];
            lblserviceroom14.Text = lblNames[3];

            room = roomDao.InfoRoom(dt1, page1 + 1);
            lblRoomname2.Text = room.Type.ToString();
            lblSlng2.Text = room.SoLuongToiDa.ToString();
            lblGiatien2.Text = room.GiaTien.ToString();
            lblDientich2.Text = room.Dientich.ToString() + "m2";

            lblNames = roomDao.takeservice(roomDao.serviceRoom(room.Id), "ServiceRoom", 8);
            lblserviceroom21.Text = lblNames[0];
            lblserviceroom22.Text = lblNames[1];
            lblserviceroom23.Text = lblNames[2];
            lblserviceroom24.Text = lblNames[3];

        }
        void loaddata(int i)
        {
            HotelDao hotelDao = new HotelDao();
            DataTable dt = hotelDao.TimHotel3(i);
            Hotel hotel = hotelDao.InfoHotel(dt, 0);
            lblNamehotel.Text = hotel.NameHotel;
            lblXeploai.Text = hotel.Xeploai.ToString() + " Star";
            lblDescription.Text = hotel.Discription.ToString();

            using (hotel.Image)
            {
                Image image = Image.FromStream(hotel.Image);
                picHotel.Image = image;
            }
            string[] lblNames=hotelDao.takeservice(hotelDao.serviceHotel(hotel.Id), "ServiceRoom", 8);
            lblhotelsevice1.Text = lblNames[0];
            lblhotelsevice2.Text = lblNames[1];
            lblhotelsevice3.Text = lblNames[2];
            lblhotelsevice4.Text = lblNames[3];
            lblhotelsevice5.Text = lblNames[4];
            lblhotelsevice6.Text = lblNames[5];
            lblhotelsevice7.Text = lblNames[6];
            lblhotelsevice8.Text = lblNames[7];


        }
        private void Detail_Load(object sender, EventArgs e)
        {
            btnPrevious.Enabled = false;
            page = 1;
            loaddata(idhotel);
            loaddataRoom(idhotel, page);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            page++;
            loaddata(idhotel);
            loaddataRoom(idhotel, page);
            btnPrevious.Enabled = true;
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (page > 2)
            {
                page--;
                loaddata(idhotel);
                loaddataRoom(idhotel, page);

                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
            }
            else if (page == 2)
            {
                page--;
                loaddata(idhotel);
                loaddataRoom(idhotel, page);
                btnPrevious.Enabled = false;
                btnNext.Enabled = true;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
