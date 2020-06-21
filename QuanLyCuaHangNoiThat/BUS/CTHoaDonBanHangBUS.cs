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
        public static List<CTHOADONBANHANG> LayDSCTHDcuaKH (string mahd)
        {
            return CTHoaDonBanHangDAO.LayDanhSachCTHDcuaKH(mahd);
        }
        public static void ThemCTHoaDon(CTHOADONBANHANG ct)
        {
            CTHoaDonBanHangDAO.ThemCTHoaDon(ct);
        }
    }
}
