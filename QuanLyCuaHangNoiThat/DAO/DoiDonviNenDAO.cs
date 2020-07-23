using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DoiDonviNenDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();
        public static List<DOIDONVINEN> LayDSGachNen()
        {
            return db.DOIDONVINEN.Where(p => p.TRANGTHAI == true).ToList();
        }


    }
}
