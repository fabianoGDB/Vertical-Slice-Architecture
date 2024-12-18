using ExampleVerticalSliceArchteture.Api.Domain;

namespace ExampleVerticalSliceArchteture.Api.Features.Product.CreateProduct
{
    public class CreateProductRequest
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
