using Lidya.Models;
using Lidya.Models.ModelViews;
using Lidya.Models.ModelViews.Category;
using Lidya.Models.ModelViews.Managment;
using Lidya.Models.ModelViews.Media;
using Lidya.Models.ModelViews.Order;
using Lidya.Models.ModelViews.Payment;
using Lidya.Models.ModelViews.Return;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lidya.ServiceHost
{
    [ServiceContract]
    public interface IIntegration
    {
        [OperationContract]
        List<ProductListOutputDVO> ProductList(ProductListInputDVO filter);

        [OperationContract]
        ProductSearchOutputDVO ProductSearch(ProductSearchInputDVO filter);

        [OperationContract]
        AuthenticateUserOutputDVO AuthenticateUser(AuthenticateUserInputDVO userInfo);

        [OperationContract]
        AuthenticatePortalOutputDVO AuthenticatePortal(AuthenticatePortalInputDVO userInfo);

        [OperationContract]
        SupplierUpdateOutputDVO CreateSupplier(SupplierUpdateInputDVO suplierinfo);

        [OperationContract]
        CategoryOutputDVO GetCategoryByID(CategoryInputDVO categoryInfo);

        [OperationContract]
        CategoryUpdateOutputDVO CategoryUpdate(CategoryUpdateInputDVO categoryInfo);

        [OperationContract]
        CategoryStatusUpdateOutputDVO CategoryStatusUpdate(CategoryStatusUpdateInputDVO categoryInfo);

        [OperationContract]
        CategoryListUpdateOutputDVO CategoryListUpdate(CategoryListUpdateInputDVO categoryInfo);

        [OperationContract]
        List<CategoryListOutputDVO> CategoryList(CategoryListInputDVO filter);

        [OperationContract]
        List<CategoryProductListOutputDVO> CategoryProductList(CategoryProductListInputDVO filter);

        [OperationContract]
        ProductUpdateOutputDVO ProductUpdate(ProductUpdateInputDVO productInfo);

        [OperationContract]
        ProductDescriptionUpdateOutputDVO ProductDescriptionUpdate(ProductDescriptionUpdateInputDVO productInfo);

        [OperationContract]
        ProductListUpdateOutputDVO ProductListUpdate(ProductListUpdateInputDVO productInfo);

        [OperationContract]
        ProductCategoryUpdateOutputDVO ProductCategoryUpdate(ProductCategoryUpdateInputDVO productCategoryInfo);

        [OperationContract]
        ProductStockUpdateOutputDVO ProductStockUpdate(ProductStockUpdateInputDVO productStockInfo);

        [OperationContract]
        ProductPriceUpdateOutputDVO ProductPriceUpdate(ProductPriceUpdateInputDVO productPriceInfo);

        [OperationContract]
        ProductStatusUpdateOutputDVO ProductStatusUpdate(ProductStatusUpdateInputDVO productStatusInfo);

        [OperationContract]
        ProductImageUpdateOutputDVO ProductImageUpdate(ProductImageUpdateInputDVO productImageInfo);

        [OperationContract]
        ProductImageListUpdateOutputDVO ProductImageListUpdate(ProductImageListUpdateInputDVO productImageListInfo);


        [OperationContract]
        ProductThumbnailImageUpdateOutputDVO ProductThumbnailImageUpdate(ProductThumbnailImageUpdateInputDVO productThumbnailImageInfo);

        [OperationContract]
        ProductThumbnailImageListUpdateOutputDVO ProductThumbnailImageListUpdate(ProductThumbnailImageListUpdateInputDVO productThumbnailImageListInfo);

        [OperationContract]
        ProductOutputDVO GetProductByID(ProductInputDVO productInfo);

        [OperationContract]
        string GetProductByColGroupCode(string colGrpCode, string securityToken);

        [OperationContract]
        List<string> GetColGroupCodeList(string securityToken);

        [OperationContract]
        List<ProductCategoryListOutputDVO> ProductCategoryList(ProductCategoryListInputDVO productInfo);

        [OperationContract]
        List<ProductCategoryListOutputDVO> GetSupplierCategoryList(string SecurityToken);

        [OperationContract]
        List<AllCategoriesDVO> GetAllCategoryTree(string SecurityToken, bool CategoryEdit);

        [OperationContract]
        bool DeleteProductCategory(string CategoryID, string ProductID, string SecurityToken);

        //[OperationContract]
        //CampaignUpdateOutputDVO CampaignUpdate(CampaignUpdateInputDVO campaignInfo);
        ////Kimlik
        ////KampanyaNo
        ////KampanyaAdı
        ////KampanyaTanımı
        ////BaşlangıçTarihi
        ////BitişTarihi
        ////KampanyaDurumu
        ////Gorsel
        ////GorselLink

        ////TSUPINST
        //[OperationContract]
        //InstallmentUpdateOutputDVO InstallmentUpdate(InstallmentUpdateInputDVO installmentInfo);
        ////46-Axess 62-Garanti 64-Maximum 67-WorldCard 123-Advantage
        ////TBANKINFO

        [OperationContract]
        SupplierOutputDVO GetSupplier(SupplierInputDVO supplierInfo);

        [OperationContract]
        SupplierOutputDVO GetSupplierForPortal(SupplierInputDVO supplierInfo);

        [OperationContract]
        SupplierOutputDVO GetSupplierForXMLEntegration(SupplierInputDVO supplierInfo);

        [OperationContract]
        List<SupplierListOutputDVO> SupplierList(SupplierListInputDVO SupInput);

        [OperationContract]
        SupplierOutputDVO GetSupplierForUpdate(SupplierInputDVO supplierInput);

        [OperationContract]
        SupplierUpdateOutputDVO SupplierUpdate(SupplierUpdateInputDVO supplierInfo);
        [OperationContract]
        SupplierUpdateOutputDVO PasswordChangeUpdate(SupplierUpdateInputDVO pwdinfo);

        [OperationContract]
        NotIntegratedOrderListOutputDVO GetNotIntegratedOrderList(NotIntegratedOrderListInputDVO orderList);

        [OperationContract]
        NotIntegratedReturnListOutputDVO GetNotIntegratedReturnList(NotIntegratedReturnListInputDVO orderList);

        [OperationContract]
        NotIntegratedOrderCodeListOutputDVO GetNotIntegratedOrderCodeList(NotIntegratedOrderCodeListInputDVO orderList);

        [OperationContract]
        AllOrderListOutputDVO GetAllOrderList(AllOrderListInputDVO orderList);

        [OperationContract]
        OrderOutputDVO GetOrder(OrderInputDVO orderInfo);

        [OperationContract]
        UpdateOrderStatusOutputDVO UpdateOrderStatus(UpdateOrderStatusInputDVO orderStatusInfo);

        [OperationContract]
        UpdateReturnStatusOutputDVO UpdateReturnStatus(UpdateReturnStatusInputDVO returnStatusInfo);

        [OperationContract]
        OrderStatusOutputDVO GetOrderStatus(OrderStatusInputDVO orderList);

        [OperationContract]
        List<MediaOutputDVO> GetMediaListBySryId(MediaInputDVO input);

        [OperationContract]
        List<MediaOutputDVO> GetMediaListByColGrp(MediaInputDVO input);

        [OperationContract]
        OrderSearchOutputDVO OrderSearch(OrderSearchInputDVO filter);

        [OperationContract]
        int GetNotIntegratedOrderListCount(NotIntegratedOrderListInputDVO filter);

        [OperationContract]
        int GetAllOrderListCount(AllOrderListInputDVO input);

        //[OperationContract]
        //MediaInsertOutputDVO MediaInsert(MediaInsertInputDVO mediaInfo);

        [OperationContract]
        bool ProductImageProcess(MediaDVO media, string SecurityToken);

        [OperationContract]
        bool CategoryImageProcess(MediaDVO media, string SecurityToken);

        [OperationContract]
        bool InsertMediaQueue(MediaDVO mediaInput, string securityToken);

        [OperationContract]
        MediaInsertOutputDVO InsertListToMediaQueue(List<MediaDVO> mediaInput, string securityToken);

        [OperationContract]
        ReturnOutputDVO GetReturn(ReturnInputDVO input);

        [OperationContract]
        ReturnListOutputDVO ReturnList(ReturnListInputDVO input);

        [OperationContract]
        int ReturnListCount(ReturnListInputDVO input);

        [OperationContract]
        List<OrderHeaderDVO> GetOrderProducts(AllOrderListInputDVO input);

        [OperationContract]
        UpdateOutputDVO UpdateOrderCargoInvoiceInfo(UpdateOrderCargoInputDVOv2 UpdateOCargoInput);

        [OperationContract]
        UpdateOrderCargoOutputDVO UpdateOrderCargoInfo(UpdateOrderCargoInputDVO UpdateOCargoInput);

        [OperationContract]
        List<OrderHeaderDVO> GetOrderProductsForCallCenter(OrderSearchInputDVO input);

        [OperationContract]
        CancelOutputDVO CancelOrder(CancelInputDVO input);

        [OperationContract]
        CancelOrderOutputDVO CancelOrderByOrderDetailId(CancelOrderInputDVO input);

        [OperationContract]
        AdminUsersNewOutputDVO CreateAdminUser(AdminUsersNewInputDVO filter);

        [OperationContract]
        List<AdminUsersListOutputDVO> GetAdminUsersList(AdminUsersListInputDVO input);

        [OperationContract]
        UpdateNotIntOrdersStatusOutputDVO UpdateOrdersStatus(UpdateNotIntOrdersStatusInputDVO StatusInfo);

        [OperationContract]
        UpdateOrderCargoOutputDVO UpdateOrderStatusAndCargoInfo(UpdateOrderCargoInputDVO UpdateOCargoInput);

        [OperationContract]
        List<OrderHeaderDVO> GetNotIntegratedOrders(AllOrderListInputDVO input);

        [OperationContract]
        List<OrderHeaderDVO> GetIntegratedOrders(AllOrderListInputDVO input);

        [OperationContract]
        List<OrderHeaderDVO> GetNewOrders(AllOrderListInputDVO input);

        [OperationContract]
        List<OrderHeaderDVO> GetAcceptedOrders(AllOrderListInputDVO input);

        [OperationContract]
        List<OrderHeaderDVO> GetInTransitOrders(AllOrderListInputDVO input);

        [OperationContract]
        List<OrderHeaderDVO> GetReturnRequestOrders(AllOrderListInputDVO StatusInfo);

        [OperationContract]
        List<OrderHeaderDVO> GetCompletedOrders(AllOrderListInputDVO input);

        [OperationContract]
        List<OrderHeaderDVO> GetReturnAcceptedOrders(AllOrderListInputDVO input);

        [OperationContract]
        List<OrderHeaderDVO> GetSupplierRejectedOrders(AllOrderListInputDVO input);

        [OperationContract]
        AllOrdersStatusCountOutputDVO GetOrdersStatusCount(AllOrdersStatusCountInputDVO input);

        [OperationContract]
        ResetPasswordOutputDVO ResetPassword(ResetPasswordInputDVO Info);

        [OperationContract]
        List<AdminUsersListOutputDVO> GetCallCenterUsersList(AdminUsersListInputDVO Info);

        [OperationContract]
        UpdateUsersStatusOutputDVO UpdateUserStatus(UpdateUsersStatusInputDVO Info);
        
        [OperationContract]
        CCTicketOutputDVO CreateCCTicket(CCTicketInputDVO info);

        [OperationContract]
        List<PaymentListOutPutDVO> GetPaymentList(PaymentListInputDVO input);
        
        [OperationContract]
         List<PaymentDetailListOutPutDVO> GetPaymentDetailsList(PaymentDetailListInputDVO input);

        [OperationContract]
        List<ActualPaymentListOutPutDVO> GetActualPaymentList(ActualPaymentListInputDVO input);

        [OperationContract]
         List<OrderHeaderDVO> GetOrderByTref(AllOrderListInputDVO input);
        
        [OperationContract]
        List<PaymentDetailListOutPutDVO> GetPaymentDetailsReport(PaymentDetailListInputDVO input);
        
        [OperationContract]      
        AcceptReturnedOrderItemListOutputDVO AcceptReturnedOrdersItemList(AcceptReturnedOrderItemListInputDVO input);

        [OperationContract]
        ReturnedOrderItemListOutputDVO RejectReturnedOrdersItemList(ReturnedOrderItemListInputDVO input);

        [OperationContract]
        PayToSupplierOutputDVO PayToSupplier(PayToSupplierInputDVO input);

        [OperationContract]
        PaymentFromSupplierOutputDVO PaymentFromSupplier(PaymentFromSupplierInputDVO input);
        
        [OperationContract]
        List<ReyonListOutPutDVO> GetReyonList(ReyonListInputDVO input);

        [OperationContract]
        UpdateLinkedReyonOutPutDVO UpdateLinkedReyon(UpdateLinkedReyonInputDVO input);

        [OperationContract]
        CreateTgReyonOutPutDVO CreateTgReyon(CreateTgReyonInPutDVO input);

        [OperationContract]
        EftRequestCountOutPutDVO GetEftRequestCount(EftRequestCountInPutDVO input);

        [OperationContract]
        EftRequestAndBankOutPutDVO GetEftRequest(EftRequestInPutDVO input);

        [OperationContract]
        PayToStoreOwnerOutputDVO PayToStoreOwner(PayToStoreOwnerInputDVO input);
        
        [OperationContract]
        List<BannerOutPutDVO> GetBanners(BannerInPutDVO input);

        [OperationContract]
        List<SupplierListOutputDVO> GetSupplierListForReyon(SupplierListInputDVO filter);


    }

}
