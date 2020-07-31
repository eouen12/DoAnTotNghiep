using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class HoaDonBanHangDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();

        public static List<HOADONBANHANG> LayDanhSachHonDon()
        {
            return db.HOADONBANHANG.Where(p => p.TRANGTHAI == true).ToList();
        }
        public static List<HOADONBANHANG> LayDanhSachHoaDonTN(string ngaylap)
        {
            return db.HOADONBANHANG.Where(p => p.TRANGTHAI == true ).ToList();
        }
        public static List<HOADONBANHANG> LayThongTinCuaHD(string mahd)
        {
            return db.HOADONBANHANG.Where(p => p.TRANGTHAI == true && p.MAHD == mahd).ToList();
        }

        public static bool ThemHoaDon(HOADONBANHANG hd)
        {
            try
            {
                db.HOADONBANHANG.Add(hd);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool CapNhatHoaDon(HOADONBANHANG hd)
        {
            try
            {
                var kq = db.HOADONBANHANG.Find(hd.MAHD);
                kq.NGAYGIAO = hd.NGAYGIAO;
                kq.TONGTIEN = hd.TONGTIEN;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool XoaHoaDon(string mahd)
        {
            try
            {
                var kq = db.HOADONBANHANG.Find(mahd);
                kq.TRANGTHAI = false;
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
