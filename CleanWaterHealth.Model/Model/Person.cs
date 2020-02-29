using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("person")]
    public partial class Person
    {
        [Key]
        [Column("person_id")]
        [StringLength(16)]
        public string PersonID { get; set; }
        [Column("person_title")]
        [StringLength(32)]
        public string PersonTitle { get; set; }
        [Column("first_name")]
        [StringLength(64)]
        public string FirstName { get; set; }
        [Column("second_name")]
        [StringLength(64)]
        public string SecondName { get; set; }
        [Column("family_name")]
        [StringLength(50)]
        public string FamilyName { get; set; }       
        [Column("date_of_birth", TypeName = "datetime")]
        public DateTime? DateOfBirth { get; set; }
        [Column("gender_ind")]
        [StringLength(1)]
        public string GenderInd { get; set; }
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
