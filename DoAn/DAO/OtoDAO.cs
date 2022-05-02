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


    }
}
