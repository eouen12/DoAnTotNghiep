using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class LichSuTraNoDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();
        public static List<LICHSUTRANO> LayDSLSTraNoCuaKH(string macn)
        {
            return db.LICHSUTRANO.Where(p => p.TRANGTHAI == true && p.MACONGNO == macn).ToList();
        }

        public static bool TaoLichSuTraNo(LICHSUTRANO lstrano)
        {
            try
            {
                db.LICHSUTRANO.Add(lstrano);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
