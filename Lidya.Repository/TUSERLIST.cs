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
    
    public partial class TUSERLIST
    {
        public TUSERLIST()
        {
            this.TADDRLIST = new HashSet<TADDRLIST>();
            this.TCARTITMLIST = new HashSet<TCARTITMLIST>();
            this.TCARTLIST = new HashSet<TCARTLIST>();
            this.TRUSERITEM = new HashSet<TRUSERITEM>();
        }
    
        public string USRID { get; set; }
        public Nullable<short> CTYPEUSR { get; set; }
        public string TNICKUSR { get; set; }
        public string TNAMEUSR { get; set; }
        public string TMAILUSR { get; set; }
        public string TMOBIUSR { get; set; }
        public Nullable<decimal> LONGITUDE { get; set; }
        public Nullable<decimal> LATITUDE { get; set; }
        public Nullable<short> CSTATUSR { get; set; }
        public Nullable<short> CLANGUSR { get; set; }
        public Nullable<long> NRANKUSR { get; set; }
        public Nullable<decimal> NUSDBUSR { get; set; }
        public Nullable<decimal> NLDYAUSR { get; set; }
        public string TIBAN { get; set; }
        public Nullable<decimal> BSHOWPIC { get; set; }
        public Nullable<short> NCURRUSR { get; set; }
        public string TLASTNAME { get; set; }
        public Nullable<System.DateTime> DDATEBIRTH { get; set; }
        public string TCOUNCODE { get; set; }
        public string TUNIQUEID { get; set; }
        public string TPASSWORD { get; set; }
        public Nullable<decimal> CTITLE { get; set; }
        public string FBID { get; set; }
        public string TFULLNAME { get; set; }
        public Nullable<decimal> SUPID { get; set; }
        public Nullable<System.DateTime> DMODIDATE { get; set; }
        public string TMODIUSR { get; set; }
        public Nullable<System.DateTime> DRECDATE { get; set; }
    
        public virtual ICollection<TADDRLIST> TADDRLIST { get; set; }
        public virtual ICollection<TCARTITMLIST> TCARTITMLIST { get; set; }
        public virtual ICollection<TCARTLIST> TCARTLIST { get; set; }
        public virtual ICollection<TRUSERITEM> TRUSERITEM { get; set; }
    }
}