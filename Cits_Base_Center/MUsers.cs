using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_USERs")]
    public partial class MUsers
    {
        [Key]
        [Column("USER_ID")]
        [StringLength(40)]
        public string UserId { get; set; }
        [Required]
        [Column("FIREBASE_ID")]
        [StringLength(40)]
        public string FirebaseId { get; set; }
        [Required]
        [Column("EMAIL")]
        [StringLength(70)]
        public string Email { get; set; }
        [Required]
        [Column("DISPLAY_NAME")]
        [StringLength(70)]
        public string DisplayName { get; set; }
        [Required]
        [Column("ROLE_ID")]
        [StringLength(40)]
        public string RoleId { get; set; }
        [Required]
        [Column("MFA_KEY")]
        [StringLength(40)]
        public string MfaKey { get; set; }
        [Column("MFA_STATUS")]
        public int MfaStatus { get; set; }
        [Column("MFA_CREATE_DATE", TypeName = "datetime")]
        public DateTime MfaCreateDate { get; set; }
        [Column("CURRENCY_ID")]
        [StringLength(40)]
        public string CurrencyId { get; set; }
        [Column("ACTIVE_STATUS")]
        public int ActiveStatus { get; set; }
        [Column("ACTIVE_STATUS_DATE", TypeName = "datetime")]
        public DateTime ActiveStatusDate { get; set; }
        [Column("DELETE_STATUS")]
        public int DeleteStatus { get; set; }
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
