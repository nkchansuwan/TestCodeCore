using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cits_Base_Center
{
    [Table("M_PACKING_ITEMs")]
    public partial class MPackingItems
    {
        [Key]
        [Column("PACKING_ITEM_ID")]
        [StringLength(40)]
        public string PackingItemId { get; set; }
        [Required]
        [Column("SITE_ID")]
        [StringLength(40)]
        public string SiteId { get; set; }
        [Required]
        [Column("CORP_ID")]
        [StringLength(40)]
        public string CorpId { get; set; }
        [Required]
        [Column("PACKING_ITEM_CODE")]
        [StringLength(40)]
        public string PackingItemCode { get; set; }
        [Required]
        [Column("PACKING_ITEM_NAME")]
        [StringLength(70)]
        public string PackingItemName { get; set; }
        [Required]
        [Column("PACKING_ITEM_DESCRIPTION")]
        [StringLength(250)]
        public string PackingItemDescription { get; set; }
        [Required]
        [Column("UM_NAME_QTY1")]
        [StringLength(70)]
        public string UmNameQty1 { get; set; }
        [Required]
        [Column("UM_NAME_QTY2")]
        [StringLength(70)]
        public string UmNameQty2 { get; set; }
        [Required]
        [Column("UM_NAME_QTY3")]
        [StringLength(70)]
        public string UmNameQty3 { get; set; }
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
