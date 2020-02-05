using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemcolourpp")]
    public partial class Itemcolourpp
    {
        [Key]
        [Column("barcode_code")]
        [StringLength(16)]
        public string BarcodeCode { get; set; }
        [Column("active_ind")]
        [StringLength(1)]
        public string ActiveInd { get; set; }
        [Column("itemcolour_id")]
        [StringLength(12)]
        public string ItemcolourId { get; set; }
        [Column("prepack_ref")]
        [StringLength(32)]
        public string PrepackRef { get; set; }
        [Column("seq_in_itemcolour")]
        public int? SeqInItemcolour { get; set; }
    }
}
