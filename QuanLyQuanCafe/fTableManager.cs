using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fTableManager : Form
    {
        private object txbTotalPrice;
        private object totalPrice;

        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
        }

        
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach(Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight};
                btn.Text = item.Ten + Environment.NewLine + item.TrangThai;
                btn.Click += Btn_Click;
                btn.Tag = item;

                switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.Aquamarine;
                        break;
                    default:
                        btn.BackColor = Color.LightYellow;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsvHoaDon.Items.Clear();
            List<DTO.Menu> listBillInfon = MenuDAO.Instance.GetListMenuByTable(id);

            float totalPrice = 0;
            foreach(DTO.Menu item in listBillInfon)
            {
                ListViewItem lsvItem = new ListViewItem(item.DrinkName.ToString());
                lsvItem.SubItems.Add((item.Count.ToString()));
                lsvItem.SubItems.Add((item.Price.ToString()));
                lsvItem.SubItems.Add((item.TotalPrice.ToString()));
                totalPrice += item.TotalPrice;
                lsvHoaDon.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");     ///set tiền về vnđ
            txbToTalPrice.Text = totalPrice.ToString("c", culture);
        }


        #region Event
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            ShowBill(tableID);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile f = new AccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
        #endregion

        private void txbToTalPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
