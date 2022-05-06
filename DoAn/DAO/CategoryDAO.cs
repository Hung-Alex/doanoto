using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance 
        {
            get
            {
                if (instance==null)
                {
                    instance = new CategoryDAO();
                }
                return instance
                ; 
            }
            private set {instance=value; }
        }
        private CategoryDAO() { }
        public List<int> getListSoChoNgoiOto()
        {
            List<int> result = new List<int>();
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery("dbo.usp_GetSoChoNgoiOto");
            foreach (DataRow item in data.Rows)
            {
                result.Add((int)item["SoChoNgoi"]);
            }
            return result;
        }
        public List<string> getListTenKhachHang()
        {
            List<string> listKH = new List<string>();
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery("select TenKhachHang from KHACHHANG");
            foreach (DataRow item in data.Rows)
            {
                listKH.Add(item["TenKhachHang"].ToString());
            }
            return listKH;
        }
        public List<string> getListTenXe()
        {
            List<string> listTenXe = new List<string>();
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery(" select TenXe from OTO");
            foreach (DataRow item in data.Rows)
            {
                listTenXe.Add(item["TenXe"].ToString());
            }
            return listTenXe;
        }

    }
}
