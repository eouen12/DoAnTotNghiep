﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HoaDonBanHangBUS
    {
        public static List<HOADONBANHANG> LayDanhSachHoaDon()
        {
            return HoaDonBanHangDAO.LayDanhSachHonDon();
        }
        public static List<HOADONBANHANG> LayDSHoaDon()
        {
            return HoaDonBanHangDAO.LayDSHonDon();
        }

        public static List<HOADONBANHANG> LayDanhSachHoaDonTN(string ngaylap)
        {
            return HoaDonBanHangDAO.LayDanhSachHoaDonTN(ngaylap);
        }
        public static List<HOADONBANHANG> LayThongTinCuaHD(string mahd)
        {
            return HoaDonBanHangDAO.LayThongTinCuaHD(mahd);
        }

        public static bool ThemHoaDon(HOADONBANHANG hd)
        {
            return HoaDonBanHangDAO.ThemHoaDon(hd);
        }

        public static bool CapNhatHoaDon(HOADONBANHANG hd)
        {
            return HoaDonBanHangDAO.CapNhatHoaDon(hd);
        }

        public static bool XoaHoaDon(string mahd)
        {
            return HoaDonBanHangDAO.XoaHoaDon(mahd);
        }
    }
}
