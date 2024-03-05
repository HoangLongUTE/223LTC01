using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BT1
{
    class NHANVIEN : NGUOI
    {
        public string BangCap { get; set; }

        public NHANVIEN() : base("", "", "", "") { }
        public NHANVIEN(string ten, string diaChi, string email, string soDienThoai, string bangCap) : base(ten, diaChi, email, soDienThoai)
        {
            BangCap = bangCap;
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine("Bang cap: " + BangCap);
        }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap bang cap: ");
            BangCap = Console.ReadLine();
        }
    }
}
