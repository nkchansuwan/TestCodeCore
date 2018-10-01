using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_PDMODELs")]
    public partial class MPdmodels
    {
        [Key]
        [Column("PDMODEL_ID")]
        [StringLength(40)]
        public string PdmodelId { get; set; }
        [Required]
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Required]
        [Column("CORP_ID")]
        [StringLength(40)]
        public string CorpId { get; set; }
        [Required]
        [Column("PDMODEL_CODE")]
        [StringLength(40)]
        public string PdmodelCode { get; set; }
        [Required]
        [Column("PDMODEL_NAME_TH")]
        [StringLength(70)]
        public string PdmodelNameTh { get; set; }
        [Required]
        [Column("PDMODEL_NAME_EN")]
        [StringLength(70)]
        public string PdmodelNameEn { get; set; }
        [Column("ACTIVE_STATUS")]
        public int ActiveStatus { get; set; }
        [Column("ACTIVE_STATUS_DATE", TypeName = "datetime")]
        public DateTime ActiveStatusDate { get; set; }
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

        [Required]
        [Column("PDBRAND_ID")]        
        [StringLength(40)]
        public string PdbrandId { get; set; }
        [Required]
        [Column("UM_NAME")]
        [StringLength(40)]
        public string UmName { get; set; }
        [Required]
        [Column("UM_NAME_SALES")]
        [StringLength(40)]
        public string UmNameSales { get; set; }
        [Required]
        [Column("UMQTY_SALES", TypeName = "decimal(16, 4)")]
        public decimal UmqtySales { get; set; }
        [Required]
        [Column("SALES_PRICE", TypeName = "decimal(16, 4)")]
        public decimal SalesPrice { get; set; }
    }
}
