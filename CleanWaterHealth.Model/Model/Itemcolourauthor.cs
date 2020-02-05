using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemcolourauthor")]
    public partial class Itemcolourauthor
    {
        [Key]
        [Column("itemcolourauthor_id")]
        [StringLength(12)]
        public string ItemcolourauthorId { get; set; }
        [Column("itemcolour_id")]
        [StringLength(12)]
        public string ItemcolourId { get; set; }
        [Column("author_code")]
        [StringLength(12)]
        public string AuthorCode { get; set; }
        [Column("short_name")]
        [StringLength(40)]
        public string ShortName { get; set; }
        [Column("seq_in_itemcolour")]
        public int? SeqInItemcolour { get; set; }
        [Column("main_author_ind")]
        [StringLength(1)]
        public string MainAuthorInd { get; set; }
    }
}
