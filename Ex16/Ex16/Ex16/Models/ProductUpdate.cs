using Ex16.Enums;

namespace Ex16.Models
{
    public class ProductUpdate
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }
    }
}
