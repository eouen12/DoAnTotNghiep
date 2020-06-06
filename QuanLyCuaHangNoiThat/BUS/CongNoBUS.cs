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
    }
}
