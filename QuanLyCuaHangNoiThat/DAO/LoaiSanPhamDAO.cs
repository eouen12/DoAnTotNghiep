using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class LoaiSanPhamDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();
        public static List<LOAISANPHAM> LayDanhSachLoaiSanPham()
        {
            return db.LOAISANPHAM.Where(p => p.TRANGTHAI == true).ToList();
        }

        public static List<LOAISANPHAM> LayDanhSachMaLoai()
        {
            return db.LOAISANPHAM.ToList();
        }

        public static bool KiemTraMaLoaiTonTai(string maloai)
        {
            var kq = db.LOAISANPHAM.Find(maloai);
            if (kq != null && kq.TRANGTHAI == true)
                return true;
            return false;
        }

        public static bool ThemLoaiSanPham(LOAISANPHAM loaisp)
        {
            try
            {
                db.LOAISANPHAM.Add(loaisp);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public static bool SuaLoaiSanPham(LOAISANPHAM loaisp)
        {
            try
            {
                var l = db.LOAISANPHAM.Find(loaisp.MALOAI);
                l.TENLOAI = loaisp.TENLOAI;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool XoaLoaiSanPham(string maloai)
        {
            try
            {
                var l = db.LOAISANPHAM.Find(maloai);
                l.TRANGTHAI = false;
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
