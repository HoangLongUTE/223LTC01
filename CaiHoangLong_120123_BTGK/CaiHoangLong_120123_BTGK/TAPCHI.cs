using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BTGK
{
    class TAPCHI:TAILIEU
    {
        public int SoPhatHanh { get; set; }
        public string TrangPhatHanh { get; set; }
        public TAPCHI(string maXuatBan, string tenTaiLieu, string nhaPhatHanh, string maDanhMuc, int soPhatHanh, string trangPhatHanh): base(maXuatBan, tenTaiLieu, nhaPhatHanh, maDanhMuc)
        {
            SoPhatHanh = soPhatHanh;
            TrangPhatHanh = trangPhatHanh;
        }

       
    }
}
