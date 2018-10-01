using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_BANKs")]
    public partial class MBanks
    {
        [Key]
        [Column("BANK_ID")]
        [StringLength(40)]
        public string BankId { get; set; }
        [Required]
        [Column("BANK_CODE")]
        [StringLength(40)]
        public string BankCode { get; set; }
        [Required]
        [Column("BANK_BOTCODE")]
        [StringLength(40)]
        public string BankBotcode { get; set; }
        [Required]
        [Column("BANK_NAME_TH")]
        [StringLength(70)]
        public string BankNameTh { get; set; }
        [Required]
        [Column("BANK_NAME_EN")]
        [StringLength(70)]
        public string BankNameEn { get; set; }
        [Required]
        [Column("BANK_COLOR_RGB")]
        [StringLength(40)]
        public string BankColorRgb { get; set; }
        [Required]
        [Column("TEXT_COLOR_RGB")]
        [StringLength(40)]
        public string TextColorRgb { get; set; }
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
