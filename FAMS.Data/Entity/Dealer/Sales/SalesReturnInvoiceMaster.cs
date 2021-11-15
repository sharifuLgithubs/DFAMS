﻿using FADMS.Data.Entity.Dealer;
using FADMS.Data.Entity.LicenseInformation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FADMS.Data.Entity.Dealer.Sales
{
    public class SalesReturnInvoiceMaster:Base
    {
        public int? licenseInfoId { get; set; }
        public LicenseInfo licenseInfo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? invoiceDate { get; set; }
        public DateTime? paymentDate { get; set; }

        public string invoiceNumber { get; set; }

        [Column(TypeName = "decimal(18,6)")]
        public decimal? totalAmount { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal? VATOnTotal { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal? DiscountOnTotal { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal? NetTotal { get; set; }
        [Column(TypeName = "decimal(18,6)")]
        public decimal? SDOnTotal { get; set; }

        public int? isClose { get; set; } //1=Paid, 0 = have Due
        public int? isStockClose { get; set; } //1 = full stock, 0 = Due
        public int? isPayClose { get; set; }
        public string remarks { get; set; }
        //public int? companyId { get; set; }
        //public Company company { get; set; }
        //public int? storeId { get; set; }
        //public Store store { get; set; }




    }
}