using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidya.Models.ModelViews.Product
{
    class ProductPriceQuantityUpdateInputDVO:InputBase 
    {
        public string ProductID { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
