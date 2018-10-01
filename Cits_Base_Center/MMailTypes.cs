using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_MAIL_TYPEs")]
    public partial class MMailTypes
    {
        [Key]
        [Column("MAIL_TYPE_ID")]
        public int MailTypeId { get; set; }
        [Column("MAIL_TYPE_NAME")]
        [StringLength(70)]
        public string MailTypeName { get; set; }
        [Column("MAIL_TYPE_SUBJECT")]
        [StringLength(70)]
        public string MailTypeSubject { get; set; }
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
