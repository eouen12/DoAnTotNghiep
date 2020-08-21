using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class SanPhamDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();

        public static List<SANPHAM> LayDanhSachSanPham()
        {
            return db.SANPHAM.Where(x => x.TRANGTHAI == true).ToList();
        }
        public static List<SANPHAM> LayDanhSachSP()
        {
            return db.SANPHAM.ToList();
        }

        public static bool KiemTraMaSPTonTai(string masp)
        {
            var kq = db.SANPHAM.Find(masp);
            if (kq != null)
                return true;
            return false;
        }

        public static bool ThemSanPham(SANPHAM sp)
        {
            try
            {
                db.SANPHAM.Add(sp);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static bool SuaSanPham(SANPHAM sp)
        {
            try
            {
                var s = db.SANPHAM.Find(sp.MASP);
                s.TENSP = sp.TENSP;
                s.GIABAN = sp.GIABAN;
                s.DVT = sp.DVT;
                s.SL_TON = sp.SL_TON;
                s.MALOAI = sp.MALOAI;
                s.MANPP = sp.MANPP;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool XoaSanPham(string  masp)
        {
            try
            {
                var sp = db.SANPHAM.Find(masp);
                sp.TRANGTHAI = false;
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
