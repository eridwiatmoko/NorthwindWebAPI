using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Contract.Models
{
    public class ProductPhotoGroupDto
    {


        [Required]
        public ProductCreateDto? ProductForCreateDto { get; set; }


        public List<IFormFile>? AllPhotos { get; set; }
    }
}
