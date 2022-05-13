using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
            loadKhachHangListView();
        }
        void loadKhachHangListView()
        {
            List<DTO.KhachHang> listKH = DAO.KhachHangDAO.Instance.GetListKhachHang();
            
            foreach (var item in listKH)
            {
                string[] obItemForListview = {item.MaKH, item.TenKH,item.SCMND,item.SDT,item.DiaChi,item.GioiTinh };
                ListViewItem itemKhachHang = new ListViewItem(obItemForListview);
                itemKhachHang.Tag = item;
                listView_khachhang.Items.Add(itemKhachHang);
            }
            
        }
    }
}
