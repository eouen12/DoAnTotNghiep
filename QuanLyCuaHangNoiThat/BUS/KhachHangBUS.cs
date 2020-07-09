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

        public static List<KHACHHANG> LayDanhSachMaKhachHang()
        {
            return KhachHangDAO.LayDanhSachMaKhachHang();
        }
        public static KHACHHANG LayThongTin(string makh)
        {
            return KhachHangDAO.LayThongTin(makh);
        }
        public static bool Insert(KHACHHANG entity)
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
