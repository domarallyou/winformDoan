using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.Model;
using doan.Connection;

namespace doan.Dao
{
    internal class HotelDao
    {
        DBConnection dBconnection = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public DataTable LoadHotel()
        {
            string sqlStr = string.Format("select * from Hotel");
            return dBconnection.Load(sqlStr);
        }

        public Hotel InfoHotel(DataTable dt, int rowin)
        {
            Hotel hotel = new Hotel();

            try
            {
                DataRow row;
                row = dt.Rows[rowin];
                hotel.Id =Convert.ToInt32(row["Id"].ToString());
                hotel.NameHotel = row["NameHotel"].ToString();
                hotel.Score = row["Score"].ToString();
                hotel.Xeploai = Convert.ToInt32(row["XepLoai"].ToString());
                hotel.Feedback = Convert.ToInt32(row["Feedback"].ToString());
                hotel.Gianen = row["Gianen"].ToString();
                hotel.Diachi = row["DiaChi"].ToString();
                hotel.Discription = row["Discripytion"].ToString();
                byte[] pic;
                pic = (byte[])row["Image"];
                MemoryStream ms = new MemoryStream(pic);
                hotel.Image = ms;
                return hotel;
            }
            catch (Exception ex)
            {
                hotel.NameHotel = "";
                hotel.Score = "";
                hotel.Xeploai = 0;
                hotel.Feedback = 0;
                hotel.Gianen = "0";
                hotel.Image = null;
                hotel.Diachi = "";
                hotel.test = false;
                return hotel;

            }

        }



        public DataTable TimHotel2()
        {
            string sqlStr = string.Format("SELECT * FROM Hotel;");
            return dBconnection.Load(sqlStr);

        }
        public DataTable TimHotel3(int id)
        {
            string sqlStr = string.Format("select * from Hotel Where Id='{0}'", id);
            return dBconnection.Load(sqlStr);

        }
        public DataTable findbytype(int type)
        {
            string sqlStr = string.Format("select * from Hotel Where Type='{0}'", type);
            return dBconnection.Load(sqlStr);

        }
        public DataTable findbyDiachi(string ht)
        {
            string sqlStr = string.Format("SELECT * FROM Hotel WHERE UPPER(DiaChi) LIKE '%{0}%';", ht);
            return dBconnection.Load(sqlStr);

        }
        public DataTable findbyName(string ht)
        {
            string sqlStr = string.Format("SELECT * FROM Hotel WHERE UPPER(NameHotel) LIKE '%{0}%';", ht);
            return dBconnection.Load(sqlStr);

        }
        public DataTable findbydate(string ht)
        {
            string sqlStr = string.Format("SELECT * FROM Hotel WHERE UPPER(DiaChi) LIKE '%{0}%';", ht);
            return dBconnection.Load(sqlStr);

        }
        public DataTable findbyStar(int ht)
        {
            string sqlStr = string.Format("SELECT * FROM Hotel WHERE XepLoai ='{0}';", ht);
            return dBconnection.Load(sqlStr);

        }

        public void ThemHotel(Hotel hotel)
        {
            conn.Open();

            byte[] bytes = hotel.Image.ToArray();
            string sqlStr = string.Format("INSERT INTO [Hotel](NameHotel,DiaChi,XepLoai,Feedback,Score,Type,Gianen,Image,Discripytion) " +
                "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}',@image,'{7}')", hotel.NameHotel, hotel.Diachi, hotel.Xeploai, hotel.Feedback, hotel.Score, hotel.Type, hotel.Gianen, hotel.Discription);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            cmd.Parameters.AddWithValue("@image", bytes);
            if (cmd.ExecuteNonQuery() > 0)

            {
                MessageBox.Show(" thanh cong ");
            }
            conn.Close();
        }
        public void UpdateHotel(Hotel hotel)
        {
            conn.Open();

            byte[] bytes = hotel.Image.ToArray();
            string sqlStr = string.Format("UPDATE [Hotel] SET " +
                                          "NameHotel = '{0}', " +
                                          "DiaChi = '{1}', " +
                                          "XepLoai = '{2}', " +
                                          "Feedback = '{3}', " +
                                          "Score = '{4}', " +
                                          "Type = '{5}', " +
                                          "Gianen = '{6}', " +
                                          "Image = @image, " +
                                          "Discripytion = '{7}' " +
                                          "WHERE NameHotel='{0}'",
                                          hotel.NameHotel, hotel.Diachi, hotel.Xeploai, hotel.Feedback, hotel.Score, hotel.Type, hotel.Gianen, hotel.Discription);

            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            cmd.Parameters.AddWithValue("@image", bytes);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }

            conn.Close();
        }
        public void DeleteHotel(string hotelname)
        {
            string sqlStr = string.Format("DELETE FROM [Hotel] WHERE NameHotel = {0}", hotelname);
            dBconnection.Thucthi(sqlStr);
        }

        public DataTable serviceHotel(int idHotel)
        {
            string sqlStr = string.Format("SELECT HotelService.Service FROM Hotel INNER JOIN serviceHotel ON Hotel.Id = serviceHotel.idHotel " +
                                          "INNER JOIN HotelService ON serviceHotel.idServiceHotel = HotelService.Id WHERE Hotel.Id = '{0}';", idHotel);
            DataTable dt;
            return dBconnection.Load(sqlStr);
        }

        public string[] takeservice(DataTable dt, string rowat,int countrow)
        {
            string[] lblNames = new string[countrow]; 

            for (int i = 0; i < countrow; i++)
            {
                try
                {
                    DataRow row = dt.Rows[i]; 
                    lblNames[i] = row[rowat].ToString(); 
                }
                catch
                {
                    lblNames[i] = ""; 
                }
            }

            return lblNames;
        }

    }
}
