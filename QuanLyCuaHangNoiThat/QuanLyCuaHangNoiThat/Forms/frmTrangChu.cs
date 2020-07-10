using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyCuaHangNoiThat.Forms
{
    public partial class frmTrangChu : Form
    {
        private List<CONGNO> lstCongNo = new List<CONGNO>();
        private List<KHACHHANG> lstKhachhang = new List<KHACHHANG>();
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void dateNgayThang_ValueChanged(object sender, EventArgs e)
        {
            LoadDSCNTheoThang(this.dateNgayThang.Value);
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            LoadDSCNTheoThang(DateTime.Now);
        }

        void FormatDataGridView()
        {
            this.dgvDSCongNo.Columns["TONGTIEN"].DefaultCellStyle.Format = "#,##0";
            this.dgvDSCongNo.Columns["TIENCONNO"].DefaultCellStyle.Format = "#,##0";
            this.dgvDSCongNo.Columns["NGAYTRA"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        void LoadDSCNTheoThang(DateTime dt)
        {
            lstKhachhang = KhachHangBUS.LayDanhSachKhachHang();
            lstCongNo = CongNoBUS.LayDanhSachCongNo();
            var kq = from cn in lstCongNo
                     join kh in lstKhachhang
                     on cn.MAKH equals kh.MAKH
                     where cn.NGAYTRA.Value.Month == dt.Month
                     select new
                     {
                         cn.MACONGNO,
                         cn.MAKH,
                         kh.TENKH,
                         cn.TONGTIEN,
                         cn.TIENCONNO,
                         cn.NGAYTRA,
                     };
            this.dgvDSCongNo.DataSource = kq.ToList();
            this.dgvDSCongNo.AutoGenerateColumns = false;
            FormatDataGridView();
        }
    }
}
