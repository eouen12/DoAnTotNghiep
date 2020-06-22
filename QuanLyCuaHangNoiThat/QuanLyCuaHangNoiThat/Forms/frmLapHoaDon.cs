using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyCuaHangNoiThat.Forms
{
    public partial class frmLapHoaDon : Form
    {
        private List<SANPHAM> lstSanPham = new List<SANPHAM>();
        private List<HOADONBANHANG> lstHoaDon = new List<HOADONBANHANG>();
        private List<CTHOADONBANHANG> lstCTHD = new List<CTHOADONBANHANG>();
        private string mahd;
        private int maKH;
        private string maNV;
        private bool slHopLe = true;
        private bool dangThaoTac = false;
        public frmLapHoaDon(int makh, string manv)
        {
            InitializeComponent();
            maKH = makh;
            maNV = manv;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                TaoHoaDon(maKH.ToString(),maNV);

                TaoCTHoaDon();

                MessageBox.Show("Lập hóa đơn thành công !!!", "Thông báo");
                dangThaoTac = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnChonSP_Click(object sender, EventArgs e)
        {
            dangThaoTac = true;
            LoadDSCTHD();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(this.txtTimKiem.Text != string.Empty)
            {
                var kq = from sp in lstSanPham
                         where sp.TENSP.Contains(this.txtTimKiem.Text)
                         || sp.MASP.Contains(this.txtTimKiem.Text)
                         || sp.LOAISANPHAM.TENLOAI.Contains(this.txtTimKiem.Text)
                         || sp.NHAPHANPHOI.TENNPP.Contains(this.txtTimKiem.Text)
                         select new
                         {
                             sp.MASP,
                             sp.TENSP,
                             sp.SL_TON,
                             sp.GIABAN,
                             sp.LOAISANPHAM.TENLOAI,
                             sp.NHAPHANPHOI.TENNPP
                         };
                this.dgvDSSanPham.DataSource = kq.ToList();
                this.dgvDSSanPham.AutoSize = true;
                this.dgvDSSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            LoadDSSP();
        }


        private void dgvDSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dgvDSSanPham.CurrentRow.Selected)
            {
                this.btnChonSP.Enabled = true;
                this.txtSoLuong.Enabled = true;
            }
            else
            {
                this.btnChonSP.Enabled = false;
                this.txtSoLuong.Enabled = false;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuong_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(this.txtSoLuong.Text) > Convert.ToInt32(this.dgvDSSanPham.CurrentRow.Cells["SOLUONGTON"].Value) && this.txtSoLuong.Text != string.Empty)
            {
                slHopLe = false;
                errorProvider1.SetError(this.txtSoLuong, "Số lượng vượt giới hạn !!!");
                errorProvider1.SetIconAlignment(this.txtSoLuong, ErrorIconAlignment.MiddleRight);
            }
            else
            {
                slHopLe = true;
                errorProvider1.Clear();
            }
        }
        void LoadDSSP()
        {
            lstSanPham = SanPhamBUS.LayDanhSachSanPham();
            lstHoaDon = HoaDonBanHangBUS.LayDanhSachHoaDon();
            var kq = from sp in lstSanPham
                     select new
                     {
                         sp.MASP,
                         sp.TENSP,
                         sp.SL_TON,
                         sp.GIABAN,
                         sp.LOAISANPHAM.TENLOAI,
                         sp.NHAPHANPHOI.TENNPP
                     };
            this.dgvDSSanPham.DataSource = kq.ToList();
            this.dgvDSSanPham.AutoSize = true;
            this.dgvDSSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        void LoadDSCTHD()
        {
            if (!slHopLe)
            {
                return;
            }
            if (lstCTHD.Count == 0)
            {
                lstCTHD.Add(new CTHOADONBANHANG
                {
                    MASP = this.dgvDSSanPham.CurrentRow.Cells["MASP"].Value.ToString(),
                    SOLUONG = Convert.ToInt32(this.txtSoLuong.Text),
                    DONGIA = Convert.ToInt32(this.dgvDSSanPham.CurrentRow.Cells["GIABAN"].Value) * Convert.ToInt32(this.txtSoLuong.Text),
                    TRANGTHAI = true,
                });
            }
            else
            {
                for (int i = 0; i < lstCTHD.Count; i++)
                {
                    if (lstCTHD[i].MASP == this.dgvDSSanPham.CurrentRow.Cells["MASP"].Value.ToString())
                    {
                        if(lstCTHD[i].SOLUONG >= Convert.ToInt32(this.dgvDSSanPham.CurrentRow.Cells["SOLUONGTON"].Value))
                        {
                            MessageBox.Show("Số lượng sản phẩm vượt mức số lượng tồn !!!", "Thông báo");
                            return;
                        }
                        lstCTHD[i].SOLUONG += Convert.ToInt32(this.txtSoLuong.Text);
                        lstCTHD[i].DONGIA = Convert.ToInt32(this.dgvDSSanPham.CurrentRow.Cells["GIABAN"].Value) * lstCTHD[i].SOLUONG;
                        this.dgvDSChiTietHD.AutoGenerateColumns = false;
                        this.dgvDSChiTietHD.DataSource = lstCTHD.ToList();
                        this.lblTongTien.Text = Convert.ToInt32(lstCTHD.Sum(p => p.DONGIA)).ToString("#,##0");
                        return;
                    }
                }
                lstCTHD.Add(new CTHOADONBANHANG
                {
                    MASP = this.dgvDSSanPham.CurrentRow.Cells["MASP"].Value.ToString(),
                    SOLUONG = Convert.ToInt32(this.txtSoLuong.Text),
                    DONGIA = Convert.ToInt32(this.dgvDSSanPham.CurrentRow.Cells["GIABAN"].Value) * Convert.ToInt32(this.txtSoLuong.Text),
                    TRANGTHAI = true,
                });
            }
            this.dgvDSChiTietHD.AutoGenerateColumns = false;
            this.dgvDSChiTietHD.DataSource = lstCTHD.ToList();
            this.lblTongTien.Text = Convert.ToInt32(lstCTHD.Sum(p => p.DONGIA)).ToString("#,##0");
        }

        void TaoHoaDon(string makh, string manv)
        {
            mahd = lstHoaDon[lstHoaDon.Count - 1].MAHD.ToString();
            int somahd = Convert.ToInt32(mahd.Remove(0, 5)) + 1;
            mahd = "HD000" + somahd;
            HoaDonBanHangBUS.ThemHoaDon(new HOADONBANHANG
            {
                MAHD = mahd,
                MAKH = Convert.ToInt32(makh),
                NV_LAP_HD = manv,
                NGAYLAP = DateTime.Now,
                TONGTIEN = Convert.ToInt32(lstCTHD.Sum(p => p.DONGIA)),
                NGAYGIAO = this.dtNgayGiao.Value,
                TRANGTHAI = true
            });
        }

        void TaoCTHoaDon()
        {
            foreach(CTHOADONBANHANG ct in lstCTHD)
            {
                ct.MAHD = mahd;
                CTHoaDonBanHangBUS.ThemCTHoaDon(ct);
            }
        }

        private void frmLapHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dangThaoTac)
            {
                if(MessageBox.Show("Đang có sự thay đổi dữ liệu, bạn có chắc chứ ?", "Thông báo", 
                                    MessageBoxButtons.YesNo, 
                                    MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
            }
        }
    }
}
