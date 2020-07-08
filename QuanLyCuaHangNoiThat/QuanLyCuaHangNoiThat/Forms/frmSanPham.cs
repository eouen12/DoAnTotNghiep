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

namespace QuanLyCuaHangNoiThat
{
    public partial class frmSanPham : Form
    {
        private string tenAnhMinhHoa;
        private string patch = @"..\..\..\..\Hinh_SanPham\";
        private List<SANPHAM> lstSanPham = new List<SANPHAM>();
        private List<ANHMINHHOASP> lstAnhMinhHoa = new List<ANHMINHHOASP>();
        private ANHMINHHOASP AMH = new ANHMINHHOASP();
        private bool dangThayDoiDL = false;
        private string manv;

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

            this.txtMaSp.Text = AutoTaoMaSP();
        }


        /// <summary>
        /// Tab danh sach san pham
        /// </summary>
        void LoadDataTabDSSP()
        {
            lstSanPham = SanPhamBUS.LayDanhSachSanPham();
            lstAnhMinhHoa = AnhMinhHoaSPBUS.LayDanhSachAnhMinhHoa();
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

            this.cbLoaiSp.DataSource = LoaiSanPhamBUS.LayDanhSachLoaiSanPham();
            this.cbLoaiSp.DisplayMember = "TENLOAI";
            this.cbLoaiSp.ValueMember = "MALOAI";

            this.cbNPPSp.DataSource = NhaPhanPhoiBUS.LayDanhSachNhaPhanPhoi();
            this.cbNPPSp.DisplayMember = "TENNPP";
            this.cbNPPSp.ValueMember = "MANPP";

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
            lstAnhMinhHoa = AnhMinhHoaSPBUS.LayDanhSachAnhMinhHoa();
            var kq = from sp in lstSanPham
                     //join anhMH in lstAnhMinhHoa
                     //on sp.MASP equals anhMH.MASP 
                     select new
                     {
                         sp.MASP,
                         sp.TENSP,
                         sp.SL_TON,
                         sp.GIABAN,
                         sp.LOAISANPHAM.TENLOAI,
                         sp.NHAPHANPHOI.TENNPP,
                         //anhMH.TENANHMINHHOA
                     };
            this.dgvDSSanPham.AutoGenerateColumns = false;
            this.dgvQLSanPham.DataSource = kq.ToList();
            this.dgvQLSanPham.AutoSize = true;
            this.dgvQLSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        void TimKiemQLSP(string chuoi)
        {
            var kq = from sp in lstSanPham
                     join anhMH in lstAnhMinhHoa
                     on sp.MASP equals anhMH.MASP
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
                         sp.LOAISANPHAM.TENLOAI,
                         sp.NHAPHANPHOI.TENNPP,
                         anhMH.TENANHMINHHOA
                     };
            this.dgvDSSanPham.AutoGenerateColumns = false;
            this.dgvQLSanPham.DataSource = kq.ToList();
            this.dgvQLSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        void Reset()
        {
            this.imgSanPham.Image = null;
            this.txtMaSp.Text = AutoTaoMaSP();
            this.txtTenSP.Clear();
            this.txtGiaBanSp.Clear();
            this.txtSLTonSp.Clear();
            this.btnThemSP.Enabled = true;
            this.btnSuaSP.Enabled = false;
            this.btnXoaSP.Enabled = false;
            this.dangThayDoiDL = false;
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
            this.dangThayDoiDL = true;
            this.txtMaSp.Text = this.dgvQLSanPham.CurrentRow.Cells["MASPQL"].Value.ToString();
            this.txtTenSP.Text = this.dgvQLSanPham.CurrentRow.Cells["TENSPQL"].Value.ToString();
            this.txtGiaBanSp.Text = this.dgvQLSanPham.CurrentRow.Cells["GIABANQL"].Value.ToString();
            this.txtSLTonSp.Text = this.dgvQLSanPham.CurrentRow.Cells["SLTONQL"].Value.ToString();

            AMH = lstAnhMinhHoa.Where(p => p.MASP == this.txtMaSp.Text && p.TRANGTHAI == true).FirstOrDefault();
            try
            {
                this.imgSanPham.ImageLocation = patch + AMH.TENANHMINHHOA;
            }
            catch
            {
                this.imgSanPham.ImageLocation = null;
            }
            //this.cbLoaiSp.SelectedItem = this.dgvQLSanPham.CurrentRow.Cells["TENLOAIQL"].Value.ToString();
            //this.cbNPPSp.SelectedItem = this.dgvQLSanPham.CurrentRow.Cells["TENNPPQL"].Value.ToString();
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
            if( this.txtTenSP.Text == string.Empty
                || this.txtGiaBanSp.Text == string.Empty
                || this.txtSLTonSp.Text == string.Empty
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
            sanpham.MALOAI = this.cbLoaiSp.SelectedValue.ToString();
            sanpham.MANPP = this.cbNPPSp.SelectedValue.ToString();
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
                    string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã thêm một sản phẩm (" + sanpham.MASP + ")";
                    LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
                    Reset();
                    LoadDataTabQLSP();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }

        }

        private void btnModeSua_Click(object sender, EventArgs e)
        {
            if (this.txtTenSP.Text == string.Empty
                || this.txtGiaBanSp.Text == string.Empty
                || this.txtSLTonSp.Text == string.Empty
                || this.imgSanPham.Image == null)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.tenAnhMinhHoa != AMH.TENANHMINHHOA && this.tenAnhMinhHoa != null)
            {
                string[] chuoiXuLiTenAnh = this.tenAnhMinhHoa.Split('.');
                tenAnhMinhHoa = this.txtMaSp.Text + "_" + DateTime.Now.ToString("dd-MM-yy-h-m-s") + "." + chuoiXuLiTenAnh[1];
            }


            SANPHAM sanpham = new SANPHAM();
            sanpham.MASP = this.txtMaSp.Text;
            sanpham.TENSP = this.txtTenSP.Text;
            sanpham.GIABAN = Convert.ToInt32(this.txtGiaBanSp.Text);
            sanpham.SL_TON = Convert.ToInt32(this.txtSLTonSp.Text);
            sanpham.MALOAI = this.cbLoaiSp.SelectedValue.ToString();
            sanpham.MANPP = this.cbNPPSp.SelectedValue.ToString();

            if(SanPhamBUS.SuaSanPham(sanpham))
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
                //else
                //{
                //    this.imgSanPham.Image.Save(System.IO.Path.Combine(patch + this.tenAnhMinhHoa));
                //    //AnhMinhHoaSPBUS.XoaAnhMinhHoa(anhMinhHoa.MAANH);
                //    string maAnh = this.txtMaSp.Text + "_" + DateTime.Now.ToString("dd-MM-yy-h-m-s");
                //    ANHMINHHOASP anhMH = new ANHMINHHOASP { MAANH = maAnh, TENANHMINHHOA = this.tenAnhMinhHoa, MASP = sanpham.MASP, TRANGTHAI = true };
                //    AnhMinhHoaSPBUS.ThemAnhMinhHoa(anhMH);
                //}
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã cập nhật thông tin của sản phẩm " + sanpham.MASP;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
                Reset();
                LoadDataTabQLSP();
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
                string lsth = "[" + DateTime.Now.ToString("dd/MM/yyyy-h:m:s") + "] " + this.manv + " đã xóa sản phẩm " + this.txtMaSp.Text;
                LichSuHeThongBUS.ThemLSHT(new LICHSUHETHONG { GHICHU = lsth });
                Reset();
                LoadDataTabQLSP();
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

        private void txtSLTonSp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        string AutoTaoMaSP()
        {
            string masp = lstSanPham.Select(p => p.MASP).LastOrDefault();
            int automa = Convert.ToInt32(masp.Remove(0, 2)) + 1;
            return "SP" + automa;
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
    }
}