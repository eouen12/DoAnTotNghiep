using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
    }
}
// còn đối với nhiều control thì phải có panel chứa đám đó r mới chọn dock . cho dể chỉnh hả, um, ví dụ hóa đơn n
// nó k giống sp chỉ có mỗi datagridview còn lable này kia, nên t xem r lồng panel, còn không thì để thừa khoảng đó ra cũng dc, hơi xấu và lệch tí , cái hóa đơn nên thêm button xuất hóa đơn á 