using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class KhachHangBUS
    {
        public static List<KHACHHANG> LayDanhSachKhachHang()
        {
            return KhachHangDAO.LayDanhSachKhachHang();
        }
        public static KHACHHANG LayThongTin(int makh)
        {
            return KhachHangDAO.LayThongTin(makh);
        }
        public static string Insert(KHACHHANG entity)
        {
            return KhachHangDAO.Insert(entity);
        }
        public static bool Update(KHACHHANG entity)
        {
            return KhachHangDAO.Update(entity);
        }
        public static bool Delete(string IDKH)
        {
            return KhachHangDAO.Delete(IDKH);
        }
    }
}
