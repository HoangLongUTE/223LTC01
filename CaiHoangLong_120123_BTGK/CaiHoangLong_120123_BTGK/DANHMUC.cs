using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiHoangLong_120123_BTGK
{
    class DANHMUC
    {
        public string MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }

        public DANHMUC(string maDanhMuc, string tenDanhMuc)
        {
            MaDanhMuc = maDanhMuc;
            TenDanhMuc = tenDanhMuc;
        }

    }
}
