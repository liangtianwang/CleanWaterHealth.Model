using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemsupplier")]
    public partial class Itemsupplier
    {
        [Key]
        [Column("itemsupplier_id")]
        [StringLength(12)]
        public string ItemsupplierId { get; set; }
        [Column("item_code")]
        [StringLength(16)]
        public string ItemCode { get; set; }
        [Column("seq_in_item")]
        public int? SeqInItem { get; set; }
        [Column("supplier_code")]
        [StringLength(12)]
        public string SupplierCode { get; set; }
        [Column("supplier_item_number")]
        [StringLength(32)]
        public string SupplierItemNumber { get; set; }
        [Column("primary_ind")]
        [StringLength(1)]
        public string PrimaryInd { get; set; }
        [Column("active_ind")]
        [StringLength(1)]
        public string ActiveInd { get; set; }
        [Column("edi_ind")]
        [StringLength(1)]
        public string EdiInd { get; set; }
    }
}
