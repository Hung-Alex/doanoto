using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    class KhachHang
    {
        private string _maKH;
        private string _tenKH;
        private string _sCMND;
        private string _sDT;
        private string _diaChi;
        private string _gioiTinh;
        public KhachHang(string makh,string tenkh,string scmnd ,string sdt,string diachi,string giotinh)
        {
            this.MaKH = makh;
            this.TenKH = tenkh;
            this.SCMND = scmnd;
            this.SDT = sdt;
            this.DiaChi = diachi;
            this.GioiTinh = giotinh;
        }
        public KhachHang(DataRow item)
        {
            this.MaKH = item["MaKH"].ToString();
            this.TenKH = item["TenKhachHang"].ToString();
            this.SCMND = item["SCMND"].ToString();
            this.SDT = item["SDT"].ToString();
            this.DiaChi = item["DiaChi"].ToString();
            this.GioiTinh = item["GioiTinh"].ToString();
        }
        public string MaKH { get => _maKH; set => _maKH = value; }
        public string TenKH { get => _tenKH; set => _tenKH = value; }
        public string SCMND { get => _sCMND; set => _sCMND = value; }
        public string SDT { get => _sDT; set => _sDT = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
    }
}
