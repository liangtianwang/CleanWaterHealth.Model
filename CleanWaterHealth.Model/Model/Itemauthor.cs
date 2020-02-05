using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemauthor")]
    public partial class Itemauthor
    {
        [Key]
        [Column("itemauthor_id")]
        [StringLength(12)]
        public string ItemauthorId { get; set; }
        [Column("item_code")]
        [StringLength(16)]
        public string ItemCode { get; set; }
        [Column("author_name")]
        [StringLength(30)]
        public string AuthorName { get; set; }
        [Column("seq_in_item")]
        public int? SeqInItem { get; set; }
        [Column("author_code")]
        [StringLength(12)]
        public string AuthorCode { get; set; }
    }
}
