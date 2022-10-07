using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodManagementEntity
{
    public class FoodCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        [ForeignKey("FoodItem")]
        public int Id { get; set; }
        public FoodItem FoodItem { get; set; }
        
    }
}
