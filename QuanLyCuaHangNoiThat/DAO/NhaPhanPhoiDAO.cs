using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhaPhanPhoiDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();
        
        public static List<NHAPHANPHOI> LayDanhSachNhaPhanPhoi()
        {
            return db.NHAPHANPHOI.Where(p => p.TRANGTHAI == true).ToList();
        }

        public static bool KiemTraMaNPPTonTai(string manpp)
        {
            var kq = db.NHAPHANPHOI.Find(manpp);
            if (kq != null && kq.TRANGTHAI == true)
                return true;
            return false;
        }
        public static bool ThemNPP(NHAPHANPHOI npp)
        {
            try
            {
                db.NHAPHANPHOI.Add(npp);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool SuaNPP(NHAPHANPHOI npp)
        {
            try
            {
                var s = db.NHAPHANPHOI.Find(npp.MANPP);
                s.TENNPP = npp.TENNPP;
                s.SDT = npp.SDT;
                s.EMAIL = npp.EMAIL;
                s.DIACHI = npp.DIACHI;
                s.WEBSITE = npp.WEBSITE;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
            public static bool XoaNPP(string manpp)
            {
                try
                {
                    var s = db.NHAPHANPHOI.Find(manpp);
                    s.TRANGTHAI = false;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
    }
}
