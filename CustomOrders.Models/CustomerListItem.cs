using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomOrders.Models
{
    public class CustomerListItem
    {
        [Display(Name = "Customer Name")]
        public string Name { get; set; }
        [Display(Name = "Customer City")]
        public string City { get; set; }
        [Display(Name = "Customer State")]
        public string State { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        [Display(Name = "Active")]
        public bool Active { get; set; }
        [Display(Name = "Create Date")]
        public DateTimeOffset CreateDate { get; set; }
    }
}
