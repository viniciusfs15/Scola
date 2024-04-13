using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContext>(options =>
{
  options.UseSqlite(builder.Configuration.GetConnectionString("MyConnectionString"),
            x => x.MigrationsAssembly("Scola.DBContext"));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
  var services = scope.ServiceProvider;
  var context = services.GetRequiredService<DbContext>();

  // Aplicar migrações
  context.Database.Migrate();
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI(options =>
  {
    options.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
    options.DefaultModelsExpandDepth(-1);
  });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



var port = builder.Configuration.GetSection("AppSettings")["Port"] ?? "7123";
app.Run($"http://localhost:{port}");

//app.Run();
