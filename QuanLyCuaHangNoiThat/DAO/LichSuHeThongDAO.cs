using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class LichSuHeThongDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();
        public static List<LICHSUHETHONG> LayDanhSachLSHT()
        {
            return db.LICHSUHETHONG.ToList();
        }

        public static void ThemLSHT(LICHSUHETHONG lsht)
        {
            db.LICHSUHETHONG.Add(lsht);
            db.SaveChanges();
        }

    }
}
