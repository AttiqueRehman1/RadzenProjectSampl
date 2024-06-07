
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domains.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool Stiched { get; set; }
        public bool UnStiched { get; set; }
        public List<Product_IMAGE> Images { get; set; } = new List<Product_IMAGE>();
    }
}
