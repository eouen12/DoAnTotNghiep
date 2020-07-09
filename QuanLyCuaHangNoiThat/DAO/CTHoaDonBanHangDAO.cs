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
        
        public static List<CTHOADONBANHANG> LayDanhSachCTHD()
        {
            return db.CTHOADONBANHANG.Where(p =>p.TRANGTHAI == true).ToList();
        }

        public static void ThemCTHoaDon(CTHOADONBANHANG ct)
        {
            if(db.CTHOADONBANHANG.Where(p=>p.MASP == ct.MASP && p.TRANGTHAI == false && p.MAHD == ct.MAHD).ToList().Count == 1 )
            {
                var kq = db.CTHOADONBANHANG.Find(ct.MAHD, ct.MASP);
                kq.SOLUONG = ct.SOLUONG;
                kq.DONGIA = ct.DONGIA;
                kq.TRANGTHAI = true;
                db.SaveChanges();
            }
            else
            {
                db.CTHOADONBANHANG.Add(ct);
                db.SaveChanges();
            }
        }

        public static bool SuaCTHoaDon(CTHOADONBANHANG ct)
        {
            try
            {
                var kq = db.CTHOADONBANHANG.Find(ct.MAHD,ct.MASP);
                kq.SOLUONG = ct.SOLUONG;
                kq.DONGIA = ct.DONGIA;
                kq.TRANGTHAI = true;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool XoaCTHoaDon(string mahd, string masp)
        {
            try
            {
                var kq = db.CTHOADONBANHANG.Find(mahd, masp);
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
