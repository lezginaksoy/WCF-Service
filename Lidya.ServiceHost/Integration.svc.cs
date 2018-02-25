using Autofac.Integration.Wcf;
using Lidya.Business.Interfaces;
using Lidya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Autofac;
using Lidya.Models.ModelViews;
//using Lidya.Models.ModelViews.Category;
//using Lidya.Models.ModelViews.Order;
//using Lidya.Models.ModelViews.Media;
//using Lidya.Models.ModelViews.Return;
//using Lidya.Models.ModelViews.Payment;
//using Lidya.Models.ModelViews.Managment;

namespace Lidya.ServiceHost
{
    public class Integration : IIntegration
    {
        //private ICoreBusiness coreBusiness { get; set; }
        //private ICategoryBusiness categoryBusiness { get; set; }
        //private IMemberBusiness memberBusiness { get; set; }
        private IProductBusiness productBusiness { get; set; }
        

        public Integration()
        {
            //this.coreBusiness = AutofacHostFactory.Container.Resolve<ICoreBusiness>();
            //this.categoryBusiness = AutofacHostFactory.Container.Resolve<ICategoryBusiness>();
            //this.memberBusiness = AutofacHostFactory.Container.Resolve<IMemberBusiness>();
            this.productBusiness = AutofacHostFactory.Container.Resolve<IProductBusiness>();
            
        }
        
        #region Members

        //public AuthenticateUserOutputDVO AuthenticateUser(AuthenticateUserInputDVO userInfo)
        //{
        //    return memberBusiness.AuthenticateUser(userInfo);
        //}
        //public AuthenticatePortalOutputDVO AuthenticatePortal(AuthenticatePortalInputDVO userInfo)
        //{
        //    return memberBusiness.AuthenticatePortal(userInfo);
        //}
        //public SupplierOutputDVO GetSupplier(SupplierInputDVO supplierInfo)
        //{
        //    return memberBusiness.GetSupplier(supplierInfo);
        //}
  
        #endregion

  
        #region Categories

        //public CategoryUpdateOutputDVO CategoryUpdate(CategoryUpdateInputDVO categoryInfo)
        //{
        //    return categoryBusiness.CategoryUpdate(categoryInfo);
        //}

        //public CategoryOutputDVO GetCategoryByID(CategoryInputDVO categoryInfo)
        //{
        //    return categoryBusiness.GetCategoryByID(categoryInfo);
        //}


        #endregion

        #region Products

        public List<ProductListOutputDVO> ProductList(ProductListInputDVO filter)
        {
            return productBusiness.ProductList(filter);
        }

        public ProductOutputDVO GetProductByID(ProductInputDVO productInfo)
        {
            return productBusiness.GetProductByID(productInfo);
        }


        //public ProductSearchOutputDVO ProductSearch(ProductSearchInputDVO filter)
        //{
        //    return productBusiness.ProductSearch(filter);
        //}


        //public ProductUpdateOutputDVO ProductUpdate(ProductUpdateInputDVO productInfo)
        //{
        //    return productBusiness.ProductUpdate(productInfo);
        //}

        //public ProductDescriptionUpdateOutputDVO ProductDescriptionUpdate(ProductDescriptionUpdateInputDVO productInfo)
        //{
        //    return productBusiness.ProductDescriptionUpdate(productInfo);
        //}
        
        #endregion

        #region Orders

        //public NotIntegratedOrderListOutputDVO GetNotIntegratedOrderList(NotIntegratedOrderListInputDVO orderList)
        //{
        //    return orderBusiness.GetNotIntegratedOrderList(orderList);
        //}

        //public List<OrderHeaderDVO> GetOrderProducts(AllOrderListInputDVO input)
        //{
        //    return orderBusiness.GetOrderProducts(input);
        //}

        //public NotIntegratedOrderCodeListOutputDVO GetNotIntegratedOrderCodeList(NotIntegratedOrderCodeListInputDVO orderList)
        //{
        //    return orderBusiness.GetNotIntegratedOrderCodeList(orderList);
        //}
        
        #endregion

 


    }
}
