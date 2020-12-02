using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomOrder.Data
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public Guid CustomerCode { get; set; }
        [Required]
        [Display(Name = "Customer Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Customer Address Line 1")]
        public string Address1 { get; set; }
        [Display(Name = "Customer Address Line 2")]
        public string Address2{ get; set; }
        [Required]
        [Display(Name = "Customer City")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Customer State")]
        public string State { get; set; }
        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        [Display(Name = "Active")]
        public bool Active { get; set; }
        [Required]
        [Display(Name = "Create Date")]
        public DateTimeOffset CreateDate { get; set; }
    }
}
