﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class CTNhapHangBUS
    {
        public static List<CHITIETNHAPHANG> LayDanhSachChiTietNhapHang()
        {
            return CTNhapHangDAO.LayDanhSachChiTietNhapHang();
        }
        public static bool ThemCTNH(CHITIETNHAPHANG ctnh)
        {
            return CTNhapHangDAO.ThemCTNH(ctnh);
        }
        public static bool SuaCTNH(CHITIETNHAPHANG ctnh)
        {
            return CTNhapHangDAO.SuaCTNH(ctnh);
        }
        public static bool XoaCTNH(string manpp, string masp)
        {
            return CTNhapHangDAO.XoaCTNH(manpp, masp);
        }
    }
}
