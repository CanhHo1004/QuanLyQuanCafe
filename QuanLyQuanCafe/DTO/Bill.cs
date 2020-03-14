using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckin, DateTime? dateCheckOut, int status)  ///Hàm xây dựng cho Hóa đơn
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill(DataRow row)        ///Lấy từng trường theo đúng tên trong CSDL
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["ngayVao"];

            var dateCheckOutTemp = row["ngayRa"];         ///Kiểm tra xem dateCheckOut có dữ liệu hay không
            if(dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;

            this.Status = (int)row["trangThai"];
        }

        private int status;
        private DateTime? dateCheckOut;
        private DateTime? dateCheckIn;
        private int iD;

        public int ID {
            get { return iD; }
            set { iD = value; }
        }

        public DateTime? DateCheckIn {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }

        public DateTime? DateCheckOut {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        public int Status {
            get { return status; }
            set { status = value; }
        }
    }
}
