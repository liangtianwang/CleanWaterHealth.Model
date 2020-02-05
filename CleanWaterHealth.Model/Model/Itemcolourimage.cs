using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemcolourimage")]
    public partial class Itemcolourimage
    {
        [Key]
        [Column("itemcolourimage_id")]
        [StringLength(12)]
        public string ItemcolourimageId { get; set; }
        [Column("itemcolour_id")]
        [StringLength(12)]
        public string ItemcolourId { get; set; }
        [Column("image_code")]
        [StringLength(24)]
        public string ImageCode { get; set; }
        [Column("active_ind")]
        [StringLength(1)]
        public string ActiveInd { get; set; }
        [Column("description")]
        [StringLength(50)]
        public string Description { get; set; }
        [Column("seq_in_itemcolour")]
        public int? SeqInItemcolour { get; set; }
        [Column("imagetype_code")]
        [StringLength(12)]
        public string ImagetypeCode { get; set; }
    }
}
