using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BT1
{
    class KHACHHANG : NGUOI
    {
        public string LoaiKhachHang { get; set; }

        public KHACHHANG() : base("", "", "", "") { }
        public KHACHHANG(string ten, string diaChi, string email, string soDienThoai, string loaiKhachHang) : base(ten, diaChi, email, soDienThoai)
        {
            LoaiKhachHang = loaiKhachHang;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine("Loai khach hang: " + LoaiKhachHang);
        }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap loai khach hang: ");
            LoaiKhachHang = Console.ReadLine();
        }
    }
}
