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

        public static List<String> LayDanhSachNhanVien()
        {
            return db.NHANVIEN.Select(p => p.MANV).ToList();
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
                     where nv.MANV == manv
                      select nv.MATKHAU;
            return kq.SingleOrDefault().ToString();
        }
    }
}
