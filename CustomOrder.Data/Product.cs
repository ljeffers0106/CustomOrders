using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomOrder.Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Manufacturer Name")]
        public string Manufacturer { get; set; }
        [Required]
        [Display(Name = "Color")]
        public string Color { get; set; }
        [Required]
        [Display(Name = "Unit Size")]
        public string UnitSize { get; set; }
        [Display(Name = "Date Added")]
        public DateTimeOffset DateAdded { get; set; }
        [Display(Name = "Active")]
        public bool ProductActive { get; set; }
    }
}
