using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance 
        {
            get 
            {
                if (instance == null)
                {
                    instance = new HoaDonDAO();
                }
                return instance;
            }
           private set => instance = value;
        }
        private HoaDonDAO() { }

        public int InsertHoaDon( int tongtien,string makh,string maxe,string mahopdong)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery($" exec dbo.usp_InsertBill '{DateTime.Now}' ,'{tongtien}' ,'{makh}' ,'{maxe}','{mahopdong}'");
        }
        public int removeHoaDonByMaHopDong(string mahopdong)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery("exec dbo.usp_RemoveHoaDonByMaHD @mahopdong",new object[] { mahopdong});
        }
        public int removeHoaDonByMaHopDongForRemoveAll(string mahopdong)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery("exec dbo.usp_RemoveHoaDonByMaHopDongForRemoveAll @mahd", new object[] { mahopdong });
        }
        public int RemoveHoaDonByMaKH(string makh)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery($"exec dbo.usp_RemoveHoaDonByMaKH '{makh}'");
        }
        public int UpdateHoaDon(int tongtien,string maxe,string makhachang,string mahopdong)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery($"exec dbo.usp_UpdateHoaDon '{DateTime.Now}' ,'{tongtien}' ,'{maxe}' ,'{mahopdong}' , '{makhachang}'");
        }
        public List<DTO.HoaDon> GetListHoaDonByDay(DateTime ngaybatdau,DateTime ngayketthuc)
        {
            DataTable hoadon = DAO.DataProvider.Instance.ExecuteQuery($"exec dbo.usp_GetListHoaDonByDay '{ngaybatdau}' ,'{ngayketthuc}'");
            List<DTO.HoaDon> listhoadon = new List<DTO.HoaDon>();
            foreach (DataRow item in hoadon.Rows)
            {
                DTO.HoaDon itemhoadon = new DTO.HoaDon(item);
                listhoadon.Add(itemhoadon);
            }
            return listhoadon;
        }
    }
}
