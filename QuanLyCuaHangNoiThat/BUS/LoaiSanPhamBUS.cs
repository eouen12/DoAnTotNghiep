using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class LoaiSanPhamBUS
    {
        public static List<LOAISANPHAM> LayDanhSachLoaiSanPham()
        {
            return LoaiSanPhamDAO.LayDanhSachLoaiSanPham();
        }

        public static List<LOAISANPHAM> LayDanhSachMaLoai()
        {
            return LoaiSanPhamDAO.LayDanhSachMaLoai();
        }
        public static bool KiemTraMaLoaiTonTai(string maloai)
        {
            return LoaiSanPhamDAO.KiemTraMaLoaiTonTai(maloai);
        }

        public static bool ThemLoaiSanPham(LOAISANPHAM loaisp)
        {
            return LoaiSanPhamDAO.ThemLoaiSanPham(loaisp);
        }

        public static bool SuaLoaiSanPham(LOAISANPHAM loaisp)
        {
            return LoaiSanPhamDAO.SuaLoaiSanPham(loaisp);
        }
        public static bool XoaLoaiSanPham(string maloai)
        {
            return LoaiSanPhamDAO.XoaLoaiSanPham(maloai);
        }
    }
}
