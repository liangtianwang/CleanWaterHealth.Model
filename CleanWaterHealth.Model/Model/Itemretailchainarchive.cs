using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemretailchainarchive")]
    public partial class Itemretailchainarchive
    {
        [Key]
        [Column("itemretailchain_id")]
        [StringLength(12)]
        public string ItemretailchainId { get; set; }
        [Column("item_code")]
        [StringLength(12)]
        public string ItemCode { get; set; }
        [Column("retailchain_code")]
        [StringLength(12)]
        public string RetailchainCode { get; set; }
        [Column("division_code")]
        [StringLength(12)]
        public string DivisionCode { get; set; }
    }
}
