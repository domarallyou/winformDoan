using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Imaging;
using System.Xml.Linq;

namespace doan.Model
{
    internal class User
    {
        public int Id;
        public string fName;
        public string lName;
        public string Username;
        public MemoryStream Image;
        public string Ngaysinh;
        public string Sdt;
        public string Password;
        public bool Role = true;
        public bool test = true;


        public User() { }

        public User(int id, string fName, string lName, string username, MemoryStream image, string ngaysinh, string sdt, string password, bool role, bool test)
        {
            Id = id;
            this.fName = fName;
            this.lName = lName;
            Username = username;
            Image = image;
            Ngaysinh = ngaysinh;
            Sdt = sdt;
            Password = password;
            Role = role;
            this.test = test;
        }
    }

}
