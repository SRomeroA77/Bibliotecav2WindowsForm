using System;
using System.Collections.Generic;

namespace Bibliotecav2.Data.Model;

public partial class Libro
{
    public int Id { get; set; }

    public string NombreLibro { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public DateTime Annio { get; set; }

    public int? GeneroId { get; set; }

    public virtual Genero? Genero { get; set; }
}
