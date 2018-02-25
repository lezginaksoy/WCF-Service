using Lidya.Business.Interfaces;
using Lidya.Models;
using Lidya.Models.ModelViews;
using Lidya.Models.ModelViews.Order;
using Lidya.Repository;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lidya.Business
{
    public class ProductBusiness : IProductBusiness
    {
        
        private static readonly ILog log = LogManager.GetLogger(typeof(ProductBusiness));

        public List<ProductListOutputDVO> ProductList(ProductListInputDVO filter)
        {
            //check  
            //var t = memberBusiness.GetToken(filter.SecurityToken);
            //if (filter.SupplierId != 0)
            //{
            //    t.UserId = filter.SupplierId;
            //}


            using (ProductRepository db = new ProductRepository())
            {
                List<ProductListOutputDVO> productList = db.ProductList(filter, t);
                return productList;
            }
        }

        public ProductOutputDVO GetProductByID(ProductInputDVO productInfo)
        {
            //check
            //var t = memberBusiness.GetToken(productInfo.SecurityToken);
            //if (t == null)
            //{
            //    return new ProductOutputDVO { ResultCode = "-1", ResultDescription = "Oturum açmanız gerekmektedir!" };
            //}

            if (string.IsNullOrEmpty(productInfo.ProductID))
            {
                return new ProductOutputDVO { ResultCode = "10", ResultDescription = "KategoriID yazmanız gerekmektedir." };
            }

            using (ProductRepository db = new ProductRepository())
            {
                ProductOutputDVO Product = new ProductOutputDVO();

             
                    Product = db.GetProductByID(productInfo.ProductID, t);
                


                if (Product != null)
                {
                    return Product;
                }
                else
                {
                    return new ProductOutputDVO { ResultCode = "13", ResultDescription = "Ürün Kaydı bulunamadı!" };
                }
            }

        }


    }
}