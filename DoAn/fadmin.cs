using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class fadmin : Form
    {
        public fadmin()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            
            string query = @"dbo.usp_HopDong @mahd , @makh";
            dataGridView_customer.DataSource = DAO.DataProvider.Instance.ExecuteQuery(query,new object []{"HD001" ,"KH001"});
            
        }
    }
}
