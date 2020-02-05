using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemimage")]
    public partial class Itemimage
    {
        [Key]
        [Column("itemimage_id")]
        [StringLength(12)]
        public string ItemimageId { get; set; }
        [Required]
        [Column("item_code")]
        [StringLength(16)]
        public string ItemCode { get; set; }
        [Column("image_code")]
        [StringLength(24)]
        public string ImageCode { get; set; }
        [Column("imagetype_code")]
        [StringLength(12)]
        public string ImagetypeCode { get; set; }
        [Column("description")]
        [StringLength(50)]
        public string Description { get; set; }
        [Column("seq_in_item")]
        public int? SeqInItem { get; set; }
    }
}
