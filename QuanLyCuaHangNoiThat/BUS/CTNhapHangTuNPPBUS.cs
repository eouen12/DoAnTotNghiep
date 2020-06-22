using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class CTNhapHangTuNPPBUS
    {
        public static List<CHITIETNHAPHANG> LayDanhSachChiTietNhapHang()
        {
            return CTNhapHangTuNPPDAO.LayDanhSachChiTietNhapHang();
        }
        public static bool ThemCTNH(CHITIETNHAPHANG npp)
        {
            return CTNhapHangTuNPPDAO.ThemCTNH(npp);
        }
        public static bool SuaCTNH(CHITIETNHAPHANG npp)
        {
            return CTNhapHangTuNPPDAO.SuaCTNH(npp);
        }
        public static bool XoaCTNH(string manpp , string masp)
        {
            return CTNhapHangTuNPPDAO.XoaCTNH(manpp , masp);
        }
    }
}
