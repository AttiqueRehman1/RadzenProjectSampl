
using System.ComponentModel.DataAnnotations;

namespace Domains.Models
{
    public class Slide
    {
        [Key]
        public int SlideIndex { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Caption { get; set; } = string.Empty;
    }
}
