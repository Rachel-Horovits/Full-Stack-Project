using BL;
using BL.Api;
using Dal;
using Dal.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddSingleton<IBLManager, BlManager>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

app.UseCors("AllowAllOrigins");

app.UseAuthorization();
app.MapControllers();

app.Run();
