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
    public partial class fOto : Form
    {
        public fOto()
        {
            InitializeComponent();
        }
        void Reset()
        {
            txt_biensoxe.Text = "";
            txt_hangxe.Text = "";
            txt_maxe.Text = "";
            txt_sochongoi.Text = "";
            txt_tenxe.Text = "";
        }

        void SetEnable(bool checktrue, bool checkfalse, bool check)
        {
            btn_editoto.Enabled = checktrue;
            btn_updateoto.Enabled = checkfalse;
            btn_addoto.Enabled = check;
            btn_removeoto.Enabled = check;
            panel_editOto.Enabled = checkfalse;
            
        }
        void LoadOto()
        {
            listView_oto.Items.Clear();
            List<DTO.Oto> oto = DAO.OtoDAO.Instance.GetListOto();
            foreach (DTO.Oto item in oto)
            {
                string[] s = { item.MaXe, item.TenXe, item.HangXe, item.BienSoXe, item.SoChoNgoi.ToString(), item.TrangThai };
                ListViewItem itemOto = new ListViewItem(s);
                itemOto.Tag = item;
                if (item.TrangThai=="Thuê")
                {
                    itemOto.BackColor = Color.Red;
                }
                listView_oto.Items.Add(itemOto);
            }
        }
        private void fOto_Load(object sender, EventArgs e)
        {
            Reset();
            SetEnable(true, false, true);
            LoadOto();
            rd_trong.Checked = true;
        }

        private void btn_removeoto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_maxe.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn xe");
                return;
            }
            else
            {
                DAO.OtoDAO.Instance.RemoveHopDongAndHoaDonByMaxe(txt_maxe.Text.Trim());
                if (DAO.OtoDAO.Instance.RemoveOto(txt_maxe.Text.Trim())>0)
                {
                    MessageBox.Show("Success");
                    LoadOto();

                }
                else
                {
                    MessageBox.Show("False");
                }
            }
        }

        private void listView_oto_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_oto.FullRowSelect = true;
            if (listView_oto.SelectedItems.Count>0)
            {
                DTO.Oto oto = listView_oto.SelectedItems[0].Tag as DTO.Oto;
                if (oto.TrangThai == "Thuê")
                {
                    return;

                }
                
                
                txt_biensoxe.Text = oto.BienSoXe;
                txt_hangxe.Text = oto.HangXe;
                txt_maxe.Text = oto.MaXe;
                txt_sochongoi.Text = oto.SoChoNgoi.ToString(); ;
                txt_tenxe.Text = oto.TenXe;
                if (oto.TrangThai=="Trống")
                {
                    rd_trong.Checked = true;

                }
                else
                {

                    rd_thue.Checked = true;
                    
                }
            }
        }

        private void btn_addoto_Click(object sender, EventArgs e)
        {
            finsertoto f = new finsertoto();
            f.ShowDialog();
            LoadOto();

        }

        private void btn_updateoto_Click(object sender, EventArgs e)
        {
            int sochongoi=0;
            string trangthai = "Trống";
            if (string.IsNullOrEmpty(txt_maxe.Text.Trim()))
            {
                MessageBox.Show("Bạn Chưa chọn xe");
                return;

            }
            if (!int.TryParse(txt_sochongoi.Text.Trim(),out sochongoi))
            {
                MessageBox.Show("Số chỗ ngồi Không hợp lệ");
                return;
            }
            if (string.IsNullOrEmpty(txt_maxe.Text.Trim())||string.IsNullOrEmpty(txt_sochongoi.Text.Trim())||string.IsNullOrEmpty(txt_tenxe.Text.Trim())||string.IsNullOrEmpty(txt_biensoxe.Text.Trim())||string.IsNullOrEmpty(txt_hangxe.Text.Trim()))
            {
                MessageBox.Show("Không được để trống thông tin");

                return;
            }
            if (rd_thue.Checked)
            {
                trangthai = @"Thuê";
            }
            else
            {
                trangthai = @"Trống";

            }
            if (DAO.DataProvider.Instance.ExecuteNonQuery($"exec usp_UpdateOto '{txt_maxe.Text.Trim()}' ,N'{txt_tenxe.Text.Trim()}' ,N'{txt_hangxe.Text.Trim()}' ,'{txt_biensoxe.Text.Trim()}' ,N'{trangthai}','{sochongoi}'")>0)
            {
                MessageBox.Show("Success");
                SetEnable(true, false, true);
                btn_editoto.Text = "Sửa";
                LoadOto();

            }
            else
            {
                MessageBox.Show("False");

            }






        }

        private void btn_editoto_Click(object sender, EventArgs e)
        {
            if (btn_editoto.Text=="Sửa")
            {
                btn_editoto.Text = "Hủy";
                SetEnable(true, true, false);
            }
            else
            {
                btn_editoto.Text = "Sửa";
            SetEnable(true, false, true);


            }
        }
        void loadOto(string tenxe)
        {
            listView_oto.Items.Clear();
            List<DTO.Oto> listOto = DAO.OtoDAO.Instance.FindOtoByTenXe(tenxe);
            foreach (var item in listOto)
            {
                string[] s = { item.MaXe, item.TenXe, item.HangXe, item.BienSoXe, item.SoChoNgoi.ToString(), item.TrangThai };
                ListViewItem oto = new ListViewItem(s);
                oto.Tag = item;
                if (item.TrangThai=="Thuê")
                {
                    oto.BackColor = Color.Red;
                }
                listView_oto.Items.Add(oto);
            }
        }
        private void txt_findoto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_findoto.Text.Trim()))
            {
                LoadOto();
            }
            else
            {
                loadOto(txt_findoto.Text.Trim());
            }
        }
    }
}
