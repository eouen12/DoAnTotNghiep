using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhaPhanPhoiDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();
        
        public static List<NHAPHANPHOI> LayDanhSachNhaPhanPhoi()
        {
            return db.NHAPHANPHOI.Where(p => p.TRANGTHAI == true).ToList();
        }
    }
}
