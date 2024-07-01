using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProductStore.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required ,MaxLength(100)]
        public string Name { get; set; } = "";
        [Required,MaxLength(100)]
        public string Brand { get; set; } = "";
        [Required,MaxLength(100)]
        public string Category { get; set; } = "";
       
        public decimal Price { get; set; }
        [Required,MaxLength(100)]
        public string Color { get; set; } = "";

        public string Description { get; set; } = "";
        [MaxLength(100)]
        public IFormFile? ImageFile { get; set; } 
    }
}
