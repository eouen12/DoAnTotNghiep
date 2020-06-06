using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CongNoDAO
    {
        private static QuanLyCuaHangNoiThatEntities DbContex = new QuanLyCuaHangNoiThatEntities();
        public static List<CONGNO> LayDanhSachCongNo()
        {
            return DbContex.CONGNOes.ToList();
        }
    }
}
