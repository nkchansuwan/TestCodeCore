using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_REFTYPE")]
    public partial class MReftype
    {
        [Key]
        [Column("REFTYPE_ID")]
        [StringLength(40)]
        public string ReftypeId { get; set; }
        [Required]
        [Column("REFTYPE_NAME_TH")]
        [StringLength(70)]
        public string ReftypeNameTh { get; set; }
        [Required]
        [Column("REFTYPE_NAME_EN")]
        [StringLength(70)]
        public string ReftypeNameEn { get; set; }
        [Required]
        [Column("REFTYPE_GROUP")]
        [StringLength(40)]
        public string ReftypeGroup { get; set; }
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
