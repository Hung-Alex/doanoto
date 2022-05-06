using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhachHangDAO();
                }
                return DAO.KhachHangDAO.instance;
            }
            private set { DAO.KhachHangDAO.instance = value; }
        }
        private KhachHangDAO() { }

        public List<DTO.KhachHang> GetListKhachHang()
        {
            List<DTO.KhachHang> khachHangs = new List<DTO.KhachHang>();
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery("select * from KHACHHANG");
            foreach (DataRow item in data.Rows)
            {
                DTO.KhachHang khacHangItem = new DTO.KhachHang(item);
                khachHangs.Add(khacHangItem);
            }
            return khachHangs;
        }

    }
}
