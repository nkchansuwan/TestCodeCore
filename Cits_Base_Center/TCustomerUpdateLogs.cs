using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("T_CUSTOMER_UPDATE_LOGs")]
    public partial class TCustomerUpdateLogs
    {
        [Key]
        [Column("CUSTOMER_UPDATE_LOG_ID")]
        [StringLength(40)]
        public string CustomerUpdateLogId { get; set; }
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Column("USER_ID")]
        [StringLength(40)]
        public string UserId { get; set; }
        [Column("UPDATE_FIELD")]
        [StringLength(125)]
        public string UpdateField { get; set; }
        [Column("OLD_DATA")]
        [StringLength(125)]
        public string OldData { get; set; }
        [Column("NEW_DATA")]
        [StringLength(125)]
        public string NewData { get; set; }
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
