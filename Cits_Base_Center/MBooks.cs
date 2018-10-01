using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_BOOKs")]
    public partial class MBooks
    {
        [Key]
        [Column("BOOK_ID")]
        [StringLength(40)]
        public string BookId { get; set; }
        [Required]
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Required]
        [Column("CORP_ID")]
        [StringLength(40)]
        public string CorpId { get; set; }
        [Required]
        [Column("BRANCH_ID")]
        [StringLength(40)]
        public string BranchId { get; set; }
        [Required]
        [Column("REFER_ID_1")]
        [StringLength(40)]
        public string ReferId1 { get; set; }
        [Required]
        [Column("BOOK_CODE")]
        [StringLength(40)]
        public string BookCode { get; set; }
        [Required]
        [Column("BOOK_NAME_TH")]
        [StringLength(70)]
        public string BookNameTh { get; set; }
        [Required]
        [Column("BOOK_NAME_EN")]
        [StringLength(70)]
        public string BookNameEn { get; set; }
        [Required]
        [Column("REFTYPE_ID")]
        [StringLength(40)]
        public string ReftypeId { get; set; }
        [Required]
        [Column("FORM_PRINT_ID_01")]
        [StringLength(40)]
        public string FormPrintId01 { get; set; }
        [Required]
        [Column("FORM_PRINT_ID_02")]
        [StringLength(40)]
        public string FormPrintId02 { get; set; }
        [Required]
        [Column("FORM_PRINT_ID_03")]
        [StringLength(40)]
        public string FormPrintId03 { get; set; }
        [Required]
        [Column("FORM_PRINT_ID_04")]
        [StringLength(40)]
        public string FormPrintId04 { get; set; }
        [Required]
        [Column("FORM_PRINT_ID_05")]
        [StringLength(40)]
        public string FormPrintId05 { get; set; }
        [Required]
        [Column("FORM_PRINT_ID_06")]
        [StringLength(40)]
        public string FormPrintId06 { get; set; }
        [Required]
        [Column("FORM_PRINT_ID_07")]
        [StringLength(40)]
        public string FormPrintId07 { get; set; }
        [Required]
        [Column("FORM_PRINT_ID_08")]
        [StringLength(40)]
        public string FormPrintId08 { get; set; }
        [Required]
        [Column("FORM_PRINT_ID_09")]
        [StringLength(40)]
        public string FormPrintId09 { get; set; }
        [Required]
        [Column("FORM_PRINT_ID_10")]
        [StringLength(40)]
        public string FormPrintId10 { get; set; }
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
