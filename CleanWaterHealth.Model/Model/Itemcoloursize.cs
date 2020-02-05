using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemcoloursize")]
    public partial class Itemcoloursize
    {
        [Key]
        [Column("itemcoloursize_id")]
        [StringLength(12)]
        public string ItemcoloursizeId { get; set; }
        [Column("itemcolour_id")]
        [StringLength(12)]
        public string ItemcolourId { get; set; }
        [Column("size")]
        [StringLength(16)]
        public string Size { get; set; }
        [Column("seq_in_itemcolour")]
        public int? SeqInItemcolour { get; set; }
        [Column("active_ind")]
        [StringLength(1)]
        public string ActiveInd { get; set; }
        [Column("sku")]
        [StringLength(16)]
        public string Sku { get; set; }
        [Column("barcode")]
        [StringLength(1)]
        public string Barcode { get; set; }
        [Column("sizesegmentsize_code")]
        [StringLength(12)]
        public string SizesegmentsizeCode { get; set; }
    }
}
