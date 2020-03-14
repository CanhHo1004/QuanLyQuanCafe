using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Menu
    {
        public Menu(string drinkName, int count, float price, float totalPirce = 0)
        {
            this.DrinkName = drinkName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPirce;
        }

        public Menu(DataRow row)
        {
            this.DrinkName = row["ten"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["gia"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["tongtien"].ToString());
        }

        private float totalPrice;
        private float price;
        private int count;
        private string drinkName;

        public string DrinkName {
            get { return drinkName; }
            set { drinkName = value; }
        }

        public int Count {
            get { return count; }
            set { count = value; }
        }

        public float Price {
            get { return price; }
            set { price = value; }
        }

        public float TotalPrice {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    }
}
