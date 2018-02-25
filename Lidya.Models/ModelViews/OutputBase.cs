using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lidya.Models.ModelViews
{
    public class OutputBase
    {
        [DataMember]
        public string ResultCode { get; set; }
        
        [DataMember]
        public string ResultDescription { get; set; }
    }
}
