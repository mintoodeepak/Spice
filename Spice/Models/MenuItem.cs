using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public string  Spicyness { get; set; }
        public enum ESpicy { NA=0, NotSpicy=1, Spicy=2, VerySpicy=3 }

        public string Image { get; set; }

        [Display(Name="Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [Display(Name = "SubCategory")]
        public int SubCategoryID { get; set; }
        [Range (1, int.MinValue, ErrorMessage ="Price should be greater than $ {1}")]
        public double Price { get; set; }

    }
}
