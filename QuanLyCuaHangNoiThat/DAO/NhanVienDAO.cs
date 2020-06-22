using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhanVienDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();

        public static List<String> LayDanhSachMaNV()
        {
            return db.NHANVIEN.Select(p => p.MANV).ToList();
        }

        public static List<NHANVIEN> LayDanhSachNV()
        {
            return db.NHANVIEN.Where(p => p.TRANGTHAI == true && p.CHUCVU == "NV").ToList();
        }

        public static List<NHANVIEN> LayThongTinCuaNV(string manv)
        {
            return db.NHANVIEN.Where(p => p.TRANGTHAI == true && p.MANV == manv).ToList();
        }

        public static String KiemTraChucVu(string manv)
        {
            var kq = from nv in db.NHANVIEN
                     where nv.MANV == manv
                     select nv.CHUCVU;
            return kq.SingleOrDefault().ToString();
        }

        public static String LayMatKhau(string manv)
        {
            var kq = from nv in db.NHANVIEN
                     where nv.MANV == manv && nv.TRANGTHAI == true
                      select nv.MATKHAU;
            return kq.SingleOrDefault().ToString();
        }

        public static bool DoiMatKhau(string manv,string mk)
        {
            try
            {
                var kq = db.NHANVIEN.Find(manv);
                kq.MATKHAU = mk;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool LamMoiMatKhau(string manv)
        {
            try
            {
                var kq = db.NHANVIEN.Find(manv);
                kq.MATKHAU = kq.MANV;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ThemNhanVien(NHANVIEN nv)
        {
            try
            {
                db.NHANVIEN.Add(nv);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static bool CapNhatNhanVien(NHANVIEN nv)
        {
            try
            {
                var kq = db.NHANVIEN.Find(nv.MANV);
                kq.TENNV = nv.TENNV;
                kq.SDT = nv.SDT;
                kq.CMND = nv.CMND;
                kq.EMAIL = nv.EMAIL;
                kq.DIACHI = nv.DIACHI;
                kq.LUONGCB = nv.LUONGCB;
                kq.ANHDAIDIEN = nv.ANHDAIDIEN;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool XoaNhanVien(string manv)
        {
            try
            {
                var kq = db.NHANVIEN.Find(manv);
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
