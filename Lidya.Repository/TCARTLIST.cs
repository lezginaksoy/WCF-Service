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
    
    public partial class TCARTLIST
    {
        public TCARTLIST()
        {
            this.TCARTITMLIST = new HashSet<TCARTITMLIST>();
            this.TCARTPYMNT = new HashSet<TCARTPYMNT>();
        }
    
        public decimal CARTID { get; set; }
        public string USRID { get; set; }
        public Nullable<decimal> SHIPADDRID { get; set; }
        public Nullable<decimal> INVADDRID { get; set; }
        public Nullable<decimal> NTOTALPROD { get; set; }
        public Nullable<decimal> NTOTALCARGO { get; set; }
        public Nullable<decimal> NDISCARGO { get; set; }
        public Nullable<decimal> NCARGOAMNT { get; set; }
        public Nullable<decimal> NTOTALAMNT { get; set; }
        public string TREFNTRX { get; set; }
        public Nullable<decimal> NCASHADV { get; set; }
        public Nullable<decimal> NLIDYAADV { get; set; }
        public decimal BUSEBAL { get; set; }
        public Nullable<decimal> BNKID { get; set; }
        public Nullable<decimal> NINST { get; set; }
        public Nullable<decimal> NCASHPYMT { get; set; }
        public Nullable<decimal> NLDYPYMT { get; set; }
        public Nullable<decimal> NCARDPYMT { get; set; }
        public decimal CSTATCART { get; set; }
        public Nullable<System.DateTime> DDATECREATE { get; set; }
        public Nullable<System.DateTime> DDATESHIP { get; set; }
        public Nullable<System.DateTime> DDATEEXP { get; set; }
        public decimal USELIDYA { get; set; }
        public Nullable<decimal> NPYMNTCARD { get; set; }
        public Nullable<decimal> NPYMNTCASH { get; set; }
        public Nullable<decimal> NPYMNTLIDYA { get; set; }
        public string TMODIUSR { get; set; }
        public Nullable<System.DateTime> DMODICART { get; set; }
        public Nullable<decimal> BMAILSENT { get; set; }
        public Nullable<decimal> NTRYCOUNT { get; set; }
        public Nullable<decimal> BNKOID { get; set; }
        public string TNOTE { get; set; }
        public string TPRCHCODE { get; set; }
        public Nullable<decimal> NRETAMNT { get; set; }
        public Nullable<decimal> NDISCOUNT { get; set; }
    
        public virtual TADDRLIST TADDRLIST { get; set; }
        public virtual TADDRLIST TADDRLIST1 { get; set; }
        public virtual ICollection<TCARTITMLIST> TCARTITMLIST { get; set; }
        public virtual TUSERLIST TUSERLIST { get; set; }
        public virtual ICollection<TCARTPYMNT> TCARTPYMNT { get; set; }
    }
}
