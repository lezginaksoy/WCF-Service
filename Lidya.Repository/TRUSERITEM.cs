//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lidya.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRUSERITEM
    {
        public TRUSERITEM()
        {
            this.TCARTITMLIST = new HashSet<TCARTITMLIST>();
        }
    
        public long UIRID { get; set; }
        public string USRID { get; set; }
        public long ITMID { get; set; }
        public Nullable<decimal> NADETUIR { get; set; }
        public Nullable<decimal> NUNICUIR { get; set; }
        public Nullable<short> NDEALUIR { get; set; }
        public Nullable<short> NBUYDUIR { get; set; }
        public Nullable<short> NSELDUIR { get; set; }
        public Nullable<long> STRID { get; set; }
        public Nullable<decimal> NPRICUIR { get; set; }
        public Nullable<decimal> NBUYBUIR { get; set; }
        public Nullable<decimal> NFRNDBUIR { get; set; }
        public Nullable<short> BUSRPICK { get; set; }
        public Nullable<short> BRYNPICT { get; set; }
    
        public virtual ICollection<TCARTITMLIST> TCARTITMLIST { get; set; }
        public virtual TUSERLIST TUSERLIST { get; set; }
    }
}
