using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan.Model;
using doan.Connection;
using System.Data.Common;

namespace doan.Dao
{
    internal class UserDao
    {

        DBConnection dBconnection = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public int UserLogin(string username, string pass)
        {
            try
            {
                string sqlStr = string.Format("select * from [User] where username='{0}' and password ='{1}'", username, pass);
                DataTable dt = dBconnection.Load(sqlStr);

                if (dt != null)
                {
                    DataRow row;
                    row = dt.Rows[0];
                    int iduser = Convert.ToInt32(row["ID"]);
                    return iduser;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public bool UserLogin1(string username, string pass)
        {
            bool role = false;
            try
            {
                string sqlStr = string.Format("select * from [User] where username='{0}' and password ='{1}'", username, pass);
                DataTable dt = dBconnection.Load(sqlStr);

                if (dt != null)
                {
                    DataRow row;
                    row = dt.Rows[0];
                    role = (bool)row["Role"];
                }
                return role;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable Userbyid(int id)
        {
            string sqlStr = string.Format("select * from [User] where Id='{0}'", id);
            return dBconnection.Load(sqlStr);
        }
        public User InfoUser(DataTable dt, int rowin)
        {
            User user = new User();

            try
            {
                DataRow row;
                row = dt.Rows[rowin];
                user.Id = Convert.ToInt32(row["ID"]);
                user.fName = row["fname"].ToString().Trim();
                user.lName = row["lname"].ToString().Trim();
                user.Sdt = row["sdt"].ToString().Trim();
                user.Role = (bool)row["Role"];
                user.Username = row["username"].ToString().Trim();
                user.Password = row["password"].ToString().Trim();
                user.Id = Convert.ToInt32(row["ID"].ToString());
                user.Ngaysinh = row["ngaysinh"].ToString().Trim();
                byte[] pic;
                pic = (byte[])row["image"];
                MemoryStream ms = new MemoryStream(pic);
                user.Image = ms;

                return user;
            }
            catch (Exception ex)
            {

                user.fName = "Guest";
                user.lName = "";
                user.Sdt = "";
                user.Role = true;
                user.Username = "";
                user.Password = "";
                user.Id = 0;
                user.Ngaysinh = "";
                byte[] pic;
                pic = null;
                MemoryStream ms = new MemoryStream(pic);
                user.Image = ms;
                return user;

            }

        }


        public void ThemUser(User user)
        {
            conn.Open();
            byte[] bytes = user.Image.ToArray();
            string sqlStr = string.Format("INSERT INTO [User](fname,lname,Role,sdt,ngaysinh,username,password,image) " +
                "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}',@image)", user.fName, user.lName, user.Role, user.Sdt, user.Ngaysinh, user.Username, user.Password);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            cmd.Parameters.AddWithValue("@image", bytes);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show(" thanh cong ");
            }
            conn.Close();
        }

        public void UpdateUser(User user)
        {
            conn.Open();
            byte[] bytes = user.Image.ToArray();
            string sqlStr = string.Format("UPDATE [User] SET " +
                                          "fname = '{0}', " +
                                          "lname = '{1}', " +
                                          "Role = '{2}', " +
                                          "sdt = '{3}', " +
                                          "ngaysinh = '{4}', " +
                                          "password = '{6}', " +
                                          "image = @image " +
                                          "WHERE username='{5}'",
                                          user.fName, user.lName, user.Role, user.Sdt, user.Ngaysinh, user.Username, user.Password);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            cmd.Parameters.AddWithValue("@image", bytes);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cập nhật người dùng thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật người dùng thất bại");
            }

            conn.Close();
        }

        public void DeleteUser(string username)
        {
            string sqlStr = string.Format("DELETE FROM [User] WHERE username = {0}", username);
            dBconnection.Thucthi(sqlStr);
        }

        public byte[] ConvertImageToVarbinary(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
       

    }
}
