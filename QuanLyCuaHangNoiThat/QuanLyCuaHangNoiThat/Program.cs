using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangNoiThat.Forms;

namespace QuanLyCuaHangNoiThat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDangNhap frmDangNhap = new frmDangNhap();
            if (frmDangNhap.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMenu(frmDangNhap.nv));
            }
            //Application.Run(new frmCongNo("NV_MINHNHUT"));
        }
    }
}

