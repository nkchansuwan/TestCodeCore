using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_VENDORs")]
    public partial class MVendors
    {
        [Key]
        [Column("VENDOR_ID")]
        [StringLength(40)]
        public string VendorId { get; set; }
        [Required]
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Required]
        [Column("CORP_ID")]
        [StringLength(40)]
        public string CorpId { get; set; }
        [Required]
        [Column("VENDOR_CODE")]
        [StringLength(40)]
        public string VendorCode { get; set; }
        [Required]
        [Column("VENDOR_NAME_TH")]
        [StringLength(150)]
        public string VendorNameTh { get; set; }
        [Required]
        [Column("VENDOR_NAME_EN")]
        [StringLength(150)]
        public string VendorNameEn { get; set; }
        [Required]
        [Column("TAX_ID")]
        [StringLength(40)]
        public string TaxId { get; set; }
        [Column("SERVICE_TYPE_ID")]
        public int ServiceTypeId { get; set; }
        [Column("ACTIVE_STATUS")]
        public int ActiveStatus { get; set; }
        [Column("ACTIVE_STATUS_DATE", TypeName = "datetime")]
        public DateTime ActiveStatusDate { get; set; }
        [Required]
        [Column("BANK_ACCOUNT_NO")]
        [StringLength(70)]
        public string BankAccountNo { get; set; }
        [Required]
        [Column("BANK_BRANCH_CODE")]
        [StringLength(70)]
        public string BankBranchCode { get; set; }
        [Required]
        [Column("BANK_ID")]
        [StringLength(40)]
        public string BankId { get; set; }
        [Column("BANK_ACCOUNT_NO_STATUS")]
        public int BankAccountNoStatus { get; set; }
        [Column("TRANSFER_LIMIT", TypeName = "decimal(16, 4)")]
        public decimal TransferLimit { get; set; }
        [Required]
        [Column("APPROVED_BY")]
        [StringLength(40)]
        public string ApprovedBy { get; set; }
        [Column("CHARGE_TYPE_ID")]
        public int ChargeTypeId { get; set; }
        [Required]
        [Column("EMAIL")]
        [StringLength(70)]
        public string Email { get; set; }
        [Required]
        [Column("FAX_NO")]
        [StringLength(70)]
        public string FaxNo { get; set; }
        [Required]
        [Column("ATTENTION_TO")]
        [StringLength(70)]
        public string AttentionTo { get; set; }
        [Required]
        [Column("ATTENTION_MESSAGE")]
        [StringLength(70)]
        public string AttentionMessage { get; set; }
        [Column("WHT_TYPE_ID")]
        public int WhtTypeId { get; set; }
        [Column("WHT_INCOME_TYPE_ID_1")]
        public int WhtIncomeTypeId1 { get; set; }
        [Column("WHT_RATE_1", TypeName = "decimal(16, 4)")]
        public decimal WhtRate1 { get; set; }
        [Column("WHT_INCOME_TYPE_ID_2")]
        public int WhtIncomeTypeId2 { get; set; }
        [Column("WHT_RATE_2", TypeName = "decimal(16, 4)")]
        public decimal WhtRate2 { get; set; }
        [Column("WHT_INCOME_TYPE_ID_3")]
        public int WhtIncomeTypeId3 { get; set; }
        [Column("WHT_RATE_3", TypeName = "decimal(16, 4)")]
        public decimal WhtRate3 { get; set; }
        [Column("WHT_DELIVERY_TYPE_ID")]
        public int WhtDeliveryTypeId { get; set; }
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
