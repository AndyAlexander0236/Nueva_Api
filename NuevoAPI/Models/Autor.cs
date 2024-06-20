using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Autor
{
    [Key]
    public int IdAutor { get; set; }

    [Required]
    public string NombreAutor { get; set; }

    // Propiedad de navegación
    public ICollection<Libro> Libros { get; set; }
}
