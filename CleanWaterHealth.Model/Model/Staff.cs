using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("staff")]
    public partial class Staff
    {
        [Key]
        [Column("staff_id")]
        [StringLength(16)]
        public string StaffID { get; set; }
        [Column("person_id")]
        [StringLength(16)]
        public string PersonID { get; set; }      
        [Column("insert_user")]
        [StringLength(32)]
        public string InsertUser { get; set; }
        [Column("insert_date_time", TypeName = "datetime")]
        public DateTime? InsertDateTime { get; set; }
        [Column("update_user")]
        [StringLength(32)]
        public string UpdateUser { get; set; }
        [Column("update_date_time", TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }

    }
}
