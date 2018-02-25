using Lidya.Models;
using Lidya.Models.ModelViews;
//using Lidya.Models.ModelViews.Category;
//using Lidya.Models.ModelViews.Managment;
//using Lidya.Models.ModelViews.Media;
//using Lidya.Models.ModelViews.Order;
//using Lidya.Models.ModelViews.Payment;
//using Lidya.Models.ModelViews.Return;
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
        ProductOutputDVO GetProductByID(ProductInputDVO productInfo);

        //[OperationContract]
        //AuthenticateUserOutputDVO AuthenticateUser(AuthenticateUserInputDVO userInfo);

        //[OperationContract]
        //AuthenticatePortalOutputDVO AuthenticatePortal(AuthenticatePortalInputDVO userInfo);


        [OperationContract]
        string GetProductByColGroupCode(string colGrpCode, string securityToken);

        [OperationContract]
        List<string> GetColGroupCodeList(string securityToken);

        
        
        //[OperationContract]
        //UpdateLinkedReyonOutPutDVO UpdateLinkedReyon(UpdateLinkedReyonInputDVO input);

        //[OperationContract]
        //CreateTgReyonOutPutDVO CreateTgReyon(CreateTgReyonInPutDVO input);

        //[OperationContract]
        //EftRequestCountOutPutDVO GetEftRequestCount(EftRequestCountInPutDVO input);

        //[OperationContract]
        //EftRequestAndBankOutPutDVO GetEftRequest(EftRequestInPutDVO input);

        //[OperationContract]
        //PayToStoreOwnerOutputDVO PayToStoreOwner(PayToStoreOwnerInputDVO input);
        
        //[OperationContract]
        //List<BannerOutPutDVO> GetBanners(BannerInPutDVO input);

        //[OperationContract]
        //List<SupplierListOutputDVO> GetSupplierListForReyon(SupplierListInputDVO filter);


    }

}
