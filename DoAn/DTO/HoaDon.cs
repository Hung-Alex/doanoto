using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    class HoaDon
    {
        private string _mahoadon;
        private string _mahopdong;
        private string _maKhachHang;
        private string _tenKhachHang;
        private string _sCMND;
        private string _maXe;
        private string _tenXe;
        private DateTime _ngayLapHoaDon;
        private int _tienThue;
        private string _hangXe;


        
        public HoaDon() { }
        public  HoaDon(string mahoadon, string mahopdong, string maKhachHang, string tenKhachHang, string sCMND, string maXe, string tenXe, DateTime ngayLapHoaDon, int tienthue,string hangxe)
        {
            this.Mahoadon = mahoadon;
            this.Mahopdong = mahopdong;
            this.MaKhachHang = maKhachHang;
            this.TenKhachHang = tenKhachHang;
            this.SCMND = sCMND;
            this.MaXe = maXe;
            this.TenXe = tenXe;
            this.NgayLapHoaDon = ngayLapHoaDon;
            this.Tienthue = tienthue;
            this.HangXe = hangxe;
        }
        public HoaDon(DataRow item)
        {
            this.Mahoadon = item["MaHoaDon"].ToString();
            this.Mahopdong = item["MaHopDong"].ToString();
            this.MaKhachHang = item["MaKH"].ToString() ;
            this.TenKhachHang = item["TenKhachHang"].ToString() ;
            this.SCMND = item["SCMND"].ToString();
            this.MaXe = item["MaXe"].ToString();
            this.TenXe = item["TenXe"].ToString();
            this.HangXe = item["HangXe"].ToString();
            this.NgayLapHoaDon = DateTime.Parse(item["NgayLapHoaDon"].ToString());
            this.Tienthue = int.Parse( item["TongTien"].ToString());
        }
        public string Mahoadon { get => _mahoadon; set => _mahoadon = value; }
        public string Mahopdong { get => _mahopdong; set => _mahopdong = value; }
        public string MaKhachHang { get => _maKhachHang; set => _maKhachHang = value; }
        public string TenKhachHang { get => _tenKhachHang; set => _tenKhachHang = value; }
        public string SCMND { get => _sCMND; set => _sCMND = value; }
        public string MaXe { get => _maXe; set => _maXe = value; }
        public string TenXe { get => _tenXe; set => _tenXe = value; }
        public DateTime NgayLapHoaDon { get => _ngayLapHoaDon; set => _ngayLapHoaDon = value; }
        public int Tienthue { get => _tienThue; set => _tienThue = value; }
        public string HangXe { get => _hangXe; set => _hangXe = value; }
    }
}
