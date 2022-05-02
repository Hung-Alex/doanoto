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
            comboBox1_HopDong.DataSource = DAO.KhachHangDAO.Instance.GetListKhacHang();
            comboBox1_HopDong.DisplayMember = "TenKH";
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
    }
}
