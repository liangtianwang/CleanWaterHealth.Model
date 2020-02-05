using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemcolournote")]
    public partial class Itemcolournote
    {
        [Key]
        [Column("itemcolournote_id")]
        [StringLength(12)]
        public string ItemcolournoteId { get; set; }
        [Column("notetype_code")]
        [StringLength(12)]
        public string NotetypeCode { get; set; }
        [Column("itemcolour_id")]
        [StringLength(12)]
        public string ItemcolourId { get; set; }
        [Column("note_nar")]
        [StringLength(255)]
        public string NoteNar { get; set; }
        [Column("seq_in_itemcolour")]
        public int? SeqInItemcolour { get; set; }
    }
}
