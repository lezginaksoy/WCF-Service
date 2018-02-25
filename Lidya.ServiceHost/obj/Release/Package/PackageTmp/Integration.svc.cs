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
using Lidya.Models.ModelViews.Category;
using Lidya.Models.ModelViews.Order;
using Lidya.Models.ModelViews.Media;
using Lidya.Models.ModelViews.Return;
using Lidya.Models.ModelViews.Payment;
using Lidya.Models.ModelViews.Managment;

namespace Lidya.ServiceHost
{
    public class Integration : IIntegration
    {
        private ICoreBusiness coreBusiness { get; set; }
        private ICategoryBusiness categoryBusiness { get; set; }
        private IMemberBusiness memberBusiness { get; set; }
        private IProductBusiness productBusiness { get; set; }
        private IOrderBusiness orderBusiness { get; set; }
        private IMediaBusiness mediaBusiness { get; set; }
        private IReturnBusiness returnBusiness { get; set; }
        private IXmlBusiness xmlBusiness { get; set; }
        private IAdminProccesBusiness adminProccesBusiness { get; set; }

        public Integration()
        {
            this.coreBusiness = AutofacHostFactory.Container.Resolve<ICoreBusiness>();
            this.categoryBusiness = AutofacHostFactory.Container.Resolve<ICategoryBusiness>();
            this.memberBusiness = AutofacHostFactory.Container.Resolve<IMemberBusiness>();
            this.productBusiness = AutofacHostFactory.Container.Resolve<IProductBusiness>();
            this.orderBusiness = AutofacHostFactory.Container.Resolve<IOrderBusiness>();
            this.mediaBusiness = AutofacHostFactory.Container.Resolve<IMediaBusiness>();
            this.returnBusiness = AutofacHostFactory.Container.Resolve<IReturnBusiness>();
            this.xmlBusiness = AutofacHostFactory.Container.Resolve<IXmlBusiness>();
            //this.adminProccesBusiness = AutofacHostFactory.Container.Resolve<IAdminProccesBusiness>();
        }

        #region Media

        public List<MediaOutputDVO> GetMediaListBySryId(MediaInputDVO input)
        {
            return mediaBusiness.GetMediaListBySryId(input);
        }

        public List<MediaOutputDVO> GetMediaListByColGrp(MediaInputDVO input)
        {
            return mediaBusiness.GetMediaListByColGrp(input);
        }
        public bool ProductImageProcess(MediaDVO media, string SecurityToken)
        {
            return mediaBusiness.ProductImageProcess(media, SecurityToken);
        }

        public bool CategoryImageProcess(MediaDVO media, string SecurityToken)
        {
            return mediaBusiness.CategoryImageProcess(media, SecurityToken);
        }

        public bool InsertMediaQueue(MediaDVO mediaInput, string securityToken)
        {
            return mediaBusiness.InsertMediaQueue(mediaInput, securityToken);
        }

        public MediaInsertOutputDVO InsertListToMediaQueue(List<MediaDVO> mediaInput, string securityToken)
        {
            return mediaBusiness.InsertListToMediaQueue(mediaInput, securityToken);
        }

        public List<BannerOutPutDVO> GetBanners(BannerInPutDVO input)
        {
            return mediaBusiness.GetBanners(input);
        }

        #endregion

        #region Members

        public AuthenticateUserOutputDVO AuthenticateUser(AuthenticateUserInputDVO userInfo)
        {
            return memberBusiness.AuthenticateUser(userInfo);
        }
        public AuthenticatePortalOutputDVO AuthenticatePortal(AuthenticatePortalInputDVO userInfo)
        {
            return memberBusiness.AuthenticatePortal(userInfo);
        }
        public SupplierOutputDVO GetSupplier(SupplierInputDVO supplierInfo)
        {
            return memberBusiness.GetSupplier(supplierInfo);
        }
        public SupplierOutputDVO GetSupplierForUpdate(SupplierInputDVO supplierInput)
        {
            return memberBusiness.GetSupplierForUpdate(supplierInput);
        }
        public SupplierOutputDVO GetSupplierForPortal(SupplierInputDVO supplierInfo)
        {
            return memberBusiness.GetSupplierForPortal(supplierInfo);
        }
        public List<SupplierListOutputDVO> SupplierList(SupplierListInputDVO SupInput)
        {
            return memberBusiness.SupplierList(SupInput);
        }
        public SupplierUpdateOutputDVO CreateSupplier(SupplierUpdateInputDVO suplierinfo)
        {
            return memberBusiness.CreateSupplier(suplierinfo);
        }
        public SupplierUpdateOutputDVO SupplierUpdate(SupplierUpdateInputDVO supplierInfo)
        {
            return memberBusiness.SupplierUpdate(supplierInfo);
        }
        public SupplierUpdateOutputDVO PasswordChangeUpdate(SupplierUpdateInputDVO pwdinfo)
        {
            return memberBusiness.PasswordChangeUpdate(pwdinfo);
        }

        public AdminUsersNewOutputDVO CreateAdminUser(AdminUsersNewInputDVO filter)
        {
            return memberBusiness.CreateAdminUser(filter);
        }
        public List<AdminUsersListOutputDVO> GetAdminUsersList(AdminUsersListInputDVO input)
        {
            return memberBusiness.GetAdminUsersList(input);
        }
        public ResetPasswordOutputDVO ResetPassword(ResetPasswordInputDVO Info)
        {
            return memberBusiness.ResetPassword(Info);
        }
        public List<AdminUsersListOutputDVO> GetCallCenterUsersList(AdminUsersListInputDVO Info)
        {
            return memberBusiness.GetCallCenterUsersList(Info);
        }
        public UpdateUsersStatusOutputDVO UpdateUserStatus(UpdateUsersStatusInputDVO Info)
        {
            return memberBusiness.UpdateUserStatus(Info);
        }
        public List<string> GetExistColGroupCodesOfImages(string securityToken)
        {
            return mediaBusiness.GetExistColGroupCodesOfImages(securityToken);
        }

        public List<SupplierListOutputDVO> GetSupplierListForReyon(SupplierListInputDVO filter)
        {
            return memberBusiness.GetSupplierListForReyon(filter);
        }
  

        #endregion

        #region Cores

        #endregion

        #region Categories

        public CategoryUpdateOutputDVO CategoryUpdate(CategoryUpdateInputDVO categoryInfo)
        {
            return categoryBusiness.CategoryUpdate(categoryInfo);
        }

        public CategoryOutputDVO GetCategoryByID(CategoryInputDVO categoryInfo)
        {
            return categoryBusiness.GetCategoryByID(categoryInfo);
        }

        public CategoryListUpdateOutputDVO CategoryListUpdate(CategoryListUpdateInputDVO categoryListInfo)
        {
            return categoryBusiness.CategoryListUpdate(categoryListInfo);
        }

        public CategoryStatusUpdateOutputDVO CategoryStatusUpdate(CategoryStatusUpdateInputDVO categoryInfo)
        {
            return categoryBusiness.CategoryStatusUpdate(categoryInfo);
        }

        public List<CategoryListOutputDVO> CategoryList(CategoryListInputDVO filter)
        {
            return categoryBusiness.CategoryList(filter);
        }

        public List<ProductCategoryListOutputDVO> GetSupplierCategoryList(string SecurityToken)
        {
            return categoryBusiness.GetSupplierCategoryList(SecurityToken);
        }

        public List<AllCategoriesDVO> GetAllCategoryTree(string SecurityToken, bool CategoryEdit)
        {
            return categoryBusiness.GetAllCategoryTree(SecurityToken, CategoryEdit);
        }

        public List<CategoryProductListOutputDVO> CategoryProductList(CategoryProductListInputDVO filter)
        {
            return categoryBusiness.CategoryProductList(filter);
        }

        #endregion

        #region Products

        public List<ProductListOutputDVO> ProductList(ProductListInputDVO filter)
        {
            return productBusiness.ProductList(filter);
        }

        public ProductSearchOutputDVO ProductSearch(ProductSearchInputDVO filter)
        {
            return productBusiness.ProductSearch(filter);
        }


        public ProductUpdateOutputDVO ProductUpdate(ProductUpdateInputDVO productInfo)
        {
            return productBusiness.ProductUpdate(productInfo);
        }

        public ProductDescriptionUpdateOutputDVO ProductDescriptionUpdate(ProductDescriptionUpdateInputDVO productInfo)
        {
            return productBusiness.ProductDescriptionUpdate(productInfo);
        }

        public ProductListUpdateOutputDVO ProductListUpdate(ProductListUpdateInputDVO productListInfo)
        {
            return productBusiness.ProductListUpdate(productListInfo);
        }

        public ProductCategoryUpdateOutputDVO ProductCategoryUpdate(ProductCategoryUpdateInputDVO productCategoryInfo)
        {
            return productBusiness.ProductCategoryUpdate(productCategoryInfo);
        }

        public ProductStockUpdateOutputDVO ProductStockUpdate(ProductStockUpdateInputDVO productStockInfo)
        {
            return productBusiness.ProductStockUpdate(productStockInfo);
        }

        public ProductPriceUpdateOutputDVO ProductPriceUpdate(ProductPriceUpdateInputDVO productPriceInfo)
        {
            return productBusiness.ProductPriceUpdate(productPriceInfo);
        }

        public ProductStatusUpdateOutputDVO ProductStatusUpdate(ProductStatusUpdateInputDVO productStatusInfo)
        {
            return productBusiness.ProductStatusUpdate(productStatusInfo);
        }

        public ProductImageUpdateOutputDVO ProductImageUpdate(ProductImageUpdateInputDVO productImageInfo)
        {
            return productBusiness.ProductImageUpdate(productImageInfo);
        }

        public ProductImageListUpdateOutputDVO ProductImageListUpdate(ProductImageListUpdateInputDVO productImageListInfo)
        {
            return productBusiness.ProductImageListUpdate(productImageListInfo);
        }

        public ProductThumbnailImageUpdateOutputDVO ProductThumbnailImageUpdate(ProductThumbnailImageUpdateInputDVO productThumbnailImageInfo)
        {
            return productBusiness.ProductThumbnailImageUpdate(productThumbnailImageInfo);
        }

        public ProductThumbnailImageListUpdateOutputDVO ProductThumbnailImageListUpdate(ProductThumbnailImageListUpdateInputDVO productThumbnailImageListInfo)
        {
            return productBusiness.ProductThumbnailImageListUpdate(productThumbnailImageListInfo);
        }

        public ProductOutputDVO GetProductByID(ProductInputDVO productInfo)
        {
            return productBusiness.GetProductByID(productInfo);
        }

        public string GetProductByColGroupCode(string colGrpCode, string securityToken)
        {
            return productBusiness.GetProductByColGroupCode(colGrpCode, securityToken);
        }

        public List<string> GetColGroupCodeList(string securityToken)
        {
            return productBusiness.GetColGroupCodeList(securityToken);
        }

        public List<ProductCategoryListOutputDVO> ProductCategoryList(ProductCategoryListInputDVO productInfo)
        {
            return productBusiness.ProductCategoryList(productInfo);
        }

        public bool DeleteProductCategory(string CategoryID, string ProductID, string SecurityToken)
        {
            return productBusiness.DeleteProductCategory(CategoryID, ProductID, SecurityToken);
        }

        #endregion

        #region Orders
        public NotIntegratedOrderListOutputDVO GetNotIntegratedOrderList(NotIntegratedOrderListInputDVO orderList)
        {
            return orderBusiness.GetNotIntegratedOrderList(orderList);
        }

        public List<OrderHeaderDVO> GetOrderProducts(AllOrderListInputDVO input)
        {
            return orderBusiness.GetOrderProducts(input);
        }

        public NotIntegratedOrderCodeListOutputDVO GetNotIntegratedOrderCodeList(NotIntegratedOrderCodeListInputDVO orderList)
        {
            return orderBusiness.GetNotIntegratedOrderCodeList(orderList);
        }

        public AllOrderListOutputDVO GetAllOrderList(AllOrderListInputDVO orderList)
        {
            return orderBusiness.GetAllOrderList(orderList);
        }

        public OrderOutputDVO GetOrder(OrderInputDVO orderInfo)
        {
            return orderBusiness.GetOrder(orderInfo);
        }

        public UpdateOrderStatusOutputDVO UpdateOrderStatus(UpdateOrderStatusInputDVO orderStatusInfo)
        {
            return orderBusiness.UpdateOrderStatus(orderStatusInfo);
        }


        public UpdateReturnStatusOutputDVO UpdateReturnStatus(UpdateReturnStatusInputDVO returnStatusInfo)
        {
            return orderBusiness.UpdateReturnStatus(returnStatusInfo);
        }

        public OrderStatusOutputDVO GetOrderStatus(OrderStatusInputDVO orderStatusInfo)
        {
            return orderBusiness.GetOrderStatus(orderStatusInfo);
        }

        public OrderSearchOutputDVO OrderSearch(OrderSearchInputDVO filter)
        {
            return orderBusiness.OrderSearch(filter);
        }

        public int GetNotIntegratedOrderListCount(NotIntegratedOrderListInputDVO filter)
        {
            return orderBusiness.GetNotIntegratedOrderListCount(filter);
        }

        public int GetAllOrderListCount(AllOrderListInputDVO input)
        {
            return orderBusiness.GetAllOrderListCount(input);
        }

        public UpdateOutputDVO UpdateOrderCargoInvoiceInfo(UpdateOrderCargoInputDVOv2 UpdateOCargoInput)
        {
            return orderBusiness.UpdateOrderCargoInvoiceInfo(UpdateOCargoInput);
        }

        public UpdateOrderCargoOutputDVO UpdateOrderCargoInfo(UpdateOrderCargoInputDVO UpdateOCargoInput)
        {
            return orderBusiness.UpdateOrderCargoInfo(UpdateOCargoInput);
        }

        public List<OrderHeaderDVO> GetOrderProductsForCallCenter(OrderSearchInputDVO input)
        {
            return orderBusiness.GetOrderProductsForCallCenter(input);

        }

        public CancelOutputDVO CancelOrder(CancelInputDVO input)
        {
            return orderBusiness.CancelOrder(input);
        }

        public CancelOrderOutputDVO CancelOrderByOrderDetailId(CancelOrderInputDVO input)
        {
            return orderBusiness.CancelOrderByOrderDetailId(input);
        }

        public UpdateNotIntOrdersStatusOutputDVO UpdateOrdersStatus(UpdateNotIntOrdersStatusInputDVO StatusInfo)
        {
            return orderBusiness.UpdateOrdersStatus(StatusInfo);
        }

        public UpdateOrderCargoOutputDVO UpdateOrderStatusAndCargoInfo(UpdateOrderCargoInputDVO UpdateOCargoInput)
        {
            return orderBusiness.UpdateOrderStatusAndCargoInfo(UpdateOCargoInput);
        }

        public List<OrderHeaderDVO> GetNotIntegratedOrders(AllOrderListInputDVO input)
        {
            return orderBusiness.GetNotIntegratedOrders(input);
        }

        public List<OrderHeaderDVO> GetIntegratedOrders(AllOrderListInputDVO input)
        {
            return orderBusiness.GetIntegratedOrders(input);
        }

        public List<OrderHeaderDVO> GetNewOrders(AllOrderListInputDVO input)
        {
            return orderBusiness.GetNewOrders(input);
        }

        public List<OrderHeaderDVO> GetAcceptedOrders(AllOrderListInputDVO input)
        {
            return orderBusiness.GetAcceptedOrders(input);
        }


        public List<OrderHeaderDVO> GetInTransitOrders(AllOrderListInputDVO StatusInfo)
        {
            return orderBusiness.GetInTransitOrders(StatusInfo);
        }


        public List<OrderHeaderDVO> GetReturnRequestOrders(AllOrderListInputDVO StatusInfo)
        {
            return orderBusiness.GetReturnRequestOrders(StatusInfo);
        }

        public List<OrderHeaderDVO> GetCompletedOrders(AllOrderListInputDVO input)
        {
            return orderBusiness.GetCompletedOrders(input);
        }

        public List<OrderHeaderDVO> GetReturnAcceptedOrders(AllOrderListInputDVO input)
        {
            return orderBusiness.GetReturnAcceptedOrders(input);
        }

        public List<OrderHeaderDVO> GetSupplierRejectedOrders(AllOrderListInputDVO input)
        {
            return orderBusiness.GetSupplierRejectedOrders(input);
        }

        public AllOrdersStatusCountOutputDVO GetOrdersStatusCount(AllOrdersStatusCountInputDVO input)
        {
            return orderBusiness.GetOrdersStatusCount(input);
        }

        public  AcceptReturnedOrderItemListOutputDVO AcceptReturnedOrdersItemList(AcceptReturnedOrderItemListInputDVO input)
        {
            return orderBusiness.AcceptReturnedOrdersItemList(input);
        }

        public ReturnedOrderItemListOutputDVO RejectReturnedOrdersItemList(ReturnedOrderItemListInputDVO input)
        {
            return orderBusiness.RejectReturnedOrdersItemList(input);
        }
        #endregion

        #region Return

        public ReturnOutputDVO GetReturn(ReturnInputDVO input)
        {
            return returnBusiness.GetReturn(input);
        }

        public ReturnListOutputDVO ReturnList(ReturnListInputDVO input)
        {
            return returnBusiness.ReturnList(input);
        }

        public int ReturnListCount(ReturnListInputDVO input)
        {
            return returnBusiness.ReturnListCount(input);
        }

        public NotIntegratedReturnListOutputDVO GetNotIntegratedReturnList(NotIntegratedReturnListInputDVO orderList)
        {
            return orderBusiness.GetNotIntegratedReturnList(orderList);
        }

        #endregion

        #region Xml

        public SupplierOutputDVO GetSupplierForXMLEntegration(SupplierInputDVO supplierInfo)
        {
            return xmlBusiness.GetSupplierForXMLEntegration(supplierInfo);
        }

        #endregion

        #region Adminproccess
         public CCTicketOutputDVO CreateCCTicket(CCTicketInputDVO info)
        {
            return memberBusiness.CreateCCTicket(info);
        }

         public List<PaymentListOutPutDVO> GetPaymentList(PaymentListInputDVO input)
         {
             return memberBusiness.GetPaymentList(input);
         }
        
         public List<PaymentDetailListOutPutDVO> GetPaymentDetailsList(PaymentDetailListInputDVO input)
         {
             return memberBusiness.GetPaymentDetailsList(input);
         }

         public List<ActualPaymentListOutPutDVO> GetActualPaymentList(ActualPaymentListInputDVO input)
         {
             return memberBusiness.GetActualPaymentList(input);
         }

         public List<OrderHeaderDVO> GetOrderByTref(AllOrderListInputDVO input)
         {
             return memberBusiness.GetOrderByTref(input);
         }

         public List<PaymentDetailListOutPutDVO> GetPaymentDetailsReport(PaymentDetailListInputDVO input)
         {
             return memberBusiness.GetPaymentDetailsReport(input);
         }

         public PayToSupplierOutputDVO PayToSupplier(PayToSupplierInputDVO input)
         {
             return memberBusiness.PayToSupplier(input);
         }
    
        public PaymentFromSupplierOutputDVO PaymentFromSupplier(PaymentFromSupplierInputDVO input)
         {
             return memberBusiness.PaymentFromSupplier(input);
         }

        public List<ReyonListOutPutDVO> GetReyonList(ReyonListInputDVO input)
        {
            return memberBusiness.GetReyonList(input);
        }

        public UpdateLinkedReyonOutPutDVO UpdateLinkedReyon(UpdateLinkedReyonInputDVO input)
        {
            return memberBusiness.UpdateLinkedReyon(input);
        }        
        public CreateTgReyonOutPutDVO CreateTgReyon(CreateTgReyonInPutDVO input)
        {
           return memberBusiness.CreateTgReyon(input);
        }

        public EftRequestCountOutPutDVO GetEftRequestCount(EftRequestCountInPutDVO input)
        {
            return memberBusiness.GetEftRequestCount(input);
        }

        public EftRequestAndBankOutPutDVO GetEftRequest(EftRequestInPutDVO input)
        {
            return memberBusiness.GetEftRequest(input);
        }

        public PayToStoreOwnerOutputDVO PayToStoreOwner(PayToStoreOwnerInputDVO input)
        {
            return memberBusiness.PayToStoreOwner(input);
        }

        #endregion




    }
}
