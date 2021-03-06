﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CTNhapHangDAO
    {
        private static QuanLyCuaHangNoiThatEntities db = new QuanLyCuaHangNoiThatEntities();

        public static List<CHITIETNHAPHANG> LayDanhSachChiTietNhapHang()
        {
            return db.CHITIETNHAPHANG.Where(p => p.TRANGTHAI == true).ToList();
        }
        public static bool ThemCTNH(CHITIETNHAPHANG ctnh)
        {
            try
            {
                db.CHITIETNHAPHANG.Add(ctnh);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool SuaCTNH(CHITIETNHAPHANG ctnh)
        {
            try
            {
                var s = db.CHITIETNHAPHANG.Find(ctnh.MASP,ctnh.MANPP);
                s.SL_NHAPHANG = ctnh.SL_NHAPHANG;
                s.DONGIA = ctnh.DONGIA;
                s.TONGGIATRI = ctnh.TONGGIATRI;
                s.NGAYNHAPHANG = ctnh.NGAYNHAPHANG;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool XoaCTNH(string manpp, string masp)
        {
            try
            {
                var ctnh = db.CHITIETNHAPHANG.Find(masp, manpp);
                ctnh.TRANGTHAI = false;
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
