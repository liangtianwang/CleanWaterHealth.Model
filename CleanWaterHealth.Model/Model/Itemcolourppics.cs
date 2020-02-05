using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemcolourppics")]
    public partial class Itemcolourppics
    {
        [Key]
        [Column("itemcolourppics_id")]
        [StringLength(12)]
        public string ItemcolourppicsId { get; set; }
        [Column("barcode_code")]
        [StringLength(16)]
        public string BarcodeCode { get; set; }
        [Column("itemcoloursize_id")]
        [StringLength(12)]
        public string ItemcoloursizeId { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
    }
}
