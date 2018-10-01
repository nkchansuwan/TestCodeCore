﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_CURRENCYs")]
    public partial class MCurrencys
    {
        [Key]
        [Column("CURRENCY_ID")]
        [StringLength(40)]
        public string CurrencyId { get; set; }
        [Required]
        [Column("CURRENCY_NAME_TH")]
        [StringLength(70)]
        public string CurrencyNameTh { get; set; }
        [Required]
        [Column("CURRENCY_NAME_EN")]
        [StringLength(70)]
        public string CurrencyNameEn { get; set; }
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
