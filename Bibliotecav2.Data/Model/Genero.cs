using System;
using System.Collections.Generic;

namespace Bibliotecav2.Data.Model;

public partial class Genero
{
    public int GeneroId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
