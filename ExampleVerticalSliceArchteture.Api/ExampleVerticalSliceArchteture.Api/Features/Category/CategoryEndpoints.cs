using ExampleVerticalSliceArchteture.Api.Features.Category.CreateCategory;
using ExampleVerticalSliceArchteture.Api.Features.Category.CreateProduct;
using ExampleVerticalSliceArchteture.Api.Features.Product.CreateProduct;
using ExampleVerticalSliceArchteture.Api.Features.Product.DeleteProduct;
using ExampleVerticalSliceArchteture.Api.Features.Product.GetProductById;
using ExampleVerticalSliceArchteture.Api.Features.Product.UpdateProduct;
using MediatR;
using Microsoft.AspNetCore.Routing;
using System.Runtime.CompilerServices;

namespace ExampleVerticalSliceArchteture.Api.Features.Category
{
    public static class CategoryEndpoints
    {
        public static IEndpointConventionBuilder MappCategoryEndpoints(this IEndpointRouteBuilder endpoint)
        {
            var categoryGroup = endpoint.MapGroup("/category");


            categoryGroup.MapPost("/create", async (CreateCategoryRequest category, ISender sender) =>
            {
                var response = await sender.Send(new CreateCategoryCommand(category));
                return response.Success ? Results.Ok(response) : Results.BadRequest(response);
            });

            return categoryGroup;
        }
    }
}
