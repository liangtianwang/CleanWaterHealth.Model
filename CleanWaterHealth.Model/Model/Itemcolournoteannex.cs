using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemcolournoteannex")]
    public partial class Itemcolournoteannex
    {
        [Key]
        [Column("itemcolournote_id")]
        [StringLength(12)]
        public string ItemcolournoteId { get; set; }
        [Column("base_note_nar")]
        [StringLength(1500)]
        public string BaseNoteNar { get; set; }
    }
}
