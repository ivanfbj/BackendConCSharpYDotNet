using cursoDeFundamentosDeEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace cursoDeFundamentosDeEntityFramework;

public class TareasContext : DbContext
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Tarea> Tareas { get; set; }

    public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }

    // Entity Framework sabe que se deben crear tabla con base en las colecciones de Categorias y Tareas
    // creadas al inicio de la clase 'TareasContext' con base en lo modelos Categoria y Tarea.

    // Se sobre escribe el método interno que tiene DbContext, que es el que invoca cuando se está
    // diseñando la base de datos. Se sobreescribe la logica para poder escribir los modelos como
    // se requieran.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Con esta línea se indica que se va a construir o diseñar las restricciones
        // para este modelo de Categoria
        modelBuilder.Entity<Categoria>(categoria =>
        {
            categoria.ToTable("Categoria");
            categoria.HasKey(p => p.CategoriaId);

            categoria.Property(p => p.Nombre).IsRequired().HasMaxLength(150);

            categoria.Property(p => p.Descripcion);
        });

        modelBuilder.Entity<Tarea>(tarea =>
        {
            tarea.ToTable("Tarea");
            tarea.HasKey(p => p.TareaId);

            // Se especifica que: Existe una propiedad llamada Categoria dentro de la clase Tarea (HasOne)
            // y que esa propiedad
            // puede tener relación con multiples Tareas con la propiedad Tareas de la clase Categoria (WithMany)
            // y por ultimo existe una clave foranea para esta relación que es la propiedad CategoriaId de
            // la clase Tarea (HasForeignKey)
            tarea.HasOne(p => p.Categoria).WithMany(p => p.Tareas).HasForeignKey(p => p.CategoriaId);

            tarea.Property(p => p.Titulo).IsRequired().HasMaxLength(200);

            tarea.Property(p => p.Descripcion);

            tarea.Property(p => p.PrioridadTarea);

            tarea.Property(p => p.FechaCreacion);

            // Para omitir una propiedad del modelo para que no sea creado en la base de datos se debe incluir
            tarea.Ignore(p => p.Resumen);
        });

    }


}