using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemcoloursysref")]
    public partial class Itemcoloursysref
    {
        [Key]
        [Column("itemcoloursysref_id")]
        [StringLength(12)]
        public string ItemcoloursysrefId { get; set; }
        [Column("systemtype_code")]
        [StringLength(12)]
        public string SystemtypeCode { get; set; }
        [Column("itemcolour_id")]
        [StringLength(12)]
        public string ItemcolourId { get; set; }
        [Column("itemcolour_ref")]
        [StringLength(32)]
        public string ItemcolourRef { get; set; }
        [Column("active_ind")]
        [StringLength(1)]
        public string ActiveInd { get; set; }
        [Column("seq_in_itemcolour")]
        public int? SeqInItemcolour { get; set; }
    }
}
