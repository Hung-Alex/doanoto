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
    public partial class finsertoto : Form
    {
        public finsertoto()
        {
            InitializeComponent();
        }
        void Reset()
        {
            txt_biensoxe.Text = "";
            txt_hangxe.Text = "";
           
            txt_sochongoi.Text = "";
            txt_tenxe.Text = "";
        }


        private void finsertoto_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn__resetoto_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn__insertoto_Click(object sender, EventArgs e)
        {
            int soChoNgoi;

            if (string.IsNullOrEmpty(txt_tenxe.Text)||string.IsNullOrEmpty(txt_biensoxe.Text)||string.IsNullOrEmpty(txt_hangxe.Text)||string.IsNullOrEmpty(txt_sochongoi.Text))
            {
                
                MessageBox.Show("Không Được để trống thông tin");
                
                return;
            }
            if (!int.TryParse(txt_sochongoi.Text.Trim(), out soChoNgoi))
            {
                MessageBox.Show("số chỗ ngồi không hợp lệ");
                return;

            }



            if (DAO.OtoDAO.Instance.InsertOto(txt_tenxe.Text,txt_hangxe.Text,txt_biensoxe.Text,soChoNgoi)>0)
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
