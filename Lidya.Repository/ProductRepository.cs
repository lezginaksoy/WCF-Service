using Lidya.Models;
using Lidya.Models.ModelViews;
using Lidya.Models.ModelViews.Order;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using HtmlAgilityPack;
using System.Globalization;
using System.Transactions;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime;
using Amazon.SecurityToken;

namespace Lidya.Repository
{
    public class ProductRepository : RepositoryBase<TSUPPLIER>
    {
        
        public bool InsertLog(string logdata, decimal logtype, Token t)
        {
            try
            {
                using (LidyaEntities db = new LidyaEntities())
                {

                    TINTLOG l = new TINTLOG();
                    l.DLOGDATE = DateTime.Now;
                    l.USRID = t.UserId.ToString();
                    l.TNAME = t.UserName;
                    l.TLOGDATA = logdata;
                    l.CTYPELOG = logtype;
                    db.TINTLOG.Add(l);
                    db.SaveChanges();
                    return true;
    
                }
            }
            catch (Exception ex)
            {
                //string hata = ""; 

                //foreach (var item in ((DbEntityValidationException)ex).EntityValidationErrors)
                //{
                //    hata += item.ValidationErrors.ToString();
                //}

                return false;
            }
        }
        
        

        public List<ProductListOutputDVO> ProductList(ProductListInputDVO filter, Token t)
        {
            int pageIndex = 0;
            int pageSize = filter.PageSize;

            double recordCount = Context.TITEMLIST.Where(x => x.SUPID == t.UserId).Select(x => x.ITMID).Count();
            pageIndex = (int)Math.Ceiling(recordCount / pageSize);

            List<ProductListOutputDVO> list = (from q in Context.TITEMLIST
                                               where q.SUPID == t.UserId

                                               select new ProductListOutputDVO
                                               {
                                                   ProductID = q.TPRODUCTID,
                                                   ProductCode = q.TPRODCODE,
                                                   ProductName = q.TDESCTUR,
                                                   ColorGroupCode = q.TCOLGRP,
                                                   Price = q.NMAXPITM,
                                               }
                                              ).OrderBy(x => x.ProductName).Skip(filter.CurrentPage * pageSize).Take(pageSize).ToList();
            if (list.Count != 0)
            {
                list[0].PageCount = pageIndex;
            }

            return list;

        }

        public ProductOutputDVO GetProductByID(string productID, Token t)
        {
            using (LidyaEntities db = new LidyaEntities())
            {
                TITEMLIST item = db.TITEMLIST.Where(x => x.TPRODUCTID == productID && x.SUPID == t.UserId).FirstOrDefault();

                if (item == null)
                    return null;
                else
                {
                    return new ProductOutputDVO
                    {
                        ProductID = item.TPRODUCTID,
                        ProductName = item.TDESCTUR,
                        ProductNameEn = item.TDESCENG,
                        ProductCode = item.TPRODCODE,
                        ProductStatus = item.CSTATITM,

                        ColorGroupCode = item.TCOLGRP,
                        MarketPrice = item.NINIPITM,
                        SalePrice = item.NMAXPITM, //Sales Price
                        Price = item.NCOGSITM,

                        Brand = item.TBRANDNAME,
                        ModelGroupCode = item.TMODELID,
                        OrginalSize = item.TMODELSIZE,
                        Color = item.TSPEC1,
                        OrginalColor = item.TMODELCOLOR,
                        Size = item.TSPEC2,
                        ExtraProperty = item.TSPEC3,
                        Description = item.TDESC,

                        DeliveryDays = item.NDLVDAYS,
                        NoteSize = item.NNOTESIZE,

                        CargoPrice = 0,
                        Quantity = item.NADETITM,
                        TaxRate = item.NVAT,
                        FixedPrice = (item.BFIXPITM == 1) ? true : false
                    };
                }
            }
        }


        
 }


 
}