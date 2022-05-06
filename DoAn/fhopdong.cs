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

namespace DoAn
{
    public partial class fhopdong : Form
    {
        public fhopdong()
        {
            InitializeComponent();
            loadComboboxTenKH();
            loadHinhThuc();
            loadComboboxTenXe();
            loadHopDong();
            setEnable(false);
        }

        #region Events
        private void button1_qledithd_Click(object sender, EventArgs e)
        {
            setEnable(true);

        }
        private void comboBox1_qlcategorykhachhanghd_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox tenkhachhang = sender as ComboBox;
            if (tenkhachhang.SelectedIndex==-1||tenkhachhang.SelectedItem==null)
            {
                return;
            }
            
            loadHopDongByNameKhachHang(tenkhachhang.SelectedValue.ToString());


        }
        private void comboBox1_qlcategorytenxe_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox tenXe = sender as ComboBox;
            if (tenXe.SelectedIndex == -1 || tenXe.SelectedItem == null)
            {
                return;
            }

            loadHopDongByNameOto(tenXe.SelectedValue.ToString());
        }
        private void combox_qlHinhthucHd_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox hinhThuc = sender as ComboBox;
            if (hinhThuc.SelectedIndex == -1 || hinhThuc.SelectedItem == null)
            {
                return;
            }

            loadHopDongByHinhThuc(hinhThuc.SelectedValue.ToString());
        }
        private void listView1_qlhopdong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1_qlhopdong.SelectedItems.Count > 0)
            {
                DTO.HopDong item = listView1_qlhopdong.SelectedItems[0].Tag as DTO.HopDong;
                textBox1_qlmahopdong.Text = item.MaHD;
                textBox1_qlmakh.Text = item.MaKH;
                comboBox1_qlcategoryhdkh.Text = item.TenKhachHang;
                textBox2_qlmaxeotohd.Text = item.MaXe;
                comboBox2_qlcategoryxehd.Text = item.TenXe;
                textBox4_qltienthuehd.Text = item.TienThue.ToString();
                dateTimePicker1_qldaystarthd.Value = item.NgayThue;
                dateTimePicker2_qldayendhd.Value = item.NgayTra;
                comboBox_qlhinhthucHdfEdit.Text = item.TinhTrang;
            }

        }

        private void button1_qlThanhtoanHd_Click(object sender, EventArgs e)
        {
            int tienthue;
            if (int.TryParse(textBox4_qltienthuehd.Text,out tienthue)==false)
            {
                MessageBox.Show("Tiền thuê vui lòng nhập số");
                return;
            }
            if (DAO.HoaDonDAO.Instance.InsertHoaDon(tienthue,textBox1_qlmakh.Text,textBox2_qlmaxeotohd.Text)>0)
            {
                MessageBox.Show("Success");

            }
            else
            {
                MessageBox.Show("false");

            }
        }
        #endregion

        #region method
        void setEnable(bool check)
        {
            panel4_qlturnonedithd.Enabled = check;
        }
        public void loadComboboxTenKH()
        {
            comboBox1_qlcategorykhachhanghd.DataSource = DAO.CategoryDAO.Instance.getListTenKhachHang();
            
        }
        public void loadComboboxTenXe()
        {
            comboBox1_qlcategorytenxe.DataSource = DAO.CategoryDAO.Instance.getListTenXe();
        }
        public void loadHinhThuc()
        {
           List<string> listHinhThuc =  new List<string>() { @"Chưa Thanh Toán",@"Thanh Toán"};
            combox_qlHinhthucHd.DataSource = listHinhThuc;
        }
        public void loadHopDong()
        {
            listView1_qlhopdong.Items.Clear();
            List<DTO.HopDong> hopdongs = DAO.HopDongDAO.Instance.getListHopDong();
            foreach (DTO.HopDong item in hopdongs)
            {
                string[] s = { item.MaHD, item.MaKH, item.TenKhachHang, item.MaXe, item.TenXe, string.Format("{0:dd/MM/yyyy HH:mm:ss}", item.NgayThue), string.Format("{0:dd/MM/yyyy HH:mm:ss}", item.NgayTra), item.NgayTra.ToString(),item.TinhTrang };
                ListViewItem hopdongitem = new ListViewItem(s);
                hopdongitem.Tag = item;
                listView1_qlhopdong.Items.Add(hopdongitem);
            }
        }
        public void loadHopDongByNameKhachHang(string tenkhachhang)
        {
            listView1_qlhopdong.Items.Clear();
            List<DTO.HopDong> hopdongs = DAO.HopDongDAO.Instance.getListHopDongByNameKhachHang(tenkhachhang);
            foreach (DTO.HopDong item in hopdongs)
            {
                string[] s = { item.MaHD, item.MaKH, item.TenKhachHang, item.MaXe, item.TenXe, item.TienThue.ToString(), string.Format("{0:dd/MM/yyyy HH:mm:ss}", item.NgayThue), string.Format("{0:dd/MM/yyyy HH:mm:ss}", item.NgayTra), item.TinhTrang };
                ListViewItem hopdongitem = new ListViewItem(s);
                hopdongitem.Tag = item;
                listView1_qlhopdong.Items.Add(hopdongitem);
            }
        }
        public void loadHopDongByNameOto(string tenoto)
        {
            listView1_qlhopdong.Items.Clear();
            List<DTO.HopDong> hopdongs = DAO.HopDongDAO.Instance.getListHopDongByNameOto(tenoto);
            foreach (DTO.HopDong item in hopdongs)
            {
                string[] s = { item.MaHD, item.MaKH, item.TenKhachHang, item.MaXe, item.TenXe,item.TienThue.ToString(), string.Format("{0:dd/MM/yyyy HH:mm:ss}",item.NgayThue), string.Format("{0:dd/MM/yyyy HH:mm:ss}", item.NgayTra), item.NgayTra.ToString(), item.TinhTrang };
                ListViewItem hopdongitem = new ListViewItem(s);
                hopdongitem.Tag = item;
                listView1_qlhopdong.Items.Add(hopdongitem);
            }
        }
        public void loadHopDongByHinhThuc(string hinhthuc)
        {
            listView1_qlhopdong.Items.Clear();
            List<DTO.HopDong> hopdongs = DAO.HopDongDAO.Instance.getListHopDongByHinhThuc(hinhthuc);
            foreach (DTO.HopDong item in hopdongs)
            {
                string[] s = { item.MaHD, item.MaKH, item.TenKhachHang, item.MaXe, item.TenXe, item.TienThue.ToString(), string.Format("{0:dd/MM/yyyy HH:mm:ss}", item.NgayThue), string.Format("{0:dd/MM/yyyy HH:mm:ss}", item.NgayTra), item.TinhTrang };
                ListViewItem hopdongitem = new ListViewItem(s);
                hopdongitem.Tag = item;
                listView1_qlhopdong.Items.Add(hopdongitem);
            }
        }






        #endregion

       

       
    }

}
