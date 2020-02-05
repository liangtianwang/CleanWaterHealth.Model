using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemcolourattrval")]
    public partial class Itemcolourattrval
    {
        [Key]
        [Column("itemcolourattrval_id")]
        [StringLength(12)]
        public string ItemcolourattrvalId { get; set; }
        [Column("itemcolour_id")]
        [StringLength(12)]
        public string ItemcolourId { get; set; }
        [Column("seq_in_itemcolour")]
        public int? SeqInItemcolour { get; set; }
        [Column("attribute_id")]
        [StringLength(12)]
        public string AttributeId { get; set; }
        [Column("actual_value")]
        [StringLength(64)]
        public string ActualValue { get; set; }
        [Column("attributevalue_id")]
        [StringLength(12)]
        public string AttributevalueId { get; set; }
    }
}
