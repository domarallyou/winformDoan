using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace doan.Model
{
    internal class Hotel
    {
        public int Id;
        public string NameHotel;
        public string Diachi;
        public int Xeploai;
        public int Feedback;
        public string Score;
        public MemoryStream Image;
        public string Gianen;
        public string Type;
        public string Discription;
        public bool test = true;
        public Hotel() { }

        public Hotel(int id, string nameHotel, string diachi, int xeploai, int feedback, string score, MemoryStream image, string gianen, string type, string Discription, bool test)
        {
            Id = id;
            NameHotel = nameHotel;
            Diachi = diachi;
            Xeploai = xeploai;
            Feedback = feedback;
            Score = score;
            Image = image;
            Gianen = gianen;
            Type = type;
            this.test = test;
            this.Discription = Discription;
        }
    }



}
