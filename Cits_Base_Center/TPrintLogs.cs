using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("T_PRINT_LOGs")]
    public partial class TPrintLogs
    {
        [Key]
        [Column("PRINT_LOG_ID")]
        [StringLength(40)]
        public string PrintLogId { get; set; }
        [Required]
        [Column("USER_ID")]
        [StringLength(40)]
        public string UserId { get; set; }
        [Required]
        [Column("FORM_PRINT_ID")]
        [StringLength(40)]
        public string FormPrintId { get; set; }
        [Required]
        [Column("MASTER_ID")]
        [StringLength(40)]
        public string MasterId { get; set; }
        [Required]
        [Column("APP_ID")]
        [StringLength(40)]
        public string AppId { get; set; }
        [Column("NUMBER_OF_PRINTING")]
        public int NumberOfPrinting { get; set; }
        [Required]
        [Column("TOTALAMT_TEXT_TH")]
        [StringLength(150)]
        public string TotalamtTextTh { get; set; }
        [Required]
        [Column("TOTALAMT_TEXT_EN")]
        [StringLength(150)]
        public string TotalamtTextEn { get; set; }
        [Required]
        [Column("BARCODE_1")]
        [StringLength(150)]
        public string Barcode1 { get; set; }
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
