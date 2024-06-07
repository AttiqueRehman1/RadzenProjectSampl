
using System.ComponentModel.DataAnnotations;

namespace Domains.Models
{
    public class ProductDetail
    {
        [Key]
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public List<string> Sizes { get; set; } = new List<string>();
        public string Instructions { get; set; } = string.Empty;
    }
}
