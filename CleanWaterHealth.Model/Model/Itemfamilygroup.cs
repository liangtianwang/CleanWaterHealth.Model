using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemfamilygroup")]
    public partial class Itemfamilygroup
    {
        [Key]
        [Column("itemfamilygroup_code")]
        [StringLength(12)]
        public string ItemfamilygroupCode { get; set; }
        [Column("description")]
        [StringLength(50)]
        public string Description { get; set; }
        [Column("active_ind")]
        [StringLength(1)]
        public string ActiveInd { get; set; }
    }
}
