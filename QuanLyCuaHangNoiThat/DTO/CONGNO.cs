//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONGNO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONGNO()
        {
            this.LICHSUTRANO = new HashSet<LICHSUTRANO>();
        }
    
        public string MACONGNO { get; set; }
        public string MAKH { get; set; }
        public string MAHD { get; set; }
        public string NV_LAPCN { get; set; }
        public Nullable<System.DateTime> NGAYLAP { get; set; }
        public Nullable<decimal> TONGTIEN { get; set; }
        public Nullable<decimal> TIENCONNO { get; set; }
        public Nullable<System.DateTime> NGAYTRA { get; set; }
        public bool TRANGTHAI { get; set; }
    
        public virtual HOADONBANHANG HOADONBANHANG { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHSUTRANO> LICHSUTRANO { get; set; }
    }
}
