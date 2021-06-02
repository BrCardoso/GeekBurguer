using GeekBurguer.Products.Contract.Enums;

namespace GeekBurguer.Products.Contract.Models
{
    public class ProductChanged
    {
        public ProductState State { get; set; }
        public Product Product { get; set; }
    }

}
