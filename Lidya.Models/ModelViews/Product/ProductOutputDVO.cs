using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lidya.Models.ModelViews
{
    public class ProductOutputDVO : OutputBase
    {
        /// <summary>
        /// Ürün ID si
        /// DB Field Name : TPRODUCTID
        /// </summary>
        [DataMember]
        public string ProductID { get; set; }

        /// <summary>
        /// Ürün Kodu
        /// DB Field Name : TPRODCODE
        /// </summary>
        [DataMember]
        public string ProductCode { get; set; }


        /// <summary>
        /// Ürün Adı
        /// DB Field Name : TDESCTUR
        /// </summary>
        [DataMember]
        public string ProductName { get; set; }

        /// <summary>
        /// Ürün Adı - İngilizce
        /// DB Field Name : TDESCENG
        /// </summary>
        [DataMember]
        public string ProductNameEn { get; set; }

        /// <summary>
        /// ModelID
        /// DB Field Name : TMODELID
        /// </summary>
        [DataMember]
        public string ModelGroupCode { get; set; }

        /// <summary>
        /// ColorGroupCode
        /// DB Field Name : TCOLGRP
        /// </summary>
        [DataMember]
        public string ColorGroupCode { get; set; }

        /// <summary>
        /// Marka
        /// DB Field Name : TBRANDNAME
        /// </summary>
        [DataMember]
        public string Brand { get; set; }

        /// <summary>
        /// Spec1
        /// DB Field Name :
        /// </summary>
        [DataMember]
        public string Color { get; set; }

        /// <summary>
        /// Orjinal Size
        /// DB Field Name : TMODELCOLOR
        /// </summary>
        [DataMember]
        public string OrginalColor { get; set; }

        /// <summary>
        /// Spec2
        /// DB Field Name : TSPEC2
        /// </summary>
        [DataMember]
        public string Size { get; set; }

        /// <summary>
        /// Orjinal Size
        /// DB Field Name : TMODELSIZE
        /// </summary>
        [DataMember]
        public string OrginalSize { get; set; }

        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Extra Özellik
        /// DB Field Name : TSPEC3
        /// </summary>
        [DataMember]
        public string ExtraProperty { get; set; }

        /// <summary>
        /// Teslim Suresi
        /// DB Field Name : NDLVDAYS
        /// </summary>
        [DataMember]
        public decimal? DeliveryDays { get; set; }

        /// <summary>
        /// Eklenecek Notun Uzunlugu
        /// DB Field Name : NNOTESIZE
        /// </summary>
        [DataMember]
        public decimal? NoteSize { get; set; }

        [DataMember]
        public bool FixedPrice { get; set; }

        [DataMember]
        public decimal? Price { get; set; }

        [DataMember]
        public decimal? MarketPrice { get; set; }

        [DataMember]
        public decimal? SalePrice { get; set; }

        [DataMember]
        public decimal? TaxRate { get; set; }

        [DataMember]
        public decimal CargoPrice { get; set; }

        /// <summary>
        /// Stok Adedi
        /// DB Field Name : NADETITM
        /// </summary>
        [DataMember]
        public long? Quantity { get; set; }

        [DataMember]
        public short? ProductStatus { get; set; }

        /// <summary>
        /// Birim
        /// DB Field Name : CUNITITM
        /// </summary>
        //[DataMember]
        //public Enumarations.ProductUnit Unit { get; set; }

        //[DataMember]
        //public DateTime? PriceExpireDate { get; set; }

        //[DataMember]
        //public decimal? CostPrice { get; set; }

        //[DataMember]
        //public decimal? MinPrice { get; set; }

        //[DataMember]
        //public DateTime? SalesStartDate { get; set; }
 
    }
}
