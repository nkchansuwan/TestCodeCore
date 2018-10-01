using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_SENT_MAIL_CONF")]
    public partial class MSentMailConf
    {
        [Key]
        [Column("SENT_MAIL_CONF_ID")]
        [StringLength(40)]
        public string SentMailConfId { get; set; }
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Column("MAIL_TYPE_ID")]
        [StringLength(40)]
        public string MailTypeId { get; set; }
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
