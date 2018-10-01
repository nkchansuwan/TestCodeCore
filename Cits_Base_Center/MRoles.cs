using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_ROLEs")]
    public partial class MRoles
    {
        [Key]
        [Column("ROLE_ID")]
        [StringLength(40)]
        public string RoleId { get; set; }
        [Required]
        [Column("ROLE_CODE")]
        [StringLength(40)]
        public string RoleCode { get; set; }
        [Required]
        [Column("ROLE_NAME")]
        [StringLength(70)]
        public string RoleName { get; set; }
        [Column("DELETE_STATUS")]
        public int DeleteStatus { get; set; }
        [Column("CREATE_DATE", TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Column("CREATE_BY")]
        [StringLength(40)]
        public string CreateBy { get; set; }
        [Column("UPDATE_DATE", TypeName = "datetime")]
        public DateTime UpdateDate { get; set; }
        [Column("UPDATE_BY")]
        [StringLength(40)]
        public string UpdateBy { get; set; }
        [Column("REVISION")]
        public int Revision { get; set; }
    }
}
