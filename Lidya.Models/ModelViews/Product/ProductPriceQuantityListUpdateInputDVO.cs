using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Lidya.Models.ModelViews.Product
{
    class ProductPriceQuantityListUpdateInputDVO : InputBase
    {
        [DataMember]
        public List<ProductPriceQuantityUpdateInputDVO> products { get; set; }
    }
}