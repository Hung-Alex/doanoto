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
            loadComboboxEditQlKH();
            loadHinhThuc();
            loadComboboxTenXe();
            loadHopDong();
            SetEnable(false, true,true);


        }

        #region Events
        private void button1_qledithd_Click(object sender, EventArgs e)
        {
            Button getText = sender as Button;
            if (getText.Text=="Chỉnh Sửa")
            {
                getText.Text = "Hủy";
                SetEnable(true, false,false);
            }
            else
            {
                getText.Text = "Chỉnh Sửa";
                SetEnable(false, true, true);
                listView1_qlhopdong_SelectedIndexChanged(listView1_qlhopdong,null);
            }
            

        }
        void SetEnable(bool checkfalse,bool checktrue,bool checkthanhtoan)
        {
            panel4_qlturnonedithd.Enabled = checkfalse;
            button1_qlcapnhathd.Enabled = checkfalse;
            button1_qlThanhtoanHd.Enabled = checktrue;
            button_qlremovehopdong.Enabled = checkthanhtoan;

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

            
            if (textBox1_qlmahopdong.Text==null|| textBox1_qlmahopdong.Text == "")
            {
                MessageBox.Show("vui lòng chọn hợp đồng để thanh toán");
                return;
            }
            if (DAO.HoaDonDAO.Instance.InsertHoaDon(int.Parse(textBox4_qltienthuehd.Text),textBox1_qlmakh.Text,textBox2_qlmaxeotohd.Text,textBox1_qlmahopdong.Text)>0)
            {
                MessageBox.Show("Success");
                DAO.HopDongDAO.Instance.updateHopDong(textBox1_qlmahopdong.Text);
                DAO.OtoDAO.Instance.updateOto(textBox2_qlmaxeotohd.Text);
                loadHopDong();

            }
            else
            {
                MessageBox.Show("false");

            }
        }
        private void comboBox1_qlcategoryhdkh_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox listKhachhang = sender as ComboBox;
            if (listKhachhang.SelectedItem!=null)
            {
                DTO.KhachHang khachHang = listKhachhang.SelectedValue as DTO.KhachHang;
                textBox1_qlmakh.Text = khachHang.MaKH;
            }
          
        }
        #endregion

        #region method
        
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
           List<string> listHinhThuc =  new List<string>() { "Chưa Thanh Toán","Thanh Toán"};
            combox_qlHinhthucHd.DataSource = listHinhThuc;
        }
        public void loadHopDong()
        {
            listView1_qlhopdong.Items.Clear();
            List<DTO.HopDong> hopdongs = DAO.HopDongDAO.Instance.getListHopDong();
            foreach (DTO.HopDong item in hopdongs)
            {
                string[] s = { item.MaHD, item.MaKH, item.TenKhachHang, item.MaXe, item.TenXe,item.TienThue.ToString(), string.Format("{0:dd/MM/yyyy HH:mm:ss}", item.NgayThue), string.Format("{0:dd/MM/yyyy HH:mm:ss}", item.NgayTra),item.TinhTrang };
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
                string[] s = { item.MaHD, item.MaKH, item.TenKhachHang, item.MaXe, item.TenXe,item.TienThue.ToString(), string.Format("{0:dd/MM/yyyy HH:mm:ss}",item.NgayThue), string.Format("{0:dd/MM/yyyy HH:mm:ss}", item.NgayTra), item.TinhTrang };
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
        void loadComboboxEditQlKH()
        {
            comboBox1_qlcategoryhdkh.DataSource = DAO.KhachHangDAO.Instance.GetListKhachHang();
            comboBox1_qlcategoryhdkh.DisplayMember = "TenKH";
        }
        void loadComboboxEditQlOto()
        {
            comboBox2_qlcategoryxehd.DataSource = DAO.OtoDAO.Instance.loadOto(@"Trống");
            comboBox2_qlcategoryxehd.DisplayMember = "TenXe";
;        }
        void loadComboboxHinhThucEditQl()
        {
            List<string> listHinhThuc = new List<string>() { "Chưa Thanh Toán", "Thanh Toán" };
            comboBox_qlhinhthucHdfEdit.DataSource = listHinhThuc;
        }










        #endregion

        private void comboBox2_qlcategoryxehd_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox listOto = sender as ComboBox;
            DTO.Oto oto = listOto.SelectedValue as DTO.Oto;
            textBox2_qlmaxeotohd.Text = oto.MaXe;
        }

        private void button_qlremovehopdong_Click(object sender, EventArgs e)
        {
            string mahd = textBox1_qlmahopdong.Text;
            DAO.HoaDonDAO.Instance.removeHoaDonByMaHopDongForRemoveAll(mahd);

            if (DAO.HopDongDAO.Instance.removeHopDong(mahd.Trim())>0) 
            {
                MessageBox.Show("success");
                loadHopDong();
            }
            else
            {
                MessageBox.Show("falied");

            }
        }

        private void button1_qlcapnhathd_Click(object sender, EventArgs e)
        {
            int price;
            if (int.TryParse(textBox4_qltienthuehd.Text,out price)==false)
            {
                MessageBox.Show("Kiểm tra lại tiền thuê không có chữ hoặc ký tự");
                return;
            }
            if ( DAO.HopDongDAO.Instance.updateHopDong(textBox1_qlmahopdong.Text,price,dateTimePicker1_qldaystarthd.Value,dateTimePicker2_qldayendhd.Value, comboBox_qlhinhthucHdfEdit.Text, textBox2_qlmaxeotohd.Text,textBox1_qlmakh.Text)>0)
            {
                MessageBox.Show("update success");
                loadHopDong();
                button1_qledithd.Text = "Chỉnh Sửa";
                SetEnable(false, true,true);
                if (comboBox_qlhinhthucHdfEdit.Text=="Chưa Thanh Toán")
                {
                    DAO.HoaDonDAO.Instance.removeHoaDonByMaHopDong(textBox1_qlmahopdong.Text);
                }
                else
                {
                    try
                    {
                        DAO.HoaDonDAO.Instance.InsertHoaDon(int.Parse(textBox4_qltienthuehd.Text), textBox1_qlmakh.Text, textBox2_qlmaxeotohd.Text, textBox1_qlmahopdong.Text);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("false");

            }


        }

        private void comboBox1_qlcategoryhdkh_Click(object sender, EventArgs e)
        {
            loadComboboxEditQlKH();
           
            
        }

        private void comboBox2_qlcategoryxehd_Click(object sender, EventArgs e)
        {
            loadComboboxEditQlOto();
        }

        private void comboBox_qlhinhthucHdfEdit_Click(object sender, EventArgs e)
        {
            loadComboboxHinhThucEditQl();
        }
    }

}
