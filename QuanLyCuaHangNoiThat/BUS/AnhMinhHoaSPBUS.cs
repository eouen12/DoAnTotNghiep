using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class AnhMinhHoaSPBUS
    {
        public static List<ANHMINHHOASP> LayDanhSachAnhMinhHoa()
        {
            return AnhMinhHoaSPDAO.LayDanhSachAnhMinhHoa();
        }

        public static bool ThemAnhMinhHoa(ANHMINHHOASP anhMH)
        {
            return AnhMinhHoaSPDAO.ThemAnhMinhHoaSanPham(anhMH);
        }
    }
}
