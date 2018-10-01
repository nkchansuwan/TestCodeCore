using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_SALESREPs")]
    public partial class MSalesreps
    {
        [Key]
        [Column("SALESREP_ID")]
        [StringLength(40)]
        public string SalesrepId { get; set; }
        [Required]
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Required]
        [Column("SALESREP_CODE")]
        [StringLength(40)]
        public string SalesrepCode { get; set; }
        [Required]
        [Column("SALESREP_NAME_TH")]
        [StringLength(150)]
        public string SalesrepNameTh { get; set; }
        [Required]
        [Column("SALESREP_NAME_EN")]
        [StringLength(150)]
        public string SalesrepNameEn { get; set; }
        [Required]
        [Column("SALESZONE_ID")]
        [StringLength(40)]
        public string SaleszoneId { get; set; }
        [Required]
        [Column("CORP_ID")]
        [StringLength(40)]
        public string CorpId { get; set; }
        [Column("ACTIVE_STATUS")]
        public int ActiveStatus { get; set; }
        [Column("ACTIVE_STATUS_DATE", TypeName = "datetime")]
        public DateTime ActiveStatusDate { get; set; }
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
