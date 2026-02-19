using Microsoft.EntityFrameworkCore;
using Peliculas.Infraestructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Configura Kestrel para escuchar en todas las IPs en el puerto 8080 (necesario para Docker)
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(8080);
});


// Cadena de conexión a PostgreSQL
builder.Services.AddDbContext<PeliContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlConnection"))); 

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// Aplica las migraciones de EF Core automáticamente al iniciar la aplicación
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PeliContext>();
    db.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
