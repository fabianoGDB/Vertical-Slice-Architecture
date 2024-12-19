using ExampleVerticalSliceArchteture.Api.Features.Product.CreateProduct;
using ExampleVerticalSliceArchteture.Api.Features.Product.DeleteProduct;
using ExampleVerticalSliceArchteture.Api.Features.Product.UpdateProduct;
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

            productGroup.MapPost("/create", async (CreateProductRequest product, ISender sender) =>
            {
                var response = await sender.Send(new CreateProductCommand(product));
                return response.Success ? Results.Ok(response) : Results.BadRequest(response);
            });

            productGroup.MapPut("/update", async (UpdateProductRequest product, ISender sender) =>
            {
                var response = await sender.Send(new UpdateProductCommand(product));
                return response.Success ? Results.Ok(response) : Results.BadRequest(response);
            });

            productGroup.MapDelete("/delete/{id:int}", async (int id, ISender sender) =>
            {
                var response = await sender.Send(new DeleteProductCommand(id));
                return response.Success ? Results.Ok(response) : Results.BadRequest(response);
            });
            return productGroup;
        }
    }
}
