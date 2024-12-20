using ExampleVerticalSliceArchteture.Api.Domain;

namespace ExampleVerticalSliceArchteture.Api.Features.Product
{
    public class GetProductResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
