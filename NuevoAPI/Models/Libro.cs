using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Libro
{
    [Key]
    public int IdLibro { get; set; }

    public string Titulo { get; set; }

    public int IdAutor { get; set; }

    // Propiedad de navegación
    [ForeignKey("IdAutor")]
    public Autor Autor { get; set; }
}
