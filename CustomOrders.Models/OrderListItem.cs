using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomOrders.Models
{
    public class OrderListItem
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        [Display(Name = "Customer Name")]
        public string Name { get; set; }
        [Display(Name = "Create Date")]
        public DateTimeOffset CreateDate { get; set; }
    }
}
