using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("T_SENT_MAIL_LOGs")]
    public partial class TSentMailLogs
    {
        [Key]
        [Column("SENT_MAIL_LOG_ID")]
        [StringLength(40)]
        public string SentMailLogId { get; set; }
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Column("USER_ID")]
        [StringLength(40)]
        public string UserId { get; set; }
        [Column("MAIL_TYPE_ID")]
        public int? MailTypeId { get; set; }
        [Column("SENT_DATE", TypeName = "datetime")]
        public DateTime? SentDate { get; set; }
        [Column("EXPIRE_STATUS")]
        public int? ExpireStatus { get; set; }
        [Column("DELETE_STATUS")]
        public int? DeleteStatus { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(250)]
        public string Description { get; set; }
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
