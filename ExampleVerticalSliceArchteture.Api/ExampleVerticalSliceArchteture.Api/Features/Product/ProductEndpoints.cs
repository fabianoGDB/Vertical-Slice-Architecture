using ExampleVerticalSliceArchteture.Api.Features.Product.CreateProduct;
using ExampleVerticalSliceArchteture.Api.Features.Product.DeleteProduct;
using ExampleVerticalSliceArchteture.Api.Features.Product.GetProductById;
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


            productGroup.MapGet("/all", async (ISender sender) =>
            {
                var response = await sender.Send(new GetAllProductQuery());
                return response != null ? Results.Ok(response) : Results.NotFound();
            });

            productGroup.MapDelete("/single/{id}", async (int id, ISender sender) =>
            {
                var response = await sender.Send(new GetProductByIdQuery(id));
                return response != null? Results.Ok(response) : Results.NotFound();
            });

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

            productGroup.MapDelete("/delete/{id}", async (int id, ISender sender) =>
            {
                var response = await sender.Send(new DeleteProductCommand(id));
                return response.Success ? Results.Ok(response) : Results.BadRequest(response);
            });

            return productGroup;
        }
    }
}
