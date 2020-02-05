using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemglgroup")]
    public partial class Itemglgroup
    {
        [Key]
        [Column("itemglgroup_code")]
        [StringLength(12)]
        public string ItemglgroupCode { get; set; }
        [Column("description")]
        [StringLength(50)]
        public string Description { get; set; }
        [Column("sales_gltranslation_code")]
        [StringLength(12)]
        public string SalesGltranslationCode { get; set; }
        [Column("disc_gltranslation_code")]
        [StringLength(12)]
        public string DiscGltranslationCode { get; set; }
        [Column("gp_gltranslation_code")]
        [StringLength(12)]
        public string GpGltranslationCode { get; set; }
        [Column("active_ind")]
        [StringLength(1)]
        public string ActiveInd { get; set; }
        [Column("ret_gltranslation_code")]
        [StringLength(12)]
        public string RetGltranslationCode { get; set; }
        [Column("dis_rt_gltranslation_code")]
        [StringLength(12)]
        public string DisRtGltranslationCode { get; set; }
    }
}
