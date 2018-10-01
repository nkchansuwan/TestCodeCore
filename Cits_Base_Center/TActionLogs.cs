using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("T_ACTION_LOGs")]
    public partial class TActionLogs
    {
        [Key]
        [Column("ACTION_LOG_ID")]
        [StringLength(40)]
        public string ActionLogId { get; set; }
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Required]
        [Column("USER_ID")]
        [StringLength(40)]
        public string UserId { get; set; }
        [Column("MENU_ID")]
        [StringLength(40)]
        public string MenuId { get; set; }
        [Required]
        [Column("ACTION")]
        [StringLength(70)]
        public string Action { get; set; }
        [Column("DELETE_STATUS")]
        public int? DeleteStatus { get; set; }
        [Column("CREATE_DATE", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("CREATE_BY")]
        [StringLength(40)]
        public string CreateBy { get; set; }
        [Column("UPDATE_DATE", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("UPDATE_BY")]
        [StringLength(40)]
        public string UpdateBy { get; set; }
        [Column("REVISION")]
        public int? Revision { get; set; }
    }
}
