using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_WHT_TYPEs")]
    public partial class MWhtTypes
    {
        [Key]
        [Column("WHT_TYPE_ID")]
        public int WhtTypeId { get; set; }
        [Required]
        [Column("WHT_TYPE_NAME_TH")]
        [StringLength(70)]
        public string WhtTypeNameTh { get; set; }
        [Required]
        [Column("WHT_TYPE_NAME_EN")]
        [StringLength(70)]
        public string WhtTypeNameEn { get; set; }
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
        [Column("WHT_GROUP_TYPE")]
        public int WhtGroupType { get; set; }
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
