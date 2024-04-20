using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (var db = new EntityDBEntities())
            {
                var query = from sv in db.SinhVien
                            where sv.Lop.Khoa.TenKhoa == "CNTT" && sv.Tuoi >= 18 && sv.Tuoi <= 20
                            select sv;

                Console.WriteLine("Danh sách sinh  vien thuộc khoa CNTT và có tuổi từ 18 đến 20:");
                foreach (var sv in query)
                {
                    Console.WriteLine($"Mã SV: {sv.MaSV}, Tên SV: {sv.TenSV}, Tuổi: {sv.Tuoi}, Lớp: {sv.Lop.TenLop}");
                }
            }
            Console.ReadLine();
        }
    }
}
