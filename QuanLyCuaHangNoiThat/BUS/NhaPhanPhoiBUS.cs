using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NhaPhanPhoiBUS
    {
        public static List<NHAPHANPHOI> LayDanhSachNhaPhanPhoi()
        {
            return NhaPhanPhoiDAO.LayDanhSachNhaPhanPhoi();
        }
        public static bool KiemTraMaNPPTonTai(string manpp)
        {
            return NhaPhanPhoiDAO.KiemTraMaNPPTonTai(manpp);
        }
        public static bool ThemNPP(NHAPHANPHOI npp)
        {
            return NhaPhanPhoiDAO.ThemNPP(npp);
        }
        public static bool SuaNPP(NHAPHANPHOI npp)
        {
            return NhaPhanPhoiDAO.SuaNPP(npp);
        }
        public static bool XoaNPP(string manpp)
        {
            return NhaPhanPhoiDAO.XoaNPP(manpp);
        }
    }
}
