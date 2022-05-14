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
            SetEnable(true, false, true);
            Reset();
            loadKhachHangListView();
        }
        void loadKhachHangListView()
        {
            listView_khachhang.Items.Clear();
            List<DTO.KhachHang> listKH = DAO.KhachHangDAO.Instance.GetListKhachHang();
            
            foreach (var item in listKH)
            {
                string[] obItemForListview = {item.MaKH, item.TenKH,item.SCMND,item.SDT,item.DiaChi,item.GioiTinh };
                ListViewItem itemKhachHang = new ListViewItem(obItemForListview);
                itemKhachHang.Tag = item;
                listView_khachhang.Items.Add(itemKhachHang);
            }
        }
        void Reset()
        {
            textBox_MaKhachHang.Text = "";
            txt_tenkhachhang.Text = "";
            txt_sdt.Text = "";
            txt_scmnd.Text = "";
            combobox_gioitinh.Text = "";
            txt_address.Text = "";

        }
        void SetEnable(bool checktrue,bool checkfalse, bool check)
        {
            panel_editkhachhang.Enabled = checkfalse;
            button_capnhatkh.Enabled = checkfalse;
            btn_addCustomer.Enabled = check;
            btn_removeCustomer.Enabled = check;
        }

        private void listView_khachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_khachhang.SelectedItems.Count>0)
            {
                DTO.KhachHang itemkh = listView_khachhang.SelectedItems[0].Tag as DTO.KhachHang;
                textBox_MaKhachHang.Text = itemkh.MaKH;
                txt_tenkhachhang.Text = itemkh.TenKH;
                txt_sdt.Text = itemkh.SDT;
                txt_scmnd.Text = itemkh.SCMND;
                combobox_gioitinh.Text = itemkh.GioiTinh;
                txt_address.Text = itemkh.DiaChi;
            }
        }

        #region events
        private void btn_editCustomer_Click(object sender, EventArgs e)
        {
            SetEnable(true,true,false);
            if (btn_editCustomer.Text=="Sửa")
            {
                SetEnable(true, true, false);
                btn_editCustomer.Text = "Hủy";
            }
            else
            {
                btn_editCustomer.Text = "Sửa";
                SetEnable(true, false, true);

            }
        }

        #endregion

        private void button_capnhatkh_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_MaKhachHang.Text))
            {
                MessageBox.Show("Vui lòng Chọn Khách Hàng bạn muốn chỉnh Sửa");
                return;
            }
            if (string.IsNullOrEmpty(txt_tenkhachhang.Text.Trim()) || string.IsNullOrEmpty(txt_sdt.Text.Trim()) || string.IsNullOrEmpty(txt_scmnd.Text.Trim()) || string.IsNullOrEmpty(txt_address.Text.Trim()))
            {
                MessageBox.Show("Không Được để  trống Thông Tin khách hàng");
                return;
            }
            if (DAO.KhachHangDAO.Instance.UpdateKhachHang(textBox_MaKhachHang.Text, txt_tenkhachhang.Text, txt_scmnd.Text, txt_sdt.Text, txt_address.Text, combobox_gioitinh.Text)>0) 
            {
                MessageBox.Show("Success");
                btn_editCustomer.Text = "Sửa";
                SetEnable(true, false, true);
                loadKhachHangListView();
            }
            else
            {
                MessageBox.Show("False");

            }
        }

        private void btn_removeCustomer_Click(object sender, EventArgs e)
        {
            string makh = textBox_MaKhachHang.Text;
            if (string.IsNullOrWhiteSpace(makh))
            {
                MessageBox.Show("Vui Lòng Chọn Thông Tin Trong Bảng để Xóa ");
            }
            else
            {
                int counthopdong =(int)DAO.DataProvider.Instance.ExecuteScalar($"select count(*) from HOPDONG where MaKH='{makh}'");
                int counthoadon = (int)DAO.DataProvider.Instance.ExecuteScalar($"select COUNT(*) from	HOADON where MaKH='{makh}'");
                if (counthopdong>0||counthoadon>0)
                {
                    DAO.HoaDonDAO.Instance.RemoveHoaDonByMaKH(makh);
                    DAO.HopDongDAO.Instance.RemoveHopDongByMaKH(makh);
                   
                }
                
                    if (DAO.KhachHangDAO.Instance.RemoveKhachHang(makh)>0)
                    {
                        MessageBox.Show("Success");
                        loadKhachHangListView();
                    Reset();

                }
                    else
                    {
                        MessageBox.Show("False");

                    }
                

            }
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            fInsertKH f = new fInsertKH();
            f.ShowDialog();
        }

        private void combobox_gioitinh_Click(object sender, EventArgs e)
        {
            List<string> giotinh = new List<string>() { "Nam", "Nữ" };
            combobox_gioitinh.DataSource = giotinh;
        }
        public void LoadKhacHangByTimKiem(string tenkh)
        {
            listView_khachhang.Items.Clear();
            List<DTO.KhachHang> listKH = DAO.KhachHangDAO.Instance.FindNameKH(tenkh.Trim());

            foreach (var item in listKH)
            {
                string[] obItemForListview = { item.MaKH, item.TenKH, item.SCMND, item.SDT, item.DiaChi, item.GioiTinh };
                ListViewItem itemKhachHang = new ListViewItem(obItemForListview);
                itemKhachHang.Tag = item;
                listView_khachhang.Items.Add(itemKhachHang);
            }
        }

        private void txt_inputcustomer_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_inputcustomer.Text.Trim()))
            {
                loadKhachHangListView();
            }
            else
            {
                LoadKhacHangByTimKiem(txt_inputcustomer.Text.Trim());

            }

        }
    }
}
