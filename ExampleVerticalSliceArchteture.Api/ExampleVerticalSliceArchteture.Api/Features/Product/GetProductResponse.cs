using ExampleVerticalSliceArchteture.Api.Domain;

namespace ExampleVerticalSliceArchteture.Api.Features.Product
{
    public class GetProductResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? CategoryName { get; set; }
        public int CategoryId { get; set; }
    }
}
