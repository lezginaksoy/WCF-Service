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
    
    public partial class TMSGTEMPLATE
    {
        public decimal MSTID { get; set; }
        public string TSUBJECT { get; set; }
        public string TBODY { get; set; }
        public string TDESC { get; set; }
        public decimal BACTIVE { get; set; }
        public System.DateTime TGENEMST { get; set; }
        public decimal MSMID { get; set; }
    
        public virtual TMSGMASTER TMSGMASTER { get; set; }
    }
}
