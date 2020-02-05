using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemnote")]
    public partial class Itemnote
    {
        [Key]
        [Column("itemnote_id")]
        [StringLength(12)]
        public string ItemnoteId { get; set; }
        [Column("notetype_code")]
        [StringLength(12)]
        public string NotetypeCode { get; set; }
        [Column("item_code")]
        [StringLength(12)]
        public string ItemCode { get; set; }
        [Column("note_nar")]
        [StringLength(255)]
        public string NoteNar { get; set; }
    }
}
