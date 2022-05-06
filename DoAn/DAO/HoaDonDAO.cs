using System;
using System.Collections.Generic;
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

        public int InsertHoaDon( int tongtien,string makh,string maxe)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery($" exec dbo.usp_InsertBill '{DateTime.Now}' ,'{tongtien}' ,'{makh}' ,'{maxe}'");
        }
    }
}
