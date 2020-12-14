using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomOrder.Data
{
    public enum Status
    {
        New = 1,
        InProcess = 2,
        Complete = 3,
        Canceled = 4
    }

    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        [Required]
        [Display(Name = "Customer Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Create Date")]
        public DateTimeOffset CreateDate { get; set; }
        [Required]
        public Status StatusType { get; set; }
        [Required]
        [Display(Name = "Status Date")]
        public DateTimeOffset StatusDate { get; set; }
    }
}
