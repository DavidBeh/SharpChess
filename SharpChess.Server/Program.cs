using System.Text.Json.Serialization;
using NSwag;
using NSwag.Generation.Processors.Security;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); // Enums as string in swagger
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument(settings =>
{
    // Add Bearer token authentication to the Swagger UI
    settings.AddSecurity("Bearer", Enumerable.Empty<string>(), new OpenApiSecurityScheme
    {
        Type = OpenApiSecuritySchemeType.ApiKey,
        Name = "Authorization",
        In = OpenApiSecurityApiKeyLocation.Header,
        Description = "Format: \"Bearer TOKEN\""
    });
    settings.Title = "SharpChess API";
    
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();

    // Use UI
    app.UseSwaggerUi3();
    app.UseReDoc(settings => { settings.Path = "/redoc"; });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();