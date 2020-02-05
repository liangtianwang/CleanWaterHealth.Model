using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemgowith")]
    public partial class Itemgowith
    {
        [Key]
        [Column("itemgowith_id")]
        [StringLength(24)]
        public string ItemgowithId { get; set; }
        [Column("item_code")]
        [StringLength(12)]
        public string ItemCode { get; set; }
        [Column("item_code_gowith")]
        [StringLength(12)]
        public string ItemCodeGowith { get; set; }
        [Column("counter")]
        public int? Counter { get; set; }
        [Column("assessment_weeks")]
        public int? AssessmentWeeks { get; set; }
        [Column("run_datetime", TypeName = "datetime")]
        public DateTime? RunDatetime { get; set; }
        [Column("type_ind")]
        [StringLength(1)]
        public string TypeInd { get; set; }
        [Column("parent_counter")]
        public int? ParentCounter { get; set; }
    }
}
