using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lidya.Models.ModelViews.Product
{
    class ProductPriceQuantityListUpdateOutputDVO
    {
        [DataMember]
        public List<ProductPriceQuantityUpdateOutputDVO> productPriceQuantityListOutputs { get; set; }
    }
}
