using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_MENUs")]
    public partial class MMenus
    {
        [Key]
        [Column("MENU_ID")]
        [StringLength(36)]
        public string MenuId { get; set; }
        [Column("MENU_CODE")]
        [StringLength(40)]
        public string MenuCode { get; set; }
        [Column("MENU_NAME")]
        [StringLength(70)]
        public string MenuName { get; set; }
        [Column("MENU_GROUP")]
        public int? MenuGroup { get; set; }
        [Column("DELETE_STATUS")]
        public int? DeleteStatus { get; set; }
        [Column("CREATE_DATE", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("CREATE_BY")]
        [StringLength(36)]
        public string CreateBy { get; set; }
        [Column("UPDATE_DATE", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("UPDATE_BY")]
        [StringLength(36)]
        public string UpdateBy { get; set; }
        [Column("REVISION")]
        public int? Revision { get; set; }
    }
}
