using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HoaDonBanHangBUS
    {
        public static List<HOADONBANHANG> LayDanhSachHoaDon()
        {
            return HoaDonBanHangDAO.LayDanhSachHonDon();
        }

        public static bool ThemHoaDon(HOADONBANHANG hd)
        {
            return HoaDonBanHangDAO.ThemHoaDon(hd);
        }

        public static bool CapNhatHoaDon(HOADONBANHANG hd)
        {
            return HoaDonBanHangDAO.CapNhatHoaDon(hd);
        }

        public static bool XoaHoaDon(string mahd)
        {
            return HoaDonBanHangDAO.XoaHoaDon(mahd);
        }
    }
}
