using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SanPhamBUS
    {
        public static List<SANPHAM> LayDanhSachSanPham()
        {
            return SanPhamDAO.LayDanhSachSanPham();
        }

        public static List<SANPHAM> LayDanhSachSP()
        {
            return SanPhamDAO.LayDanhSachSP();
        }
        public static List<SANPHAM> LayDanhSachMaSanPham()
        {
            return SanPhamDAO.LayDanhSachMaSanPham();
        }

        public static bool KiemTraMaSPTonTai(string masp)
        {
            return SanPhamDAO.KiemTraMaSPTonTai(masp);
        }

        public static bool ThemSanPham(SANPHAM sp)
        {
             return SanPhamDAO.ThemSanPham(sp);
        }

        public static bool SuaSanPham(SANPHAM sp)
        {
            return SanPhamDAO.SuaSanPham(sp);
        }
        public static bool XoaSanPham(string masp)
        {
            return SanPhamDAO.XoaSanPham(masp);
        }
    }
}
