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
        public static string Delete(string IDKH)
        {
            int ID = int.Parse(IDKH);
            string TenKH = string.Empty;
            using (QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities())
            {
                var ch = (from dt in db.KHACHHANG where dt.MAKH == ID select dt).SingleOrDefault();
                TenKH = ch.TENKH.ToString();
                db.KHACHHANG.Remove(ch);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    
                }
            }
            return TenKH;
        }
    }
}
