using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_INVOICE_STATUS")]
    public partial class MInvoiceStatus
    {
        [Key]
        [Column("INVOICE_STATUS_ID")]
        public int InvoiceStatusId { get; set; }
        [Required]
        [Column("INVOICE_STATUS_NAME_TH")]
        [StringLength(70)]
        public string InvoiceStatusNameTh { get; set; }
        [Required]
        [Column("INVOICE_STATUS_NAME_EN")]
        [StringLength(70)]
        public string InvoiceStatusNameEn { get; set; }
        [Column("INVOICE_STATUS_TYPE")]
        public int InvoiceStatusType { get; set; }
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
