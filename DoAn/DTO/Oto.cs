using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    public class Oto
    {
        private string _maXe;
        private string _tenXe;
        private string _hangXe;
        private string _bienSoXe;
        private int _soChoNgoi;
        private string _trangThai;
        public Oto(string maxe,string tenxe,string hangxe,string biensoxe,int sochongoi,string trangthai)
        {
            this.MaXe = maxe;
            this.TenXe = tenxe;
            this.HangXe = hangxe;
            this.BienSoXe = biensoxe;
            this.SoChoNgoi = sochongoi;
            this.TrangThai = trangthai;
        }
        public Oto(DataRow item)
        {
            this.MaXe = (string)item["MaXe"];
            this.TenXe = (string)item["TenXe"];
            this.HangXe = (string)item["HangXe"];
            this.BienSoXe = (string)item["BienSoxe"];
            this.SoChoNgoi = (int)item["SoChoNgoi"];
            this.TrangThai = (string)item["TrangThai"];

        }
        public string MaXe { get => _maXe; set => _maXe = value; }
        public string TenXe { get => _tenXe; set => _tenXe = value; }
        public string HangXe { get => _hangXe; set => _hangXe = value; }
        public string BienSoXe { get => _bienSoXe; set => _bienSoXe = value; }
        public int SoChoNgoi { get => _soChoNgoi; set => _soChoNgoi = value; }
        public string TrangThai { get => _trangThai; set => _trangThai = value; }
    }
}
