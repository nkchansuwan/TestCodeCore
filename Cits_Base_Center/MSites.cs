using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_SITEs")]
    public partial class MSites
    {
        [Key]
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Required]
        [Column("SITE_CODE")]
        [StringLength(40)]
        public string SiteCode { get; set; }
        [Required]
        [Column("SITE_NAME")]
        [StringLength(70)]
        public string SiteName { get; set; }
        [Required]
        [Column("SITE_DOMAIN_NAME")]
        [StringLength(120)]
        public string SiteDomainName { get; set; }
        [Required]
        [Column("SITE_SKIN_CSS")]
        [StringLength(120)]
        public string SiteSkinCss { get; set; }
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
