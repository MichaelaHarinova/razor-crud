using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorCrud.Models
{
    public class Herb
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Usage { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(15)]
        public string Part { get; set; }
        
        [Range(1, 100)]
        [Column(TypeName = "int(18, 0)")]
        public int Grams { get; set; }
        
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        

        
    }
}