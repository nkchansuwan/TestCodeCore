using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_CUSTOMERs")]
    public partial class MCustomers
    {
        [Key]
        [Column("CUSTOMER_ID")]
        [StringLength(40)]
        public string CustomerId { get; set; }
        [Required]
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Required]
        [Column("CUSTOMER_CODE")]
        [StringLength(40)]
        public string CustomerCode { get; set; }
        [Required]
        [Column("CUSTOMER_NAME_TH")]
        [StringLength(150)]
        public string CustomerNameTh { get; set; }
        [Required]
        [Column("CUSTOMER_NAME_EN")]
        [StringLength(150)]
        public string CustomerNameEn { get; set; }
        [Required]
        [Column("CORP_ID")]
        [StringLength(40)]
        public string CorpId { get; set; }
        [Column("ISCUST")]
        public int Iscust { get; set; }
        [Column("ISSUPP")]
        public int Issupp { get; set; }
        [Column("ADDRESS_TH_1")]
        [StringLength(150)]
        public string AddressTh1 { get; set; }
        [Column("ADDRESS_TH_2")]
        [StringLength(150)]
        public string AddressTh2 { get; set; }
        [Column("ADDRESS_TH_3")]
        [StringLength(150)]
        public string AddressTh3 { get; set; }
        [Column("ZIP")]
        [StringLength(40)]
        public string Zip { get; set; }
        [Column("TEL_NO")]
        [StringLength(40)]
        public string TelNo { get; set; }
        [Column("FAX_NO")]
        [StringLength(40)]
        public string FaxNo { get; set; }
        [Column("TAX_ID")]
        [StringLength(40)]
        public string TaxId { get; set; }
        [Column("VATBRANCHCODE")]
        [StringLength(40)]
        public string Vatbranchcode { get; set; }
        [Column("VATBRANCHNAME")]
        [StringLength(40)]
        public string Vatbranchname { get; set; }
        [Column("ACTIVE_STATUS")]
        public int? ActiveStatus { get; set; }
        [Column("ACTIVE_STATUS_DATE", TypeName = "datetime")]
        public DateTime? ActiveStatusDate { get; set; }
        [Column("REFER_ID_1")]
        [StringLength(40)]
        public string ReferId1 { get; set; }
        [Column("DELETE_STATUS")]
        public int? DeleteStatus { get; set; }
        [Column("CREATE_DATE", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("CREATE_BY")]
        [StringLength(40)]
        public string CreateBy { get; set; }
        [Column("UPDATE_DATE", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("UPDATE_BY")]
        [StringLength(40)]
        public string UpdateBy { get; set; }
        [Column("REVISION")]
        public int? Revision { get; set; }
    }
}
