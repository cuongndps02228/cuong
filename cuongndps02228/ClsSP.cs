using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuongndps02228
{
    public class ClsSP
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int Gia { get; set; }
        public string Mota { get; set; }
        public string Maloai { get; set; }



        public ClsSP(string masp, string tensp, int gia, string mota, string maloai)
        {
            MaSP = masp;
            TenSP = tensp;
            Gia = gia;
            Mota = mota;
            Maloai = maloai;
        }
    }
}

