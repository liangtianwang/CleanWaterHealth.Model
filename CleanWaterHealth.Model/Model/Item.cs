using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CleanWaterHealth.Model.Model
{
    public class Item
    {
        [Key]
        [Column(Order = 1)]
        public string item_code { get; set; }

        [Column(Order = 2)]
        public string description { get; set; }
    }
}
