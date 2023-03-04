using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Contract.Models
{
    public class SupplierDto
    {
        [Display(Name = "Supplier Name")]
        [Required]
        [StringLength(50, ErrorMessage = "Company name cannot be longer than 50")]
        public string? CompanyName { get; set; }
        [Required]
        public string? Address { get; set;}
    }
}
