using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_APPs")]
    public partial class MApps
    {
        [Key]
        [Column("APP_ID")]
        [StringLength(40)]
        public string AppId { get; set; }
        [Required]
        [Column("APP_CODE")]
        [StringLength(40)]
        public string AppCode { get; set; }
        [Required]
        [Column("APP_NAME_TH")]
        [StringLength(70)]
        public string AppNameTh { get; set; }
        [Required]
        [Column("APP_NAME_EN")]
        [StringLength(70)]
        public string AppNameEn { get; set; }
        [Required]
        [Column("APP_DOMAIN_NAME")]
        [StringLength(120)]
        public string AppDomainName { get; set; }
        [Required]
        [Column("APP_SKIN_CSS")]
        [StringLength(120)]
        public string AppSkinCss { get; set; }
        [Column("ACTIVE_STATUS")]
        public int ActiveStatus { get; set; }
        [Column("ACTIVE_STATUS_DATE", TypeName = "datetime")]
        public DateTime ActiveStatusDate { get; set; }
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
