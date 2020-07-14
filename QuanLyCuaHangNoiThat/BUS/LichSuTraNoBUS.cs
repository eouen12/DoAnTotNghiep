using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class LichSuTraNoBUS
    {
        public static List<LICHSUTRANO> LayDSLSTraNoCuaKH(string macn)
        {
            return LichSuTraNoDAO.LayDSLSTraNoCuaKH(macn);
        }
        public static bool TaoLichSuTraNo(LICHSUTRANO lstrano)
        {
            return LichSuTraNoDAO.TaoLichSuTraNo(lstrano);
        }
    }
}
