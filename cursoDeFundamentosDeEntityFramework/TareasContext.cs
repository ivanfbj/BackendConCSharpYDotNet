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


        base.OnModelCreating(modelBuilder);
    }


}