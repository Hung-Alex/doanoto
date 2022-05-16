using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAO
{
    class OtoDAO
    {
        private static OtoDAO instance;
        public static OtoDAO Instance
        {
            get
            {
                if (instance==null)
                {
                    DAO.OtoDAO.instance = new OtoDAO();
                };
                return DAO.OtoDAO.instance;
            }
           private set {DAO.OtoDAO.instance=value;}
        }
        private OtoDAO() { }

        public static int OtoWidth = 100;
        public static int OtoHeight = 100;


        public List<DTO.Oto> loadOto()
        {
            List<DTO.Oto> otolist = new List<DTO.Oto>();
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery("usp_GetOtoList");
            foreach (DataRow  item in data.Rows)
            {
                DTO.Oto oto = new DTO.Oto(item);
                otolist.Add(oto);
            }
            return otolist;
        }
        public List<DTO.Oto> GetListOto()
        {
            List<DTO.Oto> otolist = new List<DTO.Oto>();
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery("usp_GetOtoList");
            foreach (DataRow item in data.Rows)
            {
                DTO.Oto oto = new DTO.Oto(item);
                otolist.Add(oto);
            }
            return otolist;
        }

        public List<DTO.Oto> loadOto(int sochoingoi)
        {
            List<DTO.Oto> otolist = new List<DTO.Oto>();
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery("dbo.usp_GetListOtoBySoChoNgoi @sochongoi",new object[] { sochoingoi});
            foreach (DataRow item in data.Rows)
            {
                DTO.Oto oto = new DTO.Oto(item);
                otolist.Add(oto);
            }
            return otolist;
        }
        public DTO.Oto GetShowListViewHopDong(string maxe)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("exec dbo.usp_GetListOtoById @maxe", new object[] { maxe });
            DTO.Oto oto=new DTO.Oto(result.Rows[0]);

            return oto;
        }

        public void updateOto(string maxe)
        {
            DAO.DataProvider.Instance.ExecuteNonQuery("exec usp_UpdateOtoByMaXe @maxe",new object[] { maxe});
        }
        public List<DTO.Oto> loadOto(string trangthai)// load oto by status (Trống or Thuê)
        {
            List<DTO.Oto> otolist = new List<DTO.Oto>();
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery($"select * from OTO where TrangThai=N'{trangthai}'");
            foreach (DataRow item in data.Rows)
            {
                DTO.Oto oto = new DTO.Oto(item);
                otolist.Add(oto);
            }
            return otolist;
        }
        public int UpdateOtoByOto(string maxe, string tenxe, string hangxe, string biensoxe, int sochongoi, string trangthai)
        {
             return DAO.DataProvider.Instance.ExecuteNonQuery($"exec usp_UpdateOto '{maxe}' ,N'{tenxe}' ,N'{hangxe}' ,'{biensoxe}' ,N'{trangthai}','{sochongoi}'");
        }
       
        public int InsertOto(string tenxe,string hangxe,string biensoxe,int sochongoi)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery($" exec dbo.usp_InsertOto N'{tenxe}' ,N'{hangxe}' ,'{biensoxe}' ,{sochongoi}");
        }
        public int RemoveOto(string maxe)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery($"exec dbo.usp_RemoveOto '{maxe}'");
        }
        public  int RemoveHopDongAndHoaDonByMaxe(string maxe)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery($"exec dbo.usp_RemoveHopDongAndHoaDonByMaXe '{maxe}'");

        }
        public List<DTO.Oto> FindOtoByTenXe(string tenxe)
        {
            List<DTO.Oto> otolist = new List<DTO.Oto>();
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery($"select * from OTO where TenXe like N'%{tenxe.Trim()}%'");
            foreach (DataRow item in data.Rows)
            {
                DTO.Oto oto = new DTO.Oto(item);
                
                otolist.Add(oto);
            }
            return otolist;
        }

    }
}
