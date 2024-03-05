using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BT1
{
    class NGUOI
    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }

        public NGUOI(string ten, string diaChi, string email, string soDienThoai)
        {
            Ten = ten;
            DiaChi = diaChi;
            Email = email;
            SoDienThoai = soDienThoai;
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine("Ten: " + Ten);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("So dien thoai: " + SoDienThoai);
        }
        public virtual void NhapThongTin()
        {
            Console.Write("Nhap ten: ");
            Ten = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap email: ");
            Email = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            SoDienThoai = Console.ReadLine();
        }
    }
}
