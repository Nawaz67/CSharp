using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FoodManagementEntity
{
    public class Sales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesId { get; set; }
        public string SalesName { get; set; }

        [ForeignKey("FoodItem")]
        public int Id { get; set; }
        public FoodItem FoodItem { get; set; }
       
        public int TotalItem { get; set; }
        public double TotalBill { get; set; }

             
    }
}
