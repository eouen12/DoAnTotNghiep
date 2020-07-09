using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class CTHoaDonBanHangBUS
    {
        public static List<CTHOADONBANHANG> LayDSCTHD ()
        {
            return CTHoaDonBanHangDAO.LayDanhSachCTHD();
        }
        public static void ThemCTHoaDon(CTHOADONBANHANG ct)
        {
            CTHoaDonBanHangDAO.ThemCTHoaDon(ct);
        }
        public static bool SuaCTHoaDon(CTHOADONBANHANG ct)
        {
            return CTHoaDonBanHangDAO.SuaCTHoaDon(ct);
        }
        public static bool XoaCTHoaDon(string mahd, string masp)
        {
            return CTHoaDonBanHangDAO.XoaCTHoaDon(mahd,masp);
        }
    }
}
