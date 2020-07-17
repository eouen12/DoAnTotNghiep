using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NhanVienBUS
    {
        public static List<String> LayDanhSachMaNV()
        {
            return NhanVienDAO.LayDanhSachMaNV();
        }

        public static List<NHANVIEN> LayDanhSachNV()
        {
            return NhanVienDAO.LayDanhSachNV();
        }
        public static List<NHANVIEN> LayDanhSachAllNV()
        {
            return NhanVienDAO.LayDanhSachAllNV();
        }

        public static List<NHANVIEN> LayThongTinCuaNV(string manv)
        {
            return NhanVienDAO.LayThongTinCuaNV(manv);
        }

        public static bool KiemTraDangNhap(string manv, string mk)
        {
            return mk == NhanVienDAO.LayMatKhau(manv);
        }

        public static String ChucVuNhanVien(string manv)
        {
            return NhanVienDAO.KiemTraChucVu(manv);
        }

        public static bool ThemNhanVien(NHANVIEN nv)
        {
            return NhanVienDAO.ThemNhanVien(nv);
        }

        public static bool CapNhatNhanVien(NHANVIEN nv)
        {
            return NhanVienDAO.CapNhatNhanVien(nv);
        }

        public static bool XoaNhanVien(string manv)
        {
            return NhanVienDAO.XoaNhanVien(manv);
        }

        public static bool LamMoiMatKhau(string manv)
        {
            return NhanVienDAO.LamMoiMatKhau(manv);
        }

        public static bool DoiMatKhau(string manv,string mk)
        {
            return NhanVienDAO.DoiMatKhau(manv,mk);
        }
    }
}
