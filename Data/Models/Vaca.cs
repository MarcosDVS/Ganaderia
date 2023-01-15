using System.ComponentModel.DataAnnotations;

namespace Ganaderia.Data.Models;

public class Vaca
{
    [Key]
    public int VacaId { get; set; }
    public string Raza { get; set; } = "Brahman";
    public string Color { get; set; } = "Rojo";
    public string Sexo { get; set; } = null!;
    public DateTime Nacimiento { get; set; } = DateTime.Now;
    public int? Peso { get; set; } = 45;
    public string? Registro { get; set; }
    public string? Observacion { get; set; }
}

public class Madre:Vaca
{

}

public class Padre:Madre
{

}

public class VacaComprada:Vaca
{
    public int Costo { get; set; } = 25000;
    public DateTime FechaCompra { get; set; } = DateTime.Now;
}