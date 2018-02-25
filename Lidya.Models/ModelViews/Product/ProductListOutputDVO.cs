using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lidya.Models.ModelViews
{
    public class ProductListOutputDVO : OutputBase
    {
        [DataMember]
        public string ProductID { get; set; }

        [DataMember]
        public string ProductCode { get; set; }

        [DataMember]
        public string ColorGroupCode { get; set; }

        [DataMember]
        public string ProductName { get; set; }

        [DataMember]
        public decimal? Price { get; set; }

        [DataMember]
        public int PageCount { get; set; }
    }
}