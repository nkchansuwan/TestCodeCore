using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_FORM_PRINTs")]
    public partial class MFormPrints
    {
        [Key]
        [Column("FORM_PRINT_ID")]
        [StringLength(40)]
        public string FormPrintId { get; set; }
        [Required]
        [Column("CORP_ID")]
        [StringLength(40)]
        public string CorpId { get; set; }
        [Required]
        [Column("FORM_PRINT_CODE")]
        [StringLength(40)]
        public string FormPrintCode { get; set; }
        [Required]
        [Column("FORM_PRINT_NAME_TH")]
        [StringLength(70)]
        public string FormPrintNameTh { get; set; }
        [Required]
        [Column("FORM_PRINT_NAME_EN")]
        [StringLength(70)]
        public string FormPrintNameEn { get; set; }
        [Required]
        [Column("PAPERLESS_REPORT_ID")]
        [StringLength(40)]
        public string PaperlessReportId { get; set; }
        [Required]
        [Column("BARCODE_1_SQL_STRING_FILE")]
        [StringLength(150)]
        public string Barcode1SqlStringFile { get; set; }
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
