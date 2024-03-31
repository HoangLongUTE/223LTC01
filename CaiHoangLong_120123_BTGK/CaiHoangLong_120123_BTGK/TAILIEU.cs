using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BTGK
{
    class TAILIEU
    {
        public string MaXuatBan { get; set; }
        public string TenTaiLieu { get; set; }
        public string NhaPhatHanh { get; set; }
        public string MaDanhMuc { get; set; }

        public TAILIEU(string maXuatBan, string tenTaiLieu, string nhaPhatHanh, string maDanhMuc)
        {
            MaXuatBan = maXuatBan;
            TenTaiLieu = tenTaiLieu;
            NhaPhatHanh = nhaPhatHanh;
            MaDanhMuc = maDanhMuc;
        }
    }
}
