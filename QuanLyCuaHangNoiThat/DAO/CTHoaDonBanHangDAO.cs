using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CTHoaDonBanHangDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();
        
        public static List<CTHOADONBANHANG> LayDanhSachCTHDcuaKH(string mahd)
        {
            return db.CTHOADONBANHANG.Where(p => p.MAHD == mahd && p.TRANGTHAI == true).ToList();
        }

        public static void ThemCTHoaDon(CTHOADONBANHANG ct)
        {
            db.CTHOADONBANHANG.Add(ct);
            db.SaveChanges();
        }
    }
}
