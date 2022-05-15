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
            rd_trong.Checked = true;
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
                listView_oto.Items.Add(itemOto);
            }
        }
        private void fOto_Load(object sender, EventArgs e)
        {
            Reset();
            SetEnable(true, false, true);
            LoadOto();
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

            }
        }

        private void listView_oto_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_oto.FullRowSelect = true;
            if (listView_oto.SelectedItems.Count>0)
            {
                DTO.Oto oto = listView_oto.SelectedItems[0].Tag as DTO.Oto ;
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
    }
}
