using ExampleVerticalSliceArchteture.Api.Features.Product.CreateProduct;
using MediatR;
using Microsoft.AspNetCore.Routing;
using System.Runtime.CompilerServices;

namespace ExampleVerticalSliceArchteture.Api.Features.Product
{
    public static class ProductEndpoints
    {
        public static IEndpointConventionBuilder MappProductEndpoints(this IEndpointRouteBuilder endpoint)
        {
            var productGroup = endpoint.MapGroup("/product");
            productGroup.MapPost("create", async (CreateProductRequest product, ISender sender) =>
            {
                var response = await sender.Send(new CreateProductCommand(product));
                return response.Success ? Results.Ok(response) : Results.BadRequest(response);
            });
            return productGroup;
        }
    }
}
