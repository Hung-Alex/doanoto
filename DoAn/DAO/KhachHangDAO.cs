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
        public int RemoveKhachHang(string makhachhang)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery($" exec dbo.usp_RemoveKhachHangByMaKH '{makhachhang}'");
        }
        public int InsertKhachHang(string tenKh,string scmnd,string sdt,string diachi,string gioitinh)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery($" exec dbo.usp_InsertKhachHang N'{tenKh}' ,'{scmnd}' ,'{sdt}', N'{diachi}' ,N'{gioitinh}' ");
        }
        public int UpdateKhachHang(string makh, string tenkh,string scmnd,string sdt,string diachi,string giotinh)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery($" exec dbo.usp_UpdateKhachHang '{makh}' ,N'{tenkh}' ,'{scmnd}' ,'{sdt}' ,N'{diachi}' ,N'{giotinh}'");
        }
        public List<DTO.KhachHang> FindNameKH(string tenkh)
        {
            List<DTO.KhachHang> khachHangs = new List<DTO.KhachHang>();
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery($"select * from KHACHHANG where TenKhachHang like '%{tenkh.Trim()}%'");
            foreach (DataRow item in data.Rows)
            {
                DTO.KhachHang khacHangItem = new DTO.KhachHang(item);
                khachHangs.Add(khacHangItem);
            }
            return khachHangs;
        }

    }
}
