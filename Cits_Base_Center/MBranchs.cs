using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_BRANCHs")]
    public partial class MBranchs
    {
        [Key]
        [Column("BRANCH_ID")]
        [StringLength(40)]
        public string BranchId { get; set; }
        [Required]
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Required]
        [Column("BRANCH_CODE")]
        [StringLength(40)]
        public string BranchCode { get; set; }
        [Required]
        [Column("BRANCH_NAME_TH")]
        [StringLength(70)]
        public string BranchNameTh { get; set; }
        [Required]
        [Column("BRANCH_NAME_EN")]
        [StringLength(70)]
        public string BranchNameEn { get; set; }
        [Required]
        [Column("BRANCH_ADDRESS_TH_1")]
        [StringLength(125)]
        public string BranchAddressTh1 { get; set; }
        [Required]
        [Column("BRANCH_ADDRESS_TH_2")]
        [StringLength(125)]
        public string BranchAddressTh2 { get; set; }
        [Required]
        [Column("BRANCH_ADDRESS_TH_3")]
        [StringLength(125)]
        public string BranchAddressTh3 { get; set; }
        [Required]
        [Column("BRANCH_TEL_NO")]
        [StringLength(40)]
        public string BranchTelNo { get; set; }
        [Required]
        [Column("BRANCH_FAX_NO")]
        [StringLength(40)]
        public string BranchFaxNo { get; set; }
        [Required]
        [Column("CORP_ID")]
        [StringLength(40)]
        public string CorpId { get; set; }
        [Required]
        [Column("VATBRANCHCODE")]
        [StringLength(40)]
        public string Vatbranchcode { get; set; }
        [Column("VATTYPE_ID")]
        public int? VattypeId { get; set; }
        [Column("VATISOUT")]
        public int? Vatisout { get; set; }
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
