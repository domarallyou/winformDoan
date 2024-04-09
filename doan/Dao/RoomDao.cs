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
    internal class RoomDao
    {
        DBConnection dBconnection = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public DataTable FindRoom()
        {
            string sqlStr = string.Format("select * from Room");
            return dBconnection.Load(sqlStr);


        }
        public DataTable FindRoombyId(int IdHotel)
        {
            string sqlStr = string.Format("select * from Room where IdHotel='{0}'", IdHotel);
            return dBconnection.Load(sqlStr);

        }

        public void ThemRoom(Room room)
        {
            conn.Open();

            string sqlStr = string.Format("INSERT INTO [Room](IdHotel,Type,SoLuongToiDa,DienTich,Discription,GiaTien) " +
                "VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", room.Idhotel,room.Type,room.SoLuongToiDa,room.Dientich,room.Discription,room.GiaTien);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show(" thanh cong ");
            }
            conn.Close();
        }

        public void UpdateRoom(Room room)
        {
            conn.Open();

            string sqlStr = string.Format("UPDATE [Room] SET " +
                                          "Type = '{0}', " +
                                          "SoLuongToiDa = '{1}', " +
                                          "DienTich = '{2}', " +
                                          "Discription = '{3}', " +
                                          "GiaTien = '{4}' " +
                                          "WHERE Type = '{0}'",
                                          room.Type, room.SoLuongToiDa, room.Dientich, room.Discription, room.GiaTien );

            SqlCommand cmd = new SqlCommand(sqlStr, conn);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật phòng thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật phòng thất bại");
            }

            conn.Close();
        }
        public void DeleteRoom(int idHotel,int roomID,int dientich)
        {
            conn.Open();

            string sqlStr = string.Format("DELETE FROM [Room] WHERE Type = {0} and IdHotel='{1}' and DienTich='{2}'", roomID,idHotel,dientich);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa phòng thành công");
            }
            else
            {
                MessageBox.Show("Xóa phòng thất bại");
            }

            conn.Close();
        }


        public Room InfoRoom(DataTable dt, int rowin)
        {
            Room room = new Room();

            try
            {
                DataRow row;
                row = dt.Rows[rowin];
                room.Id =Convert.ToInt32(row["Id"].ToString());
                room.Type = row["Type"].ToString().Trim();
                room.SoLuongToiDa = Convert.ToInt32(row["SoLuongToiDa"].ToString());
                room.Dientich = Convert.ToInt32(row["Dientich"].ToString());
                room.Discription = row["Discription"].ToString();
                room.GiaTien = row["GiaTien"].ToString();


                return room;
            }
            catch (Exception ex)
            {
                room.Type = "";
                room.SoLuongToiDa = 0;
                room.Dientich = 0;
                room.Discription = "";
                room.GiaTien = "";
                room.test = false;
                return room;

            }

        }
        public DataTable serviceRoom(int idRoom)
        {
            string sqlStr = string.Format("SELECT ServiceRoom.ServiceRoom FROM Room INNER JOIN ServiceOfRoom ON Room.Id = ServiceOfRoom.IdRoom " +
                                        "INNER JOIN ServiceRoom ON ServiceOfRoom.idService = ServiceRoom.Id WHERE Room.Id = '{0}'", idRoom);
            return dBconnection.Load(sqlStr);
        }

        public string[] takeservice(DataTable dt, string rowat, int countrow)
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
