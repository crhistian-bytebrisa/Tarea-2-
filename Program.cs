using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);

// Configuración de la base de datos SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=data.db"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();
app.Run();

// ===================== MODELOS =====================
public class Pelicula
{
    public int Id { get; set; }

    [Required]
    public string Titulo { get; set; }

    [Required]
    public string Genero { get; set; }

    [Required]
    public int Duracion { get; set; }

    [Required]
    public string Clasificacion { get; set; }
}

public class PeliculaCreateDTO
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracion { get; set; }
    public string Clasificacion { get; set; }
}

public class PeliculaUpdateDTO
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracion { get; set; }
    public string Clasificacion { get; set; }
}

// ===================== DB CONTEXT =====================
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Pelicula> Peliculas { get; set; }
}

// ===================== CONTROLLER =====================
[ApiController]
[Route("api/[controller]")]
public class PeliculasController : ControllerBase
{
    private readonly AppDbContext _context;

    public PeliculasController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pelicula>>> Get()
    {
        return await _context.Peliculas.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Pelicula>> GetById(int id)
    {
        var peli = await _context.Peliculas.FindAsync(id);
        if (peli == null) return NotFound();
        return peli;
    }

    [HttpPost]
    public async Task<ActionResult> Post(PeliculaCreateDTO dto)
    {
        var peli = new Pelicula
        {
            Titulo = dto.Titulo,
            Genero = dto.Genero,
            Duracion = dto.Duracion,
            Clasificacion = dto.Clasificacion
        };

        _context.Peliculas.Add(peli);
        await _context.SaveChangesAsync();

        return Ok(peli);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, PeliculaUpdateDTO dto)
    {
        var peli = await _context.Peliculas.FindAsync(id);
        if (peli == null) return NotFound();

        peli.Titulo = dto.Titulo;
        peli.Genero = dto.Genero;
        peli.Duracion = dto.Duracion;
        peli.Clasificacion = dto.Clasificacion;

        await _context.SaveChangesAsync();
        return Ok(peli);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var peli = await _context.Peliculas.FindAsync(id);
        if (peli == null) return NotFound();

        _context.Peliculas.Remove(peli);
        await _context.SaveChangesAsync();

        return Ok("Película eliminada");
    }
}
