using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Table
    {
        public Table(int id, string ten, string trangThai)
        {
            this.ID = id;
            this.Ten = ten;
            this.TrangThai = trangThai;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Ten = row["ten"].ToString();
            this.TrangThai = row["trangthai"].ToString();
        }

        private string trangThai;
        private string ten;
        private int iD;

        public int ID {
            get {return iD; }
            set { iD = value; } 
        }

        public string Ten {
            get { return ten; }
            set { ten = value; } 
        }

        public string TrangThai {
            get { return trangThai; }
            set { trangThai = value; }
        }
    }
}
