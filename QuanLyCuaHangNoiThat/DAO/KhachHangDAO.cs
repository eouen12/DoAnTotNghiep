using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class KhachHangDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();

        public static List<KHACHHANG> LayDanhSachKhachHang()
        {
            return db.KHACHHANG.ToList();
        }

        public static KHACHHANG LayThongTin(int makh)
        {
            return db.KHACHHANG.Find(makh);
            
        }
        public static string Insert(KHACHHANG entity)
        {
            db.KHACHHANG.Add(entity);
            db.SaveChanges();
            return entity.TENKH;
        }
        public static bool Update(KHACHHANG entity)
        {
            var kh = db.KHACHHANG.Find(entity.MAKH);
            kh.TENKH = entity.TENKH;
            kh.SDT = entity.SDT;
            kh.DIACHI = entity.DIACHI;
            kh.CMND = entity.CMND;
            db.SaveChanges();
            return true ;
        }
        public static bool Delete(string IDKH)
        {
            try
            {
                var kq = db.KHACHHANG.Find(IDKH);
                kq.TRANGTHAI = false;
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
