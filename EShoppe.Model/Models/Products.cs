using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShoppe.Models.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DisplayName("Display Order")]
        public string Description { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        [Display(Name = "List Price")]
        [Range(1, 10000)]
        public int ListPrice { get; set; }

        [Required]
        [Display(Name =" Price for 1-50")]
        [Range(1, 10000)]
        public int Price50 { get; set; }

        [Required]
        [Display(Name = "Price 50-100")]
        [Range(1, 10000)]
        public int Price100 { get; set; }

        [Required]
        [Display(Name = " Price")]
        [Range(1, 10000)]
        public int Price { get; set; }
    }
}
