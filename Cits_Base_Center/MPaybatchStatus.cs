using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_PAYBATCH_STATUS")]
    public partial class MPaybatchStatus
    {
        [Key]
        [Column("PAYBATCH_STATUS_ID")]
        public int PaybatchStatusId { get; set; }
        [Required]
        [Column("PAYBATCH_STATUS_NAME_TH")]
        [StringLength(70)]
        public string PaybatchStatusNameTh { get; set; }
        [Required]
        [Column("PAYBATCH_STATUS_NAME_EN")]
        [StringLength(70)]
        public string PaybatchStatusNameEn { get; set; }
        [Column("PAYBATCH_STATUS_TYPE")]
        public int PaybatchStatusType { get; set; }
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
