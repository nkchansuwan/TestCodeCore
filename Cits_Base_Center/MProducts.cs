using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_PRODUCTs")]
    public partial class MProducts
    {
        [Key]
        [Column("PRODUCT_ID")]
        [StringLength(40)]
        public string ProductId { get; set; }
        [Required]
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Required]
        [Column("PRODUCT_CODE")]
        [StringLength(40)]
        public string ProductCode { get; set; }
        [Required]
        [Column("PRODUCT_NAME_TH")]
        [StringLength(70)]
        public string ProductNameTh { get; set; }
        [Required]
        [Column("PRODUCT_NAME_EN")]
        [StringLength(70)]
        public string ProductNameEn { get; set; }
        [Required]
        [Column("PRODUCT_SNAME_TH")]
        [StringLength(70)]
        public string ProductSnameTh { get; set; }
        [Required]
        [Column("PRODUCT_SNAME_EN")]
        [StringLength(70)]
        public string ProductSnameEn { get; set; }
        [Required]
        [Column("UM_NAME")]
        [StringLength(40)]
        public string UmName { get; set; }
        [Required]
        [Column("UM_NAME_SALES")]
        [StringLength(40)]
        public string UmNameSales { get; set; }
        [Column("UMQTY_SALES", TypeName = "decimal(16, 4)")]
        public decimal UmqtySales { get; set; }
        [Required]
        [Column("PDBRAND_ID")]
        [StringLength(40)]
        public string PdbrandId { get; set; }
        [Required]
        [Column("PDMODEL_ID")]
        [StringLength(40)]
        public string PdmodelId { get; set; }
        [Required]
        [Column("PDSIZE_ID")]
        [StringLength(40)]
        public string PdsizeId { get; set; }
        [Required]
        [Column("PDCOLOR_ID")]
        [StringLength(40)]
        public string PdcolorId { get; set; }
        [Required]
        [Column("CORP_ID")]
        [StringLength(40)]
        public string CorpId { get; set; }
        [Required]
        [Column("REFER_ID_1")]
        [StringLength(40)]
        public string ReferId1 { get; set; }
        [Column("DELETE_STATUS")]
        public int DeleteStatus { get; set; }
        [Column("CREATE_DATE", TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Required]
        [Column("CREATE_BY")]
        [StringLength(40)]
        public string CreateBy { get; set; }
        [Column("UPDATE_DATE", TypeName = "datetime")]
        public DateTime UpdateDate { get; set; }
        [Required]
        [Column("UPDATE_BY")]
        [StringLength(40)]
        public string UpdateBy { get; set; }
        [Column("REVISION")]
        public int Revision { get; set; }
    }
}
