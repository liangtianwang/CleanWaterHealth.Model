using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemnoteannex")]
    public partial class Itemnoteannex
    {
        [Key]
        [Column("itemnote_id")]
        [StringLength(12)]
        public string ItemnoteId { get; set; }
        [Column("base_note_nar")]
        public string BaseNoteNar { get; set; }
    }
}
