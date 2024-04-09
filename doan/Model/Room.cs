using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan.Model
{
    internal class Room
    {
        public int Id;
        public int Idhotel;
        public int SoLuongToiDa;
        public int Dientich;
        public string GiaTien;
        public string Type;
        public string Discription;
        public bool test = true;

        public Room() { }
        public Room(int Id, int Idhotel, int SoLuongToiDa, int Dientich, string GiaTien, string Type, string Discription, bool test)
        {
            this.Id = Id;
            this.Idhotel = Idhotel;
            this.SoLuongToiDa = SoLuongToiDa;
            this.Dientich = Dientich;
            this.Type = Type;
            this.GiaTien = GiaTien;
            this.Discription = Discription;
            this.test = test;
        }

    }


}
