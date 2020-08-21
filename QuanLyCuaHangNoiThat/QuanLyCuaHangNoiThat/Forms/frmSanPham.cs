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
using System.IO;
using System.Text.RegularExpressions;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmSanPham : Form
    {
        private string tenAnhMinhHoa;
        private string patch = @"..\..\..\..\Hinh_SanPham\";
        //private string patch = @"Hinh_SanPham\";
        private List<SANPHAM> lstSanPham = new List<SANPHAM>();
        private List<ANHMINHHOASP> lstAnhMinhHoa = new List<ANHMINHHOASP>();
        private List<LOAISANPHAM> lstLoaiSp = new List<LOAISANPHAM>();
        private List<NHAPHANPHOI> lstNhaPP = new List<NHAPHANPHOI>();
        private ANHMINHHOASP AMH = new ANHMINHHOASP();
        private bool dangThayDoiDL = false;
        private string manv;
        private string vitrithaotac = "Sản phẩm";
        private string vitrithaotacLoaiSP = "Loại sản phẩm";

        public frmSanPham(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadDataTabDSSP();

            LoadDataTabQLSP();

            LoadComboBoxData();

            FormatDataGridView();

            AutoCompleteMaLoai();

            AutoCompleteMaNPP();

            LoadDataDSLoaiSP();

            //this.txtMaSp.Text = AutoTaoMaSP();
        }
        void FormatDataGridView()
        {
            DataGridViewCellStyle styleTien = new DataGridViewCellStyle();
            styleTien.Format = "#,##0";
            this.dgvDSSanPham.Columns["GIABAN"].DefaultCellStyle = styleTien;
            this.dgvQLSanPham.Columns["GIABANQL"].DefaultCellStyle = styleTien;
        }

        /// <summary>
        /// Tab danh sach san pham
        /// </summary>
        void LoadDataTabDSSP()
        {
            lstSanPham = SanPhamBUS.LayDanhSachSanPham();
            lstNhaPP = NhaPhanPhoiBUS.LayDanhSachNhaPhanPhoi();
            lstAnhMinhHoa = AnhMinhHoaSPBUS.LayDanhSachAnhMinhHoa();
            //var kq = from sp in lstSanPham
            //         select new
            //         {
            //             sp.MASP,
            //             sp.TENSP,
            //             sp.SL_TON,
            //             sp.GIABAN,
            //             sp.DVT,
            //             sp.LOAISANPHAM.TENLOAI,
            //             sp.NHAPHANPHOI.TENNPP
            //         };
            var kq = from sp in lstSanPham
                     join npp in lstNhaPP
                     on sp.MANPP equals npp.MANPP
                     select new
                     {
                         sp.MASP,
                         sp.TENSP,
                         sp.SL_TON,
                         sp.GIABAN,
                         sp.DVT,
                         sp.LOAISANPHAM.TENLOAI,
                         npp.TENNPP
                     };
            this.dgvDSSanPham.DataSource = kq.ToList();
            this.dgvDSSanPham.AutoGenerateColumns = false;
        }

        void LoadComboBoxData()
        {
            this.cbDSLoaiSP.DataSource = LoaiSanPhamBUS.LayDanhSachLoaiSanPham();
            this.cbDSLoaiSP.DisplayMember = "TENLOAI";
            this.cbDSLoaiSP.ValueMember = "MALOAI";

            this.cbDSNPP.DataSource = NhaPhanPhoiBUS.LayDanhSachNhaPhanPhoi();
            this.cbDSNPP.DisplayMember = "TENNPP";
            this.cbDSNPP.ValueMember = "MANPP";

            this.cbQLTimKiemLoaiSP.DataSource = LoaiSanPhamBUS.LayDanhSachLoaiSanPham();
            this.cbQLTimKiemLoaiSP.DisplayMember = "TENLOAI";
            this.cbQLTimKiemLoaiSP.ValueMember = "MALOAI";

            this.cbQLTimKiemNPP.DataSource = NhaPhanPhoiBUS.LayDanhSachNhaPhanPhoi();
            this.cbQLTimKiemNPP.DisplayMember = "TENNPP";
            this.cbQLTimKiemNPP.ValueMember = "MANPP";
        }

        private void txtTimKiemDSSP_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTimKiemDSSP.Text != string.Empty)
            {
                TimKiemDSSP(this.txtTimKiemDSSP.Text);
            }
            else
            {
                LoadDataTabDSSP();
            }
        }

        void TimKiemDSSP(string chuoi)
        {
            var kq = from sp in lstSanPham
                     where sp.TENSP.Contains(chuoi)
                     || sp.MASP.Contains(chuoi)
                     || sp.MALOAI == chuoi
                     || sp.MANPP == chuoi
                     || sp.MALOAI.Contains(chuoi)
                     || sp.MANPP.Contains(chuoi)
                     || sp.LOAISANPHAM.TENLOAI.Contains(chuoi)
                     || sp.NHAPHANPHOI.TENNPP.Contains(chuoi)
                     select new
                     {
                         sp.MASP,
                         sp.TENSP,
                         sp.SL_TON,
                         sp.GIABAN,
                         sp.DVT,
                         sp.LOAISANPHAM.TENLOAI,
                         sp.NHAPHANPHOI.TENNPP
                     };

            //lstSanPham.Where(u => u.TENSP.Contains(chuoi) || u.MASP.Contains(chuoi) || u.MALOAI == chuoi || u.MANPP == chuoi).ToList();
            this.dgvDSSanPham.DataSource = kq.ToList();
            this.dgvDSSanPham.AutoSize = true;
            this.dgvDSSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void cbDSLoaiSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cbDSLoaiSP.SelectedIndex != -1)
            {
                TimKiemDSSP(this.cbDSLoaiSP.SelectedValue.ToString());
            }
        }

        private void cbDSNPP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cbDSNPP.SelectedIndex != -1)
            {
                TimKiemDSSP(this.cbDSNPP.SelectedValue.ToString());
            }
        }

        /// <summary>
        /// Tab Quan ly san pham
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void LoadDataTabQLSP()
        {

            lstSanPham = SanPhamBUS.LayDanhSachSanPham();
            lstNhaPP = NhaPhanPhoiBUS.LayDanhSachNhaPhanPhoi();
            lstLoaiSp = LoaiSanPhamBUS.LayDanhSachLoaiSanPham();
            lstAnhMinhHoa = AnhMinhHoaSPBUS.LayDanhSachAnhMinhHoa();
            //var kq = from sp in lstSanPham
            //         //join anhMH in lstAnhMinhHoa
            //         //on sp.MASP equals anhMH.MASP 
            //         select new
            //         {
            //             sp.MASP,
            //             sp.TENSP,
            //             sp.SL_TON,
            //             sp.GIABAN,
            //             sp.DVT,
            //             sp.LOAISANPHAM.TENLOAI,
            //             sp.NHAPHANPHOI.TENNPP,
            //             //anhMH.TENANHMINHHOA
            //         };

            var kq = from sp in lstSanPham
                     join npp in lstNhaPP on sp.MANPP equals npp.MANPP
                     join lsp in lstLoaiSp on sp.MALOAI equals lsp.MALOAI
                
                     select new
                     {
                         sp.MASP,
                         sp.TENSP,
                         sp.SL_TON,
                         sp.GIABAN,
                         sp.DVT,
                         lsp.TENLOAI,
                         npp.TENNPP
                     };
            this.dgvDSSanPham.AutoGenerateColumns = false;
            this.dgvQLSanPham.DataSource = kq.ToList();
            this.dgvQLSanPham.AutoSize = true;
            this.dgvQLSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        void TimKiemQLSP(string chuoi)
        {
            var kq = from sp in lstSanPham
                     where sp.TENSP.Contains(chuoi)
                     || sp.MASP.Contains(chuoi)
                     || sp.MALOAI == chuoi
                     || sp.MANPP == chuoi
                     || sp.MALOAI.Contains(chuoi)
                     || sp.MANPP.Contains(chuoi)
                     || sp.LOAISANPHAM.TENLOAI.Contains(chuoi)
                     || sp.NHAPHANPHOI.TENNPP.Contains(chuoi)
                     select new
                     {
                         sp.MASP,
                         sp.TENSP,
                         sp.SL_TON,
                         sp.GIABAN,
                         sp.DVT,
                         sp.LOAISANPHAM.TENLOAI,
                         sp.NHAPHANPHOI.TENNPP,
                     };
            this.dgvDSSanPham.AutoGenerateColumns = false;
            this.dgvQLSanPham.DataSource = kq.ToList();
            this.dgvQLSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void txtTimKiemQLSP_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTimKiemQLSP.Text != string.Empty)
            {
                TimKiemQLSP(this.txtTimKiemQLSP.Text);
            }
            else
            {
                LoadDataTabQLSP();
            }
        }

        private void cbQLTimKiemLoaiSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cbQLTimKiemLoaiSP.SelectedIndex != -1)
            {
                TimKiemQLSP(this.cbQLTimKiemLoaiSP.SelectedValue.ToString());
            }
        }

        private void cbQLTimKiemNPP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cbQLTimKiemNPP.SelectedIndex != -1)
            {
                TimKiemQLSP(this.cbQLTimKiemNPP.SelectedValue.ToString());
            }
        }

        private void dgvQLSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnSuaSP.Enabled = true;
            this.btnXoaSP.Enabled = true;
            this.btnThemSP.Enabled = false;
            this.txtMaSp.Enabled = false;
            this.dangThayDoiDL = true;
            this.txtMaSp.Text = this.dgvQLSanPham.CurrentRow.Cells["MASPQL"].Value.ToString();
            this.txtTenSP.Text = this.dgvQLSanPham.CurrentRow.Cells["TENSPQL"].Value.ToString();
            this.txtGiaBanSp.Text = Convert.ToDecimal(this.dgvQLSanPham.CurrentRow.Cells["GIABANQL"].Value).ToString("#,##");
            this.txtSLTonSp.Text = this.dgvQLSanPham.CurrentRow.Cells["SLTONQL"].Value.ToString();
            this.txtDVT.Text = this.dgvQLSanPham.CurrentRow.Cells["DVTQL"].Value.ToString();

            string tenLoai = this.dgvQLSanPham.CurrentRow.Cells["TENLOAIQL"].Value.ToString();
            string tenNPP = this.dgvQLSanPham.CurrentRow.Cells["TENNPPQL"].Value.ToString();
            this.txtLoaiSanPham.Text = lstLoaiSp.Where(p => p.TENLOAI == tenLoai).Select(p => p.MALOAI).FirstOrDefault();
            this.txtNhaPhanPhoi.Text = lstNhaPP.Where(p => p.TENNPP == tenNPP).Select(p => p.MANPP).FirstOrDefault();

            AMH = lstAnhMinhHoa.Where(p => p.MASP == this.txtMaSp.Text && p.TRANGTHAI == true).FirstOrDefault();
            try
            {
                if (AMH != null)
                {
                    this.imgSanPham.ImageLocation = patch + AMH.TENANHMINHHOA;
                }
                else
                {
                    this.imgSanPham.ImageLocation = null;
                }
            }
            catch
            {
                this.imgSanPham.ImageLocation = null;
            }
        }

        private void btnChonAnhMHSP_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(imgSanPham != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.png;)| *.jpg; *.jpeg; *.png; ";
                if(open.ShowDialog() == DialogResult.OK)
                {
                    imgSanPham.Image = Image.FromFile(open.FileName);
                    this.tenAnhMinhHoa = open.SafeFileName;
                }
            }
        }

        private void btnModeThem_Click(object sender, EventArgs e)
        {
            if (this.txtMaSp.Text == string.Empty
                || this.txtTenSP.Text == string.Empty
                || this.txtGiaBanSp.Text == string.Empty
                || this.txtSLTonSp.Text == string.Empty
                || this.txtDVT.Text == string.Empty
                || this.txtLoaiSanPham.Text == string.Empty
                || this.txtNhaPhanPhoi.Text == string.Empty
                || this.imgSanPham.Image == null)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            SANPHAM sanpham = new SANPHAM();
            sanpham.MASP = this.txtMaSp.Text;
            sanpham.TENSP = this.txtTenSP.Text;
            sanpham.GIABAN = Convert.ToInt32(this.txtGiaBanSp.Text);
            sanpham.SL_TON = Convert.ToInt32(this.txtSLTonSp.Text);
            sanpham.DVT = this.txtDVT.Text;
            sanpham.MALOAI = this.txtLoaiSanPham.Text;
            sanpham.MANPP = this.txtNhaPhanPhoi.Text;
            sanpham.TRANGTHAI = true;

            string maAnh = this.txtMaSp.Text + "_" + DateTime.Now.ToString("dd-MM-yy-h-m-s");
            string[] chuoiXuLiTenAnh = this.tenAnhMinhHoa.Split('.');
            this.tenAnhMinhHoa = this.txtMaSp.Text + "_" + DateTime.Now.ToString("dd-MM-yy-h-m-s") + "." + chuoiXuLiTenAnh[1];
            ANHMINHHOASP anhMH = new ANHMINHHOASP { MAANH = maAnh, TENANHMINHHOA = this.tenAnhMinhHoa, MASP = sanpham.MASP, TRANGTHAI = true };
            if(!SanPhamBUS.KiemTraMaSPTonTai(sanpham.MASP))
            {
                try
                {
                    SanPhamBUS.ThemSanPham(sanpham);
                    AnhMinhHoaSPBUS.ThemAnhMinhHoa(anhMH);

                    this.imgSanPham.Image.Save(patch + anhMH.TENANHMINHHOA);
                    MessageBox.Show("Thêm sản phẩm thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Reset();
                    LoadDataTabQLSP();
                    LoadDataTabDSSP();
                    string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm một sản phẩm (" + sanpham.MASP + ")";
                    LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                    {
                        NGAYTAO = DateTime.Now.Date,
                        NV_THAOTAC = this.manv,
                        VITRI_THAOTAC = this.vitrithaotac,
                        GHICHU = lsth
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }

        private void btnModeSua_Click(object sender, EventArgs e)
        {
            if (this.txtMaSp.Text == string.Empty
                || this.txtTenSP.Text == string.Empty
                || this.txtGiaBanSp.Text == string.Empty
                || this.txtSLTonSp.Text == string.Empty
                || this.txtDVT.Text == string.Empty
                || this.txtLoaiSanPham.Text == string.Empty
                || this.txtNhaPhanPhoi.Text == string.Empty
                || this.imgSanPham.Image == null)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (AMH != null)
            {
                if (this.tenAnhMinhHoa != AMH.TENANHMINHHOA && this.tenAnhMinhHoa != null)
                {
                    string[] chuoiXuLiTenAnh = this.tenAnhMinhHoa.Split('.');
                    tenAnhMinhHoa = this.txtMaSp.Text + "_" + DateTime.Now.ToString("dd-MM-yy-h-m-s") + "." + chuoiXuLiTenAnh[1];
                }
            }


            SANPHAM sanpham = new SANPHAM();
            sanpham.MASP = this.txtMaSp.Text;
            sanpham.TENSP = this.txtTenSP.Text;
            sanpham.GIABAN = Convert.ToDecimal(this.txtGiaBanSp.Text);
            sanpham.SL_TON = Convert.ToInt32(this.txtSLTonSp.Text);
            sanpham.DVT = this.txtDVT.Text;
            sanpham.MALOAI = this.txtLoaiSanPham.Text;
            sanpham.MANPP = this.txtNhaPhanPhoi.Text;

            if(SanPhamBUS.SuaSanPham(sanpham))
            {
                if (AMH != null)
                {
                    if (this.imgSanPham.ImageLocation == System.IO.Path.Combine(patch, AMH.TENANHMINHHOA) && this.tenAnhMinhHoa != null)
                    {
                        ANHMINHHOASP anhMinhHoa = AnhMinhHoaSPBUS.LayDanhSachAnhMinhHoa().Where(p => p.TENANHMINHHOA == AMH.TENANHMINHHOA).FirstOrDefault();
                        this.imgSanPham.Image.Save(System.IO.Path.Combine(patch + this.tenAnhMinhHoa));
                        AnhMinhHoaSPBUS.XoaAnhMinhHoa(anhMinhHoa.MAANH);
                        string maAnh = this.txtMaSp.Text + "_" + DateTime.Now.ToString("dd-MM-yy-h-m-s");
                        ANHMINHHOASP anhMH = new ANHMINHHOASP { MAANH = maAnh, TENANHMINHHOA = this.tenAnhMinhHoa, MASP = sanpham.MASP, TRANGTHAI = true };
                        AnhMinhHoaSPBUS.ThemAnhMinhHoa(anhMH);
                    }
                }
                else
                {
                    string maAnh = this.txtMaSp.Text + "_" + DateTime.Now.ToString("dd-MM-yy-h-m-s");
                    string[] chuoiXuLiTenAnh = this.tenAnhMinhHoa.Split('.');
                    this.tenAnhMinhHoa = this.txtMaSp.Text + "_" + DateTime.Now.ToString("dd-MM-yy-h-m-s") + "." + chuoiXuLiTenAnh[1];
                    ANHMINHHOASP anhMH = new ANHMINHHOASP
                    {
                        MAANH = maAnh,
                        TENANHMINHHOA = this.tenAnhMinhHoa,
                        MASP = sanpham.MASP,
                        TRANGTHAI = true
                    };
                    AnhMinhHoaSPBUS.ThemAnhMinhHoa(anhMH);
                    this.imgSanPham.Image.Save(patch + anhMH.TENANHMINHHOA);
                }
                Reset();
                LoadDataTabQLSP();
                LoadDataTabDSSP();
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật thông tin của sản phẩm " + sanpham.MASP;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotac,
                    GHICHU = lsth
                });
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin sản phẩm thất bại", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnModeXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chứ?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                SanPhamBUS.XoaSanPham(this.txtMaSp.Text);
                MessageBox.Show("Xóa sản phẩm thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Reset();
                LoadDataTabQLSP();
                LoadDataTabDSSP();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã xóa sản phẩm " + this.txtMaSp.Text;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotac,
                    GHICHU = lsth
                });
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtGiaBanSp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        void Reset()
        {
            this.imgSanPham.Image = null;
            this.txtMaSp.Clear();
            this.txtTenSP.Clear();
            this.txtGiaBanSp.Clear();
            this.txtSLTonSp.Clear();
            this.txtLoaiSanPham.Clear();
            this.txtNhaPhanPhoi.Clear();
            this.txtDVT.Clear();
            this.btnThemSP.Enabled = true;
            this.txtMaSp.Enabled = true;
            this.btnSuaSP.Enabled = false;
            this.btnXoaSP.Enabled = false;
            this.dangThayDoiDL = false;
        }

        private void txtSLTonSp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //string AutoTaoMaSP()
        //{
        //    List<SANPHAM> lstMaSP = SanPhamBUS.LayDanhSachSP();
        //    string ma = string.Empty;
        //    if (lstMaSP.Count == 0)
        //    {
        //        ma = "SP1";
        //        return ma;
        //    }
        //    else
        //    {
        //        ma = lstMaSP.Select(p => p.MASP).LastOrDefault();
        //        int automa = Convert.ToInt32(ma.Remove(0, 2)) + 1;
        //        ma = "SP" + automa;
        //        for (int i = 0; i < lstMaSP.Count(); i++)
        //        {
        //            if (ma == lstMaSP[i].MASP)
        //            {
        //                automa = Convert.ToInt32(ma.Remove(0, 2)) + 1;
        //                ma = "SP" + automa;
        //            }
        //        }
        //        return ma;
        //    }
        //}

        void AutoCompleteMaLoai()
        {
            lstLoaiSp = LoaiSanPhamBUS.LayDanhSachLoaiSanPham();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (LOAISANPHAM item in lstLoaiSp)
            {
                collection.Add(item.MALOAI);
            }
            this.txtLoaiSanPham.AutoCompleteCustomSource = collection;
            this.txtLoaiSanPham.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtLoaiSanPham.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        void AutoCompleteMaNPP()
        {
            lstNhaPP = NhaPhanPhoiBUS.LayDanhSachNhaPhanPhoi();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (NHAPHANPHOI item in lstNhaPP)
            {
                collection.Add(item.MANPP);
            }
            this.txtNhaPhanPhoi.AutoCompleteCustomSource = collection;
            this.txtNhaPhanPhoi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtNhaPhanPhoi.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dangThayDoiDL)
            {
                if (MessageBox.Show("Đang có sự thay đổi dữ liệu, bạn có chắc chứ ?", "Thông báo",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                    this.DialogResult = DialogResult.No;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void txtLoaiSanPham_Validated(object sender, EventArgs e)
        {
            if(this.txtLoaiSanPham.Text != string.Empty)
            {
                if(!LoaiSanPhamBUS.KiemTraMaLoaiTonTai(this.txtLoaiSanPham.Text))
                {
                    MessageBox.Show("Mã loại không tồn tại !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtLoaiSanPham.Focus();
                }
            }
        }

        private void txtNhaPhanPhoi_Validated(object sender, EventArgs e)
        {
            if (this.txtNhaPhanPhoi.Text != string.Empty)
            {
                if (!NhaPhanPhoiBUS.KiemTraMaNPPTonTai(this.txtNhaPhanPhoi.Text))
                {
                    MessageBox.Show("Mã nhà phân phối không tồn tại !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNhaPhanPhoi.Focus();
                }
            }
        }

        private void btnThemLoaiSP_Click(object sender, EventArgs e)
        {
            if (this.txtMaLoai.Text == string.Empty || this.txtTenLoaiSP.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            LOAISANPHAM loaisp = new LOAISANPHAM { MALOAI = this.txtMaLoai.Text, TENLOAI = this.txtTenLoaiSP.Text, TRANGTHAI = true };
            if (LoaiSanPhamBUS.ThemLoaiSanPham(loaisp))
            {
                MessageBox.Show("Thêm loại sản phẩm thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDataDSLoaiSP();
                AutoCompleteMaLoai();
                LoadComboBoxData();
                ResetTabQLLoaiSP();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm mới loại sản phẩm " + loaisp.MALOAI;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotacLoaiSP,
                    GHICHU = lsth
                });
            }
            else
            {
                MessageBox.Show("Thêm loại sản phẩm thất bại!!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSuaLoaiSP_Click(object sender, EventArgs e)
        {
            if (this.txtTenLoaiSP.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LOAISANPHAM loaisp = new LOAISANPHAM();
            loaisp.MALOAI = this.txtMaLoai.Text;
            loaisp.TENLOAI = this.txtTenLoaiSP.Text;
            if (LoaiSanPhamBUS.SuaLoaiSanPham(loaisp))
            {
                MessageBox.Show("Cập nhật thông tin loại sản phẩm thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDataDSLoaiSP();
                AutoCompleteMaLoai();
                LoadComboBoxData();
                ResetTabQLLoaiSP();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật thông tin loại sản phẩm " + loaisp.MALOAI;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotacLoaiSP,
                    GHICHU = lsth
                });
            }
            else
            {
                MessageBox.Show("Sửa loại sản phẩm thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaLoaiSP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                LoaiSanPhamBUS.XoaLoaiSanPham(this.txtMaLoai.Text);
                MessageBox.Show("Xóa loại sản phẩm thành công !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDataDSLoaiSP();
                AutoCompleteMaLoai();
                LoadComboBoxData();
                ResetTabQLLoaiSP();
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã xóa thông tin loại sản phẩm " + this.txtMaLoai.Text;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG
                {
                    NGAYTAO = DateTime.Now.Date,
                    NV_THAOTAC = this.manv,
                    VITRI_THAOTAC = this.vitrithaotacLoaiSP,
                    GHICHU = lsth
                });
            }
        }

        private void btnHuyboLoaiSP_Click(object sender, EventArgs e)
        {
            ResetTabQLLoaiSP();
        }

        private void txtTimKiemLoaiSP_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTimKiemLoaiSP.Text != string.Empty)
            {
                TimKiemLoaiSanPham(this.txtTimKiemLoaiSP.Text);
            }
            else
            {
                LoadDataDSLoaiSP();
            }
        }

        private void dgvDsLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnThemLoaiSP.Enabled = false;
            this.btnSuaLoaiSP.Enabled = true;
            this.btnXoaLoaiSP.Enabled = true;
            this.txtMaLoai.Enabled = false;
            this.dangThayDoiDL = true;
            this.txtMaLoai.Text = this.dgvDsLoaiSP.CurrentRow.Cells["MALOAI"].Value.ToString();
            this.txtTenLoaiSP.Text = this.dgvDsLoaiSP.CurrentRow.Cells["TENLOAI"].Value.ToString();
        }
        void LoadDataDSLoaiSP()
        {
            lstLoaiSp = LoaiSanPhamBUS.LayDanhSachLoaiSanPham();
            this.dgvDsLoaiSP.AutoGenerateColumns = false;
            this.dgvDsLoaiSP.DataSource = lstLoaiSp;
        }

        void TimKiemLoaiSanPham(string chuoi)
        {
            var kq = from loai in lstLoaiSp
                     where loai.MALOAI.Contains(chuoi) || loai.TENLOAI.Contains(chuoi)
                     select loai;
            this.dgvDsLoaiSP.AutoGenerateColumns = false;
            this.dgvDsLoaiSP.DataSource = kq.ToList();
        }

        void ResetTabQLLoaiSP()
        {
            this.txtMaLoai.Clear();
            this.txtTenLoaiSP.Clear();
            this.txtMaLoai.Focus();
            this.txtMaLoai.Enabled = true;
            this.btnThemLoaiSP.Enabled = true;
            this.btnSuaLoaiSP.Enabled = false;
            this.btnXoaLoaiSP.Enabled = false;
        }

        private void txtMaLoai_Validated(object sender, EventArgs e)
        {
            if(this.txtMaLoai.Text != string.Empty)
            {
                var kq = LoaiSanPhamBUS.LayDanhSachMaLoai().Where(p => p.MALOAI == this.txtMaLoai.Text).FirstOrDefault();
                if (kq != null)
                {
                    MessageBox.Show("Mã loại đã tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtMaLoai.Focus();
                    return;
                }
                if (this.txtMaLoai.Text == string.Empty)
                {
                    return;
                }
                if(this.txtMaLoai.Text.Length >10)
                {
                    MessageBox.Show("Mã loại không được vượt quá 10 kí tự !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtMaLoai.Focus();
                    return;
                }    
                if (!KiemtraDinhDangMALOAI(this.txtMaLoai.Text))
                {
                    MessageBox.Show("Mã loại không đúng định dạng !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtMaLoai.Focus();
                    return;
                }
            }
        }

        private void txtMaSp_Validated(object sender, EventArgs e)
        {
            if(SanPhamBUS.KiemTraMaSPTonTai(this.txtMaSp.Text))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMaSp.Focus();
                return;
            }
            if (this.txtMaSp.Text == string.Empty)
            {
                return;
            }
            if(this.txtMaSp.Text.Length > 10)
            {
                MessageBox.Show("Mã sản phẩm không được vượt quá 10 kí tự !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMaSp.Focus();
                return;
            }    
            if (!KiemtraDinhDangMASP(this.txtMaSp.Text))
            {
                MessageBox.Show("Mã sản phẩm không đúng định dạng !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMaSp.Focus();
                return;
            }
        }

        bool KiemtraDinhDangMASP(string masp)
        {
            Regex re = new Regex("^[a-zA-Z0-9]{2,10}$");
            if (re.IsMatch(masp))
                return (true);
            else
                return (false);
        }
        bool KiemtraDinhDangMALOAI(string maloai)
        {
            Regex re = new Regex("^[a-zA-Z0-9]{2,10}$");
            if (re.IsMatch(maloai))
                return (true);
            else
                return (false);
        }
    }
}