using ExampleVerticalSliceArchteture.Api.Exceptions;
using ExampleVerticalSliceArchteture.Api.Features.Product;
using ExampleVerticalSliceArchteture.Api.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlite(builder.Configuration.GetConnectionString("ConnectionString")));
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(Program).Assembly));

var app = builder.Build();

app.UseExceptionHandler(_ => { });

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapScalarApiReference();

app.MapControllers();

app.MappProductEndpoints();


app.Run();