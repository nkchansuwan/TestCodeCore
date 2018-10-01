using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("R_ROLE_MENUs")]
    public partial class RRoleMenus
    {
        [Key]
        [Column("ROLE_MENU_ID")]
        [StringLength(40)]
        public string RoleMenuId { get; set; }
        [Required]
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Required]
        [Column("ROLE_ID")]
        [StringLength(40)]
        public string RoleId { get; set; }
        [Required]
        [Column("MENU_ID")]
        [StringLength(40)]
        public string MenuId { get; set; }
        [Column("CAN_VIEW")]
        public int CanView { get; set; }
        [Column("CAN_ADD")]
        public int CanAdd { get; set; }
        [Column("CAN_EDIT")]
        public int CanEdit { get; set; }
        [Column("CAN_DELETE")]
        public int CanDelete { get; set; }
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
