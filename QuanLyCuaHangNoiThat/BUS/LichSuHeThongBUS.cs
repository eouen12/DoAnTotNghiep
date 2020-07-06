using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class LichSuHeThongBUS
    {
        public static List<LICHSUHETHONG> LayDanhSachLSHT()
        {
            return LichSuHeThongDAO.LayDanhSachLSHT();
        }

        public static void ThemLSHT(LICHSUHETHONG lsht)
        {
            LichSuHeThongDAO.ThemLSHT(lsht);
        }
    }
}
