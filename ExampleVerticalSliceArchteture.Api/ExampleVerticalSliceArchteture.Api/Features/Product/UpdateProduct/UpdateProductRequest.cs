using ExampleVerticalSliceArchteture.Api.Domain;

namespace ExampleVerticalSliceArchteture.Api.Features.Product.UpdateProduct
{
    public class UpdateProductRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
