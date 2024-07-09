using FactoryDbContext.Data;
using FactoryDbContext.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddSingleton<IApplicationDbContextFactory, ApplicationDbContextFactory>();
builder.Services.AddScoped<ProductRepository>();


var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();




//dotnet ef migrations remove --force
//dotnet ef database drop --force
//dotnet ef migrations add InitialCreate
//dotnet ef database update