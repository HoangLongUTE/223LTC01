using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BTGK
{
    class SACH:TAILIEU
    {
        public string TenTacGia { get; set; }
        public int SoTrang { get; set; }

        public SACH(string maXuatBan, string tenTaiLieu, string nhaPhatHanh, string maDanhMuc, string tenTacGia, int soTrang):base(maXuatBan, tenTaiLieu, nhaPhatHanh, maDanhMuc)
        {
            TenTacGia = tenTacGia;
            SoTrang = soTrang;
        }
    }
}
