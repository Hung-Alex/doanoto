using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    class HopDong
    {
        private string _maHD;
        private string _maKH;
        private string _tenKhachHang;
        private string _maXe;
        private string _tenXe;
        private int _tienThue;
        private DateTime _ngayThue;
        private DateTime _ngayTra;
        private string _tinhTrang;

        public HopDong(DataRow item)
        {
            this.MaHD = item["MaHopDong"].ToString();
            this.MaKH = item["MaKH"].ToString();
            this.TenKhachHang = item["TenKhachHang"].ToString();
            this.MaXe = item["MaXe"].ToString();
            this.TenXe = item["TenXe"].ToString();
            this.TienThue =( int)item["TienThue"];
            this.NgayThue = DateTime.Parse( item["NgayThue"].ToString());
            this.NgayTra = DateTime.Parse(item["NgayTra"].ToString()); ;
            this.TinhTrang = item["TinhTrang"].ToString();
        }
        public HopDong(string mahd,string makh,string tenkh,string maxe ,string tenxe,int tienthue,DateTime ngaythue,DateTime  ngaytra,string tinhtrang)
        {
            this.MaHD = mahd;
            this.MaKH = makh;
            this.TenKhachHang = tenkh;
            this.MaXe = maxe;
            this.TenXe = tenxe;
            this.TienThue = tienthue;
            this.NgayThue = ngaythue;
            this.NgayTra = ngaytra;
            this.TinhTrang = tinhtrang;
        }
        public string MaHD { get => _maHD; set => _maHD = value; }
        public string MaKH { get => _maKH; set => _maKH = value; }
        public string TenKhachHang { get => _tenKhachHang; set => _tenKhachHang = value; }
        public string MaXe { get => _maXe; set => _maXe = value; }
        public string TenXe { get => _tenXe; set => _tenXe = value; }
        public int TienThue { get => _tienThue; set => _tienThue = value; }
        public DateTime NgayThue { get => _ngayThue; set => _ngayThue = value; }
        public DateTime NgayTra { get => _ngayTra; set => _ngayTra = value; }
        public string TinhTrang { get => _tinhTrang; set => _tinhTrang = value; }
    }
}
