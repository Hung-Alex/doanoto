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
    public partial class tablemanagerment : Form
    {
        public tablemanagerment()
        {
            InitializeComponent();
            loadOptionsSochoNgoi();
            loadKhacHang();
            loadOto();

        }


        #region Method
        void loadOto()
        {
            flowLayoutPanel_HopDOng.Controls.Clear();
            List<DTO.Oto> otolist = DAO.OtoDAO.Instance.loadOto();
            foreach (DTO.Oto item in otolist)
            {
                Button oto = new Button() {Width=DAO.OtoDAO.OtoWidth,Height=DAO.OtoDAO.OtoHeight };
                oto.Text =  item.TenXe + Environment.NewLine + item.HangXe + Environment.NewLine +
                    item.SoChoNgoi.ToString() + Environment.NewLine + item.TrangThai;
                oto.Click += Oto_Click;
                oto.Tag = item;
                switch (item.TrangThai)
                {
                    case "Trống":
                             {
                            oto.BackColor = Color.Aqua;
                            oto.Enabled = true;
                            break;
                              }
                    default:
                        oto.BackColor = Color.Red;
                        oto.Enabled = false;

                        break;
                }



                flowLayoutPanel_HopDOng.Controls.Add(oto);
            }

        }
        void loadOto(int sochongoi)
        {
            flowLayoutPanel_HopDOng.Controls.Clear();
            List<DTO.Oto> otolist = DAO.OtoDAO.Instance.loadOto(sochongoi);
            foreach (DTO.Oto item in otolist)
            {
                Button oto = new Button() { Width = DAO.OtoDAO.OtoWidth, Height = DAO.OtoDAO.OtoHeight };
                oto.Text = item.TenXe + Environment.NewLine + item.HangXe + Environment.NewLine +
                    item.SoChoNgoi.ToString() + Environment.NewLine + item.TrangThai;
                oto.Click += Oto_Click;
                oto.Tag = item;
                switch (item.TrangThai)
                {
                    case "Trống":
                        {
                            oto.BackColor = Color.Aqua;
                            oto.Enabled = true;
                            break;
                        }
                    default:
                        oto.BackColor = Color.Red;
                        oto.Enabled = false;

                        break;
                }



                flowLayoutPanel_HopDOng.Controls.Add(oto);
            }

        }
        
            
        void loadKhacHang()
        {
            comboBox1_HopDong_Khachang.DataSource = DAO.KhachHangDAO.Instance.GetListKhachHang();
            comboBox1_HopDong_Khachang.DisplayMember = "TenKH";
        }
        

        public void ShowOto(string maxe)
        {
            listView_HopDong.Items.Clear();
            DTO.Oto Oto = DAO.OtoDAO.Instance.GetShowListViewHopDong(maxe);
            ListViewItem otoItem = new ListViewItem(Oto.MaXe.ToString());
            otoItem.SubItems.Add(Oto.TenXe);
            otoItem.SubItems.Add(Oto.HangXe);
            otoItem.SubItems.Add(Oto.BienSoXe);
            otoItem.SubItems.Add(Oto.SoChoNgoi.ToString());
            otoItem.Tag = Oto;
            listView_HopDong.Items.Add(otoItem);
        }
        void  loadOptionsSochoNgoi()
        {
            comboBox_categorybySochoNgoi.DataSource = DAO.CategoryDAO.Instance.getListSoChoNgoiOto();
        }
        #endregion
        #region Events
        private void Oto_Click(object sender, EventArgs e)
        {
            Button result = sender as Button;
            string maxe = (result.Tag as DTO.Oto).MaXe;
            ShowOto(maxe);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile result = new fAccountProfile();
            result.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fadmin result = new fadmin();
            result.ShowDialog();

        }
        private void comboBox1_HopDong_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox result = sender as ComboBox;
            if(result.SelectedIndex==-1)
            {
                return;
            }
            textBox1_scmnd_hopdong.Text = (result.SelectedValue as DTO.KhachHang).SCMND; 
        }
        private void comboBox_categorybySochoNgoi_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox result = sender as ComboBox;
            loadOto((int)result.SelectedValue);
        }



        #endregion

        private void button_hopdong_xemtatca_Click(object sender, EventArgs e)
        {
            loadOto();
        }

        private void Btn_AddHD_Click(object sender, EventArgs e)
        {


            listView_HopDong.FullRowSelect = true;
            DateTime ngayThueHopDong = dateTimePicker_NgayThueHD.Value;
            DateTime ngayTraHopDong = dateTimePicker_NgayTraHD.Value;
            MessageBox.Show(ngayThueHopDong.ToString());
            int tienthue ;
            if (int.TryParse(textBox_TienThueHopDong.Text.ToString(),out tienthue)==false)
            {
                MessageBox.Show("vui lòng nhập đúng tiền thuê không có chữ hoặc ký tự");
                return;
            }
            string makh = (comboBox1_HopDong_Khachang.SelectedValue as DTO.KhachHang).MaKH;
            string maxe = "";
            foreach (ListViewItem item in listView_HopDong.Items)
            {
                maxe += (item.Tag as DTO.Oto).MaXe;
            }
            if (maxe=="")
            {
                MessageBox.Show("Vui lòng chọn xe muốn thuê");
                return;
            }
            if (DAO.HopDongDAO.Instance.insertHopDong(tienthue, ngayThueHopDong, ngayTraHopDong, maxe, makh)>0)
            {
                MessageBox.Show("succsess");

            }
            else
            {
                MessageBox.Show("false");

            }
            



        }

        private void listView_HopDong_MouseClick(object sender, MouseEventArgs e)
        {
            listView_HopDong.FullRowSelect = true;
            string name = listView_HopDong.SelectedItems[0].Text;
            MessageBox.Show(name);
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fhopdong nForm = new fhopdong();
            nForm.ShowDialog();
        }
    }
}
