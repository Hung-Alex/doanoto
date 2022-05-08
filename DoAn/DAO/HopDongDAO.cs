using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    class HopDongDAO
    {
        private static HopDongDAO instance;

        public static HopDongDAO Instance 
        {
            get
            {
                if (instance==null)
                {
                    instance = new HopDongDAO();
                }
                return instance;
            }
            private  set { instance = value; }
        }

        private HopDongDAO() { }

        public int insertHopDong(int tienThue, DateTime ngaythue, DateTime ngaytra, string maxe, string makhachhang)
        {

          return DAO.DataProvider.Instance.ExecuteNonQuery($"exec dbo.usp_InsertHopDong '{tienThue}' ,'{ngaythue}' ,'{ngaytra}' ,'{maxe}' ,'{makhachhang}'");
        }
        public List<DTO.HopDong> getListHopDong()
        {
            List<DTO.HopDong> result = new List<DTO.HopDong>();
            DataTable hopdongs = DAO.DataProvider.Instance.ExecuteQuery(" exec dbo.usp_GetlistHopDongByTinhTrang @tinhtrang",new object[] {"Chưa Thanh Toán" });
            foreach (DataRow item in hopdongs.Rows)
            {
                DTO.HopDong hopdongitem = new DTO.HopDong(item);
                
                result.Add(hopdongitem);
            }
            return result;
        }
        public List<DTO.HopDong> getListHopDongByNameKhachHang(string tenkhachhang)
        {
            List<DTO.HopDong> result = new List<DTO.HopDong>();
            DataTable hopdongs = DAO.DataProvider.Instance.ExecuteQuery(" exec dbo.usp_GetlistHopDongByTenKH @tenKH", new object[] { tenkhachhang });
            foreach (DataRow item in hopdongs.Rows)
            {
                DTO.HopDong hopdongitem = new DTO.HopDong(item);
                result.Add(hopdongitem);
            }
            return result;
        }
        public List<DTO.HopDong> getListHopDongByNameOto(string tenoto)
        {
            List<DTO.HopDong> result = new List<DTO.HopDong>();
            DataTable hopdongs = DAO.DataProvider.Instance.ExecuteQuery("exec dbo.usp_GetlistHopDongByTenXe @tenxe", new object[] { tenoto });
            foreach (DataRow item in hopdongs.Rows)
            {
                DTO.HopDong hopdongitem = new DTO.HopDong(item);
                result.Add(hopdongitem);
            }
            return result;
        }
        public List<DTO.HopDong> getListHopDongByHinhThuc(string hinhthuc)
        {
            List<DTO.HopDong> result = new List<DTO.HopDong>();
            DataTable hopdongs = DAO.DataProvider.Instance.ExecuteQuery(" exec dbo.usp_GetlistHopDongByTinhTrang @tinhtrang", new object[] { hinhthuc });
            foreach (DataRow item in hopdongs.Rows)
            {
                DTO.HopDong hopdongitem = new DTO.HopDong(item);
                result.Add(hopdongitem);
            }
            return result;
        }
        public int updateHopDong(string mahopdong)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery("exec usp_UpdateHopDongByMaHD @mahopdong",new object[] {mahopdong });
        }

        public int removeHopDong(string mahd)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery("exec dbo.usp_RemoveHopDong @mahd",new object[] { mahd});
        }
        public int updateHopDong(string mahopdong,int tienthue,DateTime ngaythue,DateTime ngaytra,string tinhtrang,string maxe,string makh)
        {
            
            return DAO.DataProvider.Instance.ExecuteNonQuery($"exec usp_UpdateHopDong '{mahopdong}' ,'{tienthue}' ,'{ngaythue}' ,'{ngaytra}' ,N'{tinhtrang}' ,'{maxe}' ,'{makh}'");
        }
    }
}
