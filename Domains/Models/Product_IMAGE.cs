
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domains.Models
{
    [Table("Product_IMAGE")]
    public class Product_IMAGE
    {
        [Key]
        public int ImageID { get; set; }
        public int ProductID { get; set; }
        public string? ImageUrl { get; set; }
        public string? Caption { get; set; }
        public Product? Product { get; set; }
    }
}
