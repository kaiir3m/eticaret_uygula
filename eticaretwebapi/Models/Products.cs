using System.ComponentModel.DataAnnotations;

namespace eticaretwebapi.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; } = string.Empty;
        public int? ProductCode { get; set; }
        public string? ProductDescription { get; set; } = string.Empty;
        public int? ProductPrice { get; set; }
        public string? ProductPicture { get; set; } = string.Empty;
        public int? CategoryId { get; set; }

    }
}
