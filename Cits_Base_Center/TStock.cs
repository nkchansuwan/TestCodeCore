using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("T_STOCK")]
    public partial class TStock
    {
        [Key]
        [Column("STOCK_ID")]
        [StringLength(40)]
        public string StockId { get; set; }
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Column("CORP_ID")]
        [StringLength(40)]
        public string CorpId { get; set; }
        [Column("BRANCH_ID")]
        [StringLength(40)]
        public string BranchId { get; set; }
        [Column("WHOUSE_ID")]
        [StringLength(40)]
        public string WhouseId { get; set; }
        [Column("ITEM_ID")]
        [StringLength(40)]
        public string ItemId { get; set; }
        [Column("LOT")]
        [StringLength(40)]
        public string Lot { get; set; }
        [Column("QTY", TypeName = "decimal(16, 4)")]
        public decimal? Qty { get; set; }
        [Column("REFER_ID_1")]
        [StringLength(40)]
        public string ReferId1 { get; set; }
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
