using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BTGK
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TAILIEU> list_tailieu = new List<TAILIEU>
            {
                new SACH("MXB01","Sach thieu nhi","NXB Kim Dong","DM01","Nguyen Anh",80),
                new SACH("MXB02","Sach khoa hoc","NXB Bach Khoa","DM01","Thu Thao",120),
                new BAO("MXB03", "Bao Thanh Nien", "NXB Thanh Nien", "DM02", new DateTime(2024, 3, 1)),
                new BAO("MXB04", "Bao Tuoi Tre", "NXB Tuoi Tre", "DM02", new DateTime(2024, 3, 15)),
                new TAPCHI("MXB05", "Tap chi Cong nghe", "NXB Khoa Hoc & Ky Thuat", "DM03", 1, "Trang ddd"),
                new TAPCHI("MXB06", "Tap chi Van hoc", "NXB Van Nghe", "DM03", 2, "Trang aaa")
            };

            Console.WriteLine("Nhap loai tai lieu can tim (B: Bao, N: Sach, M: Tap chi): ");
            string category = Console.ReadLine().ToUpper();

            var result = list_tailieu.Where(tl =>
            {
                switch (category)
                {
                    case "B":
                        return tl is BAO;
                    case "N":
                        return tl is SACH;
                    case "M":
                        return tl is TAPCHI;
                    default:
                        return false;
                }
            }).ToList();

            Console.WriteLine("Ket qua tim kiem:");
            foreach (var tl in result)
            {
                Console.WriteLine($"ID: {tl.MaXuatBan}, Ten Tai Lieu: {tl.TenTaiLieu}");
            }

            Console.WriteLine("Bao thang 03/2024");
            var newspapers = list_tailieu.OfType<BAO>().Where(b => b.NgayPhatHanh.Month == 3 && b.NgayPhatHanh.Year == 2024).ToList();
            foreach (var newspaper in newspapers)
            {
                Console.WriteLine($"ID: {newspaper.MaXuatBan}, Name: {newspaper.TenTaiLieu}");
            }

            Console.ReadKey();
        }
    }
}
