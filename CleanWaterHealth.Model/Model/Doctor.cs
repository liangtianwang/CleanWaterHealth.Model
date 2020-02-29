using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("doctor")]
    public partial class Doctor
    {
        [Key]
        [Column("doctor_id")]
        [StringLength(16)]
        public string DoctorID { get; set; }
        [Column("staff_id")]
        [StringLength(16)]
        public string StaffID { get; set; }      
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
