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
    
    public partial class LICHSUTRANO
    {
        public int ID { get; set; }
        public string MACONGNO { get; set; }
        public System.DateTime NGAYTRA_THEODOI { get; set; }
        public Nullable<decimal> TIENTRA_THEODOI { get; set; }
        public bool TRANGTHAI { get; set; }
    
        public virtual CONGNO CONGNO { get; set; }
    }
}
