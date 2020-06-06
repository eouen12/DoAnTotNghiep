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
        public static List<String> LayDanhSachNhanVien()
        {
            return NhanVienDAO.LayDanhSachNhanVien();
        }

        public static bool KiemTraDangNhap(string manv, string mk)
        {
            return mk == NhanVienDAO.LayMatKhau(manv);
        }

        public static String ChucVuNhanVien(string manv)
        {
            return NhanVienDAO.KiemTraChucVu(manv);
        }
    }
}
