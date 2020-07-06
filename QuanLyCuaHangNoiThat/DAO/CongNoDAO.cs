
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CongNoDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();
        public static List<CONGNO> LayDanhSachCongNo()
        {
            return db.CONGNO.Where(p => p.TRANGTHAI == true).ToList();
        }
        public static bool CapNhatCongNo(CONGNO congno)
        {
            try
            {
                var l = db.CONGNO.Find(congno.MACONGNO);
                l.TIENCONNO = Convert.ToDecimal(congno.TIENCONNO);
                l.NGAYTRA = congno.NGAYTRA;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool ThemCongNo(CONGNO congno)
        {
            try
            {
                db.CONGNO.Add(congno);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool XoaCongNo(string macn)
        {
            try
            {
                var kq = db.CONGNO.Find(macn);
                kq.TRANGTHAI = false;
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
