using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_WHT_INCOME_TYPEs")]
    public partial class MWhtIncomeTypes
    {
        [Key]
        [Column("WHT_INCOME_TYPE_ID")]
        public int WhtIncomeTypeId { get; set; }
        [Required]
        [Column("WHT_INCOME_TYPE_NAME_TH")]
        [StringLength(70)]
        public string WhtIncomeTypeNameTh { get; set; }
        [Required]
        [Column("WHT_INCOME_TYPE_NAME_EN")]
        [StringLength(70)]
        public string WhtIncomeTypeNameEn { get; set; }
        [Column("WHT_RATE", TypeName = "decimal(16, 4)")]
        public decimal WhtRate { get; set; }
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
