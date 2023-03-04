using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Contract.Models
{
    public class SupplierProductDto
    {
        public SupplierDto? SupplierDto { get; set; }
        public virtual ICollection<ProductCreateDto>? ProductDto { get; set; }
    }
}
