using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BT1
{
    class Program
    {
        static void NhapVaHienThiThongTin(ref List<NGUOI> danhSachNguoi)
        {
            bool tiepTucNhap = true;

            while (tiepTucNhap)
            {
                Console.WriteLine("Chon loai doi tuong de nhap thong tin:");
                Console.WriteLine("1. Nhan vien");
                Console.WriteLine("2. Khach hang");
                Console.Write("Lua chon cua ban (1/2): ");
                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1":
                        NHANVIEN nhanVien = new NHANVIEN();
                        nhanVien.NhapThongTin();
                        danhSachNguoi.Add(nhanVien);
                        break;
                    case "2":
                        KHACHHANG khachHang = new KHACHHANG();
                        khachHang.NhapThongTin();
                        danhSachNguoi.Add(khachHang);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        continue;
                }

                Console.Write("Ban co muon tiep tuc nhap thong tin khong? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                {
                    tiepTucNhap = false;
                }
            }


            Console.WriteLine("\nDanh sach da nhap:");
            foreach (var nguoi in danhSachNguoi)
            {
                if (nguoi is NHANVIEN)
                {
                    NHANVIEN nhanVien = nguoi as NHANVIEN;
                    string thongTin = $"1, {nhanVien.Ten}, {nhanVien.DiaChi}, {nhanVien.Email}, {nhanVien.SoDienThoai}, {nhanVien.BangCap}";
                    Console.WriteLine(thongTin);
                }
                else if (nguoi is KHACHHANG)
                {
                    KHACHHANG khachHang = nguoi as KHACHHANG;
                    string thongTin = $"2, {khachHang.Ten}, {khachHang.DiaChi}, {khachHang.Email}, {khachHang.SoDienThoai}, {khachHang.LoaiKhachHang}";
                    Console.WriteLine(thongTin);
                }
            }
        }


        static void NhapVaSapXepThongTinNhanVien()
        {
            List<NHANVIEN> danhSachNhanVien = new List<NHANVIEN>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nNhap thong tin cho nhan vien thu {i + 1}:");
                NHANVIEN nv = new NHANVIEN();
                nv.NhapThongTin();
                danhSachNhanVien.Add(nv);
            }


            danhSachNhanVien = danhSachNhanVien.OrderBy(nv => nv.Ten).ToList();

            Console.WriteLine("\nDanh sach nhan vien sau khi sap xep:");
            foreach (NHANVIEN nv in danhSachNhanVien)
            {
                string thongTin = $"{nv.Ten}, {nv.DiaChi}, {nv.Email}, {nv.SoDienThoai}, {nv.BangCap}"; // Tao chuoi thong tin
                Console.WriteLine(thongTin);
            }
        }


        static void Main(string[] args)
        {
            List<NGUOI> danhSachNguoi = new List<NGUOI>();
            bool tiepTuc = true;

            while (tiepTuc)
            {
                Console.WriteLine("Chon bai de thuc hien:");
                Console.WriteLine("1. Nhap va hien thi thong tin");
                Console.WriteLine("2. Nhap thong tin 10 nhan vien va sap xep theo ten");
                Console.Write("Lua chon cua ban (1/2): ");
                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1":
                        NhapVaHienThiThongTin(ref danhSachNguoi);
                        break;
                    case "2":
                        NhapVaSapXepThongTinNhanVien();
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }
            }
        }
    }
}
