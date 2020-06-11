using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class AnhMinhHoaSPDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();

        public static List<ANHMINHHOASP> LayDanhSachAnhMinhHoa()
        {
            return db.ANHMINHHOASP.Where(x => x.TRANGTHAI == true).ToList();
        }

        public static bool ThemAnhMinhHoaSanPham(ANHMINHHOASP anhMH)
        {
            try
            {
                db.ANHMINHHOASP.Add(anhMH);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static bool XoaSanPham(string maAnh)
        {
            try
            {
                var anhMH = db.ANHMINHHOASP.Find(maAnh);
                anhMH.TRANGTHAI = false;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
