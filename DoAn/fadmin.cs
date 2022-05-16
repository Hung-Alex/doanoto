using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class fadmin : Form
    {
        public fadmin()
        {
            InitializeComponent();
            
            var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            LoadHoaDon(firstDayOfMonth, lastDayOfMonth);
        }

        void LoadHoaDon(DateTime start,DateTime end)
        {
            lsvHoaDon.Items.Clear();
            decimal tien = 0;
            List<DTO.HoaDon> hoadon =DAO.HoaDonDAO.Instance.GetListHoaDonByDay(start,end);
            foreach (DTO.HoaDon item in hoadon)
            {
                string[] s = {item.Mahoadon,item.Mahopdong,item.MaKhachHang,item.TenKhachHang,item.SCMND,item.MaXe,item.TenXe,item.HangXe,item.NgayLapHoaDon.ToString(),item.Tienthue.ToString() };
                ListViewItem itemhoadon = new ListViewItem(s);
                itemhoadon.Tag = item;
                tien += item.Tienthue;
                lsvHoaDon.Items.Add(itemhoadon);
            }
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string tongtien = String.Format(info, "{0:c}", tien);
            txtTongTien.Text = tongtien;
        }
        private void btn_view_bill_Click(object sender, EventArgs e)
        {
            lsvHoaDon.Items.Clear();
            LoadHoaDon(dateTimePickerStart.Value, dateTimePickerEnd.Value);
        }
    }
}
