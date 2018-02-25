using Lidya.Models;
using Lidya.Models.ModelViews;
using Lidya.Models.ModelViews.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidya.Business.Interfaces
{
    public interface IProductBusiness
    {
        List<ProductListOutputDVO> ProductList(ProductListInputDVO filter);
        ProductOutputDVO GetProductByID(ProductInputDVO productInfo);

        
    }
}
