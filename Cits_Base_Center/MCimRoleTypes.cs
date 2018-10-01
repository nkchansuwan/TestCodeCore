using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_CIM_ROLE_TYPEs")]
    public partial class MCimRoleTypes
    {
        [Key]
        [Column("ROLE_TYPE_ID")]
        public int RoleTypeId { get; set; }
        [Required]
        [Column("ROLE_TYPE_NAME_TH")]
        [StringLength(70)]
        public string RoleTypeNameTh { get; set; }
        [Required]
        [Column("ROLE_TYPE_NAME_EN")]
        [StringLength(70)]
        public string RoleTypeNameEn { get; set; }
        [Column("DELETE_STAT")]
        public int DeleteStat { get; set; }
        [Required]
        [Column("CREATE_BY")]
        [StringLength(40)]
        public string CreateBy { get; set; }
        [Column("CREATE_DATE", TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Required]
        [Column("UPDATE_BY")]
        [StringLength(40)]
        public string UpdateBy { get; set; }
        [Column("UPDATE_DATE", TypeName = "datetime")]
        public DateTime UpdateDate { get; set; }
        [Column("REVISION")]
        public int Revision { get; set; }
    }
}
