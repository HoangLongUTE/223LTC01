using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BTGK
{
    class BAO:TAILIEU
    {
        public DateTime NgayPhatHanh { get; set; }

        public BAO(string maXuatBan, string tenTaiLieu, string nhaPhatHanh, string maDanhMuc, DateTime ngayPhatHanh):base(maXuatBan, tenTaiLieu, nhaPhatHanh, maDanhMuc)
        {
            NgayPhatHanh = ngayPhatHanh;
        }
    }
}
