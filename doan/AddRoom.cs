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

namespace doan
{
    public partial class AddRoom : Form
    {
        int idhotel;
        public AddRoom(int idhotel)
        {
            InitializeComponent();
            this.idhotel = idhotel;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            RoomDao roomDao = new RoomDao();

            room.Idhotel=idhotel;
            room.Dientich=Convert.ToInt32(tbDienTich.Text.Trim());
            room.Discription=tbDiscription.Text.Trim();
            room.GiaTien=tbGiaTien.Text.Trim();
            room.Type=tbType.Text.Trim();
            room.SoLuongToiDa=Convert.ToInt32(tbSoluong.Text.Trim());
            roomDao.UpdateRoom(room);
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
