﻿using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance {
            get { if(instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; } 
        }

        private BillDAO() { }


        ///Lấy Id trong Hóa đơn
        ///Thành công -> bill ID
        ///Thất bại -> -1

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.HoaDon where idBan = "+ id +" and TrangThai = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

    }
}
