using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class CongNoBUS
    {
        public static List<CONGNO> LayDanhSachCongNo()
        {
            return CongNoDAO.LayDanhSachCongNo();
        }
        public static bool CapNhatCongNo(CONGNO congno)
        {
            return CongNoDAO.CapNhatCongNo(congno);
        }
        public static bool ThemCongNo(CONGNO congno)
        {
            return CongNoDAO.ThemCongNo(congno);
        }
        public static bool XoaCongNo(string macn)
        {
            return CongNoDAO.XoaCongNo(macn);
        }
    }
}
