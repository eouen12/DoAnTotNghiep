using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DoiDonViTuongDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();
        public static List<DOIDONVITUONG> LayDSGachTuong()
        {
            return db.DOIDONVITUONG.Where(p => p.TRANGTHAI == true).ToList();
        }
    }
}
