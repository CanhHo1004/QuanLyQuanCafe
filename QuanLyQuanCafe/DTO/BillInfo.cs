using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int drinkID, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.DrinkID = drinkID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];           ///check CSDL theo nguyên tắc id trước, đúng tên trong CSDL
            this.BillID = (int)row["idHoaDon"];
            this.DrinkID = (int)row["idThucUong"];
            this.Count = (int)row["count"];
        }

        private int count;
        private int drinkID;
        private int billID;
        private int iD;

        public int ID {
            get { return iD; }
            set { iD = value; }
        }

        public int BillID {
            get { return billID; }
            set { billID = value; }
        }

        public int DrinkID {
            get { return drinkID; }
            set { drinkID = value; }
        }

        public int Count {
            get { return count; }
            set { count = value; }
        }
    }
}
