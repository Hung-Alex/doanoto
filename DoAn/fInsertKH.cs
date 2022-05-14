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
    public partial class fInsertKH : Form
    {
        public fInsertKH()
        {
            InitializeComponent();
        }

        private void fInsertKH_Load(object sender, EventArgs e)
        {
            List<string> giotinh = new List<string>() { "Nam", "Nữ" };
            combobox_gioitinh.DataSource = giotinh;
        }

        private void btn__insertKh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenkhachhang.Text)||string.IsNullOrEmpty(txt_sdt.Text)||string.IsNullOrEmpty(txt_scmnd.Text)||string.IsNullOrEmpty(txt_address.Text))
            {
                MessageBox.Show("Không Được để  trống Thông Tin khách hàng");
                return;
            }
            
                if (DAO.KhachHangDAO.Instance.InsertKhachHang(txt_tenkhachhang.Text,txt_scmnd.Text,txt_sdt.Text,txt_address.Text,combobox_gioitinh.Text)>0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("False");

                }
            
        }
    }
}
